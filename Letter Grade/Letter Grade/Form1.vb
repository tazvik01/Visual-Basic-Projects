Public Class Form1
    'Tazvik Ziauddin
    'Ch.7 Rev.7
    '11/29/2017

    Private Sub btnLetterGrade_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLetterGrade.Click

        Const intLOWESTSCORE As Integer = 0
        Const intHIGHESTSCORE As Integer = 100
        Dim intScoreEntered As Integer

        intScoreEntered = Val(Me.txtScore.Text)

        If Not ValidEntry(intScoreEntered, intHIGHESTSCORE, intLOWESTSCORE) Then
            MessageBox.Show("Enter a score between" & intLOWESTSCORE & " and " _
                             & intHIGHESTSCORE)
            Me.txtScore.Text = Nothing
            Me.lblLetterGrade.Text = Nothing
        Else
            Me.lblLetterGrade.Text = " Your grade is " & LetterGrade(intScoreEntered)
        End If

    End Sub

    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'Returms True if lowerLimit <+ intuserNum <=intUpperLimit.
    '
    'Post:True returned if intLowerLimit =intUserNUm <=intUpperLimit
    'Otherwise False returned.
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Function ValidEntry(ByVal intUserNUm As Integer, ByVal intUpperLimit As Integer, _
    ByVal intLowerLimit As Integer) As Boolean

        If intUserNUm > intUpperLimit Or intUserNUm < intLowerLimit Then
            Return False
        Else
            Return True
        End If

    End Function

    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'Returns a letter grade coresponding to sngScore.
    '
    'Post:A letter grade has been returned.
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Function LetterGrade(ByVal intScore As Integer) As Char

        If intScore >= 90 Then
            Return "A"
        ElseIf intScore >= 80 Then
            Return "B"
        ElseIf intScore > +70 Then
            Return "C"
        ElseIf intScore >= 60 Then
            Return "D"
        Else
            Return "F"
        End If

    End Function

    Private Sub txtScore_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtScore.TextChanged

        Me.lblLetterGrade.Text = " "

    End Sub

End Class
