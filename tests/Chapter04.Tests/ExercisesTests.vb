Imports Xunit

Public Class Chapter04Tests

    ' --- 問題 4-1 ---
    <Fact>
    Public Sub Test_4_1_Spam()
        Assert.Equal("SPAM,SPAM,SPAM,SPAM,SPAM,SPAM,SPAM,SPAM,SPAM,SPAM", Exercises.Problem4_1())
    End Sub

    ' --- 問題 4-2 ---
    <Fact>
    Public Sub Test_4_2_MultiplesOf3()
        Assert.Equal("3,6,9,12,15,18,21,24,27", Exercises.Problem4_2())
    End Sub

    ' --- 問題 4-3 ---
    <Fact>
    Public Sub Test_4_3_PowersOf2()
        Assert.Equal("2,4,8,16,32,64,128,256", Exercises.Problem4_3())
    End Sub

    ' --- 問題 4-4 ---
    <Fact>
    Public Sub Test_4_4_Factorial7()
        Assert.Equal(5040, Exercises.Problem4_4())
    End Sub

    ' --- 問題 4-5 ---
    <Theory>
    <InlineData(0, "")>
    <InlineData(3, "***")>
    <InlineData(5, "*****")>
    Public Sub Test_4_5_Asterisks(n As Integer, expected As String)
        Assert.Equal(expected, Exercises.Problem4_5(n))
    End Sub

    ' --- 問題 4-6 ---
    <Theory>
    <InlineData(0, "")>
    <InlineData(5, "01234")>
    <InlineData(14, "01234567890123")>
    Public Sub Test_4_6_CyclingDigits(n As Integer, expected As String)
        Assert.Equal(expected, Exercises.Problem4_6(n))
    End Sub

    ' --- 問題 4-7 ---
    <Fact>
    Public Sub Test_4_7_PrimeFactors()
        Assert.Equal("2,2,3", Exercises.Problem4_7(12))
        Assert.Equal("2,2,3,5,5,67", Exercises.Problem4_7(20100))
        Assert.Equal("7", Exercises.Problem4_7(7))
        Assert.Equal("2", Exercises.Problem4_7(2))
    End Sub

    ' --- 問題 4-8 ---
    <Theory>
    <InlineData(7, True)>
    <InlineData(13, True)>
    <InlineData(4, False)>
    <InlineData(9, False)>
    <InlineData(100, False)>
    <InlineData(97, True)>
    Public Sub Test_4_8_IsPrime(n As Integer, expected As Boolean)
        Assert.Equal(expected, Exercises.Problem4_8(n))
    End Sub

    ' --- 問題 4-9 ---
    <Fact>
    Public Sub Test_4_9_Triangle()
        Assert.Equal("$", Exercises.Problem4_9(1))
        Assert.Equal(String.Join(Environment.NewLine, "$", "$$", "$$$"), Exercises.Problem4_9(3))
        Assert.Equal(String.Join(Environment.NewLine, "$", "$$", "$$$", "$$$$"), Exercises.Problem4_9(4))
    End Sub

    ' --- 問題 4-10 ---
    <Fact>
    Public Sub Test_4_10_XPattern()
        Assert.Equal(String.Join(Environment.NewLine, "X X", " X ", "X X"), Exercises.Problem4_10(3))
        Assert.Equal(String.Join(Environment.NewLine, "X  X", " XX ", " XX ", "X  X"), Exercises.Problem4_10(4))
        Assert.Equal(String.Join(Environment.NewLine, "X   X", " X X ", "  X  ", " X X ", "X   X"), Exercises.Problem4_10(5))
    End Sub

    ' --- 問題 4-11 ---
    <Fact>
    Public Sub Test_4_11_Fibonacci()
        Assert.Equal("0,1,1,2,3,5,8,13,21,34,55,89,144,233,377,610,987", Exercises.Problem4_11())
    End Sub

End Class
