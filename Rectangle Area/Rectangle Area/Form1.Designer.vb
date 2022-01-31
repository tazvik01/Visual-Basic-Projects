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
        Me.lblRectanglelength = New System.Windows.Forms.Label()
        Me.txtRectanglelength = New System.Windows.Forms.TextBox()
        Me.lblRactanglewidth = New System.Windows.Forms.Label()
        Me.txtRectanglewidth = New System.Windows.Forms.TextBox()
        Me.btnAnswer = New System.Windows.Forms.Button()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblRectanglelength
        '
        Me.lblRectanglelength.Location = New System.Drawing.Point(12, 24)
        Me.lblRectanglelength.Name = "lblRectanglelength"
        Me.lblRectanglelength.Size = New System.Drawing.Size(162, 34)
        Me.lblRectanglelength.TabIndex = 0
        Me.lblRectanglelength.Text = "Enter the length of the rectangle:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtRectanglelength
        '
        Me.txtRectanglelength.Location = New System.Drawing.Point(181, 24)
        Me.txtRectanglelength.Name = "txtRectanglelength"
        Me.txtRectanglelength.Size = New System.Drawing.Size(45, 20)
        Me.txtRectanglelength.TabIndex = 1
        '
        'lblRactanglewidth
        '
        Me.lblRactanglewidth.AutoSize = True
        Me.lblRactanglewidth.Location = New System.Drawing.Point(7, 73)
        Me.lblRactanglewidth.Name = "lblRactanglewidth"
        Me.lblRactanglewidth.Size = New System.Drawing.Size(158, 13)
        Me.lblRactanglewidth.TabIndex = 2
        Me.lblRactanglewidth.Text = "Enter the width of the rectangle:"
        '
        'txtRectanglewidth
        '
        Me.txtRectanglewidth.Location = New System.Drawing.Point(181, 70)
        Me.txtRectanglewidth.Name = "txtRectanglewidth"
        Me.txtRectanglewidth.Size = New System.Drawing.Size(45, 20)
        Me.txtRectanglewidth.TabIndex = 3
        '
        'btnAnswer
        '
        Me.btnAnswer.Location = New System.Drawing.Point(156, 125)
        Me.btnAnswer.Name = "btnAnswer"
        Me.btnAnswer.Size = New System.Drawing.Size(70, 22)
        Me.btnAnswer.TabIndex = 4
        Me.btnAnswer.Text = "Answer"
        Me.btnAnswer.UseVisualStyleBackColor = True
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Location = New System.Drawing.Point(7, 134)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(35, 13)
        Me.lblArea.TabIndex = 5
        Me.lblArea.Text = "Area="
        '
        'lblAnswer
        '
        Me.lblAnswer.Location = New System.Drawing.Point(39, 134)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(62, 22)
        Me.lblAnswer.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.lblArea)
        Me.Controls.Add(Me.btnAnswer)
        Me.Controls.Add(Me.txtRectanglewidth)
        Me.Controls.Add(Me.lblRactanglewidth)
        Me.Controls.Add(Me.txtRectanglelength)
        Me.Controls.Add(Me.lblRectanglelength)
        Me.Name = "Form1"
        Me.Text = "Rectangle Area"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblRectanglelength As System.Windows.Forms.Label
    Friend WithEvents txtRectanglelength As System.Windows.Forms.TextBox
    Friend WithEvents lblRactanglewidth As System.Windows.Forms.Label
    Friend WithEvents txtRectanglewidth As System.Windows.Forms.TextBox
    Friend WithEvents btnAnswer As System.Windows.Forms.Button
    Friend WithEvents lblArea As System.Windows.Forms.Label
    Friend WithEvents lblAnswer As System.Windows.Forms.Label

End Class
