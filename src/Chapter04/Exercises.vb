Public Class Exercises

    ' 問題 4-1: "SPAM" を 10 個並べた String 配列を返す
    Public Shared Function Problem4_1() As String()
        Dim numbers = {"SPAM","SPAM","SPAM","SPAM","SPAM","SPAM","SPAM","SPAM","SPAM","SPAM"}
        return numbers

    End Function

    ' 問題 4-2: 九九の三の段 (3,6,9,...,27) を Integer 配列で返す
    Public Shared Function Problem4_2() As Integer()
        Dim scores(9) 
        For i = 0 To 28 Step 3
        scores(i)
        Next
        return scores
    End Function

    ' 問題 4-3: 2^1 〜 2^8 を Integer 配列で返す
    '           result(0)=2^1, result(1)=2^2, ..., result(7)=2^8
    Public Shared Function Problem4_3() As Integer()
        Throw New NotImplementedException("問題 4-3 を実装してください")
    End Function

    ' 問題 4-4: 7! を返す
    Public Shared Function Problem4_4() As Integer
        Throw New NotImplementedException("問題 4-4 を実装してください")
    End Function

    ' 問題 4-5: 配列の平均値（整数）を返す
    Public Shared Function Problem4_5(numbers As Integer()) As Integer
        Throw New NotImplementedException("問題 4-5 を実装してください")
    End Function

    ' 問題 4-6: 勝ち(1)/負け(0) の配列から {勝ち数, 負け数} を返す
    Public Shared Function Problem4_6(results As Integer()) As Integer()
        Throw New NotImplementedException("問題 4-6 を実装してください")
    End Function

    ' 問題 4-7: 各回の得点配列の合計を返す
    Public Shared Function Problem4_7_TotalScore(scores As Integer()) As Integer
        Throw New NotImplementedException("問題 4-7（合計）を実装してください")
    End Function

    ' 問題 4-7: 巨人・阪神の合計点から勝者を返す
    '           "巨人の勝ち" / "阪神の勝ち" / "引き分け"
    Public Shared Function Problem4_7_Winner(giants As Integer, tigers As Integer) As String
        Throw New NotImplementedException("問題 4-7（勝者）を実装してください")
    End Function

    ' 問題 4-8: 配列の最大値を返す
    Public Shared Function Problem4_8(numbers As Integer()) As Integer
        Throw New NotImplementedException("問題 4-8 を実装してください")
    End Function

    ' 問題 4-9: 配列の {最大値, 最小値} を返す
    Public Shared Function Problem4_9(numbers As Integer()) As Integer()
        Throw New NotImplementedException("問題 4-9 を実装してください")
    End Function

    ' 問題 4-10: "*" を n 個並べた文字列を返す
    Public Shared Function Problem4_10(n As Integer) As String
        Throw New NotImplementedException("問題 4-10 を実装してください")
    End Function

    ' 問題 4-11: 0〜9 を繰り返す n 文字の文字列を返す
    '            例: n=14 → "01234567890123"
    Public Shared Function Problem4_11(n As Integer) As String
        Throw New NotImplementedException("問題 4-11 を実装してください")
    End Function

    ' 問題 4-12: 合計が 100 を超えた時点の合計値を返す
    Public Shared Function Problem4_12(numbers As Integer()) As Integer
        Throw New NotImplementedException("問題 4-12 を実装してください")
    End Function

    ' 問題 4-13: 3 ストライクまたは 4 ボールで停止し "Nストライク,Mボール" を返す
    '            pitches: 1=ストライク、2=ボール
    Public Shared Function Problem4_13(pitches As Integer()) As String
        Throw New NotImplementedException("問題 4-13 を実装してください")
    End Function

    ' 問題 4-14: 4-13 にファウル(3)を追加。2 ストライクまでファウルはストライク扱い
    '            pitches: 1=ストライク、2=ボール、3=ファウル
    Public Shared Function Problem4_14(pitches As Integer()) As String
        Throw New NotImplementedException("問題 4-14 を実装してください")
    End Function

    ' 問題 4-15: n を素因数分解した結果を昇順の Integer 配列で返す
    Public Shared Function Problem4_15(n As Integer) As Integer()
        Throw New NotImplementedException("問題 4-15 を実装してください")
    End Function

    ' 問題 4-16: n が素数なら True を返す
    Public Shared Function Problem4_16(n As Integer) As Boolean
        Throw New NotImplementedException("問題 4-16 を実装してください")
    End Function

    ' 問題 4-17: 九九表を 9×9 の 2 次元配列で返す
    '            result(i, j) = (i+1) × (j+1)
    Public Shared Function Problem4_17() As Integer(,)
        Throw New NotImplementedException("問題 4-17 を実装してください")
    End Function

    ' 問題 4-18: 最初の 0 の手前までの合計を返す（0 は含めない）
    Public Shared Function Problem4_18(numbers As Integer()) As Integer
        Throw New NotImplementedException("問題 4-18 を実装してください")
    End Function

    ' 問題 4-19: 最初の 0 の手前までの平均値（整数）を返す（0 は含めない）
    Public Shared Function Problem4_19(numbers As Integer()) As Integer
        Throw New NotImplementedException("問題 4-19 を実装してください")
    End Function

    ' 問題 4-20: "$" で作った三角形の各行を String 配列で返す
    '            例: size=3 → {"$", "$$", "$$$"}
    Public Shared Function Problem4_20(size As Integer) As String()
        Throw New NotImplementedException("問題 4-20 を実装してください")
    End Function

    ' 問題 4-21: "X" で作った × 印の各行を String 配列で返す（末尾空白なし）
    '            例: size=3 → {"X X", " X", "X X"}
    Public Shared Function Problem4_21(size As Integer) As String()
        Throw New NotImplementedException("問題 4-21 を実装してください")
    End Function

    ' 問題 4-22: フィボナッチ数列の 1000 以下の項を Integer 配列で返す
    '            先頭は 0, 1 とする
    Public Shared Function Problem4_22() As Integer()
        Throw New NotImplementedException("問題 4-22 を実装してください")
    End Function

End Class
