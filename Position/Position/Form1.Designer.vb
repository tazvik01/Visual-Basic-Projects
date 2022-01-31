<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuProgram = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.mnuPosition = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTopleft = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTopcenter = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTopright = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMiddleleft = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMiddlecenter = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMiddleright = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBottomleft = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBottomcenter = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBottomright = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuProgram, Me.mnuPosition})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 24)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuProgram
        '
        Me.mnuProgram.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuExit})
        Me.mnuProgram.Name = "mnuProgram"
        Me.mnuProgram.Size = New System.Drawing.Size(65, 20)
        Me.mnuProgram.Text = "Program"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(152, 22)
        Me.mnuExit.Text = "Exit"
        '
        'lblPosition
        '
        Me.lblPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPosition.Location = New System.Drawing.Point(19, 58)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(119, 45)
        Me.lblPosition.TabIndex = 1
        Me.lblPosition.Text = "Here"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip2.TabIndex = 2
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'mnuPosition
        '
        Me.mnuPosition.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTopleft, Me.mnuTopcenter, Me.mnuTopright, Me.mnuMiddleleft, Me.mnuMiddlecenter, Me.mnuMiddleright, Me.mnuBottomleft, Me.mnuBottomcenter, Me.mnuBottomright})
        Me.mnuPosition.Name = "mnuPosition"
        Me.mnuPosition.Size = New System.Drawing.Size(62, 20)
        Me.mnuPosition.Text = "Position"
        '
        'mnuTopleft
        '
        Me.mnuTopleft.Name = "mnuTopleft"
        Me.mnuTopleft.Size = New System.Drawing.Size(152, 22)
        Me.mnuTopleft.Text = "TopLeft"
        '
        'mnuTopcenter
        '
        Me.mnuTopcenter.Name = "mnuTopcenter"
        Me.mnuTopcenter.Size = New System.Drawing.Size(152, 22)
        Me.mnuTopcenter.Text = "TopCenter"
        '
        'mnuTopright
        '
        Me.mnuTopright.Name = "mnuTopright"
        Me.mnuTopright.Size = New System.Drawing.Size(152, 22)
        Me.mnuTopright.Text = "TopRight"
        '
        'mnuMiddleleft
        '
        Me.mnuMiddleleft.Name = "mnuMiddleleft"
        Me.mnuMiddleleft.Size = New System.Drawing.Size(152, 22)
        Me.mnuMiddleleft.Text = "MiddleLeft"
        '
        'mnuMiddlecenter
        '
        Me.mnuMiddlecenter.Name = "mnuMiddlecenter"
        Me.mnuMiddlecenter.Size = New System.Drawing.Size(152, 22)
        Me.mnuMiddlecenter.Text = "MiddleCenter"
        '
        'mnuMiddleright
        '
        Me.mnuMiddleright.Name = "mnuMiddleright"
        Me.mnuMiddleright.Size = New System.Drawing.Size(152, 22)
        Me.mnuMiddleright.Text = "MiddleRight"
        '
        'mnuBottomleft
        '
        Me.mnuBottomleft.Name = "mnuBottomleft"
        Me.mnuBottomleft.Size = New System.Drawing.Size(152, 22)
        Me.mnuBottomleft.Text = "BottomLeft"
        '
        'mnuBottomcenter
        '
        Me.mnuBottomcenter.Name = "mnuBottomcenter"
        Me.mnuBottomcenter.Size = New System.Drawing.Size(152, 22)
        Me.mnuBottomcenter.Text = "BottomCenter"
        '
        'mnuBottomright
        '
        Me.mnuBottomright.Name = "mnuBottomright"
        Me.mnuBottomright.Size = New System.Drawing.Size(152, 22)
        Me.mnuBottomright.Text = "BottomRight"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblPosition)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Position"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuProgram As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPosition As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTopleft As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTopcenter As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTopright As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblPosition As System.Windows.Forms.Label
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuMiddleleft As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMiddlecenter As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMiddleright As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBottomleft As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBottomcenter As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBottomright As System.Windows.Forms.ToolStripMenuItem

End Class
