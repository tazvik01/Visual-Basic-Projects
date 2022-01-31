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
        Me.lblStatement = New System.Windows.Forms.Label()
        Me.txtCents = New System.Windows.Forms.TextBox()
        Me.lblQuarters = New System.Windows.Forms.Label()
        Me.lblQuarterAnswer = New System.Windows.Forms.Label()
        Me.lblDimes = New System.Windows.Forms.Label()
        Me.lblDimeAnswer = New System.Windows.Forms.Label()
        Me.lblNickels = New System.Windows.Forms.Label()
        Me.lblNickelAnswer = New System.Windows.Forms.Label()
        Me.lblPennies = New System.Windows.Forms.Label()
        Me.lblPennieAnswer = New System.Windows.Forms.Label()
        Me.btnCoins = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblStatement
        '
        Me.lblStatement.Location = New System.Drawing.Point(2, 22)
        Me.lblStatement.Name = "lblStatement"
        Me.lblStatement.Size = New System.Drawing.Size(155, 23)
        Me.lblStatement.TabIndex = 0
        Me.lblStatement.Text = "Enter the change in cents:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtCents
        '
        Me.txtCents.Location = New System.Drawing.Point(163, 19)
        Me.txtCents.Name = "txtCents"
        Me.txtCents.Size = New System.Drawing.Size(39, 20)
        Me.txtCents.TabIndex = 1
        '
        'lblQuarters
        '
        Me.lblQuarters.Location = New System.Drawing.Point(12, 68)
        Me.lblQuarters.Name = "lblQuarters"
        Me.lblQuarters.Size = New System.Drawing.Size(66, 19)
        Me.lblQuarters.TabIndex = 2
        Me.lblQuarters.Text = "Quarters:"
        '
        'lblQuarterAnswer
        '
        Me.lblQuarterAnswer.Location = New System.Drawing.Point(66, 69)
        Me.lblQuarterAnswer.Name = "lblQuarterAnswer"
        Me.lblQuarterAnswer.Size = New System.Drawing.Size(46, 18)
        Me.lblQuarterAnswer.TabIndex = 3
        '
        'lblDimes
        '
        Me.lblDimes.Location = New System.Drawing.Point(12, 102)
        Me.lblDimes.Name = "lblDimes"
        Me.lblDimes.Size = New System.Drawing.Size(61, 18)
        Me.lblDimes.TabIndex = 4
        Me.lblDimes.Text = "Dimes:"
        '
        'lblDimeAnswer
        '
        Me.lblDimeAnswer.Location = New System.Drawing.Point(59, 102)
        Me.lblDimeAnswer.Name = "lblDimeAnswer"
        Me.lblDimeAnswer.Size = New System.Drawing.Size(44, 16)
        Me.lblDimeAnswer.TabIndex = 5
        '
        'lblNickels
        '
        Me.lblNickels.Location = New System.Drawing.Point(12, 135)
        Me.lblNickels.Name = "lblNickels"
        Me.lblNickels.Size = New System.Drawing.Size(50, 20)
        Me.lblNickels.TabIndex = 6
        Me.lblNickels.Text = "Nickels:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblNickelAnswer
        '
        Me.lblNickelAnswer.Location = New System.Drawing.Point(59, 135)
        Me.lblNickelAnswer.Name = "lblNickelAnswer"
        Me.lblNickelAnswer.Size = New System.Drawing.Size(53, 19)
        Me.lblNickelAnswer.TabIndex = 7
        '
        'lblPennies
        '
        Me.lblPennies.Location = New System.Drawing.Point(12, 174)
        Me.lblPennies.Name = "lblPennies"
        Me.lblPennies.Size = New System.Drawing.Size(53, 20)
        Me.lblPennies.TabIndex = 8
        Me.lblPennies.Text = "Pennies:"
        '
        'lblPennieAnswer
        '
        Me.lblPennieAnswer.Location = New System.Drawing.Point(61, 174)
        Me.lblPennieAnswer.Name = "lblPennieAnswer"
        Me.lblPennieAnswer.Size = New System.Drawing.Size(44, 20)
        Me.lblPennieAnswer.TabIndex = 9
        '
        'btnCoins
        '
        Me.btnCoins.Location = New System.Drawing.Point(183, 160)
        Me.btnCoins.Name = "btnCoins"
        Me.btnCoins.Size = New System.Drawing.Size(75, 23)
        Me.btnCoins.TabIndex = 10
        Me.btnCoins.Text = "Coins"
        Me.btnCoins.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(288, 227)
        Me.Controls.Add(Me.btnCoins)
        Me.Controls.Add(Me.lblPennieAnswer)
        Me.Controls.Add(Me.lblPennies)
        Me.Controls.Add(Me.lblNickelAnswer)
        Me.Controls.Add(Me.lblNickels)
        Me.Controls.Add(Me.lblDimeAnswer)
        Me.Controls.Add(Me.lblDimes)
        Me.Controls.Add(Me.lblQuarterAnswer)
        Me.Controls.Add(Me.lblQuarters)
        Me.Controls.Add(Me.txtCents)
        Me.Controls.Add(Me.lblStatement)
        Me.Name = "Form1"
        Me.Text = "Change"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblStatement As System.Windows.Forms.Label
    Friend WithEvents txtCents As System.Windows.Forms.TextBox
    Friend WithEvents lblQuarters As System.Windows.Forms.Label
    Friend WithEvents lblQuarterAnswer As System.Windows.Forms.Label
    Friend WithEvents lblDimes As System.Windows.Forms.Label
    Friend WithEvents lblDimeAnswer As System.Windows.Forms.Label
    Friend WithEvents lblNickels As System.Windows.Forms.Label
    Friend WithEvents lblNickelAnswer As System.Windows.Forms.Label
    Friend WithEvents lblPennies As System.Windows.Forms.Label
    Friend WithEvents lblPennieAnswer As System.Windows.Forms.Label
    Friend WithEvents btnCoins As System.Windows.Forms.Button

End Class
