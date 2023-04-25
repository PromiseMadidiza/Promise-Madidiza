<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        components = New ComponentModel.Container()
        txtName = New TextBox()
        btnSearch = New Button()
        btnDelete = New Button()
        btnInsert = New Button()
        btnDisplay = New Button()
        txtSurname = New TextBox()
        txtAddress = New TextBox()
        txtID = New TextBox()
        txtSearch = New TextBox()
        lblName = New Label()
        lblSurname = New Label()
        lblID = New Label()
        lblAddress = New Label()
        lblContact = New Label()
        dgvCustomers = New DataGridView()
        NameDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        SurnameDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        AddressDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        ContactDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        CustomerBindingSource = New BindingSource(components)
        OracleConnection1 = New Oracle.ManagedDataAccess.Client.OracleConnection()
        txtContact = New TextBox()
        btnUpdate = New Button()
        btnClear = New Button()
        btnExit = New Button()
        btnSort = New Button()
        CType(dgvCustomers, ComponentModel.ISupportInitialize).BeginInit()
        CType(CustomerBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(128, 300)
        txtName.Name = "txtName"
        txtName.Size = New Size(100, 23)
        txtName.TabIndex = 0
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(457, 328)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(75, 23)
        btnSearch.TabIndex = 2
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(248, 386)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(75, 23)
        btnDelete.TabIndex = 3
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnInsert
        ' 
        btnInsert.Location = New Point(248, 329)
        btnInsert.Name = "btnInsert"
        btnInsert.Size = New Size(75, 23)
        btnInsert.TabIndex = 4
        btnInsert.Text = "Insert"
        btnInsert.UseVisualStyleBackColor = True
        ' 
        ' btnDisplay
        ' 
        btnDisplay.Location = New Point(248, 299)
        btnDisplay.Name = "btnDisplay"
        btnDisplay.Size = New Size(75, 23)
        btnDisplay.TabIndex = 5
        btnDisplay.Text = "Display"
        btnDisplay.UseVisualStyleBackColor = True
        ' 
        ' txtSurname
        ' 
        txtSurname.Location = New Point(128, 328)
        txtSurname.Name = "txtSurname"
        txtSurname.Size = New Size(100, 23)
        txtSurname.TabIndex = 7
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(128, 387)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(100, 23)
        txtAddress.TabIndex = 8
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(128, 357)
        txtID.Name = "txtID"
        txtID.Size = New Size(100, 23)
        txtID.TabIndex = 9
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(351, 328)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(100, 23)
        txtSearch.TabIndex = 11
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(49, 303)
        lblName.Name = "lblName"
        lblName.Size = New Size(39, 15)
        lblName.TabIndex = 12
        lblName.Text = "Name"
        ' 
        ' lblSurname
        ' 
        lblSurname.AutoSize = True
        lblSurname.Location = New Point(49, 332)
        lblSurname.Name = "lblSurname"
        lblSurname.Size = New Size(54, 15)
        lblSurname.TabIndex = 13
        lblSurname.Text = "Surname"
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.Location = New Point(49, 360)
        lblID.Name = "lblID"
        lblID.Size = New Size(18, 15)
        lblID.TabIndex = 14
        lblID.Text = "ID"
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.Location = New Point(49, 390)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(49, 15)
        lblAddress.TabIndex = 15
        lblAddress.Text = "Address"
        ' 
        ' lblContact
        ' 
        lblContact.AutoSize = True
        lblContact.Location = New Point(49, 419)
        lblContact.Name = "lblContact"
        lblContact.Size = New Size(49, 15)
        lblContact.TabIndex = 16
        lblContact.Text = "Contact"
        ' 
        ' dgvCustomers
        ' 
        dgvCustomers.AutoGenerateColumns = False
        dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCustomers.Columns.AddRange(New DataGridViewColumn() {NameDataGridViewTextBoxColumn, SurnameDataGridViewTextBoxColumn, AddressDataGridViewTextBoxColumn, ContactDataGridViewTextBoxColumn})
        dgvCustomers.DataSource = CustomerBindingSource
        dgvCustomers.Location = New Point(12, 13)
        dgvCustomers.Name = "dgvCustomers"
        dgvCustomers.RowTemplate.Height = 25
        dgvCustomers.Size = New Size(446, 267)
        dgvCustomers.TabIndex = 17
        ' 
        ' NameDataGridViewTextBoxColumn
        ' 
        NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        NameDataGridViewTextBoxColumn.HeaderText = "Name"
        NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        ' 
        ' SurnameDataGridViewTextBoxColumn
        ' 
        SurnameDataGridViewTextBoxColumn.DataPropertyName = "Surname"
        SurnameDataGridViewTextBoxColumn.HeaderText = "Surname"
        SurnameDataGridViewTextBoxColumn.Name = "SurnameDataGridViewTextBoxColumn"
        ' 
        ' AddressDataGridViewTextBoxColumn
        ' 
        AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        ' 
        ' ContactDataGridViewTextBoxColumn
        ' 
        ContactDataGridViewTextBoxColumn.DataPropertyName = "Contact"
        ContactDataGridViewTextBoxColumn.HeaderText = "Contact"
        ContactDataGridViewTextBoxColumn.Name = "ContactDataGridViewTextBoxColumn"
        ' 
        ' CustomerBindingSource
        ' 
        CustomerBindingSource.DataSource = GetType(Customer)
        ' 
        ' OracleConnection1
        ' 
        OracleConnection1.ChunkMigrationConnectionTimeout = "120"
        ' 
        ' txtContact
        ' 
        txtContact.Location = New Point(128, 416)
        txtContact.Name = "txtContact"
        txtContact.Size = New Size(100, 23)
        txtContact.TabIndex = 18
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(248, 356)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(75, 23)
        btnUpdate.TabIndex = 19
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(248, 416)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 23)
        btnClear.TabIndex = 20
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(457, 411)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(75, 23)
        btnExit.TabIndex = 21
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnSort
        ' 
        btnSort.Location = New Point(457, 371)
        btnSort.Name = "btnSort"
        btnSort.Size = New Size(75, 23)
        btnSort.TabIndex = 22
        btnSort.Text = "Sort"
        btnSort.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(591, 455)
        Controls.Add(btnSort)
        Controls.Add(btnExit)
        Controls.Add(btnClear)
        Controls.Add(btnUpdate)
        Controls.Add(txtContact)
        Controls.Add(dgvCustomers)
        Controls.Add(lblContact)
        Controls.Add(lblAddress)
        Controls.Add(lblID)
        Controls.Add(lblSurname)
        Controls.Add(lblName)
        Controls.Add(txtSearch)
        Controls.Add(txtID)
        Controls.Add(txtAddress)
        Controls.Add(txtSurname)
        Controls.Add(btnDisplay)
        Controls.Add(btnInsert)
        Controls.Add(btnDelete)
        Controls.Add(btnSearch)
        Controls.Add(txtName)
        Name = "Form1"
        Text = "Form1"
        CType(dgvCustomers, ComponentModel.ISupportInitialize).EndInit()
        CType(CustomerBindingSource, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnInsert As Button
    Friend WithEvents btnDisplay As Button
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblSurname As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblContact As Label
    Friend WithEvents dgvCustomers As DataGridView
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SurnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents OracleConnection1 As Oracle.ManagedDataAccess.Client.OracleConnection
    Friend WithEvents txtContact As TextBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnSort As Button
End Class
