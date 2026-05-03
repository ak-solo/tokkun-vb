# 6章 メソッド

## 基礎知識

### Sub と Function

VB.NET のメソッドには **戻り値なし** の `Sub` と **戻り値あり** の `Function` があります。

```vbnet
' Sub: 値を返さない
Sub PrintHello()
    Console.WriteLine("Hello")
End Sub

' Function: 値を返す
Function Double(n As Integer) As Integer
    Return n * 2
End Function
```

---

### 引数（パラメーター）

メソッドに渡す値を **引数** といいます。型を明示して宣言します。

```vbnet
Function Add(a As Integer, b As Integer) As Integer
    Return a + b
End Function

' 呼び出し
Dim result = Add(3, 5)   ' result = 8
```

---

### ByVal と ByRef

VB.NET の引数渡しには **ByVal**（値渡し）と **ByRef**（参照渡し）があります。

```vbnet
' ByVal: 呼び出し元の変数は変わらない（省略時のデフォルト）
Sub DoubleByVal(ByVal n As Integer)
    n = n * 2
End Sub

' ByRef: 呼び出し元の変数を書き換える
Sub DoubleByRef(ByRef n As Integer)
    n = n * 2
End Sub
```

```vbnet
Dim x = 5
DoubleByVal(x)   ' x は 5 のまま
DoubleByRef(x)   ' x は 10 になる
```

ByRef は **2 つの変数を交換（スワップ）** するときに特に役立ちます。

---

### 戻り値

`Return` で値を返します。`Function` の型は `As 型名` で宣言します。

```vbnet
Function Max(a As Integer, b As Integer) As Integer
    If a >= b Then
        Return a
    Else
        Return b
    End If
End Function
```

---

### Boolean を返す関数

条件を判定して `True` / `False` を返す関数は、後から組み合わせて使えます。

```vbnet
Function IsEven(n As Integer) As Boolean
    Return n Mod 2 = 0
End Function

If IsEven(42) Then
    Console.WriteLine("偶数")
End If
```

---

## 練習問題

### 問題 6-1

整数 `n` を受け取り、**2 乗**（`n × n`）を返す関数を実装しなさい。

**解答例:** `Square` という名前で関数を定義し、`Problem6_1` から呼び出します。

```vbnet
Private Shared Function Square(n As Integer) As Integer
    Return n * n
End Function

Public Shared Function Problem6_1(n As Integer) As Integer
    Return Square(n)
End Function
```

---

### 問題 6-2

2 つの整数 `a`、`b` を受け取り、**平均**（整数除算）を返す関数を実装しなさい。

**ヒント:** VB.NET の整数除算は `\` 演算子です（`/` は浮動小数点になります）。

**解答例:** `Average` という名前で関数を定義し、`Problem6_2` から呼び出します。

---

### 問題 6-3

2 つの整数 `a`、`b` を受け取り、**大きい方**を返す関数を実装しなさい。

**解答例:** `Max` という名前で関数を定義し、`Problem6_3` から呼び出します。

---

### 問題 6-4

サイズ `size` を受け取り、`$` で作った **直角三角形** を文字列で返す関数を実装しなさい。

- 1 行目: `$`
- 2 行目: `$$`
- n 行目: `$` × n

各行を改行（`Environment.NewLine`）で結合して返します。

例: `size=3` → `"$" & vbNewLine & "$$" & vbNewLine & "$$$"`

**解答例:** `Problem6_5`（任意の文字で三角形を作る関数）を先に実装しておくと、`Problem6_4` は `Problem6_5` を呼び出す 1 行で書けます。

---

### 問題 6-5

サイズ `size` と文字 `ch`（`Char` 型）を受け取り、**任意の文字で三角形** を返す関数を実装しなさい。

問題 6-4 の `$` を `ch` に置き換えたものです。

**ヒント:** `New String(ch, n)` で `ch` を `n` 個並べた文字列が作れます。

**解答例:** `Triangle` という名前で関数を定義し、`Problem6_5` から呼び出します。`Problem6_4` もこの関数を再利用できます。

---

### 問題 6-6

1〜9 の整数 `n` を受け取り、**九九の `n` の段** を文字列で返す関数を実装しなさい。

- 各行の形式: `"n×1=積"`, `"n×2=積"`, ..., `"n×9=積"`
- 各行を `Environment.NewLine` で結合して返す

例: `n=3` の 1 行目 → `"3×1=3"`

**解答例:** `KukuRow` という名前で関数を定義し、`Problem6_6` から呼び出します。

---

### 問題 6-7

整数 `n` を受け取り、`n` が **素数かどうか** を `Boolean` で返す関数を実装しなさい。

- 素数: 1 とそれ自身以外に約数を持たない 2 以上の整数
- 1 は素数ではない

**ヒント:** 2 から `√n` までの数で割り切れるか調べれば十分です。`Math.Sqrt(n)` で平方根が求まります。

**解答例:** `IsPrime` という名前で関数を定義し、`Problem6_7` から呼び出します。

---

### 問題 6-8

2 つの `Integer` 変数 `a`、`b` を **ByRef** で受け取り、値を **交換（スワップ）** する Sub を実装しなさい。

呼び出し後に `a` と `b` の値が入れ替わっていることを確認します。

**解答例:** `Swap` という名前で Sub を定義し、`Problem6_8` から呼び出します。

---

### 問題 6-9

`Integer` 型配列 `numbers` を受け取り、配列を **昇順に並べ替える（元の配列を直接変更する）** Sub を実装しなさい。

問題 5-8 は新しい配列を返しましたが、この問題は **元の配列を直接書き換えます**。

**解答例:** 問題 6-8 で作った `Problem6_8`（スワップ）を呼び出して選択ソートを実装します。
