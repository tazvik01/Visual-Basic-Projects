Public Class Form1
    'Tazvik Ziauddin
    'Ch.6 Rev.5

    Private Sub btnSum_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSum.Click

        Dim intOddNumber As Integer
        Dim intSum As Integer
        Dim intLoop As Integer

        intOddNumber = Val(Me.txtOddNumber.Text)

        For intLoop = 1 To intOddNumber Step 2
            intSum = intSum + intLoop
        Next

        Me.lblOddNumberSum.Text = intSum

    End Sub

    Private Sub txtOddNumber_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtOddNumber.TextChanged

        Me.lblOddNumberSum.Text = Nothing

    End Sub

End Class
