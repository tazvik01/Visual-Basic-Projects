Public Class Form1
    'Tazvik Ziauddin
    'Ch.6 Rev.4
    '10/31/2017

    Private Sub btnComputeFactorial_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnComputeFactorial.Click

        Dim IngFactorial As Long = 1
        Dim intNumber As Integer
        Dim intCount As Integer

        intNumber = Val(Me.txtNumber.Text)

        For intCount = 1 To intNumber
            IngFactorial = IngFactorial * intCount
        Next intCount

        Me.lblFactorialMessage.Text = "Factorial is:"
        Me.lblFactorial.Text = IngFactorial

    End Sub

    Private Sub txtNumber_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNumber.TextChanged

        Me.lblFactorial.Text = Nothing
        Me.lblFactorialMessage.Text = Nothing

    End Sub

End Class
