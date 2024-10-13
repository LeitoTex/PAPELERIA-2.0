
Imports System.Drawing.Printing

Public Class CONTADOS
    Private WithEvents PrintDocument1 As New PrintDocument()

    Public Property id As String
    Dim descuento As Double
    Dim subtotal As Double = 0
    Dim iva As Double
    Dim total As Double
    Dim A As Double
    Dim FILA_p_EDITAR As Double
    Dim fila As Byte = 0

    'Private Function CHEQUEA_CODIGO(ByVal CODIGO As String) As Boolean
    '    Dim fila As Byte = 0
    '    Dim unused As New ListViewItem()
    '    Dim lista As ListViewItem
    '    For Each lista In ListView1.Items
    '        'VER SI EXISE ESE CODIGO
    '        Dim Elemento As ListViewItem = ListView1.Items(fila)
    '        Dim cod As String = Elemento.SubItems(0).Text
    '        If CODIGO = cod Then
    '            Return True
    '            Exit Function
    '        End If
    '        fila += 1
    '    Next
    '    Return False
    'End Function

    Private Sub TXT_PRECIO_KeyPress(sender As Object, e As KeyPressEventArgs)
        If InStr("0123456789" & Chr(8), e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            'ENVIAR ESA PULSACIÓN
            SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub TXT_CANTIDAD_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_CANTIDAD.KeyPress
        If InStr("0123456789" & Chr(8), e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{tab}")

        End If

    End Sub

    Private Sub BTN_AGREGA_Click(sender As Object, e As EventArgs) Handles BTN_AGREGA.Click
        Dim importe_d As Double = Val(TXT_DESCUENTO.Text)
        Dim importe_pr As Double = Val(TXT_PRECIO.Text) * Val(TXT_CANTIDAD.Text) - importe_d
        Dim lista As New ListViewItem(UCase(TXT_CODIGO.Text))
        fila += 1

        'If CHEQUEA_CODIGO(TXT_CODIGO.Text) = True Then
        '    MsgBox("EL CODIGO YA EXISTE")
        TXT_CODIGO.Focus()
        TXT_CODIGO.SelectAll()
        'End If
        lista.SubItems.Add(UCase(TXT_DESCRIPCION.Text))
        lista.SubItems.Add(TXT_PRECIO.Text)
        lista.SubItems.Add(TXT_CANTIDAD.Text)
        lista.SubItems.Add(TXT_DESCUENTO.Text)
        lista.SubItems.Add(importe_pr.ToString)

        ListView1.Items.Add(lista)

        importe_d = (importe_pr - (importe_pr * descuento) / 100)
        total = total + importe_d
        iva = (total * 22) / 100

        subtotal = Math.Round(total - iva, 2)
        total = Math.Round(subtotal + iva, 0)

        LBL_SUBTOTAL.Text = Format(subtotal, "$u ##,##0.00")
        LBL_IVA.Text = Format(iva, "$u ##,##0.00")
        LBL_TOTAL.Text = Format(total, "$u ##,##0.00")

        TXT_CODIGO.Text = ""
        TXT_DESCRIPCION.Text = ""
        TXT_CANTIDAD.Text = ""
        TXT_PRECIO.Text = ""
        TXT_DESCUENTO.Text = ""
        TXT_IMPORTE.Text = ""
        TXT_CODIGO.Focus()

    End Sub

    Private Sub BTN_ELIMINA_Click(sender As Object, e As EventArgs) Handles BTN_ELIMINA.Click
        Dim p As Boolean = False
        Dim lista As ListViewItem
        For Each lista In ListView1.CheckedItems
            lista.Remove()
            p = True
        Next
        If p = False Then
            MsgBox("Elija elemento a eliminar")
            Exit Sub
        End If
        total = total - A
        iva = (total * 22) / 100
        subtotal = total - iva
        total = Math.Round(subtotal + iva, 1)

        LBL_SUBTOTAL.Text = Format(subtotal, "$u ##,##0.00")
        LBL_IVA.Text = Format(iva, "$u ##,##0.00")
        LBL_TOTAL.Text = Format(total, "$u ##,##0.00")

        A = 0

        TXT_CODIGO.Focus()
    End Sub
    Private Sub ListView1_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles ListView1.ItemCheck

        If (e.CurrentValue = CheckState.Unchecked) Then
            A = A + Val(ListView1.Items(e.Index).SubItems(5).Text)
            FILA_p_EDITAR = e.Index

        ElseIf (e.CurrentValue = CheckState.Checked) Then
            A = A - Val(ListView1.Items(e.Index).SubItems(5).Text)
        End If
    End Sub
    Private Sub TXT_NOMBRE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_NOMBRE.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub TXT_DOMICILIO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_DOMICILIO.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{tab}")
        End If
    End Sub
    Private Sub TXT_RUT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_RUT.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub TXT_CODIGO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_CODIGO.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub TXT_CUENTA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_CUENTA.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub TXT_DESCRIPCION_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_DESCRIPCION.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub TXT_DESCUENTO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_DESCUENTO.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub TXT_IMPORTE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_IMPORTE.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub BTN_AGREGA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BTN_AGREGA.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            BTN_AGREGA_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MDI_Papeleria.MUESTRA()
    End Sub
    Public Sub RecibirDatos(selectedvalue As String, selectedvalue1 As String, selectedvalue2 As String)
        TXT_DESCRIPCION.Text = selectedvalue1
        TXT_CODIGO.Text = selectedvalue
        TXT_PRECIO.Text = selectedvalue2
        TXT_CANTIDAD.Focus()
    End Sub
    Public Sub recibirdatos1(selectedvalue As String, selectedvalue1 As String, selectedvalue2 As String, selectedvalue3 As String)
        TXT_CUENTA.Text = selectedvalue
        TXT_NOMBRE.Text = selectedvalue1
        TXT_DOMICILIO.Text = selectedvalue2
        TXT_RUT.Text = selectedvalue3
        TXT_CODIGO.Focus()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form2 As New Buscador()
        form2.ShowDialog()
        TXT_CANTIDAD.Focus()
    End Sub

    Private Sub BTN_CUENTA_Click(sender As Object, e As EventArgs) Handles BTN_CUENTA.Click
        Dim form2 As New BUSCADOR_CLIENTES()
        form2.ShowDialog()
        TXT_CODIGO.Focus()

    End Sub

    Private Sub BTN_ACEPTAR_Click(sender As Object, e As EventArgs) Handles BTN_ACEPTAR.Click
        PrintDocument1.Print()
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim font As New System.Drawing.Font("Arial", 12)
        Dim brush As New SolidBrush(Color.Black)
        Dim startX As Single = 10
        Dim startY As Single = 10
        Dim offsetY As Single = 0
        Dim pageHeight As Integer = e.MarginBounds.Height

        ' Obtener la altura del texto
        Dim textHeight As Single = e.Graphics.MeasureString("Texto", font).Height

        ' Imprimir encabezados de columna
        For Each column As ColumnHeader In ListView1.Columns
            If Not String.IsNullOrEmpty(column.Text) Then
                e.Graphics.DrawString(column.Text, font, brush, CSng(startX), CSng(startY + offsetY))
            End If
            startX += column.Width
        Next

        ' Imprimir filas de datos
        offsetY += textHeight
        For Each item As ListViewItem In ListView1.Items
            startX = 10
            For Each subItem As ListViewItem.ListViewSubItem In item.SubItems
                If Not String.IsNullOrEmpty(subItem.Text) Then
                    e.Graphics.DrawString(subItem.Text, font, brush, CSng(startX), CSng(startY + offsetY))
                End If
                startX += ListView1.Columns(item.SubItems.IndexOf(subItem)).Width
            Next
            offsetY += textHeight

            ' Verificar si se necesita una nueva página
            If startY + offsetY + textHeight > pageHeight Then
                e.HasMorePages = True
                Return
            End If
        Next

        e.HasMorePages = False
    End Sub

    Private Sub BTN_CANCELAR_Click(sender As Object, e As EventArgs) Handles BTN_CANCELAR.Click
        Me.Close()
        'muestra()

    End Sub

End Class



