'Imports the OleDB System Data into the Application.
Imports System.Data.OleDb
Imports System.IO
Public Class frmProductInformation

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

    'Declaring a variable which will be used to store the required data.
    Dim strProductName As String = ""

    'Declaring a Query which will be used to store the SQL Statement Strings.
    Dim Query As String

    'A Sub-routine which will be used to Execute the Query Statement and make necessary changes or references to the Database.
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

                'Gives a value to the variable that was declared.
                strProductName = Reader.GetString(2)

                'The variable is added to the combo box to display it's value.
                cboProducts.Items.Add(ProductName)

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

    Private Sub frmProductInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'The Database Connection String, which connects the database to the application.
        Access_Database.ConnectionString = "Provider=Microsoft.ACE.OleDb.12.0;Data Source = " & Data_Directory

        'Setting the grid view to read only.
        dgProductDetails.ReadOnly = True

        'Adds the following items to the indexes of the combo box referenced.
        cboGroup.Items.Add("A")
        cboGroup.Items.Add("B")

    End Sub

    Private Sub cboGroup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGroup.SelectedIndexChanged

        'Clears the Items and Text currently in the combo box.
        cboProducts.Items.Clear()
        cboProducts.Text = ""

        'An IF statement that will execute one of two different possibilities depending on which group the user selects.
        If cboGroup.SelectedItem = "A" Then

            'Sets the Query variable equal to the SQL statement which will run a command.
            Query = "SELECT * FROM Product_Details WHERE Product_Group = '" + cboGroup.SelectedItem + "'"

            'Runs the Sub-Routine which will execute the necessary instructions.
            Populate_Controls()

        ElseIf cboGroup.SelectedItem = "B" Then

            'Sets the Query variable equal to the SQL statement which will run a command.
            Query = "SELECT * FROM Product_Details WHERE Product_Group = '" + cboGroup.SelectedItem + "'"

            'Runs the Sub-Routine which will execute the necessary instructions.
            Populate_Controls()

        End If

    End Sub

    Private Sub btnViewInformation_Click(sender As Object, e As EventArgs) Handles btnViewInformation.Click

        'Defensive Programming technique.
        If cboProducts.Text = "" Then
            MsgBox("Please select a product to view", MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        'Clears all the data in the datagridview control.
        dgProductDetails.DataSource = Nothing
        dgProductDetails.Rows.Clear()
        dgProductDetails.Columns.Clear()

        'Sets the Query variable equal to the SQL statement which will run a command.
        Query = "SELECT * FROM Product_Details WHERE Product_Name = '" + cboProducts.SelectedItem + "'"

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
            'Gets the Data Source that the Grid View is displaying data for.
            dgProductDetails.DataSource = Database_Bindingsource
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

    Private Sub btnViewAll_Click(sender As Object, e As EventArgs) Handles btnViewAll.Click

        'Clears all the data in the datagridview control.
        dgProductDetails.DataSource = Nothing
        dgProductDetails.Rows.Clear()
        dgProductDetails.Columns.Clear()

        'Sets the Query variable equal to the SQL statement which will run a command.
        Query = "SELECT * FROM Product_Details"

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
            'Gets the Data Source that the Grid View is displaying data for.
            dgProductDetails.DataSource = Database_Bindingsource
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

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'Clears the Data Grid View.
        dgProductDetails.DataSource = Nothing
        dgProductDetails.Rows.Clear()
        dgProductDetails.Columns.Clear()

        'Clears the combo boxes on the interface.
        cboGroup.Text = ""
        cboProducts.Text = ""

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        'Closes the Current Interface.
        Me.Close()
        'Navigates the user to the Main menu Interface.
        frmMainMenu.Show()

    End Sub
End Class