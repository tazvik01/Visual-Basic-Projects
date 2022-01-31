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
        Me.lblAdditionproperties = New System.Windows.Forms.Label()
        Me.btnAssociative = New System.Windows.Forms.Button()
        Me.btnCommutative = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblAdditionproperties
        '
        Me.lblAdditionproperties.Location = New System.Drawing.Point(88, 102)
        Me.lblAdditionproperties.Name = "lblAdditionproperties"
        Me.lblAdditionproperties.Size = New System.Drawing.Size(87, 29)
        Me.lblAdditionproperties.TabIndex = 0
        Me.lblAdditionproperties.Text = "(a+b)+c=a+(b+c)"
        '
        'btnAssociative
        '
        Me.btnAssociative.Location = New System.Drawing.Point(18, 209)
        Me.btnAssociative.Name = "btnAssociative"
        Me.btnAssociative.Size = New System.Drawing.Size(103, 30)
        Me.btnAssociative.TabIndex = 1
        Me.btnAssociative.Text = "Associative"
        Me.btnAssociative.UseVisualStyleBackColor = True
        '
        'btnCommutative
        '
        Me.btnCommutative.Location = New System.Drawing.Point(161, 210)
        Me.btnCommutative.Name = "btnCommutative"
        Me.btnCommutative.Size = New System.Drawing.Size(98, 28)
        Me.btnCommutative.TabIndex = 2
        Me.btnCommutative.Text = "Commutative"
        Me.btnCommutative.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProgramToolStripMenuItem
        '
        Me.ProgramToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.ProgramToolStripMenuItem.Name = "ProgramToolStripMenuItem"
        Me.ProgramToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ProgramToolStripMenuItem.Text = "Program"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnCommutative)
        Me.Controls.Add(Me.btnAssociative)
        Me.Controls.Add(Me.lblAdditionproperties)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Addition Properties"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAdditionproperties As System.Windows.Forms.Label
    Friend WithEvents btnAssociative As System.Windows.Forms.Button
    Friend WithEvents btnCommutative As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ProgramToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
