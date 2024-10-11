<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistration
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegistration))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbSecurityQuestion = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbMedicalCondition = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnCapture = New System.Windows.Forms.Button()
        Me.btnTakePhoto = New System.Windows.Forms.Button()
        Me.pbImage = New System.Windows.Forms.PictureBox()
        Me.pbWebCam = New System.Windows.Forms.PictureBox()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbWebCam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbSecurityQuestion)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cbMedicalCondition)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtAnswer)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtLastName)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.btnCreate)
        Me.GroupBox1.Controls.Add(Me.btnCapture)
        Me.GroupBox1.Controls.Add(Me.btnTakePhoto)
        Me.GroupBox1.Controls.Add(Me.pbImage)
        Me.GroupBox1.Controls.Add(Me.pbWebCam)
        Me.GroupBox1.Controls.Add(Me.txtConfirmPassword)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtUsername)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(634, 338)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registration"
        '
        'cbSecurityQuestion
        '
        Me.cbSecurityQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSecurityQuestion.FormattingEnabled = True
        Me.cbSecurityQuestion.Location = New System.Drawing.Point(154, 262)
        Me.cbSecurityQuestion.Name = "cbSecurityQuestion"
        Me.cbSecurityQuestion.Size = New System.Drawing.Size(150, 26)
        Me.cbSecurityQuestion.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 265)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(121, 18)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Security Question"
        '
        'cbMedicalCondition
        '
        Me.cbMedicalCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMedicalCondition.FormattingEnabled = True
        Me.cbMedicalCondition.Location = New System.Drawing.Point(154, 226)
        Me.cbMedicalCondition.Name = "cbMedicalCondition"
        Me.cbMedicalCondition.Size = New System.Drawing.Size(150, 26)
        Me.cbMedicalCondition.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 229)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 18)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Medical Condition"
        '
        'txtAnswer
        '
        Me.txtAnswer.Location = New System.Drawing.Point(154, 301)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(150, 26)
        Me.txtAnswer.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 304)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 18)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Answer"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(154, 72)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(150, 26)
        Me.txtLastName.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 18)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Last Name"
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(331, 240)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 38)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Upoad Image"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnCreate
        '
        Me.btnCreate.Image = CType(resources.GetObject("btnCreate.Image"), System.Drawing.Image)
        Me.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCreate.Location = New System.Drawing.Point(331, 287)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(138, 40)
        Me.btnCreate.TabIndex = 19
        Me.btnCreate.Text = "Register User"
        Me.btnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnCapture
        '
        Me.btnCapture.Image = CType(resources.GetObject("btnCapture.Image"), System.Drawing.Image)
        Me.btnCapture.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCapture.Location = New System.Drawing.Point(500, 187)
        Me.btnCapture.Name = "btnCapture"
        Me.btnCapture.Size = New System.Drawing.Size(113, 44)
        Me.btnCapture.TabIndex = 17
        Me.btnCapture.Text = "Capture"
        Me.btnCapture.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCapture.UseVisualStyleBackColor = True
        '
        'btnTakePhoto
        '
        Me.btnTakePhoto.Image = CType(resources.GetObject("btnTakePhoto.Image"), System.Drawing.Image)
        Me.btnTakePhoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTakePhoto.Location = New System.Drawing.Point(331, 187)
        Me.btnTakePhoto.Name = "btnTakePhoto"
        Me.btnTakePhoto.Size = New System.Drawing.Size(138, 44)
        Me.btnTakePhoto.TabIndex = 16
        Me.btnTakePhoto.Text = "Take Photo"
        Me.btnTakePhoto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTakePhoto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTakePhoto.UseVisualStyleBackColor = True
        '
        'pbImage
        '
        Me.pbImage.Location = New System.Drawing.Point(485, 34)
        Me.pbImage.Name = "pbImage"
        Me.pbImage.Size = New System.Drawing.Size(138, 147)
        Me.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbImage.TabIndex = 9
        Me.pbImage.TabStop = False
        '
        'pbWebCam
        '
        Me.pbWebCam.Location = New System.Drawing.Point(331, 34)
        Me.pbWebCam.Name = "pbWebCam"
        Me.pbWebCam.Size = New System.Drawing.Size(138, 147)
        Me.pbWebCam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbWebCam.TabIndex = 8
        Me.pbWebCam.TabStop = False
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Location = New System.Drawing.Point(154, 190)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPassword.Size = New System.Drawing.Size(150, 26)
        Me.txtConfirmPassword.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Confirm Password"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(154, 149)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(150, 26)
        Me.txtPassword.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Password"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(154, 110)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(150, 26)
        Me.txtUsername.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Username"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(154, 34)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(150, 26)
        Me.txtName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 362)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmRegistration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registration"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbWebCam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents pbWebCam As PictureBox
    Friend WithEvents pbImage As PictureBox
    Friend WithEvents btnTakePhoto As Button
    Friend WithEvents btnCapture As Button
    Friend WithEvents btnCreate As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAnswer As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbSecurityQuestion As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cbMedicalCondition As ComboBox
    Friend WithEvents Label7 As Label
End Class
