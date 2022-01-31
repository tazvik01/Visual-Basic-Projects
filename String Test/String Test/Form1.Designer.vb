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
        Me.lblFirst = New System.Windows.Forms.Label()
        Me.lblFirstLetter = New System.Windows.Forms.Label()
        Me.lblMiddle = New System.Windows.Forms.Label()
        Me.lblMiddleLetter = New System.Windows.Forms.Label()
        Me.lblLast = New System.Windows.Forms.Label()
        Me.lblLastLetter = New System.Windows.Forms.Label()
        Me.btnDisplayData = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPrompt
        '
        Me.lblPrompt.Location = New System.Drawing.Point(29, 42)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(70, 23)
        Me.lblPrompt.TabIndex = 0
        Me.lblPrompt.Text = "Enter text:"
        '
        'txtWord
        '
        Me.txtWord.Location = New System.Drawing.Point(92, 42)
        Me.txtWord.Name = "txtWord"
        Me.txtWord.Size = New System.Drawing.Size(193, 20)
        Me.txtWord.TabIndex = 1
        '
        'lblFirst
        '
        Me.lblFirst.Location = New System.Drawing.Point(29, 106)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(70, 23)
        Me.lblFirst.TabIndex = 2
        Me.lblFirst.Text = "First letter:"
        '
        'lblFirstLetter
        '
        Me.lblFirstLetter.Location = New System.Drawing.Point(89, 106)
        Me.lblFirstLetter.Name = "lblFirstLetter"
        Me.lblFirstLetter.Size = New System.Drawing.Size(54, 23)
        Me.lblFirstLetter.TabIndex = 3
        '
        'lblMiddle
        '
        Me.lblMiddle.Location = New System.Drawing.Point(29, 140)
        Me.lblMiddle.Name = "lblMiddle"
        Me.lblMiddle.Size = New System.Drawing.Size(85, 23)
        Me.lblMiddle.TabIndex = 4
        Me.lblMiddle.Text = "Middle letter:"
        '
        'lblMiddleLetter
        '
        Me.lblMiddleLetter.Location = New System.Drawing.Point(102, 140)
        Me.lblMiddleLetter.Name = "lblMiddleLetter"
        Me.lblMiddleLetter.Size = New System.Drawing.Size(56, 23)
        Me.lblMiddleLetter.TabIndex = 5
        '
        'lblLast
        '
        Me.lblLast.Location = New System.Drawing.Point(29, 177)
        Me.lblLast.Name = "lblLast"
        Me.lblLast.Size = New System.Drawing.Size(70, 23)
        Me.lblLast.TabIndex = 6
        Me.lblLast.Text = "Last letter:"
        '
        'lblLastLetter
        '
        Me.lblLastLetter.Location = New System.Drawing.Point(90, 177)
        Me.lblLastLetter.Name = "lblLastLetter"
        Me.lblLastLetter.Size = New System.Drawing.Size(68, 23)
        Me.lblLastLetter.TabIndex = 7
        '
        'btnDisplayData
        '
        Me.btnDisplayData.Location = New System.Drawing.Point(204, 186)
        Me.btnDisplayData.Name = "btnDisplayData"
        Me.btnDisplayData.Size = New System.Drawing.Size(98, 23)
        Me.btnDisplayData.TabIndex = 8
        Me.btnDisplayData.Text = "Display Data" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnDisplayData.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 238)
        Me.Controls.Add(Me.btnDisplayData)
        Me.Controls.Add(Me.lblLastLetter)
        Me.Controls.Add(Me.lblLast)
        Me.Controls.Add(Me.lblMiddleLetter)
        Me.Controls.Add(Me.lblMiddle)
        Me.Controls.Add(Me.lblFirstLetter)
        Me.Controls.Add(Me.lblFirst)
        Me.Controls.Add(Me.txtWord)
        Me.Controls.Add(Me.lblPrompt)
        Me.Name = "Form1"
        Me.Text = "String Test"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPrompt As System.Windows.Forms.Label
    Friend WithEvents txtWord As System.Windows.Forms.TextBox
    Friend WithEvents lblFirst As System.Windows.Forms.Label
    Friend WithEvents lblFirstLetter As System.Windows.Forms.Label
    Friend WithEvents lblMiddle As System.Windows.Forms.Label
    Friend WithEvents lblMiddleLetter As System.Windows.Forms.Label
    Friend WithEvents lblLast As System.Windows.Forms.Label
    Friend WithEvents lblLastLetter As System.Windows.Forms.Label
    Friend WithEvents btnDisplayData As System.Windows.Forms.Button

End Class
