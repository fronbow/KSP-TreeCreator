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
    Public Shared Operator &(ByVal Param1 As String, ByVal Param2 As SString)
        Return Param1 & CStr(Param2)
    End Operator
    Public Shared Operator &(ByVal Param1 As SString, ByVal Param2 As String)
        Return CStr(Param1) & Param2
    End Operator
    Public Shared Operator =(ByVal Param1 As SString, ByVal Param2 As SString)
        Return (Param1.Item = Param2.item) And (Param1.Value = Param2.value)
    End Operator
    Public Shared Operator <>(ByVal Param1 As SString, ByVal Param2 As SString)
        Return Not ((Param1.Item = Param2.Item) And (Param1.Value = Param2.Value))
    End Operator
End Class