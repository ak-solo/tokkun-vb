' Chapter 08 プレイグラウンド — クラスII
' 実行: dotnet run --project playground/Chapter08
'
' src/Chapter08/Exercises.vb に実装を書いてから実行しよう
' 値を変えながら繰り返し試してみよう

Module Program
    Sub Main()
        Dim cat As New Cat("タマ", 2)   ' ← この値を変えて試してみよう
        Console.WriteLine(cat.ShowProfile())
        Console.WriteLine(cat.Sleep())
    End Sub
End Module
