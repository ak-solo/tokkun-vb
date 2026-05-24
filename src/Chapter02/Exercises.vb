Public Class Exercises

    ' 問題 2-1: 入力された文字列をそのまま返す
    Public Shared Function Problem2_1(s As String) As String
        Return s
    End Function

    ' 問題 2-2: 入力された整数をそのまま返す
    Public Shared Function Problem2_2(x As Integer) As Integer
        Return x
    End Function

    ' 問題 2-3: x を 2 倍・3 倍・4 倍した結果をカンマ区切りの文字列で返す
    Public Shared Function Problem2_3(x As Integer) As String
        Return $"{x * 2},{x * 3},{x * 4}"
    End Function

    ' 問題 2-4: x の 1 乗・2 乗・3 乗をカンマ区切りの文字列で返す
    Public Shared Function Problem2_4(x As Integer) As String
        Return $"{x},{x ^ 2},{x ^ 3}"
    End Function

    ' 問題 2-5: x と y の和を返す
    Public Shared Function Problem2_5_Sum(x As Integer, y As Integer) As Integer
        Return x + y
    End Function

    ' 問題 2-5: x と y の差（x - y）を返す
    Public Shared Function Problem2_5_Difference(x As Integer, y As Integer) As Integer
        Return x - y
    End Function

    ' 問題 2-5: x と y の積を返す
    Public Shared Function Problem2_5_Product(x As Integer, y As Integer) As Integer
        Return x * y
    End Function

    ' 問題 2-5: x ÷ y の結果を Double で返す（小数あり）
    Public Shared Function Problem2_5_Division(x As Integer, y As Integer) As Double
        Return x / y
    End Function

    ' 問題 2-5: x ÷ y の商（整数）を返す
    Public Shared Function Problem2_5_Quotient(x As Integer, y As Integer) As Integer
        Return x \ y
    End Function

    ' 問題 2-5: x ÷ y の余りを返す
    Public Shared Function Problem2_5_Remainder(x As Integer, y As Integer) As Integer
        Return x Mod y
    End Function

    ' 問題 2-6: a と b の平均値（小数切り捨て）を返す
    Public Shared Function Problem2_6(a As Integer, b As Integer) As Integer
        Return (a + b) \ 2
    End Function

    ' 問題 2-7: 年齢から生まれてからの日数（年齢 × 365）を返す
    Public Shared Function Problem2_7(age As Integer) As Integer
        Return age * 365
    End Function

    ' 問題 2-8: x を y で割った商と余りをカンマ区切りの文字列で返す
    Public Shared Function Problem2_8(x As Integer, y As Integer) As String
        Throw New NotImplementedException("問題 2-8 を実装してください")
    End Function

End Class
