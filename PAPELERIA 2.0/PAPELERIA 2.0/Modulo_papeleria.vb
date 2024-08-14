Module Modulo_papeleria
    Public RutaDB_papeleria As String = "provider=microsoft.ace.oledb.12.0; data source=" & My.Application.Info.DirectoryPath & "\papeleria.accdb"
    Public usuario As String = ""
    Public nro_cuenta As String = ""
    Public cedula As String = ""

    Public Function Carga_formulario(ByVal form As Form) As Boolean
        For Each f In Application.OpenForms
            If f.Name = form.Name Then
                form.Select()
                Return False
            End If
        Next
        form.MdiParent = MDI_Papeleria
        form.Show()
        Return True
    End Function

End Module
