Public Class Main
    Public Tree As Tree
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
        For Each t As Node In c.Nodes
            Dim n As New TreeNode(t.title.Value & " (" & t.name.Value & ")")
            n.Tag = t
            TreeView1.Nodes.Add(n)
        Next
        Tree = c
    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        Try
            ListBox1.Items.Clear()
            TextBox1.Text = CType(e.Node.Tag, Node).name.Value
            TextBox2.Text = CType(e.Node.Tag, Node).techID.Value
            TextBox3.Text = CType(e.Node.Tag, Node).pos.Value
            TextBox4.Text = CType(e.Node.Tag, Node).icon.Value
            TextBox5.Text = CType(e.Node.Tag, Node).cost.Value
            TextBox10.Text = CType(e.Node.Tag, Node).title.Value
            TextBox6.Text = CType(e.Node.Tag, Node).description.Value
            TextBox7.Text = CType(e.Node.Tag, Node).anyParent.Value
            TextBox8.Text = CType(e.Node.Tag, Node).hideIfEmpty.Value
            TextBox9.Text = CType(e.Node.Tag, Node).parents.Value
            For Each p As SString In CType(e.Node.Tag, Node).PARTS
                ListBox1.Items.Add(p.Value)
            Next
        Catch ex As Exception

        End Try
    End Sub
End Class
