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
        Me.txtFirstNumber = New System.Windows.Forms.TextBox()
        Me.lblSecondPrompt = New System.Windows.Forms.Label()
        Me.txtSecondNumber = New System.Windows.Forms.TextBox()
        Me.btnSort = New System.Windows.Forms.Button()
        Me.lblSortedNumber = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblPrompt
        '
        Me.lblPrompt.Location = New System.Drawing.Point(21, 39)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(112, 25)
        Me.lblPrompt.TabIndex = 0
        Me.lblPrompt.Text = "Enter first number:"
        '
        'txtFirstNumber
        '
        Me.txtFirstNumber.Location = New System.Drawing.Point(172, 39)
        Me.txtFirstNumber.Name = "txtFirstNumber"
        Me.txtFirstNumber.Size = New System.Drawing.Size(69, 20)
        Me.txtFirstNumber.TabIndex = 1
        '
        'lblSecondPrompt
        '
        Me.lblSecondPrompt.Location = New System.Drawing.Point(21, 79)
        Me.lblSecondPrompt.Name = "lblSecondPrompt"
        Me.lblSecondPrompt.Size = New System.Drawing.Size(127, 23)
        Me.lblSecondPrompt.TabIndex = 2
        Me.lblSecondPrompt.Text = "Enter second number:"
        '
        'txtSecondNumber
        '
        Me.txtSecondNumber.Location = New System.Drawing.Point(172, 76)
        Me.txtSecondNumber.Name = "txtSecondNumber"
        Me.txtSecondNumber.Size = New System.Drawing.Size(69, 20)
        Me.txtSecondNumber.TabIndex = 3
        '
        'btnSort
        '
        Me.btnSort.Location = New System.Drawing.Point(24, 169)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(82, 25)
        Me.btnSort.TabIndex = 4
        Me.btnSort.Text = "Sort"
        Me.btnSort.UseVisualStyleBackColor = True
        '
        'lblSortedNumber
        '
        Me.lblSortedNumber.Location = New System.Drawing.Point(169, 169)
        Me.lblSortedNumber.Name = "lblSortedNumber"
        Me.lblSortedNumber.Size = New System.Drawing.Size(100, 29)
        Me.lblSortedNumber.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(291, 224)
        Me.Controls.Add(Me.lblSortedNumber)
        Me.Controls.Add(Me.btnSort)
        Me.Controls.Add(Me.txtSecondNumber)
        Me.Controls.Add(Me.lblSecondPrompt)
        Me.Controls.Add(Me.txtFirstNumber)
        Me.Controls.Add(Me.lblPrompt)
        Me.Name = "Form1"
        Me.Text = "Sort Numbers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPrompt As System.Windows.Forms.Label
    Friend WithEvents txtFirstNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblSecondPrompt As System.Windows.Forms.Label
    Friend WithEvents txtSecondNumber As System.Windows.Forms.TextBox
    Friend WithEvents btnSort As System.Windows.Forms.Button
    Friend WithEvents lblSortedNumber As System.Windows.Forms.Label

End Class
