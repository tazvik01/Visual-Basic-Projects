Public Class Form2

    Dim blnRight As Boolean
    Dim blnLeft As Boolean
    Dim intCarSpeed As Integer = 5
    Dim intScore As Integer = 0

    Private Sub TimerMain_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerMain.Tick

        MovePlayerCar()

    End Sub
    
    Private Sub Form2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyValue = Keys.Right Then
            blnRight = True
        Else
            blnRight = False
        End If

        If e.KeyValue = Keys.Left Then
            blnLeft = True
        Else
            blnLeft = False
        End If

    End Sub

    Private Sub MovePlayerCar()

        If blnRight = True And picPlayerCar.Left + picPlayerCar.Width < Me.ClientRectangle.Width Then
            picPlayerCar.Left += intCarSpeed
        End If

        If blnLeft = True And picPlayerCar.Left > Me.ClientRectangle.Left Then
            picPlayerCar.Left -= intCarSpeed
        End If

    End Sub

    Private Sub Form2_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp

        If e.KeyValue = Keys.Right Then
            blnRight = False
        End If

        If e.KeyValue = Keys.Left Then
            blnLeft = False
        End If

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        TimerMoveEnemyOne.Enabled = True
        TimerCoin.Enabled = True
        TimerMoveEnemy.Enabled = True
        TimerCoinTwo.Enabled = True

    End Sub

    Private Sub TimerDown_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerMoveEnemyOne.Tick

        picEnemyCar.Top += 3.5

        If picEnemyCar.Top >= Me.ClientRectangle.Height Then
            TimerMoveEnemyOne.Enabled = False
        End If

        If Collision(picEnemyCar, picPlayerCar) Then
            Application.Exit()
        End If

    End Sub

    Private Sub TimerCoin_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerCoin.Tick

        picCoin.Top += 2

        If picCoin.Top >= Me.ClientRectangle.Height Then
            TimerMoveEnemyOne.Enabled = False
        End If

        If Collision(picCoin, picPlayerCar) Then
            Rnd()
            picCoin.Top = Int(Rnd() * (489 - 2 * picCoin.Height) + picCoin.Height)
            picCoin.Left = Int(Rnd() * (691 - 2 * picCoin.Width) + picCoin.Width)
            intScore = intScore + 1
            Me.lblScore.Text = " Score: " & intScore
        End If

    End Sub

    Private Function Collision(ByVal Object1 As Object, ByVal Object2 As Object) As Boolean

        Dim blnCollided As Boolean = False

        If Object1.Top + Object1.Height >= Object2.Top And _
            Object2.Top + Object2.Height >= Object1.Top And _
            Object1.Left + Object1.Width >= Object2.Left And _
             Object2.Left + Object2.Width >= Object1.Left And Object1.Visible = True And Object2.Visible = True Then
            blnCollided = True
            Return blnCollided
        End If

    End Function

    Private Sub TimerMoveEnemy_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerMoveEnemy.Tick

        picEnemyCarTwo.Top += 2

        If picEnemyCarTwo.Top >= Me.ClientRectangle.Height Then
            TimerMoveEnemyOne.Enabled = False
        End If

        If Collision(picEnemyCarTwo, picPlayerCar) Then
            Application.Exit()
        End If


    End Sub

    Private Sub TimerCoinTwo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerCoinTwo.Tick

        PicCoinTwo.Top += 2

        If picCoin.Top >= Me.ClientRectangle.Height Then
            TimerMoveEnemyOne.Enabled = False
        End If

        If Collision(PicCoinTwo, picPlayerCar) Then
            Rnd()
            picCoin.Top = Int(Rnd() * (489 - 2 * PicCoinTwo.Height) + PicCoinTwo.Height)
            picCoin.Left = Int(Rnd() * (691 - 2 * PicCoinTwo.Width) + PicCoinTwo.Width)
            intScore = intScore + 1
            Me.lblScore.Text = " Score: " & intScore
        End If


    End Sub

End Class