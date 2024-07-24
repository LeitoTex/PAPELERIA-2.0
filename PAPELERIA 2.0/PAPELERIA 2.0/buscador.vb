Imports System.Data.OleDb
Public Class buscador
    Sub Carga_productos(ByVal grilla As DataGridView,
                 ByVal nombre_tabla As String,
                 ByVal campoSql As String,
                 ByVal C_ORDEN As String)
        Try
            Dim da As OleDbDataAdapter 'DATAADPTER
            Dim dt As DataTable
            Dim consulta As String 'f9
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
            grilla.ReadOnly = True 'SOLO DE LECTURA


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Carga_productos(DataGridView1, "NOMBRE", "DOMICILIO", "RUT")

    End Sub


    Private Sub Buscador_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class