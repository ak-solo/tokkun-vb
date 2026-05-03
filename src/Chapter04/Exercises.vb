Public Class Exercises

    ' 問題 4-1: "SPAM" を 10 個カンマ区切りで並べた文字列を返す
    Public Shared Function Problem4_1() As String
        Dim result As String = ""
        For i As Integer = 1 To 10
            result = result & "SPAM"
            If i < 10 Then
                result = result & ","
            End If
        Next
        Return result
    End Function

    ' 問題 4-2: 九九の三の段 (3,6,9,...,27) をカンマ区切りの文字列で返す
    Public Shared Function Problem4_2() As String
        Dim result As String = ""
        For i As Integer = 1 To 9
            result = result & 3 * i
            If i < 9 Then
                result = result & ","
            End If
        Next
        Return result
    End Function

    ' 問題 4-3: 2^1 〜 2^8 をカンマ区切りの文字列で返す
    Public Shared Function Problem4_3() As String
        Dim result As String = ""
        For i As Integer = 1 To 8
            result = result & 2 ^ i
            If i < 8 Then
                result = result & ","
            End If
        Next
        Return result
    End Function

    ' 問題 4-4: 7! を返す
    Public Shared Function Problem4_4() As Integer
        Dim result As Integer = 1
        For num As Integer = 2 To 7
            result = result * num
        Next
        Return result
    End Function

    ' 問題 4-5: "*" を n 個並べた文字列を返す
    Public Shared Function Problem4_5(n As Integer) As String
        Dim result As String = ""
        For i As Integer = 1 To n
            result = result & "*"
        Next
        Return result
    End Function

    ' 問題 4-6: 0〜9 を繰り返す n 文字の文字列を返す
    '            例: n=14 → "01234567890123"
    Public Shared Function Problem4_6(n As Integer) As String
        Dim result As String = ""
        Dim num As Integer = 0
        For i As Integer = 1 To n
            result = result & num
            num += 1
            If num > 9 Then
                num = 0
            End If
        Next
        Return result
    End Function

    ' 問題 4-7: n を素因数分解した結果をカンマ区切りの文字列で返す
    '            例: n=20100 → "2,2,3,5,5,67"
    Public Shared Function Problem4_7(n As Integer) As String
        Dim result As String = ""
        Dim i As Integer = 0
        Dim d As Integer = 2
        Do
            If n Mod d = 0 Then
                n = n \ d
                result = result & d
                If n > 1 Then
                    result = result & ","
                End If
            Else
                d += 1
            End If
        Loop While n > 1
        Return result
    End Function

    ' 問題 4-8: n が素数なら True を返す
    Public Shared Function Problem4_8(n As Integer) As Boolean
        If n <= 1 Then Return False

        Dim d As Integer = 2
        Do
            If n Mod d = 0 Then
                Return False
            Else
                d += 1
            End If
        Loop While d * d <= n
        Return True
    End Function

    ' 問題 4-9: "$" で作った三角形を改行区切りの文字列で返す
    Public Shared Function Problem4_9(size As Integer) As String
        Dim result As String = ""
        For i As Integer = 1 To size
            For j As Integer = 1 To i
                result = result & "$"
            Next
            If i < size Then
                result = result & Environment.NewLine
            End If
        Next
        Return result
    End Function

    ' 問題 4-10: "X" で作った × 印を改行区切りの文字列で返す
    Public Shared Function Problem4_10(size As Integer) As String
        Dim result As String = ""
        For i As Integer = 1 To size
            Dim left As Integer = i
            Dim right As Integer = size + 1 - i
            For j As Integer = 1 To size
                If j = left OrElse j = right Then
                    result = result & "X"
                Else
                    result = result & " "
                End If
            Next
            If i < size Then
                result = result & Environment.NewLine
            End If
        Next
        Return result
    End Function

    ' 問題 4-11: フィボナッチ数列の 1000 以下の項をカンマ区切りの文字列で返す
    '             先頭は 0, 1 とする
    Public Shared Function Problem4_11() As String
        Dim result As String
        Dim a As Integer = 0
        Dim b As Integer = 1
        result = a & "," & b
        Do
            Dim num As Integer = a + b
            a = b
            b = num
            If num > 1000 Then Exit Do
            result = result & ","
            result = result & num
        Loop
        Return result
    End Function

End Class
