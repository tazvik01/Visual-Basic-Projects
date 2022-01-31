Public Class Form1
    'Tazvik Ziauddin
    'Ch.4 Rev.5
    '9/21/2017

    Dim IntX As Integer = 10


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProc1.Click

        Dim intX As Integer = 3

        Me.lblAnswer.Text = intX

    End Sub

    Private Sub btnProc2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnProc2.Click

        Me.lblAnswer.Text = intX

    End Sub

End Class
