Imports System.Data.OleDb
Imports System.IO
Imports AForge.Video
Imports AForge.Video.DirectShow

Public Class frmRegistration

    'Database Directory Path
    Public DatabaseDir As String = ""
    'Database Name
    Public DatabaseName As String = ""
    'digit code database name 
    Public SixDigitDatabaseName As String = ""
    'digit code for registration
    Public iCodeId As Integer = 0

    'Local Variables
    Dim CAMERA As VideoCaptureDevice
    Dim bmp As Bitmap
    Dim iUserId As Integer = 0
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand

    'Call when user click Take Photo button
    Private Sub btnTakePhoto_Click(sender As Object, e As EventArgs) Handles btnTakePhoto.Click
        'if button text is Take Photo then load webcam
        If btnTakePhoto.Text = "Take Photo" Then
            'Load Webcam
            Dim cameras As VideoCaptureDeviceForm = New VideoCaptureDeviceForm
            If cameras.ShowDialog() = Windows.Forms.DialogResult.OK Then
                'if user click ok then start webcam with user selected settings
                CAMERA = cameras.VideoDevice
                AddHandler CAMERA.NewFrame, New NewFrameEventHandler(AddressOf Captured)
                CAMERA.Start()
                btnTakePhoto.Text = "Release WebCam"
                btnCapture.Enabled = True
            End If
        Else
            'Else stop webcam
            CAMERA.Stop()
            btnTakePhoto.Text = "Take Photo"
            btnCapture.Enabled = False
        End If
    End Sub

    Private Sub Captured(sender As Object, eventArgs As NewFrameEventArgs)
        'Capture the webcam Images into webcam picture box
        bmp = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        pbWebCam.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
    End Sub

    'Call when user click on Captured button
    Private Sub btnCapture_Click(sender As Object, e As EventArgs) Handles btnCapture.Click
        'Capture the image from webcam picture box
        pbImage.Image = pbWebCam.Image
    End Sub

    'Call when user click on upload image button
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            'open file dialog box for selecting only image files
            Dim ofd As OpenFileDialog = New OpenFileDialog()
            ofd.Title = "Select Picture"
            ofd.Filter = "Image files|*.bmp;*.jpg;*.gif;*.png;*.tif"
            ofd.ShowDialog()
            pbImage.Image = System.Drawing.Image.FromFile(ofd.FileName)
        Catch ex As Exception
            'Do nothing
        End Try
    End Sub

    'Check user name if already exist in database
    Private Function checkUserName() As Boolean
        Dim bRetVal As Boolean = False
        Try
            'open the connection
            conn.Open()
            'Initialize the command with query of any user with same username
            cmd = New OleDbCommand("select ID from Users where UserName = '" + txtUsername.Text + "'", conn)

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

    'Error handling before saving user
    Private Function OkayToSave() As Boolean
        Dim bRetVal As Boolean = False
        ErrorProvider1.Clear()
        'if First Name text field is empty
        If txtName.Text = "" Then
            ErrorProvider1.SetError(txtName, "Please Enter First Name")
            txtName.Focus()
            'if Last Name text field is empty
        ElseIf txtLastName.Text = "" Then
            ErrorProvider1.SetError(txtLastName, "Please Enter Last Name")
            txtLastName.Focus()
            'if username field is empty then show error
        ElseIf txtUsername.Text = "" Then
            ErrorProvider1.SetError(txtUsername, "Please Enter Username")
            txtUsername.Focus()
            'if password field is empty show error
        ElseIf txtPassword.Text = "" Then
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
            'if Medical condition is not selected then show error
        ElseIf cbMedicalCondition.SelectedIndex < 0 Then
            ErrorProvider1.SetError(cbMedicalCondition, "Please select Medical Condition")
            'if security question is not selected then show error
        ElseIf cbSecurityQuestion.SelectedIndex < 0 Then
            ErrorProvider1.SetError(cbSecurityQuestion, "Please select Security Question")
            'if answer field is empty then show error
        ElseIf txtAnswer.Text = "" Then
            ErrorProvider1.SetError(txtAnswer, "Please Enter Answer of security question")
            txtAnswer.Focus()
            'if image is not selected then show error
        ElseIf pbImage.Image Is Nothing Then
            MessageBox.Show("Please Upload Picture")
            'if username is already exist then show error
        ElseIf checkUserName() Then
            ErrorProvider1.SetError(txtUsername, "Username Already Selected")
            txtUsername.Focus()
        Else
            bRetVal = True
        End If
        Return bRetVal
    End Function

    'Register USer
    Private Function RegisterUser() As Boolean
        Dim bRetVal As Boolean = False

        'Get picture box image to bytes
        Dim ms As MemoryStream = New MemoryStream()
        pbImage.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
        Dim image(ms.Length - 1) As Byte
        ms.Position = 0
        ms.Read(image, 0, image.Length)

        Try
            'open the connection
            conn.Open()
            'Initialize the command with query of inserting user with image
            cmd = New OleDbCommand("insert into Users([FirstName], [LastName], [UserName], [Password], [Image], [Question], [Answer]) VALUES ('" + txtName.Text + "','" + txtLastName.Text + "','" + txtUsername.Text + "','" + txtPassword.Text + "', @UserImage, '" + cbSecurityQuestion.Text + "', '" + txtAnswer.Text + "')", conn)
            'Add parameter of image
            cmd.Parameters.AddWithValue("@UserImage", image)
            'Excute the query
            cmd.ExecuteNonQuery()
            bRetVal = True
        Catch ex As Exception
            'Show Exception message if occured
            MessageBox.Show(ex.Message)
        Finally
            'Close the connection
            conn.Close()
        End Try
        Return bRetVal
    End Function

    Private Sub GetUserId()
        Try
            'open the connection
            conn.Open()
            'Initialize the command with query of any user with same username
            cmd = New OleDbCommand("select ID from Users where UserName = '" + txtUsername.Text + "'", conn)

            'Excute the query and load data in reader
            Dim dr As OleDbDataReader = cmd.ExecuteReader

            'If data is in reader then return true
            If dr.Read Then
                iUserId = Convert.ToInt32(dr.Item(0))
            End If
            'Close data reader
            dr.Close()
        Catch ex As Exception
        Finally
            'Close the connection
            conn.Close()
        End Try
    End Sub

    Private Function GetMedicalConditionId() As Integer
        Dim iRetVal As Integer = 0
        Try
            'open the connection
            conn.Open()
            'Initialize the command with query of any medicine with same medicine Name
            cmd = New OleDbCommand("select ID from MedicalConditions where MedicalCondition = '" + cbMedicalCondition.Text + "'", conn)

            'Excute the query and load data in reader
            Dim dr As OleDbDataReader = cmd.ExecuteReader

            'If data is in reader then return Id
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

    'Save Medical Condition
    Private Sub SaveMedicalCondition(iMedicalId As Integer)
        Try
            'open the connection
            conn.Open()
            'Initialize the command with query of inserting Medical Condition
            cmd = New OleDbCommand("insert into UserMedicalConditions([UserID], [MedicationID]) VALUES (" & Int32.Parse(iUserId) & "," & Int32.Parse(iMedicalId) & ")", conn)
            'Excute the query
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            'Show Exception message if occured
            MessageBox.Show(ex.Message)
        Finally
            'Close the connection
            conn.Close()
        End Try
    End Sub

    Private Sub UpdateCode()
        'DbPath for digit code database
        Dim DBPath As String = DatabaseDir + SixDigitDatabaseName
        'Initialize access database connection
        conn = New OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + DBPath)
        Try
            'open the connection
            conn.Open()
            'Initialize the command with query of updating 6 digit code
            cmd = New OleDbCommand("UPDATE 6digit SET [Used] = " & Boolean.Parse(True) & " WHERE ID= " & Int32.Parse(iCodeId), conn)
            'Excute the query
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        Finally
            'Close the connection
            conn.Close()
        End Try
    End Sub

    'Call when User Click Registration button
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        'Error handling before saving user
        If OkayToSave() Then
            GroupBox1.Enabled = False
            'Register User
            If RegisterUser() Then
                'Successfully Register then Get User ID
                GetUserId()
                'Get Medical Condition Id
                Dim iMedicalId As Integer = GetMedicalConditionId()
                'Save Medical Condition
                SaveMedicalCondition(iMedicalId)
                'Update digit code used
                UpdateCode()
                'Show successful message
                System.Windows.Forms.MessageBox.Show("Registered successfully")
                'Close the form
                Me.Close()
            End If
            GroupBox1.Enabled = True
        End If
    End Sub

    'Load Medical Conditions from database
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
                'Load the data in drop down menu for Medical Conditions
                cbMedicalCondition.Items.Add(dr.Item(0))
            End While
            'Close data reader
            dr.Close()
        Catch ex As Exception
        Finally
            'Close the connection
            conn.Close()
        End Try
    End Sub

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
    Private Sub frmRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Combine the database directory and database name to make full path
        Dim DBPath As String = DatabaseDir + DatabaseName
        'Initialize access database connection
        conn = New OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + DBPath)
        'Load Medical Conditions from database
        LoadMedicalConditions()
        'Load Security Questions from database
        LoadSecurityQuestions()
        'Disable Capture button on start
        btnCapture.Enabled = False
    End Sub

    'Call when Form is closing
    Private Sub frmRegistration_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            'if webcam is on then stop it
            If CAMERA IsNot Nothing Then
                CAMERA.Stop()
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class