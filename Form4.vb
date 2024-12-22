Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class Form4
    ' Connection string for XAMPP MySQL
    Private connectionString As String = "Server=localhost;Database=burgeru_db;User Id=root;Password=;"

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadInventory()
    End Sub

    Private Sub LoadInventory()
        Dim query As String = "SELECT product_name AS 'Food', stock_quantity AS 'Stocks' FROM inventory"
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Using cmd As New MySqlCommand(query, connection)
                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim dataTable As New DataTable()
                        adapter.Fill(dataTable)
                        dgvInventory.DataSource = dataTable
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading inventory: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class



