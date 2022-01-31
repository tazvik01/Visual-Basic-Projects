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
        Me.lblXis = New System.Windows.Forms.Label()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.btnProc1 = New System.Windows.Forms.Button()
        Me.btnProc2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblXis
        '
        Me.lblXis.Location = New System.Drawing.Point(58, 52)
        Me.lblXis.Name = "lblXis"
        Me.lblXis.Size = New System.Drawing.Size(63, 28)
        Me.lblXis.TabIndex = 0
        Me.lblXis.Text = "X is"
        Me.lblXis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAnswer
        '
        Me.lblAnswer.Location = New System.Drawing.Point(127, 57)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(49, 18)
        Me.lblAnswer.TabIndex = 1
        Me.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnProc1
        '
        Me.btnProc1.Location = New System.Drawing.Point(47, 113)
        Me.btnProc1.Name = "btnProc1"
        Me.btnProc1.Size = New System.Drawing.Size(74, 24)
        Me.btnProc1.TabIndex = 2
        Me.btnProc1.Text = "Procedure1"
        Me.btnProc1.UseVisualStyleBackColor = True
        '
        'btnProc2
        '
        Me.btnProc2.Location = New System.Drawing.Point(155, 113)
        Me.btnProc2.Name = "btnProc2"
        Me.btnProc2.Size = New System.Drawing.Size(75, 24)
        Me.btnProc2.TabIndex = 3
        Me.btnProc2.Text = "Procedure2"
        Me.btnProc2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 145)
        Me.Controls.Add(Me.btnProc2)
        Me.Controls.Add(Me.btnProc1)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.lblXis)
        Me.Name = "Form1"
        Me.Text = "ScopeDemo"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblXis As System.Windows.Forms.Label
    Friend WithEvents lblAnswer As System.Windows.Forms.Label
    Friend WithEvents btnProc1 As System.Windows.Forms.Button
    Friend WithEvents btnProc2 As System.Windows.Forms.Button

End Class
