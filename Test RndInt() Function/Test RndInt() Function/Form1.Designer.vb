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
        Me.txtLowNumber = New System.Windows.Forms.TextBox()
        Me.lblSecondPrompt = New System.Windows.Forms.Label()
        Me.txtHighNumber = New System.Windows.Forms.TextBox()
        Me.btnRandomize = New System.Windows.Forms.Button()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblPrompt
        '
        Me.lblPrompt.Location = New System.Drawing.Point(12, 26)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(135, 23)
        Me.lblPrompt.TabIndex = 0
        Me.lblPrompt.Text = "Enter a low number:"
        '
        'txtLowNumber
        '
        Me.txtLowNumber.Location = New System.Drawing.Point(119, 23)
        Me.txtLowNumber.Name = "txtLowNumber"
        Me.txtLowNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtLowNumber.TabIndex = 1
        '
        'lblSecondPrompt
        '
        Me.lblSecondPrompt.Location = New System.Drawing.Point(12, 69)
        Me.lblSecondPrompt.Name = "lblSecondPrompt"
        Me.lblSecondPrompt.Size = New System.Drawing.Size(142, 23)
        Me.lblSecondPrompt.TabIndex = 2
        Me.lblSecondPrompt.Text = "Enter a high number:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtHighNumber
        '
        Me.txtHighNumber.Location = New System.Drawing.Point(119, 66)
        Me.txtHighNumber.Name = "txtHighNumber"
        Me.txtHighNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtHighNumber.TabIndex = 3
        '
        'btnRandomize
        '
        Me.btnRandomize.Location = New System.Drawing.Point(119, 157)
        Me.btnRandomize.Name = "btnRandomize"
        Me.btnRandomize.Size = New System.Drawing.Size(100, 28)
        Me.btnRandomize.TabIndex = 4
        Me.btnRandomize.Text = "Randomize"
        Me.btnRandomize.UseVisualStyleBackColor = True
        '
        'lblAnswer
        '
        Me.lblAnswer.Location = New System.Drawing.Point(12, 106)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(179, 27)
        Me.lblAnswer.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(347, 197)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.btnRandomize)
        Me.Controls.Add(Me.txtHighNumber)
        Me.Controls.Add(Me.lblSecondPrompt)
        Me.Controls.Add(Me.txtLowNumber)
        Me.Controls.Add(Me.lblPrompt)
        Me.Name = "Form1"
        Me.Text = "Test RndInt() Function"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPrompt As System.Windows.Forms.Label
    Friend WithEvents txtLowNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblSecondPrompt As System.Windows.Forms.Label
    Friend WithEvents txtHighNumber As System.Windows.Forms.TextBox
    Friend WithEvents btnRandomize As System.Windows.Forms.Button
    Friend WithEvents lblAnswer As System.Windows.Forms.Label

End Class
