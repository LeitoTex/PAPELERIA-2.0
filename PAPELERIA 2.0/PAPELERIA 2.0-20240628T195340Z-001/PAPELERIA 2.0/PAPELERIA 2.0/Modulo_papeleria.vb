Imports System.Data.OleDb
Module Modulo_papeleria
    Public RutaDB_papeleria As String = "provider=microsoft.ace.oledb.12.0; data source=" & My.Application.Info.DirectoryPath & "\papeleria.accdb"
    Public usuario As String = ""
    Public nro_cuenta As String = ""
    Public cedula As String = ""
    Public SQL2 As String
    Public prod As Integer

    Public conn As New OleDbConnection(RutaDB_papeleria)
    Public cmd As New OleDbCommand(SQL2, conn)

    Public CodigoP, NombreP, CantidadP, PrecioP As String

    Public Function Carga_formulario(ByVal form As Form) As Boolean
        'Chequeo si ya está abierto.
        For Each f In Application.OpenForms
            'Si está abierto devuelvo False (no se puede abrir).
            If f.Name = form.Name Then
                form.Select()
                Return False
            End If
        Next
        'Si se llega a este punto es porque no está abierto.
        'Abro el formulario.
        form.MdiParent = MDI_Papeleria
        form.Show()
        'Indico apertura exitosa.
        Return True
    End Function

    Public Function Consulta_Codigo(prod) As Boolean


        SQL2 = "SELECT productos.codigo, productos.nombre_producto, productos.cantidad, productos.Precio_venta
FROM productos
WHERE (((productos.codigo)= " & prod & "));"

        Try
            Using conn As New OleDbConnection(RutaDB_papeleria)
                conn.Open()
                Using cmd As New OleDbCommand(SQL2, conn)
                    Dim reader As OleDbDataReader = cmd.ExecuteReader()

                    If reader.Read() Then ' Si encuentra un registro
                        If Form1.TXT_CODIGO.Text = reader("codigo").ToString() Then
                            CodigoP = reader("codigo").ToString
                            NombreP = reader("nombre_producto").ToString
                            'CantidadP = reader("cantidad").ToString
                            PrecioP = reader("Precio_venta").ToString
                            Return True
                        End If
                    Else
                        Return False
                        Exit Function
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Return False
        End Try
    End Function

    Public Function Carga_datos()
        Dim nombre, domicilio, rut As String
        'Dim rut As Integer
        Dim SQL As String
        Dim DATO As String

        Form1.TXT_NOMBRE.Text = ""
        Form1.TXT_DOMICILIO.Text = ""
        Form1.TXT_RUT.Text = ""

        DATO = buscador.TextBox1.Text '& "%"  '%comodin
        '                   0                  1
        SQL = "Select clientes.nombre, Clientes.domicilio, clientes.rut " _
    + "FROM Clientes " _
    + "WHERE Clientes.nombre Like '" & DATO & "' " _
    + "ORDER BY Clientes.nombre;"

        Dim da As New OleDbDataAdapter(SQL, RutaDB_papeleria)

        Dim dt As New DataTable
        da.Fill(dt)
        buscador.ListBox1.Items.Clear()
        For i = 0 To dt.Rows.Count - 1
            Dim dr As DataRow
            dr = dt.Rows(i)
            buscador.ListBox1.Items.Add(UCase(dr(0)) & " - " & dr(1) & " - " & dr(2))
            'ucase()   Mayusculas...
            nombre = dr(0)
            domicilio = dr(1)
            rut = dr(2)
            Form1.TXT_NOMBRE.Text = nombre
            Form1.TXT_DOMICILIO.Text = domicilio
            Form1.TXT_RUT.Text = rut
        Next
    End Function

    Public Function valida_rut(ByVal rut As String) As Boolean

        '3399486
        '        Ej. el rut de antel 
        '| 2 | 1 | 1 | 0 | 0 | 3 | 4 | 2 | 0 | 0 | 1 | 7
        '| 4 | 3 | 2 | 9 | 8 | 7 | 6 | 5 | 4 | 3 | 2 |
        '| 8 | 3 | 2 | 0 | 0 |21 |24 |10 | 0 | 0 | 2 |= 70

        ' el resto de 70 / 11 = 4

        'digito verif. = 11 - 4 = 7 


        Dim clave(11) As Byte : Dim a As String : Dim b As String : Dim c As Double
        Dim d As Byte

        Dim i As Integer
        'txtci.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals
        If rut.Length < 12 Then
            MsgBox("Rut incompleto", MsgBoxStyle.Exclamation, "Error")
            REGISTRAR_CLIENTES.txt_RUT.Focus() : REGISTRAR_CLIENTES.txt_RUT.SelectAll()
            Return False
            Exit Function
        Else
            clave(11) = 2 : clave(10) = 3 : clave(9) = 4 : clave(8) = 5
            clave(7) = 6 : clave(6) = 7 : clave(5) = 8 : clave(4) = 9
            clave(3) = 2 : clave(2) = 3 : clave(1) = 4

            c = 0
            For i = 11 To 1 Step -1
                a = Mid(rut, i, 1)
                b = a * clave(i)
                c = c + b
            Next i

            Dim r As Byte
            r = c Mod 11
            d = 11 - r

            If d <> Mid(rut, 12, 1) Then
                Return False
                Exit Function
            End If

            Return True

        End If

    End Function

End Module
