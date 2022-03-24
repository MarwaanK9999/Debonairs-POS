'Imports the OleDB System Data into the Application.
Imports System.Data.OleDb
Imports System.IO
Public Class frmPOS

    'Declaring a variable which gets the current directory where the database or datasource is stored in.
    Dim Data_Directory As String = Directory.GetCurrentDirectory() & "\Debonairs.accdb"

    'Declaring a variable which initializes a new instance of the OleDB class.
    Dim Access_Database As New OleDbConnection

    'Declaring a variable which will initialize a new instance of an OleDBDataAdapter.
    Dim Database_Adaptor As New OleDbDataAdapter
    'Declaring a variable which will initialize a new instance of an Data Table.
    Dim Database_Dataset As New DataTable
    'Declaring a variable which will initialize a new instance of an Binding Source.
    Dim Database_Bindingsource As New BindingSource

    'Declaring a Query which will be used to store the SQL Statement Strings.
    Dim Query As String

    'Declaring variables which will be used to store the required data.
    Dim strSearchCode As String = ""

    Public strUser As String = ""

    Dim strCurrentGroupA As String = ""

    Dim strCodes As String
    Dim strProducts As String
    Dim decPrices As String

    Dim strCode As String = ""
    Dim strProduct As String = ""
    Dim intQuantityDB As Integer = 0
    Dim intFinalQty As Integer = 0

    Dim decPaidAmount As Decimal = 0
    Dim decGroupATotal As Decimal = 0
    Dim decGroupBTotal As Decimal = 0
    Dim decSubTotal As Decimal = 0
    Dim decPromotionDiscount As Decimal = 0
    Dim decSalesTax As Decimal = 0
    Dim decTotalAmount As Decimal = 0
    Dim strUserName As String = ""
    Dim strDate As String = ""
    Dim decChange As Decimal = 0

    'Sub-routines which will be used to Execute the Query Statement and make necessary changes or references to the Database.
    Private Sub Populate_Controls()

        'Making use of Try - Catch - Finally to trap any possible errors.
        Try
            'Opens the database connection.
            Access_Database.Open()

            'Declaring an OleDBCommand variable to be used to execute instructions against the Data Source.
            Dim Cmd As OleDbCommand
            'Declaring an OleDBDataReader to be used to read the Rows in the Data Source when it's executed.
            Dim Reader As OleDbDataReader

            'Sets the Command equal to the Query which will contain the SQL statement, and the Data Connection String.
            Cmd = New OleDbCommand(Query, Access_Database)


            'Executes the reader against the Command.
            Reader = Cmd.ExecuteReader()

            'A While loop is used to gather all the values from the Database Column using the Reader.
            While Reader.Read

                'Gives values to the variable that were declared.
                strProduct = Reader.GetString(2)

                'Adds the variable values to the combo box control.
                cboProducts.Items.Add(strProduct)

            End While

            'Closes the database connection after the Command has been run.
            Access_Database.Close()

        Catch ex As Exception
            'Displays a messagebox to alert the user that there is an error.
            MsgBox(ex.Message)
        Finally
            'Closes the database connection IF an error has occured.
            Access_Database.Close()
        End Try

    End Sub

    Private Sub Select_Code()

        'Making use of Try - Catch - Finally to trap any possible errors.
        Try
            'Opens the database connection.
            Access_Database.Open()

            'Declaring an OleDBCommand variable to be used to execute instructions against the Data Source.
            Dim Cmd As OleDbCommand
            'Declaring an OleDBDataReader to be used to read the Rows in the Data Source when it's executed.
            Dim Reader As OleDbDataReader

            'Sets the Command equal to the Query which will contain the SQL statement, and the Data Connection String.
            Cmd = New OleDbCommand(Query, Access_Database)


            'Executes the reader against the Command.
            Reader = Cmd.ExecuteReader()

            'An IF statement used to determine whether the Reader has found the values from the Statement or not.
            If Reader.Read Then

                'Gives a value to the variable that was declared.
                strSearchCode = Reader.GetString(0)

            End If

            'Closes the database connection after the Command has been run.
            Access_Database.Close()

        Catch ex As Exception
            'Displays a messagebox to alert the user that there is an error.
            MsgBox(ex.Message)
        Finally
            'Closes the database connection IF an error has occured.
            Access_Database.Close()
        End Try

    End Sub

    Private Sub Add_Items()

        'Making use of Try - Catch - Finally to trap any possible errors.
        Try
            'Opens the database connection.
            Access_Database.Open()

            'Declaring an OleDBCommand variable to be used to execute instructions against the Data Source.
            Dim Cmd As OleDbCommand
            'Declaring an OleDBDataReader to be used to read the Rows in the Data Source when it's executed.
            Dim Reader As OleDbDataReader

            'Sets the Command equal to the Query which will contain the SQL statement, and the Data Connection String.
            Cmd = New OleDbCommand(Query, Access_Database)


            'Executes the reader against the Command.
            Reader = Cmd.ExecuteReader()


            'An IF statement that will execute one of two different possibilities depending on which group the user selects.
            If cboGroup.SelectedItem = "A" Then

                'An IF statement used to determine whether the Reader has found the values from the Statement or not.
                If Reader.Read Then

                    'Values are assigned to the variables that were declared.
                    strCode = Reader("Product_Code")
                    strProduct = Reader("Product_Name")
                    decGroupATotal = Reader("Product_Price")
                    intQuantityDB = Reader("Product_Quantity")

                    'Tests if the Quantity in the Data Base is depleted or not.
                    If intQuantityDB <= 0 Then
                        MsgBox("Product is out of stock, please restock")
                        Exit Sub
                    ElseIf strCurrentGroupA = "A" Then
                        MsgBox("You can only select one product from group A.")
                            Exit Sub

                    Else
                        'Adds the items to the list box.
                        lstSalesList.Items.Add("Product Code: " & strCode)
                        lstSalesList.Items.Add("Product Name: " & strProduct)
                        lstSalesList.Items.Add("Product Price: " & decGroupATotal.ToString("C"))

                        'Adds values to the variables.
                        strCodes = strCode
                        strProducts = strProduct
                        decPrices = decGroupATotal

                        'Deducts from the Quantity when a product is selected.
                        intFinalQty = intQuantityDB - 1
                        'Assigns a value to the variable.
                        strCurrentGroupA = cboGroup.SelectedItem

                    End If
                End If

            ElseIf cboGroup.SelectedItem = "B" Then

                'Values are assigned to the variables that were declared.
                If Reader.Read Then

                    'A variable is declared to be used as a data storage unit.
                    Dim decProductBPrice As Decimal

                    'Values are assigned to the variables that were declared.
                    strCode = Reader("Product_Code")
                    strProduct = Reader("Product_Name")
                    decProductBPrice = Reader("Product_Price")
                    intQuantityDB = Reader("Product_Quantity")

                    'Tests for the value of the total and will execute an instruction depending on the result.
                    If decGroupBTotal = 0 Then
                        decGroupBTotal = decProductBPrice

                    ElseIf decGroupBTotal < 0 Then
                        decGroupBTotal = decProductBPrice + decGroupBTotal
                    End If

                    'Tests if the Quantity in the Data Base is depleted or not.
                    If intQuantityDB <= 0 Then
                        MsgBox("Product is out of stock, please restock")
                        Exit Sub

                    Else

                        'Tests if there is no values in the variable.
                        If strProducts IsNot Nothing Then

                            'Adds the items to the list box.
                            lstSalesList.Items.Add("Product Code: " & strCode)
                            lstSalesList.Items.Add("Product Name: " & strProduct)
                            lstSalesList.Items.Add("Product Price: " & decProductBPrice.ToString("C"))

                            'Adds values to the variables.
                            strCodes = strCodes & "+" & strCode
                            strProducts = strProducts & "+" & strProduct
                            decPrices = decGroupBTotal & "+" & decPrices

                            'Deducts from the Quantity when a product is selected.
                            intFinalQty = intQuantityDB - 1

                        Else
                            'Adds the items to the list box.

                            lstSalesList.Items.Add("Product Code: " & strCode)
                            lstSalesList.Items.Add("Product Name: " & strProduct)
                            lstSalesList.Items.Add("Product Price: " & decProductBPrice.ToString("C"))

                            'Assigns values to the variables.
                            strCodes = strCode
                            strProducts = strProduct
                            decPrices = decGroupBTotal

                            'Deducts from the Quantity when a product is selected.
                            intFinalQty = intQuantityDB - 1

                        End If
                    End If

                End If
            End If

            'Closes the database connection after the Command has been run.
            Access_Database.Close()

        Catch ex As Exception
            'Displays a messagebox to alert the user that there is an error.
            MsgBox(ex.Message)
        Finally
            'Closes the database connection IF an error has occured.
            Access_Database.Close()
        End Try

    End Sub

    Private Sub Remove_Items()

        'Making use of Try - Catch - Finally to trap any possible errors.
        Try
            'Opens the database connection.
            Access_Database.Open()

            'Declaring an OleDBCommand variable to be used to execute instructions against the Data Source.
            Dim Cmd As OleDbCommand
            'Declaring an OleDBDataReader to be used to read the Rows in the Data Source when it's executed.
            Dim Reader As OleDbDataReader

            'Sets the Command equal to the Query which will contain the SQL statement, and the Data Connection String.
            Cmd = New OleDbCommand(Query, Access_Database)


            'Executes the reader against the Command.
            Reader = Cmd.ExecuteReader()

            'An IF statement that will execute one of two different possibilities depending on which group the user selects.
            If cboGroup.SelectedItem = "A" Then

                'An IF statement used to determine whether the Reader has found the values from the Statement or not.
                If Reader.Read Then

                    'Values are assigned to the variables that were declared.
                    strCode = Reader.GetString(0)
                    strProduct = Reader.GetString(2)
                    decGroupATotal = Reader.GetDecimal(3)
                    intQuantityDB = Reader.GetInt32(4)

                    'The items are removed from the list box.
                    lstSalesList.Items.Remove("Product Code: " & strCode)
                    lstSalesList.Items.Remove("Product Name: " & strProduct)
                    lstSalesList.Items.Remove("Product Price: " & decGroupATotal.ToString("C"))

                    'Adds a value to the quantity.
                    intFinalQty = intQuantityDB + 1
                    'Clears the variable value and sets it to Null.
                    strCurrentGroupA = " "
                    'Removes the values from string that from the items that were removed.
                    Replace(strCodes, strCode, "")
                    Replace(strProducts, strProduct, "")
                    Replace(decPrices, decGroupATotal, "")
                End If

            ElseIf cboGroup.SelectedItem = "B" Then

                'An IF statement used to determine whether the Reader has found the values from the Statement or not.
                If Reader.Read Then

                    'A variable is declared to be used as a data storage unit.
                    Dim decProductBPrice As Decimal

                    'Values are assigned to the variables that were declared.
                    strCode = Reader.GetString(0)
                    strProduct = Reader.GetString(2)
                    decProductBPrice = Reader.GetDecimal(3)
                    intQuantityDB = Reader.GetInt32(4)

                    'The items are removed from the list box.
                    lstSalesList.Items.Remove("Product Code: " & strCode)
                    lstSalesList.Items.Remove("Product Name: " & strProduct)
                    lstSalesList.Items.Remove("Product Price: " & decProductBPrice.ToString("C"))

                    'Adds a value to the quantity.
                    intFinalQty = intQuantityDB + 1
                    'Removes the values from string that from the items that were removed.
                    Replace(strCodes, strCode & "+", "")
                    Replace(strProducts, strProduct & "+", "")
                    Replace(decPrices, decProductBPrice & "+", "")

                End If
            End If

            'Closes the database connection after the Command has been run.
            Access_Database.Close()

        Catch ex As Exception
            'Displays a messagebox to alert the user that there is an error.
            MsgBox(ex.Message)
        Finally
            'Closes the database connection IF an error has occured.
            Access_Database.Close()
        End Try

    End Sub

    Private Sub Store_Sales()

        'Making use of Try - Catch - Finally to trap any possible errors.
        Try
            'Opens the database connection.
            Access_Database.Open()

            'Declaring an OleDBCommand variable to be used to execute instructions against the Data Source.
            Dim Cmd As OleDbCommand

            'Sets the Command equal to the Query which will contain the SQL statement, and the Data Connection String.
            Cmd = New OleDbCommand(Query, Access_Database)


            'Gets the SQL statement to select record in the Data Source.
            Database_Adaptor.SelectCommand = Cmd
            'Fills the specified row in the Data Set to match that of the Data Table.
            Database_Adaptor.Fill(Database_Dataset)
            'Sets the Data Source that the Connector Binds to.
            Database_Bindingsource.DataSource = Database_Dataset
            'Updates the values in the Data Tables by executing the SQL Statement.
            Database_Adaptor.Update(Database_Dataset)

            'Closes the database connection after the Command has been run.
            Access_Database.Close()

        Catch ex As Exception
            'Displays a messagebox to alert the user that there is an error.
            MsgBox(ex.Message)
        Finally
            'Closes the database connection IF an error has occured.
            Access_Database.Close()
        End Try

    End Sub

    Private Sub Update_Quantity()

        'Making use of Try - Catch - Finally to trap any possible errors.
        Try
            'Opens the database connection.
            Access_Database.Open()

            'Declaring an OleDBCommand variable to be used to execute instructions against the Data Source.
            Dim Cmd As OleDbCommand

            'Sets the Command equal to the Query which will contain the SQL statement, and the Data Connection String.
            Cmd = New OleDbCommand(Query, Access_Database)


            'Gets the SQL statement to select record in the Data Source.
            Database_Adaptor.SelectCommand = Cmd
            'Fills the specified row in the Data Set to match that of the Data Table.
            Database_Adaptor.Fill(Database_Dataset)
            'Sets the Data Source that the Connector Binds to.
            Database_Bindingsource.DataSource = Database_Dataset
            'Updates the values in the Data Tables by executing the SQL Statement.
            Database_Adaptor.Update(Database_Dataset)

            'Closes the database connection after the Command has been run.
            Access_Database.Close()

        Catch ex As Exception
            'Displays a messagebox to alert the user that there is an error.
            MsgBox(ex.Message)
        Finally
            'Closes the database connection IF an error has occured.
            Access_Database.Close()
        End Try

    End Sub

    'Functions which will be used to calculate values and perform expressions.
    Private Function SubTotal(ByVal decGroupATotalFunc As Decimal, ByVal decGroupBTotalFunc As Decimal) As Decimal

        'Declaring Variables to be used in the function.
        Dim decSubTotalFunc As Decimal

        'Determining the Sub-Total.
        decSubTotalFunc = decGroupATotalFunc + decGroupBTotalFunc

        'Returns the value for the Sub-Total.
        Return decSubTotalFunc

    End Function

    Private Function PromotionDiscount(ByVal decSubTotalFunc As Decimal) As Decimal

        'Declaring Variables to be used in the function.
        Dim decDiscountPercentage As Decimal = 0
        Dim decPromotionDiscountFunc As Decimal = 0

        If cboGroup.SelectedItem = "B" Then
            'Assigning Promotion Discount Percentage to each product.
            If cboProducts.SelectedIndex = 0 Then
                decDiscountPercentage = 0
            End If
            If cboProducts.SelectedIndex = 1 Then
                decDiscountPercentage = decDiscountPercentage + 0.1
            End If
            If cboProducts.SelectedIndex = 2 Then
                decDiscountPercentage = decDiscountPercentage + 0.08
            End If
            If cboProducts.SelectedIndex = 3 Then
                decDiscountPercentage = decDiscountPercentage + 0.06
            End If
            If cboProducts.SelectedIndex = 4 Then
                decDiscountPercentage = decDiscountPercentage + 0.04
            End If
            If cboProducts.SelectedIndex = 5 Then
                decDiscountPercentage = decDiscountPercentage + 0.02
            End If
            If cboProducts.SelectedIndex > 5 Then
                decDiscountPercentage = decDiscountPercentage + 0.05
            End If

        End If
        'Determining the Promotion Discount Amount
        decPromotionDiscountFunc = decSubTotalFunc * decDiscountPercentage

        'Returns the value for the Promotion Discount.
        Return decPromotionDiscountFunc

    End Function

    Private Function SalesTax(ByVal decSubTotalFunc As Decimal, ByVal decPromotionDiscountFunc As Decimal) As Decimal

        'Declaring Variables to be used in the function.
        Dim decSalesTaxFunc As Decimal = 0
        Const VatPerc As Decimal = 0.15

        'Determining the Sales Tax Amount
        decSalesTaxFunc = (decSubTotalFunc - decPromotionDiscountFunc) * VatPerc

        'Returns the value for the Sales Tax.
        Return decSalesTaxFunc

    End Function

    Private Function TotalAmount(ByVal decSubTotalFunc As Decimal, ByVal decPromotionDiscountFunc As Decimal, ByVal decSalesTaxFunc As Decimal) As Decimal

        'Declaring Variables to be used in the function.
        Dim decTotalAmountFunc As Decimal = 0

        'Determining the Total Amount.
        decTotalAmountFunc = (decSubTotalFunc - decPromotionDiscountFunc) + decSalesTaxFunc

        'Returns the value for the Total Amount.
        Return decTotalAmountFunc

    End Function

    Private Function Change(ByVal PaidAmountFunc As Decimal, ByVal decTotalAmountFunc As Decimal) As Decimal

        'Declaring Variables to be used in the function.
        Dim decChangeFunc As Decimal

        'Determining the Change for the customer after all calculations has been done.
        decChangeFunc = PaidAmountFunc - decTotalAmountFunc

        'Returns the value for Change.
        Return decChangeFunc

    End Function

    Private Sub frmPOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'The Database Connection String, which connects the database to the application.
        Access_Database.ConnectionString = "Provider=Microsoft.ACE.OleDb.12.0;Data Source = " & Data_Directory

        'Adds the following items to the indexes of the combo box referenced.
        cboGroup.Items.Add("A")
        cboGroup.Items.Add("B")

    End Sub

    Private Sub cboGroup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGroup.SelectedIndexChanged

        'Clears the Items currently in the combo box.
        cboProducts.Items.Clear()

        'An IF statement that will execute two different possibilities depending on which group the user selects.
        If cboGroup.SelectedItem = "A" Then

            'Clears the Items currently in the combo box.
            cboProducts.Text = ""

            'Sets the Query variable equal to the SQL statement which will run a command.
            Query = "Select * FROM Product_Details WHERE Product_Group = '" + cboGroup.SelectedItem + "'"

            'Runs the Sub-Routine which will execute the necessary instructions.
            Populate_Controls()

        ElseIf cboGroup.SelectedItem = "B" Then

            'Tests if a product from Group A has been added already.
            If strCurrentGroupA = Nothing Then
                MsgBox("Please select a product from group A first.")
                Exit Sub
            Else
                'Clears the Items currently in the combo box.
                cboProducts.Text = ""

                'Sets the Query variable equal to the SQL statement which will run a command.
                Query = "SELECT * FROM Product_Details WHERE Product_Group = '" + cboGroup.SelectedItem + "'"

                'Runs the Sub-Routine which will execute the necessary instructions.
                Populate_Controls()

            End If
        End If

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        'Defensive programming to ensure the user enters data.
        If String.IsNullOrWhiteSpace(cboGroup.Text) Then
            MsgBox("Please select a product group.")
            Exit Sub
        ElseIf String.IsNullOrWhiteSpace(cboProducts.Text) Then
            MsgBox("Please select a product.")
            Exit Sub
        Else

            'Sets the Query variable equal to the SQL statement which will run a command.
            Query = "SELECT * FROM [Product_Details] WHERE [Product_Name] = '" + cboProducts.SelectedItem + "'"

            'Runs the Sub-Routine which will execute the necessary instructions.
            Select_Code()

            'Sets the Query variable equal to the SQL statement which will run a command.
            Query = "SELECT * FROM [Product_Details] WHERE [Product_Code] = '" + strSearchCode + "'"

            'Runs the Sub-Routine which will execute the necessary instructions.
            Add_Items()

            'Sets the Query variable equal to the SQL statement which will run a command.
            Query = "UPDATE [Product_Details] SET [Product_Quantity] = '" & intFinalQty & "' WHERE [Product_Code] = '" & strCode & "'"

            'Runs the Sub-Routine which will execute the necessary instructions.
            Update_Quantity()

        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        'Defensive programming to ensure the user selects data.
        If String.IsNullOrWhiteSpace(cboGroup.Text) Then
            MsgBox("Please select a product group.")
            Exit Sub
        ElseIf String.IsNullOrWhiteSpace(cboProducts.Text) Then
            MsgBox("Please select a product.")
            Exit Sub
        Else

            'Sets the Query variable equal to the SQL statement which will run a command.
            Query = "SELECT * FROM [Product_Details] WHERE [Product_Name] = '" + cboProducts.SelectedItem + "'"

            'Runs the Sub-Routine which will execute the necessary instructions.
            Select_Code()

            'Sets the Query variable equal to the SQL statement which will run a command.
            Query = "SELECT * FROM [Product_Details] WHERE [Product_Code] = '" + strSearchCode + "'"

            'Runs the Sub-Routine which will execute the necessary instructions.
            Remove_Items()

            'Sets the Query variable equal to the SQL statement which will run a command.
            Query = "UPDATE [Product_Details] SET [Product_Quantity] = '" & intFinalQty & "' WHERE [Product_Code] = '" & strCode & "'"

            'Runs the Sub-Routine which will execute the necessary instructions.
            Update_Quantity()

        End If

    End Sub

    Private Sub btnPurchase_Click(sender As Object, e As EventArgs) Handles btnPurchase.Click

        'Defensive programming to ensure the user enters/selects data.
        If String.IsNullOrWhiteSpace(txtEnterAmount.Text) Then
            MsgBox("Please Enter an amount to pay.")
            Exit Sub
        ElseIf String.IsNullOrWhiteSpace(cboGroup.Text) Then
            MsgBox("Please select a product group.")
            Exit Sub
        ElseIf String.IsNullOrWhiteSpace(cboProducts.Text) Then
            MsgBox("Please select a product.")
            Exit Sub
        ElseIf txtEnterAmount.Text <= 0 Then
            MsgBox("Please Enter an amount that is above 0.")
            Exit Sub
        ElseIf strProducts = Nothing Then
            MsgBox("Please add a product to the list in order to make a purchase.")
            Exit Sub
        ElseIf strCurrentGroupA = "" Then
            MsgBox("You must select a product from group A.")
            Exit Sub

        Else

            'Gives values to the variable that were declared.

            decPaidAmount = CDec(txtEnterAmount.Text)

            decSubTotal = SubTotal(decGroupATotal, decGroupBTotal)

            decPromotionDiscount = PromotionDiscount(decSubTotal)

            decSalesTax = SalesTax(decSubTotal, decPromotionDiscount)

            decTotalAmount = TotalAmount(decSubTotal, decPromotionDiscount, decSalesTax)

            decChange = Change(decPaidAmount, decTotalAmount)

            strDate = Today & "," & TimeString

            'Adds values to the list box to be displayed to the user.
            lstSalesList.Items.Add(" ")
            lstSalesList.Items.Add("Paid Amount: " & vbTab & vbTab & decPaidAmount.ToString("C"))
            lstSalesList.Items.Add("Sub-Total: " & vbTab & vbTab & decSubTotal.ToString("C"))
            lstSalesList.Items.Add("Promotion Discount: " & vbTab & decPromotionDiscount.ToString("C"))
            lstSalesList.Items.Add("Sales Tax: " & vbTab & vbTab & decSalesTax.ToString("C"))
            lstSalesList.Items.Add("Total Amount: " & vbTab & vbTab & decTotalAmount.ToString("C"))
            lstSalesList.Items.Add("Change: " & vbTab & vbTab & vbTab & decChange.ToString("C"))
            lstSalesList.Items.Add("Username: " & vbTab & vbTab & strUser)
            lstSalesList.Items.Add("Date: " & vbTab & vbTab & vbTab & strDate)
            lstSalesList.Items.Add(" ")

            'Sets the Query variable equal to the SQL statement which will run a command.
            Query = "INSERT INTO [Sales] ([Product_Code], [Products], [Product_Prices], [Sub-Total], [Promotion_Discount], [Sales_Tax], [Total_Amount], [Username], [Date]) VALUES ('" & strCodes & "','" & strProducts & "','" & decPrices & "','" & decSubTotal & "','" & decPromotionDiscount & "','" & decSalesTax & "','" & decTotalAmount & "','" & strUser & "','" & strDate & "')"

            'Runs the Sub-Routine which will execute the necessary instructions.
            Store_Sales()

        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'Clears the controls on the form.
        cboGroup.Text = ""
        cboProducts.Text = ""
        lstSalesList.Items.Clear()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        'Closes the Current Interface.
        Me.Close()
        'Navigates the user to the Main menu Interface.
        frmMainMenu.Show()

    End Sub
End Class