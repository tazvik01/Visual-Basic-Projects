Public Class Form1
    'Tazvik Ziauddin
    'Ch.5 Rev.15
    '10/12/2017

    Dim IntComputerWins As Object
    Dim IntDraws As Object
    Dim IntPlayerWins As Object

    Private Sub btnGo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGo.Click

        Const intROCK As Integer = 1
        Const intPAPER As Integer = 2
        Const intSCISSORS As Integer = 3
        Dim intComputerThrow As Integer

        'Generate Computer throw
        Randomize()
        intComputerThrow = Int(3 * Rnd()) + 1

        Select Case intComputerThrow
            Case intROCK
                If Me.radRock.Checked Then
                    Me.lblWinner.Text = "Computerthrows Rock.It's a Draw!"
                    Static IntDraws As Integer = 0
                    IntDraws = IntDraws + 1
                    Me.lblNumbeOfDraws.Text = IntDraws
                ElseIf Me.radPaper.Checked Then
                    Me.lblWinner.Text = "Computer throws Paper.Computer wins!"
                    Static IntComputerWins As Integer = 0
                    IntComputerWins = IntComputerWins + 1
                    Me.lblComputerWins.Text = IntComputerWins
                ElseIf Me.radScissors.Text Then
                    Me.lblWinner.Text = "Computer throws Scissors.You win!"
                    Static IntPlayerWins As Integer = 0
                    IntPlayerWins = IntPlayerWins + 1
                    Me.lblPlayerWins.Text = IntPlayerWins
                End If
            Case intPAPER
                If Me.radRock.Checked Then
                    Me.lblWinner.Text = "Computer throws Rock.Computer wins!"
                    IntComputerWins = IntComputerWins + 1
                    Me.lblComputerWins.Text = IntComputerWins
                ElseIf Me.radPaper.Checked Then
                    Me.lblWinner.Text = "Computer throws Paper.It's a Draw!"
                    IntDraws = IntDraws + 1
                    Me.lblNumbeOfDraws.Text = IntDraws
                ElseIf Me.radScissors.Checked Then
                    Me.lblWinner.Text = "Computer throws Scissors.You win!"
                    IntPlayerWins = IntPlayerWins + 1
                    Me.lblPlayerWins.Text = IntPlayerWins
                End If
            Case intSCISSORS
                If Me.radRock.Checked Then
                    Me.lblWinner.Text = "Computer throws Rock.Computer wins!"
                    IntComputerWins = IntComputerWins + 1
                    Me.lblComputerWins.Text = IntComputerWins
                ElseIf Me.radPaper.Checked Then
                    Me.lblWinner.Text = "Computer throws Paper.You win!"
                    IntPlayerWins = IntPlayerWins + 1
                    Me.lblPlayerWins.Text = IntPlayerWins
                ElseIf Me.radScissors.Checked Then
                    Me.lblWinner.Text = "Computer throws Scissors. It's a Draw!"
                    IntDraws = IntDraws + 1
                    Me.lblNumbeOfDraws.Text = IntDraws
                End If
        End Select

    End Sub

End Class
