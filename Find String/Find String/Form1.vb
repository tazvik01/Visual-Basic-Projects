Public Class Form1
    'Tazvik Ziauddin
    'Ch.6 Rev.8

    Private Sub btnFindString_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFindString.Click

        Dim strWord As String
        Dim strSearchText As String
        Dim intPosition As Integer

        strWord = Me.txtEnterText.Text
        strSearchText = Me.txtSearch.Text

        intPosition = strWord.IndexOf(strSearchText)

        Me.lblPosition.Text = intPosition

    End Sub

End Class
