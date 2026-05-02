Public Class Exercises

    ' 問題 6-1: n の 2 乗を返す
    Public Shared Function Problem6_1(n As Integer) As Integer
        Return Square(n)
    End Function

    Private Shared Function Square(n As Integer) As Integer
        Return n * n    ' ^ 演算子は Double を返すため * で整数演算する
    End Function

    ' 問題 6-2: a と b の平均（整数除算）を返す
    Public Shared Function Problem6_2(a As Integer, b As Integer) As Integer
        Return Average(a, b)
    End Function

    Private Shared Function Average(a As Integer, b As Integer) AS Integer
        Return (a + b) \ 2
    End Function

    ' 問題 6-3: a と b の大きい方を返す
    Public Shared Function Problem6_3(a As Integer, b As Integer) As Integer
        Return Max(a, b)
    End Function

    Private Shared Function Max(a As Integer, b As Integer) As Integer
        If a > b Then
            Return a
        Else
            Return b
        End If
    End Function

    ' 問題 6-4: $ で作った直角三角形を文字列で返す（行を Environment.NewLine で結合）
    Public Shared Function Problem6_4(size As Integer) As String
        Return Triangle(size)
    End Function

    Private Shared Function Triangle(size AS Integer) AS String
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

    ' 問題 6-5: 任意の文字 ch で作った直角三角形を文字列で返す（行を Environment.NewLine で結合）
    Public Shared Function Problem6_5(size As Integer, ch As Char) As String
        Return TriangleWithChar(size, ch)
    End Function

    Private Shared Function TriangleWithChar(size As Integer, ch As Char) As String
        Dim result As String = ""
        For i As Integer = 1 To size
            For j As Integer = 1 To i
                result = result & ch
            Next
            If i < size Then
                result = result & Environment.NewLine
            End If
        Next
        Return result
    End Function

    ' 問題 6-6: 九九の n の段を文字列で返す（"n×1=積" 形式、行を Environment.NewLine で結合）
    Public Shared Function Problem6_6(n As Integer) As String
        Return Kuku(n)
    End Function

    Private Shared Function Kuku(n As Integer) AS String
        Dim result As String = ""
        For m As Integer = 1 To 9
            result = result & $"{n}×{m}={n * m}"
            If m < 9 Then
                result = result & Environment.NewLine
            End If
        Next
        Return result
    End Function

    ' 問題 6-7: n が素数なら True、そうでなければ False を返す
    Public Shared Function Problem6_7(n As Integer) As Boolean
        Return IsPrime(n)
    End Function

    Private Shared Function IsPrime(n As Integer) As Boolean
        If n <= 1 Then Return False
        For x As Integer = 2 To Math.Sqrt(n)
            If n Mod x = 0 Then Return False
        Next
        Return True
    End Function

    ' 問題 6-8: a と b の値を交換する（ByRef で呼び出し元の変数を書き換える）
    Public Shared Sub Problem6_8(ByRef a As Integer, ByRef b As Integer)
        Swap(a, b)
    End Sub

    Private Shared Sub Swap(ByRef a As Integer, ByRef b As Integer)
        Dim tmp As Integer = a
        a = b
        b = tmp
    End Sub

    ' 問題 6-9: numbers を昇順に並べ替える（元の配列を直接書き換える）
    Public Shared Sub Problem6_9(numbers As Integer())
        Sort(numbers)
    End Sub

    Private Shared Sub Sort(numbers As Integer())
        For i As Integer = 0 To numbers.Length - 1
            Dim min As Integer = Integer.MaxValue
            Dim minIndex As Integer = i
            For j As Integer = i To numbers.Length - 1
                If numbers(j) < min Then
                    min = numbers(j)
                    minIndex = j
                End If
            Next
            Swap(numbers(i), numbers(minIndex))
        Next
    End Sub

End Class
