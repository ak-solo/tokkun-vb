' Chapter 01 プレイグラウンド — 表示・変数・演算
' 実行: dotnet run --project playground/Chapter01
'
' src/Chapter01/Exercises.vb に実装を書いてから実行しよう
' 値を変えながら繰り返し試してみよう

Module Program
    Sub Main()
        ' ===== 問題 1-1 〜 1-3: 文字列の表示 =====
        Try
            Console.WriteLine(Exercises.Problem1_1())
            Console.WriteLine(Exercises.Problem1_2())
            Console.WriteLine(Exercises.Problem1_3())
        Catch ex As NotImplementedException
            Console.WriteLine("  [未実装] 問題 1-1 〜 1-3")
        End Try

        ' ===== 問題 1-4 〜 1-5: 四則演算 =====
        Try
            Console.WriteLine($"13 + 17 = {Exercises.Problem1_4()}")
            Console.WriteLine($"13 * 17 = {Exercises.Problem1_5()}")
        Catch ex As NotImplementedException
            Console.WriteLine("  [未実装] 問題 1-4 〜 1-5")
        End Try

        ' ===== 問題 1-9: 倍数（x の値を変えて試してみよう）=====
        Try
            Dim x9 As Integer = 3   ' ← この値を変えて実行してみよう
            Dim r9 = Exercises.Problem1_9(x9)
            Console.WriteLine($"{x9} の 2 倍: {r9(0)}")
            Console.WriteLine($"{x9} の 3 倍: {r9(1)}")
            Console.WriteLine($"{x9} の 4 倍: {r9(2)}")
        Catch ex As NotImplementedException
            Console.WriteLine("  [未実装] 問題 1-9")
        End Try

        ' ===== 問題 1-10: 累乗（x の値を変えて試してみよう）=====
        Try
            Dim x10 As Integer = 2   ' ← この値を変えて実行してみよう
            Dim r10 = Exercises.Problem1_10(x10)
            Console.WriteLine($"{x10} の 1 乗: {r10(0)}")
            Console.WriteLine($"{x10} の 2 乗: {r10(1)}")
            Console.WriteLine($"{x10} の 3 乗: {r10(2)}")
        Catch ex As NotImplementedException
            Console.WriteLine("  [未実装] 問題 1-10")
        End Try

        ' ===== 問題 1-11 vs 1-12: double 除算 vs 整数除算 =====
        Try
            Console.WriteLine($"10 / 3  = {Exercises.Problem1_11()} （Double）")
            Console.WriteLine($"10 \ 3 = {Exercises.Problem1_12()} （Integer）")
        Catch ex As NotImplementedException
            Console.WriteLine("  [未実装] 問題 1-11 〜 1-12")
        End Try

        ' ===== 問題 1-13: 商と余り（x, y の値を変えて試してみよう）=====
        Try
            Dim x13 As Integer = 17  ' ← 変えて試そう（x > y であること）
            Dim y13 As Integer = 5   ' ← 変えて試そう
            Dim r13 = Exercises.Problem1_13(x13, y13)
            Console.WriteLine($"{x13} ÷ {y13} の商: {r13(0)}")
            Console.WriteLine($"{x13} ÷ {y13} の余り: {r13(1)}")
        Catch ex As NotImplementedException
            Console.WriteLine("  [未実装] 問題 1-13")
        End Try
    End Sub
End Module
