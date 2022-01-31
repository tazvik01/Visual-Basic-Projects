Public Class Form1
    'Tazvik Ziauddin
    'Ch.4 Rev.3

    Private Sub btnAnswer_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAnswer.Click

        Dim sngLength As Single
        Dim sngWidth As Single
        Dim sngArea As Single

        sngLength = Val(Me.txtRectanglelength.Text)
        sngWidth = Val(Me.txtRectanglewidth.Text)
        sngArea = sngLength * sngWidth

        Me.lblAnswer.Text = sngArea 'Display answer

    End Sub

    Private Sub lblArea_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblArea.TextChanged

        'Clear the current answer When the user begins to type a new length

        Me.lblAnswer.Text = " "

    End Sub

End Class
