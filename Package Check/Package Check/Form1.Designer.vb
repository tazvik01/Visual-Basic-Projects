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
        Me.lblPackageData = New System.Windows.Forms.Label()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.txtEnterWeight = New System.Windows.Forms.TextBox()
        Me.lblLength = New System.Windows.Forms.Label()
        Me.txtEnterLength = New System.Windows.Forms.TextBox()
        Me.lblWidth = New System.Windows.Forms.Label()
        Me.txtEnterWidth = New System.Windows.Forms.TextBox()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.txtEnterHeight = New System.Windows.Forms.TextBox()
        Me.lblStatement = New System.Windows.Forms.Label()
        Me.btnCheckPackage = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPackageData
        '
        Me.lblPackageData.Location = New System.Drawing.Point(12, 34)
        Me.lblPackageData.Name = "lblPackageData"
        Me.lblPackageData.Size = New System.Drawing.Size(137, 28)
        Me.lblPackageData.TabIndex = 0
        Me.lblPackageData.Text = "Enter the package's data:"
        '
        'lblWeight
        '
        Me.lblWeight.Location = New System.Drawing.Point(56, 79)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(113, 23)
        Me.lblWeight.TabIndex = 1
        Me.lblWeight.Text = "weight in kilograms:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtEnterWeight
        '
        Me.txtEnterWeight.Location = New System.Drawing.Point(175, 76)
        Me.txtEnterWeight.Name = "txtEnterWeight"
        Me.txtEnterWeight.Size = New System.Drawing.Size(37, 20)
        Me.txtEnterWeight.TabIndex = 2
        '
        'lblLength
        '
        Me.lblLength.Location = New System.Drawing.Point(56, 115)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(113, 23)
        Me.lblLength.TabIndex = 3
        Me.lblLength.Text = "length in Centimeters:"
        '
        'txtEnterLength
        '
        Me.txtEnterLength.Location = New System.Drawing.Point(175, 112)
        Me.txtEnterLength.Name = "txtEnterLength"
        Me.txtEnterLength.Size = New System.Drawing.Size(37, 20)
        Me.txtEnterLength.TabIndex = 4
        '
        'lblWidth
        '
        Me.lblWidth.Location = New System.Drawing.Point(56, 152)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.Size = New System.Drawing.Size(113, 23)
        Me.lblWidth.TabIndex = 5
        Me.lblWidth.Text = "width in Centimeters:"
        '
        'txtEnterWidth
        '
        Me.txtEnterWidth.Location = New System.Drawing.Point(175, 152)
        Me.txtEnterWidth.Name = "txtEnterWidth"
        Me.txtEnterWidth.Size = New System.Drawing.Size(37, 20)
        Me.txtEnterWidth.TabIndex = 6
        '
        'lblHeight
        '
        Me.lblHeight.Location = New System.Drawing.Point(56, 187)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(113, 23)
        Me.lblHeight.TabIndex = 7
        Me.lblHeight.Text = "height in centimeters:"
        '
        'txtEnterHeight
        '
        Me.txtEnterHeight.Location = New System.Drawing.Point(175, 187)
        Me.txtEnterHeight.Name = "txtEnterHeight"
        Me.txtEnterHeight.Size = New System.Drawing.Size(37, 20)
        Me.txtEnterHeight.TabIndex = 8
        '
        'lblStatement
        '
        Me.lblStatement.Location = New System.Drawing.Point(12, 230)
        Me.lblStatement.Name = "lblStatement"
        Me.lblStatement.Size = New System.Drawing.Size(137, 25)
        Me.lblStatement.TabIndex = 9
        '
        'btnCheckPackage
        '
        Me.btnCheckPackage.Location = New System.Drawing.Point(147, 261)
        Me.btnCheckPackage.Name = "btnCheckPackage"
        Me.btnCheckPackage.Size = New System.Drawing.Size(110, 23)
        Me.btnCheckPackage.TabIndex = 10
        Me.btnCheckPackage.Text = "Check package"
        Me.btnCheckPackage.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(269, 296)
        Me.Controls.Add(Me.btnCheckPackage)
        Me.Controls.Add(Me.lblStatement)
        Me.Controls.Add(Me.txtEnterHeight)
        Me.Controls.Add(Me.lblHeight)
        Me.Controls.Add(Me.txtEnterWidth)
        Me.Controls.Add(Me.lblWidth)
        Me.Controls.Add(Me.txtEnterLength)
        Me.Controls.Add(Me.lblLength)
        Me.Controls.Add(Me.txtEnterWeight)
        Me.Controls.Add(Me.lblWeight)
        Me.Controls.Add(Me.lblPackageData)
        Me.Name = "Form1"
        Me.Text = "Package Check"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPackageData As System.Windows.Forms.Label
    Friend WithEvents lblWeight As System.Windows.Forms.Label
    Friend WithEvents txtEnterWeight As System.Windows.Forms.TextBox
    Friend WithEvents lblLength As System.Windows.Forms.Label
    Friend WithEvents txtEnterLength As System.Windows.Forms.TextBox
    Friend WithEvents lblWidth As System.Windows.Forms.Label
    Friend WithEvents txtEnterWidth As System.Windows.Forms.TextBox
    Friend WithEvents lblHeight As System.Windows.Forms.Label
    Friend WithEvents txtEnterHeight As System.Windows.Forms.TextBox
    Friend WithEvents lblStatement As System.Windows.Forms.Label
    Friend WithEvents btnCheckPackage As System.Windows.Forms.Button

End Class
