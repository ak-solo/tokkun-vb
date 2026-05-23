' Chapter 05 プレイグラウンド — 配列
' 実行: dotnet run --project playground/Chapter05
'
' src/Chapter05/Exercises.vb に実装を書いてから実行しよう
' 値を変えながら繰り返し試してみよう

Module Program
    Sub Main()
        Dim numbers As Integer() = {3, 7, 1, 9, 4}   ' ← この配列を変えて試してみよう
        Console.WriteLine(String.Join(", ", Exercises.Problem5_1(numbers)))
    End Sub
End Module
