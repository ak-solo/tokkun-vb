# 9章 文字列・日付操作

## 基礎知識

### 文字列メソッド

VB.NET の `String` 型には、文字列を操作するための便利なメソッドが多く用意されています。
文字列は**イミュータブル（不変）**なので、メソッドを呼び出しても元の文字列は変わらず、常に新しい文字列が返ります。

---

#### Length（文字数）

`Length` プロパティは文字列の文字数を返します。スペースや記号も 1 文字として数えます。

```vbnet
Dim s As String = "Hello"
Console.WriteLine(s.Length)  ' 5

Dim empty As String = ""
Console.WriteLine(empty.Length)  ' 0
```

---

#### Trim / ToUpper / ToLower

`Trim()` は文字列の**先頭と末尾にある空白文字**（スペース・タブ・改行）を取り除いた新しい文字列を返します。
`TrimStart()` は先頭のみ、`TrimEnd()` は末尾のみ取り除きます。

`ToUpper()` はすべての文字を**大文字**に、`ToLower()` は**小文字**に変換した新しい文字列を返します。

```vbnet
Dim s As String = "  Hello World  "

Console.WriteLine(s.Trim())          ' "Hello World"（前後の空白を削除）
Console.WriteLine(s.TrimStart())     ' "Hello World  "（先頭の空白のみ削除）
Console.WriteLine(s.TrimEnd())       ' "  Hello World"（末尾の空白のみ削除）

Console.WriteLine("hello".ToUpper()) ' "HELLO"
Console.WriteLine("HELLO".ToLower()) ' "hello"
```

---

#### Contains / StartsWith / EndsWith

いずれも `Boolean` を返す検索メソッドです。大文字・小文字を**区別**します。

- `Contains(value)` ― `value` が文字列内に含まれているか
- `StartsWith(value)` ― 文字列が `value` で始まっているか
- `EndsWith(value)` ― 文字列が `value` で終わっているか

```vbnet
Dim s As String = "Hello, VB.NET World"

Console.WriteLine(s.Contains("VB.NET"))      ' True
Console.WriteLine(s.StartsWith("Hello"))     ' True
Console.WriteLine(s.EndsWith("World"))       ' True
Console.WriteLine(s.StartsWith("world"))     ' False（大文字・小文字を区別する）
```

---

#### IndexOf / Substring

`IndexOf(value)` は、`value` が**最初に現れる位置**（0 始まりのインデックス）を `Integer` で返します。
見つからなかった場合は `-1` を返します。

`Substring(startIndex)` は `startIndex` 文字目以降をすべて切り出します。
`Substring(startIndex, length)` は `startIndex` 文字目から `length` 文字分を切り出します。

```vbnet
Dim s As String = "user@example.com"

Dim idx As Integer = s.IndexOf("@"c)         ' 4
Dim user As String   = s.Substring(0, idx)   ' "user"（0文字目から idx 文字分）
Dim domain As String = s.Substring(idx + 1)  ' "example.com"（idx+1 文字目以降すべて）

' 見つからない場合
Dim notFound As Integer = s.IndexOf("!"c)  ' -1
```

---

#### Replace

`Replace(oldValue, newValue)` は、文字列内で `oldValue` に**一致するすべての箇所**を `newValue` に置き換えた新しい文字列を返します。
一致する箇所がなければ元の文字列をそのまま返します。

```vbnet
Dim s As String = "Hello World"

Console.WriteLine(s.Replace("World", "VB.NET")) ' "Hello VB.NET"
Console.WriteLine(s.Replace("l", "L"))          ' "HeLLo WorLd"（一致するすべてを置換）
Console.WriteLine(s.Replace("x", "Y"))          ' "Hello World"（一致なし → そのまま）
```

---

#### Split / String.Join

`Split(separator)` は、区切り文字で文字列を分割した `String` 配列を返します。
区切り文字自体は結果に含まれません。

`String.Join(separator, values)` は配列やコレクションの要素を `separator` で連結した文字列を返します。

```vbnet
Dim csv As String = "apple, banana, cherry"

Dim parts As String() = csv.Split(","c)  ' {"apple", " banana", " cherry"}（',' で分割）

' String.Join で再結合
Dim joined As String = String.Join(" / ", {"a", "b", "c"})  ' "a / b / c"
```

---

#### String.IsNullOrEmpty / IsNullOrWhiteSpace

文字列が「空かどうか」を調べる静的メソッドです。

- `String.IsNullOrEmpty(s)` ― `s` が `Nothing` または空文字列 `""` のとき `True`
- `String.IsNullOrWhiteSpace(s)` ― `Nothing`・空文字列・空白文字のみのとき `True`

```vbnet
Console.WriteLine(String.IsNullOrEmpty(""))        ' True
Console.WriteLine(String.IsNullOrEmpty("  "))      ' False（空白文字がある）
Console.WriteLine(String.IsNullOrWhiteSpace("  ")) ' True（空白のみ）
Console.WriteLine(String.IsNullOrWhiteSpace("hi")) ' False
```

---

### DateTime（日付・時刻）

`DateTime` 型は日付と時刻を表します。

---

#### DateTime の作成とプロパティ

```vbnet
Dim dt As New DateTime(2024, 3, 15)  ' 2024年3月15日

Console.WriteLine(dt.Year)       ' 2024
Console.WriteLine(dt.Month)      ' 3
Console.WriteLine(dt.Day)        ' 15
Console.WriteLine(dt.DayOfWeek)  ' Friday
```

