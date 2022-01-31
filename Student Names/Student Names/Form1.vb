Public Class Form1
    'Tazvik Ziauddin
    'Ch.9 Rev.1
    '9/5/2018

    Private Sub btnAddNames_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddNames.Click

        Const intNUMNAMES As Integer = 5
        Dim strStuNames(intNUMNAMES - 1)
        Dim intName As Integer

        'get student names from user
        For intName = 0 To strStuNames.Length - 1
            strStuNames(intName) = InputBox("Enter student's first name:", "Students")
        Next intName

        'add names to list box
        For intName = 0 To strStuNames.Length - 1
            Me.lstStuNames.Items.Add(strStuNames(intName))
        Next intName

    End Sub

End Class
