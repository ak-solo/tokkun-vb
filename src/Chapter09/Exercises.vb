Imports System.Linq
Imports System.Collections.Generic

Public Class Exercises

    ' 問題 9-1: threshold 以上の要素を昇順に返す（Where + OrderBy）
    Public Shared Function Problem9_1(numbers As Integer(), threshold As Integer) As Integer()
        Return numbers _
            .Where(Function(n) n >= threshold) _
            .OrderBy(Function(n) n) _
            .ToArray()
    End Function

    ' 問題 9-2: 各要素を "{n}番" の文字列に変換した配列を返す（Select）
    Public Shared Function Problem9_2(numbers As Integer()) As String()
        Return numbers _
            .Select(Function(n) $"{n}番") _
            .ToArray()
    End Function

    ' 問題 9-3: 文字数の短い順（同じ文字数はアルファベット順）に並べた配列を返す（OrderBy + ThenBy）
    Public Shared Function Problem9_3(words As String()) As String()
        Return words _
            .OrderBy(Function(w) w.Length) _
            .ThenBy(Function(w) w) _
            .ToArray()
    End Function

    ' 問題 9-4: 平均値（Double）を返す（Average）
    Public Shared Function Problem9_4(scores As Integer()) As Double
        Return scores.Average()
    End Function

    ' 問題 9-5: 偶数を抽出 → 2乗 → 昇順（Where + Select + OrderBy のチェーン）
    Public Shared Function Problem9_5(numbers As Integer()) As Integer()
        Return numbers _
            .Where(Function(n) n Mod 2 = 0) _
            .Select(Function(n) n * n) _
            .OrderBy(Function(n) n) _
            .ToArray()
    End Function

    ' 問題 9-6: 降順に並べて先頭 n 件を返す（OrderByDescending + Take）
    Public Shared Function Problem9_6(scores As Integer(), n As Integer) As Integer()
        Return scores _
            .OrderByDescending(Function(s) s) _
            .Take(n) _
            .ToArray()
    End Function

    ' 問題 9-7: 負の数が 1 つでも含まれていれば True（Any）
    Public Shared Function Problem9_7_HasNegative(numbers As Integer()) As Boolean
        Return numbers.Any(Function(n) n < 0)
    End Function

    ' 問題 9-7: すべての要素が正の数（> 0）であれば True（All）
    Public Shared Function Problem9_7_AllPositive(numbers As Integer()) As Boolean
        Return numbers.All(Function(n) n > 0)
    End Function

    ' 問題 9-7: threshold を超える要素の個数を返す（Count）
    Public Shared Function Problem9_7_CountOver(numbers As Integer(), threshold As Integer) As Integer
        Return numbers.Count(Function(n) n > threshold)
    End Function

    ' 問題 9-8: 文字数 minLength 以上の単語を文字数の降順に返す（クエリ構文）
    Public Shared Function Problem9_8(words As String(), minLength As Integer) As String()
        Return (From w In words
                Where w.Length >= minLength
                Order By w.Length Descending
                Select w).ToArray()
    End Function

    ' 問題 9-9: 先頭文字ごとの出現件数を Dictionary で返す（GroupBy）
    Public Shared Function Problem9_9(words As String()) As Dictionary(Of Char, Integer)
        Return words _
            .GroupBy(Function(w) w(0)) _
            .ToDictionary(Function(g) g.Key, Function(g) g.Count())
    End Function

End Class
