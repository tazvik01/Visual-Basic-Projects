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
        Me.lblEnterDigit = New System.Windows.Forms.Label()
        Me.txtDigits = New System.Windows.Forms.TextBox()
        Me.lblFirstDigit = New System.Windows.Forms.Label()
        Me.lblFirstDigitAnswer = New System.Windows.Forms.Label()
        Me.lblSecondDigit = New System.Windows.Forms.Label()
        Me.lblSecondDigitAnswer = New System.Windows.Forms.Label()
        Me.btnDigits = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuProgram = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDigits = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblEnterDigit
        '
        Me.lblEnterDigit.Location = New System.Drawing.Point(12, 28)
        Me.lblEnterDigit.Name = "lblEnterDigit"
        Me.lblEnterDigit.Size = New System.Drawing.Size(137, 40)
        Me.lblEnterDigit.TabIndex = 0
        Me.lblEnterDigit.Text = "Enter a two-digit number:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtDigits
        '
        Me.txtDigits.Location = New System.Drawing.Point(155, 25)
        Me.txtDigits.Name = "txtDigits"
        Me.txtDigits.Size = New System.Drawing.Size(35, 20)
        Me.txtDigits.TabIndex = 1
        '
        'lblFirstDigit
        '
        Me.lblFirstDigit.Location = New System.Drawing.Point(12, 68)
        Me.lblFirstDigit.Name = "lblFirstDigit"
        Me.lblFirstDigit.Size = New System.Drawing.Size(100, 23)
        Me.lblFirstDigit.TabIndex = 2
        Me.lblFirstDigit.Text = "The first digit is :"
        '
        'lblFirstDigitAnswer
        '
        Me.lblFirstDigitAnswer.Location = New System.Drawing.Point(102, 68)
        Me.lblFirstDigitAnswer.Name = "lblFirstDigitAnswer"
        Me.lblFirstDigitAnswer.Size = New System.Drawing.Size(56, 23)
        Me.lblFirstDigitAnswer.TabIndex = 3
        '
        'lblSecondDigit
        '
        Me.lblSecondDigit.Location = New System.Drawing.Point(12, 106)
        Me.lblSecondDigit.Name = "lblSecondDigit"
        Me.lblSecondDigit.Size = New System.Drawing.Size(106, 23)
        Me.lblSecondDigit.TabIndex = 4
        Me.lblSecondDigit.Text = "The second digit is:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblSecondDigitAnswer
        '
        Me.lblSecondDigitAnswer.Location = New System.Drawing.Point(116, 106)
        Me.lblSecondDigitAnswer.Name = "lblSecondDigitAnswer"
        Me.lblSecondDigitAnswer.Size = New System.Drawing.Size(59, 19)
        Me.lblSecondDigitAnswer.TabIndex = 5
        '
        'btnDigits
        '
        Me.btnDigits.Location = New System.Drawing.Point(12, 148)
        Me.btnDigits.Name = "btnDigits"
        Me.btnDigits.Size = New System.Drawing.Size(79, 26)
        Me.btnDigits.TabIndex = 6
        Me.btnDigits.Text = "Digits"
        Me.btnDigits.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuProgram})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(237, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuProgram
        '
        Me.mnuProgram.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDigits})
        Me.mnuProgram.Name = "mnuProgram"
        Me.mnuProgram.Size = New System.Drawing.Size(65, 20)
        Me.mnuProgram.Text = "Program"
        '
        'mnuDigits
        '
        Me.mnuDigits.Name = "mnuDigits"
        Me.mnuDigits.Size = New System.Drawing.Size(152, 22)
        Me.mnuDigits.Text = "Digits"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(237, 212)
        Me.Controls.Add(Me.btnDigits)
        Me.Controls.Add(Me.lblSecondDigitAnswer)
        Me.Controls.Add(Me.lblSecondDigit)
        Me.Controls.Add(Me.lblFirstDigitAnswer)
        Me.Controls.Add(Me.lblFirstDigit)
        Me.Controls.Add(Me.txtDigits)
        Me.Controls.Add(Me.lblEnterDigit)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Digits of a Number"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEnterDigit As System.Windows.Forms.Label
    Friend WithEvents txtDigits As System.Windows.Forms.TextBox
    Friend WithEvents lblFirstDigit As System.Windows.Forms.Label
    Friend WithEvents lblFirstDigitAnswer As System.Windows.Forms.Label
    Friend WithEvents lblSecondDigit As System.Windows.Forms.Label
    Friend WithEvents lblSecondDigitAnswer As System.Windows.Forms.Label
    Friend WithEvents btnDigits As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuProgram As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDigits As System.Windows.Forms.ToolStripMenuItem

End Class
