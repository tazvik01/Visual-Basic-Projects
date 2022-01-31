Public Class Form1
    'Tazvik Ziauddin 
    'Ch.9 Rev.2

    Private Sub btnRollDice_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRollDice.Click

        Dim intNumRolls As Integer = Val(Me.txtRolls.Text)
        Dim intCounts(18) As Integer
        Call CountTrials(intNumRolls, intCounts)
        Call DisplayRollsCounts(intCounts, Me.lstRollsOutcomes)

    End Sub
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'Simulates intNumRolls rolls of three dice and keeps count of the 
    'outcomes.
    '
    'Pre:IntCounts() has elements with at least index values 3 through 18.
    'Post:INumRolls dice rolls simulated. Counts of intNumRolls
    'simulated dice rolls stored in intcounts().
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Sub CountTrials(ByVal intNumRolls As Integer, _
    ByRef intCounts() As Integer)

        Dim intRollOutcome As Integer

        Randomize()
        Dim intRoll As Integer

        For intRoll = 1 To intNumRolls
            intRollOutcome = (Int(6 * Rnd()) + 1) + (Int(6 * Rnd()) + 1) + (Int(6 * Rnd()) + 1)
            intCounts(intRollOutcome) = intCounts(intRollOutcome) + 1
        Next intRoll

    End Sub

    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'Displays the contents of intCounts() in a list box.
    '
    'pre: intCounts() has elements with at least index values 3 through 18.
    'post:Elements of intCounts() displayed in a list box.
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Sub DisplayRollsCounts(ByRef intCounts() As Integer, _
        ByRef lstList As ListBox)

        Dim intRollOutcome As Integer

        For intRollOutcome = 3 To 18
            lstList.Items.Add(intRollOutcome & vbTab & _
            intCounts(intRollOutcome))
        Next intRollOutcome

    End Sub

    Private Sub txtRolls_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRolls.TextChanged

        Me.lstRollsOutcomes.Items.Clear()

    End Sub

End Class
