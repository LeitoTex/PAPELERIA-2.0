
Imports System.Data.OleDb


Public Class ESTADO_DE_CUENTA_2

    Private Sub CargarDatos(Optional ByVal fechaInicio As DateTime = Nothing, Optional ByVal fechaFin As DateTime = Nothing)
        Dim connectionString As String = "provider=microsoft.ace.oledb.12.0; data source=" & My.Application.Info.DirectoryPath & "\papeleria.accdb"
        Dim query As String = "SELECT * FROM clientes"
        'Public RutaDB_papeleria As String = "provider=microsoft.ace.oledb.12.0; data source=" & My.Application.Info.DirectoryPath & "\papeleria.accdb"

        If fechaInicio <> Nothing AndAlso fechaFin <> Nothing Then
            query &= " WHERE Fecha >= @FechaInicio AND Fecha <= @FechaFin"
        End If

        Dim connection As New OleDbConnection(connectionString)
        Dim command As New OleDbCommand(query, connection)
        If fechaInicio <> Nothing AndAlso fechaFin <> Nothing Then
            command.Parameters.AddWithValue("@FechaInicio", fechaInicio)
            command.Parameters.AddWithValue("@FechaFin", fechaFin)
        End If

        Dim adapter As New OleDbDataAdapter(Command)
        Dim table As New DataTable()

        Try
            connection.Open()
            adapter.Fill(table)
            DataGridView1.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub btnAplicarFiltro_Click(sender As Object, e As EventArgs) Handles btnAplicarFiltro.Click
        Dim fechaInicio As DateTime = DateTimePickerInicio.Value
        Dim fechaFin As DateTime = DateTimePickerFin.Value
        CargarDatos(fechaInicio, fechaFin)
    End Sub

    Private Sub ESTADO_DE_CUENTA_2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatos()

    End Sub
End Class
