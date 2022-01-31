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
        Me.txtWord = New System.Windows.Forms.TextBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtLetter = New System.Windows.Forms.TextBox()
        Me.lblStatement = New System.Windows.Forms.Label()
        Me.lblNumberOfOccurence = New System.Windows.Forms.Label()
        Me.btnCountLetter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPrompt
        '
        Me.lblPrompt.Location = New System.Drawing.Point(12, 27)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(130, 23)
        Me.lblPrompt.TabIndex = 0
        Me.lblPrompt.Text = "Enter text:"
        '
        'txtWord
        '
        Me.txtWord.Location = New System.Drawing.Point(67, 24)
        Me.txtWord.Name = "txtWord"
        Me.txtWord.Size = New System.Drawing.Size(119, 20)
        Me.txtWord.TabIndex = 1
        '
        'lblSearch
        '
        Me.lblSearch.Location = New System.Drawing.Point(262, 21)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(141, 23)
        Me.lblSearch.TabIndex = 2
        Me.lblSearch.Text = "Enter letter to search for:"
        '
        'txtLetter
        '
        Me.txtLetter.Location = New System.Drawing.Point(390, 21)
        Me.txtLetter.Name = "txtLetter"
        Me.txtLetter.Size = New System.Drawing.Size(30, 20)
        Me.txtLetter.TabIndex = 3
        '
        'lblStatement
        '
        Me.lblStatement.Location = New System.Drawing.Point(12, 94)
        Me.lblStatement.Name = "lblStatement"
        Me.lblStatement.Size = New System.Drawing.Size(185, 21)
        Me.lblStatement.TabIndex = 4
        Me.lblStatement.Text = "Number of times the letter occurs:"
        Me.lblStatement.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblNumberOfOccurence
        '
        Me.lblNumberOfOccurence.Location = New System.Drawing.Point(192, 94)
        Me.lblNumberOfOccurence.Name = "lblNumberOfOccurence"
        Me.lblNumberOfOccurence.Size = New System.Drawing.Size(51, 23)
        Me.lblNumberOfOccurence.TabIndex = 5
        '
        'btnCountLetter
        '
        Me.btnCountLetter.Location = New System.Drawing.Point(347, 65)
        Me.btnCountLetter.Name = "btnCountLetter"
        Me.btnCountLetter.Size = New System.Drawing.Size(99, 26)
        Me.btnCountLetter.TabIndex = 6
        Me.btnCountLetter.Text = "Count Letter"
        Me.btnCountLetter.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 135)
        Me.Controls.Add(Me.btnCountLetter)
        Me.Controls.Add(Me.lblNumberOfOccurence)
        Me.Controls.Add(Me.lblStatement)
        Me.Controls.Add(Me.txtLetter)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.txtWord)
        Me.Controls.Add(Me.lblPrompt)
        Me.Name = "Form1"
        Me.Text = "Letter Count"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPrompt As System.Windows.Forms.Label
    Friend WithEvents txtWord As System.Windows.Forms.TextBox
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents txtLetter As System.Windows.Forms.TextBox
    Friend WithEvents lblStatement As System.Windows.Forms.Label
    Friend WithEvents lblNumberOfOccurence As System.Windows.Forms.Label
    Friend WithEvents btnCountLetter As System.Windows.Forms.Button

End Class
