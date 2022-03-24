'Imports the OleDB System Data into the Application.
Imports System.Data.OleDb
Imports System.IO

Public Class frmProductDetails

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

    'Declaring Variables to store data.
    Dim strProductGroup As String = ""
    Dim strProductName As String = ""
    Dim strProductCode As String = ""
    Dim decProductPrice As Decimal = 0
    Dim intProductQuantity As Integer = 0

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

            'Declaring a variable to hold data.
            Dim strProductCode As String

            'A While loop is used to gather all the values from the Database Column using the Reader.
            While Reader.Read

                'Assigns a value to the variable.
                strProductCode = Reader.GetString(0)

                'Adds the value from the variable into the combo box.
                cboSelectProductUpdate.Items.Add(strProductCode)

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

    Public Sub Run_Query()

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

    Private Sub frmProductDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'The Database Connection String, which connects the database to the application.
        Access_Database.ConnectionString = "Provider=Microsoft.ACE.OleDb.12.0;Data Source = " & Data_Directory

        'Disables all the text boxes when the form load event is executed.
        txtProductGroupUpdate.Enabled = False
        txtProductNameUpdate.Enabled = False
        txtProductCodeUpdate.Enabled = False
        txtProductPriceUpdate.Enabled = False

        'Adds Items to the combo boxes to be selected.
        cboProductGroupAdd.Items.Add("A")
        cboProductGroupAdd.Items.Add("B")
        cboProductGroupUpdate.Items.Add("A")
        cboProductGroupUpdate.Items.Add("B")

        'Focuses on a combo box when the form loads.
        cboProductGroupAdd.Focus()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        'Clears the list box control.
        lstNewProductDetails.Items.Clear()

        'Data validation and defensive programming techniques to validate user input.
        If String.IsNullOrWhiteSpace(cboProductGroupAdd.Text) Then
            MsgBox("Please enter all the required data.", MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf String.IsNullOrWhiteSpace(txtProductNameAdd.Text) Then
            MsgBox("Please enter all the required data.", MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf String.IsNullOrWhiteSpace(txtProductCodeAdd.Text) Then
            MsgBox("Please enter all the required data.", MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf String.IsNullOrWhiteSpace(txtProductPriceAdd.Text) Then
            MsgBox("Please enter all the required data.", MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf String.IsNullOrWhiteSpace(txtProductQuantityAdd.Text) Then
            MsgBox("Please enter all the required data.", MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf IsNumeric(txtProductQuantityAdd.Text) = False Then
            MsgBox("Please enter all the required data.", MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf IsNumeric(txtProductPriceAdd.Text) = False Then
            MsgBox("Please enter all the required data.", MessageBoxIcon.Exclamation)
            Exit Sub

        Else

            'Assigning values to the variables to be used.
            strProductGroup = CStr(cboProductGroupAdd.SelectedItem)
            strProductName = CStr(txtProductNameAdd.Text)
            strProductCode = CStr(txtProductCodeAdd.Text)
            decProductPrice = CDec(txtProductPriceAdd.Text)
            intProductQuantity = CInt(txtProductQuantityAdd.Text)

            'Sets the Query variable equal to the SQL statement which will run a command.
            Query = "INSERT INTO [Product_Details] ([Product_Group], [Product_Name], [Product_Code], [Product_Price], [Product_Quantity]) VALUES ('" & strProductGroup & "','" & strProductName & "','" & strProductCode & "','" & decProductPrice & "','" & intProductQuantity & "')"

            'Runs the Sub-Routine which will execute the necessary instructions.
            Run_Query()

            'Adds the New Products details to the list box control.
            lstNewProductDetails.Items.Add("Group: " & strProductGroup)
            lstNewProductDetails.Items.Add("Name: " & strProductName)
            lstNewProductDetails.Items.Add("Code: " & strProductCode)
            lstNewProductDetails.Items.Add("Price: " & decProductPrice.ToString("C2"))
            lstNewProductDetails.Items.Add("Quantity: " & intProductQuantity)

        End If

    End Sub

    Private Sub btnAddClear_Click(sender As Object, e As EventArgs) Handles btnAddClear.Click

        'Clears all the items in the "Add Product" Group box.
        cboProductGroupAdd.Text = " "
        txtProductNameAdd.Clear()
        txtProductCodeAdd.Clear()
        txtProductPriceAdd.Clear()
        txtProductQuantityAdd.Clear()
        lstNewProductDetails.Items.Clear()

    End Sub

    Private Sub cboProductGroupUpdate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProductGroupUpdate.SelectedIndexChanged

        'Clears the items and text in the combo box.
        cboSelectProductUpdate.Items.Clear()
        cboSelectProductUpdate.Text = ""

        'An IF statement that will execute one of two different possibilities depending on which group the user selects.
        If cboProductGroupUpdate.SelectedItem = "A" Then

            'Sets the Query variable equal to the SQL statement which will run a command.
            Query = "SELECT * FROM Product_Details WHERE Product_Group = '" + cboProductGroupUpdate.SelectedItem + "'"

            'Runs the Sub-Routine which will execute the necessary instructions.
            Populate_Controls()

        ElseIf cboProductGroupUpdate.SelectedItem = "B" Then

            'Sets the Query variable equal to the SQL statement which will run a command.
            Query = "SELECT * FROM Product_Details WHERE Product_Group = '" + cboProductGroupUpdate.SelectedItem + "'"

            'Runs the Sub-Routine which will execute the necessary instructions.
            Populate_Controls()

        End If

    End Sub
    Private Sub cboSelectProductUpdate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSelectProductUpdate.SelectedIndexChanged

        'Data validation and defensive programming techniques to validate user input.
        If String.IsNullOrWhiteSpace(cboProductGroupUpdate.Text Or cboSelectProductUpdate.Text Or txtProductGroupUpdate.Text Or txtProductNameAdd.Text Or txtProductPriceUpdate.Text) Then
            MsgBox("Please enter all the required data.", MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf IsNumeric(txtProductPriceUpdate.Text) = False Then
            MsgBox("Please enter a numerical value.", MessageBoxIcon.Exclamation)
            Exit Sub
            txtProductPriceUpdate.Focus()
        End If

        'Sets the Query variable equal to the SQL statement which will run a command.
        Query = "SELECT * FROM Product_Details WHERE Product_Code = '" + cboSelectProductUpdate.SelectedItem + "'"

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

            'Declaring variables to store data.
            Dim strProductCode As String
            Dim strProductGroup As String
            Dim strProductName As String
            Dim decProductPrice As Decimal

            'An IF statement used to determine whether the Reader has found the values from the Statement or not.
            While Reader.Read

                'Values are assigned to the variables.
                strProductCode = Reader.GetString(0)
                strProductGroup = Reader.GetString(1)
                strProductName = Reader.GetString(2)
                decProductPrice = Reader.GetDecimal(3)

                'Sets the controls equal to the values from the variables.
                txtProductCodeUpdate.Text = strProductCode
                txtProductGroupUpdate.Text = strProductGroup
                txtProductNameUpdate.Text = strProductName
                txtProductPriceUpdate.Text = decProductPrice

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

    Private Sub radGroup_CheckedChanged(sender As Object, e As EventArgs) Handles radGroup.CheckedChanged

        'An IF statement is used to enable the radio buttons on the form.
        If radGroup.Checked = True Then
            txtProductGroupUpdate.Enabled = True
            txtProductNameUpdate.Enabled = False
            txtProductCodeUpdate.Enabled = False
            txtProductPriceUpdate.Enabled = False
        End If

    End Sub

    Private Sub radName_CheckedChanged(sender As Object, e As EventArgs) Handles radName.CheckedChanged

        'An IF statement is used to enable the radio buttons on the form.
        If radName.Checked Then
            txtProductNameUpdate.Enabled = True
            txtProductGroupUpdate.Enabled = False
            txtProductCodeUpdate.Enabled = False
            txtProductPriceUpdate.Enabled = False
        End If

    End Sub

    Private Sub radCode_CheckedChanged(sender As Object, e As EventArgs) Handles radCode.CheckedChanged

        'An IF statement is used to enable the radio buttons on the form.
        If radCode.Checked Then
            txtProductCodeUpdate.Enabled = True
            txtProductGroupUpdate.Enabled = False
            txtProductNameUpdate.Enabled = False
            txtProductPriceUpdate.Enabled = False
        End If

    End Sub

    Private Sub radPrice_CheckedChanged(sender As Object, e As EventArgs) Handles radPrice.CheckedChanged

        'An IF statement is used to enable the radio buttons on the form.
        If radPrice.Checked Then
            txtProductPriceUpdate.Enabled = True
            txtProductGroupUpdate.Enabled = False
            txtProductNameUpdate.Enabled = False
            txtProductCodeUpdate.Enabled = False
        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        'Clears the items in the list box
        lstUpdate.Items.Clear()

        'An IF statement is used to determine the user's selection.
        If radGroup.Checked Then

            'A Value is assigned to the variable.
            strProductGroup = CStr(txtProductGroupUpdate.Text)

            'Sets the Query variable equal to the SQL statement which will run a command.
            Query = " UPDATE Product_Details SET Product_Group ='" & strProductGroup & "'WHERE Product_Code = '" & cboSelectProductUpdate.SelectedItem & "'"

            'Runs the Sub-Routine which will execute the necessary instructions.
            Run_Query()

            'Displays the updated product details in the list box.
            lstUpdate.Items.Add("New Product Group: " & strProductGroup)

            'A Message box is displayed to alert the user that the update was successful.
            MsgBox("Product updated.", MessageBoxIcon.Information)

        ElseIf radName.Checked Then

            'A Value is assigned to the variable.
            strProductName = CStr(txtProductNameUpdate.Text)

            'Sets the Query variable equal to the SQL statement which will run a command.
            Query = " UPDATE Product_Details SET Product_Group ='" & strProductName & "'WHERE Product_Code = '" & cboSelectProductUpdate.SelectedItem & "'"

            'Runs the Sub-Routine which will execute the necessary instructions.
            Run_Query()

            'Displays the updated product details in the list box.
            lstUpdate.Items.Add("New Product Name: " & strProductName)

            'A Message box is displayed to alert the user that the update was successful.
            MsgBox("Product updated.", MessageBoxIcon.Information)

        ElseIf radCode.Checked Then

            'A Value is assigned to the variable.
            strProductCode = CStr(txtProductCodeUpdate.Text)

            'Sets the Query variable equal to the SQL statement which will run a command.
            Query = " UPDATE Product_Details SET Product_Code ='" & strProductCode & "'WHERE Product_Code = '" & cboSelectProductUpdate.SelectedItem & "'"

            'Runs the Sub-Routine which will execute the necessary instructions.
            Run_Query()

            'Displays the updated product details in the list box.
            lstUpdate.Items.Add("New Product Code: " & strProductCode)

            'A Message box is displayed to alert the user that the update was successful.
            MsgBox("Product updated.", MessageBoxIcon.Information)

        ElseIf radPrice.Checked Then

            'A Value is assigned to the variable.
            decProductPrice = CDec(txtProductPriceUpdate.Text)

            'Sets the Query variable equal to the SQL statement which will run a command.
            Query = " UPDATE Product_Details SET Product_Price ='" & decProductPrice & "'WHERE Product_Code = '" & cboSelectProductUpdate.SelectedItem & "'"

            'Runs the Sub-Routine which will execute the necessary instructions.
            Run_Query()

            'Displays the updated product details in the list box.
            lstUpdate.Items.Add("New Product Price: " & decProductPrice.ToString("C"))

            'A Message box is displayed to alert the user that the update was successful.
            MsgBox("Product updated.", MessageBoxIcon.Information)

        End If

    End Sub

    Private Sub btnDeleteProduct_Click(sender As Object, e As EventArgs) Handles btnDeleteProduct.Click

        If cboSelectProductUpdate.Text = "" Then
            MsgBox("Please Select a product.", MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        'Sets the Query variable equal to the SQL statement which will run a command.
        Query = "DELETE * FROM Product_Details WHERE Product_Code = '" + cboSelectProductUpdate.Text + "' "

        'Runs the Sub-Routine which will execute the necessary instructions.
        Run_Query()

        'Displays the deleted product to the user.
        lstUpdate.Items.Add("Deleted Product: " & cboSelectProductUpdate.Text)

        'Clears all the items in the "Add Product" Group box.
        cboProductGroupUpdate.Text = " "
        cboSelectProductUpdate.Text = " "
        txtProductNameUpdate.Clear()
        txtProductCodeUpdate.Clear()
        txtProductPriceUpdate.Clear()

    End Sub

    Private Sub btnUpdateClear_Click(sender As Object, e As EventArgs) Handles btnUpdateClear.Click

        'Clears all the items in the "Add Product" Group box.
        cboProductGroupUpdate.Text = " "
        cboSelectProductUpdate.Text = " "
        txtProductNameUpdate.Clear()
        txtProductCodeUpdate.Clear()
        txtProductPriceUpdate.Clear()
        lstUpdate.Items.Clear()

    End Sub

    Private Sub btnProductDetails_Click(sender As Object, e As EventArgs) Handles btnProductDetails.Click

        'Closes the current interface.
        Me.Close()
        'Navigates the user back to the Main Menu Interface.
        frmProductInformation.Show()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        'Closes the current interface.
        Me.Close()
        'Navigates the user back to the Main Menu Interface.
        frmMainMenu.Show()

    End Sub
End Class