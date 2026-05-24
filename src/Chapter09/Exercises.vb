Public Class Exercises

    ' 問題 9-1: 前後の空白を除去して大文字変換
    Public Shared Function Problem9_1(input As String) As String
        Return input.Trim().ToUpper()
    End Function

    ' 問題 9-2: 区切り文字より前の部分文字列を返す（なければ元の文字列）
    Public Shared Function Problem9_2(text As String, delimiter As Char) As String
        Dim idx As Integer = text.IndexOf(delimiter)
        If idx = -1 Then Return text
        Return text.Substring(0, idx)
    End Function

    ' 問題 9-3: CSV 文字列を分割して各要素をトリムした配列を返す
    Public Shared Function Problem9_3(csv As String) As String()
        Dim values() As String = csv.Split(","c)
        For i As Integer = 0 To values.Length - 1
            values(i) = values(i).Trim()
        Next
        Return values
    End Function

    ' 問題 9-4: text 内の oldWord をすべて newWord に置換
    Public Shared Function Problem9_4(text As String, oldWord As String, newWord As String) As String
        Return text.Replace(oldWord, newWord)
    End Function

    ' 問題 9-5: text が prefix で始まれば True
    Public Shared Function Problem9_5_StartsWith(text As String, prefix As String) As Boolean
        Return text.StartsWith(prefix)
    End Function

    ' 問題 9-5: text が suffix で終わっていれば True
    Public Shared Function Problem9_5_EndsWith(text As String, suffix As String) As Boolean
        Return text.EndsWith(suffix)
    End Function

    ' 問題 9-5: text に keyword が含まれていれば True
    Public Shared Function Problem9_5_Contains(text As String, keyword As String) As Boolean
        Return text.Contains(keyword)
    End Function

    ' 問題 9-6: 曜日を日本語で返す
    Public Shared Function Problem9_6(dateValue As DateTime) As String
        Select Case dateValue.DayOfWeek
            Case DayOfWeek.Monday
                Return "月曜日"
            Case DayOfWeek.Tuesday
                Return "火曜日"
            Case DayOfWeek.Wednesday
                Return "水曜日"
            Case DayOfWeek.Thursday
                Return "木曜日"
            Case DayOfWeek.Friday
                Return "金曜日"
            Case DayOfWeek.Saturday
                Return "土曜日"
            Case DayOfWeek.Sunday
                Return "日曜日"
            Case Else
                Throw New ArgumentOutOfRangeException(NameOf(dateValue))
        End Select
    End Function

    ' 問題 9-7: 2 つの日付の差分（日数）を返す
    Public Shared Function Problem9_7(fromDate As DateTime, toDate As DateTime) As Integer
        Dim diff As TimeSpan = toDate - fromDate
        Return diff.Days
    End Function

    ' 問題 9-8: "yyyy年M月d日" 形式で日付を返す
    Public Shared Function Problem9_8(dateValue As DateTime) As String
        Return dateValue.ToString("yyyy年M月d日")
    End Function

    ' 問題 9-9: days 日後の日付を "yyyy/MM/dd" 形式で返す
    Public Shared Function Problem9_9(dateValue As DateTime, days As Integer) As String
        Return dateValue.AddDays(days).ToString("yyyy/MM/dd")
    End Function

End Class
