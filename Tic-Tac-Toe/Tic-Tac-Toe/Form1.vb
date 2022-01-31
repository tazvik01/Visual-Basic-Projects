Public Class Form1
    'Tazvik Ziauddin
    'Ch.9 Tic-Tac-Toe

    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'Two player game of Tic-Tac-Toe
    '
    'pre:Buttons representeing the board have tags that correspond to:
    '          0,0 0,1 0,2
    '          1,0 1,1 1,2
    '          2,0 2,1 2,2
    'post: Tic-Tac-Toe has been played until a winner or a draw is 
    'declared.
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Private Sub btnMoveMade_Click(ByVal sender As Object, _
                ByVal e As System.EventArgs) Handles btn00.Click, btn01.Click, _
        btn02.Click, btn10.Click, btn11.Click, btn12.Click, btn20.Click, _
        btn21.Click, btn22.Click

        Dim btnSquareClicked As Button = sender
        Static chrTTT(2, 2) As Char    'Store player moves
        Static chrPlayer As Char = "X"   'X goes first

        'Check for existing X or O
        If btnSquareClicked.Text <> Nothing Then
            MessageBox.Show("Invalid move.")
        Else
            'Show move
            btnSquareClicked.Text = chrPlayer

            'Store in chrTTT()
            Dim strIndex As String
            strIndex = btnSquareClicked.Tag
            Dim intX As Integer = Val(strIndex.Chars(0))
            Dim intY As Integer = Val(strIndex.Chars(2))
            Call StoreMove(intX, intY, chrPlayer, chrTTT)

            'Check for winner
            If IsWinner(chrTTT) Then
                MessageBox.Show("Game over!")
            Else
                If chrPlayer = "X" Then
                    chrPlayer = "O"
                Else
                    chrPlayer = "X"
                End If
            End If
        End If

    End Sub

    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'Store Tic-Tac-Toe move in chrTTT().
    'pre:intX and intY is a valid index. chrTTT() is a 3x3 array.
    'post: Tic-Tac-Toe move stored in chrTTT().
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Sub StoreMove(ByVal intX As Integer, ByVal intY As Integer, _
    ByVal chrPlayer As Char, ByRef chrTTT(,) As Char)

        chrTTT(intX, intY) = chrPlayer

    End Sub

    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'Determines if there is a winner.
    'pre: chrTTT() is a 3x3 array.
    'post: True returned if a winner is found or if all squares are filled.
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Function IsWinner(ByRef chrTTT(,) As Char) As Boolean

        'Check all rows
        Dim intRow As Integer
        For intRow = 0 To 2
            If chrTTT(intRow, 0) = chrTTT(intRow, 1) And _
                chrTTT(intRow, 1) = chrTTT(intRow, 2) And _
                (chrTTT(intRow, 0) = "X" Or chrTTT(intRow, 0) = "O") Then
                Return True 'Winner
            End If
        Next intRow

        'Check all columns 
        Dim intCol As Integer
        For intCol = 0 To 2
            If chrTTT(0, intCol) = chrTTT(1, intCol) And _
                chrTTT(1, intCol) = chrTTT(2, intCol) And _
                (chrTTT(0, intCol) = "X" Or chrTTT(0, intCol) = "O") Then
                Return True 'Winner
            End If
        Next intCol


        'Check one diagonal
        If chrTTT(0, 0) = chrTTT(1, 1) And chrTTT(1, 1) = chrTTT(2, 2) _
            And (chrTTT(0, 0) = "X" Or chrTTT(0, 0) = "O") Then
            Return True 'Winner
        End If

        'Check other diagonal
        If chrTTT(0, 2) = chrTTT(1, 1) And chrTTT(1, 1) = chrTTT(2, 0) _
          And (chrTTT(0, 2) = "X" Or chrTTT(0, 2) = "O") Then
            Return True 'Winner
        End If

        'Check for empty squares
        Dim blnMovesLeft As Boolean = False
        For intRow = 0 To 2
            For intCol = 0 To 2
                If chrTTT(intRow, intCol) = Nothing Then
                    blnMovesLeft = True
                End If
            Next intCol
        Next intRow
        If Not blnMovesLeft Then
            Return True 'All squares filled
        End If
        Return False   'No winner found

    End Function

End Class
