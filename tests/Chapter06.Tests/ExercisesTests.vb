Imports Xunit

Public Class Chapter06Tests

    ' --- 問題 6-1: 2 乗 ---

    <Theory>
    <InlineData(0, 0)>
    <InlineData(1, 1)>
    <InlineData(5, 25)>
    <InlineData(-3, 9)>
    <InlineData(10, 100)>
    Public Sub Test_6_1_Square(n As Integer, expected As Integer)
        Assert.Equal(expected, Exercises.Problem6_1(n))
    End Sub

    ' --- 問題 6-2: 平均（整数除算）---

    <Theory>
    <InlineData(3, 5, 4)>
    <InlineData(0, 10, 5)>
    <InlineData(7, 7, 7)>
    <InlineData(1, 2, 1)>
    <InlineData(-4, 4, 0)>
    Public Sub Test_6_2_Average(a As Integer, b As Integer, expected As Integer)
        Assert.Equal(expected, Exercises.Problem6_2(a, b))
    End Sub

    ' --- 問題 6-3: 大きい方 ---

    <Theory>
    <InlineData(3, 5, 5)>
    <InlineData(5, 3, 5)>
    <InlineData(4, 4, 4)>
    <InlineData(-1, -5, -1)>
    <InlineData(0, 100, 100)>
    Public Sub Test_6_3_Max(a As Integer, b As Integer, expected As Integer)
        Assert.Equal(expected, Exercises.Problem6_3(a, b))
    End Sub

    ' --- 問題 6-4: $ 三角形 ---

    <Fact>
    Public Sub Test_6_4_TriangleSize1()
        Assert.Equal("$", Exercises.Problem6_4(1))
    End Sub

    <Fact>
    Public Sub Test_6_4_TriangleSize3()
        Dim expected = "$" & Environment.NewLine & "$$" & Environment.NewLine & "$$$"
        Assert.Equal(expected, Exercises.Problem6_4(3))
    End Sub

    <Fact>
    Public Sub Test_6_4_TriangleSize5_RowCount()
        Dim result = Exercises.Problem6_4(5)
        Dim lines = result.Split(Environment.NewLine)
        Assert.Equal(5, lines.Length)
        For i = 0 To 4
            Assert.Equal(i + 1, lines(i).Length)
        Next
    End Sub

    ' --- 問題 6-5: 任意文字の三角形 ---

    <Fact>
    Public Sub Test_6_5_TriangleWithHash()
        Dim expected = "#" & Environment.NewLine & "##" & Environment.NewLine & "###"
        Assert.Equal(expected, Exercises.Problem6_5(3, "#"c))
    End Sub

    <Fact>
    Public Sub Test_6_5_TriangleWithStar_Size4()
        Dim result = Exercises.Problem6_5(4, "*"c)
        Dim lines = result.Split(Environment.NewLine)
        Assert.Equal(4, lines.Length)
        For i = 0 To 3
            Assert.Equal(New String("*"c, i + 1), lines(i))
        Next
    End Sub

    <Fact>
    Public Sub Test_6_5_TriangleSingleRow()
        Assert.Equal("A", Exercises.Problem6_5(1, "A"c))
    End Sub

    ' --- 問題 6-6: 九九の一段 ---

    <Fact>
    Public Sub Test_6_6_KukuRow1()
        Dim result = Exercises.Problem6_6(1)
        Dim lines = result.Split(Environment.NewLine)
        Assert.Equal(9, lines.Length)
        Assert.Equal("1×1=1", lines(0))
        Assert.Equal("1×9=9", lines(8))
    End Sub

    <Fact>
    Public Sub Test_6_6_KukuRow3()
        Dim result = Exercises.Problem6_6(3)
        Dim lines = result.Split(Environment.NewLine)
        Assert.Equal(9, lines.Length)
        Assert.Equal("3×1=3", lines(0))
        Assert.Equal("3×5=15", lines(4))
        Assert.Equal("3×9=27", lines(8))
    End Sub

    <Fact>
    Public Sub Test_6_6_KukuRow9()
        Dim result = Exercises.Problem6_6(9)
        Dim lines = result.Split(Environment.NewLine)
        Assert.Equal("9×1=9", lines(0))
        Assert.Equal("9×9=81", lines(8))
    End Sub

    ' --- 問題 6-7: 素数判定 ---

    <Theory>
    <InlineData(1, False)>
    <InlineData(2, True)>
    <InlineData(3, True)>
    <InlineData(4, False)>
    <InlineData(17, True)>
    <InlineData(25, False)>
    <InlineData(97, True)>
    <InlineData(100, False)>
    Public Sub Test_6_7_IsPrime(n As Integer, expected As Boolean)
        Assert.Equal(expected, Exercises.Problem6_7(n))
    End Sub

    ' --- 問題 6-8: ByRef スワップ ---

    <Fact>
    Public Sub Test_6_8_SwapPositiveNumbers()
        Dim a = 10, b = 20
        Exercises.Problem6_8(a, b)
        Assert.Equal(20, a)
        Assert.Equal(10, b)
    End Sub

    <Fact>
    Public Sub Test_6_8_SwapNegativeAndPositive()
        Dim a = -5, b = 100
        Exercises.Problem6_8(a, b)
        Assert.Equal(100, a)
        Assert.Equal(-5, b)
    End Sub

    <Fact>
    Public Sub Test_6_8_SwapSameValue()
        Dim a = 7, b = 7
        Exercises.Problem6_8(a, b)
        Assert.Equal(7, a)
        Assert.Equal(7, b)
    End Sub

    ' --- 問題 6-9: 配列のインプレースソート ---

    <Fact>
    Public Sub Test_6_9_SortBasic()
        Dim arr = {5, 3, 8, 1, 9, 2}
        Exercises.Problem6_9(arr)
        Assert.Equal({1, 2, 3, 5, 8, 9}, arr)
    End Sub

    <Fact>
    Public Sub Test_6_9_AlreadySorted()
        Dim arr = {1, 2, 3}
        Exercises.Problem6_9(arr)
        Assert.Equal({1, 2, 3}, arr)
    End Sub

    <Fact>
    Public Sub Test_6_9_ReverseOrder()
        Dim arr = {9, 7, 5, 3, 1}
        Exercises.Problem6_9(arr)
        Assert.Equal({1, 3, 5, 7, 9}, arr)
    End Sub

    <Fact>
    Public Sub Test_6_9_SingleElement()
        Dim arr = {42}
        Exercises.Problem6_9(arr)
        Assert.Equal({42}, arr)
    End Sub

    <Fact>
    Public Sub Test_6_9_WithDuplicates()
        Dim arr = {3, 1, 4, 1, 5, 9, 2, 6}
        Exercises.Problem6_9(arr)
        Assert.Equal({1, 1, 2, 3, 4, 5, 6, 9}, arr)
    End Sub

End Class
