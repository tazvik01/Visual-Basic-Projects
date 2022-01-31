Public Class Form1
    'Tazvik Ziauddin
    'Ch.7 Rev.9

    Inherits System.Windows.Forms.Form

    Dim sngOp1 As Single = 0
    Dim sngOp2 As Single = 0
    Dim strOperator As String = Nothing
    Dim blnNewOp As Boolean = True

    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'Updates the calculator display
    '
    'Pre: Global variable blnNewOp is True when the current display should be changed to a new
    'number and false when the current display should be updated with a new digit.The Tag
    'Property of the button clicked containes the number corresponding to the number on the button.
    'Post: The calculator display contains a new number or an additional digit has
    'been added to the existing display.
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Private Sub btNumber_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles btnDot.Click, btn0.Click, btn1.Click, btn2.Click, btn3.Click, btn4.Click, _
    btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click

        Dim btnNumberClicked As Button = sender 'Contains properties of clicked button
        If blnNewOp Then
            Me.txtDisplay.Text = btnNumberClicked.Tag
            blnNewOp = False
        Else
            Me.txtDisplay.Text = Me.txtDisplay.Text & btnNumberClicked.Tag
        End If

    End Sub

    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'Clears the calculator display
    '
    'post:The calculator display contains a 0 and global variables have been reinitialized
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Private Sub btnClear_Click(ByVal Sender As System.Object, ByVal e As System.EventArgs) _
    Handles btnClear.Click

        Me.txtDisplay.Text = "0"
        sngOp1 = 0
        sngOp2 = 0
        blnNewOp = True
        strOperator = Nothing

    End Sub

    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'Closes the application.
    '
    'post:The calculator program is ended.
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Private Sub btnOff_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
    Handles btnOff.Click

        End

    End Sub

    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'Updates the value of the operands and shows the result of a calculation
    'on the calculator display if two operands have been entered.
    '
    'post:The value of the first operand is assigned the value on the calculator display if an operator
    'has not been previousely clicked or the equal sign was the last operator clicked. If an operator as
    'previousely clicked, the second operand is assigned the value on the calculator display and the 
    'result of the calculation is shown on the calculator display.
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Private Sub btnOperator_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
    Handles btnPlus.Click, btnMinus.Click, btnTimes.Click, btnDivide.Click, btnEqual.Click, btnIntegerDivision.Click

        'No operator previousely clicked or  calculation just performed
        If (sngOp1 = 0 And strOperator = Nothing) Or strOperator = "=" Then
            sngOp1 = Val(Me.txtDisplay.Text)
        Else                                                          'second operand entered and a second operator clicked
            sngOp2 = Val(Me.txtDisplay.Text)
            sngOp1 = Calculate(sngOp1, sngOp2, strOperator)
            Me.txtDisplay.Text = sngOp1
        End If

        If sngOp2 = 0 And strOperator = "/" Then
            Me.txtDisplay.Text = "ERROR"
        End If

        'store operator for use when the next operator is clicked
        Dim btnOperatorSelected As Button = sender 'Contains properties of cliked button
        strOperator = btnOperatorSelected.Tag
        blnNewOp = True

    End Sub

    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'Returns the result of a calculation.
    '
    'post:The result of a calculation involving two operands has been performed.
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Function Calculate(ByVal sngFirstOperand As Single, ByVal sngSecondOperand As Single, _
    ByVal strOperator As String) As Single

        Select Case strOperator
            Case "+"
                Return (sngFirstOperand + sngSecondOperand)
            Case "-"
                Return (sngFirstOperand - sngSecondOperand)
            Case "X"
                Return (sngFirstOperand * sngSecondOperand)
            Case "/"
                Return (sngFirstOperand / sngSecondOperand)
            Case "\"
                Return (sngFirstOperand \ sngSecondOperand)
        End Select

    End Function

End Class
