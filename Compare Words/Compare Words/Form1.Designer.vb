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
        Me.txtFirstWord = New System.Windows.Forms.TextBox()
        Me.lblSecondPormpt = New System.Windows.Forms.Label()
        Me.txtSecondWord = New System.Windows.Forms.TextBox()
        Me.lblStatement = New System.Windows.Forms.Label()
        Me.btnCompareWords = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPrompt
        '
        Me.lblPrompt.Location = New System.Drawing.Point(12, 26)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(114, 26)
        Me.lblPrompt.TabIndex = 0
        Me.lblPrompt.Text = "Enter first word:"
        '
        'txtFirstWord
        '
        Me.txtFirstWord.Location = New System.Drawing.Point(96, 23)
        Me.txtFirstWord.Name = "txtFirstWord"
        Me.txtFirstWord.Size = New System.Drawing.Size(181, 20)
        Me.txtFirstWord.TabIndex = 1
        '
        'lblSecondPormpt
        '
        Me.lblSecondPormpt.Location = New System.Drawing.Point(12, 63)
        Me.lblSecondPormpt.Name = "lblSecondPormpt"
        Me.lblSecondPormpt.Size = New System.Drawing.Size(123, 26)
        Me.lblSecondPormpt.TabIndex = 2
        Me.lblSecondPormpt.Text = "Enter second word:"
        '
        'txtSecondWord
        '
        Me.txtSecondWord.Location = New System.Drawing.Point(117, 60)
        Me.txtSecondWord.Name = "txtSecondWord"
        Me.txtSecondWord.Size = New System.Drawing.Size(160, 20)
        Me.txtSecondWord.TabIndex = 3
        '
        'lblStatement
        '
        Me.lblStatement.Location = New System.Drawing.Point(12, 120)
        Me.lblStatement.Name = "lblStatement"
        Me.lblStatement.Size = New System.Drawing.Size(252, 34)
        Me.lblStatement.TabIndex = 4
        '
        'btnCompareWords
        '
        Me.btnCompareWords.Location = New System.Drawing.Point(106, 180)
        Me.btnCompareWords.Name = "btnCompareWords"
        Me.btnCompareWords.Size = New System.Drawing.Size(103, 26)
        Me.btnCompareWords.TabIndex = 5
        Me.btnCompareWords.Text = "CompareWords"
        Me.btnCompareWords.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 218)
        Me.Controls.Add(Me.btnCompareWords)
        Me.Controls.Add(Me.lblStatement)
        Me.Controls.Add(Me.txtSecondWord)
        Me.Controls.Add(Me.lblSecondPormpt)
        Me.Controls.Add(Me.txtFirstWord)
        Me.Controls.Add(Me.lblPrompt)
        Me.Name = "Form1"
        Me.Text = "Compare Words"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPrompt As System.Windows.Forms.Label
    Friend WithEvents txtFirstWord As System.Windows.Forms.TextBox
    Friend WithEvents lblSecondPormpt As System.Windows.Forms.Label
    Friend WithEvents txtSecondWord As System.Windows.Forms.TextBox
    Friend WithEvents lblStatement As System.Windows.Forms.Label
    Friend WithEvents btnCompareWords As System.Windows.Forms.Button

End Class
