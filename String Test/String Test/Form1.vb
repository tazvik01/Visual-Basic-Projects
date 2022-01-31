Public Class Form1
    'Tazvik Ziauddin
    'Ch.6 Rev.7

    Private Sub btnDisplayData_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDisplayData.Click

        Dim strWord As String
        Dim intLength As Integer
        Dim chrFirstLetter As Char
        Dim chrMiddleLetter As Char
        Dim chrLastLetter As Char
       
        strWord = Me.txtWord.Text
        strWord = strWord.ToLower
        intLength = strWord.Length - 1

        chrFirstLetter = strWord.Chars(0)
        chrMiddleLetter = strWord.Chars(intLength / 2)
        chrLastLetter = strWord.Chars(intLength)

        Me.lblFirstLetter.Text = chrFirstLetter
        Me.lblMiddleLetter.Text = chrMiddleLetter
        Me.lblLastLetter.Text = chrLastLetter

    End Sub

End Class
