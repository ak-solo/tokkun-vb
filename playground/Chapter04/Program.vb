' Chapter 04 プレイグラウンド — 繰り返し
' 実行: dotnet run --project playground/Chapter04
'
' src/Chapter04/Exercises.vb に実装を書いてから実行しよう
' 値を変えながら繰り返し試してみよう

Module Program
    Sub Main()
        ' ===== 問題 4-1〜4-4: 基本ループ =====
        Try
            Console.WriteLine(Exercises.Problem4_1())
            Console.WriteLine(Exercises.Problem4_2())
            Console.WriteLine(Exercises.Problem4_3())
            Console.WriteLine($"7! = {Exercises.Problem4_4()}")
        Catch ex As NotImplementedException
            Console.WriteLine("  [未実装] 問題 4-1 〜 4-4")
        End Try

        ' ===== 問題 4-7: 素因数分解（n の値を変えて試してみよう）=====
        Try
            Dim n7 As Integer = 20100   ' ← 変えて試そう（2 以上）
            Console.WriteLine($"{n7} の素因数: {Exercises.Problem4_7(n7)}")
        Catch ex As NotImplementedException
            Console.WriteLine("  [未実装] 問題 4-7")
        End Try

        ' ===== 問題 4-8: 素数判定 =====
        Try
            Dim n8 As Integer = 97   ' ← 変えて試そう
            Console.WriteLine($"{n8} は素数か: {Exercises.Problem4_8(n8)}")

            Console.Write("100 以下の素数: ")
            For i = 2 To 100
                If Exercises.Problem4_8(i) Then Console.Write($"{i} ")
            Next
            Console.WriteLine()
        Catch ex As NotImplementedException
            Console.WriteLine("  [未実装] 問題 4-8")
        End Try

        ' ===== 問題 4-9: 三角形（size の値を変えて試してみよう）=====
        Try
            Dim size9 As Integer = 5   ' ← 変えて試そう
            Console.WriteLine(Exercises.Problem4_9(size9))
        Catch ex As NotImplementedException
            Console.WriteLine("  [未実装] 問題 4-9")
        End Try

        ' ===== 問題 4-10: × 印（size の値を変えて試してみよう）=====
        Try
            Dim size10 As Integer = 5   ' ← 変えて試そう（2 以上）
            Console.WriteLine(Exercises.Problem4_10(size10))
        Catch ex As NotImplementedException
            Console.WriteLine("  [未実装] 問題 4-10")
        End Try

        ' ===== 問題 4-11: フィボナッチ数列 =====
        Try
            Console.WriteLine(Exercises.Problem4_11())
        Catch ex As NotImplementedException
            Console.WriteLine("  [未実装] 問題 4-11")
        End Try
    End Sub
End Module
