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

        ' ===== 問題 1-6: 3 倍→整数除算で半分 =====
        Try
            Console.WriteLine($"x=7 を 3 倍→半分（商,半分）: {Exercises.Problem1_6()}")
        Catch ex As NotImplementedException
            Console.WriteLine("  [未実装] 問題 1-6")
        End Try

        ' ===== 問題 1-9 vs 1-10: double 除算 vs 整数除算 =====
        Try
            Console.WriteLine($"10 / 3  = {Exercises.Problem1_9()} （Double）")
            Console.WriteLine($"10 \ 3 = {Exercises.Problem1_10()} （Integer）")
        Catch ex As NotImplementedException
            Console.WriteLine("  [未実装] 問題 1-9 〜 1-10")
        End Try
    End Sub
End Module
