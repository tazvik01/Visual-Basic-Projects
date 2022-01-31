Public Class Form1
    'Tazvik Ziauddin
    'Ch.6 Rev.9

    Private Sub btnStart_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnStart.Click

        Dim strFirstName As String, strlastname As String
        Dim strFullName As String

        strFirstName = InputBox("Enter your First name", "Name")
        strlastname = InputBox("Enter your Last name", "Name")
        strFullName = strFirstName & " " & strlastname

        Me.lblFullName.Text = strFullName
    

    End Sub

End Class
