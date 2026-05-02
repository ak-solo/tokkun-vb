# 4章 繰り返し

## 基礎知識

### For/Next ループ

回数が決まっているときは `For` ループを使います。

```vbnet
For i = 1 To 5
    Console.WriteLine(i)   ' 1, 2, 3, 4, 5
Next

' Step で増減幅を変更できる
For i = 0 To 8 Step 3
    Console.WriteLine(i)   ' 0, 3, 6
Next
```

---

### While ループ

条件が真の間くり返すときは `While` を使います。

```vbnet
Dim n As Integer = 1
While n <= 5
    Console.WriteLine(n)
    n += 1
End While
```

---

### Do/Loop

`Do` ループは最低 1 回は実行されます（ループ末尾で条件を評価）。

```vbnet
Dim n As Integer = 0
Do
    n += 1
    Console.WriteLine(n)
Loop While n < 5     ' 条件が真の間くり返す
```

ループ先頭で条件を評価したい場合：

```vbnet
Do While n < 5
    ' ...
Loop
```

---

### Exit For / Continue For

`Exit For` でループを途中で抜け、`Continue For` で次の反復にスキップできます。

```vbnet
For i = 1 To 10
    If i = 6 Then Exit For       ' 6 に達したら終了
    If i Mod 2 = 0 Then Continue For  ' 偶数はスキップ
    Console.WriteLine(i)         ' 1, 3, 5
Next
```

---

### 累計・最大・最小

```vbnet
Dim numbers = {5, 3, 8, 1, 9}
Dim sum As Integer = 0
Dim max As Integer = numbers(0)
Dim min As Integer = numbers(0)

For Each n In numbers
    sum += n
    If n > max Then max = n
    If n < min Then min = n
Next
```

---

### ネストしたループ（二重ループ）

ループの中にループを入れると、二次元的な処理ができます。

```vbnet
For i = 1 To 3
    For j = 1 To 3
        Console.Write($"{i * j} ")
    Next
    Console.WriteLine()
Next
```

---

## 練習問題

### 問題 4-1

`"SPAM"` という文字列を 10 個カンマ区切りで並べた文字列を返す関数を実装しなさい。

例: `"SPAM,SPAM,SPAM,SPAM,SPAM,SPAM,SPAM,SPAM,SPAM,SPAM"`

---

### 問題 4-2

九九の三の段（3, 6, 9, … 27）をカンマ区切りの文字列で返す関数を実装しなさい。

例: `"3,6,9,12,15,18,21,24,27"`

---

### 問題 4-3

2 の 1 乗から 8 乗までをカンマ区切りの文字列で返す関数を実装しなさい。

例: `"2,4,8,16,32,64,128,256"`

---

### 問題 4-4

7 の階乗（7!）を計算して返す関数を実装しなさい。

**ヒント:** `n! = 1 × 2 × 3 × … × n`

---

### 問題 4-5

`Integer` 型引数 `n` を受け取り、`"*"` を `n` 個並べた文字列を返す関数を実装しなさい。

例: `n=4` → `"****"`

---

### 問題 4-6

`Integer` 型引数 `n` を受け取り、`0`〜`9` を繰り返す数字を `n` 文字並べた文字列を返す関数を実装しなさい。

例: `n=14` → `"01234567890123"`

---

### 問題 4-7

2 以上の整数 `n` を受け取り、素因数分解した結果をカンマ区切りの文字列で返す関数を実装しなさい。

例: `n=20100` → `"2,2,3,5,5,67"`

---

### 問題 4-8

`Integer` 型引数 `n` を受け取り、`n` が素数なら `True`、そうでなければ `False` を返す関数を実装しなさい。

**ヒント:** 2 から √n までの数で割り切れるか調べます。

---

### 問題 4-9

`Integer` 型引数 `size` を受け取り、`"$"` で作った三角形を改行区切りの文字列で返す関数を実装しなさい。

例: `size=4` のとき

```
$
$$
$$$
$$$$
```

---

### 問題 4-10

`Integer` 型引数 `size` を受け取り、`"X"` で作った × 印を改行区切りの文字列で返す関数を実装しなさい。

例: `size=3` のとき

```
X X
 X 
X X
```

例: `size=5` のとき

```
X   X
 X X 
  X  
 X X 
X   X
```

---

### 問題 4-11

フィボナッチ数列の 1000 以下の項をカンマ区切りの文字列で返す関数を実装しなさい。

最初の 2 項は `0`、`1` とする。

例: `"0,1,1,2,3,5,8,13,21,34,55,89,144,233,377,610,987"`
