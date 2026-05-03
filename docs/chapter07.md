# 7章 クラスⅠ

## 基礎知識

### クラスとインスタンス

**クラス**は「もののひな型（設計図）」です。クラスから作られた実体を**インスタンス**といいます。

```vbnet
' クラス定義（設計図）
Public Class Dog
    ' ...
End Class

' インスタンスの生成（実体を作る）
Dim pochi As New Dog()
Dim koro As New Dog()
' pochi と koro は独立した別々のオブジェクト
```

---

### フィールド（メンバー変数）

クラスが持つデータを**フィールド**（メンバー変数）として宣言します。
外部から直接アクセスさせないために `Private` にするのが基本です。

```vbnet
Public Class Dog
    Private mName As String = ""    ' 名前（初期値は空文字）
    Private mAge As Integer = 0     ' 年齢（初期値は 0）
End Class
```

---

### プロパティ

フィールドへの読み書きを制御する仕組みが**プロパティ**です。
`Get`（読み取り）と `Set`（書き込み）をまとめて定義します。

```vbnet
Public Property Name() As String
    Get
        Return mName          ' 読み取り
    End Get
    Set(value As String)
        mName = value         ' 書き込み
    End Set
End Property
```

```vbnet
Dim dog As New Dog()
dog.Name = "ポチ"            ' Set が呼ばれる
Console.WriteLine(dog.Name)  ' Get が呼ばれる → "ポチ"
```

読み取り専用にするときは `ReadOnly Property` を使います。

```vbnet
Public ReadOnly Property Breed() As String
    Get
        Return mBreed
    End Get
End Property
```

---

### コンストラクタ（Sub New）

インスタンス生成時に自動で呼ばれるメソッドが**コンストラクタ**です。
`Sub New` という名前で定義します。

```vbnet
Public Class Dog
    Private mBreed As String = ""

    ' 引数なしコンストラクタ
    Public Sub New()
    End Sub

    ' 引数ありコンストラクタ
    Public Sub New(breed As String)
        mBreed = breed
    End Sub
End Class
```

```vbnet
Dim dog1 As New Dog()          ' 引数なしで生成
Dim dog2 As New Dog("柴犬")    ' 犬種を指定して生成
```

---

### メソッド

クラスの動作を定義するのが**メソッド**です。フィールドやプロパティを使って処理します。

```vbnet
Public Function ShowProfile() As String
    Return $"{mBreed}: {mName} ({mAge}歳)"
End Function
```

---

### メソッドのオーバーロード

同じ名前で**引数のリストが異なる**メソッドを複数定義できます。これを**オーバーロード**といいます。

```vbnet
' 引数なし → 合計枚数を返す
Public Overloads Function GetCount() As Integer
    ' ...
End Function

' 引数あり → 指定した種類の枚数を返す
Public Overloads Function GetCount(denomination As Integer) As Integer
    ' ...
End Function
```

---

## 練習問題

### 問題 7-1

`Dog` クラスに `Name`（`String`）プロパティを実装しなさい。

- `Private` フィールド `mName` を `""` で初期化する
- `Name` プロパティで `mName` を読み書きできるようにする

また、`Problem7_1(name As String) As String` を実装しなさい。`Dog` をインスタンス化し、`Name` に `name` をセットして `Name` を返します。

**解答例:**

```vbnet
Public Shared Function Problem7_1(name As String) As String
    Dim dog As New Dog()
    dog.Name = name
    Return dog.Name
End Function
```

---

### 問題 7-2

`Dog` クラスに `Age`（`Integer`）プロパティを追加しなさい。

- `Private` フィールド `mAge` を `0` で初期化する
- `Age` プロパティで `mAge` を読み書きできるようにする

また、`Problem7_2(name As String, age As Integer) As String` を実装しなさい。`Dog` をインスタンス化し、`Name` と `Age` をセットして `"{Name},{Age}"` 形式で返します。

例: `name="ポチ"`, `age=3` → `"ポチ,3"`

---

### 問題 7-3

`Dog` インスタンスを 2 つ作成し、それぞれ独立したデータを持てることを確認しなさい。

- 1 つ目に `Name = "ポチ"`、2 つ目に `Name = "コロ"` を設定する
- 1 つ目の `Name` を `"タロ"` に変更しても、2 つ目には影響しないことを確認する

**ポイント:** クラスから生成したインスタンスはそれぞれ独立したデータを持ちます。

また、`Problem7_3() As String` を実装しなさい。上記の手順を実行し、変更後の `"{dog1.Name},{dog2.Name}"` を返します。インスタンスが独立していれば `"タロ,コロ"` が返ります。

---

### 問題 7-4

`Dog` クラスに以下を追加しなさい。

- `Private` フィールド `mBreed`（犬種、`String`）を `""` で初期化する
- 犬種を引数に取るコンストラクタ `New(breed As String)` を実装する
- 犬種を読み取り専用で返す `Breed` プロパティ（`ReadOnly`）を実装する
- `ShowProfile()` を実装し、`"犬種: 名前 (年齢歳)"` 形式の文字列を返す

また、`Problem7_4(breed As String, name As String, age As Integer) As String` を実装しなさい。`New Dog(breed)` でインスタンスを生成し、`Name` と `Age` をセットして `ShowProfile()` の結果を返します。

例: `breed="柴犬"`, `name="ポチ"`, `age=3` → `"柴犬: ポチ (3歳)"`

---

### 問題 7-5

硬貨の入れ物を表す `CoinCase` クラスを実装しなさい。

対応する硬貨: **500 円・100 円・50 円・10 円・5 円・1 円**

| メソッド | 引数 | 戻り値 | 説明 |
|---------|------|--------|------|
| `AddCoins` | `denomination As Integer`、`count As Integer` | なし | 指定種類の硬貨を枚数分追加する。無効な種類は無視する |
| `GetCount` | `denomination As Integer` | `Integer` | 指定種類の硬貨の枚数を返す |
| `GetAmount` | なし | `Integer` | 全硬貨の合計金額を返す |

**ヒント:** `Dictionary(Of Integer, Integer)` で硬貨の種類と枚数を管理すると便利です。コンストラクタで 6 種類の硬貨を 0 枚で初期化しておきましょう。

また、`Problem7_5(denomination As Integer, count As Integer) As Integer` を実装しなさい。`CoinCase` をインスタンス化して指定の硬貨を追加し、合計金額を返します。

例: `denomination=100`, `count=5` → `500`

---

### 問題 7-6

`CoinCase` クラスにオーバーロードメソッドを追加しなさい。

| メソッド | 引数 | 戻り値 | 説明 |
|---------|------|--------|------|
| `GetCount` | なし | `Integer` | 全硬貨の合計枚数を返す |
| `GetAmount` | `denomination As Integer` | `Integer` | 指定種類の硬貨の合計金額を返す |

問題 7-5 の `GetCount(denomination)` と `GetAmount()` と同名ですが、引数が異なるオーバーロードとして実装します。

**ヒント:** オーバーロードするときは `Overloads` キーワードを両方のメソッドに付けます。

また、`Problem7_6(denomination As Integer, count As Integer) As String` を実装しなさい。`CoinCase` をインスタンス化して指定の硬貨を追加し、`"{合計枚数},{指定種の合計金額}"` を返します。

例: `denomination=100`, `count=4` → `"4,400"`
