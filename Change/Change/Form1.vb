Public Class Form1
    'Tazvik Ziauddin
    'Ch.4 Excer.7

    Private Sub btnCoins_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCoins.Click

        Dim intCents As Integer
        Dim intQuarters As Integer
        Dim intDimes As Integer
        Dim intNickels As Integer
        Dim intPennies As Integer

        intCents = Val(Me.txtCents.Text)
        intQuarters = intCents \ 25
        intDimes = ((intCents Mod 25) \ 10)
        intNickels = ((intCents Mod 25 Mod 10) \ 5)
        intPennies = ((intCents \ 1) Mod 10)

        Me.lblQuarterAnswer.Text = intQuarters
        Me.lblDimeAnswer.Text = intDimes
        Me.lblNickelAnswer.Text = intNickels
        Me.lblPennieAnswer.Text = intPennies

    End Sub

End Class
