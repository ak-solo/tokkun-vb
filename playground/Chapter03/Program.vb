' Chapter 03 プレイグラウンド — 分岐
' 実行: dotnet run --project playground/Chapter03
'
' src/Chapter03/Exercises.vb に実装を書いてから実行しよう
' 値を変えながら繰り返し試してみよう

Module Program
    Sub Main()
        ' ===== 問題 3-1 〜 3-4: 比較演算 =====
        Try
            Dim x34 As Integer = 10   ' ← 変えて試そう
            Dim y34 As Integer = 5    ' ← 変えて試そう
            Console.WriteLine($"3-1: {Exercises.Problem3_1(x34, y34)}")
            Console.WriteLine($"3-2: {Exercises.Problem3_2(x34, y34)}")
            Console.WriteLine($"3-3 大きい方: {Exercises.Problem3_3(x34, y34)}")
            Console.WriteLine($"3-4: {Exercises.Problem3_4(x34, y34)}")
        Catch ex As NotImplementedException
            Console.WriteLine("  [未実装] 問題 3-1 〜 3-4")
        End Try

        ' ===== 問題 3-5 〜 3-6: 符号・絶対値（0 や負の数も試してみよう）=====
        Try
            Dim x56 As Integer = -4   ' ← 変えて試そう
            Console.WriteLine($"3-5: {Exercises.Problem3_5(x56)}")
            Console.WriteLine($"3-6: {Exercises.Problem3_6(x56)}")
        Catch ex As NotImplementedException
            Console.WriteLine("  [未実装] 問題 3-5 〜 3-6")
        End Try

        ' ===== 問題 3-7: 成績判定 =====
        Try
            Dim score As Integer = 75   ' ← 変えて試そう
            Console.WriteLine($"ケース1: {Exercises.Problem3_7_Case1(score)}")
            Console.WriteLine($"ケース2: {Exercises.Problem3_7_Case2(score)}")
            Console.WriteLine($"ケース3: {Exercises.Problem3_7_Case3(score)}")
        Catch ex As NotImplementedException
            Console.WriteLine("  [未実装] 問題 3-7")
        End Try

        ' ===== 問題 3-8: 2科目の成績 =====
        Try
            Dim midterm As Integer = 50   ' ← 変えて試そう
            Dim final As Integer = 90     ' ← 変えて試そう
            Console.WriteLine($"中間:{midterm} 期末:{final} → {Exercises.Problem3_8(midterm, final)}")
        Catch ex As NotImplementedException
            Console.WriteLine("  [未実装] 問題 3-8")
        End Try

        ' ===== 問題 3-9: 曜日・時間帯の組み合わせ一覧 =====
        Try
            Dim days = {"日", "月", "火", "水", "木", "金", "土"}
            Dim times = {"午前", "午後", "夜間"}
            Console.Write("     ")
            For Each d In days
                Console.Write($"{d}  ")
            Next
            Console.WriteLine()
            For t = 0 To 2
                Console.Write($"{times(t)} ")
                For d = 0 To 6
                    Console.Write($"{Exercises.Problem3_9(d, t)}  ")
                Next
                Console.WriteLine()
            Next
        Catch ex As NotImplementedException
            Console.WriteLine("  [未実装] 問題 3-9")
        End Try

        ' ===== 問題 3-11: メニュー選択 =====
        Try
            Dim choice As Integer = 1   ' ← 1〜5 で変えて試そう
            Console.WriteLine(Exercises.Problem3_11(choice))
        Catch ex As NotImplementedException
            Console.WriteLine("  [未実装] 問題 3-11")
        End Try

        ' ===== 問題 3-12: 月の日数（全月まとめて確認）=====
        Try
            For month = 1 To 12
                Console.WriteLine(Exercises.Problem3_12(month))
            Next
            Console.WriteLine(Exercises.Problem3_12(13))
        Catch ex As NotImplementedException
            Console.WriteLine("  [未実装] 問題 3-12")
        End Try
    End Sub
End Module
