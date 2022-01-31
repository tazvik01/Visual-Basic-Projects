Public Class Form1
    'Tazvik Ziauddin
    'Ch.4 Excer.3

    Private Sub btnAnswer_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAnswer.Click

        Dim sngLength As Single
        Dim sngWidth As Single
        Dim sngArea As Single
        Dim sngPerimeter As Single

        sngLength = Val(Me.txtLength.Text)
        sngWidth = Val(Me.txtWidth.Text)
        sngArea = sngLength * sngWidth
        sngPerimeter = 2 * sngLength + 2 * sngWidth

        Me.lblAreaAnswer.Text = sngArea
        Me.lblPerimeterAnswer.Text = sngPerimeter

    End Sub
   
    Private Sub mnuExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuExit.Click

        End

    End Sub

End Class
