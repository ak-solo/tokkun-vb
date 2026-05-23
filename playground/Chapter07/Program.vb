' Chapter 07 プレイグラウンド — クラスI
' 実行: dotnet run --project playground/Chapter07
'
' src/Chapter07/Exercises.vb に実装を書いてから実行しよう
' 値を変えながら繰り返し試してみよう

Module Program
    Sub Main()
        Dim dog As New Dog()
        dog.Name = "ポチ"   ' ← この値を変えて試してみよう
        dog.Age = 3          ' ← この値を変えて試してみよう
        Console.WriteLine($"名前: {dog.Name}")
        Console.WriteLine($"年齢: {dog.Age}歳")
    End Sub
End Module
