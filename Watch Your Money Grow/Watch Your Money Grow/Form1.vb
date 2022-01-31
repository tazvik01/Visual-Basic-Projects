Public Class Form1
    'Tazvik Ziauddin
    'Ch.8 Rev.5

    Private Sub btnFutureValue_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFutureValue.Click

        Dim sngRate, sngInvestment As Single
        Dim intTerm As Integer
        Dim sngFutureValue As Single
        Dim blnValidData As Boolean

        'Get interest rate is valid
        GetPercentAmount(Me.txtInterest, sngRate, blnValidData)

        'Get term if interest rate is valid
        If blnValidData Then
            intTerm = Val(Me.txtTerm.Text)
            If intTerm <= 0 Then
                blnValidData = False
            End If
        End If

        'Get Investment if interest rate is valid
        If blnValidData Then
            GetDollarAmount(Me.txtInvestment, sngInvestment, blnValidData)
        End If

        'Calculate payment if all data entered by user is valid
        If blnValidData Then
            sngFutureValue = FV(sngRate / 12, intTerm * 12, -sngInvestment)
            Me.lblFutureValue.Text = "Your investment will be worth " & _
                Format(sngFutureValue, "Currency") & " if you paln on making monthly investments of " & _
                Format(sngInvestment, "Currency") & " at " & Format(sngRate, "Percent") & " for " & intTerm & " years. "
        End If

    End Sub

    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'Process data in a text box to read percentage amount, if any.
    '
    'post:sngPercent contains a decimal number if numeric data with
    'or without a % was entered in the box.blnValid is True if a
    'valid percent has been entered in the text box.
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Sub GetPercentAmount(ByRef txtUserData As TextBox, _
    ByRef sngPercent As Single, ByRef blnIsValid As Boolean)

        Dim strTestAmount As String

        blnIsValid = False                           'assume nonnumeric data
        If txtUserData.Text <> Nothing Then
            strTestAmount = txtUserData.Text
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

End Class
