Public Class Form1
    'Tazvik Ziauddin
    'Ch.5 Exe.4

    Private Sub btnCheckPackage_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCheckPackage.Click

        Dim intWeight As Integer
        Dim intLength As Integer
        Dim intWidth As Integer
        Dim intHeight As Integer
        Dim intVolume As Integer

        intWeight = Val(Me.txtEnterWeight.Text)
        intLength = Val(Me.txtEnterLength.Text)
        intWidth = Val(Me.txtEnterWidth.Text)
        intHeight = Val(Me.txtEnterHeight.Text)

        intVolume = intLength * intWidth * intHeight

        If intWeight > 27 Then
            Me.lblStatement.Text = "Rejected:Too heavy"
        ElseIf intVolume > 100000 Then
            Me.lblStatement.Text = "Rejected:Too large"
        ElseIf intVolume > 100000 And intWeight > 27 Then
            Me.lblStatement.Text = "Rejected:both"
        End If
        
    End Sub

End Class
