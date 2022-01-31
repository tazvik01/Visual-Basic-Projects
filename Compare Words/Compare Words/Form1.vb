Public Class Form1
    'Tazvik Ziauddin
    'Ch.6 Review 11

    Private Sub btnCompareWords_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCompareWords.Click

        Dim strFirstWord As String
        Dim strSecondWord As String

        strFirstWord = Me.txtFirstWord.Text
        strSecondWord = Me.txtSecondWord.Text

        Select Case String.Compare(strFirstWord, strSecondWord, True)
            Case 0
                Me.lblStatement.Text = strFirstWord & " is the same as " & strSecondWord
            Case Is < 0
                Me.lblStatement.Text = "Alphabetically before."
            Case Is > 0
                Me.lblStatement.Text = "Alphabetically after."
        End Select

    End Sub

End Class
