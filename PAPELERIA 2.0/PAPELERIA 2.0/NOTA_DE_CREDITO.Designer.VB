<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NOTA_DE_CREDITO
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TXT_CANTIDAD = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BTN_CANCELAR = New System.Windows.Forms.Button()
        Me.BTN_ACEPTAR = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TXT_IMPORTE = New System.Windows.Forms.TextBox()
        Me.TXT_DESCUENTO = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TXT_RUT = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TXT_DOMICILIO = New System.Windows.Forms.TextBox()
        Me.TXT_NOMBRE = New System.Windows.Forms.TextBox()
        Me.TXT_CUENTA = New System.Windows.Forms.TextBox()
        Me.BTN_CUENTA = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TXT_SERIE = New System.Windows.Forms.TextBox()
        Me.TXT_NRO_DOC = New System.Windows.Forms.TextBox()
        Me.LBL_TOTAL = New System.Windows.Forms.Label()
        Me.LBL_IVA = New System.Windows.Forms.Label()
        Me.LBL_SUBTOTAL = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.CODIGO = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BTN_ELIMINA = New System.Windows.Forms.Button()
        Me.BTN_AGREGA = New System.Windows.Forms.Button()
        Me.TXT_PRECIO = New System.Windows.Forms.TextBox()
        Me.TXT_DESCRIPCION = New System.Windows.Forms.TextBox()
        Me.TXT_CODIGO = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TXT_CANTIDAD
        '
        Me.TXT_CANTIDAD.Location = New System.Drawing.Point(410, 127)
        Me.TXT_CANTIDAD.Name = "TXT_CANTIDAD"
        Me.TXT_CANTIDAD.Size = New System.Drawing.Size(69, 20)
        Me.TXT_CANTIDAD.TabIndex = 162
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(407, 109)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 191
        Me.Label7.Text = "CANTIDAD"
        '
        'BTN_CANCELAR
        '
        Me.BTN_CANCELAR.Location = New System.Drawing.Point(108, 412)
        Me.BTN_CANCELAR.Name = "BTN_CANCELAR"
        Me.BTN_CANCELAR.Size = New System.Drawing.Size(79, 24)
        Me.BTN_CANCELAR.TabIndex = 190
        Me.BTN_CANCELAR.Text = "CANCELAR"
        Me.BTN_CANCELAR.UseVisualStyleBackColor = True
        '
        'BTN_ACEPTAR
        '
        Me.BTN_ACEPTAR.Location = New System.Drawing.Point(22, 412)
        Me.BTN_ACEPTAR.Name = "BTN_ACEPTAR"
        Me.BTN_ACEPTAR.Size = New System.Drawing.Size(79, 24)
        Me.BTN_ACEPTAR.TabIndex = 189
        Me.BTN_ACEPTAR.Text = "ACEPTAR"
        Me.BTN_ACEPTAR.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(576, 109)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(56, 13)
        Me.Label19.TabIndex = 188
        Me.Label19.Text = "IMPORTE"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(509, 109)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(38, 13)
        Me.Label18.TabIndex = 187
        Me.Label18.Text = "%DTO"
        '
        'TXT_IMPORTE
        '
        Me.TXT_IMPORTE.Location = New System.Drawing.Point(579, 127)
        Me.TXT_IMPORTE.Name = "TXT_IMPORTE"
        Me.TXT_IMPORTE.Size = New System.Drawing.Size(87, 20)
        Me.TXT_IMPORTE.TabIndex = 164
        '
        'TXT_DESCUENTO
        '
        Me.TXT_DESCUENTO.Location = New System.Drawing.Point(512, 127)
        Me.TXT_DESCUENTO.Name = "TXT_DESCUENTO"
        Me.TXT_DESCUENTO.Size = New System.Drawing.Size(35, 20)
        Me.TXT_DESCUENTO.TabIndex = 163
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(149, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 186
        Me.Label1.Text = "DESCRIPCION"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(115, 124)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(22, 23)
        Me.Button1.TabIndex = 159
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(301, 18)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(63, 13)
        Me.Label17.TabIndex = 185
        Me.Label17.Text = "NRO. DOC:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(211, 18)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(42, 13)
        Me.Label16.TabIndex = 184
        Me.Label16.Text = "SERIE:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(34, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 183
        Me.Label8.Text = "FECHA:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(534, 60)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(57, 13)
        Me.Label15.TabIndex = 182
        Me.Label15.Text = "RUT / C.I."
        '
        'TXT_RUT
        '
        Me.TXT_RUT.Location = New System.Drawing.Point(537, 84)
        Me.TXT_RUT.Name = "TXT_RUT"
        Me.TXT_RUT.Size = New System.Drawing.Size(185, 20)
        Me.TXT_RUT.TabIndex = 157
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(327, 60)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 13)
        Me.Label14.TabIndex = 181
        Me.Label14.Text = "DOMICILIO"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(119, 60)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 13)
        Me.Label13.TabIndex = 180
        Me.Label13.Text = "NOMBRE:"
        '
        'TXT_DOMICILIO
        '
        Me.TXT_DOMICILIO.Location = New System.Drawing.Point(330, 84)
        Me.TXT_DOMICILIO.Name = "TXT_DOMICILIO"
        Me.TXT_DOMICILIO.Size = New System.Drawing.Size(203, 20)
        Me.TXT_DOMICILIO.TabIndex = 156
        '
        'TXT_NOMBRE
        '
        Me.TXT_NOMBRE.Location = New System.Drawing.Point(122, 84)
        Me.TXT_NOMBRE.Name = "TXT_NOMBRE"
        Me.TXT_NOMBRE.Size = New System.Drawing.Size(202, 20)
        Me.TXT_NOMBRE.TabIndex = 155
        '
        'TXT_CUENTA
        '
        Me.TXT_CUENTA.Location = New System.Drawing.Point(22, 84)
        Me.TXT_CUENTA.Name = "TXT_CUENTA"
        Me.TXT_CUENTA.Size = New System.Drawing.Size(66, 20)
        Me.TXT_CUENTA.TabIndex = 153
        Me.TXT_CUENTA.Text = "9000"
        '
        'BTN_CUENTA
        '
        Me.BTN_CUENTA.Location = New System.Drawing.Point(94, 82)
        Me.BTN_CUENTA.Name = "BTN_CUENTA"
        Me.BTN_CUENTA.Size = New System.Drawing.Size(22, 23)
        Me.BTN_CUENTA.TabIndex = 154
        Me.BTN_CUENTA.Text = "..."
        Me.BTN_CUENTA.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(19, 60)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 13)
        Me.Label12.TabIndex = 179
        Me.Label12.Text = "CUENTA:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(85, 15)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(102, 20)
        Me.DateTimePicker1.TabIndex = 178
        '
        'TXT_SERIE
        '
        Me.TXT_SERIE.Location = New System.Drawing.Point(259, 15)
        Me.TXT_SERIE.Name = "TXT_SERIE"
        Me.TXT_SERIE.Size = New System.Drawing.Size(36, 20)
        Me.TXT_SERIE.TabIndex = 177
        Me.TXT_SERIE.Text = "1"
        '
        'TXT_NRO_DOC
        '
        Me.TXT_NRO_DOC.Location = New System.Drawing.Point(370, 15)
        Me.TXT_NRO_DOC.Name = "TXT_NRO_DOC"
        Me.TXT_NRO_DOC.Size = New System.Drawing.Size(75, 20)
        Me.TXT_NRO_DOC.TabIndex = 176
        Me.TXT_NRO_DOC.Text = "1"
        '
        'LBL_TOTAL
        '
        Me.LBL_TOTAL.AutoSize = True
        Me.LBL_TOTAL.Location = New System.Drawing.Point(768, 397)
        Me.LBL_TOTAL.Name = "LBL_TOTAL"
        Me.LBL_TOTAL.Size = New System.Drawing.Size(13, 13)
        Me.LBL_TOTAL.TabIndex = 175
        Me.LBL_TOTAL.Text = "0"
        '
        'LBL_IVA
        '
        Me.LBL_IVA.AutoSize = True
        Me.LBL_IVA.Location = New System.Drawing.Point(768, 373)
        Me.LBL_IVA.Name = "LBL_IVA"
        Me.LBL_IVA.Size = New System.Drawing.Size(13, 13)
        Me.LBL_IVA.TabIndex = 174
        Me.LBL_IVA.Text = "0"
        '
        'LBL_SUBTOTAL
        '
        Me.LBL_SUBTOTAL.AutoSize = True
        Me.LBL_SUBTOTAL.Location = New System.Drawing.Point(768, 348)
        Me.LBL_SUBTOTAL.Name = "LBL_SUBTOTAL"
        Me.LBL_SUBTOTAL.Size = New System.Drawing.Size(13, 13)
        Me.LBL_SUBTOTAL.TabIndex = 173
        Me.LBL_SUBTOTAL.Text = "0"
        '
        'ListView1
        '
        Me.ListView1.CheckBoxes = True
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CODIGO, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.ListView1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(22, 178)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(629, 208)
        Me.ListView1.TabIndex = 172
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'CODIGO
        '
        Me.CODIGO.Text = "CODIGO"
        Me.CODIGO.Width = 88
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "NOMBRE"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 106
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "PRECIO"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 107
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "CANTIDAD"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 103
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "DESCUENTO"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 119
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "IMPORTE"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 102
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(675, 397)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 171
        Me.Label9.Text = "TOTAL"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(675, 373)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 170
        Me.Label6.Text = "IVA 22%"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(675, 348)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 169
        Me.Label5.Text = "SUBTOTAL:"
        '
        'BTN_ELIMINA
        '
        Me.BTN_ELIMINA.Location = New System.Drawing.Point(678, 178)
        Me.BTN_ELIMINA.Name = "BTN_ELIMINA"
        Me.BTN_ELIMINA.Size = New System.Drawing.Size(82, 24)
        Me.BTN_ELIMINA.TabIndex = 166
        Me.BTN_ELIMINA.Text = "ELIMINAR"
        Me.BTN_ELIMINA.UseVisualStyleBackColor = True
        '
        'BTN_AGREGA
        '
        Me.BTN_AGREGA.Location = New System.Drawing.Point(678, 127)
        Me.BTN_AGREGA.Name = "BTN_AGREGA"
        Me.BTN_AGREGA.Size = New System.Drawing.Size(82, 24)
        Me.BTN_AGREGA.TabIndex = 165
        Me.BTN_AGREGA.Text = "AGREGAR"
        Me.BTN_AGREGA.UseVisualStyleBackColor = True
        '
        'TXT_PRECIO
        '
        Me.TXT_PRECIO.Location = New System.Drawing.Point(310, 126)
        Me.TXT_PRECIO.Name = "TXT_PRECIO"
        Me.TXT_PRECIO.Size = New System.Drawing.Size(87, 20)
        Me.TXT_PRECIO.TabIndex = 161
        '
        'TXT_DESCRIPCION
        '
        Me.TXT_DESCRIPCION.Location = New System.Drawing.Point(143, 127)
        Me.TXT_DESCRIPCION.Name = "TXT_DESCRIPCION"
        Me.TXT_DESCRIPCION.Size = New System.Drawing.Size(161, 20)
        Me.TXT_DESCRIPCION.TabIndex = 160
        '
        'TXT_CODIGO
        '
        Me.TXT_CODIGO.Location = New System.Drawing.Point(22, 127)
        Me.TXT_CODIGO.Name = "TXT_CODIGO"
        Me.TXT_CODIGO.Size = New System.Drawing.Size(87, 20)
        Me.TXT_CODIGO.TabIndex = 158
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(307, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 168
        Me.Label3.Text = "PRECIO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 167
        Me.Label2.Text = "PRODUCTO"
        '
        'NOTA_DE_CREDITO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TXT_CANTIDAD)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BTN_CANCELAR)
        Me.Controls.Add(Me.BTN_ACEPTAR)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.TXT_IMPORTE)
        Me.Controls.Add(Me.TXT_DESCUENTO)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TXT_RUT)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TXT_DOMICILIO)
        Me.Controls.Add(Me.TXT_NOMBRE)
        Me.Controls.Add(Me.TXT_CUENTA)
        Me.Controls.Add(Me.BTN_CUENTA)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TXT_SERIE)
        Me.Controls.Add(Me.TXT_NRO_DOC)
        Me.Controls.Add(Me.LBL_TOTAL)
        Me.Controls.Add(Me.LBL_IVA)
        Me.Controls.Add(Me.LBL_SUBTOTAL)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BTN_ELIMINA)
        Me.Controls.Add(Me.BTN_AGREGA)
        Me.Controls.Add(Me.TXT_PRECIO)
        Me.Controls.Add(Me.TXT_DESCRIPCION)
        Me.Controls.Add(Me.TXT_CODIGO)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "NOTA_DE_CREDITO"
        Me.Text = "NOTA_DE_CREDITO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXT_CANTIDAD As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents BTN_CANCELAR As Button
    Friend WithEvents BTN_ACEPTAR As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents TXT_IMPORTE As TextBox
    Friend WithEvents TXT_DESCUENTO As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TXT_RUT As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TXT_DOMICILIO As TextBox
    Friend WithEvents TXT_NOMBRE As TextBox
    Friend WithEvents TXT_CUENTA As TextBox
    Friend WithEvents BTN_CUENTA As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TXT_SERIE As TextBox
    Friend WithEvents TXT_NRO_DOC As TextBox
    Friend WithEvents LBL_TOTAL As Label
    Friend WithEvents LBL_IVA As Label
    Friend WithEvents LBL_SUBTOTAL As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents CODIGO As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BTN_ELIMINA As Button
    Friend WithEvents BTN_AGREGA As Button
    Friend WithEvents TXT_PRECIO As TextBox
    Friend WithEvents TXT_DESCRIPCION As TextBox
    Friend WithEvents TXT_CODIGO As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
