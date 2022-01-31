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
        Me.btnTip = New System.Windows.Forms.Button()
        Me.lblTip = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnTip
        '
        Me.btnTip.Location = New System.Drawing.Point(209, 100)
        Me.btnTip.Name = "btnTip"
        Me.btnTip.Size = New System.Drawing.Size(75, 23)
        Me.btnTip.TabIndex = 1
        Me.btnTip.Text = "Tip"
        Me.btnTip.UseVisualStyleBackColor = True
        '
        'lblTip
        '
        Me.lblTip.Location = New System.Drawing.Point(123, 45)
        Me.lblTip.Name = "lblTip"
        Me.lblTip.Size = New System.Drawing.Size(313, 40)
        Me.lblTip.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 135)
        Me.Controls.Add(Me.lblTip)
        Me.Controls.Add(Me.btnTip)
        Me.Name = "Form1"
        Me.Text = "Diskette Tips"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnTip As System.Windows.Forms.Button
    Friend WithEvents lblTip As System.Windows.Forms.Label

End Class
