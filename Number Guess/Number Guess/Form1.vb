Public Class Form1
    'Tazvik Ziauddin
    'Ch.5 Rev.4

    Private Sub btnCheckGuess_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCheckGuess.Click

        Const intSECRETNUMBER As Integer = 7

        Dim intGuess = Val(Me.txtNumber.Text)

        If intGuess = intSECRETNUMBER Then
            Me.lblStatement.Text = "You guessed it!"
        ElseIf intGuess < intSECRETNUMBER Then
            Me.lblStatement.Text = "Too low"
        Else
            Me.lblStatement.Text = "Too high"
        End If

    End Sub

End Class
