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
        Me.txtOddNumber = New System.Windows.Forms.TextBox()
        Me.lblOddNumberSum = New System.Windows.Forms.Label()
        Me.btnSum = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPrompt
        '
        Me.lblPrompt.Location = New System.Drawing.Point(30, 27)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(174, 33)
        Me.lblPrompt.TabIndex = 0
        Me.lblPrompt.Text = "Enter an odd number:"
        '
        'txtOddNumber
        '
        Me.txtOddNumber.Location = New System.Drawing.Point(150, 24)
        Me.txtOddNumber.Name = "txtOddNumber"
        Me.txtOddNumber.Size = New System.Drawing.Size(54, 20)
        Me.txtOddNumber.TabIndex = 1
        '
        'lblOddNumberSum
        '
        Me.lblOddNumberSum.Location = New System.Drawing.Point(52, 85)
        Me.lblOddNumberSum.Name = "lblOddNumberSum"
        Me.lblOddNumberSum.Size = New System.Drawing.Size(233, 42)
        Me.lblOddNumberSum.TabIndex = 2
        '
        'btnSum
        '
        Me.btnSum.Location = New System.Drawing.Point(276, 37)
        Me.btnSum.Name = "btnSum"
        Me.btnSum.Size = New System.Drawing.Size(93, 23)
        Me.btnSum.TabIndex = 3
        Me.btnSum.Text = "Sum"
        Me.btnSum.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 181)
        Me.Controls.Add(Me.btnSum)
        Me.Controls.Add(Me.lblOddNumberSum)
        Me.Controls.Add(Me.txtOddNumber)
        Me.Controls.Add(Me.lblPrompt)
        Me.Name = "Form1"
        Me.Text = "Odd Numbers Sum"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPrompt As System.Windows.Forms.Label
    Friend WithEvents txtOddNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblOddNumberSum As System.Windows.Forms.Label
    Friend WithEvents btnSum As System.Windows.Forms.Button

End Class
