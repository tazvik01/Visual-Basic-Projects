﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.lblIntegerPrompt = New System.Windows.Forms.Label()
        Me.txtInteger = New System.Windows.Forms.TextBox()
        Me.lblPrimeResult = New System.Windows.Forms.Label()
        Me.btnTest = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblIntegerPrompt
        '
        Me.lblIntegerPrompt.Location = New System.Drawing.Point(12, 25)
        Me.lblIntegerPrompt.Name = "lblIntegerPrompt"
        Me.lblIntegerPrompt.Size = New System.Drawing.Size(122, 23)
        Me.lblIntegerPrompt.TabIndex = 0
        Me.lblIntegerPrompt.Text = "Enter an integer:"
        '
        'txtInteger
        '
        Me.txtInteger.Location = New System.Drawing.Point(97, 22)
        Me.txtInteger.Name = "txtInteger"
        Me.txtInteger.Size = New System.Drawing.Size(28, 20)
        Me.txtInteger.TabIndex = 1
        '
        'lblPrimeResult
        '
        Me.lblPrimeResult.Location = New System.Drawing.Point(140, 25)
        Me.lblPrimeResult.Name = "lblPrimeResult"
        Me.lblPrimeResult.Size = New System.Drawing.Size(120, 23)
        Me.lblPrimeResult.TabIndex = 2
        '
        'btnTest
        '
        Me.btnTest.Location = New System.Drawing.Point(15, 82)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(89, 26)
        Me.btnTest.TabIndex = 3
        Me.btnTest.Text = "Test"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 132)
        Me.Controls.Add(Me.btnTest)
        Me.Controls.Add(Me.lblPrimeResult)
        Me.Controls.Add(Me.txtInteger)
        Me.Controls.Add(Me.lblIntegerPrompt)
        Me.Name = "Form1"
        Me.Text = "Prime Number"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblIntegerPrompt As System.Windows.Forms.Label
    Friend WithEvents txtInteger As System.Windows.Forms.TextBox
    Friend WithEvents lblPrimeResult As System.Windows.Forms.Label
    Friend WithEvents btnTest As System.Windows.Forms.Button

End Class
