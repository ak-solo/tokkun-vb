Imports Xunit

Public Class Chapter08Tests

    ' ===== 問題 8-1: Cat クラス（継承・コンストラクタ・Sleep） =====

    <Fact>
    Public Sub Test_8_1_CatInheritsNameFromAnimal()
        Dim cat As New Cat("タマ", 2)
        Assert.Equal("タマ", cat.Name)
    End Sub

    <Fact>
    Public Sub Test_8_1_CatInheritsAgeFromAnimal()
        Dim cat As New Cat("タマ", 2)
        Assert.Equal(2, cat.Age)
    End Sub

    <Fact>
    Public Sub Test_8_1_CatShowProfile()
        Dim cat As New Cat("タマ", 2)
        Assert.Equal("タマ,2歳", cat.ShowProfile())
    End Sub

    <Fact>
    Public Sub Test_8_1_CatSleep()
        Dim cat As New Cat("タマ", 2)
        Assert.Equal("スースー", cat.Sleep())
    End Sub

    ' ===== 問題 8-2: Dog クラス（継承・コンストラクタ・Run） =====

    <Fact>
    Public Sub Test_8_2_DogInheritsNameFromAnimal()
        Dim dog As New Dog("ポチ", 3)
        Assert.Equal("ポチ", dog.Name)
    End Sub

    <Fact>
    Public Sub Test_8_2_DogInheritsAgeFromAnimal()
        Dim dog As New Dog("ポチ", 3)
        Assert.Equal(3, dog.Age)
    End Sub

    <Fact>
    Public Sub Test_8_2_DogShowProfile()
        Dim dog As New Dog("ポチ", 3)
        Assert.Equal("ポチ,3歳", dog.ShowProfile())
    End Sub

    <Fact>
    Public Sub Test_8_2_DogRun()
        Dim dog As New Dog("ポチ", 3)
        Assert.Equal("トコトコ", dog.Run())
    End Sub

    ' ===== 問題 8-3: Cat.Speak オーバーライド =====

    <Fact>
    Public Sub Test_8_3_CatSpeak()
        Dim cat As New Cat("タマ", 2)
        Assert.Equal("ニャー", cat.Speak())
    End Sub

    <Fact>
    Public Sub Test_8_3_CatSpeakDifferentFromAnimalDefault()
        Dim cat As New Cat("ミケ", 5)
        Assert.NotEqual("......", cat.Speak())
    End Sub

    ' ===== 問題 8-4: Dog.Speak オーバーライド =====

    <Fact>
    Public Sub Test_8_4_DogSpeak()
        Dim dog As New Dog("ポチ", 3)
        Assert.Equal("ワンワン", dog.Speak())
    End Sub

    <Fact>
    Public Sub Test_8_4_DogSpeakDifferentFromAnimalDefault()
        Dim dog As New Dog("コロ", 1)
        Assert.NotEqual("......", dog.Speak())
    End Sub

    ' ===== 問題 8-5: ポリモーフィズム =====

    <Fact>
    Public Sub Test_8_5_AnimalArrayHoldsCatAndDog()
        Dim animals As Animal() = {
            New Cat("タマ", 2),
            New Dog("ポチ", 3),
            New Cat("ミケ", 1),
            New Dog("コロ", 5)
        }
        Assert.Equal(4, animals.Length)
        Assert.IsType(Of Cat)(animals(0))
        Assert.IsType(Of Dog)(animals(1))
        Assert.IsType(Of Cat)(animals(2))
        Assert.IsType(Of Dog)(animals(3))
    End Sub

    <Fact>
    Public Sub Test_8_5_PolymorphicSpeakCallsCorrectOverride()
        Dim animals As Animal() = {
            New Cat("タマ", 2),
            New Dog("ポチ", 3),
            New Cat("ミケ", 1),
            New Dog("コロ", 5)
        }
        Assert.Equal("ニャー", animals(0).Speak())
        Assert.Equal("ワンワン", animals(1).Speak())
        Assert.Equal("ニャー", animals(2).Speak())
        Assert.Equal("ワンワン", animals(3).Speak())
    End Sub

    <Fact>
    Public Sub Test_8_5_PolymorphicShowProfileUsesActualNameAndAge()
        Dim animals As Animal() = {
            New Cat("タマ", 2),
            New Dog("ポチ", 3)
        }
        Assert.Equal("タマ,2歳", animals(0).ShowProfile())
        Assert.Equal("ポチ,3歳", animals(1).ShowProfile())
    End Sub

End Class
