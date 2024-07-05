Imports System.Data.OleDb


Public Class buscador

    Sub Carga_datos()
        Dim SQL As String
        '                         0                   1
        SQL = "SELECT clientes.nombre, clientes.domicilio FROM clientes order by clientes.nombre"

        Dim da As New OleDbDataAdapter(SQL, RutaDB_papeleria)
        Dim dt As New DataTable

        da.Fill(dt)

        ListBox1.Items.Clear()

        For i = 0 To dt.Rows.Count - 1
            Dim dr As DataRow
            dr = dt.Rows(i)
            ListBox1.Items.Add(dr(0) & " - " & dr(1))
        Next

        'CONTINENTE = "africa"

        'Carga_paises(CONTINENTE)
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim SQL As String
        Dim DATO As String

        DATO = TextBox1.Text & "%"  '%comodin
        '                   0                  1
        SQL = "Select clientes.nombre, Clientes.domicilio " _
        + "FROM Clientes " _
        + "WHERE Clientes.nombre Like '" & DATO & "' " _
        + "ORDER BY Clientes.nombre;"

        Dim da As New OleDbDataAdapter(SQL, RutaDB_papeleria)
        Dim dt As New DataTable
        da.Fill(dt)
        ListBox1.Items.Clear()
        For i = 0 To dt.Rows.Count - 1
            Dim dr As DataRow
            dr = dt.Rows(i)
            ListBox1.Items.Add(UCase(dr(0)) & " - " & dr(1))
            'ucase()   Mayusculas...
        Next

    End Sub

    Private Sub Buscador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carga_datos()

    End Sub
End Class