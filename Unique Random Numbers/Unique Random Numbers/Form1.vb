Public Class Form1
    'Tazvik Ziauddin
    'Ch.6 Rev.3

    Private Sub btnGenerateNumbers_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGenerateNumbers.Click

        Dim intUniqueNumber1 As Integer
        Dim intUniqueNumber2 As Integer
        Dim intUniqueNumber3 As Integer
        Dim intlargestNumber As Integer
        Dim strUserNumber As String
        Dim intloop As Integer

        Do
            strUserNumber = InputBox("Enter a number greater than 3", "Enter a Number")
            intlargestNumber = Val(strUserNumber)
        Loop While intlargestNumber <= 3

        Do
            intUniqueNumber1 = Int((intlargestNumber - 1 + 1) * Rnd()) + 1
            intUniqueNumber2 = Int((intlargestNumber - 1 + 1) * Rnd()) + 1
            intUniqueNumber3 = Int((intlargestNumber - 1 + 1) * Rnd()) + 1

            intloop = intloop + 1

        Loop While intUniqueNumber1 = intUniqueNumber2 Or intUniqueNumber2 = intUniqueNumber3 Or intUniqueNumber1 = intUniqueNumber3

        Me.lblUniqueNumber1.Text = intUniqueNumber1
        Me.lblUniqueNumber2.Text = intUniqueNumber2
        Me.lblUniqueNumber3.Text = intUniqueNumber3
        Me.lblLoopCounter.Text = intloop

    End Sub

End Class
