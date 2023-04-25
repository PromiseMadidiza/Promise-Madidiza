Imports System.Collections.ObjectModel
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports Mysqlx.XDevAPI
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String = "server=localhost;port=3306;user=root;password=;database=customerinformation;"
        Dim connection As New MySqlConnection(connectionString)
        Try
            connection.Open()
            Dim command As New MySqlCommand("SELECT * FROM customers", connection)
            Dim adapter As New MySqlDataAdapter(command)
            Dim data As New DataTable()
            adapter.Fill(data)
            dgvCustomers.DataSource = data
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub
    Public Sub insert()
        Try
            Dim connectionString As String = "server=localhost;port=3306;user=root;password=;database=customerinformation;"
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim command As New MySqlCommand("INSERT INTO customers (Name, Surname, ID, Address, Contact) VALUES (@Name, @Surname, @ID, @Address, @Contact)", connection)
                command.Parameters.AddWithValue("@Name", txtName.Text)
                command.Parameters.AddWithValue("@Surname", txtSurname.Text)
                command.Parameters.AddWithValue("@ID", txtID.Text)
                command.Parameters.AddWithValue("@Address", txtAddress.Text)
                command.Parameters.AddWithValue("@Contact", txtContact.Text)
                command.ExecuteNonQuery()
                MessageBox.Show("Data inserted successfully!")
            End Using
        Catch ex As Exception
            MessageBox.Show("Error inserting data: " & ex.Message)
        End Try
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Try
            Dim connectionString As String = "server=localhost;port=3306;user=root;password=;database=customerinformation;"
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim command As New MySqlCommand("INSERT INTO customers (Name, Surname, ID, Address, Contact) VALUES (@Name, @Surname, @ID, @Address, @Contact)", connection)
                command.Parameters.AddWithValue("@Name", txtName.Text)
                command.Parameters.AddWithValue("@Surname", txtSurname.Text)
                command.Parameters.AddWithValue("@ID", txtID.Text)
                command.Parameters.AddWithValue("@Address", txtAddress.Text)
                command.Parameters.AddWithValue("@Contact", txtContact.Text)
                command.ExecuteNonQuery()
                MessageBox.Show("Customer inserted successfully!")
            End Using
        Catch ex As Exception
            MessageBox.Show("Error inserting customer: " & ex.Message)
        End Try
        txtName.Text = ""
        txtSurname.Text = ""
        txtID.Text = ""
        txtAddress.Text = ""
        txtContact.Text = ""
        RefreshDataGridView()
    End Sub

    Private Sub RefreshDataGridView()
        Dim connectionString As String = "server=localhost;port=3306;user=root;password=;database=customerinformation;"
        Using connection As New MySqlConnection(connectionString)
            connection.Open()
            Dim command As New MySqlCommand("SELECT * FROM customers", connection)
            Dim adapter As New MySqlDataAdapter(command)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            dgvCustomers.DataSource = dt
        End Using
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchTerm As String = txtSearch.Text.Trim().ToLower()
        Dim connectionString As String = "server=localhost;port=3306;user=root;password=;database=customerinformation;"
        Using connection As New MySqlConnection(connectionString)
            connection.Open()
            Dim command As New MySqlCommand("SELECT * FROM customers WHERE LOWER(Name) LIKE @searchTerm OR LOWER(Surname) LIKE @searchTerm OR ID LIKE @searchTerm OR LOWER(Address) LIKE @searchTerm OR Contact LIKE @searchTerm", connection)
            command.Parameters.AddWithValue("@searchTerm", "%" & searchTerm & "%")
            Dim adapter As New MySqlDataAdapter(command)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            dgvCustomers.DataSource = dt
        End Using
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim connectionString As String = "server=localhost;port=3306;user=root;password=;database=customerinformation;"
        Using connection As New MySqlConnection(connectionString)
            connection.Open()
            Dim command As New MySqlCommand("SELECT * FROM customers", connection)
            Dim adapter As New MySqlDataAdapter(command)
            Dim dataSet As New DataSet()
            adapter.Fill(dataSet)
            Dim bindingSource As New BindingSource()
            bindingSource.DataSource = dataSet.Tables(0)
            dgvCustomers.DataSource = bindingSource
        End Using
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            Dim connectionString As String = "server=localhost;port=3306;user=root;password=;database=customerinformation;"
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim command As New MySqlCommand("UPDATE customers SET Surname = @Surname, ID = @ID, Address = @Address, Contact = @Contact WHERE Name = @Name", connection)
                command.Parameters.AddWithValue("@Surname", txtSurname.Text)
                command.Parameters.AddWithValue("@ID", txtID.Text)
                command.Parameters.AddWithValue("@Address", txtAddress.Text)
                command.Parameters.AddWithValue("@Contact", txtContact.Text)
                command.Parameters.AddWithValue("@Name", txtName.Text)
                command.ExecuteNonQuery()
                MessageBox.Show("Customer updated successfully!")
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating customer: " & ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim connectionString As String = "server=localhost;port=3306;user=root;password=;database=customerinformation;"
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim command As New MySqlCommand("DELETE FROM customers WHERE Name = @Name", connection)
                command.Parameters.AddWithValue("@Name", txtName.Text)
                Dim rowsAffected As Integer = command.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Customer deleted successfully!")
                Else
                    MessageBox.Show("No customers with that name were found.")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error deleting customer: " & ex.Message)
        End Try
    End Sub
    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click
        Sort()
    End Sub
    Private Sub Sort()
        Dim connectionString As String = "server=localhost;port=3306;user=root;password=;database=customerinformation;"
        Using connection As New MySqlConnection(connectionString)
            connection.Open()
            Dim command As New MySqlCommand("SELECT * FROM customers ORDER BY Name ASC", connection)
            Dim adapter As New MySqlDataAdapter(command)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            dgvCustomers.DataSource = dt
        End Using
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName.Text = ""
        txtSurname.Text = ""
        txtID.Text = ""
        txtAddress.Text = ""
        txtContact.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub


End Class
