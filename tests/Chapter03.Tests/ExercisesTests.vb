Imports Xunit

Public Class Chapter03Tests

    ' --- 問題 3-1 ---
    <Theory>
    <InlineData(10, 5, "xはyより大きい。")>
    <InlineData(5, 10, "")>
    <InlineData(5, 5, "")>
    Public Sub Test_3_1_GreaterThan(x As Integer, y As Integer, expected As String)
        Assert.Equal(expected, Exercises.Problem3_1(x, y))
    End Sub

    ' --- 問題 3-2 ---
    <Theory>
    <InlineData(10, 5, "xはyより大きい")>
    <InlineData(5, 10, "xはyより小さい")>
    <InlineData(5, 5, "")>
    Public Sub Test_3_2_Compare(x As Integer, y As Integer, expected As String)
        Assert.Equal(expected, Exercises.Problem3_2(x, y))
    End Sub

    ' --- 問題 3-3 ---
    <Theory>
    <InlineData(10, 5, 10)>
    <InlineData(5, 10, 10)>
    <InlineData(7, 7, 7)>
    <InlineData(-3, -1, -1)>
    Public Sub Test_3_3_Max(x As Integer, y As Integer, expected As Integer)
        Assert.Equal(expected, Exercises.Problem3_3(x, y))
    End Sub

    ' --- 問題 3-4 ---
    <Theory>
    <InlineData(10, 5, "xはyより大きい")>
    <InlineData(5, 10, "xはyより小さい")>
    <InlineData(5, 5, "xとyは等しい")>
    Public Sub Test_3_4_ThreeWayCompare(x As Integer, y As Integer, expected As String)
        Assert.Equal(expected, Exercises.Problem3_4(x, y))
    End Sub

    ' --- 問題 3-5 ---
    <Theory>
    <InlineData(4, "偶数")>
    <InlineData(3, "奇数")>
    <InlineData(0, "偶数")>
    <InlineData(-4, "偶数")>
    <InlineData(-3, "奇数")>
    Public Sub Test_3_5_EvenOdd(x As Integer, expected As String)
        Assert.Equal(expected, Exercises.Problem3_5(x))
    End Sub

    ' --- 問題 3-6 ---
    <Theory>
    <InlineData(4, "正の偶数")>
    <InlineData(3, "正の奇数")>
    <InlineData(0, "正の偶数")>
    <InlineData(-4, "負の偶数")>
    <InlineData(-3, "負の奇数")>
    Public Sub Test_3_6_Classify(x As Integer, expected As String)
        Assert.Equal(expected, Exercises.Problem3_6(x))
    End Sub

    ' --- 問題 3-7 ケース1 ---
    <Theory>
    <InlineData(100, "合格")>
    <InlineData(60, "合格")>
    <InlineData(59, "不合格")>
    <InlineData(0, "不合格")>
    Public Sub Test_3_7_Case1(score As Integer, expected As String)
        Assert.Equal(expected, Exercises.Problem3_7_Case1(score))
    End Sub

    ' --- 問題 3-7 ケース2 ---
    <Theory>
    <InlineData(100, "たいへんよくできました。")>
    <InlineData(80, "たいへんよくできました。")>
    <InlineData(79, "よくできました。")>
    <InlineData(60, "よくできました。")>
    <InlineData(59, "ざんねんでした。")>
    <InlineData(0, "ざんねんでした。")>
    Public Sub Test_3_7_Case2(score As Integer, expected As String)
        Assert.Equal(expected, Exercises.Problem3_7_Case2(score))
    End Sub

    ' --- 問題 3-7 ケース3 ---
    <Theory>
    <InlineData(100, "優")>
    <InlineData(80, "優")>
    <InlineData(79, "良")>
    <InlineData(70, "良")>
    <InlineData(69, "可")>
    <InlineData(60, "可")>
    <InlineData(59, "不可")>
    <InlineData(0, "不可")>
    Public Sub Test_3_7_Case3(score As Integer, expected As String)
        Assert.Equal(expected, Exercises.Problem3_7_Case3(score))
    End Sub

    ' --- 問題 3-8 ---
    <Theory>
    <InlineData(70, 70, "合格")>   ' 両方60点以上
    <InlineData(60, 60, "合格")>   ' ちょうど60点
    <InlineData(50, 90, "合格")>   ' 合計140点以上
    <InlineData(100, 30, "合格")>  ' 合計130点ちょうど
    <InlineData(10, 95, "合格")>   ' 合計105点かつ final が90点以上（条件3: final側）
    <InlineData(95, 10, "合格")>   ' 合計105点かつ midterm が90点以上（条件3: midterm側）
    <InlineData(90, 10, "合格")>   ' 合計100点ちょうど かつ midterm がちょうど90点（条件3の境界値）
    <InlineData(0, 90, "不合格")>  ' 合計90点で条件3不成立（合計が100点未満）
    <InlineData(50, 55, "不合格")> ' いずれの条件も満たさない
    <InlineData(30, 50, "不合格")>
    Public Sub Test_3_8_PassFail(midterm As Integer, final As Integer, expected As String)
        Assert.Equal(expected, Exercises.Problem3_8(midterm, final))
    End Sub

    ' --- 問題 3-9 ---
    <Theory>
    <InlineData(0, 0, "休診")>   ' 日曜 午前
    <InlineData(1, 0, "○")>     ' 月曜 午前
    <InlineData(2, 0, "休診")>  ' 火曜 午前
    <InlineData(2, 1, "○")>     ' 火曜 午後
    <InlineData(3, 2, "休診")>  ' 水曜 夜間
    <InlineData(5, 0, "休診")>  ' 金曜 午前
    <InlineData(5, 1, "○")>     ' 金曜 午後
    <InlineData(6, 0, "○")>     ' 土曜 午前
    <InlineData(6, 1, "休診")>  ' 土曜 午後
    Public Sub Test_3_9_Hospital(dayOfWeek As Integer, timeOfDay As Integer, expected As String)
        Assert.Equal(expected, Exercises.Problem3_9(dayOfWeek, timeOfDay))
    End Sub

    ' --- 問題 3-10 条件1: x < y かつ共に偶数 ---
    <Theory>
    <InlineData(2, 4, True)>
    <InlineData(4, 2, False)>   ' x < y でない
    <InlineData(2, 3, False)>   ' y が奇数
    <InlineData(1, 3, False)>   ' 共に奇数
    Public Sub Test_3_10_Cond1(x As Integer, y As Integer, expected As Boolean)
        Assert.Equal(expected, Exercises.Problem3_10_Cond1(x, y))
    End Sub

    ' --- 問題 3-10 条件2: x = y かつ負 ---
    <Theory>
    <InlineData(-3, -3, True)>
    <InlineData(-3, -4, False)>  ' x ≠ y
    <InlineData(3, 3, False)>    ' 正の数
    Public Sub Test_3_10_Cond2(x As Integer, y As Integer, expected As Boolean)
        Assert.Equal(expected, Exercises.Problem3_10_Cond2(x, y))
    End Sub

    ' --- 問題 3-10 条件3: x < y または x が偶数 ---
    <Theory>
    <InlineData(2, 5, True)>    ' 両方成立
    <InlineData(4, 2, True)>    ' x が偶数のみ成立
    <InlineData(1, 5, True)>    ' x < y のみ成立
    <InlineData(3, 1, False)>   ' どちらも不成立
    Public Sub Test_3_10_Cond3(x As Integer, y As Integer, expected As Boolean)
        Assert.Equal(expected, Exercises.Problem3_10_Cond3(x, y))
    End Sub

    ' --- 問題 3-10 条件4: (x≤10 or x≥100) and (10≤y≤100) ---
    <Theory>
    <InlineData(5, 50, True)>     ' x≤10 かつ 10≤y≤100
    <InlineData(100, 50, True)>   ' x≥100 かつ 10≤y≤100
    <InlineData(50, 50, False)>   ' x が中間
    <InlineData(5, 5, False)>     ' y < 10
    <InlineData(5, 101, False)>   ' y > 100
    Public Sub Test_3_10_Cond4(x As Integer, y As Integer, expected As Boolean)
        Assert.Equal(expected, Exercises.Problem3_10_Cond4(x, y))
    End Sub

    ' --- 問題 3-10 条件5: NOT(x<0 AND y<0) ---
    <Theory>
    <InlineData(1, 1, True)>     ' 両方正 → 否定なので True
    <InlineData(-1, 1, True)>    ' 片方だけ負
    <InlineData(-1, -1, False)>  ' 両方負 → 否定なので False
    <InlineData(0, -1, True)>    ' 0 は負でない
    Public Sub Test_3_10_Cond5(x As Integer, y As Integer, expected As Boolean)
        Assert.Equal(expected, Exercises.Problem3_10_Cond5(x, y))
    End Sub

    ' --- 問題 3-11 ---
    <Theory>
    <InlineData(1, "大吉！今日は積極的に行動しよう。")>
    <InlineData(2, "中吉。慎重に進めば良い結果が待っている。")>
    <InlineData(3, "吉。こつこつ続けることで道が開ける。")>
    <InlineData(4, "小吉。意外なところからチャンスがやってくる。")>
    <InlineData(5, "末吉。今日はゆったり過ごすと吉。")>
    <InlineData(0, "選択肢は 1〜5 の数字で入力してください。")>
    <InlineData(9, "選択肢は 1〜5 の数字で入力してください。")>
    Public Sub Test_3_11_SushiFortune(choice As Integer, expected As String)
        Assert.Equal(expected, Exercises.Problem3_11(choice))
    End Sub

    ' --- 問題 3-12 ---
    <Theory>
    <InlineData(1, "1月は大の月です")>
    <InlineData(3, "3月は大の月です")>
    <InlineData(12, "12月は大の月です")>
    <InlineData(2, "2月は小の月です")>
    <InlineData(4, "4月は小の月です")>
    <InlineData(11, "11月は小の月です")>
    <InlineData(0, "そんな月はありません")>
    <InlineData(13, "そんな月はありません")>
    Public Sub Test_3_12_MonthSize(month As Integer, expected As String)
        Assert.Equal(expected, Exercises.Problem3_12(month))
    End Sub

End Class
