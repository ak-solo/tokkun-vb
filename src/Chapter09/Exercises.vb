Imports System.Linq
Imports System.Collections.Generic

Public Class Exercises

    ' 問題 9-1: threshold 以上の要素を昇順に返す（Where + OrderBy）
    Public Shared Function Problem9_1(numbers As Integer(), threshold As Integer) As Integer()
        Throw New NotImplementedException("問題 9-1 を実装してください")
    End Function

    ' 問題 9-2: 各要素を "{n}番" の文字列に変換した配列を返す（Select）
    Public Shared Function Problem9_2(numbers As Integer()) As String()
        Throw New NotImplementedException("問題 9-2 を実装してください")
    End Function

    ' 問題 9-3: 文字数の短い順（同じ文字数はアルファベット順）に並べた配列を返す（OrderBy + ThenBy）
    Public Shared Function Problem9_3(words As String()) As String()
        Throw New NotImplementedException("問題 9-3 を実装してください")
    End Function

    ' 問題 9-4: 平均値（Double）を返す（Average）
    Public Shared Function Problem9_4(scores As Integer()) As Double
        Throw New NotImplementedException("問題 9-4 を実装してください")
    End Function

    ' 問題 9-5: 偶数を抽出 → 2乗 → 昇順（Where + Select + OrderBy のチェーン）
    Public Shared Function Problem9_5(numbers As Integer()) As Integer()
        Throw New NotImplementedException("問題 9-5 を実装してください")
    End Function

    ' 問題 9-6: 降順に並べて先頭 n 件を返す（OrderByDescending + Take）
    Public Shared Function Problem9_6(scores As Integer(), n As Integer) As Integer()
        Throw New NotImplementedException("問題 9-6 を実装してください")
    End Function

    ' 問題 9-7: 負の数が 1 つでも含まれていれば True（Any）
    Public Shared Function Problem9_7_HasNegative(numbers As Integer()) As Boolean
        Throw New NotImplementedException("問題 9-7 の HasNegative を実装してください")
    End Function

    ' 問題 9-7: すべての要素が正の数（> 0）であれば True（All）
    Public Shared Function Problem9_7_AllPositive(numbers As Integer()) As Boolean
        Throw New NotImplementedException("問題 9-7 の AllPositive を実装してください")
    End Function

    ' 問題 9-7: threshold を超える要素の個数を返す（Count）
    Public Shared Function Problem9_7_CountOver(numbers As Integer(), threshold As Integer) As Integer
        Throw New NotImplementedException("問題 9-7 の CountOver を実装してください")
    End Function

    ' 問題 9-8: 文字数 minLength 以上の単語を文字数の降順に返す（クエリ構文）
    Public Shared Function Problem9_8(words As String(), minLength As Integer) As String()
        Throw New NotImplementedException("問題 9-8 を実装してください")
    End Function

    ' 問題 9-9: 先頭文字ごとの出現件数を Dictionary で返す（GroupBy）
    Public Shared Function Problem9_9(words As String()) As Dictionary(Of Char, Integer)
        Throw New NotImplementedException("問題 9-9 を実装してください")
    End Function

End Class
