' Chapter 06 プレイグラウンド — メソッド
' 実行: dotnet run --project playground/Chapter06
'
' src/Chapter06/Exercises.vb に実装を書いてから実行しよう
' 値を変えながら繰り返し試してみよう

Module Program
    Sub Main()
        ' ===== 問題 6-1〜6-3: 基本関数 =====
        Dim n1 As Integer = 5
        Console.WriteLine($"{n1} の 2 乗 = {Exercises.Problem6_1(n1)}")
        Dim a1 = 7, b1 = 13
        Console.WriteLine($"平均({a1}, {b1}) = {Exercises.Problem6_2(a1, b1)}")
        Console.WriteLine($"最大({a1}, {b1}) = {Exercises.Problem6_3(a1, b1)}")

        ' ===== 問題 6-4〜6-5: 三角形描画 =====
        Dim size As Integer = 5
        Console.WriteLine("--- $ 三角形 ---")
        Console.WriteLine(Exercises.Problem6_4(size))
        Console.WriteLine()
        Console.WriteLine("--- * 三角形 ---")
        Console.WriteLine(Exercises.Problem6_5(size, "*"c))

        ' ===== 問題 6-6: 九九の1段（n の値を変えて試してみよう）=====
        Dim n6 As Integer = 3
        Console.WriteLine($"--- {n6} の段 ---")
        Console.WriteLine(Exercises.Problem6_6(n6))
        ' 全段を表示する
        For i = 1 To 9
            Console.WriteLine($"=== {i} の段 ===")
            Console.WriteLine(Exercises.Problem6_6(i))
        Next

        ' ===== 問題 6-7: 素数判定 =====
        Dim n7 As Integer = 97
        Dim result7 = If(Exercises.Problem6_7(n7), "素数", "素数ではない")
        Console.WriteLine($"{n7} は{result7}")
        ' 1000 未満の素数をすべて表示する
        Dim primes As New List(Of Integer)
        For i = 2 To 999
            If Exercises.Problem6_7(i) Then primes.Add(i)
        Next
        Console.WriteLine($"1000 未満の素数: {primes.Count} 個")
        Console.WriteLine(String.Join(", ", primes))

        ' ===== 問題 6-8: ByRef スワップ =====
        Dim a8 = 42, b8 = 99
        Console.WriteLine($"スワップ前: a={a8}, b={b8}")
        Exercises.Problem6_8(a8, b8)
        Console.WriteLine($"スワップ後: a={a8}, b={b8}")

        ' ===== 問題 6-9: バブルソート（ByRef）=====
        Dim numbers9 = {5, 3, 8, 1, 9, 2, 7, 4, 6}
        Console.WriteLine($"ソート前: {String.Join(", ", numbers9)}")
        Exercises.Problem6_9(numbers9)
        Console.WriteLine($"ソート後: {String.Join(", ", numbers9)}")
    End Sub
End Module
