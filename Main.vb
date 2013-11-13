Public Class Main
    Public Tree As New Tree
    Public clicked As Boolean = False
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim open As New OpenFileDialog
        open.Filter = "Configuration Files (*.cfg)|*.cfg|All Files (*.*)|*.*"
        open.FileName = ""
        If open.ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
        Dim s As String
        Using r As New IO.StreamReader(open.FileName)
            s = r.ReadToEnd
        End Using
        Dim c As New Tree
        c.Load(s)
        Tree = c
        TreeView1.Nodes.Clear()
        TParts.Items.Clear()
        TName.Text = ""
        TTechID.Text = ""
        TPosition.Text = ""
        TIcon.Text = ""
        TCost.Text = ""
        TTitle.Text = ""
        TDescription.Text = ""
        TAnyParent.Text = ""
        THideIfEmpty.Text = ""
        TParents.Text = ""
        ResetTree()
    End Sub

    Public Sub ResetTree()
        TreeView1.Nodes.Clear()
        For Each t As Node In Tree.Nodes
            Dim n As New TreeNode(t.title.Value & " (" & t.name.Value & ")")
            n.Tag = Tree.Nodes.IndexOf(t)
            TreeView1.Nodes.Add(n)
        Next
    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        Try
            TParts.Items.Clear()
            TName.Text = Tree.Nodes(e.Node.Tag).name.Value
            TTechID.Text = Tree.Nodes(e.Node.Tag).techID.Value
            TPosition.Text = Tree.Nodes(e.Node.Tag).pos.Value
            TIcon.Text = Tree.Nodes(e.Node.Tag).icon.Value
            TCost.Text = Tree.Nodes(e.Node.Tag).cost.Value
            TTitle.Text = Tree.Nodes(e.Node.Tag).title.Value
            TDescription.Text = Tree.Nodes(e.Node.Tag).description.Value
            TAnyParent.Text = Tree.Nodes(e.Node.Tag).anyParent.Value
            THideIfEmpty.Text = Tree.Nodes(e.Node.Tag).hideIfEmpty.Value
            TParents.Text = Tree.Nodes(e.Node.Tag).parents.Value
            For Each p As SString In Tree.Nodes(e.Node.Tag).PARTS
                TParts.Items.Add(p.Value)
            Next
        Catch ex As Exception
            MsgBox("Error occured during load: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub TName_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TName.KeyPress
        Try
            If Object.Equals(TreeView1.SelectedNode, Nothing) = False Then LastIndex = TreeView1.SelectedNode.Index
            If Object.Equals(TreeView1.SelectedNode, Nothing) = False Then LastTag = TreeView1.SelectedNode.Tag
            Select Case e.KeyChar
                Case vbBack
                    Tree.Nodes(LastTag).name.Value = TName.Text.Remove(TName.Text.Length - 1)
                Case Else
                    Tree.Nodes(LastTag).name.Value = TName.Text & e.KeyChar
            End Select
            TreeView1.Nodes(LastIndex).Text = Tree.Nodes(LastTag).title.Value & " (" & Tree.Nodes(LastTag).name.Value & ")"
        Catch
        End Try
    End Sub

    Private Sub TTechID_TextChanged(sender As Object, e As EventArgs) Handles TTechID.TextChanged
        Try
            Tree.Nodes(TreeView1.SelectedNode.Tag).techID.Value = TTechID.Text
        Catch
        End Try
    End Sub

    Private Sub TPosition_TextChanged(sender As Object, e As EventArgs) Handles TPosition.TextChanged
        Try
            Tree.Nodes(TreeView1.SelectedNode.Tag).pos.Value = TPosition.Text
        Catch
        End Try
    End Sub

    Private Sub TIcon_TextChanged(sender As Object, e As EventArgs) Handles TIcon.TextChanged
        Try
            Tree.Nodes(TreeView1.SelectedNode.Tag).icon.Value = TIcon.Text
        Catch
        End Try
    End Sub

    Private Sub TCost_TextChanged(sender As Object, e As EventArgs) Handles TCost.TextChanged
        Try
            Tree.Nodes(TreeView1.SelectedNode.Tag).cost.Value = TCost.Text
        Catch
        End Try
    End Sub
    Private LastIndex As Integer
    Private LastTag As Object = Nothing
    Private Sub TTitle_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TTitle.KeyPress
        Try
            If Object.Equals(TreeView1.SelectedNode, Nothing) = False Then LastIndex = TreeView1.SelectedNode.Index
            If Object.Equals(TreeView1.SelectedNode, Nothing) = False Then LastTag = TreeView1.SelectedNode.Tag
            Select Case e.KeyChar
                Case vbBack
                    Tree.Nodes(LastTag).title.Value = TTitle.Text.Remove(TTitle.Text.Length - 1)
                Case Else
                    Tree.Nodes(LastTag).title.Value = TTitle.Text & e.KeyChar
            End Select
            TreeView1.Nodes(LastIndex).Text = Tree.Nodes(LastTag).title.Value & " (" & Tree.Nodes(LastTag).name.Value & ")"
        Catch
        End Try
    End Sub

    Private Sub TDescription_TextChanged(sender As Object, e As EventArgs) Handles TDescription.TextChanged
        Try
            Tree.Nodes(TreeView1.SelectedNode.Tag).description.Value = TDescription.Text
        Catch
        End Try
    End Sub

    Private Sub TAnyParent_TextChanged(sender As Object, e As EventArgs) Handles TAnyParent.TextChanged
        Try
            Tree.Nodes(TreeView1.SelectedNode.Tag).anyParent.Value = TAnyParent.Text
        Catch
        End Try
    End Sub

    Private Sub THideIfEmpty_TextChanged(sender As Object, e As EventArgs) Handles THideIfEmpty.TextChanged
        Try
            Tree.Nodes(TreeView1.SelectedNode.Tag).hideIfEmpty.Value = THideIfEmpty.Text
        Catch
        End Try
    End Sub

    Private Sub TParents_TextChanged(sender As Object, e As EventArgs) Handles TParents.TextChanged
        Try
            Tree.Nodes(TreeView1.SelectedNode.Tag).parents.Value = TParents.Text
        Catch
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim s As String = InputBox("Raw part name to add as a part for this node", "Add Part")
            TParts.Items.Add(s)
            Tree.Nodes(TreeView1.SelectedNode.Tag).PARTS.Add(New SString With {
                                                             .Item = "name",
                                                             .Value = s})
        Catch
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Tree.Nodes(TreeView1.SelectedNode.Tag).PARTS.Remove(New SString With {
                                                         .Item = "name",
                                                         .Value = TParts.SelectedItem})
            TParts.Items.RemoveAt(TParts.SelectedIndex)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Tree.Nodes.Add(New Node With {
                       .title = "title = New Node",
                       .name = "name = New Node"})
        TreeView1.Nodes.Clear()
        For Each t As Node In Tree.Nodes
            Dim n As New TreeNode(t.title.Value & " (" & t.name.Value & ")")
            n.Tag = Tree.Nodes.IndexOf(t)
            TreeView1.Nodes.Add(n)
        Next
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Tree.Nodes.RemoveAt(TreeView1.SelectedNode.Tag)
        TreeView1.Nodes.Clear()
        For Each t As Node In Tree.Nodes
            Dim n As New TreeNode(t.title.Value & " (" & t.name.Value & ")")
            n.Tag = Tree.Nodes.IndexOf(t)
            TreeView1.Nodes.Add(n)
        Next
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Dim save As New SaveFileDialog
        save.Filter = "Configuration Files (*.cfg)|*.cfg|All Files (*.*)|*.*"
        save.FileName = ""
        If save.ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
        Using r As New IO.StreamWriter(save.FileName)
            For Each n As Node In Tree.Nodes
                r.WriteLine("NODE")
                r.WriteLine("{")
                r.WriteLine(vbTab & n.name)
                r.WriteLine(vbTab & n.techID)
                r.WriteLine(vbTab & n.pos)
                r.WriteLine(vbTab & n.icon)
                r.WriteLine(vbTab & n.cost)
                r.WriteLine(vbTab & n.title)
                r.WriteLine(vbTab & n.description)
                r.WriteLine(vbTab & n.anyParent)
                r.WriteLine(vbTab & n.hideIfEmpty)
                r.WriteLine(vbTab & n.parents)
                r.WriteLine(vbTab & "PARTS")
                r.WriteLine(vbTab & "{")
                For Each p As SString In n.PARTS
                    r.WriteLine(vbTab & vbTab & p)
                Next
                r.WriteLine(vbTab & "}")
                r.WriteLine("}")
            Next
        End Using
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        Tree = New Tree
        TreeView1.Nodes.Clear()
        TParts.Items.Clear()
        TName.Text = ""
        TTechID.Text = ""
        TPosition.Text = ""
        TIcon.Text = ""
        TCost.Text = ""
        TTitle.Text = ""
        TDescription.Text = ""
        TAnyParent.Text = ""
        THideIfEmpty.Text = ""
        TParents.Text = ""
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        Dim prev As New Preview
        prev.Show()
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        Dim open As New OpenFileDialog
        open.Filter = "Configuration Files (*.cfg)|*.cfg|All Files (*.*)|*.*"
        open.FileName = ""
        If open.ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
        Dim s As String
        Using r As New IO.StreamReader(open.FileName)
            s = r.ReadToEnd
        End Using
        Dim c As New Tree
        c.Load(s)
        For Each n As Node In c.Nodes
            Dim b As Boolean = False
            For Each nn As Node In Tree.Nodes
                If nn.name = n.name AndAlso nn.pos = n.pos AndAlso nn.techID = n.techID Then
                    Dim o As New NodeExists
                    o.NodeName = n.name.Value
                    o.ShowDialog(Me)
                    b = True
                    Select Case o.ExistingResult
                        Case NodeExists.Result.Overwrite
                            Tree.Nodes(Tree.Nodes.IndexOf(nn)) = n
                        Case NodeExists.Result.KeepExisting
                            Exit For
                        Case NodeExists.Result.MergeIntoOld
                            For Each p As SString In n.PARTS
                                Dim bb As Boolean = True
                                For Each pp As SString In nn.PARTS
                                    If p.Value = pp.Value Then
                                        bb = False : Exit For
                                    End If
                                Next
                                ''''If Tree.Nodes(Tree.Nodes.IndexOf(nn)).PARTS.Contains(p) = False Then
                                ''''Tree.Nodes(Tree.Nodes.IndexOf(nn)).PARTS.Add(p)
                                '''' End If
                                If bb = True Then Tree.Nodes(Tree.Nodes.IndexOf(nn)).PARTS.Add(p)
                                'If Tree.Nodes(Tree.Nodes.IndexOf(nn)).PARTS.IndexOf(p) = -1 Then
                                'Tree.Nodes(Tree.Nodes.IndexOf(nn)).PARTS.Add(p)
                                'End If
                            Next
                        Case NodeExists.Result.MergeIntoNew
                            For Each p As SString In nn.PARTS
                                Dim bb As Boolean = True
                                For Each pp As SString In n.PARTS
                                    If p.Value = pp.Value Then
                                        bb = False : Exit For
                                    End If
                                Next
                                If bb = True Then c.Nodes(c.Nodes.IndexOf(nn)).PARTS.Add(p)
                            Next
                            Tree.Nodes(Tree.Nodes.IndexOf(nn)) = c.Nodes(c.Nodes.IndexOf(nn))
                    End Select
                End If
            Next
            If b = False Then Tree.Nodes.Add(n)
        Next
        ResetTree()
    End Sub
End Class
