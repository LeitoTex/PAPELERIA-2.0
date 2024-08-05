Imports System.Data.OleDb
Imports System.IO


Public Class Cls_clientes
    Dim ComandoSql As OleDbCommand
    Dim Sql As String


    Function Agregaclientes(ByVal nombre As String, ByVal domicilio As String,
                           ByVal rut As String, value As Date) As Boolean
        Dim con As New OleDbConnection(RutaDB_papeleria) 'APUNTA A LA BASE DE DATOS.. CON = CONEXION 
        con.Open()

        Try

            Sql = "Insert into clientes (nombre, domicilio, rut) " _
            + "Values (@nombre,@domicilio,@rut)"

            ComandoSql = New OleDbCommand
            With ComandoSql
                .Connection = con
                .CommandText = Sql
                .Parameters.AddWithValue("@nombre", nombre.ToUpper)
                .Parameters.AddWithValue("@domicilio", domicilio.ToUpper)
                .Parameters.AddWithValue("@rut", rut.ToUpper)

                .ExecuteNonQuery()
            End With

            ComandoSql.Dispose()
            Sql = String.Empty
            con.Close()
            Return True

        Catch exsql As OleDbException
            MsgBox(exsql.Message)
            Return False

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Function Modifica_clientes(ByVal nombre As String,
                                     ByVal DOMICILIO As String,
                                     ByVal RUT As String,
                                     ByVal id As Integer) As Boolean
        Try
            Dim con As New OleDbConnection(RutaDB_papeleria)

            Dim MS As New MemoryStream

            con.Open()
            'TOUPPER  MAYUSCULAS  TOLOWER MINUSCULAS
            Sql = "UPDATE clientes SET Nombre = '" & nombre.ToUpper & "',domicilio = '" & DOMICILIO.ToUpper & "',rut = '" & RUT & "' WHERE id =" & id & ""

            ComandoSql = New OleDbCommand(Sql, con)

            ComandoSql.ExecuteNonQuery() 'EJECUTA LOS CAMBIOS
            ComandoSql.Dispose() 'LIMPIA LA VARIABLE 
            Sql = String.Empty 'EMPTY  LIMPIA LA VARIABLE
            con.Close()
            Return True

        Catch exsql As OleDbException
            Return False

        Catch ex As Exception
            Return False
        End Try


    End Function


    Function Eliminaclientes(ByVal id As Integer) As Boolean
        Try
            Dim con As New OleDbConnection(RutaDB_papeleria)
            con.Open()
            Sql = "DELETE * FROM clientes WHERE id =" & id
            ComandoSql = New OleDbCommand(Sql, con)
            ComandoSql.ExecuteNonQuery()
            ComandoSql.Dispose()
            Sql = String.Empty
            con.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Friend Function Modificaclientes(text1 As String, text2 As String, text3 As String, text4 As String, id As Integer) As Boolean
        Throw New NotImplementedException()
    End Function

    Friend Function Modificaclientes(text1 As String, text2 As String, text3 As String, value As Date, id As Integer) As Boolean
        Throw New NotImplementedException()
    End Function
End Class
