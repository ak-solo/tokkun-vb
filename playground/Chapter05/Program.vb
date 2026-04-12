' Chapter 05 プレイグラウンド — 配列
' 実行: dotnet run --project playground/Chapter05
'
' src/Chapter05/Exercises.vb に実装を書いてから実行しよう
' 値を変えながら繰り返し試してみよう

Module Program
    Sub Main()
        ' ===== 問題 5-1〜5-2: 配列の変換 =====
        Dim numbers12 As Integer() = {3, 7, 1, 9, 4}   ' ← 変えて試そう
        Console.WriteLine($"元: {String.Join(", ", numbers12)}")
        Console.WriteLine($"2倍: {String.Join(", ", Exercises.Problem5_1(numbers12))}")
        Console.WriteLine($"逆順: {String.Join(", ", Exercises.Problem5_2(numbers12))}")

        ' ===== 問題 5-3: 偶数・奇数の分類 =====
        Dim numbers3 As Integer() = {42, 7, 54, 35, 71, 13, 21, 45, 32, 8}   ' ← 変えて試そう
        Dim r3 = Exercises.Problem5_3(numbers3)
        Console.WriteLine($"偶数: {String.Join(" ", r3(0))}")
        Console.WriteLine($"奇数: {String.Join(" ", r3(1))}")

        ' ===== 問題 5-5: 2進数変換 =====
        Dim value As Integer = 42   ' ← 変えて試そう（0〜65535）
        Dim binary = Exercises.Problem5_5(value)
        Console.WriteLine($"{value} = {String.Join("", binary)}")

        ' ===== 問題 5-6: 九九表（2次元配列）=====
        Dim kuku = Exercises.Problem5_6()
        For i = 0 To 8
            For j = 0 To 8
                Console.Write($"{kuku(i, j),3}")
            Next
            Console.WriteLine()
        Next

        ' ===== 問題 5-7: 九九の1マスを参照（x, y の値を変えて試してみよう）=====
        Dim x7 As Integer = 7   ' ← 1〜9 で変えて試そう
        Dim y7 As Integer = 8   ' ← 1〜9 で変えて試そう
        Console.WriteLine($"{x7} × {y7} = {Exercises.Problem5_7(x7, y7)}")

        ' ===== 問題 5-8: バブルソート =====
        Dim numbers8 As Integer() = {5, 3, 8, 1, 9, 2, 7, 4, 6, 0}   ' ← 変えて試そう
        Dim sorted = Exercises.Problem5_8(numbers8)
        Console.WriteLine($"元:   {String.Join(", ", numbers8)}")
        Console.WriteLine($"並替: {String.Join(", ", sorted)}")
    End Sub
End Module
