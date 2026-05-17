# 7章 クラスⅠ

## 基礎知識

### オブジェクト指向とは

これまでは変数と関数（メソッド）を別々に扱ってきました。しかし現実のものごとは「データ」と「操作」がセットになっています。

たとえば「犬」を考えると、
- **データ:** 名前・年齢・犬種
- **操作:** 吠える・プロフィールを表示する

**オブジェクト指向プログラミング**（OOP）とは、こうした「データ」と「操作」をひとまとめにして**オブジェクト**として扱う考え方です。

```
┌────────────────────────────┐
│          Dog オブジェクト   │
│  データ: name, age, breed  │
│  操作: Speak(), ShowProfile() │
└────────────────────────────┘
```

こうすることで、関連するものが一か所にまとまりコードが整理されます。また、同じ種類のオブジェクトを何個でも独立して作れます。

---

### クラスとインスタンス

**クラス**は「もののひな型（設計図）」です。クラスから作られた実体を**インスタンス**（オブジェクト）といいます。

```
クラス（設計図）         インスタンス（実体）
┌──────────┐    New    ┌──────────┐  ┌──────────┐
│   Dog    │ ────────▶ │  pochi   │  │  koro    │
│  name    │           │ name=ポチ│  │ name=コロ│
│  age     │           │ age=3   │  │ age=5   │
└──────────┘           └──────────┘  └──────────┘
```

```vbnet
' クラス定義（設計図）
Public Class Dog
    ' ...
End Class

' インスタンスの生成（New で実体を作る）
Dim pochi As New Dog()
Dim koro As New Dog()
' pochi と koro は独立した別々のオブジェクト
' 一方を変更しても、もう一方には影響しない
```

---

### フィールド（メンバー変数）

クラスが持つデータを**フィールド**（メンバー変数）として宣言します。フィールドはインスタンスごとに独立した値を持ちます。

外部から直接アクセスさせないために `Private` にするのが基本です（後述のカプセル化）。

```vbnet
Public Class Dog
    Private mName As String = ""    ' 名前（初期値は空文字）
    Private mAge As Integer = 0     ' 年齢（初期値は 0）
End Class
```

`Private` にすると、クラスの外から `dog.mName = "ポチ"` のように直接書き換えることができなくなります。

---

### カプセル化とプロパティ

フィールドを `Private` にして外から直接アクセスできないようにする考え方を**カプセル化**といいます。代わりに**プロパティ**を通じて読み書きを制御します。

なぜカプセル化するのかというと、たとえば年齢に `-5` のような不正な値が入るのを防いだり、値が変わったときに他の処理を連動させたりできるからです。

```vbnet
Public Property Age() As Integer
    Get
        Return mAge
    End Get
    Set(value As Integer)
        If value >= 0 Then mAge = value   ' 負の値は無視する
    End Set
End Property
```

`Get`（読み取り）と `Set`（書き込み）をまとめて定義します。

```vbnet
Public Property Name() As String
    Get
        Return mName
    End Get
    Set(value As String)
        mName = value
    End Set
End Property
```

```vbnet
Dim dog As New Dog()
dog.Name = "ポチ"            ' Set が呼ばれる
Console.WriteLine(dog.Name)  ' Get が呼ばれる → "ポチ"
```

読み取り専用にするときは `ReadOnly Property` を使います（`Set` を書かない）。

```vbnet
Public ReadOnly Property Breed() As String
    Get
        Return mBreed
    End Get
End Property
```

---

### コンストラクタ（Sub New）

`New Dog()` と書いたときに**自動で呼ばれる**特別なメソッドが**コンストラクタ**です。`Sub New` という名前で定義します。インスタンスの初期設定に使います。

```vbnet
Public Class Dog
    Private mBreed As String = ""

    ' 引数なしコンストラクタ（デフォルト）
    Public Sub New()
    End Sub

    ' 引数ありコンストラクタ（犬種を指定して生成）
    Public Sub New(breed As String)
        mBreed = breed
    End Sub
End Class
```

```vbnet
Dim dog1 As New Dog()          ' 引数なしで生成 → mBreed = ""
Dim dog2 As New Dog("柴犬")    ' 引数ありで生成 → mBreed = "柴犬"
```

コンストラクタを定義しない場合、引数なしのコンストラクタが自動的に用意されます。

---

### Me キーワード

`Me` はそのメソッドを呼び出している**自分自身のインスタンス**を指します。フィールド名と引数名が同じときなど、どちらを指すか明確にしたい場面で使います。

```vbnet
Public Sub New(name As String)
    Me.mName = name   ' Me.mName = フィールド、name = 引数
End Sub
```

---

### メソッド

クラスの動作を定義するのが**メソッド**です。フィールドやプロパティを使って処理します。クラスの外からは `インスタンス名.メソッド名()` で呼び出します。

```vbnet
Public Function ShowProfile() As String
    Return $"{mBreed}: {mName} ({mAge}歳)"
End Function
```

```vbnet
Dim dog As New Dog("柴犬")
dog.Name = "ポチ"
dog.Age = 3
Console.WriteLine(dog.ShowProfile())   ' → "柴犬: ポチ (3歳)"
```

---

### Dictionary（辞書型）

`Dictionary(Of TKey, TValue)` はキーと値のペアを管理するコレクションです。配列が「インデックス（0, 1, 2…）→ 値」なのに対し、Dictionary は**任意のキー → 値**で管理できます。

```vbnet
' 宣言・生成（キーが Integer、値が Integer の例）
Dim d As New Dictionary(Of Integer, Integer)()

' 要素の追加
d.Add(100, 0)    ' キー=100、値=0 を追加
d.Add(500, 0)    ' キー=500、値=0 を追加

' 値の読み書き（配列と同じように [] で指定）
d(100) = 3                   ' キー 100 の値を 3 に上書き
d(100) += 1                  ' キー 100 の値を +1
Console.WriteLine(d(100))    ' → 4

' キーの存在確認
If d.ContainsKey(50) Then
    Console.WriteLine("50 円はある")
End If
```

```vbnet
' For Each でキーと値を順番に取り出す
For Each kvp As KeyValuePair(Of Integer, Integer) In d
    Console.WriteLine($"キー={kvp.Key}, 値={kvp.Value}")
Next
```

存在しないキーにアクセスしようとすると実行時エラーになるため、`ContainsKey` で確認してから使うのが安全です。

---

### メソッドのオーバーロード

同じ名前で**引数のリストが異なる**メソッドを複数定義できます。これを**オーバーロード**といいます。呼び出し側は渡す引数によって自動的に適切なメソッドが選ばれます。

```vbnet
' 引数なし → 全硬貨の合計枚数を返す
Public Overloads Function GetCount() As Integer
    ' ...
End Function

' 引数あり → 指定した種類の枚数を返す
Public Overloads Function GetCount(denomination As Integer) As Integer
    ' ...
End Function
```

```vbnet
Dim c As New CoinCase()
c.GetCount()        ' 引数なし版が呼ばれる
c.GetCount(100)     ' 引数あり版が呼ばれる
```

引数の型か数が異なれば別のメソッドとして定義できます。戻り値の型だけが違うオーバーロードはできません。

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
