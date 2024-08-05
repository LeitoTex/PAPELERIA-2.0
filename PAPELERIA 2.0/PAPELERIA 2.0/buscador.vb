Imports System.Data.OleDb
Public Class Buscador
    Dim n As Integer


    Private Sub Btn_agrega_Click(sender As Object, e As EventArgs) Handles btn_agrega.Click
        ' Asegúrate de que se ha seleccionado una fila en el DataGridView
        If DataGridView1.SelectedRows.Count > 0 Then
            ' Obtén el valor de la celda seleccionada
            Dim selectedValue As String = DataGridView1.SelectedRows(0).Cells("codigo").Value.ToString()
            Dim selectedValue1 As String = DataGridView1.SelectedRows(1).Cells("detalle").Value.ToString()
            Dim selectedValue2 As String = DataGridView1.SelectedRows(2).Cells("precio").Value.ToString()

            Dim form2 As New Form1()

            ' Establece el valor en la propiedad del segundo formulario
            form2.TXT_CODIGO.Text = selectedValue
            form2.TXT_DESCRIPCION.Text = selectedValue1
            form2.TXT_PRECIO.Text = selectedValue2


            ' Muestra el segundo formulario
            form2.ShowDialog()
        Else
            MessageBox.Show("Por favor, selecciona una fila.")
        End If
    End Sub

    '  Sub ActualizarTabla(ByVal grilla As DataGridView)

    '  Dim da1 As OleDbDataAdapter 'DATAADPTER
    ' Dim dt1 As DataTable
    'Dim consulta As String 'f9

    'Try

    '       consulta = " SELECT productos.[Id], productos.[descripcion], productos.[precio venta]
    'FROM productos; "

    '           da1 = New OleDbDataAdapter(consulta, RutaDB_papeleria)
    '          dt1 = New DataTable
    '         da1.Fill(dt1)
    '        n = dt1.Rows.Count

    '       grilla.DataSource = dt1
    '      grilla.ReadOnly = True 'SOLO DE LECTURA
    'Catch ex As Exception
    '       MsgBox(ex.Message)
    'End Try

    'End Sub

    Private Sub Buscador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Actualizartabla(Me.DataGridView1, "productos", "", "id") 'tabla usuarios ordenado por apellido        ' Label9.Text = n
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
            grilla.ReadOnly = True 'SOLO DE LECTURA


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
            SQL = "Select productos.nombre_producto, productos.APELLIDO, USUARIOS.NRO_CUENTA, USUARIOS.usuario From USUARIOS
Where (((USUARIOS.nombre) Like '" & DATO & "'));"

            Dim da As New OleDbDataAdapter(SQL, RutaDB_papeleria)
            Dim dt As New DataTable
            da.Fill(dt)

            For i = 0 To dt.Rows.Count - 1
                Dim dr As DataRow
                dr = dt.Rows(i)
                'ListBox1.Items.Add(dr(0) & " - " & dr(1))
                'ListBox2.Items.Add(dr(2))
                'ListBox3.Items.Add(dr(3))

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    '  Private Sub Btn_carga_Click(sender As Object, e As EventArgs) Handles btn_carga.Click
    '     Carga_productos(DataGridView1, "Productos", "Id,descripcion,precioventa", "Id")

    ' End Sub
End Class