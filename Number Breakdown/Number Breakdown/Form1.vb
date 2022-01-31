Public Class Form1
    'Tazvik Ziuaddin
    'Ch.6 Rev.3
    '11/22/2017

    Private Sub btnBreakDown_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBreakDown.Click

        Dim intNumberEntered As Integer
        Dim intOnesDigit As Integer
        Dim intTensDigit As Integer
        Dim inthundredsDigit As Integer

        intNumberEntered = Val(Me.txtNUmber.Text)

        If intNumberEntered < 10 Then
            Me.lblDigits.Text = "This first digit is: " & intNumberEntered
        ElseIf intNumberEntered < 100 Then
            Call TwoDigits(intNumberEntered, intTensDigit, intOnesDigit)
            Me.lblDigits.Text = "The first digit is: " & intTensDigit & _
                vbCrLf & "The second digit is : " & intOnesDigit
        ElseIf intNumberEntered < 1000 Then
            Call ThreeDigits(intNumberEntered, inthundredsDigit, intTensDigit, intOnesDigit)
            Me.lblDigits.Text = "The first digit is: " & inthundredsDigit & _
                vbCrLf & "The second digit is:" & intTensDigit & _
            vbCrLf & "The third digit is: " & intOnesDigit
        Else
            Me.lblDigits.Text = "Invalid entry."
        End If

    End Sub

    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'The digits of a two-digit number are returned is separate parameters
    '
    'pre:intNum is a number less that 100 and greater than -100
    'Post:intFirstDigit is a number between 0 and 9 inclusive.
    'intSecondDigit is a number between 0 and 9 inclusive.
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

    Sub TwoDigits(ByVal intNum As Integer, ByRef intFirstDigit As Integer, _
    ByRef intSecondDigit As Integer)

        intFirstDigit = intNum \ 10
        intSecondDigit = intNum Mod 10

    End Sub

    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'The digits a three-digit number are returned in separate parameters
    '
    'Pre:intNum is a number less than 1000 and grater than -1000
    'Post: intFirstDigit is anumber between 0 and 9 inclusive.
    'intSecondDigit is a number between 0 and 9 inclusive.
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

    Sub ThreeDigits(ByVal intNum As Integer, ByRef intFirstDigit As Integer, _
    ByRef intSecondDigit As Integer, ByRef intThirdDigit As Integer)

        intFirstDigit = intNum \ 100
        intNum = intNum Mod 100
        Call TwoDigits(intNum, intSecondDigit, intThirdDigit)

    End Sub

End Class
