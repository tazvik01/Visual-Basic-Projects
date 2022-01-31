Public Class Form1
    'Tazvik Ziuaddin
    'Ch.5 Rev.7
    '10/11/2017

    Private Sub btnRandomNumbers_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRandomNumbers.Click

        Randomize()
        Me.lblRandNum1.Text = Int(21 * Rnd()) + 10
        Me.lblRandNum2.Text = Int(21 * Rnd()) + 10
        Me.lblRandNum3.Text = Int(21 * Rnd()) + 10
        Me.lblRandNum4.Text = Int(21 * Rnd()) + 10
        Me.lblRandNum5.Text = Int(21 * Rnd()) + 10
        Me.lblRandNum6.Text = Int(21 * Rnd()) + 10

    End Sub

End Class
