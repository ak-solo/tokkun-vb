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


Public Class Exercises

    ' 問題 8-1: Cat をインスタンス化し ShowProfile と Sleep の結果をカンマ区切りで返す
    Public Shared Function Problem8_1(name As String, age As Integer) As String
        Throw New NotImplementedException("問題 8-1 を実装してください")
    End Function

    ' 問題 8-2: Dog をインスタンス化し ShowProfile と Run の結果をカンマ区切りで返す
    Public Shared Function Problem8_2(name As String, age As Integer) As String
        Throw New NotImplementedException("問題 8-2 を実装してください")
    End Function

    ' 問題 8-3: Animal 型変数に Cat を代入して Speak を呼び出す
    Public Shared Function Problem8_3() As String
        Throw New NotImplementedException("問題 8-3 を実装してください")
    End Function

    ' 問題 8-4: Animal 型変数に Dog を代入して Speak を呼び出す
    Public Shared Function Problem8_4() As String
        Throw New NotImplementedException("問題 8-4 を実装してください")
    End Function

    ' 問題 8-5: Animal 配列に Cat と Dog を交互に格納しループで Speak をカンマ区切りで返す
    Public Shared Function Problem8_5() As String
        Throw New NotImplementedException("問題 8-5 を実装してください")
    End Function

End Class
