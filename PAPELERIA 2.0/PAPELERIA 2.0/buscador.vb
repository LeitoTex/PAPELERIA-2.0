Imports System.Data.OleDb
Public Class Buscador

    Private Sub Btn_agrega_Click(sender As Object, e As EventArgs) Handles btn_agrega.Click
        ' Asegúrate de que se ha seleccionado una fila en el DataGridView
        If DataGridView1.SelectedRows.Count > 0 Then
            ' Obtén el valor de la celda seleccionada
            Dim selectedValue As String = DataGridView1.SelectedRows(0).Cells("codigo").Value.ToString()

            ' Crea una instancia de Form2
            Dim form2 As New Form1()

            ' Establece el valor en la propiedad del segundo formulario
            form2.TXT_CODIGO.Text = selectedValue

            ' Muestra el segundo formulario
            form2.ShowDialog()
        Else
            MessageBox.Show("Por favor, selecciona una fila.")
        End If
    End Sub
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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_agrega.Click
        Carga_productos(DataGridView1, "NOMBRE", "DOMICILIO", "RUT")

    End Sub


    Private Sub Buscador_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class