Imports System.Data.OleDb
Imports System.IO

Public Class frmMain

    'Database Directory Path
    Public DatabaseDir As String = ""
    'Database Name
    Public DatabaseName As String = ""
    'Current Username
    Public Username As String = "asd"

    'Local Variables
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim iUserId As Integer = 0
    Dim sFirstName As String = ""
    Dim sLastName As String = ""
    Dim iMedicalConditionId As Integer = 0

    'Load Medical conditions from database
    Private Sub LoadMedicalConditions()
        Try
            'open the connection
            conn.Open()
            'Initialize the command with query of select all medical conditions
            cmd = New OleDbCommand("select MedicalCondition from MedicalConditions", conn)

            'Excute the query and load data in reader
            Dim dr As OleDbDataReader = cmd.ExecuteReader

            'Read till the data is in reader
            While dr.Read
                'Load the data in drop down menu for medical conditions
                cbMedicalConditions.Items.Add(dr.Item(0))
            End While
            'Close data reader
            dr.Close()
        Catch ex As Exception
        Finally
            'Close the connection
            conn.Close()
        End Try
    End Sub

    'Get User Id
    Private Sub GetUserId()
        Try
            'open the connection
            conn.Open()
            'Initialize the command with query of any user with same username
            cmd = New OleDbCommand("select ID, FirstName, LastName, Image from Users where UserName = '" + Username + "'", conn)

            'Excute the query and load data in reader
            Dim dr As OleDbDataReader = cmd.ExecuteReader

            'If data is in reader then return true
            If dr.Read Then
                iUserId = Convert.ToInt32(dr.Item(0))
                sFirstName = Convert.ToString(dr.Item(1))
                sLastName = Convert.ToString(dr.Item(2))

                Dim image() As Byte = dr.Item(3)
                Dim ms As MemoryStream = New MemoryStream(image)
                ToolStripPictureButton.Image = System.Drawing.Image.FromStream(ms)
            End If
            'Close data reader
            dr.Close()
        Catch ex As Exception
        Finally
            'Close the connection
            conn.Close()
        End Try
        UsernameToolStripMenuItem.Text = Username
        FirstnameToolStripMenuItem.Text = sFirstName
        LastnameToolStripMenuItem.Text = sLastName
    End Sub

    Private Sub LoadUserMedicalConditions()
        Try
            'clear data from Medical condtions table
            tbl_MedicalConditions.Rows.Clear()
            'open the connection
            conn.Open()
            'Initialize the command with query of all user medical conditions
            cmd = New OleDbCommand("select MedicalConditions.[MedicalCondition] from UserMedicalConditions, MedicalConditions where UserMedicalConditions.[UserID] = @userid and UserMedicalConditions.[MedicationID] = MedicalConditions.[ID]", conn)
            cmd.Parameters.AddWithValue("@userid", iUserId)

            'Excute the query and load data in reader
            Dim dr As OleDbDataReader = cmd.ExecuteReader

            'Read till the data is in reader
            While dr.Read
                'Load data in Medical condtions table
                Dim row As DataRow = tbl_MedicalConditions.NewRow
                row(0) = dr.Item(0)
                tbl_MedicalConditions.Rows.Add(row)
            End While
            'Close data reader
            dr.Close()
        Catch ex As Exception
        Finally
            'Close the connection
            conn.Close()
        End Try
    End Sub

    Private Sub LoadReminders()
        Try
            'clear data from reminder table
            tbl_Reminder.Rows.Clear()
            'open the connection
            conn.Open()
            Dim currentDate As DateTime = Convert.ToDateTime(DateTime.Now.ToString("dd MMM yyyy hh:mm tt"))
            'Initialize the command with query of all user reminders
            cmd = New OleDbCommand("select Reminder, DateTime, Occured from Reminders where UserID = @userid and DateTime > @appointmentDate", conn)
            cmd.Parameters.AddWithValue("@userid", iUserId)
            cmd.Parameters.AddWithValue("@appointmentDate", currentDate)

            'Excute the query and load data in reader
            Dim dr As OleDbDataReader = cmd.ExecuteReader

            'Read till the data is in reader
            While dr.Read
                'Load data in reminder table
                Dim row As DataRow = tbl_Reminder.NewRow
                row(0) = dr.Item(0)
                row(1) = dr.Item(1)
                row(2) = dr.Item(2)
                tbl_Reminder.Rows.Add(row)
            End While
            'Close data reader
            dr.Close()
        Catch ex As Exception
        Finally
            'Close the connection
            conn.Close()
        End Try
    End Sub

    Private Sub LoadAppointments()
        Try
            'clear data from Appointment table
            tbl_Appointments.Rows.Clear()
            'open the connection
            conn.Open()
            Dim currentDate As DateTime = Convert.ToDateTime(DateTime.Now.ToString("dd MMM yyyy hh:mm tt"))
            'Initialize the command with query of all user appointments
            cmd = New OleDbCommand("select DateTime, Occured from Appointments where UserID = @userid and DateTime > @appointmentDate", conn)
            cmd.Parameters.AddWithValue("@userid", iUserId)
            cmd.Parameters.AddWithValue("@appointmentDate", currentDate)

            'cmd = New OleDbCommand("select DateTime, Occured from Appointments where UserID = @userid", conn)
            'cmd.Parameters.AddWithValue("@userid", iUserId)

            'Read till the data is in reader
            Dim dr As OleDbDataReader = cmd.ExecuteReader

            While dr.Read
                'Load data in Appointment table
                Dim row As DataRow = tbl_Appointments.NewRow
                row(0) = dr.Item(0)
                row(1) = dr.Item(1)
                tbl_Appointments.Rows.Add(row)
            End While
            'Close data reader
            dr.Close()
        Catch ex As Exception
        Finally
            'Close the connection
            conn.Close()
        End Try
    End Sub

    Private Sub LoadPrescriptionOrders()
        Try
            'clear data from prescription orders table
            tbl_PrescriptionOrders.Rows.Clear()
            'open the connection
            conn.Open()
            'Initialize the command with query of all user prescription orders
            cmd = New OleDbCommand("select Medicines.[MedicineName], UserMedicines.[DozeOrdered] from UserMedicines, Medicines where UserMedicines.[UserID] = @userid and UserMedicines.[MedicineID] = Medicines.[ID]", conn)
            cmd.Parameters.AddWithValue("@userid", iUserId)

            'Excute the query and load data in reader
            Dim dr As OleDbDataReader = cmd.ExecuteReader

            'Read till the data is in reader
            While dr.Read
                'Load data in prescription orders table
                Dim row As DataRow = tbl_PrescriptionOrders.NewRow
                row(0) = dr.Item(0)
                row(1) = dr.Item(1)
                tbl_PrescriptionOrders.Rows.Add(row)
            End While
            'Close data reader
            dr.Close()
        Catch ex As Exception
        Finally
            'Close the connection
            conn.Close()
        End Try
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Combine the database directory and database name to make full path
        Dim DBPath As String = DatabaseDir + DatabaseName
        'Initialize access database connection
        conn = New OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + DBPath)
        'Load Medical conditons from database
        LoadMedicalConditions()
        GetUserId()
        'Load Users Medical conditons from database
        LoadUserMedicalConditions()
        'Load User Reminders from database
        LoadReminders()
        'Load User Appointments from database
        LoadAppointments()
        'Load User Prescription Orders from database
        LoadPrescriptionOrders()
        'Enable Timer
        Timer1.Enabled = True
        'Notify Icon settings
        NotifyIcon1.Icon = SystemIcons.Application
        NotifyIcon1.BalloonTipTitle = "Medicine Stock Alert"
        NotifyIcon1.BalloonTipText = "Kindly Check Medicine Stock"
        NotifyIcon1.BalloonTipIcon = ToolTipIcon.Error
    End Sub

    Private Function checkAlreadyExistance() As Boolean
        iMedicalConditionId = GetMedicalConditionId()
        Dim bRetVal As Boolean = False
        Try
            'open the connection
            conn.Open()
            'Initialize the command with query of any user medical condition with same medical condition name
            cmd = New OleDbCommand("select ID from UserMedicalConditions where UserID = " & Int32.Parse(iUserId) & " and MedicationID = " & Int32.Parse(iMedicalConditionId), conn)

            'Excute the query and load data in reader
            Dim dr As OleDbDataReader = cmd.ExecuteReader

            'If data is in reader then return true
            If dr.Read Then
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

    'Error handling before saving user medical condition
    Private Function OkayToSave() As Boolean
        Dim bRetVal As Boolean = False
        ErrorProvider1.Clear()
        'Show error if Medical condition is not selecting
        If cbMedicalConditions.SelectedIndex < 0 Then
            ErrorProvider1.SetError(cbMedicalConditions, "Please Select Medical Condition !!")
            'Show Error if User ID is not set from Main Form
        ElseIf iUserId <= 0 Then
            MessageBox.Show("User is not properply selected !!")
            'Show error if Medical condition already entered
        ElseIf checkAlreadyExistance() Then
            MessageBox.Show("Medical Condition Already Entered !!")
        Else
            bRetVal = True
        End If
        Return bRetVal
    End Function

    Private Function GetMedicalConditionId() As Integer
        Dim iRetVal As Integer = 0
        Try
            'open the connection
            conn.Open()
            'Initialize the command with query of any medition condition with same medical condition name
            cmd = New OleDbCommand("select ID from MedicalConditions where MedicalCondition = '" + cbMedicalConditions.Text + "'", conn)

            'Excute the query and load data in reader
            Dim dr As OleDbDataReader = cmd.ExecuteReader

            'If data is in reader then return medical condition id
            If dr.Read Then
                iRetVal = Convert.ToInt32(dr.Item(0))
            End If
            'Close data reader
            dr.Close()
        Catch ex As Exception
        Finally
            'Close the connection
            conn.Close()
        End Try
        Return iRetVal
    End Function

    Private Sub SaveMedicalCondition()
        Try
            'open the connection
            conn.Open()
            'Initialize the command with query of insering user medical condition
            cmd = New OleDbCommand("insert into UserMedicalConditions([UserID], [MedicationID]) VALUES (" & Int32.Parse(iUserId) & "," & Int32.Parse(iMedicalConditionId) & ")", conn)
            'Excute the query
            cmd.ExecuteNonQuery()
            'Show successful message
            System.Windows.Forms.MessageBox.Show("Medical Condition Added successfully")
        Catch ex As Exception
            'Show Exception message if occured
            MessageBox.Show(ex.Message)
        Finally
            'Close the connection
            conn.Close()
        End Try
    End Sub

    'Call when User click on Add medical condition button
    Private Sub btnAddMedicalCondition_Click(sender As Object, e As EventArgs) Handles btnAddMedicalCondition.Click
        'Error handling before saving user medical condition
        If OkayToSave() Then
            'Save Medical Condition
            SaveMedicalCondition()
            'Load user medical conditions from database
            LoadUserMedicalConditions()
        End If
    End Sub

    'Call when User click on Add Reminder button
    Private Sub btnCreateReminder_Click(sender As Object, e As EventArgs) Handles btnCreateReminder.Click
        'Show Reminder Form
        Dim NewFrm As frmAddReminder = New frmAddReminder()
        NewFrm.DatabaseDir = DatabaseDir
        NewFrm.DatabaseName = DatabaseName
        NewFrm.iUserID = iUserId
        NewFrm.ShowDialog()
        LoadReminders()
    End Sub

    'Call when User click on book Appointment button
    Private Sub btnCreateAppointment_Click(sender As Object, e As EventArgs) Handles btnCreateAppointment.Click
        'Show Appointment Form
        Dim NewFrm As frmAddAppointment = New frmAddAppointment()
        NewFrm.DatabaseDir = DatabaseDir
        NewFrm.DatabaseName = DatabaseName
        NewFrm.iUserID = iUserId
        NewFrm.ShowDialog()
        LoadAppointments()
    End Sub

    'Call when User click on Order Prescription button
    Private Sub btnOrderPrescription_Click(sender As Object, e As EventArgs) Handles btnOrderPrescription.Click
        'Show Order Prescription Form
        Dim NewFrm As frmOrderPrescription = New frmOrderPrescription()
        NewFrm.DatabaseDir = DatabaseDir
        NewFrm.DatabaseName = DatabaseName
        NewFrm.iUserId = iUserId
        NewFrm.ShowDialog()
        LoadPrescriptionOrders()
    End Sub

    'Call when User click on Google Map button
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Show Google Map Form
        Dim NewFrm As frmGoogleMaps = New frmGoogleMaps()
        NewFrm.ShowDialog()
    End Sub

    'Call when User click on Logout button
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Close()
    End Sub

    Dim AlarmDate As DateTime
    Dim ReminderString As String = ""

    'Check Reminder time for Alarm
    Private Function CheckReminders(currentDate As DateTime) As Boolean
        Dim bRetVal As Boolean = False
        Dim reminderDate As DateTime
        For index As Integer = 0 To tbl_Reminder.Rows.Count - 1
            reminderDate = tbl_Reminder.Rows(index)(1)
            If reminderDate.ToString("dd MMM yyyy hh:mm tt").Equals(currentDate.ToString("dd MMM yyyy hh:mm tt")) Then
                ReminderString = tbl_Reminder.Rows(index)(0)
                AlarmDate = reminderDate
                bRetVal = True
                index = tbl_Reminder.Rows.Count
            End If
        Next
        Return bRetVal
    End Function

    'Check Appointment time for Alarm
    Private Function CheckAppointments(currentDate As DateTime) As Boolean
        Dim bRetVal As Boolean = False
        Dim appointmentDate As DateTime
        For index As Integer = 0 To tbl_Appointments.Rows.Count - 1
            appointmentDate = tbl_Appointments.Rows(index)(0)
            If appointmentDate.ToString("dd MMM yyyy hh:mm tt").Equals(currentDate.ToString("dd MMM yyyy hh:mm tt")) Then
                AlarmDate = appointmentDate
                bRetVal = True
                index = tbl_Appointments.Rows.Count
            End If
        Next
        Return bRetVal
    End Function

    'Check Medicine Quantity for Alarm
    Private Function CheckMedicines() As Boolean
        Dim bRetVal As Boolean = False
        For index As Integer = 0 To tbl_PrescriptionOrders.Rows.Count - 1
            If tbl_PrescriptionOrders.Rows(index)(1) < 3 Then
                bRetVal = True
            End If
        Next
        Return bRetVal
    End Function

    Private Sub UpdateMedicineQuantity(sQuery As String)
        Try
            conn.Open()
            Dim cmd As OleDbCommand = New OleDbCommand(sQuery, conn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim currentDate As DateTime = DateTime.Now
        Dim bShow As Boolean = False
        'Check Reminder time for Alarm if yes play alram sound
        If CheckReminders(currentDate) Then
            ReminderString += " on " + AlarmDate.ToString("dd MMM yyyy") + " at " + AlarmDate.ToString("hh:mm tt")
            My.Computer.Audio.Play(System.AppDomain.CurrentDomain.BaseDirectory & "\Alarm.wav")
            bShow = True
        End If
        'Check appointment time for Alarm if yes play alram sound
        If CheckAppointments(currentDate) Then
            ReminderString = "Your Appointment on " + AlarmDate.ToString("dd MMM yyyy") + " at " + AlarmDate.ToString("hh:mm tt")
            My.Computer.Audio.Play(System.AppDomain.CurrentDomain.BaseDirectory & "\Alarm.wav")
            bShow = True
        End If
        'Check Medicine Quantity for Alarm if yes play alram sound
        If CheckMedicines() Then
            NotifyIcon1.Visible = True
            NotifyIcon1.ShowBalloonTip(30000)
        End If
        Dim sQuery As String = ""
        Dim bUpdate As Boolean = False
        'Check time for doze of medicine
        If currentDate.ToString("hh:mm tt").Equals("09:00 AM") Then
            sQuery = "UPDATE UserMedicines SET [DozeOrdered] = [DozeOrdered] - " & Int32.Parse(1) &
                            " WHERE [MorningDoze] = " & Boolean.Parse(True) & " and [UserID] = " & Int32.Parse(iUserId)
            bUpdate = True
        ElseIf currentDate.ToString("hh:mm tt").Equals("02:00 PM") Then
            sQuery = "UPDATE UserMedicines SET [DozeOrdered] = [DozeOrdered] - " & Int32.Parse(1) &
                            " WHERE [AfternoonDoze] = " & Boolean.Parse(True) & " and [UserID] = " & Int32.Parse(iUserId)
            bUpdate = True
        ElseIf currentDate.ToString("hh:mm tt").Equals("08:00 PM") Then
            sQuery = "UPDATE UserMedicines SET [DozeOrdered] = [DozeOrdered] - " & Int32.Parse(1) &
                            " WHERE [EveningDoze] = " & Boolean.Parse(True) & " and [UserID] = " & Int32.Parse(iUserId)
            bUpdate = True
        End If
        If bUpdate Then
            If MessageBox.Show("Medicine Time !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information) = DialogResult.OK Then
                UpdateMedicineQuantity(sQuery)
            End If
        End If
        If bShow Then
            MessageBox.Show(ReminderString)
        End If
    End Sub

    'Call when form is closing
    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Timer1.Enabled = False
        NotifyIcon1.Visible = False
    End Sub

    'Call when user click about button
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim NewFrm As frmAbout = New frmAbout()
        NewFrm.ShowDialog()
    End Sub
End Class