Public Class MDI_Papeleria

    Private m_ChildFormNumber As Integer
    Private Sub MDI_Papeleria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LOGIN.Close()
    End Sub
    'Private Function Carga_formulario(ByVal form As Form) As Boolean
    '    For Each f As Form In Application.OpenForms
    '        If f.Name = form.Name Then
    '            form.Select()
    '            Return False
    '        End If
    '    Next
    '    form.MdiParent = Me
    '    form.Show()
    '    Return True
    'End Function
    Sub oculta()
        btn_lgout.Hide()
        BTN_CONTADOS.Hide()
        BTN_CREDITO.Hide()
    End Sub
    Sub MUESTRA()
        btn_lgout.Show()
        BTN_CONTADOS.Show()
        BTN_CREDITO.Show()

    End Sub



    Private Sub btn_lgout_Click(sender As Object, e As EventArgs) Handles btn_lgout.Click
        LOGIN.Show()
        LOGIN.TXT_USER.Clear()
        LOGIN.TXT_PASS.Clear()
    End Sub

    Private Sub BTN_CONTADOS_Click(sender As Object, e As EventArgs) Handles BTN_CONTADOS.Click
        Carga_formulario(FORM1)
        oculta()

    End Sub
    Private Sub BTNLOGOUT_MouseHover(sender As Object, e As EventArgs) Handles btn_lgout.MouseHover
        ToolTip.SetToolTip(btn_lgout, "LOG OUT")

    End Sub

    Private Sub BTN_CONTADOS_MouseHover(sender As Object, e As EventArgs) Handles BTN_CONTADOS.MouseHover
        ToolTip.SetToolTip(BTN_CONTADOS, "CONTADO")

    End Sub

    Private Sub BTN_CREDITO_Click(sender As Object, e As EventArgs) Handles BTN_CREDITO.Click
        Carga_formulario(creditos)
        oculta()
    End Sub

    Private Sub ComprasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComprasToolStripMenuItem.Click
        Carga_formulario(COMPRAS)
        oculta()
    End Sub

    Private Sub PROVEEDORToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PROVEEDORToolStripMenuItem.Click
        Carga_formulario(REGISTRAR_PROVEEDORES)
        oculta()

    End Sub

    Private Sub CLIENTEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CLIENTEToolStripMenuItem.Click
        Carga_formulario(REGISTRAR_CLIENTES)
        oculta()

    End Sub

    Private Sub USUARIOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles USUARIOToolStripMenuItem.Click
        Carga_formulario(REGISTRAR_USUARIOS)
        oculta()

    End Sub
End Class
