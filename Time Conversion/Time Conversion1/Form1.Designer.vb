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
        Me.grpCoversions = New System.Windows.Forms.GroupBox()
        Me.rdnMinuteFormat = New System.Windows.Forms.RadioButton()
        Me.rdnMinutesToSeconds = New System.Windows.Forms.RadioButton()
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.txtMinutes = New System.Windows.Forms.TextBox()
        Me.lblStatement = New System.Windows.Forms.Label()
        Me.lblTimeInHour = New System.Windows.Forms.Label()
        Me.lblTimeInMinute = New System.Windows.Forms.Label()
        Me.grpCoversions.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpCoversions
        '
        Me.grpCoversions.Controls.Add(Me.rdnMinuteFormat)
        Me.grpCoversions.Controls.Add(Me.rdnMinutesToSeconds)
        Me.grpCoversions.Location = New System.Drawing.Point(12, 99)
        Me.grpCoversions.Name = "grpCoversions"
        Me.grpCoversions.Size = New System.Drawing.Size(287, 87)
        Me.grpCoversions.TabIndex = 0
        Me.grpCoversions.TabStop = False
        Me.grpCoversions.Text = "Select time Conversion"
        '
        'rdnMinuteFormat
        '
        Me.rdnMinuteFormat.Location = New System.Drawing.Point(148, 19)
        Me.rdnMinuteFormat.Name = "rdnMinuteFormat"
        Me.rdnMinuteFormat.Size = New System.Drawing.Size(133, 43)
        Me.rdnMinuteFormat.TabIndex = 1
        Me.rdnMinuteFormat.TabStop = True
        Me.rdnMinuteFormat.Text = "Minutes to" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "hour: minute format" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.rdnMinuteFormat.UseVisualStyleBackColor = True
        '
        'rdnMinutesToSeconds
        '
        Me.rdnMinutesToSeconds.Location = New System.Drawing.Point(12, 22)
        Me.rdnMinutesToSeconds.Name = "rdnMinutesToSeconds"
        Me.rdnMinutesToSeconds.Size = New System.Drawing.Size(130, 40)
        Me.rdnMinutesToSeconds.TabIndex = 0
        Me.rdnMinutesToSeconds.TabStop = True
        Me.rdnMinutesToSeconds.Text = "Minutes to " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "seconds"
        Me.rdnMinutesToSeconds.UseVisualStyleBackColor = True
        '
        'lblPrompt
        '
        Me.lblPrompt.Location = New System.Drawing.Point(12, 37)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(201, 23)
        Me.lblPrompt.TabIndex = 1
        Me.lblPrompt.Text = "Enter the time in minutes:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtMinutes
        '
        Me.txtMinutes.Location = New System.Drawing.Point(163, 37)
        Me.txtMinutes.Name = "txtMinutes"
        Me.txtMinutes.Size = New System.Drawing.Size(39, 20)
        Me.txtMinutes.TabIndex = 2
        '
        'lblStatement
        '
        Me.lblStatement.Location = New System.Drawing.Point(9, 214)
        Me.lblStatement.Name = "lblStatement"
        Me.lblStatement.Size = New System.Drawing.Size(182, 27)
        Me.lblStatement.TabIndex = 3
        Me.lblStatement.Text = "The time in hour: minute format is:"
        '
        'lblTimeInHour
        '
        Me.lblTimeInHour.Location = New System.Drawing.Point(181, 214)
        Me.lblTimeInHour.Name = "lblTimeInHour"
        Me.lblTimeInHour.Size = New System.Drawing.Size(43, 22)
        Me.lblTimeInHour.TabIndex = 4
        '
        'lblTimeInMinute
        '
        Me.lblTimeInMinute.Location = New System.Drawing.Point(247, 214)
        Me.lblTimeInMinute.Name = "lblTimeInMinute"
        Me.lblTimeInMinute.Size = New System.Drawing.Size(46, 22)
        Me.lblTimeInMinute.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 261)
        Me.Controls.Add(Me.lblTimeInMinute)
        Me.Controls.Add(Me.lblTimeInHour)
        Me.Controls.Add(Me.lblStatement)
        Me.Controls.Add(Me.txtMinutes)
        Me.Controls.Add(Me.lblPrompt)
        Me.Controls.Add(Me.grpCoversions)
        Me.Name = "Form1"
        Me.Text = "Time Conversion"
        Me.grpCoversions.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpCoversions As System.Windows.Forms.GroupBox
    Friend WithEvents rdnMinuteFormat As System.Windows.Forms.RadioButton
    Friend WithEvents rdnMinutesToSeconds As System.Windows.Forms.RadioButton
    Friend WithEvents lblPrompt As System.Windows.Forms.Label
    Friend WithEvents txtMinutes As System.Windows.Forms.TextBox
    Friend WithEvents lblStatement As System.Windows.Forms.Label
    Friend WithEvents lblTimeInHour As System.Windows.Forms.Label
    Friend WithEvents lblTimeInMinute As System.Windows.Forms.Label

End Class
