Imports System.Data.OleDb

Public Class REGISTRAR_CLIENTES

    Dim obj_clientes As New Cls_clientes
    Dim n As Integer
    Dim ini As Integer
    Dim f As Integer
    Dim id As Integer
    Private txtUsuario As Object

    Sub ModoModificacion()
        BTN_AGREGAR.Enabled = False
        BTN_ELIMINAR.Enabled = False
        BTN_MODIFICAR.Enabled = True
        BTN_CANCELAR.Enabled = True
    End Sub

    Sub LimpiarCampos()
        TXT_NOMBRE.Text = ""
        TXT_domicilio.Text = ""
        txt_RUT.Text = ""
        TXT_NOMBRE.Focus()
    End Sub

    Sub ModoInsercion()
        BTN_CANCELAR.Enabled = True
        BTN_NUEVO.Enabled = True
        BTN_ELIMINAR.Enabled = False
        BTN_MODIFICAR.Enabled = True
        BTN_AGREGAR.Enabled = True
    End Sub

    Function ValidarDatos() As Boolean

        If TXT_NOMBRE.Text.Trim = "" Then
            MsgBox("error en el nombre...")
            TXT_NOMBRE.Focus()
            Return False
            Exit Function
        End If

        If TXT_domicilio.Text.Trim = "" Then
            MsgBox("error en el apellido...")
            TXT_domicilio.Focus()
            Return False
            Exit Function
        End If

        If txt_RUT.Text.Trim = "" Then
            MsgBox("error en el usuario...")
            txtUsuario.Focus()
            Return False
            Exit Function
        End If

        Return True
    End Function

    Function ObtenerCampo(ByVal grilla As DataGridView, ByVal indice_columna As Byte)
        Try
            If Not IsDBNull(grilla.Item(indice_columna, grilla.CurrentCell.RowIndex).Value) Then
                Return CStr(grilla.Item(indice_columna, grilla.CurrentCell.RowIndex).Value)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Private Sub NUEVO_USUARIO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ini = 0
        ActualizarTabla(Me.DGV1, "clientes", "", "nombre") 'tabla ususarios ordenado por apellido
        ' Label6.Text = "1"
        ' Label9.Text = n
        Pinta_fila(ini)


    End Sub

    Sub ActualizarTabla(ByVal grilla As DataGridView, ByVal nombre_tabla As String,
                        ByVal campoSql As String, ByVal C_ORDEN As String)
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
            n = dt.Rows.Count

            grilla.DataSource = dt
            grilla.ReadOnly = True 'SOLO DE LECTURA
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub Pinta_fila(ByVal nn As Integer)
        Try
            For i As Integer = 0 To DGV1.Rows.Count - 1
                DGV1.Rows(i).Selected = False
            Next
            If nn > 0 Then
                DGV1.Rows(nn).Selected = True
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    'Private Sub BTN_AGREGAR_Click(sender As Object, e As EventArgs) Handles BTN_AGREGAR.Click
    '    Try
    '        If ValidarDatos() Then
    '            '  obj_usuario.AgregaUsuario()
    '            If obj_clientes.Agregaclientes(TXT_NOMBRE.Text, TXT_domicilio.Text, txt_RUT.Text) = True Then

    '                MsgBox("Registro ingresado satisfactoriamente", MsgBoxStyle.Information, "Confirmacion")
    '                Me.LimpiarCampos()
    '                ActualizarTabla(Me.DGV1, "clientes", "", "nombre")
    '            Else
    '                MsgBox("Error al ingresar el registro, reintente la accion", MsgBoxStyle.Critical, "Error")
    '            End If
    '        End If


    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de Validación de datos")
    '    End Try
    '    Me.ModoInsercion()

    'End Sub

    'Private Sub DGV1_MouseClick(sender As Object, e As MouseEventArgs) Handles DGV1.MouseClick
    '    If DGV1.SelectedRows.Count = 0 Then
    '        MsgBox("Debe seleccionar un usuario para poder editarlo", MsgBoxStyle.Critical, "Error")
    '        DGV1.Focus()
    '    Else
    '        Me.ModoModificacion()
    '        id = ObtenerCampo(Me.DGV1, 0)
    '        TXT_NOMBRE.Text = ObtenerCampo(Me.DGV1, 1)
    '        TXT_domicilio.Text = ObtenerCampo(Me.DGV1, 2)
    '        txt_RUT.Text = ObtenerCampo(Me.DGV1, 3)
    '        DTP1.Text = ObtenerCampo(Me.DGV1, 4)

    '        BTN_NUEVO.Enabled = False
    '        BTN_AGREGAR.Enabled = False
    '        BTN_ELIMINAR.Enabled = True

    '        ' txtNombre.Focus()
    '        '   Label6.Text = dgv1.CurrentRow.Index + 1
    '        'ini = dgv1.CurrentRow.Index

    '    End If

    'End Sub

    'Private Sub BTN_MODIFICAR_Click(sender As Object, e As EventArgs) Handles BTN_MODIFICAR.Click
    '    Try
    '        Dim i = MsgBox("¿Desea modificar ese registro?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "Confirmación")
    '        If i = MsgBoxResult.Yes Then
    '            If ValidarDatos() Then
    '                If obj_clientes.Modificaclientes(TXT_NOMBRE.Text,
    '                                                 TXT_domicilio.Text,
    '                                                 txt_RUT.Text,
    '                                                 id) = True Then
    '                    MsgBox("Registro actualizado satisfactoriamente", MsgBoxStyle.Information, "Confirmacion")
    '                    Me.LimpiarCampos()
    '                    ActualizarTabla(Me.DGV1, "clientes", "", "id")

    '                    Me.ModoInsercion()
    '                Else
    '                    MsgBox("Error al modificar el registro, reintente la acción", MsgBoxStyle.Critical, "Error")
    '                End If
    '            End If
    '        End If

    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de Validación de datos")
    '    End Try

    'End Sub

    Private Sub BTN_CANCELAR_Click(sender As Object, e As EventArgs) Handles BTN_CANCELAR.Click
        BTN_ELIMINAR.Enabled = True
        BTN_MODIFICAR.Enabled = True
        BTN_NUEVO.Enabled = True
        BTN_AGREGAR.Enabled = True

        Pinta_fila(0)
        If id > 0 Then
            id = DGV1.Item(0, 0).Value
        End If
        LimpiarCampos()

    End Sub

    Private Sub BTN_ELIMINAR_Click(sender As Object, e As EventArgs) Handles BTN_ELIMINAR.Click
        Dim i = MsgBox("¿Desea eliminar este usuario?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "Confirmación")
        If i = MsgBoxResult.Yes Then
            Try

                If obj_clientes.Eliminaclientes(id) = True Then
                    MsgBox("Registro Eliminado satisfactoriamente", MsgBoxStyle.Information, "Confirmacion")
                    Me.LimpiarCampos()
                    ActualizarTabla(Me.DGV1, "clientes", "", "id")
                    Me.ModoInsercion()
                    Me.LimpiarCampos()
                Else
                    MsgBox("Error al eliminar el registro, reintente la accion", MsgBoxStyle.Critical, "Error")
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error de Validación de datos")
            End Try
        Else
        End If

    End Sub

    Private Sub BTN_NUEVO_Click(sender As Object, e As EventArgs) Handles BTN_NUEVO.Click

        Try
            BTN_AGREGAR.Enabled = True
            BTN_NUEVO.Enabled = False
            '  PictureBox1.Image = Nothing
            BTN_ELIMINAR.Enabled = False

            LimpiarCampos()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub BTN_FIN_Click(sender As Object, e As EventArgs) Handles BTN_FIN.Click
        Me.Close()
    End Sub

    Private Sub DGV1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellContentClick

    End Sub

    Private Sub REGISTRAR_CLIENTES_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MDI_Papeleria.MUESTRA()
    End Sub
End Class