Public Class Productos
    Private Sub BTN_ACEPTAR_Click(sender As Object, e As EventArgs) Handles BTN_ACEPTAR.Click

    End Sub

    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Productos_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MDI_Papeleria.MUESTRA()

    End Sub
End Class