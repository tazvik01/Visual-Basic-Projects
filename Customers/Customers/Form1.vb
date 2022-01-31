Public Class Form1
    'Tazvik Ziauddin
    'Ch.9 Rev.6

    Structure Customer
        Dim strFirstName As String
        Dim strLastName As String
        Dim sngBalance As Single
    End Structure

    Private Sub btnCustomerInfo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCustomerInfo.Click

        Dim stcCustomer(4) As Customer
        Const intNUMBEROFCUSTOMER As Integer = 5
        Dim strFirstName As String
        Dim strLastName As String
        Dim sngBalance As Single
        Dim intLoop As Integer
        Dim intAverage As Integer
        Dim intHighestBalance As Integer

        For intLoop = 0 To 4
            stcCustomer(intLoop).strFirstName = InputBox("Enter first name", "Name")
            stcCustomer(intLoop).strLastName = InputBox("Enter Last name", "Name")
            stcCustomer(intLoop).sngBalance = InputBox("Enter Balance", "Balance")
        Next intLoop

        For intLoop = 0 To 4
            sngBalance = sngBalance + stcCustomer(intLoop).sngBalance
            If stcCustomer(intLoop).sngBalance > stcCustomer(intHighestBalance).sngBalance Then
                intHighestBalance = intLoop
            End If
        Next intLoop

        intAverage = sngBalance / intNUMBEROFCUSTOMER

        Me.lblaverage.Text = " The average account balance is: " & Format(intAverage, "Currency")
        Me.lblHighestbalance.Text = " The customer with the highest account balance is: " & stcCustomer(intHighestBalance).strFirstName & _
        " " & stcCustomer(intHighestBalance).strLastName & " " & Format(stcCustomer(intHighestBalance).sngBalance, "Currency")

    End Sub

End Class
