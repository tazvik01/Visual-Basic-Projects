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
        Me.lblPizzaSize = New System.Windows.Forms.Label()
        Me.txtSizeOfPizza = New System.Windows.Forms.TextBox()
        Me.lbltotalPizzaCost = New System.Windows.Forms.Label()
        Me.lblCostAnswer = New System.Windows.Forms.Label()
        Me.btnCost = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPizzaSize
        '
        Me.lblPizzaSize.Location = New System.Drawing.Point(2, 32)
        Me.lblPizzaSize.Name = "lblPizzaSize"
        Me.lblPizzaSize.Size = New System.Drawing.Size(181, 34)
        Me.lblPizzaSize.TabIndex = 0
        Me.lblPizzaSize.Text = "Enter the size of the pizza in inches:"
        '
        'txtSizeOfPizza
        '
        Me.txtSizeOfPizza.Location = New System.Drawing.Point(189, 32)
        Me.txtSizeOfPizza.Name = "txtSizeOfPizza"
        Me.txtSizeOfPizza.Size = New System.Drawing.Size(45, 20)
        Me.txtSizeOfPizza.TabIndex = 1
        '
        'lbltotalPizzaCost
        '
        Me.lbltotalPizzaCost.Location = New System.Drawing.Point(2, 94)
        Me.lbltotalPizzaCost.Name = "lbltotalPizzaCost"
        Me.lbltotalPizzaCost.Size = New System.Drawing.Size(168, 23)
        Me.lbltotalPizzaCost.TabIndex = 2
        Me.lbltotalPizzaCost.Text = "The totalcost of the pizza is $"
        '
        'lblCostAnswer
        '
        Me.lblCostAnswer.Location = New System.Drawing.Point(154, 94)
        Me.lblCostAnswer.Name = "lblCostAnswer"
        Me.lblCostAnswer.Size = New System.Drawing.Size(55, 23)
        Me.lblCostAnswer.TabIndex = 3
        '
        'btnCost
        '
        Me.btnCost.Location = New System.Drawing.Point(119, 130)
        Me.btnCost.Name = "btnCost"
        Me.btnCost.Size = New System.Drawing.Size(78, 23)
        Me.btnCost.TabIndex = 4
        Me.btnCost.Text = "Cost"
        Me.btnCost.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 165)
        Me.Controls.Add(Me.btnCost)
        Me.Controls.Add(Me.lblCostAnswer)
        Me.Controls.Add(Me.lbltotalPizzaCost)
        Me.Controls.Add(Me.txtSizeOfPizza)
        Me.Controls.Add(Me.lblPizzaSize)
        Me.Name = "Form1"
        Me.Text = "Pizza Cost"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPizzaSize As System.Windows.Forms.Label
    Friend WithEvents txtSizeOfPizza As System.Windows.Forms.TextBox
    Friend WithEvents lbltotalPizzaCost As System.Windows.Forms.Label
    Friend WithEvents lblCostAnswer As System.Windows.Forms.Label
    Friend WithEvents btnCost As System.Windows.Forms.Button

End Class
