' Chapter 02 プレイグラウンド — 入力
' 実行: dotnet run --project playground/Chapter02
'
' src/Chapter02/Exercises.vb に実装を書いてから実行しよう
' 値を変えながら繰り返し試してみよう

Module Program
    Sub Main()
        ' ===== 問題 2-1: 文字列をそのまま表示 =====
        Dim s As String = "Hello VB.NET"   ' ← 変えて試そう
        Console.WriteLine(Exercises.Problem2_1(s))

        ' ===== 問題 2-2: 整数を表示 =====
        Dim x2 As Integer = 42              ' ← 変えて試そう
        Console.WriteLine(Exercises.Problem2_2(x2))

        ' ===== 問題 2-3: 1乗・2乗・3乗 =====
        Dim x3 As Integer = 3   ' ← 変えて試そう
        Dim r3 = Exercises.Problem2_3(x3)
        Console.WriteLine($"{x3} の 1 乗: {r3(0)}")
        Console.WriteLine($"{x3} の 2 乗: {r3(1)}")
        Console.WriteLine($"{x3} の 3 乗: {r3(2)}")

        ' ===== 問題 2-4: 四則演算 =====
        Dim x4 As Integer = 10   ' ← 変えて試そう
        Dim y4 As Integer = 3    ' ← 変えて試そう
        Console.WriteLine($"和      : {Exercises.Problem2_4_Sum(x4, y4)}")
        Console.WriteLine($"差(x-y) : {Exercises.Problem2_4_Difference(x4, y4)}")
        Console.WriteLine($"積      : {Exercises.Problem2_4_Product(x4, y4)}")
        Console.WriteLine($"除算    : {Exercises.Problem2_4_Division(x4, y4)}")
        Console.WriteLine($"商      : {Exercises.Problem2_4_Quotient(x4, y4)}")
        Console.WriteLine($"余り    : {Exercises.Problem2_4_Remainder(x4, y4)}")

        ' ===== 問題 2-5: 平均 =====
        Dim a5 As Integer = 3    ' ← 変えて試そう
        Dim b5 As Integer = 4    ' ← 変えて試そう
        Console.WriteLine($"{a5} と {b5} の平均: {Exercises.Problem2_5(a5, b5)}")

        ' ===== 問題 2-6: 日数換算 =====
        Dim age As Integer = 20   ' ← 変えて試そう
        Console.WriteLine($"年齢 {age} 歳 → おおよそ {Exercises.Problem2_6(age)} 日")
    End Sub
End Module
