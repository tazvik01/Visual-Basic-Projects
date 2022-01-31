Public Class Form1
    'Tazvik Ziauddin
    'Ch.6 Rev.2

    Dim intNumberOfScores As Integer
    Dim intSumOfScores As Integer

    Private Sub btnEnterScores_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEnterScores.Click

        Const strTITLE As String = "Grades"
        Const strPROMPT As String = "Enter a score (-1to finish):"
        Const intFLAG As Integer = -1
        Dim intNewScore As Integer
        intNumberOfScores = 0
        intSumOfScores = 0
        Dim strTemporaryScore As String

        'Clear labels
        Me.lblAverageMessage.Text = Nothing
        Me.lblAverage.Text = Nothing
        Me.lblScoresMessage.Text = Nothing
        Me.lblNumberOfScores.Text = Nothing

        'getScores
        Do
            strTemporaryScore = InputBox(strPROMPT, strTITLE)
            If strTemporaryScore = Nothing Then
                intNewScore = intFLAG
            Else
                intNewScore = Val(strTemporaryScore)
                If intNewScore <> intFLAG Then
                    intNumberOfScores = intNumberOfScores + 1
                    intSumOfScores = intSumOfScores + intNewScore
                End If
            End If
        Loop While intNewScore <> intFLAG

        Me.lblScoresMessage.Text = "Scores entered:"
        Me.lblNumberOfScores.Text = intNumberOfScores

    End Sub

    Private Sub btnAverageScore_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAverageScore.Click

        Dim sngAverage As Single

        If intNumberOfScores > 0 Then
            sngAverage = intSumOfScores / intNumberOfScores
            Me.lblAverage.Text = sngAverage
        Else
            Me.lblAverage.Text = 0
        End If

        Me.lblAverageMessage.Text = "Average Score:"

    End Sub

End Class
