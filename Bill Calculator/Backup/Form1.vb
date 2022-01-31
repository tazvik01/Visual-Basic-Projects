Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents btnTotal As System.Windows.Forms.Button
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblBillCalculator As System.Windows.Forms.Label
    Friend WithEvents txtMealDeal1 As System.Windows.Forms.TextBox
    Friend WithEvents txtMealDeal3 As System.Windows.Forms.TextBox
    Friend WithEvents txtMealDeal2 As System.Windows.Forms.TextBox
    Friend WithEvents lblMealDeal1Prompt As System.Windows.Forms.Label
    Friend WithEvents lblMealDeal2Prompt As System.Windows.Forms.Label
    Friend WithEvents lblMealDeal3Prompt As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblBillCalculator = New System.Windows.Forms.Label()
        Me.lblMealDeal1Prompt = New System.Windows.Forms.Label()
        Me.txtMealDeal1 = New System.Windows.Forms.TextBox()
        Me.lblMealDeal2Prompt = New System.Windows.Forms.Label()
        Me.lblMealDeal3Prompt = New System.Windows.Forms.Label()
        Me.txtMealDeal3 = New System.Windows.Forms.TextBox()
        Me.txtMealDeal2 = New System.Windows.Forms.TextBox()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblBillCalculator
        '
        Me.lblBillCalculator.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBillCalculator.Location = New System.Drawing.Point(8, 8)
        Me.lblBillCalculator.Name = "lblBillCalculator"
        Me.lblBillCalculator.Size = New System.Drawing.Size(128, 32)
        Me.lblBillCalculator.TabIndex = 0
        Me.lblBillCalculator.Text = "Bill Calculator"
        Me.lblBillCalculator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMealDeal1Prompt
        '
        Me.lblMealDeal1Prompt.Location = New System.Drawing.Point(32, 48)
        Me.lblMealDeal1Prompt.Name = "lblMealDeal1Prompt"
        Me.lblMealDeal1Prompt.Size = New System.Drawing.Size(72, 24)
        Me.lblMealDeal1Prompt.TabIndex = 1
        Me.lblMealDeal1Prompt.Text = "Meal Deal 1:"
        Me.lblMealDeal1Prompt.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtMealDeal1
        '
        Me.txtMealDeal1.Location = New System.Drawing.Point(112, 48)
        Me.txtMealDeal1.Name = "txtMealDeal1"
        Me.txtMealDeal1.Size = New System.Drawing.Size(48, 20)
        Me.txtMealDeal1.TabIndex = 2
        Me.txtMealDeal1.Text = ""
        '
        'lblMealDeal2Prompt
        '
        Me.lblMealDeal2Prompt.Location = New System.Drawing.Point(32, 80)
        Me.lblMealDeal2Prompt.Name = "lblMealDeal2Prompt"
        Me.lblMealDeal2Prompt.Size = New System.Drawing.Size(72, 24)
        Me.lblMealDeal2Prompt.TabIndex = 3
        Me.lblMealDeal2Prompt.Text = "Meal Deal 2:"
        Me.lblMealDeal2Prompt.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblMealDeal3Prompt
        '
        Me.lblMealDeal3Prompt.Location = New System.Drawing.Point(32, 112)
        Me.lblMealDeal3Prompt.Name = "lblMealDeal3Prompt"
        Me.lblMealDeal3Prompt.Size = New System.Drawing.Size(72, 24)
        Me.lblMealDeal3Prompt.TabIndex = 5
        Me.lblMealDeal3Prompt.Text = "Meal Deal 3:"
        Me.lblMealDeal3Prompt.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtMealDeal3
        '
        Me.txtMealDeal3.Location = New System.Drawing.Point(112, 112)
        Me.txtMealDeal3.Name = "txtMealDeal3"
        Me.txtMealDeal3.Size = New System.Drawing.Size(48, 20)
        Me.txtMealDeal3.TabIndex = 6
        Me.txtMealDeal3.Text = ""
        '
        'txtMealDeal2
        '
        Me.txtMealDeal2.Location = New System.Drawing.Point(112, 80)
        Me.txtMealDeal2.Name = "txtMealDeal2"
        Me.txtMealDeal2.Size = New System.Drawing.Size(48, 20)
        Me.txtMealDeal2.TabIndex = 4
        Me.txtMealDeal2.Text = ""
        '
        'btnTotal
        '
        Me.btnTotal.Location = New System.Drawing.Point(168, 112)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(64, 24)
        Me.btnTotal.TabIndex = 7
        Me.btnTotal.Text = "Total"
        '
        'lblTotal
        '
        Me.lblTotal.Location = New System.Drawing.Point(240, 112)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(56, 24)
        Me.lblTotal.TabIndex = 8
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(352, 158)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblTotal, Me.btnTotal, Me.txtMealDeal2, Me.txtMealDeal3, Me.lblMealDeal3Prompt, Me.lblMealDeal2Prompt, Me.txtMealDeal1, Me.lblMealDeal1Prompt, Me.lblBillCalculator})
        Me.Name = "Form1"
        Me.Text = "Bill Calculator"
        Me.ResumeLayout(False)

    End Sub

#End Region

    'Chap 07 Bill Calculator Data File


    Private Sub btnTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTotal.Click

        Dim intMealDeal1 As Integer, intMealDeal2 As Integer, intMealDeal3 As Integer
        Dim decTotal As Decimal

        intMealDeal1 = Val(txtMealDeal1.Text)
        intMealDeal2 = Val(txtMealDeal2.Text)
        intMealDeal3 = Val(txtMealDeal3.Text)
        decTotal = TotalBill(intMealDeal1, intMealDeal2, intMealDeal3)
        Me.lblTotal.Text = "$" & decTotal

    End Sub


    ' TotalBill function and documentation to be completed by student
    


    Private Sub txtMealDeal1_Change()
        Me.lblTotal.Text = " "
    End Sub


    Private Sub txtMealDeal2_Change()
        Me.lblTotal.Text = " "
    End Sub


    Private Sub txtMealDeal3_Change()
        Me.lblTotal.Text = " "
    End Sub


End Class
