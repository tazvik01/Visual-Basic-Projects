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
        Me.lblRatePrompt = New System.Windows.Forms.Label()
        Me.lblTermPrompt = New System.Windows.Forms.Label()
        Me.lblPrincipalPrompt = New System.Windows.Forms.Label()
        Me.txtPrincipal = New System.Windows.Forms.TextBox()
        Me.lblMonthlyPayment = New System.Windows.Forms.Label()
        Me.btnPayment = New System.Windows.Forms.Button()
        Me.cboRate = New System.Windows.Forms.ComboBox()
        Me.cboTerm = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblRatePrompt
        '
        Me.lblRatePrompt.Location = New System.Drawing.Point(12, 25)
        Me.lblRatePrompt.Name = "lblRatePrompt"
        Me.lblRatePrompt.Size = New System.Drawing.Size(94, 21)
        Me.lblRatePrompt.TabIndex = 0
        Me.lblRatePrompt.Text = "&Interest rate (%):" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblTermPrompt
        '
        Me.lblTermPrompt.Location = New System.Drawing.Point(12, 76)
        Me.lblTermPrompt.Name = "lblTermPrompt"
        Me.lblTermPrompt.Size = New System.Drawing.Size(135, 21)
        Me.lblTermPrompt.TabIndex = 2
        Me.lblTermPrompt.Text = "& Term of loan (years):"
        '
        'lblPrincipalPrompt
        '
        Me.lblPrincipalPrompt.Location = New System.Drawing.Point(12, 124)
        Me.lblPrincipalPrompt.Name = "lblPrincipalPrompt"
        Me.lblPrincipalPrompt.Size = New System.Drawing.Size(70, 20)
        Me.lblPrincipalPrompt.TabIndex = 4
        Me.lblPrincipalPrompt.Text = "P&rincipal($):"
        '
        'txtPrincipal
        '
        Me.txtPrincipal.Location = New System.Drawing.Point(78, 124)
        Me.txtPrincipal.Name = "txtPrincipal"
        Me.txtPrincipal.Size = New System.Drawing.Size(105, 20)
        Me.txtPrincipal.TabIndex = 5
        '
        'lblMonthlyPayment
        '
        Me.lblMonthlyPayment.Location = New System.Drawing.Point(15, 178)
        Me.lblMonthlyPayment.Name = "lblMonthlyPayment"
        Me.lblMonthlyPayment.Size = New System.Drawing.Size(401, 51)
        Me.lblMonthlyPayment.TabIndex = 6
        '
        'btnPayment
        '
        Me.btnPayment.Enabled = False
        Me.btnPayment.Location = New System.Drawing.Point(315, 134)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.Size = New System.Drawing.Size(101, 25)
        Me.btnPayment.TabIndex = 7
        Me.btnPayment.Text = "&Payment"
        Me.btnPayment.UseVisualStyleBackColor = True
        '
        'cboRate
        '
        Me.cboRate.FormattingEnabled = True
        Me.cboRate.Items.AddRange(New Object() {"6%", "6.5%", "7%", "7.5%", "8%", "8.5%", "9%"})
        Me.cboRate.Location = New System.Drawing.Point(97, 25)
        Me.cboRate.Name = "cboRate"
        Me.cboRate.Size = New System.Drawing.Size(97, 21)
        Me.cboRate.TabIndex = 1
        '
        'cboTerm
        '
        Me.cboTerm.FormattingEnabled = True
        Me.cboTerm.Items.AddRange(New Object() {"3", "5", "10", "15", "20", "30"})
        Me.cboTerm.Location = New System.Drawing.Point(123, 73)
        Me.cboTerm.Name = "cboTerm"
        Me.cboTerm.Size = New System.Drawing.Size(103, 21)
        Me.cboTerm.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 238)
        Me.Controls.Add(Me.cboTerm)
        Me.Controls.Add(Me.cboRate)
        Me.Controls.Add(Me.btnPayment)
        Me.Controls.Add(Me.lblMonthlyPayment)
        Me.Controls.Add(Me.txtPrincipal)
        Me.Controls.Add(Me.lblPrincipalPrompt)
        Me.Controls.Add(Me.lblTermPrompt)
        Me.Controls.Add(Me.lblRatePrompt)
        Me.Name = "Form1"
        Me.Text = "Loan Payment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblRatePrompt As System.Windows.Forms.Label
    Friend WithEvents lblTermPrompt As System.Windows.Forms.Label
    Friend WithEvents lblPrincipalPrompt As System.Windows.Forms.Label
    Friend WithEvents txtPrincipal As System.Windows.Forms.TextBox
    Friend WithEvents lblMonthlyPayment As System.Windows.Forms.Label
    Friend WithEvents btnPayment As System.Windows.Forms.Button
    Friend WithEvents cboRate As System.Windows.Forms.ComboBox
    Friend WithEvents cboTerm As System.Windows.Forms.ComboBox

End Class
