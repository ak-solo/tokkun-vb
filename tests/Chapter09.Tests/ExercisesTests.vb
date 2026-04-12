Imports Xunit

Public Class Chapter09Tests

    ' ===== 問題 9-1: Where + OrderBy =====

    <Theory>
    <InlineData(New Integer() {5, 1, 8, 3, 9, 2}, 4, New Integer() {5, 8, 9})>
    <InlineData(New Integer() {10, 2, 5, 7, 1}, 5, New Integer() {5, 7, 10})>
    <InlineData(New Integer() {1, 2, 3}, 10, New Integer() {})>
    <InlineData(New Integer() {5, 5, 5}, 3, New Integer() {5, 5, 5})>
    Public Sub Test_9_1_FilterAndSort(numbers As Integer(), threshold As Integer, expected As Integer())
        Assert.Equal(expected, Exercises.Problem9_1(numbers, threshold))
    End Sub

    <Fact>
    Public Sub Test_9_1_ThresholdIsInclusive()
        ' threshold と同じ値は含まれる（以上）
        Assert.Equal({4, 4}, Exercises.Problem9_1({4, 4}, 4))
    End Sub

    ' ===== 問題 9-2: Select =====

    <Theory>
    <InlineData(New Integer() {3, 1, 4}, New String() {"3番", "1番", "4番"})>
    <InlineData(New Integer() {10}, New String() {"10番"})>
    <InlineData(New Integer() {1, 2, 3}, New String() {"1番", "2番", "3番"})>
    Public Sub Test_9_2_ToLabel(numbers As Integer(), expected As String())
        Assert.Equal(expected, Exercises.Problem9_2(numbers))
    End Sub

    <Fact>
    Public Sub Test_9_2_PreservesOrder()
        ' 入力の順序が保たれていること
        Dim result = Exercises.Problem9_2({9, 1, 5})
        Assert.Equal("9番", result(0))
        Assert.Equal("1番", result(1))
        Assert.Equal("5番", result(2))
    End Sub

    ' ===== 問題 9-3: OrderBy + ThenBy =====

    <Fact>
    Public Sub Test_9_3_SortByLengthThenAlphabetical()
        Dim result = Exercises.Problem9_3({"banana", "fig", "apple", "kiwi"})
        Assert.Equal({"fig", "kiwi", "apple", "banana"}, result)
    End Sub

    <Fact>
    Public Sub Test_9_3_SameLengthSortedAlphabetically()
        ' 同じ文字数はアルファベット順
        Assert.Equal({"ant", "bat", "cat"}, Exercises.Problem9_3({"cat", "ant", "bat"}))
    End Sub

    <Fact>
    Public Sub Test_9_3_SingleElement()
        Assert.Equal({"hello"}, Exercises.Problem9_3({"hello"}))
    End Sub

    ' ===== 問題 9-4: Average =====

    <Theory>
    <InlineData(New Integer() {80, 60, 95, 70, 55}, 72.0)>
    <InlineData(New Integer() {100, 0}, 50.0)>
    <InlineData(New Integer() {75}, 75.0)>
    <InlineData(New Integer() {1, 2, 3, 4}, 2.5)>
    Public Sub Test_9_4_Average(scores As Integer(), expected As Double)
        Assert.Equal(expected, Exercises.Problem9_4(scores))
    End Sub

    ' ===== 問題 9-5: Where + Select + OrderBy チェーン =====

    <Fact>
    Public Sub Test_9_5_EvenSquaredSorted()
        Assert.Equal({4, 16, 36, 64}, Exercises.Problem9_5({5, 2, 8, 3, 4, 6}))
    End Sub

    <Fact>
    Public Sub Test_9_5_NoEvens()
        Assert.Empty(Exercises.Problem9_5({1, 3, 5}))
    End Sub

    <Fact>
    Public Sub Test_9_5_SingleEven()
        Assert.Equal({16}, Exercises.Problem9_5({4}))
    End Sub

    <Fact>
    Public Sub Test_9_5_ResultIsAscending()
        ' 結果が昇順に並んでいることを確認
        Dim result = Exercises.Problem9_5({6, 2, 4})
        Assert.Equal({4, 16, 36}, result)
    End Sub

    ' ===== 問題 9-6: OrderByDescending + Take =====

    <Theory>
    <InlineData(New Integer() {70, 85, 60, 95, 75}, 3, New Integer() {95, 85, 75})>
    <InlineData(New Integer() {10, 20, 30}, 2, New Integer() {30, 20})>
    <InlineData(New Integer() {1, 2, 3, 4, 5}, 1, New Integer() {5})>
    Public Sub Test_9_6_TopN(scores As Integer(), n As Integer, expected As Integer())
        Assert.Equal(expected, Exercises.Problem9_6(scores, n))
    End Sub

    <Fact>
    Public Sub Test_9_6_AllElements()
        ' n が要素数と同じ場合は全要素を降順で返す
        Assert.Equal({5, 5, 5}, Exercises.Problem9_6({5, 5, 5}, 3))
    End Sub

    ' ===== 問題 9-7: Any / All / Count =====

    <Theory>
    <InlineData(New Integer() {3, -1, 5}, True)>
    <InlineData(New Integer() {3, 1, 5}, False)>
    <InlineData(New Integer() {-1, -2, -3}, True)>
    <InlineData(New Integer() {0, 1, 2}, False)>
    Public Sub Test_9_7_HasNegative(numbers As Integer(), expected As Boolean)
        Assert.Equal(expected, Exercises.Problem9_7_HasNegative(numbers))
    End Sub

    <Theory>
    <InlineData(New Integer() {3, 1, 5}, True)>
    <InlineData(New Integer() {3, 0, 5}, False)>
    <InlineData(New Integer() {3, -1, 5}, False)>
    <InlineData(New Integer() {1}, True)>
    Public Sub Test_9_7_AllPositive(numbers As Integer(), expected As Boolean)
        Assert.Equal(expected, Exercises.Problem9_7_AllPositive(numbers))
    End Sub

    <Theory>
    <InlineData(New Integer() {3, 7, 2, 8, 5}, 4, 3)>
    <InlineData(New Integer() {1, 2, 3}, 10, 0)>
    <InlineData(New Integer() {5, 5, 5}, 4, 3)>
    <InlineData(New Integer() {5, 5, 5}, 5, 0)>
    Public Sub Test_9_7_CountOver(numbers As Integer(), threshold As Integer, expected As Integer)
        Assert.Equal(expected, Exercises.Problem9_7_CountOver(numbers, threshold))
    End Sub

    ' ===== 問題 9-8: クエリ構文 =====

    <Fact>
    Public Sub Test_9_8_FilterByLengthDescending()
        Dim words = {"cat", "elephant", "ox", "dog", "hippopotamus"}
        Assert.Equal({"hippopotamus", "elephant"}, Exercises.Problem9_8(words, 4))
    End Sub

    <Fact>
    Public Sub Test_9_8_MultipleSameLengthDescending()
        ' "hello"(5) と "hey"(3) が minLength=3 以上 → 長い順
        Dim result = Exercises.Problem9_8({"hi", "hello", "hey"}, 3)
        Assert.Equal({"hello", "hey"}, result)
    End Sub

    <Fact>
    Public Sub Test_9_8_NoneMatch()
        Assert.Empty(Exercises.Problem9_8({"a", "bb", "ccc"}, 5))
    End Sub

    ' ===== 問題 9-9: GroupBy =====

    <Fact>
    Public Sub Test_9_9_GroupByFirstChar()
        Dim words = {"apple", "ant", "banana", "bear", "cat"}
        Dim result = Exercises.Problem9_9(words)
        Assert.Equal(3, result.Count)
        Assert.Equal(2, result("a"c))
        Assert.Equal(2, result("b"c))
        Assert.Equal(1, result("c"c))
    End Sub

    <Fact>
    Public Sub Test_9_9_AllSameFirstChar()
        Dim result = Exercises.Problem9_9({"alpha", "arrow", "ant"})
        Assert.Equal(1, result.Count)
        Assert.Equal(3, result("a"c))
    End Sub

    <Fact>
    Public Sub Test_9_9_AllDifferentFirstChar()
        Dim result = Exercises.Problem9_9({"zoo", "yak", "xray"})
        Assert.Equal(3, result.Count)
        Assert.Equal(1, result("z"c))
        Assert.Equal(1, result("y"c))
        Assert.Equal(1, result("x"c))
    End Sub

End Class
