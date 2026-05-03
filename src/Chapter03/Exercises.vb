Public Class Exercises

    ' 問題 3-1: x > y のとき "xはyより大きい。"、それ以外は "" を返す
    Public Shared Function Problem3_1(x As Integer, y As Integer) As String
        If x > y Then
            Return "xはyより大きい。"
        Else
            Return ""
        End If
    End Function

    ' 問題 3-2: x > y → "xはyより大きい"、x < y → "xはyより小さい"、x = y → ""
    Public Shared Function Problem3_2(x As Integer, y As Integer) As String
        If x > y Then
            Return "xはyより大きい"
        ElseIf x < y Then
            Return "xはyより小さい"
        Else
            Return ""
        End If
    End Function

    ' 問題 3-3: x と y の大きい方を返す
    Public Shared Function Problem3_3(x As Integer, y As Integer) As Integer
        If x > y Then
            Return x
        Else
            Return y
        End If
    End Function

    ' 問題 3-4: x > y → "xはyより大きい"、x < y → "xはyより小さい"、x = y → "xとyは等しい"
    Public Shared Function Problem3_4(x As Integer, y As Integer) As String
        If x > y Then
            Return "xはyより大きい"
        ElseIf x < y Then
            Return "xはyより小さい"
        Else
            Return "xとyは等しい"
        End If
    End Function

    ' 問題 3-5: 偶数なら "偶数"、奇数なら "奇数" を返す
    Public Shared Function Problem3_5(x As Integer) As String
        If x mod 2 = 0 Then
            Return "偶数"
        Else
            Return "奇数"
        End If
    End Function

    ' 問題 3-6: "正の偶数" / "正の奇数" / "負の偶数" / "負の奇数" を返す（0 は "正の偶数"）
    Public Shared Function Problem3_6(x As Integer) As String
        If x >= 0 Then
            If x Mod 2 = 0 Then
                Return "正の偶数"
            Else
                Return "正の奇数"
            End If
        Else
            If x Mod 2 = 0 Then
                Return "負の偶数"
            Else
                Return "負の奇数"
            End If
        End If
    End Function

    ' 問題 3-7 ケース1: 60点以上 → "合格"、未満 → "不合格"
    Public Shared Function Problem3_7_Case1(score As Integer) As String
        If score >= 60 Then
            Return "合格"
        Else
            Return "不合格"
        End If
    End Function

    ' 問題 3-7 ケース2: 80点以上 → "たいへんよくできました。"
    '                   60点以上 → "よくできました。"
    '                   60点未満 → "ざんねんでした。"
    Public Shared Function Problem3_7_Case2(score As Integer) As String
        If score >= 80 Then
            Return "たいへんよくできました。"
        ElseIf score >= 60 Then
            Return "よくできました。"
        Else
            Return "ざんねんでした。"
        End If
    End Function

    ' 問題 3-7 ケース3: 80点以上 → "優"、70点以上 → "良"、60点以上 → "可"、未満 → "不可"
    Public Shared Function Problem3_7_Case3(score As Integer) As String
        If score >= 80 Then
            Return "優"
        ElseIf score >= 70 Then
            Return "良"
        ElseIf score >= 60 Then
            Return "可"
        Else
            Return "不可"
        End If
    End Function

    ' 問題 3-8: 中間・期末の点数から合否を返す
    '   合格条件: 両方60点以上 / 合計130点以上 / 合計100点以上かつどちらかが90点以上
    Public Shared Function Problem3_8(midterm As Integer, final As Integer) As String
        If (midterm >= 60 AndAlso final >= 60) OrElse _
           (midterm + final >= 130) OrElse _
           (midterm + final >= 100 AndAlso (midterm >= 90 OrElse final >= 90)) Then
            Return "合格"
        Else
            Return "不合格"
        End If
    End Function

    ' 問題 3-9: 曜日(0=日〜6=土)と時間帯(0=午前,1=午後,2=夜間)から "○" または "休診" を返す
    Public Shared Function Problem3_9(dayOfWeek As Integer, timeOfDay As Integer) As String
        Select Case dayOfWeek
            Case 0      '日曜日
                Return "休診"
            Case 1, 4   '月曜日／木曜日
                Return "○"
            Case 2, 5   '火曜日／金曜日
                If timeOfDay = 0 Then   '午前中
                    Return "休診"
                Else
                    Return "○"
                End If
            Case 3      '水曜日
                If timeOfDay = 2 Then   '夜間
                    Return "休診"
                Else
                    Return "○"
                End If
            Case 6      '土曜日
                If timeOfDay = 0 Then   '午前中
                    Return "○"
                Else
                    Return "休診"
                End If
            Case Else
                Throw New ArgumentException()
        End Select
    End Function

    ' 問題 3-10 条件1: x < y かつ x と y がともに偶数
    Public Shared Function Problem3_10_Cond1(x As Integer, y As Integer) As Boolean
        Return x < y AndAlso x mod 2 = 0 AndAlso y mod 2 = 0
    End Function

    ' 問題 3-10 条件2: x = y かつ負の数
    Public Shared Function Problem3_10_Cond2(x As Integer, y As Integer) As Boolean
        Return x = y AndAlso x < 0
    End Function

    ' 問題 3-10 条件3: x < y または x が偶数
    Public Shared Function Problem3_10_Cond3(x As Integer, y As Integer) As Boolean
        Return x < y OrElse x mod 2 = 0
    End Function

    ' 問題 3-10 条件4: (x ≤ 10 または x ≥ 100) かつ (y ≥ 10 かつ y ≤ 100)
    Public Shared Function Problem3_10_Cond4(x As Integer, y As Integer) As Boolean
        Return (x <= 10 OrElse x >= 100) AndAlso (y >= 10 AndAlso y <= 100)
    End Function

    ' 問題 3-10 条件5: 「x も y も負の数」ではない（否定）
    Public Shared Function Problem3_10_Cond5(x As Integer, y As Integer) As Boolean
        Return Not (x < 0 AndAlso y < 0)
    End Function

    ' 問題 3-11: 寿司占い（Select Case を使うこと）
    '   1=まぐろ, 2=えび, 3=こはだ, 4=いくら, 5=たまご, その他 → エラーメッセージ
    Public Shared Function Problem3_11(choice As Integer) As String
        Select Case choice
            Case 1  'まぐろ
                Return "大吉！今日は積極的に行動しよう。"
            Case 2  'えび
                Return "中吉。慎重に進めば良い結果が待っている。"
            Case 3  'こはだ
                Return "吉。こつこつ続けることで道が開ける。"
            Case 4  'いくら
                Return "小吉。意外なところからチャンスがやってくる。"
            Case 5  'たまご
                Return "末吉。今日はゆったり過ごすと吉。"
            Case Else   'その他
                Return "選択肢は 1〜5 の数字で入力してください。"
        End Select
    End Function

    ' 問題 3-12: 月の大小判定（Select Case を使うこと）
    '   大の月(1,3,5,7,8,10,12) → "{n}月は大の月です"
    '   小の月(2,4,6,9,11)      → "{n}月は小の月です"
    '   1〜12 以外              → "そんな月はありません"
    Public Shared Function Problem3_12(month As Integer) As String
        Select Case month
            Case 1, 3, 5, 7, 8, 10, 12
                Return $"{month}月は大の月です"
            Case 2, 4, 6, 9, 11
                Return $"{month}月は小の月です"
            Case Else
                Return "そんな月はありません"
        End Select
    End Function

End Class
