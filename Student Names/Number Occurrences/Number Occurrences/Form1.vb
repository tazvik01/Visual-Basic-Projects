Public Class Form1
    'Tazvik Ziuaddin
    'Ch.9 Rev.3

    Private Sub btnCountLetters_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNumCount.Click

        Const intUNICODEZ As Integer = 9
        Dim intNumberCounts(intUNICODEZ) As Integer

        Dim strPhrase As String = Me.txtCount.Text
        Call NumCount(strPhrase, intNumberCounts)
        Call DisplayNumberCounts(intNumberCounts, Me.lstnumoccur)

    End Sub
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'Counts the occurrences of numbers a through 9 in a string, regardless of case.
    '
    'pre:intLetterCounts() has elements with at least index values 65 through 90
    'corresponding to the Unicode value for 0 through the Unicode value For 9.
    'post: Counts of numbers stored in intNumberCounts().
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Sub NumCount(ByVal strPhrase As String, _
        ByRef intNumberCounts() As Integer)

        Dim intNumberIndex As Integer
        Dim chrNumber As Char

        Dim intCharacter As Integer
        For intCharacter = 0 To strPhrase.Length - 1
            chrNumber = Char.ToUpper(strPhrase.Chars(intCharacter))
            If chrNumber >= "0" And chrNumber <= "9" Then
                intNumberIndex = Val(chrNumber)
                intNumberCounts(intNumberIndex) = intNumberCounts(intNumberIndex) + 1
            End If
        Next intCharacter

    End Sub

    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'Displays the contents of intNumberCounts() in a listbox.
    '
    'post:Elements of intNumberCounts() displayed in a list box.
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Sub DisplayNumberCounts(ByRef intNumberCounts() As Integer, _
            ByRef lstList As ListBox)

        Dim intNumber As Integer
        For intNumber = Val("0") To Val("9")
            lstList.Items.Add((intNumber) & vbTab & intNumberCounts(intNumber))
        Next intNumber

    End Sub

    Private Sub txtCount_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCount.TextChanged

        Me.lstnumoccur.Items.Clear()

    End Sub

End Class
