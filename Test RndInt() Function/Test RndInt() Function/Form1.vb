Public Class Form1
    'Tazvik Ziauddin
    'Ch.7 Rev.10

    Private Sub btnRandomize_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRandomize.Click

        Dim intLowNumber As Integer
        Dim intHighNumber As Integer
        Dim intAnswer As Integer

        intLowNumber = Val(Me.txtLowNumber.Text)
        intHighNumber = Val(Me.txtHighNumber.Text)
        intAnswer = RndInt(intLowNumber, intHighNumber)

        Me.lblAnswer.Text = intAnswer

    End Sub

    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'Returns a random number.
    '
    'post:The result of RndInt returns a random integer in the range between intLowNum to intHighNum 
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Function RndInt(ByVal intLowNum As Integer, ByVal intHighNum As Integer) As Integer

        Randomize()
        Return Int((intHighNum - intLowNum + 1) * Rnd()) + intLowNum

    End Function

End Class
