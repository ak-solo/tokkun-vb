' ベースクラス（変更しない）
Public Class Animal

    Public Sub New(name As String, age As Integer)
        Me.Name = name
        Me.Age = age
    End Sub

    Public Property Name As String
    Public Property Age As Integer

    Public Function ShowProfile() As String
        Return $"{Name},{Age}歳"
    End Function

    Public Overridable Function Speak() As String
        Return "......"
    End Function

End Class


' 問題 8-1 / 8-3: Animal を継承した Cat クラス
Public Class Cat
    Inherits Animal

    ' 問題 8-1: MyBase.New(name, age) を呼ぶコンストラクタ
    Public Sub New(name As String, age As Integer)
        MyBase.New(name, age)
    End Sub

    ' 問題 8-1: "スースー" を返す
    Public Function Sleep() As String
        Throw New NotImplementedException("問題 8-1 の Sleep を実装してください")
    End Function

    ' 問題 8-3: "ニャー" を返す（Animal.Speak のオーバーライド）
    Public Overrides Function Speak() As String
        Throw New NotImplementedException("問題 8-3 の Cat.Speak を実装してください")
    End Function

End Class


' 問題 8-2 / 8-4: Animal を継承した Dog クラス
Public Class Dog
    Inherits Animal

    ' 問題 8-2: MyBase.New(name, age) を呼ぶコンストラクタ
    Public Sub New(name As String, age As Integer)
        MyBase.New(name, age)
    End Sub

    ' 問題 8-2: "トコトコ" を返す
    Public Function Run() As String
        Throw New NotImplementedException("問題 8-2 の Run を実装してください")
    End Function

    ' 問題 8-4: "ワンワン" を返す（Animal.Speak のオーバーライド）
    Public Overrides Function Speak() As String
        Throw New NotImplementedException("問題 8-4 の Dog.Speak を実装してください")
    End Function

End Class
