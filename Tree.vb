Public Class Tree
    Public Nodes As New List(Of Node)
    Public Sub Load(ByVal Cfg As String)
        Dim ch As Char = vbCr
        Dim n As Integer = 0
        Dim b As Boolean = False
        If Cfg.Contains(ch) = False Then ch = vbLf
        For Each str As String In Cfg.Split(ch)
            Select Case str.Trim
                Case "{"
                    n += 1
                    b = True
                Case "}"
                    n -= 1
            End Select

            Select Case n
                Case 1
                    If b = True Then Nodes.Add(New Node) : Nodes.Last.PARTS = New List(Of SString)
                    If str.Contains("="c) = False Then Exit Select
                    Dim ss As SString = str.Trim()
                    Select Case ss.Item
                        Case "name" : Nodes.Last.name = ss
                        Case "techID" : Nodes.Last.techID = ss
                        Case "pos" : Nodes.Last.pos = ss
                        Case "icon" : Nodes.Last.icon = ss
                        Case "cost" : Nodes.Last.cost = ss
                        Case "title" : Nodes.Last.title = ss
                        Case "description" : Nodes.Last.description = ss
                        Case "anyParent" : Nodes.Last.anyParent = ss
                        Case "hideIfEmpty" : Nodes.Last.hideIfEmpty = ss
                        Case "parents" : Nodes.Last.parents = ss
                    End Select
                Case 2
                    If str.Contains("="c) = False Then Exit Select
                    Nodes.Last.PARTS.Add(str.Trim())
            End Select
            b = False
        Next
    End Sub
End Class
Public Class Node
    Public Property name As SString
    Public Property techID As SString
    Public Property pos As SString
    Public Property icon As SString
    Public Property cost As SString
    Public Property title As SString
    Public Property description As SString
    Public Property anyParent As SString
    Public Property hideIfEmpty As SString
    Public Property parents As SString
    Public Property PARTS As List(Of SString)
End Class
