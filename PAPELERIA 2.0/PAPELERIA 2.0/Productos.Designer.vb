<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Productos
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
        Me.BTN_ACEPTAR = New System.Windows.Forms.Button()
        Me.BTN_CANCELAR = New System.Windows.Forms.Button()
        Me.BTN_MODIFICAR = New System.Windows.Forms.Button()
        Me.BTN_ELIMINAR = New System.Windows.Forms.Button()
        Me.LABEL = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXT_CODIGO = New System.Windows.Forms.TextBox()
        Me.TXT_NOMBRE = New System.Windows.Forms.TextBox()
        Me.TXT_CAPITULO = New System.Windows.Forms.TextBox()
        Me.TXT_PRECIO_COSTO = New System.Windows.Forms.TextBox()
        Me.TXT_PRECIO_VENTA = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'BTN_ACEPTAR
        '
        Me.BTN_ACEPTAR.Location = New System.Drawing.Point(353, 56)
        Me.BTN_ACEPTAR.Name = "BTN_ACEPTAR"
        Me.BTN_ACEPTAR.Size = New System.Drawing.Size(87, 22)
        Me.BTN_ACEPTAR.TabIndex = 0
        Me.BTN_ACEPTAR.Text = "ACEPTAR"
        Me.BTN_ACEPTAR.UseVisualStyleBackColor = True
        '
        'BTN_CANCELAR
        '
        Me.BTN_CANCELAR.Location = New System.Drawing.Point(353, 126)
        Me.BTN_CANCELAR.Name = "BTN_CANCELAR"
        Me.BTN_CANCELAR.Size = New System.Drawing.Size(87, 22)
        Me.BTN_CANCELAR.TabIndex = 1
        Me.BTN_CANCELAR.Text = "CANCELAR"
        Me.BTN_CANCELAR.UseVisualStyleBackColor = True
        '
        'BTN_MODIFICAR
        '
        Me.BTN_MODIFICAR.Location = New System.Drawing.Point(353, 91)
        Me.BTN_MODIFICAR.Name = "BTN_MODIFICAR"
        Me.BTN_MODIFICAR.Size = New System.Drawing.Size(87, 22)
        Me.BTN_MODIFICAR.TabIndex = 2
        Me.BTN_MODIFICAR.Text = "MODIFICAR"
        Me.BTN_MODIFICAR.UseVisualStyleBackColor = True
        '
        'BTN_ELIMINAR
        '
        Me.BTN_ELIMINAR.Location = New System.Drawing.Point(353, 161)
        Me.BTN_ELIMINAR.Name = "BTN_ELIMINAR"
        Me.BTN_ELIMINAR.Size = New System.Drawing.Size(87, 22)
        Me.BTN_ELIMINAR.TabIndex = 3
        Me.BTN_ELIMINAR.Text = "ELIMINAR"
        Me.BTN_ELIMINAR.UseVisualStyleBackColor = True
        '
        'LABEL
        '
        Me.LABEL.AutoSize = True
        Me.LABEL.Location = New System.Drawing.Point(57, 57)
        Me.LABEL.Name = "LABEL"
        Me.LABEL.Size = New System.Drawing.Size(49, 13)
        Me.LABEL.TabIndex = 4
        Me.LABEL.Tag = ""
        Me.LABEL.Text = "CODIGO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "NOMBRE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(57, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "CAPITULO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(57, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "PRECIO COSTO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(57, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "PRECIO VENTA"
        '
        'TXT_CODIGO
        '
        Me.TXT_CODIGO.Location = New System.Drawing.Point(154, 57)
        Me.TXT_CODIGO.Name = "TXT_CODIGO"
        Me.TXT_CODIGO.Size = New System.Drawing.Size(177, 20)
        Me.TXT_CODIGO.TabIndex = 9
        '
        'TXT_NOMBRE
        '
        Me.TXT_NOMBRE.Location = New System.Drawing.Point(154, 95)
        Me.TXT_NOMBRE.Name = "TXT_NOMBRE"
        Me.TXT_NOMBRE.Size = New System.Drawing.Size(177, 20)
        Me.TXT_NOMBRE.TabIndex = 11
        '
        'TXT_CAPITULO
        '
        Me.TXT_CAPITULO.Location = New System.Drawing.Point(154, 133)
        Me.TXT_CAPITULO.Name = "TXT_CAPITULO"
        Me.TXT_CAPITULO.Size = New System.Drawing.Size(177, 20)
        Me.TXT_CAPITULO.TabIndex = 12
        '
        'TXT_PRECIO_COSTO
        '
        Me.TXT_PRECIO_COSTO.Location = New System.Drawing.Point(154, 171)
        Me.TXT_PRECIO_COSTO.Name = "TXT_PRECIO_COSTO"
        Me.TXT_PRECIO_COSTO.Size = New System.Drawing.Size(177, 20)
        Me.TXT_PRECIO_COSTO.TabIndex = 13
        '
        'TXT_PRECIO_VENTA
        '
        Me.TXT_PRECIO_VENTA.Location = New System.Drawing.Point(154, 209)
        Me.TXT_PRECIO_VENTA.Name = "TXT_PRECIO_VENTA"
        Me.TXT_PRECIO_VENTA.Size = New System.Drawing.Size(177, 20)
        Me.TXT_PRECIO_VENTA.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(541, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "CODIGO DE BARRAS"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(541, 85)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(144, 134)
        Me.ListBox1.TabIndex = 16
        '
        'Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXT_PRECIO_VENTA)
        Me.Controls.Add(Me.TXT_PRECIO_COSTO)
        Me.Controls.Add(Me.TXT_CAPITULO)
        Me.Controls.Add(Me.TXT_NOMBRE)
        Me.Controls.Add(Me.TXT_CODIGO)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LABEL)
        Me.Controls.Add(Me.BTN_ELIMINAR)
        Me.Controls.Add(Me.BTN_MODIFICAR)
        Me.Controls.Add(Me.BTN_CANCELAR)
        Me.Controls.Add(Me.BTN_ACEPTAR)
        Me.Name = "Productos"
        Me.Text = "Productos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_ACEPTAR As Button
    Friend WithEvents BTN_CANCELAR As Button
    Friend WithEvents BTN_MODIFICAR As Button
    Friend WithEvents BTN_ELIMINAR As Button
    Friend WithEvents LABEL As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TXT_CODIGO As TextBox
    Friend WithEvents TXT_NOMBRE As TextBox
    Friend WithEvents TXT_CAPITULO As TextBox
    Friend WithEvents TXT_PRECIO_COSTO As TextBox
    Friend WithEvents TXT_PRECIO_VENTA As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
End Class
