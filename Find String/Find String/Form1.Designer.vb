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
        Me.txtEnterText = New System.Windows.Forms.TextBox()
        Me.lblPormpt2 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblSearchText = New System.Windows.Forms.Label()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.btnFindString = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPrompt
        '
        Me.lblPrompt.Location = New System.Drawing.Point(31, 32)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(83, 23)
        Me.lblPrompt.TabIndex = 0
        Me.lblPrompt.Text = "Enter text:"
        '
        'txtEnterText
        '
        Me.txtEnterText.Location = New System.Drawing.Point(98, 29)
        Me.txtEnterText.Name = "txtEnterText"
        Me.txtEnterText.Size = New System.Drawing.Size(234, 20)
        Me.txtEnterText.TabIndex = 1
        '
        'lblPormpt2
        '
        Me.lblPormpt2.Location = New System.Drawing.Point(22, 80)
        Me.lblPormpt2.Name = "lblPormpt2"
        Me.lblPormpt2.Size = New System.Drawing.Size(92, 23)
        Me.lblPormpt2.TabIndex = 2
        Me.lblPormpt2.Text = "Enter search text:"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(120, 77)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(196, 20)
        Me.txtSearch.TabIndex = 3
        '
        'lblSearchText
        '
        Me.lblSearchText.Location = New System.Drawing.Point(22, 152)
        Me.lblSearchText.Name = "lblSearchText"
        Me.lblSearchText.Size = New System.Drawing.Size(119, 23)
        Me.lblSearchText.TabIndex = 4
        Me.lblSearchText.Text = "Position of search text:"
        '
        'lblPosition
        '
        Me.lblPosition.Location = New System.Drawing.Point(138, 152)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(52, 30)
        Me.lblPosition.TabIndex = 5
        '
        'btnFindString
        '
        Me.btnFindString.Location = New System.Drawing.Point(248, 159)
        Me.btnFindString.Name = "btnFindString"
        Me.btnFindString.Size = New System.Drawing.Size(102, 27)
        Me.btnFindString.TabIndex = 6
        Me.btnFindString.Text = "FindString"
        Me.btnFindString.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 214)
        Me.Controls.Add(Me.btnFindString)
        Me.Controls.Add(Me.lblPosition)
        Me.Controls.Add(Me.lblSearchText)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lblPormpt2)
        Me.Controls.Add(Me.txtEnterText)
        Me.Controls.Add(Me.lblPrompt)
        Me.Name = "Form1"
        Me.Text = "Find String"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPrompt As System.Windows.Forms.Label
    Friend WithEvents txtEnterText As System.Windows.Forms.TextBox
    Friend WithEvents lblPormpt2 As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lblSearchText As System.Windows.Forms.Label
    Friend WithEvents lblPosition As System.Windows.Forms.Label
    Friend WithEvents btnFindString As System.Windows.Forms.Button

End Class
