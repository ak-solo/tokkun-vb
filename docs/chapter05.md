# 5章 配列

## 基礎知識

### 配列とは

たとえば 40 人分のテストの点数を管理しようとすると、変数を 40 個宣言しなければなりません。

```vbnet
Dim score1 As Integer = 80
Dim score2 As Integer = 60
' ... score3, score4 ...
Dim score40 As Integer = 75   ' 現実的ではない
```

**配列**を使うと、同じ型の値を 1 つの変数にまとめて管理できます。

```vbnet
Dim scores(39) As Integer   ' 40 人分をまとめて管理
scores(0) = 80
scores(1) = 60
' ...
```

配列はループと組み合わせることで真価を発揮します。

```vbnet
' 全員の点数を一気に処理できる
For i = 0 To scores.Length - 1
    Console.WriteLine(scores(i))
Next
```

---

### インデックス（添字）

配列の各要素には **インデックス**（添字）という番号がついています。インデックスは **0 から始まります**（1 からではありません）。

```
インデックス:   0    1    2    3    4
           ┌────┬────┬────┬────┬────┐
 scores =  │ 80 │ 60 │ 90 │ 70 │ 55 │
           └────┴────┴────┴────┴────┘
```

```vbnet
Dim scores = {80, 60, 90, 70, 55}
Console.WriteLine(scores(0))   ' → 80（先頭）
Console.WriteLine(scores(4))   ' → 55（末尾）
Console.WriteLine(scores(2))   ' → 90
```

> **よくあるミス:** インデックスが配列の範囲を超えると実行時エラー（`IndexOutOfRangeException`）になります。要素数 5 の配列で `scores(5)` にアクセスしようとするとエラーです。

---

### 配列の宣言

`Dim 変数名(最大インデックス) As 型名` で宣言します。引数は**最大インデックス**なので、要素数は最大インデックス + 1 です。

```vbnet
Dim numbers(4) As Integer   ' 要素数 5（インデックス 0〜4）
numbers(0) = 10
numbers(4) = 50
```

宣言と同時に初期値を設定することもできます。この書き方では要素数は自動的に決まります。

```vbnet
Dim primes = {2, 3, 5, 7, 11}   ' 要素数 5（インデックス 0〜4）
```

配列の要素数は `.Length` プロパティで取得できます。

```vbnet
Console.WriteLine(primes.Length)   ' → 5
```

---

### 配列の走査

配列の全要素を順番に処理することを**走査**といいます。インデックスを使う方法と `For Each` を使う方法があります。

```vbnet
Dim scores = {80, 60, 90, 70}

' インデックスで走査（インデックスが必要なとき）
For i = 0 To scores.Length - 1
    Console.WriteLine($"{i}番目: {scores(i)}")
Next

' For Each で走査（値だけ取り出すとき・シンプルに書ける）
For Each s In scores
    Console.WriteLine(s)
Next
```

使い分けの目安：
- インデックスを使って別の要素を参照する・インデックス自体が必要 → `For` ループ
- 要素の値だけ取り出せればよい → `For Each`

---

### 逆順アクセス

`Step -1` を使ってインデックスを末尾から遡ることで、逆順に処理できます。

```vbnet
Dim arr = {1, 2, 3, 4, 5}
For i = arr.Length - 1 To 0 Step -1
    Console.Write($"{arr(i)} ")   ' 5 4 3 2 1
Next
```

`arr.Length - 1` が末尾のインデックスです。要素数が変わっても自動的に対応できます。

---

### 2次元配列

1次元配列が「1列に並んだ箱」なら、**2次元配列**は「行と列をもつ表（グリッド）」です。

```
           列0  列1  列2
     行0 ┌────┬────┬────┐
         │  1 │  2 │  3 │
     行1 ├────┼────┼────┤
         │  4 │  5 │  6 │
     行2 └────┴────┴────┘
```

`Dim 変数名(最大行インデックス, 最大列インデックス) As 型名` で宣言します。

