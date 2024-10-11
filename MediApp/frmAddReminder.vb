Imports System.Data.OleDb

Public Class frmAddReminder
    'Current User ID
    Public iUserID As Integer = 0
    'Database Directory Path
    Public DatabaseDir As String = ""
    'Database Name
    Public DatabaseName As String = ""

    'Variables
    Dim reminderDate As DateTime
    Dim conn As OleDbConnection

    'Call when the forms Load
    Private Sub frmAddReminder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Combine the database directory and database name to make full path
        Dim DBPath As String = DatabaseDir + DatabaseName
        'Initialize access database connection
        conn = New OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + DBPath)
        'Force the min date of Reminder to today
        dtpReminder.MinDate = System.DateTime.Now
    End Sub

    'Error handling before saving appointment
    Private Function OkayToSave() As Boolean
        Dim bRetVal As Boolean = False
        ErrorProvider1.Clear()
        'if Reminder text is Empty show Error
        If txtReminder.Text = "" Then
            ErrorProvider1.SetError(txtReminder, "Please Enter Reminder Text")
            txtReminder.Focus()
            'Show Error if User ID is not set from Main Form
        ElseIf iUserID <= 0 Then
            MessageBox.Show("User is not properply selected !!")
        Else
            bRetVal = True
        End If
        Return bRetVal
    End Function

    'Save the reminder in database
    Private Sub SaveReminder()
        Try
            'open the connection
            conn.Open()
            'Initialize the coomand with query of inserting Reminder
            Dim cmd As OleDbCommand = New OleDbCommand("insert into Reminders([UserID], [Reminder], [DateTime], [Occured]) VALUES (" & Int32.Parse(iUserID) & ",'" + txtReminder.Text + "', @ReminderDate ," & Int32.Parse(0) & ")", conn)
            'Add the parameters of reminder date
            cmd.Parameters.AddWithValue("@ReminderDate", reminderDate)
            'Excute the query
            cmd.ExecuteNonQuery()
            'Show successful message
            System.Windows.Forms.MessageBox.Show("Add Reminder successfully")
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

    'Call when user click the create button
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        'Error handling before saving reminder
        If OkayToSave() Then
            'set the reminder date value from date time picker.
            reminderDate = dtpReminder.Value
            'Save the Reminder
            SaveReminder()
        End If
    End Sub
End Class