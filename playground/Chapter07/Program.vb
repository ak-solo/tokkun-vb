' Chapter 07 プレイグラウンド — クラスI
' 実行: dotnet run --project playground/Chapter07
'
' src/Chapter07/Exercises.vb に実装を書いてから実行しよう
' 値を変えながら繰り返し試してみよう

Module Program
    Sub Main()
        ' ===== 問題 7-1: フィールドとプロパティ =====
        Dim dog As New Dog()
        dog.Name = "ポチ"
        dog.Age = 3
        Console.WriteLine($"名前: {dog.Name}")
        Console.WriteLine($"年齢: {dog.Age}歳")

        ' ===== 問題 7-2: インスタンスの独立性 =====
        Dim dog1 As New Dog()
        dog1.Name = "ポチ"
        dog1.Age = 3

        Dim dog2 As New Dog()
        dog2.Name = "コロ"
        dog2.Age = 5

        Console.WriteLine($"dog1 → 名前: {dog1.Name}, 年齢: {dog1.Age}歳")
        Console.WriteLine($"dog2 → 名前: {dog2.Name}, 年齢: {dog2.Age}歳")

        ' dog1 を変更しても dog2 は影響を受けない
        dog1.Name = "タロ"
        Console.WriteLine($"dog1.Name を変更後 → dog2.Name = {dog2.Name}")

        ' ===== 問題 7-3: コンストラクタ + ShowProfile =====
        Dim dog3 As New Dog("柴犬")
        dog3.Name = "ポチ"
        dog3.Age = 3
        Console.WriteLine(dog3.ShowProfile())
        ' 複数の犬のプロフィールを表示する
        Dim dogs = {
            New Dog("柴犬"),
            New Dog("トイプードル"),
            New Dog("ゴールデンレトリバー")
        }
        Dim names = {"ポチ", "モコ", "ゴールド"}
        Dim ages = {3, 1, 5}

        For i = 0 To 2
            dogs(i).Name = names(i)
            dogs(i).Age = ages(i)
            Console.WriteLine(dogs(i).ShowProfile())
        Next

        ' ===== 問題 7-4: CoinCase — 枚数管理 =====
        Dim cc As New CoinCase()
        cc.AddCoins(500, 1)
        cc.AddCoins(100, 2)
        cc.AddCoins(50, 3)
        cc.AddCoins(10, 4)
        cc.AddCoins(5, 5)
        cc.AddCoins(1, 6)

        For Each d In {500, 100, 50, 10, 5, 1}
            Console.WriteLine($"{d,4}円: {cc.GetCount(d),3}枚")
        Next
        Console.WriteLine($"合計金額: {cc.GetAmount()}円")

        ' ===== 問題 7-5: CoinCase — 合計金額 =====
        Dim cc2 As New CoinCase()
        cc2.AddCoins(500, 2)
        cc2.AddCoins(100, 5)
        cc2.AddCoins(10, 3)

        Console.WriteLine($"合計枚数: {cc2.GetCount()}枚")
        Console.WriteLine($"500円の合計: {cc2.GetAmount(500)}円")
        Console.WriteLine($"100円の合計: {cc2.GetAmount(100)}円")
        Console.WriteLine($" 10円の合計: {cc2.GetAmount(10)}円")
        Console.WriteLine($"全体の合計: {cc2.GetAmount()}円")
    End Sub
End Module
