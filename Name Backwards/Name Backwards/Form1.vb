Public Class Form1
    'Tazvik Ziauddin
    'Ch.6 Ex.11

    Private Sub btnDisplayBackwards_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDisplayBackwards.Click

        Dim strName As String
        Dim intLength As Integer
        Dim intLoop As Integer
        Dim strNameBackwards As String

        strName = Me.txtName.Text
        strName = strName.ToLower
        intLength = strName.Length - 1

        For intLoop = intLength To 0 Step -1
            strNameBackwards = strNameBackwards & strName.Substring(intLoop, 1)
        Next intLoop

        Me.lblBackwards.Text = strNameBackwards


    End Sub

End Class
