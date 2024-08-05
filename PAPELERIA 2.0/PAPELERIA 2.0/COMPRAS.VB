Public Class COMPRAS

    Private Function CHEQUEA_CODIGO(ByVal CODIGO As String) As Boolean
        Dim fila As Byte = 0

        Dim unused As New ListViewItem()

        Dim lista As ListViewItem
        For Each lista In ListView1.Items

            'VER SI EXISE ESE CODIGO
            Dim Elemento As ListViewItem = ListView1.Items(fila)
            Dim cod As String = Elemento.SubItems(0).Text
            If CODIGO = cod Then
                Return True
                Exit Function
            End If

            fila += 1
        Next
        Return False
    End Function

    Private Sub COMPRAS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub COMPRAS_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MDI_Papeleria.MUESTRA()

    End Sub

    Private Sub BTN_ACEPTAR_Click(sender As Object, e As EventArgs) Handles BTN_ACEPTAR.Click

    End Sub

    Private Sub TXT_CANTIDAD_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_CANTIDAD.KeyPress
        If InStr("0123456789" & Chr(8), e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then 'presiono enter?
            e.Handled = True
            'ENVIAR ESA PULSACIÓN
            SendKeys.Send("{tab}")
        End If
    End Sub


    Private Sub TXT_PRECIO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_PRECIO.KeyPress
        If InStr("0123456789" & Chr(8), e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then 'presiono enter?
            e.Handled = True
            'ENVIAR ESA PULSACIÓN
            SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub BTN_AGREGA_Click(sender As Object, e As EventArgs) Handles BTN_AGREGA.Click
        Dim lista As New ListViewItem(UCase(TXT_CODIGO.Text))

        If CHEQUEA_CODIGO(TXT_CODIGO.Text) = True Then
            MsgBox("EL CODIGO YA EXISTE")
            TXT_CODIGO.Focus()
            TXT_CODIGO.SelectAll()

            Exit Sub
        End If
        lista.SubItems.Add(UCase(TXT_DESCRIPCION.Text))
        lista.SubItems.Add(TXT_PRECIO.Text)
        lista.SubItems.Add(TXT_CANTIDAD.Text)

        ListView1.Items.Add(lista)

    End Sub
End Class