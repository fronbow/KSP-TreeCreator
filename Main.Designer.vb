<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TTitle = New System.Windows.Forms.TextBox()
        Me.TParents = New System.Windows.Forms.TextBox()
        Me.THideIfEmpty = New System.Windows.Forms.TextBox()
        Me.TAnyParent = New System.Windows.Forms.TextBox()
        Me.TDescription = New System.Windows.Forms.TextBox()
        Me.TCost = New System.Windows.Forms.TextBox()
        Me.TIcon = New System.Windows.Forms.TextBox()
        Me.TPosition = New System.Windows.Forms.TextBox()
        Me.TTechID = New System.Windows.Forms.TextBox()
        Me.TName = New System.Windows.Forms.TextBox()
        Me.TParts = New System.Windows.Forms.ListBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton5, Me.ToolStripButton1, Me.ToolStripButton4, Me.ToolStripButton6})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(475, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton5.Text = "ToolStripButton5"
        Me.ToolStripButton5.ToolTipText = "Create new Tree.cfg"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        Me.ToolStripButton1.ToolTipText = "Open Tree.cfg"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "Save tree.cfg"
        Me.ToolStripButton4.ToolTipText = "Save Tree.cfg"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton6.Text = "ToolStripButton6"
        Me.ToolStripButton6.ToolTipText = "Preview"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 25)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TreeView1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ToolStrip2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(475, 388)
        Me.SplitContainer1.SplitterDistance = 221
        Me.SplitContainer1.TabIndex = 1
        '
        'TreeView1
        '
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.Location = New System.Drawing.Point(0, 25)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(221, 363)
        Me.TreeView1.TabIndex = 0
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton2, Me.ToolStripButton3})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(221, 25)
        Me.ToolStrip2.TabIndex = 1
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        Me.ToolStripButton2.ToolTipText = "Add Node"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "ToolStripButton3"
        Me.ToolStripButton3.ToolTipText = "Remove Node"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.TTitle)
        Me.Panel1.Controls.Add(Me.TParents)
        Me.Panel1.Controls.Add(Me.THideIfEmpty)
        Me.Panel1.Controls.Add(Me.TAnyParent)
        Me.Panel1.Controls.Add(Me.TDescription)
        Me.Panel1.Controls.Add(Me.TCost)
        Me.Panel1.Controls.Add(Me.TIcon)
        Me.Panel1.Controls.Add(Me.TPosition)
        Me.Panel1.Controls.Add(Me.TTechID)
        Me.Panel1.Controls.Add(Me.TName)
        Me.Panel1.Controls.Add(Me.TParts)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(250, 388)
        Me.Panel1.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(124, 285)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(115, 23)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "Remove Part"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(7, 285)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 23)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Add Part"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(4, 140)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Title:"
        '
        'TTitle
        '
        Me.TTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TTitle.Location = New System.Drawing.Point(40, 137)
        Me.TTitle.Name = "TTitle"
        Me.TTitle.Size = New System.Drawing.Size(203, 20)
        Me.TTitle.TabIndex = 20
        '
        'TParents
        '
        Me.TParents.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TParents.Location = New System.Drawing.Point(57, 241)
        Me.TParents.Name = "TParents"
        Me.TParents.Size = New System.Drawing.Size(186, 20)
        Me.TParents.TabIndex = 19
        '
        'THideIfEmpty
        '
        Me.THideIfEmpty.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.THideIfEmpty.Location = New System.Drawing.Point(82, 215)
        Me.THideIfEmpty.Name = "THideIfEmpty"
        Me.THideIfEmpty.Size = New System.Drawing.Size(161, 20)
        Me.THideIfEmpty.TabIndex = 18
        '
        'TAnyParent
        '
        Me.TAnyParent.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TAnyParent.Location = New System.Drawing.Point(72, 189)
        Me.TAnyParent.Name = "TAnyParent"
        Me.TAnyParent.Size = New System.Drawing.Size(171, 20)
        Me.TAnyParent.TabIndex = 17
        '
        'TDescription
        '
        Me.TDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TDescription.Location = New System.Drawing.Point(73, 163)
        Me.TDescription.Name = "TDescription"
        Me.TDescription.Size = New System.Drawing.Size(170, 20)
        Me.TDescription.TabIndex = 16
        '
        'TCost
        '
        Me.TCost.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TCost.Location = New System.Drawing.Point(40, 111)
        Me.TCost.Name = "TCost"
        Me.TCost.Size = New System.Drawing.Size(203, 20)
        Me.TCost.TabIndex = 15
        '
        'TIcon
        '
        Me.TIcon.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TIcon.Location = New System.Drawing.Point(40, 85)
        Me.TIcon.Name = "TIcon"
        Me.TIcon.Size = New System.Drawing.Size(203, 20)
        Me.TIcon.TabIndex = 14
        '
        'TPosition
        '
        Me.TPosition.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TPosition.Location = New System.Drawing.Point(56, 59)
        Me.TPosition.Name = "TPosition"
        Me.TPosition.Size = New System.Drawing.Size(187, 20)
        Me.TPosition.TabIndex = 13
        '
        'TTechID
        '
        Me.TTechID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TTechID.Location = New System.Drawing.Point(56, 33)
        Me.TTechID.Name = "TTechID"
        Me.TTechID.Size = New System.Drawing.Size(187, 20)
        Me.TTechID.TabIndex = 12
        '
        'TName
        '
        Me.TName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TName.Location = New System.Drawing.Point(47, 7)
        Me.TName.Name = "TName"
        Me.TName.Size = New System.Drawing.Size(196, 20)
        Me.TName.TabIndex = 11
        '
        'TParts
        '
        Me.TParts.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TParts.FormattingEnabled = True
        Me.TParts.Location = New System.Drawing.Point(6, 312)
        Me.TParts.Name = "TParts"
        Me.TParts.Size = New System.Drawing.Size(241, 69)
        Me.TParts.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 270)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Parts:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(4, 244)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Parents:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(4, 218)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Hide if Empty:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(4, 192)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Any Parent:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 166)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Description:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Cost:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Icon:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Position:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tech ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 413)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main"
        Me.Text = "KSP TreeCreator"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TParents As System.Windows.Forms.TextBox
    Friend WithEvents THideIfEmpty As System.Windows.Forms.TextBox
    Friend WithEvents TAnyParent As System.Windows.Forms.TextBox
    Friend WithEvents TDescription As System.Windows.Forms.TextBox
    Friend WithEvents TCost As System.Windows.Forms.TextBox
    Friend WithEvents TIcon As System.Windows.Forms.TextBox
    Friend WithEvents TPosition As System.Windows.Forms.TextBox
    Friend WithEvents TTechID As System.Windows.Forms.TextBox
    Friend WithEvents TName As System.Windows.Forms.TextBox
    Friend WithEvents TParts As System.Windows.Forms.ListBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TTitle As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton

End Class
