Public Class Exercises

    ' 問題 3-1: x > y のとき "xはyより大きい。"、それ以外は "" を返す
    Public Shared Function Problem3_1(x As Integer, y As Integer) As String
        if x>y then
            return "xはyより大きい。"
        else
            return""
        end if
    End Function

    ' 問題 3-2: x > y → "xはyより大きい"、x < y → "xはyより小さい"、x = y → ""
    Public Shared Function Problem3_2(x As Integer, y As Integer) As String
        if x>y then
            return "xはyより大きい"
        elseif x < y then
            return "xはyより小さい"
        else
            return""
        end if
    End Function

    ' 問題 3-3: x と y の大きい方を返す
    Public Shared Function Problem3_3(x As Integer, y As Integer) As Integer
        if x>y then
            return x
        else
            return y
        end if
    End Function

    ' 問題 3-4: x > y → "xはyより大きい"、x < y → "xはyより小さい"、x = y → "xとyは等しい"
    Public Shared Function Problem3_4(x As Integer, y As Integer) As String
        if x>y then
            return "xはyより大きい"
        elseif x < y then
            return "xはyより小さい"
        else
            return"xとyは等しい"
        end if
    End Function

    ' 問題 3-5: 偶数なら "偶数"、奇数なら "奇数" を返す
    Public Shared Function Problem3_5(x As Integer) As String
        if  x mod 2 = 0 then
            return "偶数"
        else
            return "奇数"
        end if
    End Function

    ' 問題 3-6: "正の偶数" / "正の奇数" / "負の偶数" / "負の奇数" を返す（0 は "正の偶数"）
    Public Shared Function Problem3_6(x As Integer) As String
        if x>=0 and x mod 2 = 0 then
            return "正の偶数"
        elseif x>0 and x mod 2 <> 0 then 
            return "正の奇数"
        elseif x<0 and x mod 2 = 0 then 
            return "負の偶数"
         elseif x<0 and x mod 2 <> 0 then 
            return "負の奇数"
         else
            return "予想外"
        end if
    End Function

    ' 問題 3-7 ケース1: 60点以上 → "合格"、未満 → "不合格"
    Public Shared Function Problem3_7_Case1(score As Integer) As String
        select Case score
            case 60 to 100
                return "合格"
            case else 
                return "不合格"
        end select
    End Function

    ' 問題 3-7 ケース2: 80点以上 → "たいへんよくできました。"
    '                   60点以上 → "よくできました。"
    '                   60点未満 → "ざんねんでした。"
    Public Shared Function Problem3_7_Case2(score As Integer) As String
        select Case score
            case 80 to 100
                return "たいへんよくできました。"
            case 60 to 79
                return "よくできました。"
            case else 
                return "ざんねんでした。"
        end select
    End Function

    ' 問題 3-7 ケース3: 80点以上 → "優"、70点以上 → "良"、60点以上 → "可"、未満 → "不可"
    Public Shared Function Problem3_7_Case3(score As Integer) As String
        select Case score
            case 80 to 100
                return "優"
            case 70 to 79
                return "良"
            case 60 to 69
                return "可"
            case else 
                return "不可"
        end select
    End Function

    ' 問題 3-8: 中間・期末の点数から合否を返す
    '   合格条件: 両方60点以上 / 合計130点以上 / 合計100点以上かつどちらかが90点以上
    Public Shared Function Problem3_8(midterm As Integer, final As Integer) As String
        if (midterm >= 60 and final >= 60) or (midterm + final >= 130)  or (midterm + final >=100 and midterm >= 90 or final) >=90 then
            return "合格"
        else
            return"不合格"
        end if
    End Function

    ' 問題 3-9: 曜日(0=日〜6=土)と時間帯(0=午前,1=午後,2=夜間)から "○" または "休診" を返す
    Public Shared Function Problem3_9(dayOfWeek As Integer, timeOfDay As Integer) As String
        Throw New NotImplementedException("問題 3-9 を実装してください")
    End Function

    ' 問題 3-10 条件1: x < y かつ x と y がともに偶数
    Public Shared Function Problem3_10_Cond1(x As Integer, y As Integer) As Boolean
        if x < y and x mod 2 = 0 and y mod 2 = 0 then
            return True
        else
            return false
        end if
    End Function

    ' 問題 3-10 条件2: x = y かつ負の数
    Public Shared Function Problem3_10_Cond2(x As Integer, y As Integer) As Boolean
        if x = y and 0>x and 0>y then
            return True
        else
            return false
        end if
    End Function

    ' 問題 3-10 条件3: x < y または x が偶数
    Public Shared Function Problem3_10_Cond3(x As Integer, y As Integer) As Boolean
        if x < y or x mod 2 =0 then
            return True
        else
            return false
        end if  
    End Function

    ' 問題 3-10 条件4: (x ≤ 10 または x ≥ 100) かつ (y ≥ 10 かつ y ≤ 100)
    Public Shared Function Problem3_10_Cond4(x As Integer, y As Integer) As Boolean
        if (x <= 10 or x >= 100) and (y>= 10 and y <= 100) then
            return True
        else
            return false
        end if
    End Function

    ' 問題 3-10 条件5: 「x も y も負の数」ではない（否定）
    Public Shared Function Problem3_10_Cond5(x As Integer, y As Integer) As Boolean
        if x <= 0 <> x or y <= 0 <> y then
            return True
        else
            return false
        end if
    End Function

    ' 問題 3-11: 寿司占い（Select Case を使うこと）
    '   1=まぐろ, 2=えび, 3=こはだ, 4=いくら, 5=たまご, その他 → エラーメッセージ
    Public Shared Function Problem3_11(choice As Integer) As String
    select case choice
        case 1
            return "大吉！今日は積極的に行動しよう。"
        case 2
            return "中吉。慎重に進めば良い結果が待っている。"
        case 3
            return "吉。こつこつ続けることで道が開ける。"
        case 4
            return "小吉。意外なところからチャンスがやってくる。"
        case 5
            return "末吉。今日はゆったり過ごすと吉。"
        case else
            return "選択肢は 1〜5 の数字で入力してください。"
    end select
    End Function

    ' 問題 3-12: 月の大小判定（Select Case を使うこと）
    '   大の月(1,3,5,7,8,10,12) → "{n}月は大の月です"
    '   小の月(2,4,6,9,11)      → "{n}月は小の月です"
    '   1〜12 以外              → "そんな月はありません"
    Public Shared Function Problem3_12(month As Integer) As String
        select case month
        case 1,3,5,7,8,10,12
            return $"{month}月は大の月です"
        case 2,4,6,9,11
            return $"{month}月は小の月です"
        case else
            return "そんな月はありません"
    end select
    End Function

End Class
