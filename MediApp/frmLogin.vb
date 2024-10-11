Imports System.Data.OleDb

Public Class frmLogin


    'Database Directory Path
    Dim DatabaseDir As String = "D:\\MediApp Program\\MediApp\\"
    'Database Name
    Dim DatabaseName As String = "LOG IN2002.mdb"
    'Digit code Database Name
    Dim SixDigitDatabaseName As String = "SixDigitCode.mdb"

    'Local Variables
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim iUserId As Integer = 0
    Dim Username As String = "asd"
    Dim totalTicks As Integer = 30
    Dim occuredTicks As Integer = 0

    'Call when the forms Load
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Combine the database directory and database name to make full path
        Dim DBPath As String = DatabaseDir + DatabaseName
        'Initialize access database connection
        conn = New OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + DBPath)
        'focus the username textfield
        txtUsername.Focus()
    End Sub

    'Error handling before Logging in
    Private Function OkayToSave() As Boolean
        Dim bRetVal As Boolean = False
        ErrorProvider1.Clear()
        'if username field is empty then show error
        If txtUsername.Text = "" Then
            ErrorProvider1.SetError(txtUsername, "Please Enter Username")
            txtUsername.Focus()
            'if password field is empty then show error
        ElseIf txtPassword.Text = "" Then
            ErrorProvider1.SetError(txtPassword, "Please Enter Password")
            txtPassword.Focus()
        Else
            bRetVal = True
        End If
        Return bRetVal
    End Function

    'Log in after matching credentials from database
    Private Function LoginUser() As Boolean
        Dim bRetVal As Boolean = False
        Try
            'open the connection
            conn.Open()
            'Initialize the command with query of any user with same username and password
            cmd = New OleDbCommand("select ID, FirstName, LastName, Image from Users where UserName = '" + txtUsername.Text + "' and Password = '" + txtPassword.Text + "'", conn)

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

    'Clear all text fields
    Private Sub ClearFields()
        txtUsername.Text = ""
        txtPassword.Text = ""
    End Sub

    Dim timestried As String = 0

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If Timer1.Enabled = False Then
            Dim success As Boolean = False
            'Error handling before Logging in
            If OkayToSave() Then
                timestried += 1
                'Log in after matching credentials from database
                If LoginUser() Then
                    'If credientials matched then open Main form
                    Dim newForm As frmMain = New frmMain()
                    newForm.Username = txtUsername.Text
                    Me.Hide()
                    'Pass the database path and name
                    newForm.DatabaseDir = DatabaseDir
                    newForm.DatabaseName = DatabaseName
                    newForm.ShowDialog()
                    ClearFields()
                    Me.Show()
                    txtUsername.Focus()
                    success = True
                Else
                    'if tries are less then 3 then show message
                    If timestried < 3 Then
                        MessageBox.Show("Invalid Username or Password !!, you have used " & timestried & " of your 3 login attempts.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        'Else show lockout message
                        MessageBox.Show("Incorrect login, maximum attempts reached, please try again in 30 seconds.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Timer1.Enabled = True
                        timestried = 0
                    End If
                End If
            End If
        Else
            Dim iTimeRemaining = totalTicks - occuredTicks
            MessageBox.Show(" Account locked, please wait " & iTimeRemaining & " seconds", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    'Call when user click register button and open respective form
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        'Show Registration Code Form
        Dim newForm As frmRegistrationCode = New frmRegistrationCode()
        Me.Hide()
        'Pass database path and digit code database name
        newForm.DatabaseDir = DatabaseDir
        newForm.DatabaseName = SixDigitDatabaseName
        newForm.ShowDialog()
        If newForm.bCode Then
            'Show Registration Form
            Dim newForm1 As frmRegistration = New frmRegistration()
            Me.Hide()
            'Pass database path and database name
            newForm1.DatabaseDir = DatabaseDir
            newForm1.DatabaseName = DatabaseName
            newForm1.SixDigitDatabaseName = SixDigitDatabaseName
            newForm1.iCodeId = newForm.iCodeId
            newForm1.ShowDialog()
        End If
        ClearFields()
        Me.Show()
        txtUsername.Focus()
    End Sub

    'Call when user click on Forget Button
    Private Sub btnForget_Click(sender As Object, e As EventArgs) Handles btnForget.Click
        'Show Forget Form
        Dim newForm As frmForget = New frmForget()
        Me.Hide()
        'Pass database path and database name
        newForm.DatabaseDir = DatabaseDir
        newForm.DatabaseName = DatabaseName
        newForm.ShowDialog()
        ClearFields()
        Me.Show()
        txtUsername.Focus()
    End Sub

    'Call when Timer ticks
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If occuredTicks = totalTicks Then
            timestried = 0
            Timer1.Enabled = False
        Else
            occuredTicks = occuredTicks + 1
        End If
    End Sub

    'Call when Form is closing
    Private Sub frmLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'disable the timer
        Timer1.Enabled = False
    End Sub
End Class
