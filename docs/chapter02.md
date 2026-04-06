# 2章 引数と戻り値

## 基礎知識

### 関数に値を渡す（引数）

関数は**引数**を通じて値を受け取ることができます。引数は関数を呼び出す側から渡す「入力値」です。

```vbnet
Function Double(x As Integer) As Integer
    Return x * 2
End Function

Console.WriteLine(Double(5))   ' → 10
Console.WriteLine(Double(3))   ' → 6
```

引数を変えるだけで同じ関数を何度でも使いまわせます。

---

### 引数を複数定義する

カンマ区切りで複数の引数を定義できます。

```vbnet
Function Sum(x As Integer, y As Integer) As Integer
    Return x + y
End Function

Console.WriteLine(Sum(3, 7))    ' → 10
Console.WriteLine(Sum(10, 20))  ' → 30
```

---

### 引数の型

引数にも変数と同様に型を指定します。

| 型 | 渡せる値の例 |
|---|---|
| `Integer` | `10`, `-5`, `0` |
| `Double` | `3.14`, `0.5` |
| `String` | `"hello"`, `"VB.NET"` |

---

### 複数の値を返す（配列）

複数の値をまとめて返したいときは、配列を戻り値にします。

```vbnet
Function Powers(x As Integer) As Integer()
    Return New Integer() {x ^ 1, x ^ 2, x ^ 3}
End Function

Dim result = Powers(2)
Console.WriteLine(result(0))   ' → 2
Console.WriteLine(result(1))   ' → 4
Console.WriteLine(result(2))   ' → 8
```

---

## 練習問題

### 問題 2-1

`String` 型の引数 `s` を受け取り、`s` をそのまま返す関数を実装しなさい。

---

### 問題 2-2

`Integer` 型の引数 `x` を受け取り、`x` をそのまま返す関数を実装しなさい。

---

### 問題 2-3

`Integer` 型の引数 `x` を受け取り、`x` の **1 乗・2 乗・3 乗** を整数配列で返す関数を実装しなさい。

- `result(0)` = x の 1 乗
- `result(1)` = x の 2 乗
- `result(2)` = x の 3 乗

**ヒント:** 累乗は `^` 演算子を使います（例: `x ^ 2`）。

---

### 問題 2-4

`Integer` 型の引数 `x`、`y` を受け取り、以下の計算結果をそれぞれ返す関数を実装しなさい。

| 関数名 | 内容 | 戻り値の型 |
|---|---|---|
| `Problem2_4_Sum` | x と y の和 | `Integer` |
| `Problem2_4_Difference` | x と y の差（x − y） | `Integer` |
| `Problem2_4_Product` | x と y の積 | `Integer` |
| `Problem2_4_Division` | x ÷ y の結果（小数あり） | `Double` |
| `Problem2_4_Quotient` | x ÷ y の商（整数） | `Integer` |
| `Problem2_4_Remainder` | x ÷ y の余り | `Integer` |

**ヒント:** 小数ありの除算は `/`、整数の商は `\`、余りは `Mod` を使います。

---

### 問題 2-5

`Integer` 型の引数 `a`、`b` を受け取り、2 つの整数の平均値（整数）を返す関数を実装しなさい。

※ 小数点以下は切り捨ててよい。

**ヒント:** 整数除算 `\` を使うと小数を切り捨てられます。

---

### 問題 2-6

`Integer` 型の引数 `age`（年齢）を受け取り、生まれてからのおおよその日数を返す関数を実装しなさい。

※ 閏年は考慮せず、`年齢 × 365` で計算する。
