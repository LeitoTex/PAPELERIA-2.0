
Imports System.Data.OleDb
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class ESTADOS_DE_CUENTA

    Dim n As Integer

    Sub pinta_fila(ByVal nn As Integer)
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

    Sub ActualizarTabla1(ByVal grilla As DataGridView)
        Try
            Dim da As OleDbDataAdapter 'DATAADPTER
            Dim dt As DataTable
            Dim consulta As String 'f9
            consulta = "SELECT CLIENTES.NOMBRE, CLIENTES.FECHA, MOVIMIENTOS.TIPO_OPERACION, MOVIMIENTOS.IMPORTE, MOVIMIENTOS.OBSERVACION
From MOVIMIENTOS
Where (((MOVIMIENTOS.NRO_NOMBRE) = " & LBL_NUMERO_CUENTA.Text & "))
Order By MOVIMIENTOS.FECHA DESC;"

            da = New OleDbDataAdapter(consulta, RutaDB_cajero)
            dt = New DataTable
            da.Fill(dt)
            n = dt.Rows.Count

            grilla.DataSource = dt
            grilla.ReadOnly = True 'SOLO DE LECTURA
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub ActualizarTabla(ByVal grilla As DataGridView)

        Dim da1 As OleDbDataAdapter 'DATAADPTER
        Dim dt1 As DataTable
        Dim consulta As String 'f9
        Dim fecha1 As String
        Dim fecha2 As String

        Try
            fecha1 = CDate(DateTimePicker_DESDE.Text).ToString("MM/dd/yyyy")
            fecha2 = CDate(DateTimePicker_HASTA.Text).ToString("MM/dd/yyyy")

            consulta = "SELECT MOVIMIENTOS.NRO_CUENTA, MOVIMIENTOS.FECHA, MOVIMIENTOS.TIPO_OPERACION, MOVIMIENTOS.IMPORTE, MOVIMIENTOS.OBSERVACION
From MOVIMIENTOS
Where MOVIMIENTOS.NRO_CUENTA = " & ListBox2.SelectedIndex & " And MOVIMIENTOS.TIPO_OPERACION = '" & CMB_TIPO_OPERACION.Text & "' And MOVIMIENTOS.FECHA 
Between # " & fecha1 & " # And # " & fecha2 & " # "

            da1 = New OleDbDataAdapter(consulta, RutaDB_papeleria)
            dt1 = New DataTable
            da1.Fill(dt1)
            n = dt1.Rows.Count

            grilla.DataSource = dt1
            grilla.ReadOnly = True 'SOLO DE LECTURA
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub carga_datos()
        Try
            Dim SQL As String
            '               0                   1
            SQL = "Select USUARIOS.NOMBRE, USUARIOS.APELLIDO, USUARIOS.NRO_CUENTA, USUARIOS.usuario From USUARIOS order by APELLIDO"

            Dim da As New OleDbDataAdapter(SQL, RutaDB_papeleria)
            Dim dt As New DataTable

            da.Fill(dt)

            ListBox1.Items.Clear()
            ListBox2.Items.Clear()
            ListBox3.Items.Clear()

            For i = 0 To dt.Rows.Count - 1
                Dim dr As DataRow 'dr datarow
                dr = dt.Rows(i)
                ListBox1.Items.Add(dr(0) & " - " & dr(1))
                ListBox2.Items.Add(dr(2))
                ListBox3.Items.Add(dr(3))

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TXT_NUMERO_CUENTA.TextChanged
        Try
            Dim SQL As String
            Dim DATO As String

            DATO = TXT_NUMERO_CUENTA.Text & "%"
            '                   0                  1
            SQL = "Select USUARIOS.NOMBRE, USUARIOS.APELLIDO, USUARIOS.NRO_CUENTA, USUARIOS.usuario From USUARIOS
Where (((USUARIOS.nombre) Like '" & DATO & "'));"

            Dim da As New OleDbDataAdapter(SQL, RutaDB_papeleria)
            Dim dt As New DataTable
            da.Fill(dt)
            ListBox1.Items.Clear()
            ListBox2.Items.Clear()
            ListBox3.Items.Clear()

            For i = 0 To dt.Rows.Count - 1
                Dim dr As DataRow
                dr = dt.Rows(i)
                ListBox1.Items.Add(dr(0) & " - " & dr(1))
                ListBox2.Items.Add(dr(2))
                ListBox3.Items.Add(dr(3))

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        ListBox2.SelectedIndex = ListBox1.SelectedIndex
        ListBox3.SelectedIndex = ListBox1.SelectedIndex

        LBL_NUMERO_CUENTA.Text = ListBox2.Text
        lbl_usuario.Text = ListBox3.Text

        ActualizarTabla1(DGV1)

    End Sub
    Private Sub REGISTRO_CAJERO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carga_datos()
        BTN_BUSCAR.Enabled = False

    End Sub
    Private Sub DateTimePicker_HASTA_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker_HASTA.ValueChanged

    End Sub

    Private Sub BTN_BUSCAR_Click(sender As Object, e As EventArgs) Handles BTN_BUSCAR.Click
        ActualizarTabla(DGV1)

    End Sub

    Private Sub REGISTRO_CAJERO_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        MDI_Papeleria.MUESTRA()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_fin.Click
        MDI_Papeleria.MUESTRA()
        Me.Close()

    End Sub

    Private Sub BTN_CANCELAR_Click(sender As Object, e As EventArgs) Handles BTN_CANCELAR.Click
        DGV1.ClearSelection()
        CMB_TIPO_OPERACION.Text = ""
        BTN_BUSCAR.Enabled = False
        Me.TXT_NUMERO_CUENTA.Focus()

    End Sub

    Private Sub CMB_TIPO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMB_TIPO_OPERACION.SelectedIndexChanged
        BTN_BUSCAR.Enabled = True
    End Sub
End Class
End Class