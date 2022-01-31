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
        Me.lblInterestPrompt = New System.Windows.Forms.Label()
        Me.lblTermPrompt = New System.Windows.Forms.Label()
        Me.lblInvestment = New System.Windows.Forms.Label()
        Me.txtInterest = New System.Windows.Forms.TextBox()
        Me.txtTerm = New System.Windows.Forms.TextBox()
        Me.txtInvestment = New System.Windows.Forms.TextBox()
        Me.btnFutureValue = New System.Windows.Forms.Button()
        Me.lblFutureValue = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblInterestPrompt
        '
        Me.lblInterestPrompt.Location = New System.Drawing.Point(12, 20)
        Me.lblInterestPrompt.Name = "lblInterestPrompt"
        Me.lblInterestPrompt.Size = New System.Drawing.Size(121, 25)
        Me.lblInterestPrompt.TabIndex = 0
        Me.lblInterestPrompt.Text = "Interest rate[%]:"
        '
        'lblTermPrompt
        '
        Me.lblTermPrompt.Location = New System.Drawing.Point(12, 71)
        Me.lblTermPrompt.Name = "lblTermPrompt"
        Me.lblTermPrompt.Size = New System.Drawing.Size(121, 25)
        Me.lblTermPrompt.TabIndex = 1
        Me.lblTermPrompt.Text = "Term [Years]:"
        '
        'lblInvestment
        '
        Me.lblInvestment.Location = New System.Drawing.Point(12, 122)
        Me.lblInvestment.Name = "lblInvestment"
        Me.lblInvestment.Size = New System.Drawing.Size(161, 25)
        Me.lblInvestment.TabIndex = 2
        Me.lblInvestment.Text = "Monthly investment [$]:"
        '
        'txtInterest
        '
        Me.txtInterest.Location = New System.Drawing.Point(122, 20)
        Me.txtInterest.Name = "txtInterest"
        Me.txtInterest.Size = New System.Drawing.Size(118, 22)
        Me.txtInterest.TabIndex = 3
        '
        'txtTerm
        '
        Me.txtTerm.Location = New System.Drawing.Point(105, 71)
        Me.txtTerm.Name = "txtTerm"
        Me.txtTerm.Size = New System.Drawing.Size(118, 22)
        Me.txtTerm.TabIndex = 4
        '
        'txtInvestment
        '
        Me.txtInvestment.Location = New System.Drawing.Point(164, 122)
        Me.txtInvestment.Name = "txtInvestment"
        Me.txtInvestment.Size = New System.Drawing.Size(118, 22)
        Me.txtInvestment.TabIndex = 5
        '
        'btnFutureValue
        '
        Me.btnFutureValue.Location = New System.Drawing.Point(338, 121)
        Me.btnFutureValue.Name = "btnFutureValue"
        Me.btnFutureValue.Size = New System.Drawing.Size(112, 26)
        Me.btnFutureValue.TabIndex = 6
        Me.btnFutureValue.Text = "Future Value"
        Me.btnFutureValue.UseVisualStyleBackColor = True
        '
        'lblFutureValue
        '
        Me.lblFutureValue.Location = New System.Drawing.Point(26, 171)
        Me.lblFutureValue.Name = "lblFutureValue"
        Me.lblFutureValue.Size = New System.Drawing.Size(449, 73)
        Me.lblFutureValue.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 253)
        Me.Controls.Add(Me.lblFutureValue)
        Me.Controls.Add(Me.btnFutureValue)
        Me.Controls.Add(Me.txtInvestment)
        Me.Controls.Add(Me.txtTerm)
        Me.Controls.Add(Me.txtInterest)
        Me.Controls.Add(Me.lblInvestment)
        Me.Controls.Add(Me.lblTermPrompt)
        Me.Controls.Add(Me.lblInterestPrompt)
        Me.Name = "Form1"
        Me.Text = "Watch Your Money Grow"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblInterestPrompt As System.Windows.Forms.Label
    Friend WithEvents lblTermPrompt As System.Windows.Forms.Label
    Friend WithEvents lblInvestment As System.Windows.Forms.Label
    Friend WithEvents txtInterest As System.Windows.Forms.TextBox
    Friend WithEvents txtTerm As System.Windows.Forms.TextBox
    Friend WithEvents txtInvestment As System.Windows.Forms.TextBox
    Friend WithEvents btnFutureValue As System.Windows.Forms.Button
    Friend WithEvents lblFutureValue As System.Windows.Forms.Label

End Class
