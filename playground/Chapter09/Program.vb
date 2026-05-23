' Chapter 09 プレイグラウンド — 文字列・日付操作
' 実行: dotnet run --project playground/Chapter09
'
' src/Chapter09/Exercises.vb に実装を書いてから実行しよう
' 値を変えながら繰り返し試してみよう

Module Program
    Sub Main()
        Dim input As String = "  hello world  "   ' ← この値を変えて試してみよう
        Console.WriteLine(Exercises.Problem9_1(input))
    End Sub
End Module
