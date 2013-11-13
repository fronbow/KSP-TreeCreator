<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NodeExists
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Overwrite = New System.Windows.Forms.Button()
        Me.KeepCurrent = New System.Windows.Forms.Button()
        Me.MergePartsIntoOld = New System.Windows.Forms.Button()
        Me.MergePartsIntoNew = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.Overwrite, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.KeepCurrent, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.MergePartsIntoOld, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.MergePartsIntoNew, 3, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(15, 30)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(498, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Overwrite
        '
        Me.Overwrite.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Overwrite.Location = New System.Drawing.Point(3, 3)
        Me.Overwrite.Name = "Overwrite"
        Me.Overwrite.Size = New System.Drawing.Size(67, 23)
        Me.Overwrite.TabIndex = 0
        Me.Overwrite.Text = "Overwrite"
        '
        'KeepCurrent
        '
        Me.KeepCurrent.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.KeepCurrent.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.KeepCurrent.Location = New System.Drawing.Point(76, 3)
        Me.KeepCurrent.Name = "KeepCurrent"
        Me.KeepCurrent.Size = New System.Drawing.Size(81, 23)
        Me.KeepCurrent.TabIndex = 1
        Me.KeepCurrent.Text = "Keep Current"
        '
        'MergePartsIntoOld
        '
        Me.MergePartsIntoOld.Location = New System.Drawing.Point(163, 3)
        Me.MergePartsIntoOld.Name = "MergePartsIntoOld"
        Me.MergePartsIntoOld.Size = New System.Drawing.Size(135, 23)
        Me.MergePartsIntoOld.TabIndex = 2
        Me.MergePartsIntoOld.Text = "Merge parts into old node"
        Me.MergePartsIntoOld.UseVisualStyleBackColor = True
        '
        'MergePartsIntoNew
        '
        Me.MergePartsIntoNew.Location = New System.Drawing.Point(304, 3)
        Me.MergePartsIntoNew.Name = "MergePartsIntoNew"
        Me.MergePartsIntoNew.Size = New System.Drawing.Size(142, 23)
        Me.MergePartsIntoNew.TabIndex = 3
        Me.MergePartsIntoNew.Text = "Merge parts into new node"
        Me.MergePartsIntoNew.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Node [node] already exists. What do?"
        '
        'NodeExists
        '
        Me.AcceptButton = Me.Overwrite
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.KeepCurrent
        Me.ClientSize = New System.Drawing.Size(525, 71)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NodeExists"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Node Exists"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Overwrite As System.Windows.Forms.Button
    Friend WithEvents KeepCurrent As System.Windows.Forms.Button
    Friend WithEvents MergePartsIntoOld As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MergePartsIntoNew As System.Windows.Forms.Button

End Class
