Public Class Form1
    'Tazvik Ziauddin
    'Ch.9 Rev.8

    Structure MenuItem
        Dim strSpanishName As String
        Dim strEnglishName As String
        Dim decPrice As Decimal
    End Structure

    Const intMAXFOODITEMS As Integer = 9 'Number of item buttons on interface

    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'Processes orders by showing selected items in a list and maintaining a current total.
    '
    'post: A total price is displayed and selected Items are displayed in a list if menu
    'items have been selected. The list is clear and no price is displayed if a new order is started.
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Private Sub ProcessOrder(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewOrder.Click, btnLanguage.Click, btnItem0.Click, btnItem1.Click, btnItem2.Click, _
        btnItem3.Click, btnItem4.Click, btnItem5.Click, btnItem6.Click, btnItem7.Click, btnItem8.Click

        Static stcLucyMenu(intMAXFOODITEMS - 1) As MenuItem
        Static decTotalPrice As Decimal
        Dim intMenuItem As Integer
        Dim btnItems() As Button = {Me.btnItem0, Me.btnItem1, Me.btnItem2, Me.btnItem3, Me.btnItem4, Me.btnItem5, Me.btnItem6, Me.btnItem7, Me.btnItem8}

        Dim btnButtonClicked As Button = sender
        Select Case btnButtonClicked.Tag
            Case "NewOrder"
                'Load menu items and display on buttons
                Me.btnLanguage.Text = "English"
                Call LoadMenu(stcLucyMenu)
                Call LoadButtons(stcLucyMenu, btnItems, Me.btnLanguage)
                'initialize price and clear total from interface
                decTotalPrice = 0
                Me.lblTotal.Text = Nothing
                'clear list of existing items and show list
                Me.lstItemsOrdered.Items.Clear()
                Me.lstItemsOrdered.Visible = True
            Case "Language"
                'Load menu items and display on buttons
                If Me.btnLanguage.Text = "Spanish" Then
                    btnLanguage.Text = "English"
                Else
                    btnLanguage.Text = "Spanish"
                End If
                Call LoadButtons(stcLucyMenu, btnItems, btnLanguage)
                'Call AddToList(stcLucyMenu(intMenuItem), Me.lstItemsOrdered, Me.btnLanguage)
              
            Case Else
                intMenuItem = Val(btnButtonClicked.Tag)
                Call AddToList(stcLucyMenu(intMenuItem), Me.lstItemsOrdered, Me.btnLanguage)
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

        Menu(0).strSpanishName = "Arroz con Pollo"
        Menu(0).strEnglishName = "Chicken and Yellow Rice"
        Menu(0).decPrice = 9.95

        Menu(1).strSpanishName = "Ropa Vieja"
        Menu(1).strEnglishName = "Shredded Beef"
        Menu(1).decPrice = 9.95

        Menu(2).strSpanishName = "Masitas"
        Menu(2).strEnglishName = "Pork and Plantains"
        Menu(2).decPrice = 8.95

        Menu(3).strSpanishName = "Cuban Sandwich"
        Menu(3).strEnglishName = "Cuban Bread with Meat and Cheese"
        Menu(3).decPrice = 6.65

        Menu(4).strSpanishName = "Moros"
        Menu(4).strEnglishName = "Black Beans and Rice"
        Menu(4).decPrice = 2.75

        Menu(5).strSpanishName = "Yuca"
        Menu(5).strEnglishName = "Cassava"
        Menu(5).decPrice = 2.75

        Menu(6).strSpanishName = "Cafe con Leche"
        Menu(6).strEnglishName = "Coffee with Milk"
        Menu(6).decPrice = 1.75

        Menu(7).strSpanishName = "Flan"
        Menu(7).strEnglishName = "Baked Custard"
        Menu(7).decPrice = 2.5

        Menu(8).strSpanishName = "Pudin de Pan"
        Menu(8).strEnglishName = "Bread Pudding"
        Menu(8).decPrice = 2.95

    End Sub

    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'Displays menu item names on interface.
    'post: Menu item names are displayed on buttons.
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Sub LoadButtons(ByRef Menu() As MenuItem, _
    ByRef btnItems() As Button, ByRef btnLanguage As Button)

        Dim intItem As Integer

        'set each button to an item name
        For intItem = 0 To Menu.Length - 1
            If btnLanguage.Text = "English" Then
                btnItems(intItem).Text = Menu(intItem).strEnglishName
                btnItems(intItem).Visible = True
            Else
                btnItems(intItem).Text = Menu(intItem).strSpanishName
                btnItems(intItem).Visible = True
            End If
        Next intItem

    End Sub

    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'Adds selected menu item to a list.
    'post: Selected menu item name and price of item are displayed in a list.
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Sub AddToList(ByVal Item As MenuItem, ByRef lstOrderList As ListBox, ByRef btnLanguage As Button)

        If btnLanguage.Text = "English" Then
            lstOrderList.Items.Add(Item.strEnglishName & vbTab & Format(Item.decPrice, "Currency"))
        Else
            lstOrderList.Items.Add(Item.strSpanishName & vbTab & Format(Item.decPrice, "Currency"))
        End If


    End Sub

    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'Displays a total price for the current order in a label.
    'post: A price is displayed in a label
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Sub ShowTotal(ByVal decAmount As Decimal, ByRef lblAmount As Label)

        lblAmount.Text = "Total: " & Format(decAmount, "Currency")

    End Sub

End Class
