' Chapter 10 プレイグラウンド — LINQ
' 実行: dotnet run --project playground/Chapter10
'
' src/Chapter10/Exercises.vb に実装を書いてから実行しよう
' 値を変えながら繰り返し試してみよう

Module Program
    Sub Main()
        Dim nums As Integer() = {5, 1, 8, 3, 9, 2}   ' ← この配列を変えて試してみよう
        Dim threshold As Integer = 4                   ' ← この値を変えて試してみよう
        Dim result = Exercises.Problem10_1(nums, threshold)
        Console.WriteLine(String.Join(", ", result))
    End Sub
End Module
