Imports System.Data.OleDb

Public Class frmAddAppointment
    'Current User ID
    Public iUserID As Integer = 0
    'Database Directory Path
    Public DatabaseDir As String = ""
    'Database Name
    Public DatabaseName As String = ""

    'Local Variables
    Dim appointmentDate As DateTime
    Dim bReceiveEmail As Boolean = False
    Dim ReceiveEmail As String = ""
    Dim conn As OleDbConnection

    'Call when the forms Load
    Private Sub frmAddAppointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Combine the database directory and database name to make full path
        Dim DBPath As String = DatabaseDir + DatabaseName
        'Initialize access database connection
        conn = New OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + DBPath)
        'Force the min date of appointment to today
        dtpAppointment.MinDate = System.DateTime.Now
    End Sub

    'Error handling before saving appointment
    Private Function OkayToSave() As Boolean
        Dim bRetVal As Boolean = False
        'Show Error if User ID is not set from Main Form
        If iUserID <= 0 Then
            MessageBox.Show("User is not properply selected !!")
        Else
            bRetVal = True
        End If
        Return bRetVal
    End Function

    'Save the appointment in database
    Private Sub SaveReminder()
        Try
            'open the connection
            conn.Open()
            'Initialize the command with query of inserting Appointment
            Dim cmd As OleDbCommand = New OleDbCommand("insert into Appointments([UserID], [DateTime], [Occured], [ReceiveEmail], [Email]) VALUES (" & Int32.Parse(iUserID) & ", @ReminderDate , @occured, @receiveEmail, '" + ReceiveEmail + "')", conn)
            'Add the parameters of appointment date and other boolean variables
            cmd.Parameters.Add(New OleDbParameter("@ReminderDate", OleDbType.Date)).Value = appointmentDate
            cmd.Parameters.Add(New OleDbParameter("@occured", OleDbType.Boolean, 1)).Value = False
            cmd.Parameters.Add(New OleDbParameter("@receiveEmail", OleDbType.Boolean, 1)).Value = bReceiveEmail
            'Excute the query
            cmd.ExecuteNonQuery()
            'Show successful message
            System.Windows.Forms.MessageBox.Show("Your appointment has been booked with doctor on " + appointmentDate.ToString("dd") + "rd of " + appointmentDate.ToString("MMMMMMMMM") + " at " + appointmentDate.ToString("hh:mm tt"))
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
        'Error handling before saving appointment
        If OkayToSave() Then
            'set the appointment date value from date time picker.
            appointmentDate = dtpAppointment.Value
            bReceiveEmail = False
            ReceiveEmail = ""
            'Message for Email receiving
            Dim message As String = "Would you like to receive an email?"
            'Show message for receiving email
            If MessageBox.Show(message, "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                'if User click Yes then show ReceiveEmail Form 
                bReceiveEmail = True
                Dim NewFrm As frmReceiveEmail = New frmReceiveEmail()
                NewFrm.ShowDialog()
                ReceiveEmail = NewFrm.sEmail
            End If
            'Save the Appointment
            SaveReminder()
        End If
    End Sub
End Class