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
        Me.btnAnswer = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuProgram = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblPerimeter = New System.Windows.Forms.Label()
        Me.lblLength = New System.Windows.Forms.Label()
        Me.txtLength = New System.Windows.Forms.TextBox()
        Me.lblWidth = New System.Windows.Forms.Label()
        Me.txtWidth = New System.Windows.Forms.TextBox()
        Me.lblPerimeterAnswer = New System.Windows.Forms.Label()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.lblAreaAnswer = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAnswer
        '
        Me.btnAnswer.Location = New System.Drawing.Point(226, 109)
        Me.btnAnswer.Name = "btnAnswer"
        Me.btnAnswer.Size = New System.Drawing.Size(74, 20)
        Me.btnAnswer.TabIndex = 5
        Me.btnAnswer.Text = "Answer"
        Me.btnAnswer.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuProgram})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(335, 24)
        Me.MenuStrip1.TabIndex = 6
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
        Me.mnuExit.Size = New System.Drawing.Size(92, 22)
        Me.mnuExit.Text = "Exit"
        '
        'lblPerimeter
        '
        Me.lblPerimeter.Location = New System.Drawing.Point(12, 108)
        Me.lblPerimeter.Name = "lblPerimeter"
        Me.lblPerimeter.Size = New System.Drawing.Size(71, 21)
        Me.lblPerimeter.TabIndex = 3
        Me.lblPerimeter.Text = "Perimeter="
        '
        'lblLength
        '
        Me.lblLength.Location = New System.Drawing.Point(12, 34)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(96, 20)
        Me.lblLength.TabIndex = 7
        Me.lblLength.Text = "Enter Length:"
        '
        'txtLength
        '
        Me.txtLength.Location = New System.Drawing.Point(102, 34)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.Size = New System.Drawing.Size(32, 20)
        Me.txtLength.TabIndex = 8
        '
        'lblWidth
        '
        Me.lblWidth.Location = New System.Drawing.Point(176, 37)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.Size = New System.Drawing.Size(79, 20)
        Me.lblWidth.TabIndex = 9
        Me.lblWidth.Text = "Enter Width:"
        '
        'txtWidth
        '
        Me.txtWidth.Location = New System.Drawing.Point(261, 34)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(34, 20)
        Me.txtWidth.TabIndex = 10
        '
        'lblPerimeterAnswer
        '
        Me.lblPerimeterAnswer.Location = New System.Drawing.Point(74, 107)
        Me.lblPerimeterAnswer.Name = "lblPerimeterAnswer"
        Me.lblPerimeterAnswer.Size = New System.Drawing.Size(60, 22)
        Me.lblPerimeterAnswer.TabIndex = 12
        '
        'lblArea
        '
        Me.lblArea.Location = New System.Drawing.Point(12, 82)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(71, 18)
        Me.lblArea.TabIndex = 1
        Me.lblArea.Text = "Area="
        '
        'lblAreaAnswer
        '
        Me.lblAreaAnswer.Location = New System.Drawing.Point(50, 82)
        Me.lblAreaAnswer.Name = "lblAreaAnswer"
        Me.lblAreaAnswer.Size = New System.Drawing.Size(58, 14)
        Me.lblAreaAnswer.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 150)
        Me.Controls.Add(Me.lblAreaAnswer)
        Me.Controls.Add(Me.lblPerimeterAnswer)
        Me.Controls.Add(Me.txtWidth)
        Me.Controls.Add(Me.lblWidth)
        Me.Controls.Add(Me.txtLength)
        Me.Controls.Add(Me.lblLength)
        Me.Controls.Add(Me.btnAnswer)
        Me.Controls.Add(Me.lblPerimeter)
        Me.Controls.Add(Me.lblArea)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Rectangle Area and Perimeter"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAnswer As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuProgram As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblPerimeter As System.Windows.Forms.Label
    Friend WithEvents lblLength As System.Windows.Forms.Label
    Friend WithEvents txtLength As System.Windows.Forms.TextBox
    Friend WithEvents lblWidth As System.Windows.Forms.Label
    Friend WithEvents txtWidth As System.Windows.Forms.TextBox
    Friend WithEvents lblPerimeterAnswer As System.Windows.Forms.Label
    Friend WithEvents lblArea As System.Windows.Forms.Label
    Friend WithEvents lblAreaAnswer As System.Windows.Forms.Label

End Class
