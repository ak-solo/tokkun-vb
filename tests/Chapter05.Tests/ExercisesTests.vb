Imports Xunit

Public Class Chapter05Tests

    ' --- 問題 5-1 ---
    <Theory>
    <InlineData(New Integer() {1, 2, 3}, New Integer() {2, 4, 6})>
    <InlineData(New Integer() {5, 10, 15}, New Integer() {10, 20, 30})>
    <InlineData(New Integer() {0}, New Integer() {0})>
    Public Sub Test_5_1_Double(numbers As Integer(), expected As Integer())
        Assert.Equal(expected, Exercises.Problem5_1(numbers))
    End Sub

    ' --- 問題 5-2 ---
    <Theory>
    <InlineData(New Integer() {1, 2, 3, 4, 5}, New Integer() {5, 4, 3, 2, 1})>
    <InlineData(New Integer() {10, 20}, New Integer() {20, 10})>
    <InlineData(New Integer() {7}, New Integer() {7})>
    Public Sub Test_5_2_Reverse(numbers As Integer(), expected As Integer())
        Assert.Equal(expected, Exercises.Problem5_2(numbers))
    End Sub

    ' --- 問題 5-3 ---
    <Fact>
    Public Sub Test_5_3_ClassifyEvenOdd()
        Dim numbers = {42, 7, 54, 35, 71, 13, 21, 45, 32, 8}
        Dim result = Exercises.Problem5_3(numbers)
        Assert.Equal({42, 54, 32, 8}, result(0))          ' 偶数（入力順）
        Assert.Equal({7, 35, 71, 13, 21, 45}, result(1))  ' 奇数（入力順）
    End Sub

    <Fact>
    Public Sub Test_5_3_AllEvens()
        Dim result = Exercises.Problem5_3({2, 4, 6})
        Assert.Equal({2, 4, 6}, result(0))
        Assert.Empty(result(1))
    End Sub

    <Fact>
    Public Sub Test_5_3_AllOdds()
        Dim result = Exercises.Problem5_3({1, 3, 5})
        Assert.Empty(result(0))
        Assert.Equal({1, 3, 5}, result(1))
    End Sub

    ' --- 問題 5-4 ---
    <Fact>
    Public Sub Test_5_4_StopWhenSumOver100()
        ' 20+30+10+50=110 で停止 → 4 要素返る
        Dim result = Exercises.Problem5_4({20, 30, 10, 50, 99})
        Assert.Equal({20, 30, 10, 50}, result)
    End Sub

    <Fact>
    Public Sub Test_5_4_StopAt10Items()
        ' 合計が 100 を超えないまま 10 個収集 → 10 要素返る
        Dim input = {5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 99}
        Dim result = Exercises.Problem5_4(input)
        Assert.Equal(10, result.Length)
        Assert.All(result, Function(n) Assert.Equal(5, n))
    End Sub

    <Fact>
    Public Sub Test_5_4_StopImmediately()
        ' 1 つ目で即停止
        Assert.Equal({200}, Exercises.Problem5_4({200, 1, 2}))
    End Sub

    ' --- 問題 5-5 ---
    <Fact>
    Public Sub Test_5_5_BinaryRepresentation()
        Dim result0 = Exercises.Problem5_5(0)
        Assert.Equal(16, result0.Length)
        Assert.All(result0, Function(b) Assert.Equal(0, b))  ' 全ビット 0

        Dim result1 = Exercises.Problem5_5(1)
        Assert.Equal(0, result1(0))    ' MSB = 0
        Assert.Equal(1, result1(15))   ' LSB = 1

        Dim result5 = Exercises.Problem5_5(5)   ' 0000000000000101
        Assert.Equal(1, result5(13))
        Assert.Equal(0, result5(14))
        Assert.Equal(1, result5(15))
        Assert.Equal(0, result5(0))
    End Sub

    <Fact>
    Public Sub Test_5_5_AllOnes()
        ' 65535 = 1111111111111111
        Dim result = Exercises.Problem5_5(65535)
        Assert.All(result, Function(b) Assert.Equal(1, b))
    End Sub

    ' --- 問題 5-6 ---
    <Fact>
    Public Sub Test_5_6_MultiplicationTable()
        Dim kuku = Exercises.Problem5_6()
        Assert.Equal(1, kuku(0, 0))   ' 1×1
        Assert.Equal(6, kuku(1, 2))   ' 2×3
        Assert.Equal(9, kuku(2, 2))   ' 3×3
        Assert.Equal(9, kuku(0, 8))   ' 1×9
        Assert.Equal(81, kuku(8, 8))  ' 9×9
    End Sub

    ' --- 問題 5-7 ---
    <Theory>
    <InlineData(1, 1, 1)>
    <InlineData(3, 4, 12)>
    <InlineData(7, 8, 56)>
    <InlineData(9, 9, 81)>
    Public Sub Test_5_7_KukuLookup(x As Integer, y As Integer, expected As Integer)
        Assert.Equal(expected, Exercises.Problem5_7(x, y))
    End Sub

    ' --- 問題 5-8 ---
    <Theory>
    <InlineData(New Integer() {5, 3, 8, 1}, New Integer() {1, 3, 5, 8})>
    <InlineData(New Integer() {-3, 7, -1, 2}, New Integer() {-3, -1, 2, 7})>
    <InlineData(New Integer() {1}, New Integer() {1})>
    <InlineData(New Integer() {3, 3, 1, 2}, New Integer() {1, 2, 3, 3})>
    Public Sub Test_5_8_Sort(numbers As Integer(), expected As Integer())
        Assert.Equal(expected, Exercises.Problem5_8(numbers))
    End Sub

    <Fact>
    Public Sub Test_5_8_DoesNotMutateInput()
        ' 元の配列を変更していないことを確認
        Dim original = {5, 3, 8, 1}
        Exercises.Problem5_8(original)
        Assert.Equal({5, 3, 8, 1}, original)
    End Sub

End Class
