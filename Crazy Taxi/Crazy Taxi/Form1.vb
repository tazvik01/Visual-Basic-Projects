Public Class Form1
    'Tazvik Ziauddin
    'Rushil Dave
    'Final Porject

    Private Sub mnuInstruction_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuInstruction.Click

        MessageBox.Show("In this game the players objective is to eat all the coins and dodge all the cars using the arrows on the keyboard. When the player bumps into a car the will end and the he or she will have the chance to play it again. ")

    End Sub

    Private Sub mnuExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuExit.Click

        End

    End Sub

    Private Sub btnStart_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnStart.Click

        Form2.Show()

    End Sub

End Class
