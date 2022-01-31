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
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents txtPizzaOrders As System.Windows.Forms.TextBox
    Friend WithEvents txtBeverageOrders As System.Windows.Forms.TextBox
    Friend WithEvents txtSaladOrders As System.Windows.Forms.TextBox
    Friend WithEvents lblPPizzaPrompt As System.Windows.Forms.Label
    Friend WithEvents lblSaladPrompt As System.Windows.Forms.Label
    Friend WithEvents lblBeveragePrompt As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblPPizzaPrompt = New System.Windows.Forms.Label()
        Me.txtPizzaOrders = New System.Windows.Forms.TextBox()
        Me.lblSaladPrompt = New System.Windows.Forms.Label()
        Me.lblBeveragePrompt = New System.Windows.Forms.Label()
        Me.txtBeverageOrders = New System.Windows.Forms.TextBox()
        Me.txtSaladOrders = New System.Windows.Forms.TextBox()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(8, 8)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(136, 32)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Restaurant Check"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPPizzaPrompt
        '
        Me.lblPPizzaPrompt.Location = New System.Drawing.Point(16, 48)
        Me.lblPPizzaPrompt.Name = "lblPPizzaPrompt"
        Me.lblPPizzaPrompt.Size = New System.Drawing.Size(88, 16)
        Me.lblPPizzaPrompt.TabIndex = 1
        Me.lblPPizzaPrompt.Text = "Personal Pizza:"
        Me.lblPPizzaPrompt.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtPizzaOrders
        '
        Me.txtPizzaOrders.Location = New System.Drawing.Point(112, 48)
        Me.txtPizzaOrders.Name = "txtPizzaOrders"
        Me.txtPizzaOrders.Size = New System.Drawing.Size(48, 20)
        Me.txtPizzaOrders.TabIndex = 2
        Me.txtPizzaOrders.Text = ""
        '
        'lblSaladPrompt
        '
        Me.lblSaladPrompt.Location = New System.Drawing.Point(56, 80)
        Me.lblSaladPrompt.Name = "lblSaladPrompt"
        Me.lblSaladPrompt.Size = New System.Drawing.Size(48, 16)
        Me.lblSaladPrompt.TabIndex = 3
        Me.lblSaladPrompt.Text = "Salad:"
        Me.lblSaladPrompt.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblBeveragePrompt
        '
        Me.lblBeveragePrompt.Location = New System.Drawing.Point(40, 112)
        Me.lblBeveragePrompt.Name = "lblBeveragePrompt"
        Me.lblBeveragePrompt.Size = New System.Drawing.Size(64, 16)
        Me.lblBeveragePrompt.TabIndex = 5
        Me.lblBeveragePrompt.Text = "Beverage:"
        Me.lblBeveragePrompt.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtBeverageOrders
        '
        Me.txtBeverageOrders.Location = New System.Drawing.Point(112, 112)
        Me.txtBeverageOrders.Name = "txtBeverageOrders"
        Me.txtBeverageOrders.Size = New System.Drawing.Size(48, 20)
        Me.txtBeverageOrders.TabIndex = 6
        Me.txtBeverageOrders.Text = ""
        '
        'txtSaladOrders
        '
        Me.txtSaladOrders.Location = New System.Drawing.Point(112, 80)
        Me.txtSaladOrders.Name = "txtSaladOrders"
        Me.txtSaladOrders.Size = New System.Drawing.Size(48, 20)
        Me.txtSaladOrders.TabIndex = 4
        Me.txtSaladOrders.Text = ""
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
        Me.ClientSize = New System.Drawing.Size(312, 158)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblTotal, Me.btnTotal, Me.txtSaladOrders, Me.txtBeverageOrders, Me.lblBeveragePrompt, Me.lblSaladPrompt, Me.txtPizzaOrders, Me.lblPPizzaPrompt, Me.lblTitle})
        Me.Name = "Form1"
        Me.Text = "Restaurant Check"
        Me.ResumeLayout(False)

    End Sub

#End Region

    'Chap 07 Restaurant Check Data File


    Private Sub btnTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTotal.Click

        Dim intNumPizzas As Integer, intNumSalads As Integer, intNumBeverages As Integer
        Dim decTotal As Decimal

        intNumPizzas = Val(txtPizzaOrders.Text)
        intNumSalads = Val(txtSaladOrders.Text)
        intNumBeverages = Val(txtBeverageOrders.Text)
        decTotal = TotalBill(intNumPizzas, intNumSalads, intNumBeverages)
        Me.lblTotal.Text = "$" & decTotal

    End Sub


    'CheckTotal function and documentation to be completed by student
    


    Private Sub txtPizzaOrders_Change()
        Me.lblTotal.Text = " "
    End Sub


    Private Sub txtSaladOrders_Change()
        Me.lblTotal.Text = " "
    End Sub


    Private Sub txtBeverageOrders_Change()
        Me.lblTotal.Text = " "
    End Sub


End Class
