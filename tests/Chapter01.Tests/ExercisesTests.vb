Imports Xunit

Public Class Chapter01Tests

    ' --- 問題 1-1 ---
    <Fact>
    Public Sub Test_1_1_HelloWorld()
        Assert.Equal("Hello World", Exercises.Problem1_1())
    End Sub

    ' --- 問題 1-2 ---
    <Fact>
    Public Sub Test_1_2_VariableDisplay()
        Assert.Equal("x=11", Exercises.Problem1_2())
    End Sub

    ' --- 問題 1-3 ---
    <Fact>
    Public Sub Test_1_3_TwoVariables()
        Assert.Equal("x=13,y=17", Exercises.Problem1_3())
    End Sub

    ' --- 問題 1-4 ---
    <Fact>
    Public Sub Test_1_4_SumOf13And17()
        Assert.Equal(30, Exercises.Problem1_4())
    End Sub

    ' --- 問題 1-5 ---
    <Fact>
    Public Sub Test_1_5_ProductOf13And17()
        Assert.Equal(221, Exercises.Problem1_5())
    End Sub

    ' --- 問題 1-6 ---
    <Fact>
    Public Sub Test_1_6_TripleThenHalf()
        Assert.Equal("21,10", Exercises.Problem1_6())
    End Sub

    ' --- 問題 1-7 ---
    <Fact>
    Public Sub Test_1_7_SwapVariables()
        Assert.Equal("x=7,y=3", Exercises.Problem1_7())
    End Sub

    ' --- 問題 1-8 ---
    <Fact>
    Public Sub Test_1_8_ProductOf19And23()
        Assert.Equal(437, Exercises.Problem1_8())
    End Sub

    ' --- 問題 1-9 ---
    <Fact>
    Public Sub Test_1_9_DivisionReturnsDouble()
        Dim result = Exercises.Problem1_9()
        Assert.IsType(Of Double)(result)
        Assert.Equal(10.0 / 3.0, result, 10)
    End Sub

    ' --- 問題 1-10 ---
    <Fact>
    Public Sub Test_1_10_IntegerDivision()
        Assert.Equal(3, Exercises.Problem1_10())
    End Sub

End Class
