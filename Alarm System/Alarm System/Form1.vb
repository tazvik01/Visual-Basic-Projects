Public Class Form1
    'Tazvik Ziauddin
    'Ch.7 Ex.5

    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'Updates the alarm system display.
    'pre:Global variable blnNewOp is True when the current display should be changed to a new
    'number and false when the current display shoudl be updated with a new digit. The Tag
    'property of the button clicked contains the number corresponding to the number o the button.
    'post:The calculator display contains a new number or an additional digit has
    'been added to the existing display.
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Private Sub btnNumber_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btn0.Click, btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, _
        btn8.Click, btn9.Click

        Dim blnNewOp As Boolean
        Dim btnNumberClicked As Button = sender 'Contains properties of clicked button

        If blnNewOp Then
            Me.txtDisplay.Text = btnNumberClicked.Tag
            blnNewOp = False
        Else
            Me.txtDisplay.Text = Me.txtDisplay.Text & btnNumberClicked.Tag
        End If

    End Sub

    Private Sub btnEnter_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEnter.Click

        Const intCODE As Integer = 62498
        Dim intCodeTyped As Integer

        intCodeTyped = Val(Me.txtDisplay.Text)

        If intCodeTyped = intCODE Then
            MessageBox.Show("Accepted.")
        Else
            MessageBox.Show("Not Accepted.")
        End If

    End Sub

End Class
