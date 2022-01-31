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
        Me.lstRollsOutcomes = New System.Windows.Forms.ListBox()
        Me.lblRolls = New System.Windows.Forms.Label()
        Me.txtRolls = New System.Windows.Forms.TextBox()
        Me.btnRollDice = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstRollsOutcomes
        '
        Me.lstRollsOutcomes.FormattingEnabled = True
        Me.lstRollsOutcomes.Location = New System.Drawing.Point(12, 56)
        Me.lstRollsOutcomes.Name = "lstRollsOutcomes"
        Me.lstRollsOutcomes.Size = New System.Drawing.Size(186, 225)
        Me.lstRollsOutcomes.TabIndex = 0
        '
        'lblRolls
        '
        Me.lblRolls.Location = New System.Drawing.Point(12, 15)
        Me.lblRolls.Name = "lblRolls"
        Me.lblRolls.Size = New System.Drawing.Size(106, 23)
        Me.lblRolls.TabIndex = 1
        Me.lblRolls.Text = "Number of rolls;"
        '
        'txtRolls
        '
        Me.txtRolls.Location = New System.Drawing.Point(98, 15)
        Me.txtRolls.Name = "txtRolls"
        Me.txtRolls.Size = New System.Drawing.Size(81, 20)
        Me.txtRolls.TabIndex = 2
        '
        'btnRollDice
        '
        Me.btnRollDice.Location = New System.Drawing.Point(203, 15)
        Me.btnRollDice.Name = "btnRollDice"
        Me.btnRollDice.Size = New System.Drawing.Size(94, 23)
        Me.btnRollDice.TabIndex = 3
        Me.btnRollDice.Text = "Roll Dice"
        Me.btnRollDice.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 309)
        Me.Controls.Add(Me.btnRollDice)
        Me.Controls.Add(Me.txtRolls)
        Me.Controls.Add(Me.lblRolls)
        Me.Controls.Add(Me.lstRollsOutcomes)
        Me.Name = "Form1"
        Me.Text = "Dice Rolls"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstRollsOutcomes As System.Windows.Forms.ListBox
    Friend WithEvents lblRolls As System.Windows.Forms.Label
    Friend WithEvents txtRolls As System.Windows.Forms.TextBox
    Friend WithEvents btnRollDice As System.Windows.Forms.Button

End Class
