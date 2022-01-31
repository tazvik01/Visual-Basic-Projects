Public Class Form1
    'Tazvik Ziauddin
    'Ch.6 For Next Test


    Private Sub btnEnter_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEnter.Click

        Dim strName As String
        Dim intLength As Integer
        Dim intLoop As Integer
        Dim chrLetter As Char

        strName = Me.txtName.Text
        strName = strName.ToLower
        intLength = strName.Length - 1

        'For intLoop = 0 To intLength 'Converts a string into characters moving forward
        '    chrLetter = strName.Chars(intLoop)
        '    MessageBox.Show(chrLetter)
        'Next intLoop

        'For intLoop = intLength To 0 Step -1  'Display the characters of a string backwards
        '    chrLetter = strName.Chars(intLoop)
        '    MessageBox.Show(chrLetter)
        'Next intLoop

        For intLoop = 100 To 1 Step -1 'Count down
            MessageBox.Show(intLoop)
        Next intLoop

        'Lebels go down here

    End Sub

End Class
