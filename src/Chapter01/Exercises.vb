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

    ' 問題 1-6: x=7 を 3 倍し、さらに半分（整数除算）にした各ステップを配列で返す
    '           result(0) = 3 倍後の値、result(1) = 半分にした値
    Public Shared Function Problem1_6() As Integer()
        Dim x As Integer = 7
        Dim step1 As Integer = x * 3
        Dim step2 As Integer = step1 \ 2
        Return New Integer() {step1, step2}
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

    ' 問題 1-9: x を 2 倍・3 倍・4 倍した結果を配列で返す
    '           result(0)=x*2, result(1)=x*3, result(2)=x*4
    Public Shared Function Problem1_9(x As Integer) As Integer()
        Return New Integer() {x * 2, x * 3, x * 4}
    End Function

    ' 問題 1-10: x の 1 乗・2 乗・3 乗を配列で返す
    '            result(0)=x^1, result(1)=x^2, result(2)=x^3
    Public Shared Function Problem1_10(x As Integer) As Integer()
        Return New Integer() {x ^ 1, x ^ 2, x ^ 3}
    End Function

    ' 問題 1-11: Integer 変数 x=10, y=3 を宣言し、x / y の結果（Double）を返す
    Public Shared Function Problem1_11() As Double
        Dim x As Integer = 10
        Dim y As Integer = 3
        Return x / y
    End Function

    ' 問題 1-12: 10 \ 3 の結果を Integer 変数に代入して返す
    Public Shared Function Problem1_12() As Integer
        Dim x As Integer = 10 \ 3
        Return x
    End Function

    ' 問題 1-13: x を y で割った商と余りを配列で返す
    '            result(0) = 商、result(1) = 余り
    Public Shared Function Problem1_13(x As Integer, y As Integer) As Integer()
        Return New Integer() {x \ y, x mod y}
    End Function

End Class
