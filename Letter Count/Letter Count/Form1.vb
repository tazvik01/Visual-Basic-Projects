Public Class Form1
    'Tazvik Ziauddin
    'Ch.6 Rev.6

    Private Sub btnCountLetter_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCountLetter.Click

        Dim strWord As String
        Dim intLength As Integer
        Dim intLoop As Integer
        Dim intCount As Integer
        Dim strLetter As String

        strWord = Me.txtWord.Text
        strLetter = Me.txtLetter.Text
        strWord = strWord.ToLower
        intLength = strWord.Length - 1

        For intLoop = 0 To intLength
            If strLetter = strWord.Chars(intLoop) Then
                intCount = intCount + 1
            End If
        Next intLoop

        Me.lblNumberOfOccurence.Text = intCount

    End Sub

End Class
