# 8章 クラスⅡ

## 基礎知識

### 継承（Inherits）

既存のクラスを**ベースクラス（親クラス）**として、その機能を引き継ぐ新しいクラスを作れます。
これを**継承**といい、`Inherits` キーワードで宣言します。

```vbnet
Public Class Animal
    Public Property Name As String = ""
    Public Property Age As Integer = 0
End Class

' Animal を継承した Cat クラス
Public Class Cat
    Inherits Animal

    Public Function Sleep() As String
        Return "スースー"
    End Function
End Class
```

```vbnet
Dim cat As New Cat()
cat.Name = "タマ"     ' Animal のプロパティを Cat でも使える
Console.WriteLine(cat.Name)
Console.WriteLine(cat.Sleep())
```

---

### コンストラクタと MyBase.New

派生クラスのコンストラクタでは、`MyBase.New(...)` でベースクラスのコンストラクタを呼び出します。

```vbnet
Public Class Animal
    Public Sub New(name As String, age As Integer)
        Me.Name = name
        Me.Age = age
    End Sub
    Public Property Name As String
    Public Property Age As Integer
End Class

Public Class Cat
    Inherits Animal

    Public Sub New(name As String, age As Integer)
        MyBase.New(name, age)   ' Animal のコンストラクタを呼ぶ
    End Sub
End Class
```

```vbnet
Dim cat As New Cat("タマ", 2)   ' name="タマ"、age=2 で初期化
```

---

### オーバーライド（Overrides / Overridable）

ベースクラスのメソッドを派生クラスで**上書き**できます。

- ベースクラスのメソッドに `Overridable` を付ける
- 派生クラスのメソッドに `Overrides` を付ける

```vbnet
Public Class Animal
    Public Overridable Function Speak() As String
        Return "......"    ' デフォルトの鳴き声
    End Function
End Class

Public Class Cat
    Inherits Animal

    Public Overrides Function Speak() As String
        Return "ニャー"    ' Cat 専用の鳴き声
    End Function
End Class

Public Class Dog
    Inherits Animal

    Public Overrides Function Speak() As String
        Return "ワンワン"    ' Dog 専用の鳴き声
    End Function
End Class
```

---

### ポリモーフィズム

ベースクラス型の変数に、派生クラスのインスタンスを代入できます。
メソッドを呼び出すと、**実際のインスタンスの型**に応じたメソッドが実行されます。

```vbnet
Dim animals As Animal() = {
    New Cat("タマ", 2),
    New Dog("ポチ", 3),
    New Cat("ミケ", 1)
}

For Each a In animals
    Console.WriteLine(a.Speak())   ' Cat なら "ニャー"、Dog なら "ワンワン"
Next
```

`animals` の型は `Animal()` ですが、実行時には Cat や Dog それぞれの `Speak` が呼ばれます。
これが**ポリモーフィズム（多態性）**です。

---

## 練習問題

> **注意:** 問題 8-1 以降の Animal クラスはすでに実装済みです。骨格ファイルの Animal を変更せず、Cat と Dog を実装してください。

### 問題 8-1

`Animal` クラスを継承した `Cat` クラスを実装しなさい。

- コンストラクタ `New(name As String, age As Integer)` で `MyBase.New(name, age)` を呼ぶ
- `Sleep()` メソッドを実装し、`"スースー"` を返す

---

### 問題 8-2

`Animal` クラスを継承した `Dog` クラスを実装しなさい。

- コンストラクタ `New(name As String, age As Integer)` で `MyBase.New(name, age)` を呼ぶ
- `Run()` メソッドを実装し、`"トコトコ"` を返す

---

### 問題 8-3

`Cat` クラスに `Speak()` メソッドをオーバーライドして実装しなさい。

- `Animal.Speak()` のデフォルト実装は `"......"` を返す
- `Cat.Speak()` は `"ニャー"` を返す

---

### 問題 8-4

`Dog` クラスに `Speak()` メソッドをオーバーライドして実装しなさい。

- `Dog.Speak()` は `"ワンワン"` を返す

---

### 問題 8-5

`Animal` 型の配列を使って、`Cat` と `Dog` のインスタンスをまとめて扱いなさい。

- 要素数 4 の `Animal` 配列を作成する
- 偶数インデックス（0、2）に `Cat`、奇数インデックス（1、3）に `Dog` を格納する
- ループで各要素の `ShowProfile()` と `Speak()` を呼ぶ

**ポイント:** `Animal` 型の変数に `Cat`/`Dog` を代入しても、`Speak()` は実際のクラスのものが呼ばれます。これがポリモーフィズムです。
