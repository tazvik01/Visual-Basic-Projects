Public Class Form1
    'Tazvik Ziauddin
    'Ch.3 Rev.6
   
    Private Sub mnuExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuExit.Click

        End

    End Sub

    Private Sub mnuSmile_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuSmile.Click

        Me.lblMessage.Text = "Smile!"

    End Sub
      
    Private Sub mnuHelloWorld_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuHelloWorld.Click

        Me.lblMessage.Text = "Hello, world!"

    End Sub

End Class
