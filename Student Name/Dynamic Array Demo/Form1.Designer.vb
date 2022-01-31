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
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnProcess = New System.Windows.Forms.Button()
        Me.grpAction = New System.Windows.Forms.GroupBox()
        Me.radFind = New System.Windows.Forms.RadioButton()
        Me.radRemove = New System.Windows.Forms.RadioButton()
        Me.radAdd = New System.Windows.Forms.RadioButton()
        Me.lstItemIndex = New System.Windows.Forms.ListBox()
        Me.grpAction.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.Location = New System.Drawing.Point(170, 33)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(56, 23)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(212, 30)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(53, 20)
        Me.txtName.TabIndex = 1
        '
        'btnProcess
        '
        Me.btnProcess.Location = New System.Drawing.Point(313, 236)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(80, 23)
        Me.btnProcess.TabIndex = 2
        Me.btnProcess.Text = "Process"
        Me.btnProcess.UseVisualStyleBackColor = True
        '
        'grpAction
        '
        Me.grpAction.Controls.Add(Me.radFind)
        Me.grpAction.Controls.Add(Me.radRemove)
        Me.grpAction.Controls.Add(Me.radAdd)
        Me.grpAction.Location = New System.Drawing.Point(153, 106)
        Me.grpAction.Name = "grpAction"
        Me.grpAction.Size = New System.Drawing.Size(240, 63)
        Me.grpAction.TabIndex = 3
        Me.grpAction.TabStop = False
        Me.grpAction.Text = "Action"
        '
        'radFind
        '
        Me.radFind.Location = New System.Drawing.Point(159, 31)
        Me.radFind.Name = "radFind"
        Me.radFind.Size = New System.Drawing.Size(56, 24)
        Me.radFind.TabIndex = 2
        Me.radFind.TabStop = True
        Me.radFind.Text = "Find"
        Me.radFind.UseVisualStyleBackColor = True
        '
        'radRemove
        '
        Me.radRemove.Location = New System.Drawing.Point(79, 31)
        Me.radRemove.Name = "radRemove"
        Me.radRemove.Size = New System.Drawing.Size(74, 24)
        Me.radRemove.TabIndex = 1
        Me.radRemove.TabStop = True
        Me.radRemove.Text = "Remove"
        Me.radRemove.UseVisualStyleBackColor = True
        '
        'radAdd
        '
        Me.radAdd.Location = New System.Drawing.Point(15, 31)
        Me.radAdd.Name = "radAdd"
        Me.radAdd.Size = New System.Drawing.Size(58, 24)
        Me.radAdd.TabIndex = 0
        Me.radAdd.TabStop = True
        Me.radAdd.Text = "Add"
        Me.radAdd.UseVisualStyleBackColor = True
        '
        'lstItemIndex
        '
        Me.lstItemIndex.FormattingEnabled = True
        Me.lstItemIndex.Location = New System.Drawing.Point(12, 21)
        Me.lstItemIndex.Name = "lstItemIndex"
        Me.lstItemIndex.Size = New System.Drawing.Size(135, 238)
        Me.lstItemIndex.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 274)
        Me.Controls.Add(Me.lstItemIndex)
        Me.Controls.Add(Me.grpAction)
        Me.Controls.Add(Me.btnProcess)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Name = "Form1"
        Me.Text = "Dynamic Array Demo"
        Me.grpAction.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents btnProcess As System.Windows.Forms.Button
    Friend WithEvents grpAction As System.Windows.Forms.GroupBox
    Friend WithEvents radFind As System.Windows.Forms.RadioButton
    Friend WithEvents radRemove As System.Windows.Forms.RadioButton
    Friend WithEvents radAdd As System.Windows.Forms.RadioButton
    Friend WithEvents lstItemIndex As System.Windows.Forms.ListBox

End Class
