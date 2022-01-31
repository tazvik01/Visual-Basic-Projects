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
        Me.radScissors = New System.Windows.Forms.RadioButton()
        Me.radPaper = New System.Windows.Forms.RadioButton()
        Me.radRock = New System.Windows.Forms.RadioButton()
        Me.lblWinner = New System.Windows.Forms.Label()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.lblComputerRecord = New System.Windows.Forms.Label()
        Me.lblPlayerRecord = New System.Windows.Forms.Label()
        Me.lblDraws = New System.Windows.Forms.Label()
        Me.lblComputerWins = New System.Windows.Forms.Label()
        Me.lblPlayerWins = New System.Windows.Forms.Label()
        Me.lblNumbeOfDraws = New System.Windows.Forms.Label()
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
        'lblWinner
        '
        Me.lblWinner.Location = New System.Drawing.Point(25, 103)
        Me.lblWinner.Name = "lblWinner"
        Me.lblWinner.Size = New System.Drawing.Size(263, 40)
        Me.lblWinner.TabIndex = 1
        Me.lblWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(113, 208)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(97, 28)
        Me.btnGo.TabIndex = 2
        Me.btnGo.Text = "Go!"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'lblComputerRecord
        '
        Me.lblComputerRecord.Location = New System.Drawing.Point(25, 143)
        Me.lblComputerRecord.Name = "lblComputerRecord"
        Me.lblComputerRecord.Size = New System.Drawing.Size(80, 22)
        Me.lblComputerRecord.TabIndex = 3
        Me.lblComputerRecord.Text = "Computer wins:"
        '
        'lblPlayerRecord
        '
        Me.lblPlayerRecord.Location = New System.Drawing.Point(174, 145)
        Me.lblPlayerRecord.Name = "lblPlayerRecord"
        Me.lblPlayerRecord.Size = New System.Drawing.Size(63, 26)
        Me.lblPlayerRecord.TabIndex = 4
        Me.lblPlayerRecord.Text = "Player wins:"
        '
        'lblDraws
        '
        Me.lblDraws.Location = New System.Drawing.Point(99, 179)
        Me.lblDraws.Name = "lblDraws"
        Me.lblDraws.Size = New System.Drawing.Size(46, 26)
        Me.lblDraws.TabIndex = 5
        Me.lblDraws.Text = "Draws:"
        '
        'lblComputerWins
        '
        Me.lblComputerWins.Location = New System.Drawing.Point(102, 143)
        Me.lblComputerWins.Name = "lblComputerWins"
        Me.lblComputerWins.Size = New System.Drawing.Size(45, 22)
        Me.lblComputerWins.TabIndex = 6
        '
        'lblPlayerWins
        '
        Me.lblPlayerWins.Location = New System.Drawing.Point(244, 143)
        Me.lblPlayerWins.Name = "lblPlayerWins"
        Me.lblPlayerWins.Size = New System.Drawing.Size(59, 22)
        Me.lblPlayerWins.TabIndex = 7
        '
        'lblNumbeOfDraws
        '
        Me.lblNumbeOfDraws.Location = New System.Drawing.Point(140, 179)
        Me.lblNumbeOfDraws.Name = "lblNumbeOfDraws"
        Me.lblNumbeOfDraws.Size = New System.Drawing.Size(59, 26)
        Me.lblNumbeOfDraws.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 248)
        Me.Controls.Add(Me.lblNumbeOfDraws)
        Me.Controls.Add(Me.lblPlayerWins)
        Me.Controls.Add(Me.lblComputerWins)
        Me.Controls.Add(Me.lblDraws)
        Me.Controls.Add(Me.lblPlayerRecord)
        Me.Controls.Add(Me.lblComputerRecord)
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
    Friend WithEvents lblComputerRecord As System.Windows.Forms.Label
    Friend WithEvents lblPlayerRecord As System.Windows.Forms.Label
    Friend WithEvents lblDraws As System.Windows.Forms.Label
    Friend WithEvents lblComputerWins As System.Windows.Forms.Label
    Friend WithEvents lblPlayerWins As System.Windows.Forms.Label
    Friend WithEvents lblNumbeOfDraws As System.Windows.Forms.Label

End Class
