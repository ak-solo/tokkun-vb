Imports Xunit

Public Class Chapter09Tests

    ' ===== 問題 9-1: Trim + ToUpper =====

    <Theory>
    <InlineData("  hello world  ", "HELLO WORLD")>
    <InlineData("  VB.NET  ", "VB.NET")>
    <InlineData("already", "ALREADY")>
    <InlineData("  ", "")>
    Public Sub Test_9_1_TrimAndUpperCase(input As String, expected As String)
        Assert.Equal(expected, Exercises.Problem9_1(input))
    End Sub

    <Fact>
    Public Sub Test_9_1_MixedCase()
        Assert.Equal("HELLO WORLD", Exercises.Problem9_1("  Hello World  "))
    End Sub

    ' ===== 問題 9-2: IndexOf + Substring =====

    <Theory>
    <InlineData("user@example.com", "@"c, "user")>
    <InlineData("first.last@mail.co.jp", "@"c, "first.last")>
    <InlineData("hello", "@"c, "hello")>
    Public Sub Test_9_2_SubstringBeforeDelimiter(text As String, delimiter As Char, expected As String)
        Assert.Equal(expected, Exercises.Problem9_2(text, delimiter))
    End Sub

    <Fact>
    Public Sub Test_9_2_SlashDelimiter()
        Assert.Equal("https:", Exercises.Problem9_2("https://example.com", "/"c))
    End Sub

    ' ===== 問題 9-3: Split + Trim =====

    <Fact>
    Public Sub Test_9_3_SplitAndTrim()
        Assert.Equal({"apple", "banana", "cherry"}, Exercises.Problem9_3("apple, banana, cherry"))
    End Sub

    <Fact>
    Public Sub Test_9_3_NoExtraSpaces()
        Assert.Equal({"a", "b", "c"}, Exercises.Problem9_3("a,b,c"))
    End Sub

    <Fact>
    Public Sub Test_9_3_SingleElement()
        Assert.Equal({"only"}, Exercises.Problem9_3("only"))
    End Sub

    <Fact>
    Public Sub Test_9_3_WithLeadingAndTrailingSpaces()
        Dim result As String() = Exercises.Problem9_3("  alpha , beta  ,  gamma  ")
        Assert.Equal("alpha", result(0))
        Assert.Equal("beta", result(1))
        Assert.Equal("gamma", result(2))
    End Sub

    ' ===== 問題 9-4: Replace =====

    <Theory>
    <InlineData("Hello World World", "World", "VB.NET", "Hello VB.NET VB.NET")>
    <InlineData("aabbcc", "b", "X", "aaXXcc")>
    <InlineData("no match here", "xyz", "ABC", "no match here")>
    Public Sub Test_9_4_ReplaceAll(text As String, oldWord As String, newWord As String, expected As String)
        Assert.Equal(expected, Exercises.Problem9_4(text, oldWord, newWord))
    End Sub

    <Fact>
    Public Sub Test_9_4_EmptyReplacement()
        Assert.Equal("Hello ", Exercises.Problem9_4("Hello World", "World", ""))
    End Sub

    ' ===== 問題 9-5: StartsWith / EndsWith / Contains =====

    <Theory>
    <InlineData("Hello, World", "Hello", True)>
    <InlineData("Hello, World", "World", False)>
    <InlineData("Hello, World", "", True)>
    Public Sub Test_9_5_StartsWith(text As String, prefix As String, expected As Boolean)
        Assert.Equal(expected, Exercises.Problem9_5_StartsWith(text, prefix))
    End Sub

    <Theory>
    <InlineData("Hello, World", "World", True)>
    <InlineData("Hello, World", "Hello", False)>
    <InlineData("Hello, World", "", True)>
    Public Sub Test_9_5_EndsWith(text As String, suffix As String, expected As Boolean)
        Assert.Equal(expected, Exercises.Problem9_5_EndsWith(text, suffix))
    End Sub

    <Theory>
    <InlineData("Hello, World", "World", True)>
    <InlineData("Hello, World", "VB.NET", False)>
    <InlineData("Hello, World", "Hello", True)>
    Public Sub Test_9_5_Contains(text As String, keyword As String, expected As Boolean)
        Assert.Equal(expected, Exercises.Problem9_5_Contains(text, keyword))
    End Sub

    ' ===== 問題 9-6: 曜日（日本語） =====

    <Fact>
    Public Sub Test_9_6_Monday()
        Assert.Equal("月曜日", Exercises.Problem9_6(New DateTime(2024, 1, 1)))
    End Sub

    <Fact>
    Public Sub Test_9_6_Sunday()
        Assert.Equal("日曜日", Exercises.Problem9_6(New DateTime(2024, 1, 7)))
    End Sub

    <Fact>
    Public Sub Test_9_6_AllDaysOfWeek()
        Assert.Equal("月曜日", Exercises.Problem9_6(New DateTime(2024, 1, 1)))
        Assert.Equal("火曜日", Exercises.Problem9_6(New DateTime(2024, 1, 2)))
        Assert.Equal("水曜日", Exercises.Problem9_6(New DateTime(2024, 1, 3)))
        Assert.Equal("木曜日", Exercises.Problem9_6(New DateTime(2024, 1, 4)))
        Assert.Equal("金曜日", Exercises.Problem9_6(New DateTime(2024, 1, 5)))
        Assert.Equal("土曜日", Exercises.Problem9_6(New DateTime(2024, 1, 6)))
        Assert.Equal("日曜日", Exercises.Problem9_6(New DateTime(2024, 1, 7)))
    End Sub

    ' ===== 問題 9-7: 日付の差分 =====

    <Fact>
    Public Sub Test_9_7_DaysInSameMonth()
        Assert.Equal(9, Exercises.Problem9_7(New DateTime(2024, 1, 1), New DateTime(2024, 1, 10)))
    End Sub

    <Fact>
    Public Sub Test_9_7_AcrossMonths()
        Assert.Equal(60, Exercises.Problem9_7(New DateTime(2024, 1, 1), New DateTime(2024, 3, 1)))
    End Sub

    <Fact>
    Public Sub Test_9_7_SameDay()
        Assert.Equal(0, Exercises.Problem9_7(New DateTime(2024, 5, 1), New DateTime(2024, 5, 1)))
    End Sub

    <Fact>
    Public Sub Test_9_7_AcrossYears()
        ' 2024 年はうるう年（366 日）
        Assert.Equal(366, Exercises.Problem9_7(New DateTime(2024, 1, 1), New DateTime(2025, 1, 1)))
    End Sub

    ' ===== 問題 9-8: 日付フォーマット =====

    <Fact>
    Public Sub Test_9_8_FormatDate()
        Assert.Equal("2024年3月5日", Exercises.Problem9_8(New DateTime(2024, 3, 5)))
    End Sub

    <Fact>
    Public Sub Test_9_8_EndOfYear()
        Assert.Equal("2024年12月31日", Exercises.Problem9_8(New DateTime(2024, 12, 31)))
    End Sub

    <Fact>
    Public Sub Test_9_8_SingleDigitMonthAndDay()
        Assert.Equal("2024年1月1日", Exercises.Problem9_8(New DateTime(2024, 1, 1)))
    End Sub

    ' ===== 問題 9-9: n 日後のフォーマット =====

    <Fact>
    Public Sub Test_9_9_AddDays()
        Assert.Equal("2024/01/31", Exercises.Problem9_9(New DateTime(2024, 1, 1), 30))
    End Sub

    <Fact>
    Public Sub Test_9_9_CrossMonth()
        Assert.Equal("2024/02/01", Exercises.Problem9_9(New DateTime(2024, 1, 31), 1))
    End Sub

    <Fact>
    Public Sub Test_9_9_ZeroDays()
        Assert.Equal("2024/01/01", Exercises.Problem9_9(New DateTime(2024, 1, 1), 0))
    End Sub

    <Fact>
    Public Sub Test_9_9_CrossYear()
        Assert.Equal("2025/01/01", Exercises.Problem9_9(New DateTime(2024, 12, 31), 1))
    End Sub

End Class
