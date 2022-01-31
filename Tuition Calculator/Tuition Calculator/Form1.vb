Public Class Form1
    'Tazvik Ziauddin
    'Ch.8 Rev.7
    '2017/12/26

    Private Sub btnCalculate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCalculate.Click

        Const decUNDERGRADUATEPERHOUR As Decimal = 75
        Const decGRADUATEPERHOUR As Decimal = 145
        Const decTHESISPERHOUR As Decimal = 160
        Dim intCreditHours As Integer
        Dim decTuition As Decimal

        If Me.cboCreditHours.SelectedIndex >= 0 Then  'list item selected
            intCreditHours = Val(Me.cboCreditHours.SelectedItem)
        Else
            intCreditHours = Val(Me.cboCreditHours.Text)   'value typed
        End If

        Select Case Me.lstCourseLevels.SelectedItem
            Case "Undergraduate"
                decTuition = decUNDERGRADUATEPERHOUR * intCreditHours
            Case "Graduate"
                decTuition = decGRADUATEPERHOUR * intCreditHours
            Case "Thesis and Dissertation"
                decTuition = decTHESISPERHOUR * intCreditHours
        End Select

        Me.lblTuition.Text = "Tuition is: " & Format(decTuition, "Currency") 

    End Sub

    Private Sub lstCourseLevels_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstCourseLevels.SelectedIndexChanged

        Me.lblTuition.Text = Nothing

    End Sub

End Class
