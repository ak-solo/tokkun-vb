' Chapter 02 プレイグラウンド — 引数と戻り値
' 実行: dotnet run --project playground/Chapter02
'
' src/Chapter02/Exercises.vb に実装を書いてから実行しよう
' 値を変えながら繰り返し試してみよう

Module Program
    Sub Main()
        Dim s As String = "Hello VB.NET"   ' ← この値を変えて試してみよう
        Console.WriteLine(Exercises.Problem2_1(s))
    End Sub
End Module
