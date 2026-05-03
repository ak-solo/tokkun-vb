Imports Xunit

Public Class Chapter07Tests

    ' ===== 問題 7-1: Name プロパティ =====

    <Fact>
    Public Sub Test_7_1_NameGetSet()
        Dim dog As New Dog()
        dog.Name = "ポチ"
        Assert.Equal("ポチ", dog.Name)
    End Sub

    <Fact>
    Public Sub Test_7_1_NameCanBeUpdated()
        Dim dog As New Dog()
        dog.Name = "コロ"
        dog.Name = "タロ"
        Assert.Equal("タロ", dog.Name)
    End Sub

    <Fact>
    Public Sub Test_7_1_DefaultNameIsEmpty()
        Dim dog As New Dog()
        Assert.Equal("", dog.Name)
    End Sub

    ' ===== 問題 7-2: Age プロパティ =====

    <Fact>
    Public Sub Test_7_2_AgeGetSet()
        Dim dog As New Dog()
        dog.Age = 3
        Assert.Equal(3, dog.Age)
    End Sub

    <Fact>
    Public Sub Test_7_2_DefaultAgeIsZero()
        Dim dog As New Dog()
        Assert.Equal(0, dog.Age)
    End Sub

    ' ===== 問題 7-3: インスタンスの独立性 =====

    <Fact>
    Public Sub Test_7_3_TwoInstancesAreIndependent()
        Dim dog1 As New Dog()
        dog1.Name = "ポチ"
        dog1.Age = 3

        Dim dog2 As New Dog()
        dog2.Name = "コロ"
        dog2.Age = 5

        Assert.Equal("ポチ", dog1.Name)
        Assert.Equal(3, dog1.Age)
        Assert.Equal("コロ", dog2.Name)
        Assert.Equal(5, dog2.Age)
    End Sub

    <Fact>
    Public Sub Test_7_3_ChangingOneDoesNotAffectOther()
        Dim dog1 As New Dog()
        dog1.Name = "ポチ"
        Dim dog2 As New Dog()
        dog2.Name = "コロ"

        dog1.Name = "タロ"

        Assert.Equal("タロ", dog1.Name)
        Assert.Equal("コロ", dog2.Name)   ' dog2 は影響を受けない
    End Sub

    ' ===== 問題 7-4: コンストラクタ・Breed・ShowProfile =====

    <Fact>
    Public Sub Test_7_4_BreedSetByConstructor()
        Dim dog As New Dog("柴犬")
        Assert.Equal("柴犬", dog.Breed)
    End Sub

    <Fact>
    Public Sub Test_7_4_ShowProfile()
        Dim dog As New Dog("柴犬")
        dog.Name = "ポチ"
        dog.Age = 3
        Assert.Equal("柴犬: ポチ (3歳)", dog.ShowProfile())
    End Sub

    <Fact>
    Public Sub Test_7_4_ShowProfileDifferentDog()
        Dim dog As New Dog("トイプードル")
        dog.Name = "モコ"
        dog.Age = 1
        Assert.Equal("トイプードル: モコ (1歳)", dog.ShowProfile())
    End Sub

    <Fact>
    Public Sub Test_7_4_MultipleBreeds()
        Dim dog1 As New Dog("柴犬")
        Dim dog2 As New Dog("ゴールデンレトリバー")
        Assert.Equal("柴犬", dog1.Breed)
        Assert.Equal("ゴールデンレトリバー", dog2.Breed)
    End Sub

    ' ===== 問題 7-5: CoinCase 基本機能 =====

    <Fact>
    Public Sub Test_7_5_AddCoinsAndGetCount()
        Dim cc As New CoinCase()
        cc.AddCoins(500, 2)
        cc.AddCoins(100, 5)
        Assert.Equal(2, cc.GetCount(500))
        Assert.Equal(5, cc.GetCount(100))
    End Sub

    <Fact>
    Public Sub Test_7_5_InitialCountIsZero()
        Dim cc As New CoinCase()
        For Each d In {500, 100, 50, 10, 5, 1}
            Assert.Equal(0, cc.GetCount(d))
        Next
    End Sub

    <Fact>
    Public Sub Test_7_5_AddCoinsAccumulates()
        Dim cc As New CoinCase()
        cc.AddCoins(10, 3)
        cc.AddCoins(10, 4)
        Assert.Equal(7, cc.GetCount(10))
    End Sub

    <Fact>
    Public Sub Test_7_5_InvalidDenominationIsIgnored()
        Dim cc As New CoinCase()
        cc.AddCoins(200, 10)   ' 200 円は無効
        cc.AddCoins(0, 5)      ' 0 円は無効
        Assert.Equal(0, cc.GetCount(500))
        Assert.Equal(0, cc.GetCount(100))
    End Sub

    <Fact>
    Public Sub Test_7_5_GetAmount_Total()
        Dim cc As New CoinCase()
        cc.AddCoins(500, 1)
        cc.AddCoins(100, 2)
        cc.AddCoins(50, 3)
        cc.AddCoins(10, 4)
        cc.AddCoins(5, 5)
        cc.AddCoins(1, 6)
        ' 500 + 200 + 150 + 40 + 25 + 6 = 921
        Assert.Equal(921, cc.GetAmount())
    End Sub

    <Fact>
    Public Sub Test_7_5_GetAmount_EmptyIsZero()
        Dim cc As New CoinCase()
        Assert.Equal(0, cc.GetAmount())
    End Sub

    ' ===== 問題 7-6: オーバーロード =====

    <Fact>
    Public Sub Test_7_6_GetCountNoArgs_Total()
        Dim cc As New CoinCase()
        cc.AddCoins(500, 2)
        cc.AddCoins(100, 3)
        cc.AddCoins(10, 5)
        Assert.Equal(10, cc.GetCount())   ' 2 + 3 + 5 = 10
    End Sub

    <Fact>
    Public Sub Test_7_6_GetCountNoArgs_EmptyIsZero()
        Dim cc As New CoinCase()
        Assert.Equal(0, cc.GetCount())
    End Sub

    <Fact>
    Public Sub Test_7_6_GetAmountByDenomination()
        Dim cc As New CoinCase()
        cc.AddCoins(100, 4)
        cc.AddCoins(50, 3)
        Assert.Equal(400, cc.GetAmount(100))
        Assert.Equal(150, cc.GetAmount(50))
    End Sub

    <Fact>
    Public Sub Test_7_6_GetAmountByDenomination_EmptyIsZero()
        Dim cc As New CoinCase()
        Assert.Equal(0, cc.GetAmount(500))
    End Sub

    ' ===== Problem7_1 =====

    <Theory>
    <InlineData("ポチ")>
    <InlineData("コロ")>
    <InlineData("")>
    Public Sub Test_7_1_Problem(name As String)
        Assert.Equal(name, Exercises.Problem7_1(name))
    End Sub

    ' ===== Problem7_2 =====

    <Theory>
    <InlineData("ポチ", 3, "ポチ,3")>
    <InlineData("コロ", 5, "コロ,5")>
    Public Sub Test_7_2_Problem(name As String, age As Integer, expected As String)
        Assert.Equal(expected, Exercises.Problem7_2(name, age))
    End Sub

    ' ===== Problem7_3 =====

    <Fact>
    Public Sub Test_7_3_Problem_IndependentInstances()
        Assert.Equal("タロ,コロ", Exercises.Problem7_3())
    End Sub

    ' ===== Problem7_4 =====

    <Theory>
    <InlineData("柴犬", "ポチ", 3, "柴犬: ポチ (3歳)")>
    <InlineData("トイプードル", "モコ", 1, "トイプードル: モコ (1歳)")>
    Public Sub Test_7_4_Problem(breed As String, name As String, age As Integer, expected As String)
        Assert.Equal(expected, Exercises.Problem7_4(breed, name, age))
    End Sub

    ' ===== Problem7_5 =====

    <Theory>
    <InlineData(500, 2, 1000)>
    <InlineData(100, 5, 500)>
    <InlineData(10, 3, 30)>
    Public Sub Test_7_5_Problem(denomination As Integer, count As Integer, expected As Integer)
        Assert.Equal(expected, Exercises.Problem7_5(denomination, count))
    End Sub

    ' ===== Problem7_6 =====

    <Theory>
    <InlineData(100, 4, "4,400")>
    <InlineData(500, 3, "3,1500")>
    Public Sub Test_7_6_Problem(denomination As Integer, count As Integer, expected As String)
        Assert.Equal(expected, Exercises.Problem7_6(denomination, count))
    End Sub

End Class
