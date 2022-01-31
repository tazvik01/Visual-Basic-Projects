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
        Me.lblNumberPrompt = New System.Windows.Forms.Label()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.btnComputeFactorial = New System.Windows.Forms.Button()
        Me.lblFactorial = New System.Windows.Forms.Label()
        Me.lblFactorialMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblNumberPrompt
        '
        Me.lblNumberPrompt.Location = New System.Drawing.Point(12, 21)
        Me.lblNumberPrompt.Name = "lblNumberPrompt"
        Me.lblNumberPrompt.Size = New System.Drawing.Size(119, 26)
        Me.lblNumberPrompt.TabIndex = 0
        Me.lblNumberPrompt.Text = "Enter a number:"
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(104, 18)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(27, 20)
        Me.txtNumber.TabIndex = 1
        '
        'btnComputeFactorial
        '
        Me.btnComputeFactorial.Location = New System.Drawing.Point(176, 32)
        Me.btnComputeFactorial.Name = "btnComputeFactorial"
        Me.btnComputeFactorial.Size = New System.Drawing.Size(113, 26)
        Me.btnComputeFactorial.TabIndex = 2
        Me.btnComputeFactorial.Text = "Compute Factorial" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnComputeFactorial.UseVisualStyleBackColor = True
        '
        'lblFactorial
        '
        Me.lblFactorial.Location = New System.Drawing.Point(97, 84)
        Me.lblFactorial.Name = "lblFactorial"
        Me.lblFactorial.Size = New System.Drawing.Size(192, 34)
        Me.lblFactorial.TabIndex = 3
        '
        'lblFactorialMessage
        '
        Me.lblFactorialMessage.Location = New System.Drawing.Point(15, 84)
        Me.lblFactorialMessage.Name = "lblFactorialMessage"
        Me.lblFactorialMessage.Size = New System.Drawing.Size(76, 34)
        Me.lblFactorialMessage.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 152)
        Me.Controls.Add(Me.lblFactorialMessage)
        Me.Controls.Add(Me.lblFactorial)
        Me.Controls.Add(Me.btnComputeFactorial)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.lblNumberPrompt)
        Me.Name = "Form1"
        Me.Text = "Factorial"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNumberPrompt As System.Windows.Forms.Label
    Friend WithEvents txtNumber As System.Windows.Forms.TextBox
    Friend WithEvents btnComputeFactorial As System.Windows.Forms.Button
    Friend WithEvents lblFactorial As System.Windows.Forms.Label
    Friend WithEvents lblFactorialMessage As System.Windows.Forms.Label

End Class
