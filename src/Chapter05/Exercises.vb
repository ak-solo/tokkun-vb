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

End Class
