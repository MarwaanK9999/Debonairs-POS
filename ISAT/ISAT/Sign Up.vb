'Imports the OleDB System Data into the Application.
Imports System.Data.OleDb
Imports System.IO

Public Class frmSignUp

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

    'Declaring variables which will be used to store the required data.
    Dim strUsername As String = ""
    Dim strPassword As String = ""
    Dim strName As String = ""
    Dim strSurname As String = ""

    'Declaring a Query which will be used to store the SQL Statement Strings.
    Dim Query As String

    'A Sub-routine which will be used to Execute the Query Statement and make necessary changes or references to the Database.
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

    Private Sub frmSignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'The Database Connection String, which connects the database to the application.
        Access_Database.ConnectionString = "Provider=Microsoft.ACE.OleDb.12.0;Data Source = " & Data_Directory

        'Focuses the user on the assigned text box.
        txtName.Focus()

    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click

        'Defensive Programming and data validation techniques to validate user input.
        If String.IsNullOrWhiteSpace(txtName.Text) Then
            MsgBox("Please enter all the required data.", MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf String.IsNullOrWhiteSpace(txtSurname.Text) Then
            MsgBox("Please enter all the required data.", MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf String.IsNullOrWhiteSpace(txtUsername.Text) Then
            MsgBox("Please enter all the required data.", MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MsgBox("Please enter all the required data.", MessageBoxIcon.Exclamation)
            Exit Sub
        Else
            'Assigns values to the data.
            strUsername = CStr(txtUsername.Text)
            strPassword = CStr(txtPassword.Text)
            strName = CStr(txtName.Text)
            strSurname = CStr(txtSurname.Text)

            'Sets the Query variable equal to the SQL statement which will run a command.
            Query = "INSERT INTO [Login] ([Name], [Surname], [Username], [Password]) VALUES ('" & strName & "','" & strSurname & "','" & strUsername & "','" & strPassword & "')"

            'Runs the Sub-Routine which will execute the necessary instructions.
            Run_Query()

            'Clears the text box controls.
            txtName.Clear()
            txtSurname.Clear()
            txtUsername.Clear()
            txtPassword.Clear()
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Exits the entire application.
        Application.Exit()

    End Sub

    Private Sub btnContinueLogin_Click(sender As Object, e As EventArgs) Handles btnContinueLogin.Click

        'Closes the current interface.
        Me.Close()
        'Shows the Login Interface.
        frmLogin.Show()

    End Sub
End Class