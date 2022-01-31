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
        Me.grpThrow = New System.Windows.Forms.GroupBox()
        Me.radRock = New System.Windows.Forms.RadioButton()
        Me.radPaper = New System.Windows.Forms.RadioButton()
        Me.radScissors = New System.Windows.Forms.RadioButton()
        Me.lblWinner = New System.Windows.Forms.Label()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.grpThrow.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpThrow
        '
        Me.grpThrow.Controls.Add(Me.radScissors)
        Me.grpThrow.Controls.Add(Me.radPaper)
        Me.grpThrow.Controls.Add(Me.radRock)
        Me.grpThrow.Location = New System.Drawing.Point(22, 12)
        Me.grpThrow.Name = "grpThrow"
        Me.grpThrow.Size = New System.Drawing.Size(296, 71)
        Me.grpThrow.TabIndex = 0
        Me.grpThrow.TabStop = False
        Me.grpThrow.Text = "Choose Your Throw"
        '
        'radRock
        '
        Me.radRock.Location = New System.Drawing.Point(6, 32)
        Me.radRock.Name = "radRock"
        Me.radRock.Size = New System.Drawing.Size(75, 24)
        Me.radRock.TabIndex = 0
        Me.radRock.TabStop = True
        Me.radRock.Text = "Rock"
        Me.radRock.UseVisualStyleBackColor = True
        '
        'radPaper
        '
        Me.radPaper.Location = New System.Drawing.Point(102, 32)
        Me.radPaper.Name = "radPaper"
        Me.radPaper.Size = New System.Drawing.Size(86, 24)
        Me.radPaper.TabIndex = 1
        Me.radPaper.TabStop = True
        Me.radPaper.Text = "Paper"
        Me.radPaper.UseVisualStyleBackColor = True
        '
        'radScissors
        '
        Me.radScissors.Location = New System.Drawing.Point(194, 32)
        Me.radScissors.Name = "radScissors"
        Me.radScissors.Size = New System.Drawing.Size(87, 24)
        Me.radScissors.TabIndex = 2
        Me.radScissors.TabStop = True
        Me.radScissors.Text = "Scissors"
        Me.radScissors.UseVisualStyleBackColor = True
        '
        'lblWinner
        '
        Me.lblWinner.Location = New System.Drawing.Point(25, 105)
        Me.lblWinner.Name = "lblWinner"
        Me.lblWinner.Size = New System.Drawing.Size(263, 40)
        Me.lblWinner.TabIndex = 1
        Me.lblWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(101, 172)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(97, 28)
        Me.btnGo.TabIndex = 2
        Me.btnGo.Text = "Go!"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 212)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.lblWinner)
        Me.Controls.Add(Me.grpThrow)
        Me.Name = "Form1"
        Me.Text = "Rock paper Scissors"
        Me.grpThrow.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpThrow As System.Windows.Forms.GroupBox
    Friend WithEvents radScissors As System.Windows.Forms.RadioButton
    Friend WithEvents radPaper As System.Windows.Forms.RadioButton
    Friend WithEvents radRock As System.Windows.Forms.RadioButton
    Friend WithEvents lblWinner As System.Windows.Forms.Label
    Friend WithEvents btnGo As System.Windows.Forms.Button

End Class
