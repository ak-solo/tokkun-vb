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
        Throw New NotImplementedException("問題 7-4 の New(breed) を実装してください")
    End Sub

    ' 問題 7-1: 名前プロパティ
    Public Property Name() As String
        Get
            Throw New NotImplementedException("問題 7-1 の Name.Get を実装してください")
        End Get
        Set(value As String)
            Throw New NotImplementedException("問題 7-1 の Name.Set を実装してください")
        End Set
    End Property

    ' 問題 7-2: 年齢プロパティ
    Public Property Age() As Integer
        Get
            Throw New NotImplementedException("問題 7-2 の Age.Get を実装してください")
        End Get
        Set(value As Integer)
            Throw New NotImplementedException("問題 7-2 の Age.Set を実装してください")
        End Set
    End Property

    ' 問題 7-4: 犬種プロパティ（読み取り専用）
    Public ReadOnly Property Breed() As String
        Get
            Throw New NotImplementedException("問題 7-4 の Breed.Get を実装してください")
        End Get
    End Property

    ' 問題 7-4: "犬種: 名前 (年齢歳)" の形式で返す
    Public Function ShowProfile() As String
        Throw New NotImplementedException("問題 7-4 の ShowProfile を実装してください")
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
        Throw New NotImplementedException("問題 7-5 の AddCoins を実装してください")
    End Sub

    ' 問題 7-5: 指定した種類の硬貨の枚数を返す
    Public Overloads Function GetCount(denomination As Integer) As Integer
        Throw New NotImplementedException("問題 7-5 の GetCount(denomination) を実装してください")
    End Function

    ' 問題 7-5: 全硬貨の合計金額を返す
    Public Overloads Function GetAmount() As Integer
        Throw New NotImplementedException("問題 7-5 の GetAmount() を実装してください")
    End Function

    ' 問題 7-6: 全硬貨の合計枚数を返す
    Public Overloads Function GetCount() As Integer
        Throw New NotImplementedException("問題 7-6 の GetCount() を実装してください")
    End Function

    ' 問題 7-6: 指定した種類の硬貨の合計金額を返す
    Public Overloads Function GetAmount(denomination As Integer) As Integer
        Throw New NotImplementedException("問題 7-6 の GetAmount(denomination) を実装してください")
    End Function

End Class
