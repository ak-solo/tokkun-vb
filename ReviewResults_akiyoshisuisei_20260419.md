# ソースコードレビュー — Chapter 01〜03（問題 3-8 まで）

レビュー日: 2026-04-19  
対象者: akiyoshisuisei  
対象範囲: `src/Chapter01/Exercises.vb`, `src/Chapter02/Exercises.vb`, `src/Chapter03/Exercises.vb`（問題 3-8 まで）

---

## 総評

Chapter 01・02 は全問題を正しく実装できており、特に `Problem1_7` のスワップ処理（一時変数 `i` を使った正しい実装）は評価できます。
Chapter 03 の `Problem3_8` に**テストをすり抜けてしまう論理バグ**が含まれており、要修正です。

---

## Chapter 01

### ✅ 良い点

- 全問題が正しく動作する
- `Problem1_7` の値の入れ替えを一時変数で正しく実装できている
- `Problem1_5` は変数を使わずにリテラル同士の積を直接返しており、問題の意図通り

### ⚠️ 指摘事項

| 場所 | 深刻度 | 内容 |
|---|---|---|
| 全体的なスタイル | 低 | `dim` / `return` / `integer` など、キーワードの大文字・小文字が揺れている（`Dim` / `Return` / `Integer` に統一が望ましい） |
| `Problem1_2` L11 | 低 | `Return ($"x={x}")` — 括弧は不要。`Return $"x={x}"` で十分 |
| `Problem1_4` | 低 | `Dim x As Integer = 13 + 17 : Return x` — 中間変数は不要。`Return 13 + 17` で十分 |
| `Problem1_6` | 低 | `x*3` が 2 回書かれている。`Dim tripled = x * 3 : Return New Integer(){tripled, tripled \ 2}` とすると重複がなくなる |
| `Problem1_11` | 低 | 中間変数 `i` は不要。`Return x / y` で十分 |

---

## Chapter 02

### ✅ 総評

全問題が正しく実装されています。`Problem2_5` の整数除算による切り捨ても正確です。

### ⚠️ 指摘事項

| 場所 | 深刻度 | 内容 |
|---|---|---|
| L34, L39, L44 | 低 | 引数名 `x` を `X`（大文字）で参照している。VB.NET は大文字小文字を区別しないため動作はするが、宣言時の `x` と統一すべき |
| `Problem2_4_Sum` 等 | 低 | `return(value)` の括弧は不要（Chapter 01 と同様） |

---

## Chapter 03

### ✅ 良い点

- 問題 3-1〜3-5 はすべて正しく動作する
- `Problem3_7`（全ケース）で `Select Case` を活用できている

### ⚠️ 指摘事項

---

#### 問題 3-6（軽微）— 到達不能な `else` 節

```vbnet
elseif x<0 and x mod 2 <> 0 then
    return "負の奇数"
else
    return "予想外"   ' ← ここには絶対に到達しない
end if
```

整数は必ず「正の偶数・正の奇数・負の偶数・負の奇数」のいずれかに分類されるため、`else "予想外"` は dead code です。コードが意図通りに網羅されているか自信がなかった裏返しとも言えます。`else` 節は削除し、4 つの `ElseIf` で閉じるか、`Else` を最後の `"負の奇数"` に使う形が自然です。

---

#### 問題 3-7（注意）— `Select Case ... To 100` の上限

```vbnet
Case 60 To 100
    Return "合格"
```

テストは score が 0〜100 の範囲のみを扱うため合格しますが、100 点を超えるスコアが渡された場合は `"不合格"` になってしまいます。`If` 文で `score >= 60` と書く方が意味的には正確です。

---

#### 🔴 問題 3-8（バグ）— 演算子の優先順位と型の混在

**L108:**

```vbnet
If (midterm >= 60 And final >= 60) Or (midterm + final >= 130) Or
   (midterm + final >= 100 And midterm >= 90 Or final) >= 90 Then
```

**問題の箇所:** `(midterm + final >= 100 And midterm >= 90 Or final) >= 90`

括弧の位置が意図と異なり、次のように解釈されます。

```
((midterm + final >= 100 And midterm >= 90) Or final) >= 90
```

1. `And` は `Or` より優先度が高いので、`(合計>=100 And midterm>=90)` が先に Boolean として評価される
2. `Or final` で Integer である `final` を Boolean 式にビット OR する（VB.NET では True = -1）
3. その結果の Integer を `>= 90` と比較する

この挙動により、**`midterm >= 90` かつ `final < 90` のケースで誤って「不合格」になります。**

例: `midterm=95, final=10`（合計 105 点、中間 90 点以上 → 合格のはず）

| ステップ | 評価 |
|---|---|
| `105 >= 100 And 95 >= 90` | `True`（VB では `-1`） |
| `-1 Or 10` | `-1`（全ビット 1） |
| `-1 >= 90` | `False` |
| 結果 | `"不合格"` ← **誤り** |

既存のテストはこのケース（`midterm >= 90` 側）を検証していないためテストはたまたま通りますが、実装は誤っています。

**正しい実装:**

```vbnet
If (midterm >= 60 And final >= 60) Or
   (midterm + final >= 130) Or
   (midterm + final >= 100 And (midterm >= 90 Or final >= 90)) Then
    Return "合格"
Else
    Return "不合格"
End If
```

---

## まとめ

| 章 | 状態 | 主な問題 |
|---|---|---|
| Chapter 01 | ほぼOK | スタイルの揺れ（小文字キーワード・不要な中間変数）のみ |
| Chapter 02 | ほぼOK | 引数名の大文字表記の揺れ（軽微） |
| Chapter 03（3-1〜3-7） | OK | 3-6 の dead code、3-7 の上限設定（どちらも軽微） |
| Chapter 03（3-8） | バグあり | 括弧の位置ミスによる演算子優先順位の問題。一部ケースで誤判定 |

優先して修正すべきは **3-8** です。スタイルの揺れは動作に影響しませんが、一貫性のために直しておくと読みやすくなります。
