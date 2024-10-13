Imports System.Data.OleDb

Public Class BUSCADOR_CLIENTES
    Public Property FormularioReceptor As String

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            If DataGridView1.SelectedRows.Count > 0 Then
                Dim selectedValue As String = If(DataGridView1.SelectedRows(0).Cells("ID").Value?.ToString(), String.Empty)
                Dim selectedValue1 As String = If(DataGridView1.SelectedRows(0).Cells("NOMBRE").Value?.ToString(), String.Empty)
                Dim selectedValue2 As String = If(DataGridView1.SelectedRows(0).Cells("DOMICILIO").Value?.ToString(), String.Empty)
                Dim selectedValue3 As String = If(DataGridView1.SelectedRows(0).Cells("RUT").Value?.ToString(), String.Empty)
                'If DataGridView1.SelectedRows.Count > 0 Then
                '    Dim selectedValue As String = DataGridView1.SelectedRows(0).Cells("ID").Value.ToString()
                '    Dim selectedValue1 As String = DataGridView1.SelectedRows(0).Cells("NOMBRE").Value.ToString()
                '    Dim selectedValue2 As String = DataGridView1.SelectedRows(0).Cells("DOMICILIO").Value.ToString()
                '    Dim selectedValue3 As String = DataGridView1.SelectedRows(0).Cells("RUT").Value.ToString()

                ' Lógica condicional para enviar los datos al formulario correspondiente
                Select Case FormularioReceptor
                    Case "CONTADOS"
                        CONTADOS.recibirdatos1(selectedValue, selectedValue1, selectedValue2, selectedValue3)
                    Case "CREDITOS"
                        Creditos.RecibirDatos2(selectedValue, selectedValue1, selectedValue2, selectedValue3)
                    Case "DEVOLUCION"
                        DEVOLUCION.RecibirDatos3(selectedValue, selectedValue1, selectedValue2, selectedValue3)
                    Case "NOTA_DE_CREDITO"
                        NOTA_DE_CREDITO.RecibirDatos4(selectedValue, selectedValue1, selectedValue2, selectedValue3)
                End Select
            End If
        Catch ex As Exception
            MessageBox.Show("Error al transferir los datos: " & ex.Message)
        End Try

    End Sub

    '    CONTADOS.RecibirDatos1(selectedValue, selectedValue1, selectedValue2, selectedValue3)
    '    Creditos.RecibirDatos2(selectedValue, selectedValue1, selectedValue2, selectedValue3)
    '    DEVOLUCION.RecibirDatos3(selectedValue, selectedValue1, selectedValue2, selectedValue3)
    '    NOTA_DE_CREDITO.RecibirDatos4(selectedValue, selectedValue1, selectedValue2, selectedValue3)
    'End If



    Private Sub Buscador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Actualizartabla(Me.DataGridView1, "CLIENTES", "", "id")
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
            SQL = "Select CLIENTES.nombre From CLIENTES
Where (((CLIENTES.nombre) Like '" & DATO & "'));"

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
    Private Sub btn_agrega_Click(sender As Object, e As EventArgs) Handles btn_agrega.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DataGridView1.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            'ENVIAR ESA PULSACIÓN
            SendKeys.Send("{enter}")
        End If

    End Sub
End Class