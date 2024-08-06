
Imports System.Data.OleDb
Imports System.IO
Public Class cls_productos
    Dim obj_productos As New cls_productos
    Dim ComandoSql As OleDbCommand
    Dim Sql As String


    Function Agregastock(ByVal stock As Integer) As Boolean
        Try
            Dim con As New OleDbConnection(RutaDB_papeleria)
            con.Open()

            Sql = "Insert into productos (stock) " _
                + "Values (@stock)"

            ComandoSql = New OleDbCommand
            With ComandoSql
                .Connection = con
                .CommandText = Sql
                .Parameters.AddWithValue("@stock", stock)

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
End Class

