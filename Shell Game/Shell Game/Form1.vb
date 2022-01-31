Public Class Form1
    'Tazvik Ziauddin
    'Ch.7 Rev.6
    '11/28/2017

    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'Determines which shell was clicked and displays a message if shell clicked is the 
    'Same as a randomly chosel shell.
    '
    'Pre: Shell picture objects have valid Tag properties.
    'Post: The hidden shell is shown and a message box is displayed to the user.
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Private Sub picShell_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
    Handles picShell1.Click, picShell2.Click, picShell3.Click

        'Determines which shell was clicked by user
        Dim picShellClicked As PictureBox = sender
        Dim intShellClicked As Integer = Val(picShellClicked.Tag)

        'Pick the shell that hides the pearl
        Randomize()
        Dim intShellWithPearl As Integer = Int(3 * Rnd()) + 1

        'Show the pearl
        Select Case intShellWithPearl
            Case 1
                Me.picPearl1.Visible = True
            Case 2
                Me.picPearl2.Visible = True
            Case 3
                Me.picPearl3.Visible = True
        End Select

        'Display message to player
        If intShellClicked = intShellWithPearl Then
            MessageBox.Show("You won!")
        Else
            MessageBox.Show("Sorry,you lose.")
        End If

        'Hide pearl again
        Select Case intShellWithPearl
            Case 1
                Me.picPearl1.Visible = False
            Case 2
                Me.picPearl2.Visible = False
            Case 3
                Me.picPearl3.Visible = False
        End Select

    End Sub

End Class
