---
paths:
  - "playground/**/*.vb"
---

# プレイグラウンド（playground/）

## 目的

- 引数を変えながら関数の動作を確認する「実験の場」
- テストとは別に、自分の実装が直感的に正しいか体感できる

## 実行方法

```bash
dotnet run --project playground/Chapter01   # Chapter01 を実行
dotnet run --project playground/Chapter02   # Chapter02 を実行
```

## ファイル構成

```vbnet
' playground/Chapter01/Program.vb

Module Program
    Sub Main()
        ' ===== 問題 1-1 〜 1-3: 文字列の表示 =====
        Console.WriteLine(Exercises.Problem1_1())

        ' ===== 問題 1-9: 倍数（x の値を変えて試してみよう）=====
        Dim x9 As Integer = 3   ' ← この値を変えて実行してみよう
        Dim r9 = Exercises.Problem1_9(x9)
        Console.WriteLine($"{x9} の 2 倍: {r9(0)}")
    End Sub
End Module
```

## プレイグラウンドの原則

- `Program.vb` の変数の値（コメントで `← 変えて試そう` と示した箇所）を書き換えて実行する
- `Module Program` / `Sub Main()` で囲む（VB.NET はトップレベルステートメント非対応）
- 同じ変数名が複数必要な場合はサフィックスで区別する（例: `x9`, `x10`, `x13`）
