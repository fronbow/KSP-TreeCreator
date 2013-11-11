Public Class Pos
    '-488,1175,-11
    Sub New(ByVal PosString As String)
        Dim s As String() = PosString.Split(","c)
        X = CSng(s(0))
        Y = CSng(s(1))
        Z = CSng(s(2))
    End Sub
    Public Property X As Single
    Public Property Y As Single
    Public Property Z As Single
End Class
