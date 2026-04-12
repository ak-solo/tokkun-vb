' Chapter 04 プレイグラウンド — 繰り返し
' 実行: dotnet run --project playground/Chapter04
'
' src/Chapter04/Exercises.vb に実装を書いてから実行しよう
' 値を変えながら繰り返し試してみよう

Module Program
    Sub Main()
        ' ===== 問題 4-1〜4-4: 基本ループ =====
        Try
            ' 4-1: SPAM を 10 回
            For Each s In Exercises.Problem4_1()
                Console.Write(s & " ")
            Next
            Console.WriteLine()

            ' 4-2: 三の段
            Console.WriteLine(String.Join(", ", Exercises.Problem4_2()))

            ' 4-3: 2 の累乗
            Console.WriteLine(String.Join(", ", Exercises.Problem4_3()))

            ' 4-4: 7!
            Console.WriteLine($"7! = {Exercises.Problem4_4()}")
        Catch ex As NotImplementedException
            Console.WriteLine("  [未実装] 問題 4-1 〜 4-4")
        End Try

        ' ===== 問題 4-15: 素因数分解（n の値を変えて試してみよう）=====
        Try
            Dim n15 As Integer = 20100   ' ← 変えて試そう（2 以上）
            Console.WriteLine($"{n15} = {String.Join(" × ", Exercises.Problem4_15(n15))}")
        Catch ex As NotImplementedException
            Console.WriteLine("  [未実装] 問題 4-15")
        End Try

        ' ===== 問題 4-16: 素数判定 =====
        Try
            Dim n16 As Integer = 97   ' ← 変えて試そう
            Console.WriteLine($"{n16} は素数か: {Exercises.Problem4_16(n16)}")

            ' 100 以下の素数を全部探す
            Console.Write("100 以下の素数: ")
            For i = 2 To 100
                If Exercises.Problem4_16(i) Then Console.Write($"{i} ")
            Next
            Console.WriteLine()
        Catch ex As NotImplementedException
            Console.WriteLine("  [未実装] 問題 4-16")
        End Try

        ' ===== 問題 4-17: 九九表 =====
        Try
            Dim kuku = Exercises.Problem4_17()
            For i = 0 To 8
                For j = 0 To 8
                    Console.Write($"{kuku(i, j),3}")
                Next
                Console.WriteLine()
            Next
        Catch ex As NotImplementedException
            Console.WriteLine("  [未実装] 問題 4-17")
        End Try

        ' ===== 問題 4-20: 三角形（size の値を変えて試してみよう）=====
        Try
            Dim size20 As Integer = 5   ' ← 変えて試そう
            For Each line In Exercises.Problem4_20(size20)
                Console.WriteLine(line)
            Next
        Catch ex As NotImplementedException
            Console.WriteLine("  [未実装] 問題 4-20")
        End Try

        ' ===== 問題 4-21: ダイヤ（size の値を変えて試してみよう）=====
        Try
            Dim size21 As Integer = 5   ' ← 変えて試そう（2 以上）
            For Each line In Exercises.Problem4_21(size21)
                Console.WriteLine(line)
            Next
        Catch ex As NotImplementedException
            Console.WriteLine("  [未実装] 問題 4-21")
        End Try

        ' ===== 問題 4-22: フィボナッチ数列 =====
        Try
            Dim fib = Exercises.Problem4_22()
            Console.WriteLine($"項数: {fib.Length}")
            Console.WriteLine(String.Join(", ", fib))
        Catch ex As NotImplementedException
            Console.WriteLine("  [未実装] 問題 4-22")
        End Try
    End Sub
End Module
