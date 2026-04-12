' Chapter 09 プレイグラウンド — LINQ
' 実行: dotnet run --project playground/Chapter09
'
' src/Chapter09/Exercises.vb に実装を書いてから実行しよう
' 値を変えながら繰り返し試してみよう

Module Program
    Sub Main()
        ' ===== 問題 9-1: Where + OrderBy =====
        Try
            Dim nums1 = {5, 1, 8, 3, 9, 2}
            Dim threshold1 As Integer = 4   ' ← この値を変えて試してみよう
            Dim r1 = Exercises.Problem9_1(nums1, threshold1)
            Console.WriteLine($"9-1 ({threshold1} 以上を昇順): {String.Join(", ", r1)}")
        Catch ex As NotImplementedException
            Console.WriteLine("  [未実装] 問題 9-1")
        End Try

        ' ===== 問題 9-2: Select =====
        Try
            Dim nums2 = {3, 1, 4}   ' ← この配列を変えて試してみよう
            Dim r2 = Exercises.Problem9_2(nums2)
            Console.WriteLine($"9-2 (ラベル変換): {String.Join(", ", r2)}")
        Catch ex As NotImplementedException
            Console.WriteLine("  [未実装] 問題 9-2")
        End Try

        ' ===== 問題 9-3: OrderBy + ThenBy =====
        Try
            Dim words3 = {"banana", "fig", "apple", "kiwi"}   ' ← 単語を変えて試してみよう
            Dim r3 = Exercises.Problem9_3(words3)
            Console.WriteLine($"9-3 (文字数順): {String.Join(", ", r3)}")
        Catch ex As NotImplementedException
            Console.WriteLine("  [未実装] 問題 9-3")
        End Try

        ' ===== 問題 9-4: Average =====
        Try
            Dim scores4 = {80, 60, 95, 70, 55}   ' ← 点数を変えて試してみよう
            Dim r4 = Exercises.Problem9_4(scores4)
            Console.WriteLine($"9-4 (平均): {r4}")
        Catch ex As NotImplementedException
            Console.WriteLine("  [未実装] 問題 9-4")
        End Try

        ' ===== 問題 9-5: メソッドチェーン =====
        Try
            Dim nums5 = {5, 2, 8, 3, 4, 6}   ' ← この配列を変えて試してみよう
            Dim r5 = Exercises.Problem9_5(nums5)
            Console.WriteLine($"9-5 (偶数を抽出→2乗→昇順): {String.Join(", ", r5)}")
        Catch ex As NotImplementedException
            Console.WriteLine("  [未実装] 問題 9-5")
        End Try

        ' ===== 問題 9-6: OrderByDescending + Take =====
        Try
            Dim scores6 = {70, 85, 60, 95, 75}
            Dim topN As Integer = 3   ' ← この値を変えて試してみよう
            Dim r6 = Exercises.Problem9_6(scores6, topN)
            Console.WriteLine($"9-6 (上位 {topN} 件): {String.Join(", ", r6)}")
        Catch ex As NotImplementedException
            Console.WriteLine("  [未実装] 問題 9-6")
        End Try

        ' ===== 問題 9-7: Any / All / Count =====
        Try
            Dim nums7 = {3, -1, 5, 0, 8}   ' ← この配列を変えて試してみよう
            Console.WriteLine($"9-7 HasNegative: {Exercises.Problem9_7_HasNegative(nums7)}")
            Console.WriteLine($"9-7 AllPositive: {Exercises.Problem9_7_AllPositive(nums7)}")
            Dim over7 As Integer = 4   ' ← この値を変えて試してみよう
            Console.WriteLine($"9-7 CountOver({over7}): {Exercises.Problem9_7_CountOver(nums7, over7)}")
        Catch ex As NotImplementedException
            Console.WriteLine("  [未実装] 問題 9-7")
        End Try

        ' ===== 問題 9-8: クエリ構文 =====
        Try
            Dim words8 = {"cat", "elephant", "ox", "dog", "hippopotamus"}
            Dim minLen8 As Integer = 4   ' ← この値を変えて試してみよう
            Dim r8 = Exercises.Problem9_8(words8, minLen8)
            Console.WriteLine($"9-8 (文字数 {minLen8} 以上を長い順): {String.Join(", ", r8)}")
        Catch ex As NotImplementedException
            Console.WriteLine("  [未実装] 問題 9-8")
        End Try

        ' ===== 問題 9-9: GroupBy =====
        Try
            Dim words9 = {"apple", "ant", "banana", "bear", "cat"}   ' ← 単語を変えて試してみよう
            Dim r9 = Exercises.Problem9_9(words9)
            Console.WriteLine("9-9 (先頭文字ごとの件数):")
            For Each kvp In r9.OrderBy(Function(p) p.Key)
                Console.WriteLine($"  '{kvp.Key}': {kvp.Value}件")
            Next
        Catch ex As NotImplementedException
            Console.WriteLine("  [未実装] 問題 9-9")
        End Try
    End Sub
End Module
