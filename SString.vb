Public Class SString
    Public Property Item As String
    Public Property Value As Object
    Public Shared Widening Operator CType(ByVal value As SString) As String
        Return value.Item & " = " & value.Value.ToString()
    End Operator
    Public Shared Narrowing Operator CType(ByVal value As String) As SString
        Dim s As New SString
        s.Item = value.Trim.Remove(value.LastIndexOf(Char.Parse("=")) - 1).Trim()
        s.Value = value.Trim.Remove(0, value.LastIndexOf(Char.Parse("=")) + 1).Trim()
        Return s
    End Operator
End Class