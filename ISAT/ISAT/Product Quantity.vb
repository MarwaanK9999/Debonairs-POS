'Imports the OleDB System Data into the Application.
Imports System.Data.OleDb
Imports System.IO
Public Class frmProductQuantity

    'Declaring a variable which gets the current directory where the database or datasource is stored in.
    Dim Data_Directory As String = Directory.GetCurrentDirectory() & "\Debonairs.accdb"

    'Declaring a variable which initializes a new instance of the OleDB class.
    Dim Access_Database As New OleDbConnection

    'Declaring a Query which will be used to store the SQL Statement Strings.
    Dim Query As String

    Private Sub frmProductQuantity_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'The Database Connection String, which connects the database to the application.
        Access_Database.ConnectionString = "Provider=Microsoft.ACE.OleDb.12.0;Data Source = " & Data_Directory

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        'Data Validation and Defensive Programming techniques to validate user input.
        If String.IsNullOrWhiteSpace(txtProductCode.Text) Then
            MsgBox("Please Enter the required data", MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        'Sets the Query variable equal to the SQL statement which will run a command.
        Query = "SELECT * FROM Product_Details WHERE Product_Code = '" + txtProductCode.Text + "'"

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
            Reader = Cmd.ExecuteReader

            'An IF statement used to determine whether the Reader has found the values from the Statement or not.
            If Reader.Read = True Then
                'If the product is out of stock, a message box will appear to alert the user.
                If Reader("Product_Quantity") = 0 Then
                    MsgBox("Product Found, Please Restock.", MessageBoxIcon.Exclamation)
                    'If the product is in stock, a message box will appear to alert the user.
                ElseIf Reader("Product_Quantity") < 0 Then
                    MsgBox("Product Found, Still in stock.", MessageBoxIcon.Information)
                End If

                'Adds the Product Information from the Database to the controls on the form.
                cboProductGroup.Items.Add(Reader("Product_Group"))
                cboProductGroup.SelectedText = Reader("Product_Group")
                cboSelectedProduct.Items.Add(Reader("Product_Name"))
                cboSelectedProduct.SelectedText = Reader("Product_Name")
                'Displays the Current Product Quantity in the list box.
                lstDisplayQuantity.Items.Add("Current Product Quantity:" & vbTab & Reader("Product_Quantity"))
            Else
                'Clears the text box which contains the Product Code.
                txtProductCode.Clear()
                'A Message box appears to alert the user that the product has not been found.
                MsgBox("Product Not Found")
                'Focuses on the Product Quantity text box to navigate the user to the control.
                txtProductCode.Focus()
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

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        'Declaring an OleDBCommand variable to be used to execute instructions against the Data Source.
        Dim Cmd As OleDbCommand
        'Declaring an OleDBDataReader to be used to read the Rows in the Data Source when it's executed.
        Dim Reader As OleDbDataReader

        'Declaring variables to be used to store values.
        Dim InitalQty As Integer
        Dim AddedQty As Integer
        Dim FinalQty As Integer

        'Sets the Query variable equal to the SQL statement which will run a command.
        Query = "SELECT * FROM Product_Details WHERE Product_Code = '" + txtProductCode.Text + "'"

        'Making use of Try - Catch - Finally to trap any possible errors.
        Try
            'Opens the database connection.
            Access_Database.Open()

            'Sets the Command equal to the Query which will contain the SQL statement, and the Data Connection String.
            Cmd = New OleDbCommand(Query, Access_Database)
            'Executes the reader against the Command.
            Reader = Cmd.ExecuteReader

            'An IF statement used to determine whether the Reader has found the values from the Statement or not.
            If Reader.Read = True Then

                'Values are given to the variables that were declared to store the quantity values.
                InitalQty = Reader("Product_Quantity")
                AddedQty = CInt(txtProductQuantity.Text)

                'A calculation is done to determine the new quantity.
                FinalQty = InitalQty + AddedQty
            Else
                'Clears the text box which contains the Product Code.
                txtProductQuantity.Clear()
                'A message box appears to alert the user that the quantity has not been updated successfully.
                MsgBox("Product Not Updated", MessageBoxIcon.Exclamation)
                'Exits the sub and so that no further execution will be done.
                Exit Sub
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

        'Sets the Query variable equal to the SQL statement which will run a command.
        Query = "UPDATE Product_Details SET Product_Quantity='" & FinalQty & "'WHERE Product_Code = '" & txtProductCode.Text & "'"

        'Making use of Try - Catch - Finally to trap any possible errors.
        Try
            'Opens the database connection.
            Access_Database.Open()

            'Sets the Command equal to the Query which will contain the SQL statement, and the Data Connection String.
            Cmd = New OleDbCommand(Query, Access_Database)


            'Declaring an OleDBDataReader to be used to read the Rows in the Data Source when it's executed.
            Reader = Cmd.ExecuteReader

            'An IF statement used to determine whether the Reader has found the values from the Statement or not.
            If Reader.Read Then
                'The Final Quantity is set to the Current Quantity in the Database.
                FinalQty = Reader("Product_Quantity")
            End If

            'Data Validation and Defensive Programming techniques to validate user input.
            If IsNumeric(txtProductQuantity.Text) = False Then
                MsgBox("Please Enter a Number.", MessageBoxIcon.Exclamation)
                Exit Sub
            ElseIf String.IsNullOrWhiteSpace(txtProductQuantity.Text) Then
                MsgBox("Please Enter the required data", MessageBoxIcon.Exclamation)
                    Exit Sub
                End If

            'A message box appears to alert the user that the quantity has been updated successfully.
            MsgBox("Product Updated", MessageBoxIcon.Information)

            'The new Product Quantity is displayed in the list box.
            lstDisplayQuantity.Items.Add("The New Product Quantity is: " & FinalQty)

            'Closes the database connection after the Command has been run.
            Access_Database.Close()

        Catch ex As Exception
            'Displays a messagebox to alert the user that there is an error.
            MsgBox(ex.Message)
            Exit Sub
        Finally
            'Closes the database connection IF an error has occured.
            Access_Database.Close()

        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'Clears all the controls on the form.
        txtProductCode.Clear()
        cboProductGroup.Items.Clear()
        cboSelectedProduct.Items.Clear()
        txtProductQuantity.Clear()
        lstDisplayQuantity.Items.Clear()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        'Closes the current interface.
        Me.Close()
        'Navigates the user back to the Main Menu Interface.
        frmMainMenu.Show()

    End Sub
End Class