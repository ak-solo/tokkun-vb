---
paths:
  - "src/**/*.vb"
---

# 骨格コード（src/）

## ファイルの書き方

```vbnet
' src/Chapter01/Exercises.vb

Public Class Exercises

    ' 問題 1-1: "Hello World" を返す
    Public Shared Function Problem1_1() As String
        Throw New NotImplementedException("問題 1-1 を実装してください")
    End Function

    ' 問題 1-4: 13 と 17 の和を返す
    Public Shared Function Problem1_4() As Integer
        Throw New NotImplementedException("問題 1-4 を実装してください")
    End Function

End Class
```

## 骨格コードの原則

- 関数シグネチャ（名前・引数・戻り値の型）は変えない
- `Throw New NotImplementedException` をそのまま残す（テストが `NotImplementedException` で失敗するのが「Red」の状態）
- 問題のコメントに問題番号と概要を明記する
- 入力値を Console.ReadLine() から取ることは **しない**（引数で受け取る）
