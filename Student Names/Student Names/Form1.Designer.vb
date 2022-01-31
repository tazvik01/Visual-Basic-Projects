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
        Me.lstStuNames = New System.Windows.Forms.ListBox()
        Me.btnAddNames = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstStuNames
        '
        Me.lstStuNames.FormattingEnabled = True
        Me.lstStuNames.Location = New System.Drawing.Point(12, 12)
        Me.lstStuNames.Name = "lstStuNames"
        Me.lstStuNames.Size = New System.Drawing.Size(137, 121)
        Me.lstStuNames.TabIndex = 0
        '
        'btnAddNames
        '
        Me.btnAddNames.Location = New System.Drawing.Point(173, 12)
        Me.btnAddNames.Name = "btnAddNames"
        Me.btnAddNames.Size = New System.Drawing.Size(75, 42)
        Me.btnAddNames.TabIndex = 1
        Me.btnAddNames.Text = "      Add        Names"
        Me.btnAddNames.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(270, 180)
        Me.Controls.Add(Me.btnAddNames)
        Me.Controls.Add(Me.lstStuNames)
        Me.Name = "Form1"
        Me.Text = "Student Names"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstStuNames As System.Windows.Forms.ListBox
    Friend WithEvents btnAddNames As System.Windows.Forms.Button

End Class
