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
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.lblDecimalPlace = New System.Windows.Forms.Label()
        Me.txtDecimalPlace = New System.Windows.Forms.TextBox()
        Me.btnRound = New System.Windows.Forms.Button()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblPrompt
        '
        Me.lblPrompt.Location = New System.Drawing.Point(25, 33)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(118, 23)
        Me.lblPrompt.TabIndex = 0
        Me.lblPrompt.Text = "Enter a number:"
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(133, 34)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(100, 22)
        Me.txtNumber.TabIndex = 1
        '
        'lblDecimalPlace
        '
        Me.lblDecimalPlace.Location = New System.Drawing.Point(25, 78)
        Me.lblDecimalPlace.Name = "lblDecimalPlace"
        Me.lblDecimalPlace.Size = New System.Drawing.Size(118, 23)
        Me.lblDecimalPlace.TabIndex = 2
        Me.lblDecimalPlace.Text = "Decimal places:"
        '
        'txtDecimalPlace
        '
        Me.txtDecimalPlace.Location = New System.Drawing.Point(133, 75)
        Me.txtDecimalPlace.Name = "txtDecimalPlace"
        Me.txtDecimalPlace.Size = New System.Drawing.Size(48, 22)
        Me.txtDecimalPlace.TabIndex = 3
        '
        'btnRound
        '
        Me.btnRound.Location = New System.Drawing.Point(273, 34)
        Me.btnRound.Name = "btnRound"
        Me.btnRound.Size = New System.Drawing.Size(100, 31)
        Me.btnRound.TabIndex = 4
        Me.btnRound.Text = "Round"
        Me.btnRound.UseVisualStyleBackColor = True
        '
        'lblAnswer
        '
        Me.lblAnswer.Location = New System.Drawing.Point(251, 109)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(122, 32)
        Me.lblAnswer.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(398, 167)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.btnRound)
        Me.Controls.Add(Me.txtDecimalPlace)
        Me.Controls.Add(Me.lblDecimalPlace)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.lblPrompt)
        Me.Name = "Form1"
        Me.Text = "Round the Number"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPrompt As System.Windows.Forms.Label
    Friend WithEvents txtNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblDecimalPlace As System.Windows.Forms.Label
    Friend WithEvents txtDecimalPlace As System.Windows.Forms.TextBox
    Friend WithEvents btnRound As System.Windows.Forms.Button
    Friend WithEvents lblAnswer As System.Windows.Forms.Label

End Class
