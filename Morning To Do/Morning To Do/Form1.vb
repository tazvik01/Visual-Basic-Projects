Public Class Form1
    'Tazvik Ziauddin
    'Ch.5 Rev.16
    '21/10/2017


    Private Sub chkLunch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkLunch.Click

        If Me.chkLunch.Checked Then
            MessageBox.Show("Don't forget bottled water!")
        End If

    End Sub

    Private Sub btnAllDone_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAllDone.Click

        If Not (Me.chkBed.Checked And Me.chkLunch.Checked _
                And Me.chkHomework.Checked And Me.chkTeeth.Checked) Then
            MessageBox.Show("Did you forget something?")
        Else
            End
        End If

    End Sub

End Class
