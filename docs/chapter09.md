# 9章 LINQ

## 基礎知識

### LINQ とは

**LINQ（Language Integrated Query）** は、コレクションや配列に対して SQL に似た操作（抽出・変換・並び替え・集計）を簡潔に書けるしくみです。

VB.NET では **メソッド構文**と**クエリ構文**の 2 通りで書けます。

---

### List(Of T)

LINQ と組み合わせてよく使うコレクション型です。要素数が可変で、追加・削除が簡単にできます。

```vbnet
Dim names As New List(Of String) From {"Alice", "Bob", "Carol"}
names.Add("Dave")
Console.WriteLine(names.Count)   ' 4
```

配列も `List` も、LINQ メソッドはどちらでも使えます（`IEnumerable(Of T)` を実装しているため）。

---

### Where（絞り込み）

条件に合う要素だけを取り出します。

```vbnet
Dim numbers = {1, 2, 3, 4, 5, 6}

' メソッド構文
Dim evens = numbers.Where(Function(n) n Mod 2 = 0).ToArray()
' → {2, 4, 6}

' クエリ構文
Dim evens2 = (From n In numbers Where n Mod 2 = 0).ToArray()
```

---

### Select（変換・射影）

各要素を別の値に変換します。

```vbnet
Dim numbers = {1, 2, 3}

' メソッド構文
Dim doubled = numbers.Select(Function(n) n * 2).ToArray()
' → {2, 4, 6}

' クエリ構文
Dim doubled2 = (From n In numbers Select n * 2).ToArray()
```

---

### OrderBy / OrderByDescending（並び替え）

```vbnet
Dim words = {"banana", "apple", "cherry"}

Dim asc  = words.OrderBy(Function(w) w).ToArray()           ' アルファベット昇順
Dim desc = words.OrderByDescending(Function(w) w).ToArray() ' 降順

' 文字数の短い順
Dim byLen = words.OrderBy(Function(w) w.Length).ToArray()
```

---

### 集計（Count / Sum / Average / Min / Max）

```vbnet
Dim scores = {80, 60, 95, 70, 55}

Console.WriteLine(scores.Count())              ' 5
Console.WriteLine(scores.Sum())                ' 360
Console.WriteLine(scores.Average())            ' 72.0
Console.WriteLine(scores.Min())                ' 55
Console.WriteLine(scores.Max())                ' 95
```

---

### メソッドチェーン

LINQ メソッドはつなげて書けます。

```vbnet
Dim numbers = {5, 3, 8, 1, 6, 2, 9, 4}

' 偶数だけ抽出 → 降順に並べ → 先頭 3 件
Dim result = numbers _
    .Where(Function(n) n Mod 2 = 0) _
    .OrderByDescending(Function(n) n) _
    .Take(3) _
    .ToArray()
' → {8, 6, 4}
```

---

### Any / All

- `Any(条件)` ― 条件を満たす要素が **1 つでも** あれば `True`
- `All(条件)` ― **すべての** 要素が条件を満たせば `True`

```vbnet
Dim scores = {80, 60, 95, 70}

Console.WriteLine(scores.Any(Function(s) s >= 90))   ' True（95 がある）
Console.WriteLine(scores.All(Function(s) s >= 60))   ' True（全員 60 以上）
Console.WriteLine(scores.All(Function(s) s >= 70))   ' False（60 がある）
```

---

### GroupBy（グループ化）

同じキーを持つ要素をまとめます。

```vbnet
Dim words = {"apple", "ant", "banana", "bear", "cat"}

' 先頭文字でグループ化し、グループ名と件数を表示
For Each g In words.GroupBy(Function(w) w(0))
    Console.WriteLine($"{g.Key}: {g.Count()}件")
Next
' a: 2件
' b: 2件
' c: 1件
```

---

### クエリ構文

SQL に似た書き方です。`From`・`Where`・`Select`・`Order By` を使います。

