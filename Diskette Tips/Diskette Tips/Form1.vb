Public Class Form1
    'Tazvik Ziauddin
    'Ch.7 Ex.1

    Private Sub btnTip_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTip.Click

        Call DisplayTip()

    End Sub

    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'Shows different tips using select case and generates random tips by calling random numbers.
    '
    'post: A message is displayed in a lablel.
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Sub DisplayTip()

        Dim intTip As Integer

        intTip = RndInt(1, 4)

        Select Case intTip
            Case 1
                Me.lblTip.Text = "Keep diskettes away from electrical and magnetic devices."
            Case 2
                Me.lblTip.Text = "Do not expose diskettes to either extreme cold or heat."
            Case 3
                Me.lblTip.Text = "Store diskettes away from dust, dirt, and moisture."
            Case 4
                Me.lblTip.Text = "Never touch the diskette's magnetic surface."
        End Select

    End Sub

    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'Returns a random number.
    '
    'post:The result of RndInt returns a random integer in the range between intLowNum to intHighNum 
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Function RndInt(ByVal intLowNum As Integer, ByVal intHighNum As Integer) As Integer

        Randomize()
        Return Int((intHighNum - intLowNum + 1) * Rnd()) + intLowNum

    End Function

End Class
