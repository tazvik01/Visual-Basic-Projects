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
        Me.btnCustomerInfo = New System.Windows.Forms.Button()
        Me.lblHighestbalance = New System.Windows.Forms.Label()
        Me.lblaverage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCustomerInfo
        '
        Me.btnCustomerInfo.Location = New System.Drawing.Point(87, 86)
        Me.btnCustomerInfo.Name = "btnCustomerInfo"
        Me.btnCustomerInfo.Size = New System.Drawing.Size(204, 26)
        Me.btnCustomerInfo.TabIndex = 0
        Me.btnCustomerInfo.Text = "Enter Customer Information"
        Me.btnCustomerInfo.UseVisualStyleBackColor = True
        '
        'lblHighestbalance
        '
        Me.lblHighestbalance.Location = New System.Drawing.Point(70, 126)
        Me.lblHighestbalance.Name = "lblHighestbalance"
        Me.lblHighestbalance.Size = New System.Drawing.Size(240, 43)
        Me.lblHighestbalance.TabIndex = 1
        '
        'lblaverage
        '
        Me.lblaverage.Location = New System.Drawing.Point(84, 175)
        Me.lblaverage.Name = "lblaverage"
        Me.lblaverage.Size = New System.Drawing.Size(218, 46)
        Me.lblaverage.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 230)
        Me.Controls.Add(Me.lblaverage)
        Me.Controls.Add(Me.lblHighestbalance)
        Me.Controls.Add(Me.btnCustomerInfo)
        Me.Name = "Form1"
        Me.Text = "Customers"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCustomerInfo As System.Windows.Forms.Button
    Friend WithEvents lblHighestbalance As System.Windows.Forms.Label
    Friend WithEvents lblaverage As System.Windows.Forms.Label

End Class
