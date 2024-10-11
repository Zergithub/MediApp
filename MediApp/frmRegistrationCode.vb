Imports System.Data.OleDb

Public Class frmRegistrationCode

    'Database Directory Path
    Public DatabaseDir As String = ""
    'Database Name
    Public DatabaseName As String = ""
    'Current Code Id
    Public iCodeId As Integer = 0
    'Returning variable if correct code is entered
    Public bCode As Boolean = False

    'Local Variables
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand

    'Check code is digit code database
    Private Function checkCode() As Boolean
        Dim bRetVal As Boolean = False
        Try
            'open the connection
            conn.Open()
            'Initialize the command with query of any digit code with same entered code
            cmd = New OleDbCommand("select ID from 6digit where DigitCode = " & Int32.Parse(txtDigit.Text) & " and Used = " & Boolean.Parse(False), conn)

            'Excute the query and load data in reader
            Dim dr As OleDbDataReader = cmd.ExecuteReader

            'If data is in reader then return true
            If dr.Read Then
                iCodeId = Convert.ToInt32(dr.Item(0))
                bRetVal = True
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

    'Call When User click Submit button
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ErrorProvider1.Clear()
        'if digit text field is empty show error
        If txtDigit.Text = "" Then
            ErrorProvider1.SetError(txtDigit, "Please Enter Digit Code")
            txtDigit.Focus()
        Else
            'check code
            If checkCode() Then
                bCode = True
                Me.Close()
            Else
                'If code doesn't exist in database show error
                MessageBox.Show("Invalid Code !!")
            End If
        End If
    End Sub

    Private Sub frmRegistrationCode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Combine the database directory and database name to make full path
        Dim DBPath As String = DatabaseDir + DatabaseName
        'Initialize access database connection
        conn = New OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + DBPath)
        'focus digit text field
        txtDigit.Focus()
    End Sub
End Class