'Imports the OleDB System Data into the Application.
Imports System.Data.OleDb
Imports System.IO
Public Class frmLogin

    'Declaring a variable which gets the current directory where the database or datasource is stored in.
    Dim Data_Directory As String = Directory.GetCurrentDirectory() & "\Debonairs.accdb"

    'Declaring a variable which initializes a new instance of the OleDB class.
    Dim Access_Database As New OleDbConnection

    'Declaring a Query which will be used to store the SQL Statement Strings.
    Dim Query As String

    'A Sub-routine which will be used to Execute the Query Statement and make necessary changes or references to the Database.
    Private Sub Run_Query()

        'The Database Connection String, which connects the database to the application.
        Access_Database.ConnectionString = "Provider=Microsoft.ACE.OleDb.12.0;Data Source = " & Data_Directory

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
            If Reader.Read Then
                'Sends the  data in the text box to a variable that was declared in the POS interface.
                frmPOS.strUser = txtUsername.Text
                'Hides the current interface.
                Me.Hide()
                'Navigates to the main menu of the application.
                frmMainMenu.Show()
            Else
                'Clears the controls on the form.
                txtUsername.Clear()
                txtPassword.Clear()
                'Displays a messagebox to alert the user that there is an error.
                MsgBox("Invalid Username or Password")
                'Focuses on the Username text box to make input for the user easier.
                txtUsername.Focus()
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
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Focuses the user on the Username text box.
        txtUsername.Focus()

    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        'Defensive Programming and Data Validation techniques to validate user input.
        If String.IsNullOrWhiteSpace(txtUsername.Text) Then
            MsgBox("Please enter all the required data", MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MsgBox("Please enter all the required data", MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        'Sets the Query variable equal to the SQL statement which will run a command.
        Query = "SELECT * FROM Login WHERE Username + Password = '" + txtUsername.Text + txtPassword.Text + "'"

            'Runs the Sub-Routine which will execute the necessary instructions.
            Run_Query()


    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click

        'Hides the current Interface.
        Me.Hide()
        'Shows the sign up Interface.
        frmSignUp.Show()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Exits the entire application.
        Application.Exit()

    End Sub
End Class
