Public Class Form1
    'Tazvik Ziauddin
    'Ch.5 Ex.5

    Private Sub btnWhatToDo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnWhatToDo.Click

        Dim chrComputerBeep As Char
        Dim chrHardDriveSpin As Char

        chrComputerBeep = Me.txtComputerBeep.Text
        chrHardDriveSpin = Me.txtHardDriveSpin.Text

        If chrComputerBeep = "y" Or chrComputerBeep = "y" And chrHardDriveSpin = "Y" Or chrHardDriveSpin = "y" Then
            Me.lblStatement.Text = "Contact tech support."
        ElseIf chrComputerBeep = "y" Or chrComputerBeep = "Y" And chrHardDriveSpin = "N" Or chrHardDriveSpin = "n" Then
            Me.lblStatement.Text = "Check drive contact"
        ElseIf chrComputerBeep = "n" Or chrComputerBeep = "N" And chrHardDriveSpin = "N" Or chrHardDriveSpin = "n" Then
            Me.lblStatement.Text = "Bring  Computer to repair Center."
        ElseIf chrComputerBeep = "n" Or chrComputerBeep = "N" And chrHardDriveSpin = "Y" Or chrHardDriveSpin = "y" Then
            Me.lblStatement.Text = "Check the speaker connection"
        End If

    End Sub

End Class
