Public Class Form1
    'Tazvik Ziauddin
    'Ch.9 Rev.5

    Private Sub btnProcess_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnProcess.Click

        Static intDataArray(-1) As Integer                 'array with zero elements
        Dim intIndex As Integer

        Dim intNumEntered As Integer = Val(Me.txtVal.Text)
        If Me.radAdd.Checked Then
            Call AddItem(intDataArray, intNumEntered)
            Call DisplayData(intDataArray, Me.lstItemIndex)
        ElseIf Me.radRemove.Checked Then
            Call RemoveItem(intDataArray, intNumEntered)
            Call DisplayData(intDataArray, Me.lstItemIndex)
        ElseIf Me.radFind.Checked Then
            intIndex = FindItemIndex(intDataArray, intNumEntered)
            If intIndex = -1 Then
                Me.lstItemIndex.Items.Add("Item not found")
            Else
                Me.lstItemIndex.Items.Add("Item at index" & intIndex)
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
    Sub AddItem(ByRef intDataArray() As Integer, _
    ByVal intNumToAdd As Integer)

        'Use Length to size array because that value is one greater than the
        'current highest index value
        ReDim Preserve intDataArray(intDataArray.Length)
        intDataArray(intDataArray.Length - 1) = intNumToAdd

    End Sub

    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'Removes the first occurrence of intNumToRemove from intDataArray()
    'and sizes the array with one less element.
    '
    'post:If intNumToRemove found, intDataArray() has one less element
    'and intNumToRemove is deleted from array.
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Sub RemoveItem(ByRef intDataArray() As Integer, _
             ByVal intNumToRemove As Integer)

        Dim intItemIndex As Integer
        intItemIndex = FindItemIndex(intDataArray, intNumToRemove)

        If intItemIndex > -1 Then
            Dim intIndex As Integer
            For intIndex = intItemIndex To intDataArray.Length - 2
                intDataArray(intIndex) = intDataArray(intIndex + 1)
            Next intIndex
            ReDim Preserve intDataArray(intDataArray.Length - 2)
        End If

    End Sub

    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'Returns the index of the first occurrence of intSearchItem in 
    'intDataArray() or -1 if intSearchItem not found.
    '
    'post: Index of the first occurrence of intSearchItem returned, or
    '-1 returned if intSearchItem not found.
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Function FindItemIndex(ByRef intDataArray() As Integer, _
    ByVal intSearchItem As Integer) As Integer

        'Empty array
        If intDataArray.Length = 0 Then
            Return -1       'Item not found
        End If

        'Find search item
        Dim intIndex As Integer = 0
        Do While (intDataArray(intIndex) <> intSearchItem) _
          And (intIndex < intDataArray.Length - 1)
            intIndex = intIndex + 1
        Loop
        If intDataArray(intIndex) = intSearchItem Then
            Return intIndex       'Item found
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
    Sub DisplayData(ByRef intDataArray() As Integer, _
        ByRef lstList As ListBox)

        lstList.Items.Clear()

        Dim intIndex As Integer
        For intIndex = 0 To intDataArray.Length - 1
            lstList.Items.Add(intIndex & vbTab & intDataArray(intIndex))
        Next intIndex

    End Sub

End Class
