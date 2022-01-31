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
        Me.lblCourseLevelList = New System.Windows.Forms.Label()
        Me.lstCourseLevels = New System.Windows.Forms.ListBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblTuition = New System.Windows.Forms.Label()
        Me.lblCreditHours = New System.Windows.Forms.Label()
        Me.cboCreditHours = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblCourseLevelList
        '
        Me.lblCourseLevelList.Location = New System.Drawing.Point(17, 23)
        Me.lblCourseLevelList.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCourseLevelList.Name = "lblCourseLevelList"
        Me.lblCourseLevelList.Size = New System.Drawing.Size(80, 19)
        Me.lblCourseLevelList.TabIndex = 2
        Me.lblCourseLevelList.Text = "Course Level:"
        '
        'lstCourseLevels
        '
        Me.lstCourseLevels.FormattingEnabled = True
        Me.lstCourseLevels.Items.AddRange(New Object() {"Undergraduated", "Graduate", "Thesis and Deissertation"})
        Me.lstCourseLevels.Location = New System.Drawing.Point(20, 44)
        Me.lstCourseLevels.Margin = New System.Windows.Forms.Padding(2)
        Me.lstCourseLevels.Name = "lstCourseLevels"
        Me.lstCourseLevels.Size = New System.Drawing.Size(122, 69)
        Me.lstCourseLevels.TabIndex = 3
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(181, 98)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(78, 23)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblTuition
        '
        Me.lblTuition.Location = New System.Drawing.Point(17, 155)
        Me.lblTuition.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTuition.Name = "lblTuition"
        Me.lblTuition.Size = New System.Drawing.Size(242, 33)
        Me.lblTuition.TabIndex = 5
        '
        'lblCreditHours
        '
        Me.lblCreditHours.Location = New System.Drawing.Point(162, 23)
        Me.lblCreditHours.Name = "lblCreditHours"
        Me.lblCreditHours.Size = New System.Drawing.Size(100, 23)
        Me.lblCreditHours.TabIndex = 6
        Me.lblCreditHours.Text = "Credit Hours:"
        '
        'cboCreditHours
        '
        Me.cboCreditHours.FormattingEnabled = True
        Me.cboCreditHours.Items.AddRange(New Object() {"3", "6", "9", "12", "15"})
        Me.cboCreditHours.Location = New System.Drawing.Point(165, 44)
        Me.cboCreditHours.Name = "cboCreditHours"
        Me.cboCreditHours.Size = New System.Drawing.Size(72, 21)
        Me.cboCreditHours.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(274, 206)
        Me.Controls.Add(Me.cboCreditHours)
        Me.Controls.Add(Me.lblCreditHours)
        Me.Controls.Add(Me.lblTuition)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lstCourseLevels)
        Me.Controls.Add(Me.lblCourseLevelList)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Tuition Calculator"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblCourseLevelList As System.Windows.Forms.Label
    Friend WithEvents lstCourseLevels As System.Windows.Forms.ListBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lblTuition As System.Windows.Forms.Label
    Friend WithEvents lblCreditHours As System.Windows.Forms.Label
    Friend WithEvents cboCreditHours As System.Windows.Forms.ComboBox

End Class