---

#### 日付の演算

```vbnet
Dim dt As New DateTime(2024, 1, 1)

Dim nextWeek  As DateTime = dt.AddDays(7)    ' 2024/1/8
Dim nextMonth As DateTime = dt.AddMonths(1)  ' 2024/2/1
Dim nextYear  As DateTime = dt.AddYears(1)   ' 2025/1/1
```

---

#### 日付の差分

```vbnet
Dim fromDate As New DateTime(2024, 1, 1)
Dim toDate   As New DateTime(2024, 1, 10)

Dim diff As TimeSpan = toDate - fromDate
Console.WriteLine(diff.Days)  ' 9
```

---

#### 日付のフォーマット

```vbnet
Dim dt As New DateTime(2024, 3, 5)

Console.WriteLine(dt.ToString("yyyy/MM/dd"))    ' "2024/03/05"
Console.WriteLine(dt.ToString("yyyy年M月d日"))  ' "2024年3月5日"
Console.WriteLine(dt.ToString("MM/dd"))         ' "03/05"
```

`M` は月を 1 桁/2 桁で、`MM` は常に 2 桁で出力します（`d`/`dd` も同様）。

---

## 練習問題

### 問題 9-1

文字列 `input` を受け取り、前後の空白を取り除いてから **すべて大文字** に変換した文字列を返す関数を実装しなさい。

例: `"  hello world  "` → `"HELLO WORLD"`

**ヒント:** `Trim()` → `ToUpper()` の順に適用します。

---

### 問題 9-2

文字列 `text` と区切り文字 `delimiter`（`Char` 型）を受け取り、**最初に区切り文字が現れる位置より前** の部分文字列を返す関数を実装しなさい。区切り文字が存在しない場合は `text` をそのまま返すこと。

例: `"user@example.com", "@"c` → `"user"`
例: `"hello", "@"c` → `"hello"`

**ヒント:** `IndexOf` で位置を取得し、`-1` の場合は元の文字列を、それ以外は `Substring` で切り出します。

---

### 問題 9-3

カンマ区切りの文字列 `csv` を受け取り、各要素の前後の空白を除去した `String` 配列を返す関数を実装しなさい。

例: `"apple, banana, cherry"` → `{"apple", "banana", "cherry"}`

**ヒント:** `Split(","c)` で分割した後、各要素に `Trim()` を適用します。

---

### 問題 9-4

文字列 `text` 内に含まれる `oldWord` をすべて `newWord` に置き換えた文字列を返す関数を実装しなさい。

例: `"Hello World World", "World", "VB.NET"` → `"Hello VB.NET VB.NET"`

**ヒント:** `Replace` は一致するすべての箇所を置換します。

---

### 問題 9-5

文字列の検索に関する次の 3 つの関数を実装しなさい。

- `Problem9_5_StartsWith` ― `text` が `prefix` で始まっていれば `True` を返す
- `Problem9_5_EndsWith` ― `text` が `suffix` で終わっていれば `True` を返す
- `Problem9_5_Contains` ― `text` に `keyword` が含まれていれば `True` を返す

例（StartsWith）: `"Hello, World", "Hello"` → `True`
例（EndsWith）: `"Hello, World", "World"` → `True`
例（Contains）: `"Hello, World", "VB.NET"` → `False`

---

### 問題 9-6

`DateTime` 型の日付 `date` を受け取り、その曜日を **日本語**（`"月曜日"`〜`"日曜日"`）で返す関数を実装しなさい。

例: `New DateTime(2024, 1, 1)` （月曜日）→ `"月曜日"`
例: `New DateTime(2024, 1, 7)` （日曜日）→ `"日曜日"`

**ヒント:** `date.DayOfWeek` は `DayOfWeek` 列挙型（`Monday`, `Tuesday`, ...）を返します。`Select Case` で変換しましょう。

---

### 問題 9-7

2 つの `DateTime` 型の日付 `from` と `toDate` を受け取り、その差の **日数**（`Integer`）を返す関数を実装しなさい。`toDate` は常に `from` 以降の日付が渡されると仮定してよい。

例: `from=2024/1/1, toDate=2024/1/10` → `9`
例: `from=2024/1/1, toDate=2024/3/1` → `60`

**ヒント:** `(toDate - from).Days` で `TimeSpan` の日数部分を取得できます。

---

### 問題 9-8

`DateTime` 型の日付 `date` を受け取り、`"yyyy年M月d日"` の形式に整形した文字列を返す関数を実装しなさい。

例: `New DateTime(2024, 3, 5)` → `"2024年3月5日"`
例: `New DateTime(2024, 12, 31)` → `"2024年12月31日"`

**ヒント:** `date.ToString("yyyy年M月d日")` を使います。

---

### 問題 9-9

`DateTime` 型の日付 `date` と整数 `days` を受け取り、`days` 日後の日付を `"yyyy/MM/dd"` の形式に整形した文字列を返す関数を実装しなさい。

例: `New DateTime(2024, 1, 1), 30` → `"2024/01/31"`
例: `New DateTime(2024, 1, 31), 1` → `"2024/02/01"`

**ヒント:** `AddDays(days)` で日付を進め、`ToString("yyyy/MM/dd")` で整形します。
