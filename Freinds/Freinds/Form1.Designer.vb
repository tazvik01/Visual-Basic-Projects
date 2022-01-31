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
        Me.txtFreindName = New System.Windows.Forms.TextBox()
        Me.btnGetInfo = New System.Windows.Forms.Button()
        Me.picFreindPhoto = New System.Windows.Forms.PictureBox()
        Me.lblFreindInfo = New System.Windows.Forms.Label()
        CType(Me.picFreindPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPrompt
        '
        Me.lblPrompt.Location = New System.Drawing.Point(35, 30)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(162, 34)
        Me.lblPrompt.TabIndex = 0
        Me.lblPrompt.Text = "Enter the first name of freind:"
        '
        'txtFreindName
        '
        Me.txtFreindName.Location = New System.Drawing.Point(177, 27)
        Me.txtFreindName.Name = "txtFreindName"
        Me.txtFreindName.Size = New System.Drawing.Size(198, 20)
        Me.txtFreindName.TabIndex = 1
        '
        'btnGetInfo
        '
        Me.btnGetInfo.Location = New System.Drawing.Point(415, 27)
        Me.btnGetInfo.Name = "btnGetInfo"
        Me.btnGetInfo.Size = New System.Drawing.Size(102, 27)
        Me.btnGetInfo.TabIndex = 2
        Me.btnGetInfo.Text = "Get Info"
        Me.btnGetInfo.UseVisualStyleBackColor = True
        '
        'picFreindPhoto
        '
        Me.picFreindPhoto.Location = New System.Drawing.Point(341, 131)
        Me.picFreindPhoto.Name = "picFreindPhoto"
        Me.picFreindPhoto.Size = New System.Drawing.Size(100, 100)
        Me.picFreindPhoto.TabIndex = 3
        Me.picFreindPhoto.TabStop = False
        '
        'lblFreindInfo
        '
        Me.lblFreindInfo.Location = New System.Drawing.Point(33, 85)
        Me.lblFreindInfo.Name = "lblFreindInfo"
        Me.lblFreindInfo.Size = New System.Drawing.Size(285, 165)
        Me.lblFreindInfo.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 318)
        Me.Controls.Add(Me.lblFreindInfo)
        Me.Controls.Add(Me.picFreindPhoto)
        Me.Controls.Add(Me.btnGetInfo)
        Me.Controls.Add(Me.txtFreindName)
        Me.Controls.Add(Me.lblPrompt)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picFreindPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPrompt As System.Windows.Forms.Label
    Friend WithEvents txtFreindName As System.Windows.Forms.TextBox
    Friend WithEvents btnGetInfo As System.Windows.Forms.Button
    Friend WithEvents picFreindPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents lblFreindInfo As System.Windows.Forms.Label

End Class
