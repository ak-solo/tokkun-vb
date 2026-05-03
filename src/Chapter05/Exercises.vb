Public Class Exercises

    ' 問題 5-1: 各要素を 2 倍にした新しい配列を返す
    Public Shared Function Problem5_1(numbers As Integer()) As Integer()
        Dim result(numbers.Length - 1) As Integer
        For i As Integer = 0 To numbers.Length - 1
            result(i) = numbers(i) * 2
        Next
        Return result
    End Function

    ' 問題 5-2: 逆順にした新しい配列を返す
    Public Shared Function Problem5_2(numbers As Integer()) As Integer()
        Dim result(numbers.Length - 1) As Integer
        For i As Integer = 0 To numbers.Length - 1
            result(i) = numbers(numbers.Length - 1 - i)
        Next
        Return result
    End Function

    ' 問題 5-3: 偶数と奇数に分類して返す（ジャグ配列）
    '           result(0) = 偶数配列、result(1) = 奇数配列（入力順を保つ）
    Public Shared Function Problem5_3(numbers As Integer()) As Integer()()
        Dim even As New List(Of Integer)
        Dim odd As New List(Of Integer)
        For Each num In numbers
            If num Mod 2 = 0 Then
                even.Add(num)
            Else
                odd.Add(num)
            End If
        Next
        Return New Integer()() {even.ToArray(), odd.ToArray()}
    End Function

    ' 問題 5-4: 合計が 100 を超えるか 10 個収集するまで要素を集めて返す
    Public Shared Function Problem5_4(numbers As Integer()) As Integer()
        Dim result As New List(Of Integer)
        Dim sum As Integer = 0
        For i As Integer = 0 To numbers.Length - 1
            sum += numbers(i)
            result.Add(numbers(i))
            If sum > 100 OrElse result.Count = 10 Then
                Return result.ToArray()
            End If
        Next
        Return result.ToArray()
    End Function

    ' 問題 5-5: value の 16 桁 2 進数表現を Integer 配列で返す
    '           result(0) = MSB（最上位ビット）、result(15) = LSB（最下位ビット）
    Public Shared Function Problem5_5(value As Integer) As Integer()
        Dim result(15) As Integer
        For i As Integer = 15 To 0 Step -1
            If value = 0 Then Exit For
            result(i) = value Mod 2
            value = value \ 2
        Next
        Return result
    End Function

    ' 問題 5-6: 九九表を 9×9 の 2 次元配列で返す
    '           result(i, j) = (i+1) × (j+1)
    Public Shared Function Problem5_6() As Integer(,)
        Dim result(8, 8) As Integer
        For i As Integer = 0 To 8
            For j As Integer = 0 To 8
                result(i, j) = (i + 1) * (j + 1)
            Next
        Next
        Return result
    End Function

    ' 問題 5-7: 九九配列を内部で使用して x × y を返す（1 ≤ x, y ≤ 9）
    Public Shared Function Problem5_7(x As Integer, y As Integer) As Integer
        Dim kuku As Integer(,) = Problem5_6()
        Return kuku(x - 1, y - 1)
    End Function

    ' 問題 5-8: 昇順に並べ替えた新しい配列を返す
    Public Shared Function Problem5_8(numbers As Integer()) As Integer()
        Dim result(numbers.Length - 1) As Integer
        For i As Integer = 0 To numbers.Length - 1
            result(i) = numbers(i)
        Next
        For i As Integer = 0 To result.Length - 1
            For j As Integer = 1 To result.Length - 1 - i
                If result(j - 1) > result(j) Then
                    Dim tmp = result(j - 1)
                    result(j - 1) = result(j)
                    result(j) = tmp
                End If
            Next
        Next
        Return result
    End Function

    ' 問題 5-9: 配列の平均値（整数）を返す
    Public Shared Function Problem5_9(numbers As Integer()) As Integer
        Dim count As Integer = numbers.Length
        Dim sum As Integer = 0
        For Each num In numbers
            sum = sum + num
        Next
        Return sum \ count
    End Function

    ' 問題 5-10: 勝ち(1)/負け(0) の配列から {勝ち数, 負け数} を返す
    Public Shared Function Problem5_10(results As Integer()) As Integer()
        Dim win As Integer = 0
        Dim lose As Integer = 0
        For Each r In results
            If r = 1 Then
                win += 1
            Else
                lose += 1
            End If
        Next
        Return New Integer() {win, lose}
    End Function

    ' 問題 5-11: 各回の得点配列の合計を返す
    Public Shared Function Problem5_11_TotalScore(scores As Integer()) As Integer
        Dim sum As Integer = 0
        For Each score In scores
            sum = sum + score
        Next
        Return sum
    End Function

    ' 問題 5-12: 配列の最大値を返す
    Public Shared Function Problem5_12(numbers As Integer()) As Integer
        Dim max As Integer = numbers(0)
        For Each num In numbers
            If num > max Then
                max = num
            End If
        Next
        Return max
    End Function

    ' 問題 5-13: 配列の {最大値, 最小値} を返す
    Public Shared Function Problem5_13(numbers As Integer()) As Integer()
        Dim max As Integer = numbers(0)
        Dim min As Integer = numbers(0)
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

    ' 問題 5-14: 合計が 100 を超えた時点の合計値を返す
    Public Shared Function Problem5_14(numbers As Integer()) As Integer
        Dim sum As Integer = 0
        For Each num In numbers
            sum = sum + num
            If sum > 100 Then
                Return sum
            End If
        Next
        Return sum
    End Function

    ' 問題 5-15: 3 ストライクまたは 4 ボールで停止し "Nストライク,Mボール" を返す
    '            pitches: 1=ストライク、2=ボール
    Public Shared Function Problem5_15(pitches As Integer()) As String
        Dim strikes As Integer = 0
        Dim balls As Integer = 0
        For Each pitch In pitches
            If pitch = 1 Then
                strikes += 1
            ElseIf pitch = 2 Then
                balls += 1
            End If
            If strikes = 3 OrElse balls = 4 Then
                Return $"{strikes}ストライク,{balls}ボール"
            End If
        Next
        Return $"{strikes}ストライク,{balls}ボール"
    End Function

    ' 問題 5-16: 5-15 にファウル(3)を追加。2 ストライクまでファウルはストライク扱い
    '            pitches: 1=ストライク、2=ボール、3=ファウル
    Public Shared Function Problem5_16(pitches As Integer()) As String
        Dim strikes As Integer = 0
        Dim balls As Integer = 0
        For Each pitch In pitches
            If pitch = 1 Then
                strikes += 1
            ElseIf pitch = 2 Then
                balls += 1
            ElseIf pitch = 3 AndAlso strikes < 2 Then
                strikes += 1
            End If
            If strikes = 3 OrElse balls = 4 Then
                Return $"{strikes}ストライク,{balls}ボール"
            End If
        Next
        Return $"{strikes}ストライク,{balls}ボール"
    End Function

    ' 問題 5-17: 最初の 0 の手前までの合計を返す（0 は含めない）
    Public Shared Function Problem5_17(numbers As Integer()) As Integer
        Dim sum As Integer = 0
        For Each num In numbers
            If num = 0 Then
                Return sum
            End If
            sum += num
        Next
        Return sum
    End Function

    ' 問題 5-18: 最初の 0 の手前までの平均値（整数）を返す（0 は含めない）
    Public Shared Function Problem5_18(numbers As Integer()) As Integer
        Dim count As Integer = 0
        Dim sum As Integer = 0
        For Each num In numbers
            If num = 0 Then
                If count = 0 Then Return 0
                Return sum \ count
            End If
            count += 1
            sum += num
        Next
        Return sum \ count
    End Function

End Class
