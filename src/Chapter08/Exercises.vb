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
        Return "スースー"
    End Function

    ' 問題 8-3: "ニャー" を返す（Animal.Speak のオーバーライド）
    Public Overrides Function Speak() As String
        Return "ニャー"
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
        Return "トコトコ"
    End Function

    ' 問題 8-4: "ワンワン" を返す（Animal.Speak のオーバーライド）
    Public Overrides Function Speak() As String
        Return "ワンワン"
    End Function

End Class


Public Class Exercises

    ' 問題 8-1: Cat をインスタンス化し ShowProfile と Sleep の結果をカンマ区切りで返す
    Public Shared Function Problem8_1(name As String, age As Integer) As String
        Dim cat As New Cat(name, age)
        Return $"{cat.ShowProfile()},{cat.Sleep()}"
    End Function

    ' 問題 8-2: Dog をインスタンス化し ShowProfile と Run の結果をカンマ区切りで返す
    Public Shared Function Problem8_2(name As String, age As Integer) As String
        Dim dog As New Dog(name, age)
        Return $"{dog.ShowProfile()},{dog.Run()}"
    End Function

    ' 問題 8-3: Animal 型変数に Cat を代入して Speak を呼び出す
    Public Shared Function Problem8_3() As String
        Dim animal As Animal = New Cat("タマ", 2)
        Return animal.Speak()
    End Function

    ' 問題 8-4: Animal 型変数に Dog を代入して Speak を呼び出す
    Public Shared Function Problem8_4() As String
        Dim animal As Animal = New Dog("ポチ", 3)
        Return animal.Speak()
    End Function

    ' 問題 8-5: Animal 配列に Cat と Dog を交互に格納しループで Speak をカンマ区切りで返す
    Public Shared Function Problem8_5() As String
        Dim animals() As Animal = {
            New Cat("タマ", 2),
            New Dog("ポチ", 3),
            New Cat("ミケ", 1),
            New Dog("ハチ", 1)
        }
        Dim speaks As New List(Of String)
        For Each animal In animals
            speaks.Add(animal.Speak())
        Next
        Return String.Join(",", speaks)
    End Function

End Class