```vbnet
Dim scores = {80, 60, 95, 70, 55}

' 70 以上のスコアを降順に並べて取得
Dim result = (From s In scores
              Where s >= 70
              Order By s Descending
              Select s).ToArray()
' → {95, 80, 70}
```

---

## 練習問題

### 問題 9-1

`Integer` 型配列 `numbers` と整数 `threshold` を受け取り、`threshold` **以上** の要素だけを **昇順** に並べた配列を返す関数を実装しなさい。

例: `numbers={5, 1, 8, 3, 9, 2}`, `threshold=4` → `{5, 8, 9}`

**ヒント:** `Where` → `OrderBy` の順にチェーンします。

---

### 問題 9-2

`Integer` 型配列 `numbers` を受け取り、各要素を `"{n}番"` という形式の文字列に変換した `String` 配列を返す関数を実装しなさい。

例: `numbers={3, 1, 4}` → `{"3番", "1番", "4番"}`

**ヒント:** `Select` と文字列補間 `$"..."` を組み合わせます。

---

### 問題 9-3

`String` 型配列 `words` を受け取り、文字数の **短い順**（文字数が同じ場合はアルファベット順）に並べた配列を返す関数を実装しなさい。

例: `words={"banana", "fig", "apple", "kiwi"}` → `{"fig", "kiwi", "apple", "banana"}`

**ヒント:** `OrderBy` は複数のキーを `ThenBy` でつなげられます。

---

### 問題 9-4

`Integer` 型配列 `scores` を受け取り、その **平均値**（`Double`）を返す関数を実装しなさい。

例: `scores={80, 60, 95, 70, 55}` → `72.0`

---

### 問題 9-5

`Integer` 型配列 `numbers` を受け取り、以下の処理をこの順で行った配列を返す関数を実装しなさい。

1. 偶数のみ抽出する
2. 各要素を 2 乗する
3. 昇順に並べる

例: `numbers={5, 2, 8, 3, 4, 6}` → `{4, 16, 36, 64}`

**ヒント:** `Where` → `Select` → `OrderBy` の順にチェーンします。

---

### 問題 9-6

`Integer` 型配列 `scores` と整数 `n` を受け取り、**上位 n 件** のスコアを降順に並べた配列を返す関数を実装しなさい。

例: `scores={70, 85, 60, 95, 75}`, `n=3` → `{95, 85, 75}`

**ヒント:** `OrderByDescending` → `Take` の順にチェーンします。

---

### 問題 9-7

`Integer` 型配列 `numbers` を受け取り、以下の 3 つを判定する関数をそれぞれ実装しなさい。

- `Problem9_7_HasNegative` ― 負の数が 1 つでも含まれていれば `True` を返す
- `Problem9_7_AllPositive` ― すべての要素が正の数（0 より大きい）であれば `True` を返す
- `Problem9_7_CountOver` ― 引数 `threshold` を超える要素の個数を返す

例（HasNegative）: `numbers={3, -1, 5}` → `True`
例（AllPositive）: `numbers={3, 1, 5}` → `True`
例（CountOver）: `numbers={3, 7, 2, 8, 5}`, `threshold=4` → `3`

---

### 問題 9-8

**クエリ構文**を使って実装しなさい。

`String` 型配列 `words` と整数 `minLength` を受け取り、文字数が `minLength` 以上の単語を **文字数の降順** に並べた配列を返す関数を実装しなさい。

例: `words={"cat", "elephant", "ox", "dog", "hippopotamus"}`, `minLength=4` → `{"hippopotamus", "elephant"}`

**ヒント:** `From w In words Where ... Order By ... Descending Select w` の形で書きます。

---

### 問題 9-9

`String` 型配列 `words` を受け取り、**先頭文字ごとの出現件数** を `Dictionary(Of Char, Integer)` で返す関数を実装しなさい。

例: `words={"apple", "ant", "banana", "bear", "cat"}` → `{'a': 2, 'b': 2, 'c': 1}`

**ヒント:** `GroupBy(Function(w) w(0))` でグループ化し、`.ToDictionary(Function(g) g.Key, Function(g) g.Count())` で辞書に変換します。
