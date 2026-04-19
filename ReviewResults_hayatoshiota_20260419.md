# ソースコードレビュー — Chapter 01〜03（問題 3-9 まで）

レビュー日: 2026-04-19  
対象者: hayatoshiota  
対象範囲: `src/Chapter01/Exercises.vb`, `src/Chapter02/Exercises.vb`, `src/Chapter03/Exercises.vb`（問題 3-9 まで）

---

## 総評

全体的に基本的な構文は習得できており、Chapter 01・02 は概ね正しく動作します。
Chapter 03 の後半（3-8, 3-9）に**テストが失敗する可能性のある論理バグ**が含まれています。

---

## Chapter 01

### ✅ 良い点

- 変数宣言・型指定・四則演算・配列の返し方はすべて正しい
- `Problem1_6` の整数除算 `\` の使い分けも正確

### ⚠️ 指摘事項

| 場所 | 深刻度 | 内容 |
|---|---|---|
| 全体的なスタイル | 低 | `return(value)` は動作するが VB.NET の慣用形は `Return value`（括弧なし）。演算子ではなくキーワードなので括弧は不要 |
| L17 `Problem1_3` | 低 | `Dim y As INteger` → `INteger` は大文字が混在。VB.NET は大文字小文字を区別しないので動作はするが、可読性が下がる |
| `Problem1_7` | 中 | **スワップが正しく実装されていない**。一時変数 `temp` を使って x と y の値を入れ替えるのが学習目的。現状は `i = 7` をハードコードしており、x と y の値を変えると動作しなくなる |
| `Problem1_11` | 低 | 中間変数 `i` は不要。`Return x / y` で十分 |

**Problem1_7 の正しい実装例:**

```vbnet
Dim x As Integer = 3
Dim y As Integer = 7
Dim temp As Integer = x
x = y
y = temp
Return $"x={x},y={y}"
```

---

## Chapter 02

### ✅ 総評

すべての問題が正しく実装されています。引数で入力を受け取るという設計方針も守られています。

### ⚠️ 指摘事項

| 場所 | 深刻度 | 内容 |
|---|---|---|
| 全体的なスタイル | 低 | Chapter 01 と同様、`Return(value)` の括弧は不要 |

---

## Chapter 03

### ✅ 良い点

- 問題 3-1〜3-7 は概ね正しく動作する
- `Problem3_7_Case3` で `Select Case ... To ...` を適切に使えている

### ⚠️ 指摘事項

---

#### 問題 3-7 ケース2（軽微）

```vbnet
ElseIf score >=60 And score < 80 Then  ' ← And score < 80 は冗長
```

`ElseIf` の時点で `score < 80` は既に保証されているため、`And score < 80` は不要です。

---

#### 🔴 問題 3-8（バグ）— 演算子の優先順位

**L104:**

```vbnet
If (midterm >= 60 And final >= 60) Or (midterm + final >= 130) Or
   (midterm + final >= 100 And midterm >= 90 Or final >= 90) Then
```

**問題:** `And` は `Or` より優先度が高いため、最後の条件は次のように解釈されます。

```
(midterm + final >= 100 And midterm >= 90) Or (final >= 90)
```

これは意図と異なります。`final = 90, midterm = 0` のようなケースで誤って「合格」になります。

**正しい実装:**

```vbnet
Or (midterm + final >= 100 And (midterm >= 90 Or final >= 90))
```

---

#### 🔴 問題 3-9（複数のバグ）— ほぼ全テストが失敗する可能性あり

コード全体に複数の問題が重なっています。

**1. 論理が逆になっている（最大の問題）**

```vbnet
Dim open As Boolean = True   ' open = True のとき...
' ...
If open Then
    Return "休診"             ' ← "休診" を返している（逆！）
Else
    Return "○"
End If
```

`open = True` が「開院」を意味するなら、`"○"` を返すべきです。

**2. `Then` キーワードの欠落（構文エラー）**

```vbnet
If dayOfWeek = 0          ' ← Then がない → コンパイルエラー
    open = False
End If
```

**3. 複数行条件の行継続が未処理**

```vbnet
If dayOfWeek = 2 Or dayOfWeek = 5   ' ← 行末に _ が必要
    And timeOfDay = 0
```

VB.NET では条件を複数行に分ける場合、行末に `_` が必要です。

**4. 演算子の優先順位（土曜日の条件）**

```vbnet
If dayOfWeek = 6
    And timeOfDay = 1 Or timeOfDay = 2 Then
```

これは `(dayOfWeek = 6 And timeOfDay = 1) Or timeOfDay = 2` と解釈され、曜日に関係なく夜間なら全部 `open = False` になってしまいます。

**修正の方向性（例）:**

```vbnet
Public Shared Function Problem3_9(dayOfWeek As Integer, timeOfDay As Integer) As String
    Dim isHoliday As Boolean = False

    If dayOfWeek = 0 Then                                          ' 日曜は終日
        isHoliday = True
    ElseIf (dayOfWeek = 2 Or dayOfWeek = 5) And timeOfDay = 0 Then ' 火・金の午前
        isHoliday = True
    ElseIf dayOfWeek = 3 And timeOfDay = 2 Then                    ' 水の夜間
        isHoliday = True
    ElseIf dayOfWeek = 6 And (timeOfDay = 1 Or timeOfDay = 2) Then ' 土の午後・夜間
        isHoliday = True
    End If

    If isHoliday Then
        Return "休診"
    Else
        Return "○"
    End If
End Function
```

---

## まとめ

| 章 | 状態 | 主な問題 |
|---|---|---|
| Chapter 01 | ほぼOK | Problem1_7 のスワップ実装が不正確 |
| Chapter 02 | OK | スタイルのみ |
| Chapter 03（3-1〜3-7） | OK | Problem3_7_Case2 の冗長条件（軽微） |
| Chapter 03（3-8） | バグあり | 演算子の優先順位により一部条件が誤動作 |
| Chapter 03（3-9） | バグあり | 構文エラー・論理反転・優先順位の複合的な問題 |

優先して修正すべきは **3-9 → 3-8 → 1-7** の順です。
