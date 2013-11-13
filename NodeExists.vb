Imports System.Windows.Forms

Public Class NodeExists
    Public Enum Result
        Overwrite
        KeepExisting
        MergeIntoOld
        MergeIntoNew
    End Enum
    Public Property [NodeName] As String
    Public Property [ExistingResult] As Result
    Private Sub Overwrite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Overwrite.Click
        ExistingResult = Result.Overwrite
        Me.Close()
    End Sub

    Private Sub KeepCurrent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeepCurrent.Click
        ExistingResult = Result.KeepExisting
        Me.Close()
    End Sub

    Private Sub MergePartsIntoOld_Click(sender As Object, e As EventArgs) Handles MergePartsIntoOld.Click
        ExistingResult = Result.MergeIntoOld
        Me.Close()
    End Sub

    Private Sub MergePartsIntoNew_Click(sender As Object, e As EventArgs) Handles MergePartsIntoNew.Click
        ExistingResult = Result.MergeIntoNew
        Me.Close()
    End Sub

    Private Sub NodeExists_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Node " & NodeName & " already exists. What do?"
    End Sub
End Class
