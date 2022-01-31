Public Class Form1
    'Tazvik Ziauddin
    'Ch.8 Rev.1

    Dim intNumber As Integer
    Dim intAnswer As Integer

    Private Sub btnAbsoluteValue_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAbsoluteValue.Click

        If IsNumeric(Me.txtNumber.Text) Then
            intNumber = Val(Me.txtNumber.Text)
        Else
            MessageBox.Show("Enter a numeric value.")
        End If

        intNumber = Val(Me.txtNumber.Text)
        intAnswer = Math.Abs(intNumber)

        Me.lblAnswer.Text = " The absolute value of " & intNumber & "  is  " & intAnswer

    End Sub

    Private Sub btnSquareRoot_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSquareRoot.Click

        If IsNumeric(Me.txtNumber.Text) Then
            intNumber = Val(Me.txtNumber.Text)
        Else
            MessageBox.Show("Enter a numeric value.")
        End If

        intNumber = Val(Me.txtNumber.Text)
        intAnswer = Math.Sqrt(intNumber)

        Me.lblAnswer.Text = " The square root of " & intNumber & "  is  " & intAnswer

    End Sub

    Private Sub btnSign_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSign.Click

        If IsNumeric(Me.txtNumber.Text) Then
            intNumber = Val(Me.txtNumber.Text)
        Else
            MessageBox.Show("Enter a numeric value.")
        End If

        intNumber = Val(Me.txtNumber.Text)
        intAnswer = Math.Sign(intNumber)

        Me.lblAnswer.Text = " The sign of " & intNumber & "  is  " & intAnswer

        Select Case intAnswer
            Case -1
                Me.lblAnswer.Text = " The sign of " & intNumber & "  is  negative "
            Case 0
                Me.lblAnswer.Text = " The sign of " & intNumber & "  is  zero "
            Case 1
                Me.lblAnswer.Text = " The sign of " & intNumber & "  is  posetive "
        End Select

    End Sub

End Class
