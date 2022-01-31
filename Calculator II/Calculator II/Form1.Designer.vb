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
        Me.txtDisplay = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnOff = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btnDot = New System.Windows.Forms.Button()
        Me.btnEqual = New System.Windows.Forms.Button()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.btnMinus = New System.Windows.Forms.Button()
        Me.btnTimes = New System.Windows.Forms.Button()
        Me.btnDivide = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btnIntegerDivision = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtDisplay
        '
        Me.txtDisplay.Location = New System.Drawing.Point(6, 12)
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.Size = New System.Drawing.Size(248, 20)
        Me.txtDisplay.TabIndex = 0
        Me.txtDisplay.Text = "                                                                       " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & _
            "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "       0"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(12, 65)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(55, 28)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnOff
        '
        Me.btnOff.Location = New System.Drawing.Point(73, 65)
        Me.btnOff.Name = "btnOff"
        Me.btnOff.Size = New System.Drawing.Size(55, 28)
        Me.btnOff.TabIndex = 2
        Me.btnOff.Text = "Off"
        Me.btnOff.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(12, 205)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(42, 31)
        Me.btn1.TabIndex = 3
        Me.btn1.Tag = "1"
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(60, 205)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(42, 31)
        Me.btn2.TabIndex = 4
        Me.btn2.Tag = "2"
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(108, 205)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(42, 31)
        Me.btn3.TabIndex = 5
        Me.btn3.Tag = "3"
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn0
        '
        Me.btn0.Location = New System.Drawing.Point(12, 242)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(42, 31)
        Me.btn0.TabIndex = 6
        Me.btn0.Tag = "0"
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = True
        '
        'btnDot
        '
        Me.btnDot.Location = New System.Drawing.Point(60, 242)
        Me.btnDot.Name = "btnDot"
        Me.btnDot.Size = New System.Drawing.Size(42, 31)
        Me.btnDot.TabIndex = 7
        Me.btnDot.Tag = "."
        Me.btnDot.Text = "."
        Me.btnDot.UseVisualStyleBackColor = True
        '
        'btnEqual
        '
        Me.btnEqual.Location = New System.Drawing.Point(107, 242)
        Me.btnEqual.Name = "btnEqual"
        Me.btnEqual.Size = New System.Drawing.Size(68, 31)
        Me.btnEqual.TabIndex = 8
        Me.btnEqual.Tag = "="
        Me.btnEqual.Text = "="
        Me.btnEqual.UseVisualStyleBackColor = True
        '
        'btnPlus
        '
        Me.btnPlus.Location = New System.Drawing.Point(212, 190)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(42, 94)
        Me.btnPlus.TabIndex = 9
        Me.btnPlus.Tag = "+"
        Me.btnPlus.Text = "+"
        Me.btnPlus.UseVisualStyleBackColor = True
        '
        'btnMinus
        '
        Me.btnMinus.Location = New System.Drawing.Point(212, 157)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(42, 24)
        Me.btnMinus.TabIndex = 10
        Me.btnMinus.Tag = "-"
        Me.btnMinus.Text = "-"
        Me.btnMinus.UseVisualStyleBackColor = True
        '
        'btnTimes
        '
        Me.btnTimes.Location = New System.Drawing.Point(212, 120)
        Me.btnTimes.Name = "btnTimes"
        Me.btnTimes.Size = New System.Drawing.Size(42, 24)
        Me.btnTimes.TabIndex = 11
        Me.btnTimes.Tag = "X"
        Me.btnTimes.Text = "X"
        Me.btnTimes.UseVisualStyleBackColor = True
        '
        'btnDivide
        '
        Me.btnDivide.Location = New System.Drawing.Point(212, 87)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(42, 24)
        Me.btnDivide.TabIndex = 12
        Me.btnDivide.Tag = "/"
        Me.btnDivide.Text = "/"
        Me.btnDivide.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Location = New System.Drawing.Point(12, 168)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(42, 31)
        Me.btn4.TabIndex = 13
        Me.btn4.Tag = "4"
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Location = New System.Drawing.Point(60, 168)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(42, 31)
        Me.btn5.TabIndex = 14
        Me.btn5.Tag = "5"
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Location = New System.Drawing.Point(107, 168)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(42, 31)
        Me.btn6.TabIndex = 15
        Me.btn6.Tag = "6"
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Location = New System.Drawing.Point(12, 131)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(42, 31)
        Me.btn7.TabIndex = 16
        Me.btn7.Tag = "7"
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.Location = New System.Drawing.Point(60, 131)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(42, 31)
        Me.btn8.TabIndex = 17
        Me.btn8.Tag = "8"
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.Location = New System.Drawing.Point(107, 131)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(42, 31)
        Me.btn9.TabIndex = 18
        Me.btn9.Tag = "9"
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btnIntegerDivision
        '
        Me.btnIntegerDivision.Location = New System.Drawing.Point(212, 56)
        Me.btnIntegerDivision.Name = "btnIntegerDivision"
        Me.btnIntegerDivision.Size = New System.Drawing.Size(42, 25)
        Me.btnIntegerDivision.TabIndex = 19
        Me.btnIntegerDivision.Tag = "\"
        Me.btnIntegerDivision.Text = "\"
        Me.btnIntegerDivision.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(263, 289)
        Me.Controls.Add(Me.btnIntegerDivision)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btnDivide)
        Me.Controls.Add(Me.btnTimes)
        Me.Controls.Add(Me.btnMinus)
        Me.Controls.Add(Me.btnPlus)
        Me.Controls.Add(Me.btnEqual)
        Me.Controls.Add(Me.btnDot)
        Me.Controls.Add(Me.btn0)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.btnOff)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtDisplay)
        Me.Name = "Form1"
        Me.Text = "Calculator II"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDisplay As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnOff As System.Windows.Forms.Button
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents btn2 As System.Windows.Forms.Button
    Friend WithEvents btn3 As System.Windows.Forms.Button
    Friend WithEvents btn0 As System.Windows.Forms.Button
    Friend WithEvents btnDot As System.Windows.Forms.Button
    Friend WithEvents btnEqual As System.Windows.Forms.Button
    Friend WithEvents btnPlus As System.Windows.Forms.Button
    Friend WithEvents btnMinus As System.Windows.Forms.Button
    Friend WithEvents btnTimes As System.Windows.Forms.Button
    Friend WithEvents btnDivide As System.Windows.Forms.Button
    Friend WithEvents btn4 As System.Windows.Forms.Button
    Friend WithEvents btn5 As System.Windows.Forms.Button
    Friend WithEvents btn6 As System.Windows.Forms.Button
    Friend WithEvents btn7 As System.Windows.Forms.Button
    Friend WithEvents btn8 As System.Windows.Forms.Button
    Friend WithEvents btn9 As System.Windows.Forms.Button
    Friend WithEvents btnIntegerDivision As System.Windows.Forms.Button

End Class
