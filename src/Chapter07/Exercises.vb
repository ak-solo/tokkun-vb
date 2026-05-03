' 問題 7-1 〜 7-4: Dog クラス
Public Class Dog

    Private mName As String = ""
    Private mAge As Integer = 0
    Private mBreed As String = ""

    ' 問題 7-1: 引数なしコンストラクタ（空でよい）
    Public Sub New()
    End Sub

    ' 問題 7-4: 犬種を引数に取るコンストラクタ
    Public Sub New(breed As String)
        mBreed = breed
    End Sub

    ' 問題 7-1: 名前プロパティ
    Public Property Name() As String
        Get
            Return mName
        End Get
        Set(value As String)
            mName = value
        End Set
    End Property

    ' 問題 7-2: 年齢プロパティ
    Public Property Age() As Integer
        Get
            Return mAge
        End Get
        Set(value As Integer)
            mAge = value
        End Set
    End Property

    ' 問題 7-4: 犬種プロパティ（読み取り専用）
    Public ReadOnly Property Breed() As String
        Get
            Return mBreed
        End Get
    End Property

    ' 問題 7-4: "犬種: 名前 (年齢歳)" の形式で返す
    Public Function ShowProfile() As String
        Return $"{mBreed}: {mName} ({mAge}歳)"
    End Function

End Class


' 問題 7-5 〜 7-6: CoinCase クラス
Public Class CoinCase

    ' 対応する硬貨の種類: 500, 100, 50, 10, 5, 1
    Private mCounts As New Dictionary(Of Integer, Integer)

    ' コンストラクタ: 6 種類の硬貨を 0 枚で初期化済み（変更しない）
    Public Sub New()
        For Each denomination In {500, 100, 50, 10, 5, 1}
            mCounts(denomination) = 0
        Next
    End Sub

    ' 問題 7-5: 指定した種類の硬貨を枚数分追加する（無効な種類は無視）
    Public Sub AddCoins(denomination As Integer, count As Integer)
        If mCounts.ContainsKey(denomination) Then
            mCounts(denomination) += count
        End If
    End Sub

    ' 問題 7-5: 指定した種類の硬貨の枚数を返す
    Public Overloads Function GetCount(denomination As Integer) As Integer
        Return mCounts(denomination)
    End Function

    ' 問題 7-5: 全硬貨の合計金額を返す
    Public Overloads Function GetAmount() As Integer
        Dim amount As Integer
        For Each pair In mCounts
            amount += pair.Key * pair.Value
        Next
        Return amount
    End Function

    ' 問題 7-6: 全硬貨の合計枚数を返す
    Public Overloads Function GetCount() As Integer
        Dim total As Integer
        For Each pair In mCounts
            total += pair.Value
        Next
        Return total
    End Function

    ' 問題 7-6: 指定した種類の硬貨の合計金額を返す
    Public Overloads Function GetAmount(denomination As Integer) As Integer
        Return mCounts(denomination) * denomination
    End Function

End Class


Public Class Exercises

    ' 問題 7-1: Dog をインスタンス化し、Name に name をセットして返す
    Public Shared Function Problem7_1(name As String) As String
        Throw New NotImplementedException("問題 7-1 を実装してください")
    End Function

    ' 問題 7-2: Dog に name と age をセットし、"{Name},{Age}" を返す
    Public Shared Function Problem7_2(name As String, age As Integer) As String
        Throw New NotImplementedException("問題 7-2 を実装してください")
    End Function

    ' 問題 7-3: dog1.Name="ポチ"→"タロ"、dog2.Name="コロ" のまま → "タロ,コロ" を返す
    Public Shared Function Problem7_3() As String
        Throw New NotImplementedException("問題 7-3 を実装してください")
    End Function

    ' 問題 7-4: New Dog(breed) を生成し name/age をセットして ShowProfile() を返す
    Public Shared Function Problem7_4(breed As String, name As String, age As Integer) As String
        Throw New NotImplementedException("問題 7-4 を実装してください")
    End Function

    ' 問題 7-5: CoinCase に denomination を count 枚追加し、合計金額を返す
    Public Shared Function Problem7_5(denomination As Integer, count As Integer) As Integer
        Throw New NotImplementedException("問題 7-5 を実装してください")
    End Function

    ' 問題 7-6: CoinCase に denomination を count 枚追加し、"{合計枚数},{指定種の合計金額}" を返す
    Public Shared Function Problem7_6(denomination As Integer, count As Integer) As String
        Throw New NotImplementedException("問題 7-6 を実装してください")
    End Function

End Class
