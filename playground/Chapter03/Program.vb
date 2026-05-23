' Chapter 03 プレイグラウンド — 分岐
' 実行: dotnet run --project playground/Chapter03
'
' src/Chapter03/Exercises.vb に実装を書いてから実行しよう
' 値を変えながら繰り返し試してみよう

Module Program
    Sub Main()
        Dim x As Integer = 10   ' ← この値を変えて試してみよう
        Dim y As Integer = 5    ' ← この値を変えて試してみよう
        Console.WriteLine(Exercises.Problem3_1(x, y))
    End Sub
End Module
