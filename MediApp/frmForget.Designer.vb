<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmForget
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmForget))
        Me.gbUser = New System.Windows.Forms.GroupBox()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.cbSecurityQuestion = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbPassword = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.gbUser.SuspendLayout()
        Me.gbPassword.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbUser
        '
        Me.gbUser.Controls.Add(Me.btnCreate)
        Me.gbUser.Controls.Add(Me.cbSecurityQuestion)
        Me.gbUser.Controls.Add(Me.Label8)
        Me.gbUser.Controls.Add(Me.txtAnswer)
        Me.gbUser.Controls.Add(Me.Label6)
        Me.gbUser.Controls.Add(Me.txtUsername)
        Me.gbUser.Controls.Add(Me.Label2)
        Me.gbUser.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbUser.Location = New System.Drawing.Point(12, 12)
        Me.gbUser.Name = "gbUser"
        Me.gbUser.Size = New System.Drawing.Size(308, 206)
        Me.gbUser.TabIndex = 0
        Me.gbUser.TabStop = False
        Me.gbUser.Text = "Credentials"
        '
        'btnCreate
        '
        Me.btnCreate.Image = CType(resources.GetObject("btnCreate.Image"), System.Drawing.Image)
        Me.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCreate.Location = New System.Drawing.Point(153, 142)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(138, 40)
        Me.btnCreate.TabIndex = 20
        Me.btnCreate.Text = "Confirm User"
        Me.btnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'cbSecurityQuestion
        '
        Me.cbSecurityQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSecurityQuestion.FormattingEnabled = True
        Me.cbSecurityQuestion.Location = New System.Drawing.Point(141, 71)
        Me.cbSecurityQuestion.Name = "cbSecurityQuestion"
        Me.cbSecurityQuestion.Size = New System.Drawing.Size(150, 26)
        Me.cbSecurityQuestion.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(121, 18)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Security Question"
        '
        'txtAnswer
        '
        Me.txtAnswer.Location = New System.Drawing.Point(141, 110)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(150, 26)
        Me.txtAnswer.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 18)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Answer"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(141, 28)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(150, 26)
        Me.txtUsername.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 18)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Username"
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Location = New System.Drawing.Point(137, 73)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPassword.Size = New System.Drawing.Size(150, 26)
        Me.txtConfirmPassword.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 18)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Confirm Password"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(137, 32)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(150, 26)
        Me.txtPassword.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 18)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Password"
        '
        'gbPassword
        '
        Me.gbPassword.Controls.Add(Me.Button1)
        Me.gbPassword.Controls.Add(Me.txtConfirmPassword)
        Me.gbPassword.Controls.Add(Me.Label3)
        Me.gbPassword.Controls.Add(Me.Label4)
        Me.gbPassword.Controls.Add(Me.txtPassword)
        Me.gbPassword.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbPassword.Location = New System.Drawing.Point(326, 12)
        Me.gbPassword.Name = "gbPassword"
        Me.gbPassword.Size = New System.Drawing.Size(316, 206)
        Me.gbPassword.TabIndex = 16
        Me.gbPassword.TabStop = False
        Me.gbPassword.Text = "Set New Password"
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(184, 133)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 49)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Reset Password"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmForget
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 229)
        Me.Controls.Add(Me.gbPassword)
        Me.Controls.Add(Me.gbUser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmForget"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Forget Password"
        Me.gbUser.ResumeLayout(False)
        Me.gbUser.PerformLayout()
        Me.gbPassword.ResumeLayout(False)
        Me.gbPassword.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbUser As GroupBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents gbPassword As GroupBox
    Friend WithEvents cbSecurityQuestion As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtAnswer As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnCreate As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
