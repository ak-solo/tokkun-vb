Imports Xunit

Public Class Chapter04Tests

    ' --- 問題 4-1 ---
    <Fact>
    Public Sub Test_4_1_Spam()
        Dim result = Exercises.Problem4_1()
        Assert.Equal(10, result.Length)
        Assert.All(result, Sub(s) Assert.Equal("SPAM", s))
    End Sub

    ' --- 問題 4-2 ---
    <Fact>
    Public Sub Test_4_2_MultiplesOf3()
        Dim expected = {3, 6, 9, 12, 15, 18, 21, 24, 27}
        Assert.Equal(expected, Exercises.Problem4_2())
    End Sub

    ' --- 問題 4-3 ---
    <Fact>
    Public Sub Test_4_3_PowersOf2()
        Dim expected = {2, 4, 8, 16, 32, 64, 128, 256}
        Assert.Equal(expected, Exercises.Problem4_3())
    End Sub

    ' --- 問題 4-4 ---
    <Fact>
    Public Sub Test_4_4_Factorial7()
        Assert.Equal(5040, Exercises.Problem4_4())
    End Sub

    ' --- 問題 4-5 ---
    <Theory>
    <InlineData(New Integer() {10, 20, 30}, 20)>
    <InlineData(New Integer() {1, 2, 3, 4}, 2)>   ' 10\4=2（切り捨て）
    <InlineData(New Integer() {100}, 100)>
    Public Sub Test_4_5_Average(numbers As Integer(), expected As Integer)
        Assert.Equal(expected, Exercises.Problem4_5(numbers))
    End Sub

    ' --- 問題 4-6 ---
    <Fact>
    Public Sub Test_4_6_WinsLosses()
        Dim r1 = Exercises.Problem4_6({1, 0, 1, 1, 0})
        Assert.Equal(3, r1(0))   ' wins
        Assert.Equal(2, r1(1))   ' losses

        Dim r2 = Exercises.Problem4_6({0, 0, 0})
        Assert.Equal(0, r2(0))
        Assert.Equal(3, r2(1))
    End Sub

    ' --- 問題 4-7 ---
    <Fact>
    Public Sub Test_4_7_TotalScore()
        Assert.Equal(9, Exercises.Problem4_7_TotalScore({1, 2, 0, 3, 0, 1, 0, 2, 0}))
        Assert.Equal(0, Exercises.Problem4_7_TotalScore({0, 0, 0, 0, 0, 0, 0, 0, 0}))
    End Sub

    <Theory>
    <InlineData(5, 6, "阪神の勝ち")>
    <InlineData(7, 3, "巨人の勝ち")>
    <InlineData(4, 4, "引き分け")>
    Public Sub Test_4_7_Winner(giants As Integer, tigers As Integer, expected As String)
        Assert.Equal(expected, Exercises.Problem4_7_Winner(giants, tigers))
    End Sub

    ' --- 問題 4-8 ---
    <Theory>
    <InlineData(New Integer() {5, 3, 8, 1}, 8)>
    <InlineData(New Integer() {-1, -5, -3}, -1)>
    <InlineData(New Integer() {7}, 7)>
    Public Sub Test_4_8_Max(numbers As Integer(), expected As Integer)
        Assert.Equal(expected, Exercises.Problem4_8(numbers))
    End Sub

    ' --- 問題 4-9 ---
    <Fact>
    Public Sub Test_4_9_MaxMin()
        Dim r1 = Exercises.Problem4_9({5, 3, 8, 1, 9})
        Assert.Equal(9, r1(0))   ' max
        Assert.Equal(1, r1(1))   ' min

        Dim r2 = Exercises.Problem4_9({-3, -1, -5})
        Assert.Equal(-1, r2(0))
        Assert.Equal(-5, r2(1))
    End Sub

    ' --- 問題 4-10 ---
    <Theory>
    <InlineData(0, "")>
    <InlineData(3, "***")>
    <InlineData(5, "*****")>
    Public Sub Test_4_10_Asterisks(n As Integer, expected As String)
        Assert.Equal(expected, Exercises.Problem4_10(n))
    End Sub

    ' --- 問題 4-11 ---
    <Theory>
    <InlineData(0, "")>
    <InlineData(5, "01234")>
    <InlineData(14, "01234567890123")>
    Public Sub Test_4_11_CyclingDigits(n As Integer, expected As String)
        Assert.Equal(expected, Exercises.Problem4_11(n))
    End Sub

    ' --- 問題 4-12 ---
    <Theory>
    <InlineData(New Integer() {30, 40, 50, 60}, 120)>   ' 30+40+50=120 で停止
    <InlineData(New Integer() {101}, 101)>
    <InlineData(New Integer() {50, 51}, 101)>
    Public Sub Test_4_12_SumUntilOver100(numbers As Integer(), expected As Integer)
        Assert.Equal(expected, Exercises.Problem4_12(numbers))
    End Sub

    ' --- 問題 4-13 ---
    <Theory>
    <InlineData(New Integer() {1, 2, 1, 1}, "3ストライク,1ボール")>
    <InlineData(New Integer() {2, 2, 2, 2}, "0ストライク,4ボール")>
    <InlineData(New Integer() {1, 2, 1, 2, 2, 2}, "2ストライク,4ボール")>
    Public Sub Test_4_13_StrikeBall(pitches As Integer(), expected As String)
        Assert.Equal(expected, Exercises.Problem4_13(pitches))
    End Sub

    ' --- 問題 4-14 ---
    <Theory>
    <InlineData(New Integer() {3, 3, 1}, "3ストライク,0ボール")>         ' foul→1S,foul→2S,strike→3S
    <InlineData(New Integer() {1, 1, 3, 1}, "3ストライク,0ボール")>      ' 2S後にfoul→変化なし,strike→3S
    <InlineData(New Integer() {3, 3, 3, 2, 2, 2, 2}, "2ストライク,4ボール")>
    Public Sub Test_4_14_StrikeBallFoul(pitches As Integer(), expected As String)
        Assert.Equal(expected, Exercises.Problem4_14(pitches))
    End Sub

    ' --- 問題 4-15 ---
    <Fact>
    Public Sub Test_4_15_PrimeFactors()
        Assert.Equal({2, 2, 3}, Exercises.Problem4_15(12))
        Assert.Equal({2, 2, 3, 5, 5, 67}, Exercises.Problem4_15(20100))
        Assert.Equal({7}, Exercises.Problem4_15(7))
        Assert.Equal({2}, Exercises.Problem4_15(2))
    End Sub

    ' --- 問題 4-16 ---
    <Theory>
    <InlineData(7, True)>
    <InlineData(13, True)>
    <InlineData(4, False)>
    <InlineData(9, False)>
    <InlineData(100, False)>
    <InlineData(97, True)>
    Public Sub Test_4_16_IsPrime(n As Integer, expected As Boolean)
        Assert.Equal(expected, Exercises.Problem4_16(n))
    End Sub

    ' --- 問題 4-17 ---
    <Fact>
    Public Sub Test_4_17_MultiplicationTable()
        Dim kuku = Exercises.Problem4_17()
        Assert.Equal(1, kuku(0, 0))    ' 1×1
        Assert.Equal(9, kuku(2, 2))    ' 3×3
        Assert.Equal(81, kuku(8, 8))   ' 9×9
        Assert.Equal(9, kuku(0, 8))    ' 1×9
        Assert.Equal(6, kuku(1, 2))    ' 2×3
    End Sub

    ' --- 問題 4-18 ---
    <Theory>
    <InlineData(New Integer() {5, 10, 3, 0}, 18)>
    <InlineData(New Integer() {100, 0}, 100)>
    <InlineData(New Integer() {0}, 0)>
    Public Sub Test_4_18_SumUntilZero(numbers As Integer(), expected As Integer)
        Assert.Equal(expected, Exercises.Problem4_18(numbers))
    End Sub

    ' --- 問題 4-19 ---
    <Theory>
    <InlineData(New Integer() {5, 10, 3, 0}, 6)>    ' (5+10+3)\3=6
    <InlineData(New Integer() {3, 4, 0}, 3)>         ' (3+4)\2=3（切り捨て）
    <InlineData(New Integer() {10, 0}, 10)>
    Public Sub Test_4_19_AverageUntilZero(numbers As Integer(), expected As Integer)
        Assert.Equal(expected, Exercises.Problem4_19(numbers))
    End Sub

    ' --- 問題 4-20 ---
    <Fact>
    Public Sub Test_4_20_Triangle()
        Assert.Equal({"$"}, Exercises.Problem4_20(1))
        Assert.Equal({"$", "$$", "$$$"}, Exercises.Problem4_20(3))
        Assert.Equal({"$", "$$", "$$$", "$$$$"}, Exercises.Problem4_20(4))
    End Sub

    ' --- 問題 4-21 ---
    <Fact>
    Public Sub Test_4_21_XPattern()
        Assert.Equal({"X X", " X", "X X"}, Exercises.Problem4_21(3))
        Assert.Equal({"X  X", " XX", " XX", "X  X"}, Exercises.Problem4_21(4))
        Assert.Equal({"X   X", " X X", "  X", " X X", "X   X"}, Exercises.Problem4_21(5))
    End Sub

    ' --- 問題 4-22 ---
    <Fact>
    Public Sub Test_4_22_Fibonacci()
        Dim fib = Exercises.Problem4_22()
        Assert.Equal(17, fib.Length)
        Assert.Equal(0, fib(0))
        Assert.Equal(1, fib(1))
        Assert.Equal(1, fib(2))
        Assert.Equal(5, fib(5))
        Assert.Equal(987, fib(16))
    End Sub

End Class
