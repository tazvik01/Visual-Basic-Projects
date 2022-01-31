Public Class Form1
    'Tazvik Ziauddin
    'Ch.6 Rev.1
    '10/24/2017

    Private Sub btnTest_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTest.Click

        'Get number from user
        Dim intTestNum As Integer = Val(Me.txtInteger.Text)

        'Test number
        Dim intDivisor As Integer = 1
        If intTestNum <= 1 Then
            Me.lblPrimeResult.Text = "Not a Prime number."
        Else
            Do
                intDivisor = intDivisor + 1
            Loop While intTestNum Mod intDivisor <> 0
            If intDivisor = intTestNum Then
                Me.lblPrimeResult.Text = "Prime number."
            Else
                Me.lblPrimeResult.Text = "Not a prime number."
            End If
        End If

    End Sub

End Class
