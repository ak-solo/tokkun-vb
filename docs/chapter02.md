# 2章 入力

## 基礎知識

### キーボードからの入力

`Console.ReadLine()` を使うと、ユーザーが入力した 1 行分の文字列を `String` 型として受け取れます。

```vbnet
Dim s As String
s = Console.ReadLine()    ' 1 行分の文字列を入力する
```

### 文字列を数値に変換する

`Console.ReadLine()` は常に `String` を返すため、数値として使うには変換が必要です。

```vbnet
Dim s As String
Dim n As Integer

s = Console.ReadLine()    ' 文字列として受け取る
n = Integer.Parse(s)      ' Integer に変換する
```

1 行にまとめて書くこともできます。

```vbnet
Dim n As Integer
n = Integer.Parse(Console.ReadLine())
```

### 練習問題での設計方針

この教材では `Console.ReadLine()` を関数の中で直接使う代わりに、**入力値を引数**として受け取る形にします。これにより、ユニットテストで任意の値を渡して動作を検証できるようになります。

```vbnet
' NG: テストできない
Function Problem2_3() As Integer()
    Dim x = Integer.Parse(Console.ReadLine())
    Return New Integer() {x ^ 1, x ^ 2, x ^ 3}
End Function

' OK: 引数で受け取る
Function Problem2_3(x As Integer) As Integer()
    Return New Integer() {x ^ 1, x ^ 2, x ^ 3}
End Function
```

---

## 練習問題

### 問題 2-1

`String` 型の引数 `s` を受け取り、`s` をそのまま返す関数を実装しなさい。

> 実際のプログラムでは `s = Console.ReadLine()` で入力を受け取り、`Console.WriteLine(s)` で表示します。

---

### 問題 2-2

`Integer` 型の引数 `x` を受け取り、`x` をそのまま返す関数を実装しなさい。

> 実際のプログラムでは `x = Integer.Parse(Console.ReadLine())` で入力を受け取ります。

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

**ヒント:**
- 小数ありの除算は `/`、整数の商は `\`、余りは `Mod` を使います。

---

### 問題 2-5

`Integer` 型の引数 `a`、`b` を受け取り、2 つの整数の平均値（整数）を返す関数を実装しなさい。

※ 小数点以下は切り捨ててよい。

**ヒント:** 整数除算 `\` を使うと小数を切り捨てられます。

---

### 問題 2-6

`Integer` 型の引数 `age`（年齢）を受け取り、生まれてから現在までのおおよその日数を返す関数を実装しなさい。

※ 閏年は考慮せず、`年齢 × 365` で計算する。
