Public Class Form1
    'Tazvik Ziauddin
    'Ch.7 Rev.2
    '21/10/17

    Const intMIN As Integer = 1
    Const intMAX As Integer = 50

    Private Sub btnCheckGuess_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCheckGuess.Click

        Dim IntGuess As Integer
       
        Randomize()
        Static intSecretNumber As Integer = Int((intMAX - intMIN + 1) * Rnd()) + intMIN

        Static intCount As Integer = 0
        intCount = intCount + 1
        MessageBox.Show(intCount)

        IntGuess = Val(Me.txtPlayerGuess.Text)
        If IntGuess < 1 Or IntGuess > 50 Then
            MessageBox.Show("Guess out of range.")
        ElseIf IntGuess = intSecretNumber Then
            Me.lblMessage.Text = "You guessed it!"
            MessageBox.Show(intCount)
        Else
            Call GiveHint(intSecretNumber, IntGuess)
        End If

    End Sub

    Private Sub txtPlayerGuess_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPlayerGuess.TextChanged

        Me.lblMessage.Text = " "

    End Sub

    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'Determines if intFirstNum is larger than intSecondNum and then displays an 
    'appropriate message.
    '
    'Post: A message is displayed in a message box.
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

    Sub GiveHint(ByVal intFirstNum As Integer, ByVal intSecondNum As Integer)

        If intFirstNum > intSecondNum Then
            MessageBox.Show("Too low.")
        Else
            MessageBox.Show("Too high.")
        End If

    End Sub

End Class
