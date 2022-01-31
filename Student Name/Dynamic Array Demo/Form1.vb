Public Class Form1
    'Tazvik Ziauddin
    'Ch.9 Rev.5

    Private Sub btnProcess_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnProcess.Click

        Static strDataArray(-1) As String                 'array with zero elements
        Dim strIndex As String

        Dim strNumEntered As String = (Me.txtName.Text)
        If Me.radAdd.Checked Then
            Call AddItem(strDataArray, strNumEntered)
            Call DisplayData(strDataArray, Me.lstItemIndex)
        ElseIf Me.radRemove.Checked Then
            Call RemoveItem(strDataArray, strNumEntered)
            Call DisplayData(strDataArray, Me.lstItemIndex)
        ElseIf Me.radFind.Checked Then
            strIndex = FindItemIndex(strDataArray, strNumEntered)
            If strIndex = -1 Then
                Me.lstItemIndex.Items.Add("Item not found")
            Else
                Me.lstItemIndex.Items.Add("Item at index" & strIndex)
            End If
        End If

    End Sub

    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'Adds new element intNumToAdd as the last element of intDataArray().
    '
    'pre: intDataArray() contains Zero or more elements.
    'post: intDataArray() contains a new element intNumToAdd as the
    'last element of the array.
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Sub AddItem(ByRef strDataArray() As String, _
    ByVal strNumToAdd As String)

        'Use Length to size array because that value is one greater than the
        'current highest index value
        ReDim Preserve strDataArray(strDataArray.Length)
        strDataArray(strDataArray.Length - 1) = strNumToAdd

    End Sub

    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'Removes the first occurrence of intNumToRemove from intDataArray()
    'and sizes the array with one less element.
    '
    'post:If intNumToRemove found, intDataArray() has one less element
    'and intNumToRemove is deleted from array.
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Sub RemoveItem(ByRef strDataArray() As String, _
             ByVal strNumToRemove As String)

        Dim strItemIndex As String
        strItemIndex = FindItemIndex(strDataArray, StrNumToRemove)

        If strItemIndex > -1 Then
            Dim intIndex As Integer
            For intIndex = strItemIndex To strDataArray.Length - 2
                strDataArray(intIndex) = strDataArray(intIndex + 1)
            Next intIndex
            ReDim Preserve strDataArray(strDataArray.Length - 2)
        End If

    End Sub

    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'Returns the index of the first occurrence of intSearchItem in 
    'intDataArray() or -1 if intSearchItem not found.
    '
    'post: Index of the first occurrence of intSearchItem returned, or
    '-1 returned if intSearchItem not found.
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Function FindItemIndex(ByRef strDataArray() As String, _
    ByVal strSearchItem As String) As String

        'Empty array
        If strDataArray.Length = 0 Then
            Return -1       'Item not found
        End If

        'Find search item
        Dim strIndex As String = 0
        Do While (strDataArray(strIndex) <> strSearchItem) _
          And (strIndex < strDataArray.Length - 1)
            strIndex = strIndex + 1
        Loop
        If strDataArray(strIndex) = strSearchItem Then
            Return StrIndex       'Item found
        Else
            Return -1            'Item not found
        End If

    End Function

    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'Clears a list boxand then displays intDataAray() elements int the list box.
    '
    'pre: intDataArray.Length >0
    'post: List box cleared of any previous items. intDataArray()
    'elements displayed in the list box.
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Sub DisplayData(ByRef strDataArray() As String, _
        ByRef lstList As ListBox)

        lstList.Items.Clear()

        Dim intIndex As Integer
        For intIndex = 0 To strDataArray.Length - 1
            lstList.Items.Add(intIndex & vbTab & strDataArray(intIndex))
        Next intIndex

    End Sub

End Class