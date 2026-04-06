Imports Xunit

Public Class Chapter02Tests

    ' --- 問題 2-1 ---
    <Theory>
    <InlineData("hello")>
    <InlineData("VB.NET")>
    <InlineData("12345")>
    <InlineData("")>
    Public Sub Test_2_1_ReturnInputString(s As String)
        Assert.Equal(s, Exercises.Problem2_1(s))
    End Sub

    ' --- 問題 2-2 ---
    <Theory>
    <InlineData(0)>
    <InlineData(42)>
    <InlineData(-7)>
    <InlineData(100)>
    Public Sub Test_2_2_ReturnInputInteger(x As Integer)
        Assert.Equal(x, Exercises.Problem2_2(x))
    End Sub

    ' --- 問題 2-3 ---
    <Theory>
    <InlineData(2, 2, 4, 8)>
    <InlineData(3, 3, 9, 27)>
    <InlineData(5, 5, 25, 125)>
    <InlineData(1, 1, 1, 1)>
    Public Sub Test_2_3_Powers(x As Integer, exp1 As Integer, exp2 As Integer, exp3 As Integer)
        Dim result = Exercises.Problem2_3(x)
        Assert.Equal(exp1, result(0))
        Assert.Equal(exp2, result(1))
        Assert.Equal(exp3, result(2))
    End Sub

    ' --- 問題 2-4: 和 ---
    <Theory>
    <InlineData(10, 3, 13)>
    <InlineData(0, 0, 0)>
    <InlineData(-5, 5, 0)>
    <InlineData(100, 200, 300)>
    Public Sub Test_2_4_Sum(x As Integer, y As Integer, expected As Integer)
        Assert.Equal(expected, Exercises.Problem2_4_Sum(x, y))
    End Sub

    ' --- 問題 2-4: 差 ---
    <Theory>
    <InlineData(10, 3, 7)>
    <InlineData(5, 5, 0)>
    <InlineData(3, 10, -7)>
    <InlineData(0, 100, -100)>
    Public Sub Test_2_4_Difference(x As Integer, y As Integer, expected As Integer)
        Assert.Equal(expected, Exercises.Problem2_4_Difference(x, y))
    End Sub

    ' --- 問題 2-4: 積 ---
    <Theory>
    <InlineData(10, 3, 30)>
    <InlineData(0, 5, 0)>
    <InlineData(-4, 3, -12)>
    <InlineData(7, 7, 49)>
    Public Sub Test_2_4_Product(x As Integer, y As Integer, expected As Integer)
        Assert.Equal(expected, Exercises.Problem2_4_Product(x, y))
    End Sub

    ' --- 問題 2-4: 除算（Double）---
    <Theory>
    <InlineData(10, 3)>
    <InlineData(7, 2)>
    <InlineData(1, 4)>
    Public Sub Test_2_4_Division(x As Integer, y As Integer)
        Dim expected As Double = CDbl(x) / CDbl(y)
        Assert.Equal(expected, Exercises.Problem2_4_Division(x, y), 10)
    End Sub

    ' --- 問題 2-4: 商 ---
    <Theory>
    <InlineData(10, 3, 3)>
    <InlineData(7, 2, 3)>
    <InlineData(20, 4, 5)>
    <InlineData(1, 5, 0)>
    Public Sub Test_2_4_Quotient(x As Integer, y As Integer, expected As Integer)
        Assert.Equal(expected, Exercises.Problem2_4_Quotient(x, y))
    End Sub

    ' --- 問題 2-4: 余り ---
    <Theory>
    <InlineData(10, 3, 1)>
    <InlineData(7, 2, 1)>
    <InlineData(20, 4, 0)>
    <InlineData(1, 5, 1)>
    Public Sub Test_2_4_Remainder(x As Integer, y As Integer, expected As Integer)
        Assert.Equal(expected, Exercises.Problem2_4_Remainder(x, y))
    End Sub

    ' --- 問題 2-5 ---
    <Theory>
    <InlineData(10, 6, 8)>
    <InlineData(3, 4, 3)>
    <InlineData(0, 0, 0)>
    <InlineData(1, 100, 50)>
    Public Sub Test_2_5_Average(a As Integer, b As Integer, expected As Integer)
        Assert.Equal(expected, Exercises.Problem2_5(a, b))
    End Sub

    ' --- 問題 2-6 ---
    <Theory>
    <InlineData(1, 365)>
    <InlineData(20, 7300)>
    <InlineData(50, 18250)>
    <InlineData(0, 0)>
    Public Sub Test_2_6_AgeToDays(age As Integer, expected As Integer)
        Assert.Equal(expected, Exercises.Problem2_6(age))
    End Sub

End Class
