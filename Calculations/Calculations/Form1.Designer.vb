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
        Me.btnExpression1 = New System.Windows.Forms.Button()
        Me.lblExpression1 = New System.Windows.Forms.Label()
        Me.btnExpression2 = New System.Windows.Forms.Button()
        Me.lblExpression2 = New System.Windows.Forms.Label()
        Me.lblExpression3 = New System.Windows.Forms.Label()
        Me.btnExpression3 = New System.Windows.Forms.Button()
        Me.lblExpression4 = New System.Windows.Forms.Label()
        Me.btnExpression4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnExpression1
        '
        Me.btnExpression1.Location = New System.Drawing.Point(19, 26)
        Me.btnExpression1.Name = "btnExpression1"
        Me.btnExpression1.Size = New System.Drawing.Size(61, 22)
        Me.btnExpression1.TabIndex = 0
        Me.btnExpression1.Text = "5+2^3"
        Me.btnExpression1.UseVisualStyleBackColor = True
        '
        'lblExpression1
        '
        Me.lblExpression1.AutoSize = True
        Me.lblExpression1.Location = New System.Drawing.Point(126, 31)
        Me.lblExpression1.Name = "lblExpression1"
        Me.lblExpression1.Size = New System.Drawing.Size(39, 13)
        Me.lblExpression1.TabIndex = 1
        Me.lblExpression1.Text = "Label1"
        Me.lblExpression1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExpression2
        '
        Me.btnExpression2.Location = New System.Drawing.Point(18, 74)
        Me.btnExpression2.Name = "btnExpression2"
        Me.btnExpression2.Size = New System.Drawing.Size(61, 22)
        Me.btnExpression2.TabIndex = 2
        Me.btnExpression2.Text = "4/2+5"
        Me.btnExpression2.UseVisualStyleBackColor = True
        '
        'lblExpression2
        '
        Me.lblExpression2.AutoSize = True
        Me.lblExpression2.Location = New System.Drawing.Point(126, 83)
        Me.lblExpression2.Name = "lblExpression2"
        Me.lblExpression2.Size = New System.Drawing.Size(39, 13)
        Me.lblExpression2.TabIndex = 3
        Me.lblExpression2.Text = "Label2"
        Me.lblExpression2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblExpression3
        '
        Me.lblExpression3.AutoSize = True
        Me.lblExpression3.Location = New System.Drawing.Point(126, 134)
        Me.lblExpression3.Name = "lblExpression3"
        Me.lblExpression3.Size = New System.Drawing.Size(39, 13)
        Me.lblExpression3.TabIndex = 4
        Me.lblExpression3.Text = "Label3"
        Me.lblExpression3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExpression3
        '
        Me.btnExpression3.Location = New System.Drawing.Point(22, 125)
        Me.btnExpression3.Name = "btnExpression3"
        Me.btnExpression3.Size = New System.Drawing.Size(57, 21)
        Me.btnExpression3.TabIndex = 5
        Me.btnExpression3.Text = "3+4*2"
        Me.btnExpression3.UseVisualStyleBackColor = True
        '
        'lblExpression4
        '
        Me.lblExpression4.AutoSize = True
        Me.lblExpression4.Location = New System.Drawing.Point(126, 182)
        Me.lblExpression4.Name = "lblExpression4"
        Me.lblExpression4.Size = New System.Drawing.Size(39, 13)
        Me.lblExpression4.TabIndex = 6
        Me.lblExpression4.Text = "Label4"
        Me.lblExpression4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExpression4
        '
        Me.btnExpression4.Location = New System.Drawing.Point(14, 182)
        Me.btnExpression4.Name = "btnExpression4"
        Me.btnExpression4.Size = New System.Drawing.Size(65, 20)
        Me.btnExpression4.TabIndex = 7
        Me.btnExpression4.Text = "7-3+2"
        Me.btnExpression4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnExpression4)
        Me.Controls.Add(Me.lblExpression4)
        Me.Controls.Add(Me.btnExpression3)
        Me.Controls.Add(Me.lblExpression3)
        Me.Controls.Add(Me.lblExpression2)
        Me.Controls.Add(Me.btnExpression2)
        Me.Controls.Add(Me.lblExpression1)
        Me.Controls.Add(Me.btnExpression1)
        Me.Name = "Form1"
        Me.Text = "Calculation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExpression1 As System.Windows.Forms.Button
    Friend WithEvents lblExpression1 As System.Windows.Forms.Label
    Friend WithEvents btnExpression2 As System.Windows.Forms.Button
    Friend WithEvents lblExpression2 As System.Windows.Forms.Label
    Friend WithEvents lblExpression3 As System.Windows.Forms.Label
    Friend WithEvents btnExpression3 As System.Windows.Forms.Button
    Friend WithEvents lblExpression4 As System.Windows.Forms.Label
    Friend WithEvents btnExpression4 As System.Windows.Forms.Button

End Class
