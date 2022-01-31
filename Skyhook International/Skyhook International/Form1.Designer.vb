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
        Me.lblSkyhooks = New System.Windows.Forms.Label()
        Me.txtNumberofskyhooks = New System.Windows.Forms.TextBox()
        Me.btnShip = New System.Windows.Forms.Button()
        Me.lblNumberOfBoxes = New System.Windows.Forms.Label()
        Me.lblNumberOfEnvelopes = New System.Windows.Forms.Label()
        Me.lblBoxes = New System.Windows.Forms.Label()
        Me.lblEnvelopes = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblSkyhooks
        '
        Me.lblSkyhooks.Location = New System.Drawing.Point(12, 25)
        Me.lblSkyhooks.Name = "lblSkyhooks"
        Me.lblSkyhooks.Size = New System.Drawing.Size(151, 24)
        Me.lblSkyhooks.TabIndex = 0
        Me.lblSkyhooks.Text = "Number of skyhooks ordered:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtNumberofskyhooks
        '
        Me.txtNumberofskyhooks.Location = New System.Drawing.Point(178, 22)
        Me.txtNumberofskyhooks.Name = "txtNumberofskyhooks"
        Me.txtNumberofskyhooks.Size = New System.Drawing.Size(45, 20)
        Me.txtNumberofskyhooks.TabIndex = 1
        '
        'btnShip
        '
        Me.btnShip.Location = New System.Drawing.Point(15, 60)
        Me.btnShip.Name = "btnShip"
        Me.btnShip.Size = New System.Drawing.Size(67, 21)
        Me.btnShip.TabIndex = 2
        Me.btnShip.Text = "Ship"
        Me.btnShip.UseVisualStyleBackColor = True
        '
        'lblNumberOfBoxes
        '
        Me.lblNumberOfBoxes.Location = New System.Drawing.Point(12, 128)
        Me.lblNumberOfBoxes.Name = "lblNumberOfBoxes"
        Me.lblNumberOfBoxes.Size = New System.Drawing.Size(45, 22)
        Me.lblNumberOfBoxes.TabIndex = 3
        '
        'lblNumberOfEnvelopes
        '
        Me.lblNumberOfEnvelopes.Location = New System.Drawing.Point(15, 164)
        Me.lblNumberOfEnvelopes.Name = "lblNumberOfEnvelopes"
        Me.lblNumberOfEnvelopes.Size = New System.Drawing.Size(42, 23)
        Me.lblNumberOfEnvelopes.TabIndex = 4
        '
        'lblBoxes
        '
        Me.lblBoxes.Location = New System.Drawing.Point(86, 128)
        Me.lblBoxes.Name = "lblBoxes"
        Me.lblBoxes.Size = New System.Drawing.Size(52, 23)
        Me.lblBoxes.TabIndex = 5
        Me.lblBoxes.Text = "Boxes"
        '
        'lblEnvelopes
        '
        Me.lblEnvelopes.Location = New System.Drawing.Point(86, 164)
        Me.lblEnvelopes.Name = "lblEnvelopes"
        Me.lblEnvelopes.Size = New System.Drawing.Size(60, 23)
        Me.lblEnvelopes.TabIndex = 6
        Me.lblEnvelopes.Text = "Envelopes"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(297, 235)
        Me.Controls.Add(Me.lblEnvelopes)
        Me.Controls.Add(Me.lblBoxes)
        Me.Controls.Add(Me.lblNumberOfEnvelopes)
        Me.Controls.Add(Me.lblNumberOfBoxes)
        Me.Controls.Add(Me.btnShip)
        Me.Controls.Add(Me.txtNumberofskyhooks)
        Me.Controls.Add(Me.lblSkyhooks)
        Me.Name = "Form1"
        Me.Text = "Skyhook International"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSkyhooks As System.Windows.Forms.Label
    Friend WithEvents txtNumberofskyhooks As System.Windows.Forms.TextBox
    Friend WithEvents btnShip As System.Windows.Forms.Button
    Friend WithEvents lblNumberOfBoxes As System.Windows.Forms.Label
    Friend WithEvents lblNumberOfEnvelopes As System.Windows.Forms.Label
    Friend WithEvents lblBoxes As System.Windows.Forms.Label
    Friend WithEvents lblEnvelopes As System.Windows.Forms.Label

End Class
