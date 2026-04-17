Public Class Exercises

    ' 問題 3-1: x > y のとき "xはyより大きい。"、それ以外は "" を返す
    Public Shared Function Problem3_1(x As Integer, y As Integer) As String
        if x > y Then
            return("xはyより大きい。")
        Else
            return("")
        End If
    End Function

    ' 問題 3-2: x > y → "xはyより大きい"、x < y → "xはyより小さい"、x = y → ""
    Public Shared Function Problem3_2(x As Integer, y As Integer) As String
        If x > y Then
            return("xはyより大きい")
        Else If x < y Then
            return("xはyより小さい")
        Else 
            return("")
        End If
    End Function

    ' 問題 3-3: x と y の大きい方を返す
    Public Shared Function Problem3_3(x As Integer, y As Integer) As Integer
        If x > y Then
            return(x)
        Else 
            return(y)
        End If
    End Function

    ' 問題 3-4: x > y → "xはyより大きい"、x < y → "xはyより小さい"、x = y → "xとyは等しい"
    Public Shared Function Problem3_4(x As Integer, y As Integer) As String
        If x > y Then
            return("xはyより大きい")
        Else If x < y Then
            return("xはyより小さい")
        Else 
            return("xとyは等しい")
        End If
    End Function

    ' 問題 3-5: 偶数なら "偶数"、奇数なら "奇数" を返す
    Public Shared Function Problem3_5(x As Integer) As String
        if x Mod 2 = 0 Then
            return("偶数")
        Else 
            return("奇数")
        End If
    End Function

    ' 問題 3-6: "正の偶数" / "正の奇数" / "負の偶数" / "負の奇数" を返す（0 は "正の偶数"）
    Public Shared Function Problem3_6(x As Integer) As String
        If x >= 0 and  x mod 2 = 0 Then
            return("正の偶数")
        Else If x >=0 And Not(x mod 2 = 0) Then
            return("正の奇数")
        Else If x < 0 And x mod 2 = 0 Then
            return("負の偶数")
        Else 
            return("負の奇数")
        End If
    End Function

    ' 問題 3-7 ケース1: 60点以上 → "合格"、未満 → "不合格"
    Public Shared Function Problem3_7_Case1(score As Integer) As String
        If score >= 60 Then
            return("合格")
        Else
            return("不合格")
        End If
    End Function

    ' 問題 3-7 ケース2: 80点以上 → "たいへんよくできました。"
    '                   60点以上 → "よくできました。"
    '                   60点未満 → "ざんねんでした。"
    Public Shared Function Problem3_7_Case2(score As Integer) As String
        If score >= 80 Then
            return("たいへんよくできました。")
        Else If score >=60 And score < 80 Then
            return("よくできました。")
        Else 
            return("ざんねんでした。")
        End If
    End Function

    ' 問題 3-7 ケース3: 80点以上 → "優"、70点以上 → "良"、60点以上 → "可"、未満 → "不可"
    Public Shared Function Problem3_7_Case3(score As Integer) As String
        Select Case score
        Case 80 to 100
            return("優")
        Case 70 to 79
            return("良")
        Case 60 to 69
            return("可")
        Case Else
            return("不可")
        End Select
    End Function

    ' 問題 3-8: 中間・期末の点数から合否を返す
    '   合格条件: 両方60点以上 / 合計130点以上 / 合計100点以上かつどちらかが90点以上
    Public Shared Function Problem3_8(midterm As Integer, final As Integer) As String
           If (midterm >= 60 And final >=60)Or(midterm + final >= 130) Or(midterm + final >= 100 And midterm >= 90 Or final >= 90) Then
                return ("合格")
            Else 
                return ("不合格")
            End If
    End Function

    ' 問題 3-9: 曜日(0=日〜6=土)と時間帯(0=午前,1=午後,2=夜間)から "○" または "休診" を返す
    Public Shared Function Problem3_9(dayOfWeek As Integer, timeOfDay As Integer) As String
        Throw New NotImplementedException("問題 3-7（ケース3）を実装してください")
    End Function
            
    ' 問題 3-10 条件1: x < y かつ s と y がともに偶数
    Public Shared Function Problem3_10_Cond1(x As Integer, y As Integer) As Boolean
        If x < y And x Mod 2 = 0 And y Mod 2 = 0
            Return (true)
        End If
    End Function

    ' 問題 3-10 条件2: x = y かつ負の数
    Public Shared Function Problem3_10_Cond2(x As Integer, y As Integer) As Boolean
        If x = y And x < 0
            Return (true)
        End If
    End Function

    ' 問題 3-10 条件3: x < y または x が偶数
    Public Shared Function Problem3_10_Cond3(x As Integer, y As Integer) As Boolean
        If x < y Or x Mod 2 = 0
            Return (true)
        End if
    End Function

    ' 問題 3-10 条件4: (x ≤ 10 または x ≥ 100) かつ (y ≥ 10 かつ y ≤ 100)
    Public Shared Function Problem3_10_Cond4(x As Integer, y As Integer) As Boolean
        If (x <= 10 Or x >= 100) And (y>=10 And y <= 100)
            Return (true)
        End If
    End Function

    ' 問題 3-10 条件5: 「x も y も負の数」ではない（否定）
    Public Shared Function Problem3_10_Cond5(x As Integer, y As Integer) As Boolean
        If Not(x < 0 And y < 0)
            Return (true)
        End If
    End Function

    ' 問題 3-11: 寿司占い（Select Case を使うこと）
    '   1=まぐろ, 2=えび, 3=こはだ, 4=いくら, 5=たまご, その他 → エラーメッセージ
    Public Shared Function Problem3_11(choice As Integer) As String
        Throw New NotImplementedException("問題 3-11 を実装してください")
    End Function

    ' 問題 3-12: 月の大小判定（Select Case を使うこと）
    '   大の月(1,3,5,7,8,10,12) → "{n}月は大の月です"
    '   小の月(2,4,6,9,11)      → "{n}月は小の月です"
    '   1〜12 以外              → "そんな月はありません"
    Public Shared Function Problem3_12(month As Integer) As String
        Throw New NotImplementedException("問題 3-12 を実装してください")
    End Function

End Class
