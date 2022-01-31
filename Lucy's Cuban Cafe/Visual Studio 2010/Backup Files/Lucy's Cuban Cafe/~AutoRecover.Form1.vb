Public Class Form1
    'Tazvik Ziauddin
    'Ch.9 Rev.8

    Structure MenuItem
        Dim strEnglishName As String
        Dim strSpanishName As String
        Dim decPrice As Decimal
    End Structure

    Const intMAXFOODITEMS As Integer = 9 'Number of item buttons on interface

    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'Processes orders by showing selected items in a list and maintaining a current total.
    '
    'post: A total price is displayed and selected Items are displayed in a list if menu
    'items have been selected. The list is clear and no price is displayed if a new order is started.
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Private Sub ProcessOrder(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnNewOrder.Click, btnItem0.Click, btnItem1.Click, btnItem2.Click, btnItem3.Click, _
        btnItem4.Click, btnItem5.Click, btnItem6.Click, btnItem7.Click, btnItem8.Click

        Static stcLucyMenu(intMAXFOODITEMS - 1) As MenuItem
        Static decTotalPrice As Decimal
        Dim intMenuItem As Integer

        Dim btnButtonClicked As Button = sender
        Select Case btnButtonClicked.Tag
            Case "NewOrder"
                'Load menu items and display on buttons
                Call LoadMenu(stcLucyMenu)
                Call LoadButtons(stcLucyMenu)
                'initialize price and clear total from interface
                decTotalPrice = 0
                Me.lblTotal.Text = Nothing
                'clear list of existing items and show list
                Me.lstItemsOrdered.Items.Clear()
                Me.lstItemsOrdered.Visible = True
            Case Else
                intMenuItem = Val(btnButtonClicked.Tag)
                Call AddToList(stcLucyMenu(intMenuItem), Me.lstItemsOrdered)
                decTotalPrice = decTotalPrice + stcLucyMenu(intMenuItem).decPrice
                Call ShowTotal(decTotalPrice, Me.lblTotal)
        End Select

    End Sub

    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'Stroes item names and prices in Menu() array.
    '
    'post: Menu item names and prices are stored in an array.
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Sub LoadMenu(ByRef Menu() As MenuItem)

        Menu(0).strItemName = "Arroz con Pollo"
        Menu(0).decPrice = 9.95

        Menu(1).strItemName = "Ropa Vieja"
        Menu(1).decPrice = 9.95

        Menu(2).strItemName = "Masitas"
        Menu(2).decPrice = 8.95

        Menu(3).strItemName = "Cuban Sandwich"
        Menu(3).decPrice = 6.65

        Menu(4).strItemName = "Moros"
        Menu(4).decPrice = 2.75

        Menu(5).strItemName = "Yuca"
        Menu(5).decPrice = 2.75

        Menu(6).strItemName = "Cafe con Leche"
        Menu(6).decPrice = 1.75

        Menu(7).strItemName = "Flan"
        Menu(7).decPrice = 2.5

        Menu(8).strItemName = "Pudin de Pan"
        Menu(8).decPrice = 2.95

    End Sub

    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'Displays menu item names on interface.
    'post: Menu item names are displayed on buttons.
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Sub LoadButtons(ByRef Menu() As MenuItem)

        Me.btnItem0.Text = Menu(0).strItemName
        Me.btnItem0.Visible = True

        Me.btnItem1.Text = Menu(1).strItemName
        Me.btnItem1.Visible = True

        Me.btnItem2.Text = Menu(2).strItemName
        Me.btnItem2.Visible = True

        Me.btnItem3.Text = Menu(3).strItemName
        Me.btnItem3.Visible = True

        Me.btnItem4.Text = Menu(4).strItemName
        Me.btnItem4.Visible = True

        Me.btnItem5.Text = Menu(5).strItemName
        Me.btnItem5.Visible = True

        Me.btnItem6.Text = Menu(6).strItemName
        Me.btnItem6.Visible = True

        Me.btnItem7.Text = Menu(7).strItemName
        Me.btnItem7.Visible = True

        Me.btnItem8.Text = Menu(8).strItemName
        Me.btnItem8.Visible = True

    End Sub

    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'Adds selected menu item to a list.
    'post: Selected menu item name and price of item are displayed in a list.
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Sub AddToList(ByVal Item As MenuItem, ByRef lstOrderList As ListBox)

        lstOrderList.Items.Add(Item.strItemName & vbTab & Format(Item.decPrice, "Currency"))

    End Sub

    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'Displays a total price for the current order in a label.
    'post: A prince is displayed in a label
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Sub ShowTotal(ByVal decAmount As Decimal, ByRef lblAmount As Label)

        lblAmount.Text = "Total: " & Format(decAmount, "Currency")

    End Sub

End Class
