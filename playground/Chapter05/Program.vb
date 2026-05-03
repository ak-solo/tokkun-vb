' Chapter 05 プレイグラウンド — 配列
' 実行: dotnet run --project playground/Chapter05
'
' src/Chapter05/Exercises.vb に実装を書いてから実行しよう
' 値を変えながら繰り返し試してみよう

Module Program
    Sub Main()
        ' ===== 問題 5-1〜5-2: 配列の変換 =====
        Try
            Dim numbers12 As Integer() = {3, 7, 1, 9, 4}   ' ← 変えて試そう
            Console.WriteLine($"元: {String.Join(", ", numbers12)}")
            Console.WriteLine($"2倍: {String.Join(", ", Exercises.Problem5_1(numbers12))}")
            Console.WriteLine($"逆順: {String.Join(", ", Exercises.Problem5_2(numbers12))}")
        Catch ex As NotImplementedException
            Console.WriteLine("  [未実装] 問題 5-1 〜 5-2")
        End Try

        ' ===== 問題 5-3: 偶数・奇数の分類 =====
        Try
            Dim numbers3 As Integer() = {42, 7, 54, 35, 71, 13, 21, 45, 32, 8}   ' ← 変えて試そう
            Dim r3 = Exercises.Problem5_3(numbers3)
            Console.WriteLine($"偶数: {String.Join(" ", r3(0))}")
            Console.WriteLine($"奇数: {String.Join(" ", r3(1))}")
        Catch ex As NotImplementedException
            Console.WriteLine("  [未実装] 問題 5-3")
        End Try

        ' ===== 問題 5-5: 2進数変換 =====
        Try
            Dim value As Integer = 42   ' ← 変えて試そう（0〜65535）
            Dim binary = Exercises.Problem5_5(value)
            Console.WriteLine($"{value} = {String.Join("", binary)}")
        Catch ex As NotImplementedException
            Console.WriteLine("  [未実装] 問題 5-5")
        End Try

        ' ===== 問題 5-6: 九九表（2次元配列）=====
        Try
            Dim kuku = Exercises.Problem5_6()
            For i = 0 To 8
                For j = 0 To 8
                    Console.Write($"{kuku(i, j),3}")
                Next
                Console.WriteLine()
            Next
        Catch ex As NotImplementedException
            Console.WriteLine("  [未実装] 問題 5-6")
        End Try

        ' ===== 問題 5-7: 九九の1マスを参照（x, y の値を変えて試してみよう）=====
        Try
            Dim x7 As Integer = 7   ' ← 1〜9 で変えて試そう
            Dim y7 As Integer = 8   ' ← 1〜9 で変えて試そう
            Console.WriteLine($"{x7} × {y7} = {Exercises.Problem5_7(x7, y7)}")
        Catch ex As NotImplementedException
            Console.WriteLine("  [未実装] 問題 5-7")
        End Try

        ' ===== 問題 5-8: バブルソート =====
        Try
            Dim numbers8 As Integer() = {5, 3, 8, 1, 9, 2, 7, 4, 6, 0}   ' ← 変えて試そう
            Dim sorted = Exercises.Problem5_8(numbers8)
            Console.WriteLine($"元:   {String.Join(", ", numbers8)}")
            Console.WriteLine($"並替: {String.Join(", ", sorted)}")
        Catch ex As NotImplementedException
            Console.WriteLine("  [未実装] 問題 5-8")
        End Try

        ' ===== 問題 5-9: 平均値 =====
        Try
            Dim numbers9 As Integer() = {10, 20, 30, 40}   ' ← 変えて試そう
            Console.WriteLine($"平均: {Exercises.Problem5_9(numbers9)}")
        Catch ex As NotImplementedException
            Console.WriteLine("  [未実装] 問題 5-9")
        End Try

        ' ===== 問題 5-10: 勝ち数・負け数 =====
        Try
            Dim results10 As Integer() = {1, 0, 1, 1, 0}   ' ← 変えて試そう（1=勝ち, 0=負け）
            Dim r10 = Exercises.Problem5_10(results10)
            Console.WriteLine($"勝ち: {r10(0)}, 負け: {r10(1)}")
        Catch ex As NotImplementedException
            Console.WriteLine("  [未実装] 問題 5-10")
        End Try

        ' ===== 問題 5-11: 野球スコア =====
        Try
            Dim giants11 As Integer() = {1, 2, 0, 3, 0, 1, 0, 2, 0}   ' ← 変えて試そう
            Dim tigers11 As Integer() = {0, 0, 2, 0, 1, 0, 0, 0, 3}   ' ← 変えて試そう
            Dim g = Exercises.Problem5_11_TotalScore(giants11)
            Dim t = Exercises.Problem5_11_TotalScore(tigers11)
            Console.WriteLine($"巨人 {g} - {t} 阪神")
        Catch ex As NotImplementedException
            Console.WriteLine("  [未実装] 問題 5-11")
        End Try

        ' ===== 問題 5-12・5-13: 最大値・最小値 =====
        Try
            Dim numbers13 As Integer() = {5, 3, 8, 1, 9}   ' ← 変えて試そう
            Console.WriteLine($"最大: {Exercises.Problem5_12(numbers13)}")
            Dim r13 = Exercises.Problem5_13(numbers13)
            Console.WriteLine($"最大: {r13(0)}, 最小: {r13(1)}")
        Catch ex As NotImplementedException
            Console.WriteLine("  [未実装] 問題 5-12 〜 5-13")
        End Try

        ' ===== 問題 5-14: 合計が 100 を超えたところで停止 =====
        Try
            Dim numbers14 As Integer() = {30, 40, 50, 60}   ' ← 変えて試そう
            Console.WriteLine($"停止時の合計: {Exercises.Problem5_14(numbers14)}")
        Catch ex As NotImplementedException
            Console.WriteLine("  [未実装] 問題 5-14")
        End Try

        ' ===== 問題 5-15・5-16: 投球判定 =====
        Try
            Dim pitches15 As Integer() = {1, 2, 1, 1}   ' ← 変えて試そう（1=S, 2=B）
            Console.WriteLine($"5-15: {Exercises.Problem5_15(pitches15)}")

            Dim pitches16 As Integer() = {3, 3, 1}      ' ← 変えて試そう（1=S, 2=B, 3=F）
            Console.WriteLine($"5-16: {Exercises.Problem5_16(pitches16)}")
        Catch ex As NotImplementedException
            Console.WriteLine("  [未実装] 問題 5-15 〜 5-16")
        End Try

        ' ===== 問題 5-17・5-18: 0 の手前まで集計 =====
        Try
            Dim numbers17 As Integer() = {5, 10, 3, 0, 99}   ' ← 変えて試そう
            Console.WriteLine($"0 の手前の合計: {Exercises.Problem5_17(numbers17)}")
            Console.WriteLine($"0 の手前の平均: {Exercises.Problem5_18(numbers17)}")
        Catch ex As NotImplementedException
            Console.WriteLine("  [未実装] 問題 5-17 〜 5-18")
        End Try
    End Sub
End Module
