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
        Me.lblComputerQuestion = New System.Windows.Forms.Label()
        Me.txtComputerBeep = New System.Windows.Forms.TextBox()
        Me.lblHardDriveQuestion = New System.Windows.Forms.Label()
        Me.txtHardDriveSpin = New System.Windows.Forms.TextBox()
        Me.lblStatement = New System.Windows.Forms.Label()
        Me.btnWhatToDo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblComputerQuestion
        '
        Me.lblComputerQuestion.Location = New System.Drawing.Point(16, 34)
        Me.lblComputerQuestion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblComputerQuestion.Name = "lblComputerQuestion"
        Me.lblComputerQuestion.Size = New System.Drawing.Size(295, 28)
        Me.lblComputerQuestion.TabIndex = 0
        Me.lblComputerQuestion.Text = "Does the computer beep on  start up (Y/N)?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtComputerBeep
        '
        Me.txtComputerBeep.Location = New System.Drawing.Point(319, 34)
        Me.txtComputerBeep.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtComputerBeep.Name = "txtComputerBeep"
        Me.txtComputerBeep.Size = New System.Drawing.Size(35, 22)
        Me.txtComputerBeep.TabIndex = 1
        '
        'lblHardDriveQuestion
        '
        Me.lblHardDriveQuestion.Location = New System.Drawing.Point(16, 89)
        Me.lblHardDriveQuestion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHardDriveQuestion.Name = "lblHardDriveQuestion"
        Me.lblHardDriveQuestion.Size = New System.Drawing.Size(212, 22)
        Me.lblHardDriveQuestion.TabIndex = 2
        Me.lblHardDriveQuestion.Text = "Does the hard drive spin (Y/N)?"
        '
        'txtHardDriveSpin
        '
        Me.txtHardDriveSpin.Location = New System.Drawing.Point(236, 89)
        Me.txtHardDriveSpin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtHardDriveSpin.Name = "txtHardDriveSpin"
        Me.txtHardDriveSpin.Size = New System.Drawing.Size(35, 22)
        Me.txtHardDriveSpin.TabIndex = 3
        '
        'lblStatement
        '
        Me.lblStatement.Location = New System.Drawing.Point(16, 145)
        Me.lblStatement.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStatement.Name = "lblStatement"
        Me.lblStatement.Size = New System.Drawing.Size(256, 42)
        Me.lblStatement.TabIndex = 4
        '
        'btnWhatToDo
        '
        Me.btnWhatToDo.Location = New System.Drawing.Point(303, 175)
        Me.btnWhatToDo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnWhatToDo.Name = "btnWhatToDo"
        Me.btnWhatToDo.Size = New System.Drawing.Size(128, 28)
        Me.btnWhatToDo.TabIndex = 5
        Me.btnWhatToDo.Text = "What to do?"
        Me.btnWhatToDo.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 234)
        Me.Controls.Add(Me.btnWhatToDo)
        Me.Controls.Add(Me.lblStatement)
        Me.Controls.Add(Me.txtHardDriveSpin)
        Me.Controls.Add(Me.lblHardDriveQuestion)
        Me.Controls.Add(Me.txtComputerBeep)
        Me.Controls.Add(Me.lblComputerQuestion)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Computer Troubleshooting"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblComputerQuestion As System.Windows.Forms.Label
    Friend WithEvents txtComputerBeep As System.Windows.Forms.TextBox
    Friend WithEvents lblHardDriveQuestion As System.Windows.Forms.Label
    Friend WithEvents txtHardDriveSpin As System.Windows.Forms.TextBox
    Friend WithEvents lblStatement As System.Windows.Forms.Label
    Friend WithEvents btnWhatToDo As System.Windows.Forms.Button

End Class
