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
        Me.lblprompt = New System.Windows.Forms.Label()
        Me.txtNUmber = New System.Windows.Forms.TextBox()
        Me.lblDigits = New System.Windows.Forms.Label()
        Me.btnBreakDown = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblprompt
        '
        Me.lblprompt.Location = New System.Drawing.Point(21, 21)
        Me.lblprompt.Name = "lblprompt"
        Me.lblprompt.Size = New System.Drawing.Size(173, 23)
        Me.lblprompt.TabIndex = 0
        Me.lblprompt.Text = "Enter a number less that 1,000:"
        '
        'txtNUmber
        '
        Me.txtNUmber.Location = New System.Drawing.Point(187, 21)
        Me.txtNUmber.Name = "txtNUmber"
        Me.txtNUmber.Size = New System.Drawing.Size(89, 20)
        Me.txtNUmber.TabIndex = 1
        '
        'lblDigits
        '
        Me.lblDigits.Location = New System.Drawing.Point(12, 55)
        Me.lblDigits.Name = "lblDigits"
        Me.lblDigits.Size = New System.Drawing.Size(333, 90)
        Me.lblDigits.TabIndex = 2
        '
        'btnBreakDown
        '
        Me.btnBreakDown.Location = New System.Drawing.Point(135, 180)
        Me.btnBreakDown.Name = "btnBreakDown"
        Me.btnBreakDown.Size = New System.Drawing.Size(90, 23)
        Me.btnBreakDown.TabIndex = 3
        Me.btnBreakDown.Text = "Break Down"
        Me.btnBreakDown.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 233)
        Me.Controls.Add(Me.btnBreakDown)
        Me.Controls.Add(Me.lblDigits)
        Me.Controls.Add(Me.txtNUmber)
        Me.Controls.Add(Me.lblprompt)
        Me.Name = "Form1"
        Me.Text = "Number Breakdown"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblprompt As System.Windows.Forms.Label
    Friend WithEvents txtNUmber As System.Windows.Forms.TextBox
    Friend WithEvents lblDigits As System.Windows.Forms.Label
    Friend WithEvents btnBreakDown As System.Windows.Forms.Button

End Class
