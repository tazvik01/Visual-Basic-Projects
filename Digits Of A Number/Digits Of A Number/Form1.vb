Public Class Form1
    'Tazvik Ziauddin
    'Ch.4 Excer.8

    Private Sub btnDigits_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDigits.Click

        Dim sngDigit As Single
        Dim sngFirstDigit As Single
        Dim sngSecondDigit As Single

        sngDigit = Val(Me.txtDigits.Text)
        sngFirstDigit = sngDigit \ 10
        sngSecondDigit = sngDigit Mod 10

        Me.lblFirstDigitAnswer.Text = sngFirstDigit
        Me.lblSecondDigitAnswer.Text = sngSecondDigit


    End Sub

    Private Sub mnuDigits_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuDigits.Click

        Dim sngDigit As Single
        Dim sngFirstDigit As Single
        Dim sngSecondDigit As Single

        sngDigit = Val(Me.txtDigits.Text)
        sngFirstDigit = sngDigit \ 10
        sngSecondDigit = sngDigit Mod 10

        Me.lblFirstDigitAnswer.Text = sngFirstDigit
        Me.lblSecondDigitAnswer.Text = sngSecondDigit

    End Sub

End Class
