Public Class Exercises

    ' 問題 1-1: "Hello World" を返す
    Public Shared Function Problem1_1() As String
        Return "Hello World"
    End Function

    ' 問題 1-2: 変数 x に 11 を代入し、"x=11" を返す
    Public Shared Function Problem1_2() As String
        Dim x As Integer = 11
        Return $"x={x}"
    End Function

    ' 問題 1-3: 変数 x=13, y=17 を代入し、"x=13,y=17" を返す
    Public Shared Function Problem1_3() As String
        Dim x As Integer = 13
        Dim y As Integer = 17
        Return $"x={x},y={y}"
    End Function

    ' 問題 1-4: 13 と 17 の和を返す
    Public Shared Function Problem1_4() As Integer
        Dim x As Integer = 13 + 17
        Return x
    End Function

    ' 問題 1-5: 13 と 17 の積を返す（変数を使わないこと）
    Public Shared Function Problem1_5() As Integer
        Return 13 * 17
    End Function

    ' 問題 1-6: x=7 を 3 倍した値と、さらに整数除算で半分にした値をカンマ区切りで返す
    Public Shared Function Problem1_6() As String
        Dim x As Integer = 7
        x = x * 3
        Return $"{x},{x \ 2}"
    End Function

    ' 問題 1-7: x=3, y=7 の値を入れ替えた結果を "x=7,y=3" の形式で返す
    Public Shared Function Problem1_7() As String
        Dim x As Integer = 3
        Dim y As Integer = 7
        Dim tmp As Integer = x
        x = y
        y = tmp
        Return $"x={x},y={y}"
    End Function

    ' 問題 1-8: 変数 x=19, y=23 の積を変数 z に代入して返す
    Public Shared Function Problem1_8() As Integer
        Dim x As Integer = 19
        Dim y As Integer = 23
        Dim z As Integer = x * y
        Return z
    End Function

    ' 問題 1-9: Integer 変数 x=10, y=3 を宣言し、x / y の結果（Double）を返す
    Public Shared Function Problem1_9() As Double
        Dim x As Integer = 10
        Dim y As Integer = 3
        Return x / y
    End Function

    ' 問題 1-10: 10 \ 3 の結果を Integer 変数に代入して返す
    Public Shared Function Problem1_10() As Integer
        Dim x As Integer = 10 \ 3
        Return x
    End Function

End Class
