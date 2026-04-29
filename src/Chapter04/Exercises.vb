Public Class Exercises

    ' 問題 4-1: "SPAM" を 10 個並べた String 配列を返す
    Public Shared Function Problem4_1() As String()
        Dim result(9) As String
        For i As Integer = 0 To 9
            result(i) = "SPAM"
        Next
        Return result
    End Function

    ' 問題 4-2: 九九の三の段 (3,6,9,...,27) を Integer 配列で返す
    Public Shared Function Problem4_2() As Integer()
        Dim result(8) As Integer
        For i As Integer = 0 To 8
            Dim m As Integer = i + 1
            result(i) = 3 * m
        Next
        Return result
    End Function

    ' 問題 4-3: 2^1 〜 2^8 を Integer 配列で返す
    '           result(0)=2^1, result(1)=2^2, ..., result(7)=2^8
    Public Shared Function Problem4_3() As Integer()
        Dim result(7) As Integer
        For i As Integer = 0 To 7
            Dim n As Integer = i + 1
            result(i) = 2 ^ n
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

    ' 問題 4-5: 配列の平均値（整数）を返す
    Public Shared Function Problem4_5(numbers As Integer()) As Integer
        Dim count As Integer = numbers.Length
        Dim sum As Integer = 0
        For Each num In numbers
            sum = sum + num
        Next
        return sum \ count
    End Function

    ' 問題 4-6: 勝ち(1)/負け(0) の配列から {勝ち数, 負け数} を返す
    Public Shared Function Problem4_6(results As Integer()) As Integer()
        Dim win As Integer = 0
        Dim lose As Integer = 0
        For Each result In results
            Select Case result
                Case 0  '負け
                    lose += 1
                Case 1  '勝ち
                    win += 1
            End Select
        Next
        Return New Integer() {win, lose}
    End Function

    ' 問題 4-7: 各回の得点配列の合計を返す
    Public Shared Function Problem4_7_TotalScore(scores As Integer()) As Integer
        Dim sum As Integer = 0
        For Each score In scores
            sum = sum + score
        Next
        return sum
    End Function

    ' 問題 4-7: 巨人・阪神の合計点から勝者を返す
    '           "巨人の勝ち" / "阪神の勝ち" / "引き分け"
    Public Shared Function Problem4_7_Winner(giants As Integer, tigers As Integer) As String
        If giants > tigers Then
            Return "巨人の勝ち"
        ElseIf tigers > giants
            Return "阪神の勝ち"
        Else
            Return "引き分け"
        End If
    End Function

    ' 問題 4-8: 配列の最大値を返す
    Public Shared Function Problem4_8(numbers As Integer()) As Integer
        Dim max As Integer = Integer.MinValue
        For Each num In numbers
            if num > max Then
                max = num
            End If
        Next
        Return max
    End Function

    ' 問題 4-9: 配列の {最大値, 最小値} を返す
    Public Shared Function Problem4_9(numbers As Integer()) As Integer()
        Dim max As Integer = Integer.MinValue
        Dim min As Integer = Integer.MaxValue
        For Each num In numbers
            If num > max Then
                max = num
            End If
            If num < min Then
                min = num
            End If
        Next
        Return New Integer() {max, min}
    End Function

    ' 問題 4-10: "*" を n 個並べた文字列を返す
    Public Shared Function Problem4_10(n As Integer) As String
        Dim result As String = ""
        For i As Integer = 1 To n
            result = result & "*"
        Next
        Return result
    End Function

    ' 問題 4-11: 0〜9 を繰り返す n 文字の文字列を返す
    '            例: n=14 → "01234567890123"
    Public Shared Function Problem4_11(n As Integer) As String
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

    ' 問題 4-12: 合計が 100 を超えた時点の合計値を返す
    Public Shared Function Problem4_12(numbers As Integer()) As Integer
        Dim sum As Integer = 0
        For Each num In numbers
            sum = sum + num
            If sum > 100 Then
                Return sum
            End If
        Next
        Return sum
    End Function

    ' 問題 4-13: 3 ストライクまたは 4 ボールで停止し "Nストライク,Mボール" を返す
    '            pitches: 1=ストライク、2=ボール
    Public Shared Function Problem4_13(pitches As Integer()) As String
        Dim strikes As Integer = 0
        Dim balls As Integer = 0
        For Each pitch In pitches
            If pitch = 1 Then
                strikes += 1
            End If
            If pitch = 2 Then
                balls += 1
            End If
            if strikes = 3 OrElse balls = 4 Then
                Return $"{strikes}ストライク,{balls}ボール"
            End If
        Next
        Return $"{strikes}ストライク,{balls}ボール"
    End Function

    ' 問題 4-14: 4-13 にファウル(3)を追加。2 ストライクまでファウルはストライク扱い
    '            pitches: 1=ストライク、2=ボール、3=ファウル
    Public Shared Function Problem4_14(pitches As Integer()) As String
        Dim strikes As Integer = 0
        Dim balls As Integer = 0
        Dim fauls As Integer = 0
        For Each pitch In pitches
            If pitch = 1 Then
                strikes += 1
            End If
            If pitch = 2 Then
                balls += 1
            End If
            If pitch = 3 AndAlso strikes < 2 Then
                strikes += 1
            End If
            if strikes = 3 OrElse balls = 4 Then
                Return $"{strikes}ストライク,{balls}ボール"
            End If
        Next
        Return $"{strikes}ストライク,{balls}ボール"
    End Function

    ' 問題 4-15: n を素因数分解した結果を昇順の Integer 配列で返す
    Public Shared Function Problem4_15(n As Integer) As Integer()
        Dim result() As Integer = New Integer() {}
        Dim i As Integer = 0
        Dim d As Integer = 2
        Do
            If n mod d = 0 Then
                n = n / d
                ReDim Preserve result(i)
                result(i) = d
                i += 1
            Else
                d += 1
            End If
        Loop While n > 1
        Return result
    End Function

    ' 問題 4-16: n が素数なら True を返す
    Public Shared Function Problem4_16(n As Integer) As Boolean
        If n = 2 Then Return False

        Dim d As Integer = 2
        Do
            If n mod d = 0 Then
                return False
            Else
                d += 1
            End If
        Loop While n > d
        Return True
    End Function

    ' 問題 4-17: 九九表を 9×9 の 2 次元配列で返す
    '            result(i, j) = (i+1) × (j+1)
    Public Shared Function Problem4_17() As Integer(,)
        Dim result(8, 8) As Integer
        For i As Integer = 0 To 8
            For j As Integer = 0 To 8
                Dim num1 = i + 1
                Dim num2 = j + 1
                result(i, j) = num1 * num2
            Next
        Next
        Return result
    End Function

    ' 問題 4-18: 最初の 0 の手前までの合計を返す（0 は含めない）
    Public Shared Function Problem4_18(numbers As Integer()) As Integer
        Dim sum As Integer = 0
        For Each num In numbers
            if num = 0 Then
                Return sum
            End If
            sum += num
        Next
        Return sum
    End Function

    ' 問題 4-19: 最初の 0 の手前までの平均値（整数）を返す（0 は含めない）
    Public Shared Function Problem4_19(numbers As Integer()) As Integer
        Dim count As Integer = 0
        Dim sum As Integer = 0
        For Each num In numbers
            if num = 0 Then
                Return sum \ count
            End If
            count += 1
            sum += num
        Next
        Return sum \ count
    End Function

    ' 問題 4-20: "$" で作った三角形の各行を String 配列で返す
    '            例: size=3 → {"$", "$$", "$$$"}
    Public Shared Function Problem4_20(size As Integer) As String()
        Dim result() As String = New String() {}
        For i As Integer = 0 To size - 1
            Dim mark As String = ""
            For j As Integer = 0 To i
                mark = mark & "$"
            Next
            Redim Preserve result(i)
            result(i) = mark
        Next
        Return result
    End Function

    ' 問題 4-21: "X" で作った × 印の各行を String 配列で返す（末尾空白なし）
    '            例: size=3 → {"X X", " X", "X X"}
    Public Shared Function Problem4_21(size As Integer) As String()
        Dim result(size - 1) As String
        For i As Integer = 0 To size - 1
            Dim mark As String = ""
            Dim left As Integer = i
            Dim right As Integer = size - 1 - i
            For j As Integer = 0 To size - 1
                If left <= right AndAlso j > right Then Exit For
                If left >= right AndAlso j > left Then Exit For

                If j = left Then
                    mark = mark & "X"
                ElseIf j = right Then
                    mark = mark & "X"
                Else
                    mark = mark & " "
                End If
            Next
            result(i) = mark
        Next
        Return result
    End Function

    ' 問題 4-22: フィボナッチ数列の 1000 以下の項を Integer 配列で返す
    '            先頭は 0, 1 とする
    Public Shared Function Problem4_22() As Integer()
        Dim result(1) As Integer
        result(0) = 0
        result(1) = 1
        Dim i As Integer = 1
        Do While result(i - 1) + result(i) <= 1000
            Dim num As Integer = result(i - 1) + result(i)
            i += 1
            ReDim Preserve result(i)
            result(i) = num
        Loop
        Return result
    End Function

End Class
