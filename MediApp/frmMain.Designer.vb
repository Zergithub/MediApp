<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvMedicalConditions = New System.Windows.Forms.DataGridView()
        Me.MedicalConditionsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataSet1 = New System.Data.DataSet()
        Me.tbl_MedicalConditions = New System.Data.DataTable()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.tbl_Reminder = New System.Data.DataTable()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.DataColumn4 = New System.Data.DataColumn()
        Me.tbl_Appointments = New System.Data.DataTable()
        Me.DataColumn5 = New System.Data.DataColumn()
        Me.DataColumn6 = New System.Data.DataColumn()
        Me.tbl_PrescriptionOrders = New System.Data.DataTable()
        Me.DataColumn7 = New System.Data.DataColumn()
        Me.DataColumn8 = New System.Data.DataColumn()
        Me.btnAddMedicalCondition = New System.Windows.Forms.Button()
        Me.cbMedicalConditions = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnCreateReminder = New System.Windows.Forms.Button()
        Me.dgvReminder = New System.Windows.Forms.DataGridView()
        Me.ReminderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OccuredDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnCreateAppointment = New System.Windows.Forms.Button()
        Me.dgvAppointment = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnOrderPrescription = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MedicineDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.PersonalDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.UsernameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FirstnameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LastnameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmailMedihelpgmailcomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Phone08045769102ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ToolStripPictureButton = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvMedicalConditions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbl_MedicalConditions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbl_Reminder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbl_Appointments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbl_PrescriptionOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvReminder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvAppointment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvMedicalConditions)
        Me.GroupBox1.Controls.Add(Me.btnAddMedicalCondition)
        Me.GroupBox1.Controls.Add(Me.cbMedicalConditions)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(618, 165)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Medical Condition"
        '
        'dgvMedicalConditions
        '
        Me.dgvMedicalConditions.AllowUserToAddRows = False
        Me.dgvMedicalConditions.AllowUserToDeleteRows = False
        Me.dgvMedicalConditions.AllowUserToResizeColumns = False
        Me.dgvMedicalConditions.AllowUserToResizeRows = False
        Me.dgvMedicalConditions.AutoGenerateColumns = False
        Me.dgvMedicalConditions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMedicalConditions.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MedicalConditionsDataGridViewTextBoxColumn})
        Me.dgvMedicalConditions.DataMember = "tbl_MedicalConditions"
        Me.dgvMedicalConditions.DataSource = Me.DataSet1
        Me.dgvMedicalConditions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvMedicalConditions.Location = New System.Drawing.Point(6, 25)
        Me.dgvMedicalConditions.MultiSelect = False
        Me.dgvMedicalConditions.Name = "dgvMedicalConditions"
        Me.dgvMedicalConditions.Size = New System.Drawing.Size(317, 134)
        Me.dgvMedicalConditions.TabIndex = 2
        '
        'MedicalConditionsDataGridViewTextBoxColumn
        '
        Me.MedicalConditionsDataGridViewTextBoxColumn.DataPropertyName = "MedicalConditions"
        Me.MedicalConditionsDataGridViewTextBoxColumn.HeaderText = "Medical Condition"
        Me.MedicalConditionsDataGridViewTextBoxColumn.Name = "MedicalConditionsDataGridViewTextBoxColumn"
        Me.MedicalConditionsDataGridViewTextBoxColumn.ReadOnly = True
        Me.MedicalConditionsDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MedicalConditionsDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.MedicalConditionsDataGridViewTextBoxColumn.Width = 250
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.tbl_MedicalConditions, Me.tbl_Reminder, Me.tbl_Appointments, Me.tbl_PrescriptionOrders})
        '
        'tbl_MedicalConditions
        '
        Me.tbl_MedicalConditions.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1})
        Me.tbl_MedicalConditions.TableName = "tbl_MedicalConditions"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "MedicalConditions"
        '
        'tbl_Reminder
        '
        Me.tbl_Reminder.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn2, Me.DataColumn3, Me.DataColumn4})
        Me.tbl_Reminder.TableName = "tbl_Reminder"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "Reminder"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "DateTime"
        Me.DataColumn3.DataType = GetType(Date)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "Occured"
        Me.DataColumn4.DataType = GetType(Boolean)
        '
        'tbl_Appointments
        '
        Me.tbl_Appointments.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn5, Me.DataColumn6})
        Me.tbl_Appointments.TableName = "tbl_Appointments"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "DateTime"
        Me.DataColumn5.DataType = GetType(Date)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "Occured"
        Me.DataColumn6.DataType = GetType(Boolean)
        '
        'tbl_PrescriptionOrders
        '
        Me.tbl_PrescriptionOrders.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn7, Me.DataColumn8})
        Me.tbl_PrescriptionOrders.TableName = "tbl_PrescriptionOrders"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "Medicine"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "Quantity"
        Me.DataColumn8.DataType = GetType(Integer)
        '
        'btnAddMedicalCondition
        '
        Me.btnAddMedicalCondition.Image = CType(resources.GetObject("btnAddMedicalCondition.Image"), System.Drawing.Image)
        Me.btnAddMedicalCondition.Location = New System.Drawing.Point(558, 46)
        Me.btnAddMedicalCondition.Name = "btnAddMedicalCondition"
        Me.btnAddMedicalCondition.Size = New System.Drawing.Size(37, 41)
        Me.btnAddMedicalCondition.TabIndex = 1
        Me.btnAddMedicalCondition.UseVisualStyleBackColor = True
        '
        'cbMedicalConditions
        '
        Me.cbMedicalConditions.FormattingEnabled = True
        Me.cbMedicalConditions.Location = New System.Drawing.Point(342, 54)
        Me.cbMedicalConditions.Name = "cbMedicalConditions"
        Me.cbMedicalConditions.Size = New System.Drawing.Size(202, 26)
        Me.cbMedicalConditions.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnCreateReminder)
        Me.GroupBox2.Controls.Add(Me.dgvReminder)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 222)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(524, 311)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Reminders"
        '
        'btnCreateReminder
        '
        Me.btnCreateReminder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCreateReminder.Image = CType(resources.GetObject("btnCreateReminder.Image"), System.Drawing.Image)
        Me.btnCreateReminder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCreateReminder.Location = New System.Drawing.Point(403, 15)
        Me.btnCreateReminder.Name = "btnCreateReminder"
        Me.btnCreateReminder.Size = New System.Drawing.Size(94, 41)
        Me.btnCreateReminder.TabIndex = 1
        Me.btnCreateReminder.Text = "Create"
        Me.btnCreateReminder.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCreateReminder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCreateReminder.UseVisualStyleBackColor = True
        '
        'dgvReminder
        '
        Me.dgvReminder.AllowUserToAddRows = False
        Me.dgvReminder.AllowUserToDeleteRows = False
        Me.dgvReminder.AllowUserToResizeColumns = False
        Me.dgvReminder.AllowUserToResizeRows = False
        Me.dgvReminder.AutoGenerateColumns = False
        Me.dgvReminder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReminder.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ReminderDataGridViewTextBoxColumn, Me.DateTimeDataGridViewTextBoxColumn, Me.OccuredDataGridViewCheckBoxColumn})
        Me.dgvReminder.DataMember = "tbl_Reminder"
        Me.dgvReminder.DataSource = Me.DataSet1
        Me.dgvReminder.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvReminder.Location = New System.Drawing.Point(7, 62)
        Me.dgvReminder.MultiSelect = False
        Me.dgvReminder.Name = "dgvReminder"
        Me.dgvReminder.Size = New System.Drawing.Size(511, 243)
        Me.dgvReminder.TabIndex = 0
        '
        'ReminderDataGridViewTextBoxColumn
        '
        Me.ReminderDataGridViewTextBoxColumn.DataPropertyName = "Reminder"
        Me.ReminderDataGridViewTextBoxColumn.HeaderText = "Reminder"
        Me.ReminderDataGridViewTextBoxColumn.Name = "ReminderDataGridViewTextBoxColumn"
        Me.ReminderDataGridViewTextBoxColumn.ReadOnly = True
        Me.ReminderDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ReminderDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.ReminderDataGridViewTextBoxColumn.Width = 220
        '
        'DateTimeDataGridViewTextBoxColumn
        '
        Me.DateTimeDataGridViewTextBoxColumn.DataPropertyName = "DateTime"
        Me.DateTimeDataGridViewTextBoxColumn.HeaderText = "DateTime"
        Me.DateTimeDataGridViewTextBoxColumn.Name = "DateTimeDataGridViewTextBoxColumn"
        Me.DateTimeDataGridViewTextBoxColumn.ReadOnly = True
        Me.DateTimeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DateTimeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.DateTimeDataGridViewTextBoxColumn.Width = 150
        '
        'OccuredDataGridViewCheckBoxColumn
        '
        Me.OccuredDataGridViewCheckBoxColumn.DataPropertyName = "Occured"
        Me.OccuredDataGridViewCheckBoxColumn.HeaderText = "Occured"
        Me.OccuredDataGridViewCheckBoxColumn.Name = "OccuredDataGridViewCheckBoxColumn"
        Me.OccuredDataGridViewCheckBoxColumn.ReadOnly = True
        Me.OccuredDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.OccuredDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.OccuredDataGridViewCheckBoxColumn.Width = 70
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnCreateAppointment)
        Me.GroupBox3.Controls.Add(Me.dgvAppointment)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(850, 222)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(302, 311)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Appointments"
        '
        'btnCreateAppointment
        '
        Me.btnCreateAppointment.Image = CType(resources.GetObject("btnCreateAppointment.Image"), System.Drawing.Image)
        Me.btnCreateAppointment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCreateAppointment.Location = New System.Drawing.Point(193, 15)
        Me.btnCreateAppointment.Name = "btnCreateAppointment"
        Me.btnCreateAppointment.Size = New System.Drawing.Size(93, 41)
        Me.btnCreateAppointment.TabIndex = 1
        Me.btnCreateAppointment.Text = "Book"
        Me.btnCreateAppointment.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCreateAppointment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCreateAppointment.UseVisualStyleBackColor = True
        '
        'dgvAppointment
        '
        Me.dgvAppointment.AllowUserToAddRows = False
        Me.dgvAppointment.AllowUserToDeleteRows = False
        Me.dgvAppointment.AllowUserToResizeColumns = False
        Me.dgvAppointment.AllowUserToResizeRows = False
        Me.dgvAppointment.AutoGenerateColumns = False
        Me.dgvAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAppointment.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewCheckBoxColumn1})
        Me.dgvAppointment.DataMember = "tbl_Appointments"
        Me.dgvAppointment.DataSource = Me.DataSet1
        Me.dgvAppointment.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvAppointment.Location = New System.Drawing.Point(9, 62)
        Me.dgvAppointment.MultiSelect = False
        Me.dgvAppointment.Name = "dgvAppointment"
        Me.dgvAppointment.Size = New System.Drawing.Size(286, 243)
        Me.dgvAppointment.TabIndex = 0
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "DateTime"
        Me.DataGridViewTextBoxColumn2.HeaderText = "DateTime"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Occured"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Occured"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewCheckBoxColumn1.Width = 70
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnOrderPrescription)
        Me.GroupBox4.Controls.Add(Me.DataGridView1)
        Me.GroupBox4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(542, 222)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(302, 311)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Prescription"
        '
        'btnOrderPrescription
        '
        Me.btnOrderPrescription.Image = CType(resources.GetObject("btnOrderPrescription.Image"), System.Drawing.Image)
        Me.btnOrderPrescription.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOrderPrescription.Location = New System.Drawing.Point(205, 15)
        Me.btnOrderPrescription.Name = "btnOrderPrescription"
        Me.btnOrderPrescription.Size = New System.Drawing.Size(88, 41)
        Me.btnOrderPrescription.TabIndex = 1
        Me.btnOrderPrescription.Text = "Order"
        Me.btnOrderPrescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnOrderPrescription.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOrderPrescription.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MedicineDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn})
        Me.DataGridView1.DataMember = "tbl_PrescriptionOrders"
        Me.DataGridView1.DataSource = Me.DataSet1
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(7, 62)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(286, 243)
        Me.DataGridView1.TabIndex = 0
        '
        'MedicineDataGridViewTextBoxColumn
        '
        Me.MedicineDataGridViewTextBoxColumn.DataPropertyName = "Medicine"
        Me.MedicineDataGridViewTextBoxColumn.HeaderText = "Medicine"
        Me.MedicineDataGridViewTextBoxColumn.Name = "MedicineDataGridViewTextBoxColumn"
        Me.MedicineDataGridViewTextBoxColumn.ReadOnly = True
        Me.MedicineDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MedicineDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.MedicineDataGridViewTextBoxColumn.Width = 180
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Qty"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        Me.QuantityDataGridViewTextBoxColumn.Width = 40
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(1000, 143)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 57)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Google Maps"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1, Me.ToolStripPictureButton})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1157, 47)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PersonalDetailsToolStripMenuItem, Me.ContactsToolStripMenuItem, Me.AboutToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(29, 44)
        Me.ToolStripDropDownButton1.Text = "ToolStripDropDownButton1"
        '
        'PersonalDetailsToolStripMenuItem
        '
        Me.PersonalDetailsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsersToolStripMenuItem, Me.ToolStripSeparator1, Me.UsernameToolStripMenuItem, Me.FirstnameToolStripMenuItem, Me.LastnameToolStripMenuItem})
        Me.PersonalDetailsToolStripMenuItem.Name = "PersonalDetailsToolStripMenuItem"
        Me.PersonalDetailsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PersonalDetailsToolStripMenuItem.Text = "Personal Details"
        '
        'UsersToolStripMenuItem
        '
        Me.UsersToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem"
        Me.UsersToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.UsersToolStripMenuItem.Text = "User's"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(123, 6)
        '
        'UsernameToolStripMenuItem
        '
        Me.UsernameToolStripMenuItem.Name = "UsernameToolStripMenuItem"
        Me.UsernameToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.UsernameToolStripMenuItem.Text = "username"
        '
        'FirstnameToolStripMenuItem
        '
        Me.FirstnameToolStripMenuItem.Name = "FirstnameToolStripMenuItem"
        Me.FirstnameToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.FirstnameToolStripMenuItem.Text = "firstname"
        '
        'LastnameToolStripMenuItem
        '
        Me.LastnameToolStripMenuItem.Name = "LastnameToolStripMenuItem"
        Me.LastnameToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.LastnameToolStripMenuItem.Text = "lastname"
        '
        'ContactsToolStripMenuItem
        '
        Me.ContactsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmailMedihelpgmailcomToolStripMenuItem, Me.Phone08045769102ToolStripMenuItem})
        Me.ContactsToolStripMenuItem.Name = "ContactsToolStripMenuItem"
        Me.ContactsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ContactsToolStripMenuItem.Text = "Contacts"
        '
        'EmailMedihelpgmailcomToolStripMenuItem
        '
        Me.EmailMedihelpgmailcomToolStripMenuItem.Name = "EmailMedihelpgmailcomToolStripMenuItem"
        Me.EmailMedihelpgmailcomToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.EmailMedihelpgmailcomToolStripMenuItem.Text = "Email : Medihelp@gmail.com"
        '
        'Phone08045769102ToolStripMenuItem
        '
        Me.Phone08045769102ToolStripMenuItem.Name = "Phone08045769102ToolStripMenuItem"
        Me.Phone08045769102ToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.Phone08045769102ToolStripMenuItem.Text = "Phone : 080 4576 9102"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'Timer1
        '
        Me.Timer1.Interval = 60000
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'ToolStripPictureButton
        '
        Me.ToolStripPictureButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripPictureButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripPictureButton.Image = CType(resources.GetObject("ToolStripPictureButton.Image"), System.Drawing.Image)
        Me.ToolStripPictureButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripPictureButton.Name = "ToolStripPictureButton"
        Me.ToolStripPictureButton.Size = New System.Drawing.Size(23, 44)
        Me.ToolStripPictureButton.Text = "ToolStripButton1"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1157, 537)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Medi App"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvMedicalConditions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbl_MedicalConditions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbl_Reminder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbl_Appointments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbl_PrescriptionOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvReminder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvAppointment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbMedicalConditions As ComboBox
    Friend WithEvents btnAddMedicalCondition As Button
    Friend WithEvents DataSet1 As DataSet
    Friend WithEvents dgvMedicalConditions As DataGridView
    Friend WithEvents tbl_MedicalConditions As DataTable
    Friend WithEvents DataColumn1 As DataColumn
    Friend WithEvents MedicalConditionsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvReminder As DataGridView
    Friend WithEvents tbl_Reminder As DataTable
    Friend WithEvents DataColumn2 As DataColumn
    Friend WithEvents DataColumn3 As DataColumn
    Friend WithEvents DataColumn4 As DataColumn
    Friend WithEvents btnCreateReminder As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ReminderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OccuredDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents tbl_Appointments As DataTable
    Friend WithEvents DataColumn5 As DataColumn
    Friend WithEvents DataColumn6 As DataColumn
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnCreateAppointment As Button
    Friend WithEvents dgvAppointment As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnOrderPrescription As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents tbl_PrescriptionOrders As DataTable
    Friend WithEvents DataColumn7 As DataColumn
    Friend WithEvents DataColumn8 As DataColumn
    Friend WithEvents MedicineDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents PersonalDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContactsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsernameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FirstnameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LastnameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents EmailMedihelpgmailcomToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Phone08045769102ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripPictureButton As ToolStripButton
End Class
