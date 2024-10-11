Imports System.Data.OleDb

Public Class frmOrderPrescription

    'Current User ID
    Public iUserId As Integer = 0
    'Database Directory Path
    Public DatabaseDir As String = ""
    'Database Name
    Public DatabaseName As String = ""

    'Local Variables
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand

    'Load Medicines from database
    Private Sub LoadMedicines()
        Try
            'open the connection
            conn.Open()
            'Initialize the command with query of select all Medicines
            cmd = New OleDbCommand("select MedicineName from Medicines", conn)

            'Excute the query and load data in reader
            Dim dr As OleDbDataReader = cmd.ExecuteReader

            'Read till the data is in reader
            While dr.Read
                'Load the data in drop down menu for Medicines
                cbMedicine.Items.Add(dr.Item(0))
            End While
            'Close data reader
            dr.Close()
        Catch ex As Exception
        Finally
            'Close the connection
            conn.Close()
        End Try
    End Sub

    'Call when the forms Load
    Private Sub frmOrderPrescription_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Combine the database directory and database name to make full path
        Dim DBPath As String = DatabaseDir + DatabaseName
        'Initialize access database connection
        conn = New OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + DBPath)
        'Load Medicines from database
        LoadMedicines()
    End Sub

    'Check Medicine if already ordered
    Private Function chkMedicine() As Boolean
        Dim bRetVal As Boolean = False
        'Loop through Medicine ordered table
        For index As Integer = 0 To tbl_UserMedicines.Rows.Count - 1
            'if already exists then return True
            If tbl_UserMedicines.Rows(index)(0).Equals(cbMedicine.Text) Then
                bRetVal = True
                index = tbl_UserMedicines.Rows.Count
            End If
        Next
        Return bRetVal
    End Function

    'Error handling before add medicine into ordered table
    Private Function OkayToSave() As Boolean
        Dim bRetVal As Boolean = False
        ErrorProvider1.Clear()
        'if Medicine is not selected then show error
        If cbMedicine.SelectedIndex < 0 Then
            ErrorProvider1.SetError(cbMedicine, "Please Select Medicine !!")
            'if Quanty is less then zero show error
        ElseIf txtQty.Value <= 0 Then
            ErrorProvider1.SetError(txtQty, "Quantity must be greater than zero !!")
            'if doze time is not selected then show error
        ElseIf cbMorning.Checked = False And cbAfternoon.Checked = False And cbNight.Checked = False Then
            ErrorProvider1.SetError(cbMorning, "Please Select One doze per day !!")
            'Show Error if User ID is not set from Main Form
        ElseIf iUserId <= 0 Then
            MessageBox.Show("User is not properply selected !!")
            'Check Medicine if already ordered then show error
        ElseIf chkMedicine() Then
            MessageBox.Show("Medicine Already Entered !!")
        Else
            bRetVal = True
        End If
        Return bRetVal
    End Function

    'Call when user click on Add button
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'Error handling before add medicine into ordered table
        If OkayToSave() Then
            'Add new row in medicine ordered table
            Dim newRow As DataRow = tbl_UserMedicines.NewRow
            newRow(0) = cbMedicine.Text
            newRow(1) = txtQty.Value
            newRow(2) = cbMorning.Checked
            newRow(3) = cbAfternoon.Checked
            newRow(4) = cbNight.Checked
            tbl_UserMedicines.Rows.Add(newRow)
        End If
    End Sub

    'Get Medicine Id from database
    Private Function GetMedicineId(medicineName As String) As Integer
        Dim iRetVal As Integer = 0
        Try
            'open the connection
            conn.Open()
            'Initialize the command with query of any medicine with same medicine name
            cmd = New OleDbCommand("select ID from Medicines where MedicineName = '" + medicineName + "'", conn)

            'Excute the query and load data in reader
            Dim dr As OleDbDataReader = cmd.ExecuteReader

            'If data is in reader then return Medicine Id
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

    Private Function GetAlreadyPrescriptionId(medicineID As Integer) As Integer
        Dim iRetVal As Integer = 0
        Try
            'open the connection
            conn.Open()
            'Initialize the command with query of any user prescription Id with same user and medicine Id
            cmd = New OleDbCommand("select ID from UserMedicines where UserID = " & Int32.Parse(iUserId) & " and MedicineID = " & Int32.Parse(medicineID), conn)

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

    'Save Order
    Private Sub SaveOrder()
        Dim bRetVal As Boolean = False
        For index As Integer = 0 To tbl_UserMedicines.Rows.Count - 1
            bRetVal = False
            'Get the user entered values
            Dim iMedicineID As Integer = GetMedicineId(tbl_UserMedicines.Rows(index)(0))
            Dim iQuantity As Integer = tbl_UserMedicines.Rows(index)(1)
            Dim bMorning As Boolean = tbl_UserMedicines.Rows(index)(2)
            Dim bAfternoon As Boolean = tbl_UserMedicines.Rows(index)(3)
            Dim bNight As Boolean = tbl_UserMedicines.Rows(index)(4)
            Dim iAlreadyId As Integer = GetAlreadyPrescriptionId(iMedicineID)

            Dim sQuery As String = ""
            'if user already order that medicine then query will be of update
            If iAlreadyId > 0 Then
                sQuery = "UPDATE UserMedicines SET [DozeOrdered] = [DozeOrdered] + " & Int32.Parse(iQuantity) & ", [MorningDoze]= " & Boolean.Parse(bMorning) & ", " &
                            "[AfternoonDoze]= " & Boolean.Parse(bAfternoon) & ", [EveningDoze]= " & Boolean.Parse(bNight) &
                            " WHERE ID= " & Int32.Parse(iAlreadyId)
            Else
                'Else insert query
                sQuery = "insert into UserMedicines([UserID], [MedicineID], [DozeOrdered], [MorningDoze], [AfternoonDoze], [EveningDoze]) VALUES (" & Int32.Parse(iUserId) & ", " & Int32.Parse(iMedicineID) & ", " & Int32.Parse(iQuantity) & ", " & Boolean.Parse(bMorning) & "," & Boolean.Parse(bAfternoon) & "," & Boolean.Parse(bNight) & ")"
            End If
            Try
                'open the connection
                conn.Open()
                'Initialize the command with query
                Dim cmd As OleDbCommand = New OleDbCommand(sQuery, conn)
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
        Next
        If bRetVal Then
            'If successful then show this message
            System.Windows.Forms.MessageBox.Show("Your order has been placed, it will be delivered to you in 3 working days")
            Me.Close()
        End If
    End Sub

    'Call when user click on order button
    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        'if user add atleast one medicine
        If tbl_UserMedicines.Rows.Count > 0 Then
            If MessageBox.Show("To confirm the order ?", "Are you Sure", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                'Save the order
                SaveOrder()
            End If
        End If
    End Sub
End Class