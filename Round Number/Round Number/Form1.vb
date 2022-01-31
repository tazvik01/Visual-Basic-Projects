Public Class Form1
    'Tazvik Ziauddin
    'Ch.8 Rev.2

    Private Sub btnRound_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRound.Click

        Dim sngNumber As Single
        Dim intPlaces As Integer

        sngNumber = Val(Me.txtNumber.Text)
        intPlaces = Val(Me.txtDecimalPlace.Text)

        Me.lblAnswer.Text = Math.Round(sngNumber, intPlaces)

    End Sub

End Class
