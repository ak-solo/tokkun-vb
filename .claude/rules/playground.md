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

各章の `Program.vb` には、**1問目の呼び出し例だけ**を記載する。
それ以外の問題は最初から書かない（学習者が自分で追加する余地を残す）。

```vbnet
' playground/Chapter01/Program.vb
' Chapter 01 プレイグラウンド — 表示・変数・演算
' 実行: dotnet run --project playground/Chapter01
'
' src/Chapter01/Exercises.vb に実装を書いてから実行しよう
' 値を変えながら繰り返し試してみよう

Module Program
    Sub Main()
        Console.WriteLine(Exercises.Problem1_1())
    End Sub
End Module
```

## プレイグラウンドの原則

- 1問目の呼び出しのみ記載する（2問目以降は学習者が自分で書く）
- `Module Program` / `Sub Main()` で囲む（VB.NET はトップレベルステートメント非対応）
- `Try/Catch` は書かない（テンプレートコードを最小限にして自由な使い方を促す）
- 引数を取るメソッドは変数を宣言してから渡す（値を変えて試しやすくするため）
