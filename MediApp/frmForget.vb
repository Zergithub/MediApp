Imports System.Data.OleDb

Public Class frmForget

    'Database Directory Path
    Public DatabaseDir As String = ""
    'Database Name
    Public DatabaseName As String = ""

    'Local Variables
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim iUserId As Integer = 0

    'Load Security Questions from database
    Private Sub LoadSecurityQuestions()
        Try
            'open the connection
            conn.Open()
            'Initialize the command with query of select all security questions
            cmd = New OleDbCommand("select Question from SecurityQuestions", conn)

            'Excute the query and load data in reader
            Dim dr As OleDbDataReader = cmd.ExecuteReader

            'Read till the data is in reader
            While dr.Read
                'Load the data in drop down menu for security questions
                cbSecurityQuestion.Items.Add(dr.Item(0))
            End While
            'Close data reader
            dr.Close()
        Catch ex As Exception
        Finally
            'Close the connection
            conn.Close()
            'Set width for drop down menu for handling data
            cbSecurityQuestion.DropDownWidth = 400
        End Try
    End Sub

    'Call when the forms Load
    Private Sub frmForget_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Combine the database directory and database name to make full path
        Dim DBPath As String = DatabaseDir + DatabaseName
        'Initialize access database connection
        conn = New OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + DBPath)
        'Load Security Questions from database
        LoadSecurityQuestions()
        'disable password group box on loading
        gbPassword.Enabled = False
    End Sub

    'Check if username already exists in database
    Private Function checkUser() As Boolean
        Dim bRetVal As Boolean = False
        Try
            'open the connection
            conn.Open()
            'Initialize the command with query of any user with same username
            cmd = New OleDbCommand("select ID from Users where UserName = '" + txtUsername.Text + "' and Question = '" + cbSecurityQuestion.Text + "' and Answer = '" + txtAnswer.Text + "'", conn)

            'Excute the query and load data in reader
            Dim dr As OleDbDataReader = cmd.ExecuteReader

            'If data is in reader then return true
            If dr.Read Then
                bRetVal = True
                iUserId = Convert.ToInt32(dr.Item(0))
            End If

            'Close data reader
            dr.Close()
        Catch ex As Exception
        Finally
            'Close the connection
            conn.Close()
        End Try
        Return bRetVal
    End Function

    'Error handling before checking username and password
    Private Function OkayToCheck() As Boolean
        Dim bRetVal As Boolean = False
        ErrorProvider1.Clear()
        'if username field is empty then show error
        If txtUsername.Text = "" Then
            ErrorProvider1.SetError(txtUsername, "Please Enter Username")
            txtUsername.Focus()
            'if security question is not selected then show error
        ElseIf cbSecurityQuestion.SelectedIndex < 0 Then
            ErrorProvider1.SetError(cbSecurityQuestion, "Please Select Security Question")
            'if answer field is empty then show error
        ElseIf txtAnswer.Text = "" Then
            ErrorProvider1.SetError(txtAnswer, "Please Enter Answer")
            txtAnswer.Focus()
        Else
            bRetVal = True
        End If
        Return bRetVal
    End Function

    'Call when user click the check button
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        'Error handling before checking username and password
        If OkayToCheck() Then
            'Check if username already exists in database
            If checkUser() Then
                'Then enable password group box
                gbPassword.Enabled = True
                gbUser.Enabled = False
            Else
                'Else show error message
                MessageBox.Show("Invalid Credentials !!")
            End If
        End If
    End Sub

    'Error handling before reseting the password
    Private Function OkayToSave() As Boolean
        Dim bRetVal As Boolean = False
        ErrorProvider1.Clear()
        'if password field is empty show error
        If txtPassword.Text = "" Then
            ErrorProvider1.SetError(txtPassword, "Please Enter Password")
            txtPassword.Focus()
            'if confirm password field is empty show error
        ElseIf txtConfirmPassword.Text = "" Then
            ErrorProvider1.SetError(txtConfirmPassword, "Please Enter Confirm Password")
            txtConfirmPassword.Focus()
            'if password and confirm password fields doesn't match show error
        ElseIf txtPassword.Text <> txtConfirmPassword.Text Then
            ErrorProvider1.SetError(txtConfirmPassword, "Password must match")
            txtConfirmPassword.Focus()
        Else
            bRetVal = True
        End If
        Return bRetVal
    End Function

    'Update the password
    Private Sub UpdateUser()
        'Query for updating password
        Dim sQuery As String = "UPDATE Users SET [Password] = '" + txtPassword.Text + "'" &
                            " WHERE ID= " & Int32.Parse(iUserId)
        Try
            'open the connection
            conn.Open()
            'Initialize the command with query of updating password
            cmd = New OleDbCommand(sQuery, conn)
            'Excute the query
            cmd.ExecuteNonQuery()
            'Show successful message
            MessageBox.Show("Password Changed Successfully !!")
            'Close the form
            Me.Close()
        Catch ex As Exception
            'Show Exception message if occured
            MessageBox.Show(ex.Message)
        Finally
            'Close the connection
            conn.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Error handling before reseting the password
        If OkayToSave() Then
            'Update the password
            UpdateUser()
        End If
    End Sub
End Class