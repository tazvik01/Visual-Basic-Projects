Public Class Form1
    'Tazvik Ziauddin
    'Ch.6 Rev.10

    Private Sub btnStart_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnStart.Click

        Dim chrSecretMessege As Char
        Dim chrNewLetter As Char
        Dim intLoop As Integer
        Dim intCharcode As Integer
        Dim lngUnicode As Long

        For intLoop = 1 To 6
            chrSecretMessege = InputBox("Enter six upper case letters", "Letter")
            chrNewLetter = Char.ToLower(chrSecretMessege)
            intCharcode = AscW(chrNewLetter)
            lngUnicode = lngUnicode & intCharcode
        Next

        Me.lblSecretMessage.Text = lngUnicode

    End Sub

End Class
