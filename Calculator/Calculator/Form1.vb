Public Class Form1
    'Tazvik Ziauddin
    'Ch.4 Rev.8

    Private Sub txtOperand1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtOperand1.TextChanged

        Dim sngTxtOperand1 As Single

        Me.radAddition.Checked = False
        Me.radDivision.Checked = False
        Me.radExponenitation.Checked = False
        Me.radIntDivision.Checked = False
        Me.radModDivision.Checked = False
        Me.radMultiplication.Checked = False
        Me.radSubtraction.Checked = False
        Me.lblExpressionValue.Text = Nothing

    End Sub

    Private Sub txtOperand2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtOperand2.TextChanged

        Dim sngTxtOperand2 As Single

        Me.radAddition.Checked = False
        Me.radDivision.Checked = False
        Me.radExponenitation.Checked = False
        Me.radIntDivision.Checked = False
        Me.radModDivision.Checked = False
        Me.radMultiplication.Checked = False
        Me.radSubtraction.Checked = False
        Me.lblExpressionValue.Text = Nothing

    End Sub

    Private Sub radExponenitation_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radExponenitation.Click

        Dim sngAnswer As Single
        sngAnswer = Val(Me.txtOperand1.Text) ^ Val(Me.txtOperand2.Text)
        Me.lblExpressionValue.Text = sngAnswer

    End Sub

    Private Sub radMultiplication_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radMultiplication.Click

        Dim sngAnswer As Single
        sngAnswer = Val(Me.txtOperand1.Text) * Val(Me.txtOperand2.Text)
        Me.lblExpressionValue.Text = sngAnswer

    End Sub

    Private Sub radDivision_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radDivision.Click

        Dim sngANswer As Single
        sngANswer = Val(Me.txtOperand1.Text) / Val(Me.txtOperand2.Text)
        Me.lblExpressionValue.Text = sngANswer


    End Sub

    Private Sub radIntDivision_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radIntDivision.Click

        Dim sngANswer As Single
        sngANswer = Val(Me.txtOperand1.Text) \ Val(Me.txtOperand2.Text)
        Me.lblExpressionValue.Text = sngANswer


    End Sub

    Private Sub radModDivision_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radModDivision.Click

        Dim sngANswer As Single
        sngANswer = Val(Me.txtOperand1.Text) Mod Val(Me.txtOperand2.Text)
        Me.lblExpressionValue.Text = sngANswer



    End Sub

    Private Sub radAddition_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radAddition.Click

        Dim sngANswer As Single
        sngANswer = Val(Me.txtOperand1.Text) + Val(Me.txtOperand2.Text)
        Me.lblExpressionValue.Text = sngANswer



    End Sub

    Private Sub radSubtraction_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radSubtraction.Click

        Dim sngANswer As Single
        sngANswer = Val(Me.txtOperand1.Text) - Val(Me.txtOperand2.Text)
        Me.lblExpressionValue.Text = sngANswer

    End Sub

End Class
