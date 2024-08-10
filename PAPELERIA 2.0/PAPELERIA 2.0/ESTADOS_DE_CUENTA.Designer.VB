<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ESTADOS_DE_CUENTA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ESTADOS_DE_CUENTA))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.LBL_NUMERO_CUENTA = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BTN_CANCELAR = New System.Windows.Forms.Button()
        Me.btn_fin = New System.Windows.Forms.Button()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CMB_TIPO_OPERACION = New System.Windows.Forms.ComboBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.BTN_BUSCAR = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_NUMERO_CUENTA = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.DateTimePicker_HASTA = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker_DESDE = New System.Windows.Forms.DateTimePicker()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(802, -7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 83)
        Me.PictureBox1.TabIndex = 55
        Me.PictureBox1.TabStop = False
        '
        'lbl_usuario
        '
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_usuario.Location = New System.Drawing.Point(731, -4)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(20, 25)
        Me.lbl_usuario.TabIndex = 54
        Me.lbl_usuario.Text = "*"
        '
        'LBL_NUMERO_CUENTA
        '
        Me.LBL_NUMERO_CUENTA.AutoSize = True
        Me.LBL_NUMERO_CUENTA.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_NUMERO_CUENTA.Location = New System.Drawing.Point(533, -4)
        Me.LBL_NUMERO_CUENTA.Name = "LBL_NUMERO_CUENTA"
        Me.LBL_NUMERO_CUENTA.Size = New System.Drawing.Size(23, 25)
        Me.LBL_NUMERO_CUENTA.TabIndex = 53
        Me.LBL_NUMERO_CUENTA.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(302, -4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(225, 25)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "NUMERO DE CUENTA:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(606, -4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 25)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "USUARIO:"
        '
        'BTN_CANCELAR
        '
        Me.BTN_CANCELAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CANCELAR.Location = New System.Drawing.Point(737, 240)
        Me.BTN_CANCELAR.Name = "BTN_CANCELAR"
        Me.BTN_CANCELAR.Size = New System.Drawing.Size(132, 40)
        Me.BTN_CANCELAR.TabIndex = 50
        Me.BTN_CANCELAR.Text = "CANCELAR"
        Me.BTN_CANCELAR.UseVisualStyleBackColor = True
        '
        'btn_fin
        '
        Me.btn_fin.Font = New System.Drawing.Font("Garamond", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_fin.Location = New System.Drawing.Point(737, 428)
        Me.btn_fin.Name = "btn_fin"
        Me.btn_fin.Size = New System.Drawing.Size(132, 44)
        Me.btn_fin.TabIndex = 49
        Me.btn_fin.Text = "FIN"
        Me.btn_fin.UseVisualStyleBackColor = True
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Location = New System.Drawing.Point(-76, 226)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(101, 264)
        Me.ListBox3.TabIndex = 48
        Me.ListBox3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(44, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(232, 25)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "TIPO DE MOVIMIENTO:"
        '
        'CMB_TIPO_OPERACION
        '
        Me.CMB_TIPO_OPERACION.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMB_TIPO_OPERACION.FormattingEnabled = True
        Me.CMB_TIPO_OPERACION.Items.AddRange(New Object() {"DEPOSITO ", "RETIRO"})
        Me.CMB_TIPO_OPERACION.Location = New System.Drawing.Point(307, 51)
        Me.CMB_TIPO_OPERACION.Name = "CMB_TIPO_OPERACION"
        Me.CMB_TIPO_OPERACION.Size = New System.Drawing.Size(244, 33)
        Me.CMB_TIPO_OPERACION.TabIndex = 46
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(-78, 123)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(101, 264)
        Me.ListBox2.TabIndex = 45
        Me.ListBox2.Visible = False
        '
        'BTN_BUSCAR
        '
        Me.BTN_BUSCAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_BUSCAR.Location = New System.Drawing.Point(737, 120)
        Me.BTN_BUSCAR.Name = "BTN_BUSCAR"
        Me.BTN_BUSCAR.Size = New System.Drawing.Size(132, 40)
        Me.BTN_BUSCAR.TabIndex = 44
        Me.BTN_BUSCAR.Text = "BUSCAR"
        Me.BTN_BUSCAR.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(-81, -40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(199, 25)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "NOMBRE USUARIO:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(374, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 25)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "HASTA:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(44, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 25)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "DESDE:"
        '
        'TXT_NUMERO_CUENTA
        '
        Me.TXT_NUMERO_CUENTA.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_NUMERO_CUENTA.Location = New System.Drawing.Point(-78, -7)
        Me.TXT_NUMERO_CUENTA.Name = "TXT_NUMERO_CUENTA"
        Me.TXT_NUMERO_CUENTA.Size = New System.Drawing.Size(299, 30)
        Me.TXT_NUMERO_CUENTA.TabIndex = 40
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(-78, 42)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(94, 238)
        Me.ListBox1.TabIndex = 39
        '
        'DGV1
        '
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Location = New System.Drawing.Point(49, 181)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.Size = New System.Drawing.Size(652, 291)
        Me.DGV1.TabIndex = 38
        '
        'DateTimePicker_HASTA
        '
        Me.DateTimePicker_HASTA.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_HASTA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_HASTA.Location = New System.Drawing.Point(467, 123)
        Me.DateTimePicker_HASTA.Name = "DateTimePicker_HASTA"
        Me.DateTimePicker_HASTA.Size = New System.Drawing.Size(234, 30)
        Me.DateTimePicker_HASTA.TabIndex = 37
        Me.DateTimePicker_HASTA.Value = New Date(2023, 12, 7, 18, 23, 20, 0)
        '
        'DateTimePicker_DESDE
        '
        Me.DateTimePicker_DESDE.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_DESDE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_DESDE.Location = New System.Drawing.Point(153, 123)
        Me.DateTimePicker_DESDE.Name = "DateTimePicker_DESDE"
        Me.DateTimePicker_DESDE.Size = New System.Drawing.Size(200, 30)
        Me.DateTimePicker_DESDE.TabIndex = 36
        Me.DateTimePicker_DESDE.Value = New Date(2023, 1, 1, 0, 0, 0, 0)
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 557)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(910, 22)
        Me.StatusStrip1.TabIndex = 35
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ESTADOS_DE_CUENTA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(910, 579)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_usuario)
        Me.Controls.Add(Me.LBL_NUMERO_CUENTA)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BTN_CANCELAR)
        Me.Controls.Add(Me.btn_fin)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CMB_TIPO_OPERACION)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.BTN_BUSCAR)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXT_NUMERO_CUENTA)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.DGV1)
        Me.Controls.Add(Me.DateTimePicker_HASTA)
        Me.Controls.Add(Me.DateTimePicker_DESDE)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "ESTADOS_DE_CUENTA"
        Me.Text = "ESTADOS_DE_CUENTA"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_usuario As Label
    Friend WithEvents LBL_NUMERO_CUENTA As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BTN_CANCELAR As Button
    Friend WithEvents btn_fin As Button
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CMB_TIPO_OPERACION As ComboBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents BTN_BUSCAR As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_NUMERO_CUENTA As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents DateTimePicker_HASTA As DateTimePicker
    Friend WithEvents DateTimePicker_DESDE As DateTimePicker
    Friend WithEvents StatusStrip1 As StatusStrip
End Class
