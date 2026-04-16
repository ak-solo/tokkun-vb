Public Class Exercises

    ' 問題 2-1: 入力された文字列をそのまま返す
    Public Shared Function Problem2_1(s As String) As String  
     Return s
    End Function

    ' 問題 2-2: 入力された整数をそのまま返す
    Public Shared Function Problem2_2(x As Integer) As Integer
        return x
    End Function
    ' 問題 2-3: x の 1 乗・2 乗・3 乗を配列で返す
    '           result(0)=x^1, result(1)=x^2, result(2)=x^3
    Public Shared Function Problem2_3(x As Integer) As Integer()
        Return New Integer() {x ^ 1, x ^ 2, x ^ 3}
    End Function
    ' 問題 2-4: x と y の和を返す
    Public Shared Function Problem2_4_Sum(x As Integer, y As Integer) As Integer
       return(x+y)
    End Function

    ' 問題 2-4: x と y の差（x - y）を返す
    Public Shared Function Problem2_4_Difference(x As Integer, y As Integer) As Integer
        return(x-y)
    End Function

    ' 問題 2-4: x と y の積を返す
    Public Shared Function Problem2_4_Product(x As Integer, y As Integer) As Integer
        return(x*y)
    End Function

    ' 問題 2-4: x ÷ y の結果を Double で返す（小数あり）
    Public Shared Function Problem2_4_Division(x As Integer, y As Integer) As Double
        return(X/y)
    End Function

    ' 問題 2-4: x ÷ y の商（整数）を返す
    Public Shared Function Problem2_4_Quotient(x As Integer, y As Integer) As Integer
        return(X\y)
    End Function

    ' 問題 2-4: x ÷ y の余りを返す
    Public Shared Function Problem2_4_Remainder(x As Integer, y As Integer) As Integer
        return(X mod y)
    End Function

    ' 問題 2-5: a と b の平均値（小数切り捨て）を返す
    Public Shared Function Problem2_5(a As Integer, b As Integer) As Integer
        return((a+b)\2)
    End Function

    ' 問題 2-6: 年齢から生まれてからの日数（年齢 × 365）を返す
    Public Shared Function Problem2_6(age As Integer) As Integer
        return(age*365)
    End Function

End Class
