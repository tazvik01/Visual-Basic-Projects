Public Class Form1
    'Tazvik Ziauddin
    'Ch.7 Rev.4

    Private Sub btnSort_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSort.Click

        Dim intFirstNumber As Integer
        Dim intSecondNumber As Integer

        intFirstNumber = Me.txtFirstNumber.Text
        intSecondNumber = Me.txtSecondNumber.Text

        Call LowestToHighest(intFirstNumber, intSecondNumber)

        Me.lblSortedNumber.Text = intFirstNumber & " . " & intSecondNumber

    End Sub

    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'Determines ifintLowest is the lesser of two values and then swaps
    'intLowerst and intHighest if necessary.
    '
    'Post: intLowest is the lesser of the two arguments passed.
    'intHighest is the greater of the two arguments passed.
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

    Sub LowestToHighest(ByRef intLowest As Integer, _
    ByRef intHighest As Integer)

        Dim intTemp As Integer
        If intLowest > intHighest Then 'Swap Values
            intTemp = intLowest
            intLowest = intHighest
            intHighest = intTemp
        End If

    End Sub

End Class
