Module Modulo_papeleria
    Public RutaDB_papeleria As String = "provider=microsoft.ace.oledb.12.0; data source=" & My.Application.Info.DirectoryPath & "\papeleria.accdb"
    Public usuario As String = ""
    Public nro_cuenta As String = ""
    Public cedula As String = ""

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

End Module
