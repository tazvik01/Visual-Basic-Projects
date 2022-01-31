Public Class Form1
    'Tazvik Ziauddin
    'Ch.8 Rev.9
    '2018/01/15

    Private Sub btnPayment_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPayment.Click

        Dim sngRate, sngPrinciple As Single
        Dim intTerm As Integer
        Dim sngPayment As Single
        Dim blnValidData As Boolean

        'Get interest rate
        GetPercentAmount(Me.cboRate, sngRate, blnValidData)

        'Get term if interest rate is valid
        If blnValidData Then
            intTerm = Val(Me.cboTerm.Text)
            If intTerm <= 0 Then
                blnValidData = False
            End If
        End If

        'Get principle if interest rate and ter are valid
        If blnValidData Then
            GetDollarAmount(Me.txtPrincipal, sngPrinciple, blnValidData)
        End If

        'Calculate payment if all data entered by user is valid
        If blnValidData Then
            sngPayment = Pmt(sngRate / 12, intTerm * 12, -sngPrinciple)
            Me.lblMonthlyPayment.Text = "The monthly payment for a loan of " & _
                Format(sngPrinciple, "Currency") & " at " & Format(sngRate, "Percent") _
                & " for " & intTerm & " years is " & Format(sngPayment, "Currency")
        Else
            Me.lblMonthlyPayment.Text = "Enter valid data."
        End If

    End Sub

    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'Process data in a combo box to read percentage amount, if any.
    '
    'post:sngPercent contains a decimal number if numeric data with
    'or without a % was entered in the box.blnValid is True if a
    'valid percent has been entered in the text box.
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Sub GetPercentAmount(ByRef cboUserData As ComboBox, _
    ByRef sngPercent As Single, ByRef blnIsValid As Boolean)

        Dim strTestAmount As String

        blnIsValid = False                           'assume nonnumeric data
        If cboUserData.Text <> Nothing Then
            strTestAmount = cboUserData.Text
            strTestAmount = strTestAmount.TrimEnd("%")   'delete %
        End If
        If IsNumeric(strTestAmount) Then                 'numeric data
            If Val(strTestAmount) > 1 Then               'convert data
                sngPercent = Val(strTestAmount) / 100
            Else
                sngPercent = Val(strTestAmount)
            End If
            blnIsValid = True
        End If

    End Sub

    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'Process data in a text box to read a dollar amount, if any.
    '
    'post: decDollars contains a number if numeric data with or
    'without a $ and commas was entered in the text box. blnIsValid is
    'True if a valid dollar amount has been entered in the text box.
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Sub GetDollarAmount(ByRef txtUserData As TextBox, _
    ByRef decDollars As Decimal, ByRef blnIsValid As Boolean)

        Dim strTestAmount As String

        blnIsValid = False                                               'assume nonnumeric data
        If txtUserData.Text <> Nothing Then
            strTestAmount = txtUserData.Text                             'data typed
            strTestAmount = strTestAmount.Replace("$", "")               'delete $
            strTestAmount = strTestAmount.Replace(",", "")               'delete commas
            If IsNumeric(strTestAmount) Then                             'numeric data
                decDollars = Val(strTestAmount)
                blnIsValid = True
            End If
        End If

    End Sub

    Private Sub NewDataEntered(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles txtPrincipal.TextChanged, _
    cboRate.SelectedIndexChanged, cboTerm.SelectedIndexChanged, _
    cboRate.TextChanged, cboTerm.TextChanged

        Me.lblMonthlyPayment.Text = Nothing
        Me.btnPayment.Enabled = False

        If Me.cboRate.Text <> Nothing And Me.cboTerm.Text <> Nothing And _
        Me.txtPrincipal.Text <> Nothing Then
            Me.btnPayment.Enabled = True
        End If

    End Sub

End Class
