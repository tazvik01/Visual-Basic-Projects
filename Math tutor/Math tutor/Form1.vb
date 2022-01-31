Public Class Form1
    'Tazvik Ziauddin
    'Ch.5 Ex.10

    Private Sub btnNewProblem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNewProblem.Click

        Dim intAnswer As Integer
        Dim intFirstNumber As Integer
        Dim intSecondNumber As Integer
        Dim intOperator As Integer
      
        intAnswer = Val(Me.txtAnswer.Text)

        intFirstNumber = Int((10 - 1 + 1) * Rnd()) + 1
        intSecondNumber = Int((10 - 1 + 1) * Rnd()) + 1

        intOperator = "*,+,-,/"

        Me.lblFirstNumber.Text = intFirstNumber
        Me.lblSecondNumber.Text = intSecondNumber

    End Sub

    Private Sub btnCheckAnswer_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCheckAnswer.Click

    End Sub

    Private Sub btnShowAnswer_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnShowAnswer.Click

    End Sub
End Class
