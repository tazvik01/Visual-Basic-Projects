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
        Me.lblFirstNumber = New System.Windows.Forms.Label()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.btnNewProblem = New System.Windows.Forms.Button()
        Me.btnCheckAnswer = New System.Windows.Forms.Button()
        Me.btnShowAnswer = New System.Windows.Forms.Button()
        Me.lblStatement = New System.Windows.Forms.Label()
        Me.lblOperator = New System.Windows.Forms.Label()
        Me.lblSecondNumber = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblFirstNumber
        '
        Me.lblFirstNumber.Location = New System.Drawing.Point(9, 51)
        Me.lblFirstNumber.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFirstNumber.Name = "lblFirstNumber"
        Me.lblFirstNumber.Size = New System.Drawing.Size(35, 35)
        Me.lblFirstNumber.TabIndex = 0
        Me.lblFirstNumber.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtAnswer
        '
        Me.txtAnswer.Location = New System.Drawing.Point(188, 49)
        Me.txtAnswer.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(37, 20)
        Me.txtAnswer.TabIndex = 1
        '
        'btnNewProblem
        '
        Me.btnNewProblem.Location = New System.Drawing.Point(285, 21)
        Me.btnNewProblem.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnNewProblem.Name = "btnNewProblem"
        Me.btnNewProblem.Size = New System.Drawing.Size(93, 25)
        Me.btnNewProblem.TabIndex = 2
        Me.btnNewProblem.Text = "New Problem"
        Me.btnNewProblem.UseVisualStyleBackColor = True
        '
        'btnCheckAnswer
        '
        Me.btnCheckAnswer.Location = New System.Drawing.Point(285, 67)
        Me.btnCheckAnswer.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCheckAnswer.Name = "btnCheckAnswer"
        Me.btnCheckAnswer.Size = New System.Drawing.Size(93, 26)
        Me.btnCheckAnswer.TabIndex = 3
        Me.btnCheckAnswer.Text = "Check Answer"
        Me.btnCheckAnswer.UseVisualStyleBackColor = True
        '
        'btnShowAnswer
        '
        Me.btnShowAnswer.Location = New System.Drawing.Point(285, 113)
        Me.btnShowAnswer.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnShowAnswer.Name = "btnShowAnswer"
        Me.btnShowAnswer.Size = New System.Drawing.Size(93, 26)
        Me.btnShowAnswer.TabIndex = 4
        Me.btnShowAnswer.Text = "Show Answer" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnShowAnswer.UseVisualStyleBackColor = True
        '
        'lblStatement
        '
        Me.lblStatement.Location = New System.Drawing.Point(9, 128)
        Me.lblStatement.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblStatement.Name = "lblStatement"
        Me.lblStatement.Size = New System.Drawing.Size(126, 28)
        Me.lblStatement.TabIndex = 5
        '
        'lblOperator
        '
        Me.lblOperator.Location = New System.Drawing.Point(59, 67)
        Me.lblOperator.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOperator.Name = "lblOperator"
        Me.lblOperator.Size = New System.Drawing.Size(38, 19)
        Me.lblOperator.TabIndex = 6
        '
        'lblSecondNumber
        '
        Me.lblSecondNumber.Location = New System.Drawing.Point(111, 51)
        Me.lblSecondNumber.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSecondNumber.Name = "lblSecondNumber"
        Me.lblSecondNumber.Size = New System.Drawing.Size(35, 35)
        Me.lblSecondNumber.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 181)
        Me.Controls.Add(Me.lblSecondNumber)
        Me.Controls.Add(Me.lblOperator)
        Me.Controls.Add(Me.lblStatement)
        Me.Controls.Add(Me.btnShowAnswer)
        Me.Controls.Add(Me.btnCheckAnswer)
        Me.Controls.Add(Me.btnNewProblem)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.lblFirstNumber)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.Text = "Math Tutor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFirstNumber As System.Windows.Forms.Label
    Friend WithEvents txtAnswer As System.Windows.Forms.TextBox
    Friend WithEvents btnNewProblem As System.Windows.Forms.Button
    Friend WithEvents btnCheckAnswer As System.Windows.Forms.Button
    Friend WithEvents btnShowAnswer As System.Windows.Forms.Button
    Friend WithEvents lblStatement As System.Windows.Forms.Label
    Friend WithEvents lblOperator As System.Windows.Forms.Label
    Friend WithEvents lblSecondNumber As System.Windows.Forms.Label

End Class