```vbnet
Dim matrix(2, 2) As Integer   ' 3行3列
matrix(0, 0) = 1
matrix(1, 2) = 6   ' 1行目・2列目

' 二重ループで走査
For i = 0 To 2
    For j = 0 To 2
        Console.Write($"{matrix(i, j),3}")
    Next
    Console.WriteLine()
Next
```

外側のループが「行」、内側のループが「列」を担当するのが一般的なパターンです。

---

### ジャグ配列（配列の配列）

2次元配列が「行と列が固定されたグリッド」なら、**ジャグ配列**は「各行の長さが異なってもよい配列の配列」です。型は `型名()()` と書きます。

```
triangle(0) → { 1 }          ← 1 列
triangle(1) → { 1, 2 }       ← 2 列
triangle(2) → { 1, 2, 3 }    ← 3 列（長さが違ってもよい）
```

外側の配列を先に宣言し、各要素に内側の配列を代入して使います。

```vbnet
Dim triangle(2) As Integer()        ' 外側：3 行分のスロット
triangle(0) = New Integer() {1}
triangle(1) = New Integer() {1, 2}
triangle(2) = New Integer() {1, 2, 3}

Console.WriteLine(triangle(1)(1))   ' → 2（1 行目の 1 番目）
Console.WriteLine(triangle(2)(0))   ' → 1（2 行目の 0 番目）
```

`List(Of Integer)` で要素を収集してから `.ToArray()` で変換すると、長さが事前に決まらなくても扱いやすいです。

```vbnet
Dim small As New List(Of Integer)
Dim large As New List(Of Integer)
For Each n In {3, 7, 1, 9, 4}
    If n < 5 Then
        small.Add(n)
    Else
        large.Add(n)
    End If
Next

Dim result(1) As Integer()
result(0) = small.ToArray()   ' {3, 1, 4}
result(1) = large.ToArray()   ' {7, 9}
```

---

### 動的な配列収集（List(Of T)）

通常の配列は宣言時に要素数を決めなければなりません。条件でフィルタリングするなど、**最終的な要素数が事前にわからない場合**は `List(Of T)` が便利です。

```vbnet
Dim evens As New List(Of Integer)   ' 空のリストを作成
For Each n In {1, 2, 3, 4, 5, 6}
    If n Mod 2 = 0 Then evens.Add(n)   ' 条件を満たすものだけ追加
Next
Dim result = evens.ToArray()   ' 配列に変換 → {2, 4, 6}
```

`T` には型名（`Integer`、`String` など）を入れます。主なメソッドは以下の通りです。

| 操作 | コード例 |
|---|---|
| 末尾に追加 | `list.Add(value)` |
| 要素数を取得 | `list.Count` |
| 配列に変換 | `list.ToArray()` |

---

### 配列のソート

`Array.Sort` を使うと昇順に並び替えられます。**元の配列自体が変更される**ことに注意してください。

```vbnet
Dim arr = {5, 3, 8, 1}
Array.Sort(arr)   ' arr の中身が {1, 3, 5, 8} に変わる
```

元の配列を変えずに並び替えた別の配列を作りたい場合は、先にコピーします。

```vbnet
Dim original = {5, 3, 8, 1}
Dim sorted = DirectCast(original.Clone(), Integer())
Array.Sort(sorted)   ' sorted = {1, 3, 5, 8}、original はそのまま
```

---

### 配列・リストの文字列化（String.Join）

ループで `&=` を使って文字列を組み立てる代わりに、`String.Join` を使うとシンプルに書けます。

```vbnet
Dim words = {"apple", "banana", "cherry"}
Dim result = String.Join(", ", words)   ' "apple, banana, cherry"
```

`List(Of String)` もそのまま渡せます。改行区切りの文字列を作るときにも便利です。

```vbnet
Dim lines As New List(Of String)
lines.Add("1行目")
lines.Add("2行目")
lines.Add("3行目")
Dim text = String.Join(Environment.NewLine, lines)
' "1行目" & vbNewLine & "2行目" & vbNewLine & "3行目"
```

---

## 練習問題

### 問題 5-1

`Integer` 型配列 `numbers` を受け取り、各要素を **2 倍** にした新しい配列を返す関数を実装しなさい。

---

