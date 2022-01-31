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
        Me.lblInstruction = New System.Windows.Forms.Label()
        Me.btnEnterScores = New System.Windows.Forms.Button()
        Me.btnAverageScore = New System.Windows.Forms.Button()
        Me.lblScoresMessage = New System.Windows.Forms.Label()
        Me.lblNumberOfScores = New System.Windows.Forms.Label()
        Me.lblAverageMessage = New System.Windows.Forms.Label()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblInstruction
        '
        Me.lblInstruction.Location = New System.Drawing.Point(12, 9)
        Me.lblInstruction.Name = "lblInstruction"
        Me.lblInstruction.Size = New System.Drawing.Size(242, 56)
        Me.lblInstruction.TabIndex = 0
        Me.lblInstruction.Text = "Select Enter Scores to enter test scores.Select Average Score to display the aver" & _
            "age of the scores entered."
        '
        'btnEnterScores
        '
        Me.btnEnterScores.Location = New System.Drawing.Point(15, 84)
        Me.btnEnterScores.Name = "btnEnterScores"
        Me.btnEnterScores.Size = New System.Drawing.Size(91, 25)
        Me.btnEnterScores.TabIndex = 1
        Me.btnEnterScores.Text = "Enter Scores"
        Me.btnEnterScores.UseVisualStyleBackColor = True
        '
        'btnAverageScore
        '
        Me.btnAverageScore.Location = New System.Drawing.Point(15, 129)
        Me.btnAverageScore.Name = "btnAverageScore"
        Me.btnAverageScore.Size = New System.Drawing.Size(88, 25)
        Me.btnAverageScore.TabIndex = 2
        Me.btnAverageScore.Text = "Average Score" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnAverageScore.UseVisualStyleBackColor = True
        '
        'lblScoresMessage
        '
        Me.lblScoresMessage.Location = New System.Drawing.Point(130, 84)
        Me.lblScoresMessage.Name = "lblScoresMessage"
        Me.lblScoresMessage.Size = New System.Drawing.Size(118, 29)
        Me.lblScoresMessage.TabIndex = 3
        '
        'lblNumberOfScores
        '
        Me.lblNumberOfScores.Location = New System.Drawing.Point(254, 84)
        Me.lblNumberOfScores.Name = "lblNumberOfScores"
        Me.lblNumberOfScores.Size = New System.Drawing.Size(73, 29)
        Me.lblNumberOfScores.TabIndex = 4
        '
        'lblAverageMessage
        '
        Me.lblAverageMessage.Location = New System.Drawing.Point(125, 129)
        Me.lblAverageMessage.Name = "lblAverageMessage"
        Me.lblAverageMessage.Size = New System.Drawing.Size(123, 35)
        Me.lblAverageMessage.TabIndex = 5
        '
        'lblAverage
        '
        Me.lblAverage.Location = New System.Drawing.Point(257, 135)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(70, 29)
        Me.lblAverage.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 191)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.lblAverageMessage)
        Me.Controls.Add(Me.lblNumberOfScores)
        Me.Controls.Add(Me.lblScoresMessage)
        Me.Controls.Add(Me.btnAverageScore)
        Me.Controls.Add(Me.btnEnterScores)
        Me.Controls.Add(Me.lblInstruction)
        Me.Name = "Form1"
        Me.Text = "Average Score"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblInstruction As System.Windows.Forms.Label
    Friend WithEvents btnEnterScores As System.Windows.Forms.Button
    Friend WithEvents btnAverageScore As System.Windows.Forms.Button
    Friend WithEvents lblScoresMessage As System.Windows.Forms.Label
    Friend WithEvents lblNumberOfScores As System.Windows.Forms.Label
    Friend WithEvents lblAverageMessage As System.Windows.Forms.Label
    Friend WithEvents lblAverage As System.Windows.Forms.Label

End Class
