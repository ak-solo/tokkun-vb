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
        Dim j As Integer = 0
        For i As Integer = numbers.Length - 1 To 0 Step -1
            result(j) = numbers(i)
            j += 1
        Next
        Return result
    End Function

    ' 問題 5-3: 偶数と奇数に分類して返す（ジャグ配列）
    '           result(0) = 偶数配列、result(1) = 奇数配列（入力順を保つ）
    Public Shared Function Problem5_3(numbers As Integer()) As Integer()()
        Dim even() As Integer = New Integer() {}
        Dim odd() As Integer = New Integer() {}
        Dim evenIndex As Integer = 0
        Dim oddIndex As Integer = 0
        For Each num In numbers
            If num mod 2 = 0 Then
                ReDim Preserve even(evenIndex)
                even(evenIndex) = num
                evenIndex += 1
            Else
                ReDim Preserve odd(oddIndex)
                odd(oddIndex) = num
                oddIndex += 1
            End If
        Next
        Return New Integer()() {even, odd}
    End Function

    ' 問題 5-4: 合計が 100 を超えるか 10 個収集するまで要素を集めて返す
    Public Shared Function Problem5_4(numbers As Integer()) As Integer()
        Dim result() As Integer = New Integer() {}
        Dim sum As Integer = 0
        For i As Integer = 0 To numbers.Length - 1
            sum += numbers(i)
            ReDim Preserve result(i)
            result(i) = numbers(i)
            If sum > 100 OrElse result.Length = 10 Then
                Return result
            End If
        Next
        Return result
    End Function

    ' 問題 5-5: value の 16 桁 2 進数表現を Integer 配列で返す
    '           result(0) = MSB（最上位ビット）、result(15) = LSB（最下位ビット）
    Public Shared Function Problem5_5(value As Integer) As Integer()
        Dim result(15) As Integer
        For i As Integer = 15 To 0 Step -1
            If value = 0 Then
                result(i) = 0
            Else
                result(i) = value mod 2
                value = value \ 2
            End If
        Next
        Return result
    End Function

    ' 問題 5-6: 九九表を 9×9 の 2 次元配列で返す
    '           result(i, j) = (i+1) × (j+1)
    Public Shared Function Problem5_6() As Integer(,)
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

    ' 問題 5-7: 九九配列を内部で使用して x × y を返す（1 ≤ x, y ≤ 9）
    Public Shared Function Problem5_7(x As Integer, y As Integer) As Integer
        Dim kuku As Integer(,) = Problem5_6()
        Return kuku(x - 1, y - 1)
    End Function

    ' 問題 5-8: 昇順に並べ替えた新しい配列を返す
    Public Shared Function Problem5_8(numbers As Integer()) As Integer()
        Dim result() As Integer = numbers.Clone()
        For i As Integer = 0 To result.Length - 1
            For j As Integer = 1 To result.Length - 1 - i
                if result(j - 1) > result(j) Then
                    Dim tmp = result(j - 1)
                    result(j - 1) = result(j)
                    result(j) = tmp
                End If
            Next
        Next
        Return result
    End Function

End Class
