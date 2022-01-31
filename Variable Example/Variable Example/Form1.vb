Public Class Form1
    'Tazvik Ziauddin
    'Variable Example
    '9/18/2017

    Private Sub btnAnswer_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAnswer.Click

        'Constants go above Dim Statements (remember to use CAPITAL letters for identifier)
        Dim sngRadius As Single
        Dim sngCircleArea As Single 'Declare variables for anything you dont know before running the program

        sngRadius = Val(Me.txtRadius.Text) 'Assign values to variable in the order that they were declared
        sngCircleArea = 3.14 * sngRadius ^ 2
        'snCircleArea=3.14 * Val(me.txtRadius.Text)^ 2 Never do this!

        Me.lblAnswer.Text = sngCircleArea 'Display answer variables
        'Me lblAnswer.Text=3.14*sngradius^2 Never do this

    End Sub

    Private Sub txtRadius_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRadius.TextChanged

        'Clear the current answer when the user begins to type a new radius  value
        Me.lblAnswer.Text = " "

    End Sub

End Class
