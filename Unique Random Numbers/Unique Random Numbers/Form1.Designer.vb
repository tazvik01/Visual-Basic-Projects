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
        Me.btnGenerateNumbers = New System.Windows.Forms.Button()
        Me.lblStatement = New System.Windows.Forms.Label()
        Me.lblLoopCounter = New System.Windows.Forms.Label()
        Me.lblUniqueNumber1 = New System.Windows.Forms.Label()
        Me.lblUniqueNumber2 = New System.Windows.Forms.Label()
        Me.lblUniqueNumber3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnGenerateNumbers
        '
        Me.btnGenerateNumbers.Location = New System.Drawing.Point(93, 212)
        Me.btnGenerateNumbers.Name = "btnGenerateNumbers"
        Me.btnGenerateNumbers.Size = New System.Drawing.Size(129, 26)
        Me.btnGenerateNumbers.TabIndex = 0
        Me.btnGenerateNumbers.Text = "Generate Numbers"
        Me.btnGenerateNumbers.UseVisualStyleBackColor = True
        '
        'lblStatement
        '
        Me.lblStatement.Location = New System.Drawing.Point(90, 161)
        Me.lblStatement.Name = "lblStatement"
        Me.lblStatement.Size = New System.Drawing.Size(190, 48)
        Me.lblStatement.TabIndex = 1
        Me.lblStatement.Text = "loop iterations were needed to generate three unique numbers."
        '
        'lblLoopCounter
        '
        Me.lblLoopCounter.Location = New System.Drawing.Point(47, 161)
        Me.lblLoopCounter.Name = "lblLoopCounter"
        Me.lblLoopCounter.Size = New System.Drawing.Size(26, 24)
        Me.lblLoopCounter.TabIndex = 2
        '
        'lblUniqueNumber1
        '
        Me.lblUniqueNumber1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUniqueNumber1.Location = New System.Drawing.Point(25, 35)
        Me.lblUniqueNumber1.Name = "lblUniqueNumber1"
        Me.lblUniqueNumber1.Size = New System.Drawing.Size(80, 78)
        Me.lblUniqueNumber1.TabIndex = 3
        '
        'lblUniqueNumber2
        '
        Me.lblUniqueNumber2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUniqueNumber2.Location = New System.Drawing.Point(111, 35)
        Me.lblUniqueNumber2.Name = "lblUniqueNumber2"
        Me.lblUniqueNumber2.Size = New System.Drawing.Size(78, 78)
        Me.lblUniqueNumber2.TabIndex = 4
        '
        'lblUniqueNumber3
        '
        Me.lblUniqueNumber3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUniqueNumber3.Location = New System.Drawing.Point(218, 35)
        Me.lblUniqueNumber3.Name = "lblUniqueNumber3"
        Me.lblUniqueNumber3.Size = New System.Drawing.Size(77, 78)
        Me.lblUniqueNumber3.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(321, 250)
        Me.Controls.Add(Me.lblUniqueNumber3)
        Me.Controls.Add(Me.lblUniqueNumber2)
        Me.Controls.Add(Me.lblUniqueNumber1)
        Me.Controls.Add(Me.lblLoopCounter)
        Me.Controls.Add(Me.lblStatement)
        Me.Controls.Add(Me.btnGenerateNumbers)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnGenerateNumbers As System.Windows.Forms.Button
    Friend WithEvents lblStatement As System.Windows.Forms.Label
    Friend WithEvents lblLoopCounter As System.Windows.Forms.Label
    Friend WithEvents lblUniqueNumber1 As System.Windows.Forms.Label
    Friend WithEvents lblUniqueNumber2 As System.Windows.Forms.Label
    Friend WithEvents lblUniqueNumber3 As System.Windows.Forms.Label

End Class
