<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrderPrescription
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrderPrescription))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbNight = New System.Windows.Forms.CheckBox()
        Me.cbAfternoon = New System.Windows.Forms.CheckBox()
        Me.cbMorning = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbMedicine = New System.Windows.Forms.ComboBox()
        Me.dgvOderPrescription = New System.Windows.Forms.DataGridView()
        Me.MedicineDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MorningDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.AfternoonDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.NightDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataSet1 = New System.Data.DataSet()
        Me.tbl_UserMedicines = New System.Data.DataTable()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.DataColumn4 = New System.Data.DataColumn()
        Me.DataColumn5 = New System.Data.DataColumn()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvOderPrescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbl_UserMedicines, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtQty)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cbMedicine)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(465, 127)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Medicine"
        '
        'btnAdd
        '
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(183, 86)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 35)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Add"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbNight)
        Me.GroupBox2.Controls.Add(Me.cbAfternoon)
        Me.GroupBox2.Controls.Add(Me.cbMorning)
        Me.GroupBox2.Location = New System.Drawing.Point(284, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(171, 102)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Daily Doze"
        '
        'cbNight
        '
        Me.cbNight.AutoSize = True
        Me.cbNight.Location = New System.Drawing.Point(16, 67)
        Me.cbNight.Name = "cbNight"
        Me.cbNight.Size = New System.Drawing.Size(60, 22)
        Me.cbNight.TabIndex = 2
        Me.cbNight.Text = "Night"
        Me.cbNight.UseVisualStyleBackColor = True
        '
        'cbAfternoon
        '
        Me.cbAfternoon.AutoSize = True
        Me.cbAfternoon.Location = New System.Drawing.Point(16, 43)
        Me.cbAfternoon.Name = "cbAfternoon"
        Me.cbAfternoon.Size = New System.Drawing.Size(91, 22)
        Me.cbAfternoon.TabIndex = 1
        Me.cbAfternoon.Text = "Afternoon"
        Me.cbAfternoon.UseVisualStyleBackColor = True
        '
        'cbMorning
        '
        Me.cbMorning.AutoSize = True
        Me.cbMorning.Location = New System.Drawing.Point(16, 20)
        Me.cbMorning.Name = "cbMorning"
        Me.cbMorning.Size = New System.Drawing.Size(78, 22)
        Me.cbMorning.TabIndex = 0
        Me.cbMorning.Text = "Morning"
        Me.cbMorning.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Doze Quantity Ordered"
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(177, 53)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(81, 26)
        Me.txtQty.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Medicine"
        '
        'cbMedicine
        '
        Me.cbMedicine.FormattingEnabled = True
        Me.cbMedicine.Location = New System.Drawing.Point(81, 21)
        Me.cbMedicine.Name = "cbMedicine"
        Me.cbMedicine.Size = New System.Drawing.Size(177, 26)
        Me.cbMedicine.TabIndex = 0
        '
        'dgvOderPrescription
        '
        Me.dgvOderPrescription.AllowUserToAddRows = False
        Me.dgvOderPrescription.AllowUserToDeleteRows = False
        Me.dgvOderPrescription.AllowUserToResizeColumns = False
        Me.dgvOderPrescription.AllowUserToResizeRows = False
        Me.dgvOderPrescription.AutoGenerateColumns = False
        Me.dgvOderPrescription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOderPrescription.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MedicineDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.MorningDataGridViewCheckBoxColumn, Me.AfternoonDataGridViewCheckBoxColumn, Me.NightDataGridViewCheckBoxColumn})
        Me.dgvOderPrescription.DataMember = "tbl_UserMedicines"
        Me.dgvOderPrescription.DataSource = Me.DataSet1
        Me.dgvOderPrescription.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvOderPrescription.Location = New System.Drawing.Point(12, 145)
        Me.dgvOderPrescription.MultiSelect = False
        Me.dgvOderPrescription.Name = "dgvOderPrescription"
        Me.dgvOderPrescription.Size = New System.Drawing.Size(465, 205)
        Me.dgvOderPrescription.TabIndex = 1
        '
        'MedicineDataGridViewTextBoxColumn
        '
        Me.MedicineDataGridViewTextBoxColumn.DataPropertyName = "Medicine"
        Me.MedicineDataGridViewTextBoxColumn.HeaderText = "Medicine"
        Me.MedicineDataGridViewTextBoxColumn.Name = "MedicineDataGridViewTextBoxColumn"
        Me.MedicineDataGridViewTextBoxColumn.ReadOnly = True
        Me.MedicineDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MedicineDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.MedicineDataGridViewTextBoxColumn.Width = 160
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Qty"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        Me.QuantityDataGridViewTextBoxColumn.ReadOnly = True
        Me.QuantityDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.QuantityDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.QuantityDataGridViewTextBoxColumn.Width = 40
        '
        'MorningDataGridViewCheckBoxColumn
        '
        Me.MorningDataGridViewCheckBoxColumn.DataPropertyName = "Morning"
        Me.MorningDataGridViewCheckBoxColumn.HeaderText = "Morning"
        Me.MorningDataGridViewCheckBoxColumn.Name = "MorningDataGridViewCheckBoxColumn"
        Me.MorningDataGridViewCheckBoxColumn.ReadOnly = True
        Me.MorningDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MorningDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.MorningDataGridViewCheckBoxColumn.Width = 70
        '
        'AfternoonDataGridViewCheckBoxColumn
        '
        Me.AfternoonDataGridViewCheckBoxColumn.DataPropertyName = "Afternoon"
        Me.AfternoonDataGridViewCheckBoxColumn.HeaderText = "Afternoon"
        Me.AfternoonDataGridViewCheckBoxColumn.Name = "AfternoonDataGridViewCheckBoxColumn"
        Me.AfternoonDataGridViewCheckBoxColumn.ReadOnly = True
        Me.AfternoonDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.AfternoonDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.AfternoonDataGridViewCheckBoxColumn.Width = 70
        '
        'NightDataGridViewCheckBoxColumn
        '
        Me.NightDataGridViewCheckBoxColumn.DataPropertyName = "Night"
        Me.NightDataGridViewCheckBoxColumn.HeaderText = "Night"
        Me.NightDataGridViewCheckBoxColumn.Name = "NightDataGridViewCheckBoxColumn"
        Me.NightDataGridViewCheckBoxColumn.ReadOnly = True
        Me.NightDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.NightDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.NightDataGridViewCheckBoxColumn.Width = 60
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.tbl_UserMedicines})
        '
        'tbl_UserMedicines
        '
        Me.tbl_UserMedicines.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5})
        Me.tbl_UserMedicines.TableName = "tbl_UserMedicines"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "Medicine"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "Quantity"
        Me.DataColumn2.DataType = GetType(Integer)
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "Morning"
        Me.DataColumn3.DataType = GetType(Boolean)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "Afternoon"
        Me.DataColumn4.DataType = GetType(Boolean)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "Night"
        Me.DataColumn5.DataType = GetType(Boolean)
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'btnOrder
        '
        Me.btnOrder.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrder.Image = CType(resources.GetObject("btnOrder.Image"), System.Drawing.Image)
        Me.btnOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOrder.Location = New System.Drawing.Point(384, 356)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(83, 38)
        Me.btnOrder.TabIndex = 6
        Me.btnOrder.Text = "Order"
        Me.btnOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'frmOrderPrescription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(488, 399)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.dgvOderPrescription)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOrderPrescription"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Order Prescription"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvOderPrescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbl_UserMedicines, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbMedicine As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtQty As NumericUpDown
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbMorning As CheckBox
    Friend WithEvents cbNight As CheckBox
    Friend WithEvents cbAfternoon As CheckBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents dgvOderPrescription As DataGridView
    Friend WithEvents DataSet1 As DataSet
    Friend WithEvents tbl_UserMedicines As DataTable
    Friend WithEvents DataColumn1 As DataColumn
    Friend WithEvents DataColumn2 As DataColumn
    Friend WithEvents DataColumn3 As DataColumn
    Friend WithEvents DataColumn4 As DataColumn
    Friend WithEvents DataColumn5 As DataColumn
    Friend WithEvents MedicineDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MorningDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents AfternoonDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents NightDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents btnOrder As Button
End Class
