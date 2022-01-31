Public Class Form1
    'Tazvik Ziauddin
    'Ch.5 Rev.10
    '10/12/2017

    Private Sub btnGo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGo.Click

        Const intROCK As Integer = 1
        Const intPAPER As Integer = 2
        Const intSCISSORS As Integer = 3
        Dim intComputerThrow As Integer

        'Generate Computer throw
        Randomize()
        intComputerThrow = Int(3 * Rnd()) + 1

        If Me.radRock.Checked Then
            If intComputerThrow = intROCK Then
                Me.lblWinner.Text = "Computerthrows Rock.It's a Draw!"
            ElseIf intComputerThrow = intPAPER Then
                Me.lblWinner.Text = "Computer throws Paper.Computer wins!"
            ElseIf intComputerThrow = intSCISSORS Then
                Me.lblWinner.Text = "Computer throws Scissors.You win!"
            End If
        ElseIf Me.radPaper.Checked Then
            If intComputerThrow = intROCK Then
                Me.lblWinner.Text = "Computer throws Rock.Computer wins!"
            ElseIf intComputerThrow = intPAPER Then
                Me.lblWinner.Text = "Computer throws Paper.It's a Draw!"
            ElseIf intComputerThrow = intSCISSORS Then
                Me.lblWinner.Text = "Computer throws Scissors.Computer win!"
            End If
        ElseIf Me.radScissors.Checked Then
            If intComputerThrow = intROCK Then
                Me.lblWinner.Text = "Computer throws Rock.Computer wins!"
            ElseIf intComputerThrow = intPAPER Then
                Me.lblWinner.Text = "Computer throws Paper.You win!"
            ElseIf intComputerThrow = intSCISSORS Then
                Me.lblWinner.Text = "Computer throws Scissors. It's a Draw!"
            End If
        End If

    End Sub

End Class
