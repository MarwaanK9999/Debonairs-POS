'Imports the OleDB System Data into the Application.
Imports System.Data.OleDb
Imports System.IO
Public Class frmSalesInformation

    'Declaring a variable which gets the current directory where the database or datasource is stored in.
    Dim Data_Directory As String = Directory.GetCurrentDirectory() & "\Debonairs.accdb"

    'Declaring a variable which initializes a new instance of the OleDB class.
    Dim Access_Database As New OleDbConnection

    'Declaring variables which will be used to store the required data.
    Dim intTransactionNumber As Integer = 0
    Dim strProductCodes As String = ""
    Dim strProductNames As String = ""
    Dim strProductPrices As String = 0
    Dim decSubTotal As Decimal = 0
    Dim decPromotionDiscount As Decimal = 0
    Dim decSalesTax As Decimal = 0
    Dim decTotalAmount As Decimal = 0
    Dim strUser As String = ""
    Dim strDate_Time As String = ""

    'Declaring a Query which will be used to store the SQL Statement Strings.
    Dim Query As String

    'A Sub-routine which will be used to Execute the Query Statement and make necessary changes or references to the Database.
    Private Sub Populate()

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

                'Gives a value to the variable that was declared.
                intTransactionNumber = Reader.GetInt32(0)

                'The variable is added to the combo box to display it's value.
                cboTransactionNo.Items.Add(intTransactionNumber)

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

    Private Sub frmSalesInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'The Database Connection String, which connects the database to the application.
        Access_Database.ConnectionString = "Provider=Microsoft.ACE.OleDb.12.0;Data Source = " & Data_Directory

        'Sets the Query variable equal to the SQL statement which will run a command.
        Query = "SELECT * FROM Sales"

        'Runs the Sub-Routine which will execute the necessary instructions.
        Populate()

    End Sub

    Private Sub btnViewSale_Click(sender As Object, e As EventArgs) Handles btnViewSale.Click

        'Clears all the items that the listbox currently contains.
        lstViewSales.Items.Clear()

        'Sets the Query variable equal to the SQL statement which will run a command.
        Query = "SELECT * FROM Sales WHERE CInt(Transaction_Number) = '" & CInt(cboTransactionNo.SelectedItem) & "'"

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

            'Adds the heading "Sales" to the listbox which will display the sales
            lstViewSales.Items.Add("Sales:")

            'An IF statement used to determine whether the Reader has found the values from the Statement or not.
            If Reader.Read Then

                'Values are given to the variables that were declared to store the quantity values.
                intTransactionNumber = CInt(cboTransactionNo.SelectedItem)
                strProductCodes = Reader.GetString(1)
                strProductNames = Reader.GetString(2)
                strProductPrices = Reader.GetString(3)
                decSubTotal = Reader.GetDecimal(4)
                decPromotionDiscount = Reader.GetDecimal(5)
                decSalesTax = Reader.GetDecimal(6)
                decTotalAmount = Reader.GetDecimal(7)
                strUser = Reader.GetString(8)
                strDate_Time = Reader.GetString(9)

                'Adds all the data to the list box so that it can be displayed to the user.
                lstViewSales.Items.Add("")
                lstViewSales.Items.Add("Transaction Number:" & intTransactionNumber)
                lstViewSales.Items.Add("Product Codes:" & vbTab & strProductCodes)
                lstViewSales.Items.Add("Product Names:" & vbTab & strProductNames)
                lstViewSales.Items.Add("Product Prices:" & vbTab & strProductPrices)
                lstViewSales.Items.Add("Sub Total:" & vbTab & decSubTotal.ToString("C"))
                lstViewSales.Items.Add("Sub Total:" & vbTab & decPromotionDiscount.ToString("C"))
                lstViewSales.Items.Add("Sub Total:" & vbTab & decSalesTax.ToString("C"))
                lstViewSales.Items.Add("Total Amount:" & vbTab & decTotalAmount.ToString("C"))
                lstViewSales.Items.Add("User:" & vbTab & vbTab & strUser)
                lstViewSales.Items.Add("Date:" & vbTab & vbTab & strDate_Time)
                lstViewSales.Items.Add("")

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

    Private Sub btnViewAll_Click(sender As Object, e As EventArgs) Handles btnViewAll.Click

        'Clears all the items that the listbox currently contains.
        lstViewSales.Items.Clear()

        'Sets the Query variable equal to the SQL statement which will run a command.
        Query = "SELECT * FROM Sales"

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

            'Adds the heading "Sales" to the listbox which will display the sales
            lstViewSales.Items.Add("Sales:")

            'A While loop is used to gather all the values from the Database Column using the Reader.
            While Reader.Read

                'Values are given to the variables that were declared to store the quantity values.
                intTransactionNumber = Reader.GetInt32(0)
                strProductCodes = Reader.GetString(1)
                strProductNames = Reader.GetString(2)
                strProductPrices = Reader.GetString(3)
                decSubTotal = Reader.GetDecimal(4)
                decPromotionDiscount = Reader.GetDecimal(5)
                decSalesTax = Reader.GetDecimal(6)
                decTotalAmount = Reader.GetDecimal(7)
                strUser = Reader.GetString(8)
                strDate_Time = Reader.GetString(9)

                'Adds all the data to the list box so that it can be displayed to the user.
                lstViewSales.Items.Add("")
                lstViewSales.Items.Add("Transaction Number:" & intTransactionNumber)
                lstViewSales.Items.Add("Product Codes:" & vbTab & strProductCodes)
                lstViewSales.Items.Add("Product Names:" & vbTab & strProductNames)
                lstViewSales.Items.Add("Product Prices:" & vbTab & strProductPrices)
                lstViewSales.Items.Add("Sub Total:" & vbTab & decSubTotal.ToString("C"))
                lstViewSales.Items.Add("Sub Total:" & vbTab & decPromotionDiscount.ToString("C"))
                lstViewSales.Items.Add("Sub Total:" & vbTab & decSalesTax.ToString("C"))
                lstViewSales.Items.Add("Total Amount:" & vbTab & decTotalAmount.ToString("C"))
                lstViewSales.Items.Add("User:" & vbTab & vbTab & strUser)
                lstViewSales.Items.Add("Date:" & vbTab & vbTab & strDate_Time)
                lstViewSales.Items.Add("")

            End While

            'Closes the database connection after the Command has been run.
            Access_Database.Close()

        Catch ex As Exception
            'Closes the database connection IF an error has occured.
            MsgBox(ex.Message)
        Finally
            'Closes the database connection IF an error has occured.
            Access_Database.Close()
        End Try

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'Clears the list box control on the interface.
        lstViewSales.Items.Clear()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        'Closes the Current Interface.
        Me.Close()
        'Navigates the user back to the Main Menu Interface.
        frmMainMenu.Show()

    End Sub
End Class