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
        Me.lblOp1Promt = New System.Windows.Forms.Label()
        Me.txtOperand1 = New System.Windows.Forms.TextBox()
        Me.lblOp2Prompt = New System.Windows.Forms.Label()
        Me.txtOperand2 = New System.Windows.Forms.TextBox()
        Me.grpOperators = New System.Windows.Forms.GroupBox()
        Me.radSubtraction = New System.Windows.Forms.RadioButton()
        Me.radAddition = New System.Windows.Forms.RadioButton()
        Me.radModDivision = New System.Windows.Forms.RadioButton()
        Me.radIntDivision = New System.Windows.Forms.RadioButton()
        Me.radDivision = New System.Windows.Forms.RadioButton()
        Me.radMultiplication = New System.Windows.Forms.RadioButton()
        Me.radExponenitation = New System.Windows.Forms.RadioButton()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.lblExpressionValue = New System.Windows.Forms.Label()
        Me.grpOperators.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblOp1Promt
        '
        Me.lblOp1Promt.Location = New System.Drawing.Point(12, 17)
        Me.lblOp1Promt.Name = "lblOp1Promt"
        Me.lblOp1Promt.Size = New System.Drawing.Size(100, 28)
        Me.lblOp1Promt.TabIndex = 0
        Me.lblOp1Promt.Text = "First Operand"
        '
        'txtOperand1
        '
        Me.txtOperand1.Location = New System.Drawing.Point(110, 17)
        Me.txtOperand1.Name = "txtOperand1"
        Me.txtOperand1.Size = New System.Drawing.Size(36, 20)
        Me.txtOperand1.TabIndex = 1
        '
        'lblOp2Prompt
        '
        Me.lblOp2Prompt.Location = New System.Drawing.Point(204, 17)
        Me.lblOp2Prompt.Name = "lblOp2Prompt"
        Me.lblOp2Prompt.Size = New System.Drawing.Size(88, 28)
        Me.lblOp2Prompt.TabIndex = 2
        Me.lblOp2Prompt.Text = "Second Operand"
        '
        'txtOperand2
        '
        Me.txtOperand2.Location = New System.Drawing.Point(330, 17)
        Me.txtOperand2.Name = "txtOperand2"
        Me.txtOperand2.Size = New System.Drawing.Size(38, 20)
        Me.txtOperand2.TabIndex = 3
        '
        'grpOperators
        '
        Me.grpOperators.Controls.Add(Me.radSubtraction)
        Me.grpOperators.Controls.Add(Me.radAddition)
        Me.grpOperators.Controls.Add(Me.radModDivision)
        Me.grpOperators.Controls.Add(Me.radIntDivision)
        Me.grpOperators.Controls.Add(Me.radDivision)
        Me.grpOperators.Controls.Add(Me.radMultiplication)
        Me.grpOperators.Controls.Add(Me.radExponenitation)
        Me.grpOperators.Location = New System.Drawing.Point(31, 70)
        Me.grpOperators.Name = "grpOperators"
        Me.grpOperators.Size = New System.Drawing.Size(432, 99)
        Me.grpOperators.TabIndex = 4
        Me.grpOperators.TabStop = False
        Me.grpOperators.Text = "Select an Operator"
        '
        'radSubtraction
        '
        Me.radSubtraction.AutoSize = True
        Me.radSubtraction.Location = New System.Drawing.Point(337, 42)
        Me.radSubtraction.Name = "radSubtraction"
        Me.radSubtraction.Size = New System.Drawing.Size(28, 17)
        Me.radSubtraction.TabIndex = 6
        Me.radSubtraction.TabStop = True
        Me.radSubtraction.Text = "-"
        Me.radSubtraction.UseVisualStyleBackColor = True
        '
        'radAddition
        '
        Me.radAddition.AutoSize = True
        Me.radAddition.Location = New System.Drawing.Point(300, 42)
        Me.radAddition.Name = "radAddition"
        Me.radAddition.Size = New System.Drawing.Size(31, 17)
        Me.radAddition.TabIndex = 5
        Me.radAddition.TabStop = True
        Me.radAddition.Text = "+"
        Me.radAddition.UseVisualStyleBackColor = True
        '
        'radModDivision
        '
        Me.radModDivision.AutoSize = True
        Me.radModDivision.Location = New System.Drawing.Point(234, 42)
        Me.radModDivision.Name = "radModDivision"
        Me.radModDivision.Size = New System.Drawing.Size(46, 17)
        Me.radModDivision.TabIndex = 4
        Me.radModDivision.TabStop = True
        Me.radModDivision.Text = "Mod"
        Me.radModDivision.UseVisualStyleBackColor = True
        '
        'radIntDivision
        '
        Me.radIntDivision.AutoSize = True
        Me.radIntDivision.Location = New System.Drawing.Point(182, 42)
        Me.radIntDivision.Name = "radIntDivision"
        Me.radIntDivision.Size = New System.Drawing.Size(30, 17)
        Me.radIntDivision.TabIndex = 3
        Me.radIntDivision.TabStop = True
        Me.radIntDivision.Text = "\"
        Me.radIntDivision.UseVisualStyleBackColor = True
        '
        'radDivision
        '
        Me.radDivision.AutoSize = True
        Me.radDivision.Location = New System.Drawing.Point(126, 42)
        Me.radDivision.Name = "radDivision"
        Me.radDivision.Size = New System.Drawing.Size(30, 17)
        Me.radDivision.TabIndex = 2
        Me.radDivision.TabStop = True
        Me.radDivision.Text = "/"
        Me.radDivision.UseVisualStyleBackColor = True
        '
        'radMultiplication
        '
        Me.radMultiplication.AutoSize = True
        Me.radMultiplication.Location = New System.Drawing.Point(73, 41)
        Me.radMultiplication.Name = "radMultiplication"
        Me.radMultiplication.Size = New System.Drawing.Size(29, 17)
        Me.radMultiplication.TabIndex = 1
        Me.radMultiplication.TabStop = True
        Me.radMultiplication.Text = "*"
        Me.radMultiplication.UseVisualStyleBackColor = True
        '
        'radExponenitation
        '
        Me.radExponenitation.AutoSize = True
        Me.radExponenitation.Location = New System.Drawing.Point(12, 39)
        Me.radExponenitation.Name = "radExponenitation"
        Me.radExponenitation.Size = New System.Drawing.Size(31, 17)
        Me.radExponenitation.TabIndex = 0
        Me.radExponenitation.TabStop = True
        Me.radExponenitation.Text = "^"
        Me.radExponenitation.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.Location = New System.Drawing.Point(30, 197)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(82, 15)
        Me.lblResult.TabIndex = 5
        Me.lblResult.Text = "Result:"
        '
        'lblExpressionValue
        '
        Me.lblExpressionValue.Location = New System.Drawing.Point(84, 197)
        Me.lblExpressionValue.Name = "lblExpressionValue"
        Me.lblExpressionValue.Size = New System.Drawing.Size(72, 18)
        Me.lblExpressionValue.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 267)
        Me.Controls.Add(Me.lblExpressionValue)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.grpOperators)
        Me.Controls.Add(Me.txtOperand2)
        Me.Controls.Add(Me.lblOp2Prompt)
        Me.Controls.Add(Me.txtOperand1)
        Me.Controls.Add(Me.lblOp1Promt)
        Me.Name = "Form1"
        Me.Text = "Calculator"
        Me.grpOperators.ResumeLayout(False)
        Me.grpOperators.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblOp1Promt As System.Windows.Forms.Label
    Friend WithEvents txtOperand1 As System.Windows.Forms.TextBox
    Friend WithEvents lblOp2Prompt As System.Windows.Forms.Label
    Friend WithEvents txtOperand2 As System.Windows.Forms.TextBox
    Friend WithEvents grpOperators As System.Windows.Forms.GroupBox
    Friend WithEvents radSubtraction As System.Windows.Forms.RadioButton
    Friend WithEvents radAddition As System.Windows.Forms.RadioButton
    Friend WithEvents radModDivision As System.Windows.Forms.RadioButton
    Friend WithEvents radIntDivision As System.Windows.Forms.RadioButton
    Friend WithEvents radDivision As System.Windows.Forms.RadioButton
    Friend WithEvents radMultiplication As System.Windows.Forms.RadioButton
    Friend WithEvents radExponenitation As System.Windows.Forms.RadioButton
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents lblExpressionValue As System.Windows.Forms.Label

End Class
