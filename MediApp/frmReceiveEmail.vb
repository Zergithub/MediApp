Public Class frmReceiveEmail

    Public sEmail As String = ""
    'Error handling before getting email
    Private Function OkayToSave() As Boolean
        Dim bRetVal As Boolean = False
        ErrorProvider1.Clear()
        'if email text field is empty then show error
        If txtEmail.Text = "" Then
            ErrorProvider1.SetError(txtEmail, "Please Enter Email")
            txtEmail.Focus()
        Else
            bRetVal = True
        End If
        Return bRetVal
    End Function

    'Call when user click OK button
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        'Error handling before getting email
        If OkayToSave() Then
            'return entered email and close Form
            sEmail = txtEmail.Text
            Me.Close()
        End If
    End Sub

    'Call when the forms Load
    Private Sub frmReceiveEmail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Focus the email text field
        txtEmail.Focus()
    End Sub
End Class