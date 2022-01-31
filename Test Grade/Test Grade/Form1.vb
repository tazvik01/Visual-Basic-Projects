Public Class Form1
    'Tazvik Ziauddin
    'Ch.5 Rev.13

    Private Sub btnCheckGrade_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCheckGrade.Click

        Dim IntGrade As Integer
        IntGrade = Val(Me.txtGrade.Text)

        Select Case IntGrade
            Case Is > 100
                MessageBox.Show("Invalid grade.")
            Case Is >= 93
                Me.lblStatement.Text = "A"
            Case Is >= 85
                Me.lblStatement.Text = "B"
            Case Is >= 78
                Me.lblStatement.Text = "C"
            Case Is >= 69
                Me.lblStatement.Text = "D"
            Case Is >= 0
                Me.lblStatement.Text = "F"
            Case Is < 0
                MessageBox.Show("Invalid grade.")
        End Select

    End Sub

    Private Sub txtGrade_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtGrade.TextChanged

        Me.lblStatement.Text = " "

    End Sub

End Class