### 問題 5-2

`Integer` 型配列 `numbers` を受け取り、**逆順** にした新しい配列を返す関数を実装しなさい。

---

### 問題 5-3

`Integer` 型配列 `numbers` を受け取り、偶数と奇数に分類して返す関数を実装しなさい。

- `result(0)` = 偶数のみの配列（入力順を保つ）
- `result(1)` = 奇数のみの配列（入力順を保つ）

戻り値の型: `Integer()()` （ジャグ配列。基礎知識の「ジャグ配列」を参照）

---

### 問題 5-4

`Integer` 型配列 `numbers` を受け取り、以下の条件のどちらかを満たすまで要素を収集し、収集した要素の配列を返す関数を実装しなさい。

- 合計が 100 を超えた
- 10 個収集した

**ヒント:** `List(Of Integer)` を使うと要素数が不定でも収集できます。

---

### 問題 5-5

`Integer` 型引数 `value` を受け取り、16 桁の 2 進数表現を `Integer` 配列（要素数 16）で返す関数を実装しなさい。

- `result(0)` = 最上位ビット（MSB）
- `result(15)` = 最下位ビット（LSB）

例: `value=5` → `{0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,1}`

**ヒント:** 右シフト演算子 `>>` とビット積 `And 1` を使う方法、または `Mod 2` と `\2` を繰り返す方法があります。

---

### 問題 5-6

9×9 の九九表を 2 次元 `Integer` 配列で返す関数を実装しなさい。

- `result(i, j)` = `(i+1) × (j+1)`（0 始まりインデックス）

**ヒント:** 二重の `For` ループで各要素に値を代入します。

---

### 問題 5-7

1〜9 の整数 `x`、`y` を受け取り、**問題 5-6 で作成した九九配列を内部で使用して** その積を返す関数を実装しなさい。

---

### 問題 5-8

`Integer` 型配列 `numbers` を受け取り、**昇順（小さい順）** に並べ替えた新しい配列を返す関数を実装しなさい。

---

### 問題 5-9

`Integer` 型配列 `numbers` を受け取り、その平均値（整数）を返す関数を実装しなさい。

※ 小数点以下は切り捨ててよい。

---

### 問題 5-10

`Integer` 型配列 `results`（0=負け、1=勝ち）を受け取り、勝ち数と負け数を配列で返す関数を実装しなさい。

- `result(0)` = 勝ち数
- `result(1)` = 負け数

---

### 問題 5-11

各回の得点を格納した配列（9 要素）を受け取り、合計点を返す関数を実装しなさい。

**`Problem5_11_TotalScore(scores As Integer()) As Integer`**
- 配列要素の合計を返す

---

### 問題 5-12

`Integer` 型配列 `numbers` を受け取り、最大値を返す関数を実装しなさい。

---

### 問題 5-13

`Integer` 型配列 `numbers` を受け取り、最大値と最小値を配列で返す関数を実装しなさい。

- `result(0)` = 最大値
- `result(1)` = 最小値

---

### 問題 5-14

`Integer` 型配列 `numbers` を受け取り、合計が 100 を超えたところで停止し、そのときの合計値を返す関数を実装しなさい。

---

### 問題 5-15

投球の種類（1=ストライク、2=ボール）を格納した `Integer` 型配列 `pitches` を受け取り、3 ストライクまたは 4 ボールになった時点で停止し、結果を `"Nストライク,Mボール"` の形式で返す関数を実装しなさい。

---

### 問題 5-16

問題 5-15 にファウル（3）を追加した関数を実装しなさい。

- ファウルは 2 ストライクまではストライクにカウントする
- 2 ストライクのときのファウルはストライク数を増やさない（三振にならない）

---

### 問題 5-17

`Integer` 型配列 `numbers` を受け取り、最初に現れる `0` の手前までの合計を返す関数を実装しなさい。

※ `0` は合計に含めない。

---

### 問題 5-18

`Integer` 型配列 `numbers` を受け取り、最初に現れる `0` の手前までの平均値（整数）を返す関数を実装しなさい。

※ `0` は平均に含めない。小数点以下は切り捨て。
