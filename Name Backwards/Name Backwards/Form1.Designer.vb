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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnDisplayBackwards = New System.Windows.Forms.Button()
        Me.lblBackwards = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblPrompt
        '
        Me.lblPrompt.Location = New System.Drawing.Point(21, 22)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(83, 26)
        Me.lblPrompt.TabIndex = 0
        Me.lblPrompt.Text = "Enter a name:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(101, 22)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(191, 20)
        Me.txtName.TabIndex = 1
        '
        'btnDisplayBackwards
        '
        Me.btnDisplayBackwards.Location = New System.Drawing.Point(101, 123)
        Me.btnDisplayBackwards.Name = "btnDisplayBackwards"
        Me.btnDisplayBackwards.Size = New System.Drawing.Size(138, 27)
        Me.btnDisplayBackwards.TabIndex = 2
        Me.btnDisplayBackwards.Text = "Display Backwards"
        Me.btnDisplayBackwards.UseVisualStyleBackColor = True
        '
        'lblBackwards
        '
        Me.lblBackwards.Enabled = False
        Me.lblBackwards.Location = New System.Drawing.Point(107, 69)
        Me.lblBackwards.Name = "lblBackwards"
        Me.lblBackwards.Size = New System.Drawing.Size(199, 30)
        Me.lblBackwards.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 162)
        Me.Controls.Add(Me.lblBackwards)
        Me.Controls.Add(Me.btnDisplayBackwards)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblPrompt)
        Me.Name = "Form1"
        Me.Text = "Name Backwards"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPrompt As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents btnDisplayBackwards As System.Windows.Forms.Button
    Friend WithEvents lblBackwards As System.Windows.Forms.Label

End Class
