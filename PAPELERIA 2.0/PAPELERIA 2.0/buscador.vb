Imports System.Data.OleDb
Public Class Buscador

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedValue As String = DataGridView1.SelectedRows(0).Cells("ID").Value.ToString()
            Dim selectedValue1 As String = DataGridView1.SelectedRows(0).Cells("descripcion").Value.ToString()
            Dim selectedValue2 As String = DataGridView1.SelectedRows(0).Cells("precio venta").Value.ToString()
            CONTADOS.RecibirDatos(selectedValue, selectedValue1, selectedValue2)
            Creditos.RecibirDatos(selectedValue, selectedValue1, selectedValue2)
        End If
    End Sub

    Private Sub Buscador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Actualizartabla(Me.DataGridView1, "productos", "", "id")
    End Sub

    Sub Actualizartabla(ByVal grilla As DataGridView,
                ByVal nombre_tabla As String,
               ByVal campoSql As String,
              ByVal C_ORDEN As String)
        Try
            Dim da As OleDbDataAdapter
            Dim dt As DataTable
            Dim consulta As String
            consulta = "Select "
            If campoSql = "" Then
                consulta += "*"
            Else
                consulta += campoSql
            End If
            consulta += " From " & nombre_tabla & " ORDER BY " & C_ORDEN
            da = New OleDbDataAdapter(consulta, RutaDB_papeleria)
            dt = New DataTable
            da.Fill(dt)
            grilla.DataSource = dt
            grilla.ReadOnly = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            Dim SQL As String
            Dim DATO As String

            DATO = TextBox1.Text & "%"
            '                   0                  1
            '            SQL = "Select productos.nombre producto From productos
            'Where (((productos.nombre producto) Like '" & DATO & "'));"
            SQL = "SELECT [productos].[DESCRIPCION] AS producto FROM [productos] WHERE [productos].[DESCRIPCION] LIKE '" & DATO & "';"

            Dim da As New OleDbDataAdapter(SQL, RutaDB_papeleria)
            Dim dt As New DataTable
            da.Fill(dt)

            For i = 0 To dt.Rows.Count - 1
                Dim dr As DataRow
                dr = dt.Rows(i)
                DataGridView1.DataSource = dt
                'ListBox1.Items.Add(dr(0) & " - " & dr(1))
                'ListBox2.Items.Add(dr(2))
                'ListBox3.Items.Add(dr(3))

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btn_agrega_Click(sender As Object, e As EventArgs) Handles btn_agrega.Click
        Me.Close()
    End Sub
End Class