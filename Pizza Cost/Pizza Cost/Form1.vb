Public Class Form1
    'Tazvik Ziuaddin
    'Ch.4 Excer.4

    Private Sub btnCost_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCost.Click

        Const sngLABORCOSTPERBOX As Single = 0.75
        Const sngRENTCOSTPERPIZZA As Single = 1.0

        Dim sngSizeOfPizza As Single
        Dim sngMaterials As Single
        Dim sngTotalPizzaCost As Single

        sngSizeOfPizza = Val(Me.txtSizeOfPizza.Text)
        sngMaterials = 0.05 * sngSizeOfPizza * sngSizeOfPizza
        sngTotalPizzaCost = sngRENTCOSTPERPIZZA + sngMaterials + sngLABORCOSTPERBOX

        Me.lblCostAnswer.Text = sngTotalPizzaCost

    End Sub
End Class
