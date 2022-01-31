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
        Me.btnEnterTemparatures = New System.Windows.Forms.Button()
        Me.lblAverageTemp = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnEnterTemparatures
        '
        Me.btnEnterTemparatures.Location = New System.Drawing.Point(12, 38)
        Me.btnEnterTemparatures.Name = "btnEnterTemparatures"
        Me.btnEnterTemparatures.Size = New System.Drawing.Size(133, 41)
        Me.btnEnterTemparatures.TabIndex = 0
        Me.btnEnterTemparatures.Text = "Enter" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Temperatures"
        Me.btnEnterTemparatures.UseVisualStyleBackColor = True
        '
        'lblAverageTemp
        '
        Me.lblAverageTemp.Location = New System.Drawing.Point(151, 38)
        Me.lblAverageTemp.Name = "lblAverageTemp"
        Me.lblAverageTemp.Size = New System.Drawing.Size(302, 38)
        Me.lblAverageTemp.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 131)
        Me.Controls.Add(Me.lblAverageTemp)
        Me.Controls.Add(Me.btnEnterTemparatures)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnEnterTemparatures As System.Windows.Forms.Button
    Friend WithEvents lblAverageTemp As System.Windows.Forms.Label

End Class
