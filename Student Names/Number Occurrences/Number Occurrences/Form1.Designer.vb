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
        Me.txtCount = New System.Windows.Forms.TextBox()
        Me.lblprompt = New System.Windows.Forms.Label()
        Me.btnNumCount = New System.Windows.Forms.Button()
        Me.lstnumoccur = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'txtCount
        '
        Me.txtCount.Location = New System.Drawing.Point(109, 24)
        Me.txtCount.Name = "txtCount"
        Me.txtCount.Size = New System.Drawing.Size(181, 20)
        Me.txtCount.TabIndex = 0
        '
        'lblprompt
        '
        Me.lblprompt.Location = New System.Drawing.Point(12, 24)
        Me.lblprompt.Name = "lblprompt"
        Me.lblprompt.Size = New System.Drawing.Size(91, 23)
        Me.lblprompt.TabIndex = 1
        Me.lblprompt.Text = "Enter a number;"
        '
        'btnNumCount
        '
        Me.btnNumCount.Location = New System.Drawing.Point(177, 59)
        Me.btnNumCount.Name = "btnNumCount"
        Me.btnNumCount.Size = New System.Drawing.Size(113, 23)
        Me.btnNumCount.TabIndex = 2
        Me.btnNumCount.Text = "Count Numerals"
        Me.btnNumCount.UseVisualStyleBackColor = True
        '
        'lstnumoccur
        '
        Me.lstnumoccur.FormattingEnabled = True
        Me.lstnumoccur.Location = New System.Drawing.Point(25, 58)
        Me.lstnumoccur.Name = "lstnumoccur"
        Me.lstnumoccur.Size = New System.Drawing.Size(134, 108)
        Me.lstnumoccur.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 193)
        Me.Controls.Add(Me.lstnumoccur)
        Me.Controls.Add(Me.btnNumCount)
        Me.Controls.Add(Me.lblprompt)
        Me.Controls.Add(Me.txtCount)
        Me.Name = "Form1"
        Me.Text = "Number Occurrences"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCount As System.Windows.Forms.TextBox
    Friend WithEvents lblprompt As System.Windows.Forms.Label
    Friend WithEvents btnNumCount As System.Windows.Forms.Button
    Friend WithEvents lstnumoccur As System.Windows.Forms.ListBox

End Class
