Public Class Form1
    'Tazvik Ziauddin
    'Ch.5 Rev.3
    '9/21/2017

    Private Sub btnAnswer_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAnswer.Click

        Const sngPI As Single = 3.14
        Dim sngRadius As Single
        Dim sngCircleArea As Single

        sngRadius = Val(Me.txtRadius.Text)

        If sngRadius < 0 Then
            Me.lblAnswer.Text = "Negative radii are illegal."
        Else
            sngCircleArea = sngPI * sngRadius ^ 2
            Me.lblAnswer.Text = sngCircleArea 'Display answer

        End If

       
    End Sub

    Private Sub txtRadius_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRadius.TextChanged

        'Clear the current answer when the user begins to type a new radius  value

        Me.lblAnswer.Text = " "

    End Sub

End Class
