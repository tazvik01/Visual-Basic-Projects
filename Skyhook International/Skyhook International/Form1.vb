Public Class Form1
    'Tazvik Ziauddin
    'Ch.4 Rev.6

    Private Sub btnShip_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnShip.Click

        Const intSKYHOOKSPERBOX As Integer = 3
        Dim intNumberOfSkyhooks As Integer
        Dim intNumberOfBoxes As Integer
        Dim intNumberOfEnvelopes As Integer

        intNumberOfSkyhooks = Val(Me.txtNumberofskyhooks.Text)
        intNumberOfBoxes = intNumberOfSkyhooks \ intSKYHOOKSPERBOX
        intNumberOfEnvelopes = intNumberOfSkyhooks Mod intSKYHOOKSPERBOX

        Me.lblNumberOfBoxes.Text = intNumberOfBoxes 'Display Answer
        Me.lblNumberOfEnvelopes.Text = intNumberOfEnvelopes 'Display Answer

    End Sub

   
End Class
