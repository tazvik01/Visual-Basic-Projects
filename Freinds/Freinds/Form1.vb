Public Class Form1
    'Tazvik Ziauddin
    'Ch.7 Rev.1
    '11/21/2017

    Private Sub btnGetInfo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGetInfo.Click

        Dim strFreindName As String
        strFreindName = Me.txtFreindName.Text

        'Show freind info
        Select Case strFreindName.ToUpper
            Case "SHANA"
                Call SHANAInfo()
            Case "LUIZ"
                Call LUIZInfo()
            Case "CRIS"
                Call CRISInfo()
            Case Else
                MessageBox.Show("Sorry,no information available")
        End Select

    End Sub

    Sub SHANAInfo()
        Me.picFreindPhoto.Image = Image.FromFile("Shana.bmp")
        Me.lblFreindInfo.Text = "Shana's birthday is June 24. Her favorite animal" & _
     " is the dolphin,Her favorite color is blue, and she likes to do extreme inline skating."

    End Sub

    Sub LUIZInfo()
        Me.picFreindPhoto.Image = Image.FromFile("luiz.bmp")
        Me.lblFreindInfo.Text = "luiz's birthday is August 21. His favorite animal" & _
       " is the tiger,his favorite color is green, and he likes to do gymnastics."

    End Sub

    Sub CRISInfo()
        Me.picFreindPhoto.Image = Image.FromFile("cris.bmp")
        Me.lblFreindInfo.Text = "Cris' birthday is september 20. His favorite animal" & _
       " is any kind of bird, his favorite color is yellow, and he likes to play the guitar."

    End Sub

End Class
