' Chapter 08 プレイグラウンド — クラスII
' 実行: dotnet run --project playground/Chapter08
'
' src/Chapter08/Exercises.vb に実装を書いてから実行しよう
' 値を変えながら繰り返し試してみよう

Module Program
    Sub Main()
        ' ===== 問題 8-1: Cat クラス =====
        Try
            Dim cat As New Cat("タマ", 2)
            Console.WriteLine(cat.ShowProfile())
            Console.WriteLine(cat.Sleep())
        Catch ex As NotImplementedException
            Console.WriteLine("  [未実装] 問題 8-1")
        End Try

        ' ===== 問題 8-2: Dog クラス =====
        Try
            Dim dog As New Dog("ポチ", 3)
            Console.WriteLine(dog.ShowProfile())
            Console.WriteLine(dog.Run())
        Catch ex As NotImplementedException
            Console.WriteLine("  [未実装] 問題 8-2")
        End Try

        ' ===== 問題 8-3: Speak のオーバーライド =====
        Try
            Dim cat2 As New Cat("タマ", 2)
            Dim dog2 As New Dog("ポチ", 3)
            Console.WriteLine($"Cat.Speak: {cat2.Speak()}")
            Console.WriteLine($"Dog.Speak: {dog2.Speak()}")
        Catch ex As NotImplementedException
            Console.WriteLine("  [未実装] 問題 8-3")
        End Try

        ' ===== 問題 8-4: ポリモーフィズム =====
        Try
            Dim animals As Animal() = {
                New Cat("タマ", 2),
                New Dog("ポチ", 3),
                New Cat("ミケ", 1),
                New Dog("コロ", 5)
            }

            For Each a In animals
                Console.WriteLine($"{a.ShowProfile()} → {a.Speak()}")
            Next

            ' ===== Animal 型変数に Cat インスタンスを代入してみる =====
            Dim a2 As Animal = New Cat("サクラ", 4)
            Console.WriteLine($"変数の型: Animal、実際のインスタンス: Cat")
            Console.WriteLine($"Speak の結果: {a2.Speak()}")   ' Cat.Speak が呼ばれる
        Catch ex As NotImplementedException
            Console.WriteLine("  [未実装] 問題 8-4")
        End Try
    End Sub
End Module
