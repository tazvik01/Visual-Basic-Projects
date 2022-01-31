Public Class Form1
    'Tazvik Ziauddin
    'Ch.4 Excer.9

    Private Sub rdnMinutesToSeconds_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdnMinutesToSeconds.Click

        Dim intMinutes As Integer
        Dim intTimeInSeconds As Integer

        intMinutes = Val(Me.txtMinutes.Text)
        intTimeInSeconds = intMinutes * 60

        Me.lblTimeInMinute.Text = intTimeInSeconds

    End Sub

    Private Sub rdnMinuteFormat_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdnMinuteFormat.Click

        Dim intMinutes As Integer
        Dim intTimeInHour As Integer
        Dim intTimeInMinute As Integer

        intMinutes = Val(Me.txtMinutes.Text)
        intTimeInHour = intMinutes / 60
        intTimeInMinute = intMinutes Mod 60

        Me.lblTimeInHour.Text = intTimeInHour
        Me.lblTimeInMinute.Text = intTimeInMinute

    End Sub

End Class
