Public Class Form1
    'Tazvik Ziauddin
    'Ch.5 Excer.1

    Private Sub btnCheckNumber_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCheckNumber.Click

        Dim IntNumber As Integer
        IntNumber = Val(Me.txtNumber.Text)

        Select Case IntNumber
            Case Is < 10
                Me.lblStatement.Text = "The number is a one digit number."
            Case Is <= 99
                Me.lblStatement.Text = "The number is a two digit number."
        End Select

    End Sub

End Class
