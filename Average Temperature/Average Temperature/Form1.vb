Public Class Form1
    'Tazvik Ziauddin
    'Ch.6 Test
    '11/20/2017

    Private Sub btnEnterTemparatures_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEnterTemparatures.Click

        Dim intTemperature As Integer
        Dim intAverageTemparature As Integer
        Dim intLoop As Integer

        For intLoop = 1 To 5
            intTemperature = InputBox("Enter the high temparature of each day for the last 5 days", "Temparature")
            intAverageTemparature = intTemperature * intLoop / 5
        Next intLoop

        Me.lblAverageTemp.Text = "The average high temparature over the past 5 days was  " & intAverageTemparature & "  degrees."

    End Sub

End Class
