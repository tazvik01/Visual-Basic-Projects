<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TimerMain = New System.Windows.Forms.Timer(Me.components)
        Me.TimerMoveEnemyOne = New System.Windows.Forms.Timer(Me.components)
        Me.TimerCoin = New System.Windows.Forms.Timer(Me.components)
        Me.lblScore = New System.Windows.Forms.Label()
        Me.picCoin = New System.Windows.Forms.PictureBox()
        Me.picEnemyCar = New System.Windows.Forms.PictureBox()
        Me.picPlayerCar = New System.Windows.Forms.PictureBox()
        Me.picRoad = New System.Windows.Forms.PictureBox()
        Me.picEnemyCarTwo = New System.Windows.Forms.PictureBox()
        Me.TimerMoveEnemy = New System.Windows.Forms.Timer(Me.components)
        Me.PicCoinTwo = New System.Windows.Forms.PictureBox()
        Me.TimerCoinTwo = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picCoin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEnemyCar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayerCar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRoad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEnemyCarTwo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicCoinTwo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TimerMain
        '
        Me.TimerMain.Enabled = True
        Me.TimerMain.Interval = 1
        '
        'TimerMoveEnemyOne
        '
        Me.TimerMoveEnemyOne.Interval = 25
        '
        'TimerCoin
        '
        Me.TimerCoin.Interval = 25
        '
        'lblScore
        '
        Me.lblScore.BackColor = System.Drawing.Color.White
        Me.lblScore.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(540, 9)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(123, 28)
        Me.lblScore.TabIndex = 4
        Me.lblScore.Text = "Score:"
        '
        'picCoin
        '
        Me.picCoin.BackgroundImage = Global.Crazy_Taxi.My.Resources.Resources.tumblr_olg5ofbgQL1sbdg0wo1_400
        Me.picCoin.Image = Global.Crazy_Taxi.My.Resources.Resources.Gold_Coin_Transparent_PNG_Clipart
        Me.picCoin.Location = New System.Drawing.Point(428, 213)
        Me.picCoin.Name = "picCoin"
        Me.picCoin.Size = New System.Drawing.Size(23, 26)
        Me.picCoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCoin.TabIndex = 3
        Me.picCoin.TabStop = False
        '
        'picEnemyCar
        '
        Me.picEnemyCar.BackgroundImage = Global.Crazy_Taxi.My.Resources.Resources.tumblr_olg5ofbgQL1sbdg0wo1_400
        Me.picEnemyCar.Image = Global.Crazy_Taxi.My.Resources.Resources.Machovka_grey_car
        Me.picEnemyCar.Location = New System.Drawing.Point(377, 82)
        Me.picEnemyCar.Name = "picEnemyCar"
        Me.picEnemyCar.Size = New System.Drawing.Size(62, 53)
        Me.picEnemyCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEnemyCar.TabIndex = 2
        Me.picEnemyCar.TabStop = False
        '
        'picPlayerCar
        '
        Me.picPlayerCar.BackColor = System.Drawing.Color.Transparent
        Me.picPlayerCar.BackgroundImage = Global.Crazy_Taxi.My.Resources.Resources.tumblr_olg5ofbgQL1sbdg0wo1_400
        Me.picPlayerCar.Image = Global.Crazy_Taxi.My.Resources.Resources.nissan_PNG30
        Me.picPlayerCar.Location = New System.Drawing.Point(428, 362)
        Me.picPlayerCar.Name = "picPlayerCar"
        Me.picPlayerCar.Size = New System.Drawing.Size(138, 65)
        Me.picPlayerCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlayerCar.TabIndex = 1
        Me.picPlayerCar.TabStop = False
        '
        'picRoad
        '
        Me.picRoad.BackColor = System.Drawing.Color.Tomato
        Me.picRoad.Image = Global.Crazy_Taxi.My.Resources.Resources.tumblr_olg5ofbgQL1sbdg0wo1_400
        Me.picRoad.Location = New System.Drawing.Point(2, -1)
        Me.picRoad.Name = "picRoad"
        Me.picRoad.Size = New System.Drawing.Size(675, 450)
        Me.picRoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRoad.TabIndex = 0
        Me.picRoad.TabStop = False
        '
        'picEnemyCarTwo
        '
        Me.picEnemyCarTwo.BackgroundImage = Global.Crazy_Taxi.My.Resources.Resources.tumblr_olg5ofbgQL1sbdg0wo1_400
        Me.picEnemyCarTwo.Image = Global.Crazy_Taxi.My.Resources.Resources.Machovka_grey_car
        Me.picEnemyCarTwo.Location = New System.Drawing.Point(190, 223)
        Me.picEnemyCarTwo.Name = "picEnemyCarTwo"
        Me.picEnemyCarTwo.Size = New System.Drawing.Size(67, 49)
        Me.picEnemyCarTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEnemyCarTwo.TabIndex = 5
        Me.picEnemyCarTwo.TabStop = False
        '
        'TimerMoveEnemy
        '
        Me.TimerMoveEnemy.Interval = 25
        '
        'PicCoinTwo
        '
        Me.PicCoinTwo.BackgroundImage = Global.Crazy_Taxi.My.Resources.Resources.tumblr_olg5ofbgQL1sbdg0wo1_400
        Me.PicCoinTwo.Image = Global.Crazy_Taxi.My.Resources.Resources.Gold_Coin_Transparent_PNG_Clipart
        Me.PicCoinTwo.Location = New System.Drawing.Point(262, 118)
        Me.PicCoinTwo.Name = "PicCoinTwo"
        Me.PicCoinTwo.Size = New System.Drawing.Size(23, 26)
        Me.PicCoinTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicCoinTwo.TabIndex = 6
        Me.PicCoinTwo.TabStop = False
        '
        'TimerCoinTwo
        '
        Me.TimerCoinTwo.Interval = 25
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 450)
        Me.Controls.Add(Me.PicCoinTwo)
        Me.Controls.Add(Me.picEnemyCarTwo)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.picCoin)
        Me.Controls.Add(Me.picEnemyCar)
        Me.Controls.Add(Me.picPlayerCar)
        Me.Controls.Add(Me.picRoad)
        Me.Name = "Form2"
        Me.Text = "Crazy Taxi"
        CType(Me.picCoin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEnemyCar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayerCar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRoad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEnemyCarTwo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicCoinTwo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picRoad As System.Windows.Forms.PictureBox
    Friend WithEvents picPlayerCar As System.Windows.Forms.PictureBox
    Friend WithEvents TimerMain As System.Windows.Forms.Timer
    Friend WithEvents picEnemyCar As System.Windows.Forms.PictureBox
    Friend WithEvents TimerMoveEnemyOne As System.Windows.Forms.Timer
    Friend WithEvents picCoin As System.Windows.Forms.PictureBox
    Friend WithEvents TimerCoin As System.Windows.Forms.Timer
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents picEnemyCarTwo As System.Windows.Forms.PictureBox
    Friend WithEvents TimerMoveEnemy As System.Windows.Forms.Timer
    Friend WithEvents PicCoinTwo As System.Windows.Forms.PictureBox
    Friend WithEvents TimerCoinTwo As System.Windows.Forms.Timer
End Class
