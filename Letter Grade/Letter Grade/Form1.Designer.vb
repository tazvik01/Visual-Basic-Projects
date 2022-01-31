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
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.txtScore = New System.Windows.Forms.TextBox()
        Me.btnLetterGrade = New System.Windows.Forms.Button()
        Me.lblLetterGrade = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblPrompt
        '
        Me.lblPrompt.Location = New System.Drawing.Point(46, 39)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(109, 23)
        Me.lblPrompt.TabIndex = 0
        Me.lblPrompt.Text = "Enter a test score:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtScore
        '
        Me.txtScore.Location = New System.Drawing.Point(144, 36)
        Me.txtScore.Name = "txtScore"
        Me.txtScore.Size = New System.Drawing.Size(36, 20)
        Me.txtScore.TabIndex = 1
        '
        'btnLetterGrade
        '
        Me.btnLetterGrade.Location = New System.Drawing.Point(217, 36)
        Me.btnLetterGrade.Name = "btnLetterGrade"
        Me.btnLetterGrade.Size = New System.Drawing.Size(92, 23)
        Me.btnLetterGrade.TabIndex = 2
        Me.btnLetterGrade.Text = "Letter Grade"
        Me.btnLetterGrade.UseVisualStyleBackColor = True
        '
        'lblLetterGrade
        '
        Me.lblLetterGrade.Location = New System.Drawing.Point(44, 75)
        Me.lblLetterGrade.Name = "lblLetterGrade"
        Me.lblLetterGrade.Size = New System.Drawing.Size(135, 31)
        Me.lblLetterGrade.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 121)
        Me.Controls.Add(Me.lblLetterGrade)
        Me.Controls.Add(Me.btnLetterGrade)
        Me.Controls.Add(Me.txtScore)
        Me.Controls.Add(Me.lblPrompt)
        Me.Name = "Form1"
        Me.Text = "Letter Grade"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPrompt As System.Windows.Forms.Label
    Friend WithEvents txtScore As System.Windows.Forms.TextBox
    Friend WithEvents btnLetterGrade As System.Windows.Forms.Button
    Friend WithEvents lblLetterGrade As System.Windows.Forms.Label

End Class
