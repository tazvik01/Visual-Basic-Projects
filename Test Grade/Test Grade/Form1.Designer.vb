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
        Me.lblEnterTestGrade = New System.Windows.Forms.Label()
        Me.txtGrade = New System.Windows.Forms.TextBox()
        Me.lblStatement = New System.Windows.Forms.Label()
        Me.btnCheckGrade = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblEnterTestGrade
        '
        Me.lblEnterTestGrade.Location = New System.Drawing.Point(2, 19)
        Me.lblEnterTestGrade.Name = "lblEnterTestGrade"
        Me.lblEnterTestGrade.Size = New System.Drawing.Size(113, 27)
        Me.lblEnterTestGrade.TabIndex = 0
        Me.lblEnterTestGrade.Text = "Enter a test grade:"
        '
        'txtGrade
        '
        Me.txtGrade.Location = New System.Drawing.Point(121, 19)
        Me.txtGrade.Name = "txtGrade"
        Me.txtGrade.Size = New System.Drawing.Size(33, 20)
        Me.txtGrade.TabIndex = 1
        '
        'lblStatement
        '
        Me.lblStatement.Location = New System.Drawing.Point(72, 69)
        Me.lblStatement.Name = "lblStatement"
        Me.lblStatement.Size = New System.Drawing.Size(110, 32)
        Me.lblStatement.TabIndex = 2
        '
        'btnCheckGrade
        '
        Me.btnCheckGrade.Location = New System.Drawing.Point(54, 119)
        Me.btnCheckGrade.Name = "btnCheckGrade"
        Me.btnCheckGrade.Size = New System.Drawing.Size(100, 23)
        Me.btnCheckGrade.TabIndex = 3
        Me.btnCheckGrade.Text = "Check Grade"
        Me.btnCheckGrade.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(231, 187)
        Me.Controls.Add(Me.btnCheckGrade)
        Me.Controls.Add(Me.lblStatement)
        Me.Controls.Add(Me.txtGrade)
        Me.Controls.Add(Me.lblEnterTestGrade)
        Me.Name = "Form1"
        Me.Text = "Test Grade"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEnterTestGrade As System.Windows.Forms.Label
    Friend WithEvents txtGrade As System.Windows.Forms.TextBox
    Friend WithEvents lblStatement As System.Windows.Forms.Label
    Friend WithEvents btnCheckGrade As System.Windows.Forms.Button

End Class
