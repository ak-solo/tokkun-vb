' Chapter 02 プレイグラウンド — 引数と戻り値
' 実行: dotnet run --project playground/Chapter02
'
' src/Chapter02/Exercises.vb に実装を書いてから実行しよう
' 値を変えながら繰り返し試してみよう

Module Program
    Sub Main()
        ' ===== 問題 2-1: 文字列をそのまま表示 =====
        Try
            Dim s As String = "Hello VB.NET"   ' ← 変えて試そう
            Console.WriteLine(Exercises.Problem2_1(s))
        Catch ex As NotImplementedException
            Console.WriteLine("  [未実装] 問題 2-1")
        End Try

        ' ===== 問題 2-2: 整数を表示 =====
        Try
            Dim x2 As Integer = 42              ' ← 変えて試そう
            Console.WriteLine(Exercises.Problem2_2(x2))
        Catch ex As NotImplementedException
            Console.WriteLine("  [未実装] 問題 2-2")
        End Try

        ' ===== 問題 2-3: 2 倍・3 倍・4 倍 =====
        Try
            Dim x3 As Integer = 3   ' ← 変えて試そう
            Console.WriteLine($"{x3} の 2 倍・3 倍・4 倍: {Exercises.Problem2_3(x3)}")
        Catch ex As NotImplementedException
            Console.WriteLine("  [未実装] 問題 2-3")
        End Try

        ' ===== 問題 2-4: 1 乗・2 乗・3 乗 =====
        Try
            Dim x4 As Integer = 3   ' ← 変えて試そう
            Console.WriteLine($"{x4} の 1 乗・2 乗・3 乗: {Exercises.Problem2_4(x4)}")
        Catch ex As NotImplementedException
            Console.WriteLine("  [未実装] 問題 2-4")
        End Try

        ' ===== 問題 2-5: 四則演算 =====
        Try
            Dim x5 As Integer = 10   ' ← 変えて試そう
            Dim y5 As Integer = 3    ' ← 変えて試そう
            Console.WriteLine($"和      : {Exercises.Problem2_5_Sum(x5, y5)}")
            Console.WriteLine($"差(x-y) : {Exercises.Problem2_5_Difference(x5, y5)}")
            Console.WriteLine($"積      : {Exercises.Problem2_5_Product(x5, y5)}")
            Console.WriteLine($"除算    : {Exercises.Problem2_5_Division(x5, y5)}")
            Console.WriteLine($"商      : {Exercises.Problem2_5_Quotient(x5, y5)}")
            Console.WriteLine($"余り    : {Exercises.Problem2_5_Remainder(x5, y5)}")
        Catch ex As NotImplementedException
            Console.WriteLine("  [未実装] 問題 2-5")
        End Try

        ' ===== 問題 2-6: 平均 =====
        Try
            Dim a6 As Integer = 3    ' ← 変えて試そう
            Dim b6 As Integer = 4    ' ← 変えて試そう
            Console.WriteLine($"{a6} と {b6} の平均: {Exercises.Problem2_6(a6, b6)}")
        Catch ex As NotImplementedException
            Console.WriteLine("  [未実装] 問題 2-6")
        End Try

        ' ===== 問題 2-7: 日数換算 =====
        Try
            Dim age As Integer = 20   ' ← 変えて試そう
            Console.WriteLine($"年齢 {age} 歳 → おおよそ {Exercises.Problem2_7(age)} 日")
        Catch ex As NotImplementedException
            Console.WriteLine("  [未実装] 問題 2-7")
        End Try
    End Sub
End Module
