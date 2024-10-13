<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ESTADO_DE_CUENTA_2
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnaplicarfiltro = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DateTimePickerINICIO = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerfin = New System.Windows.Forms.DateTimePicker()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(151, 81)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(97, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'btnaplicarfiltro
        '
        Me.btnaplicarfiltro.Location = New System.Drawing.Point(257, 79)
        Me.btnaplicarfiltro.Name = "btnaplicarfiltro"
        Me.btnaplicarfiltro.Size = New System.Drawing.Size(75, 23)
        Me.btnaplicarfiltro.TabIndex = 2
        Me.btnaplicarfiltro.Text = "Button1"
        Me.btnaplicarfiltro.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(216, 170)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView1.TabIndex = 3
        '
        'DateTimePickerINICIO
        '
        Me.DateTimePickerINICIO.Location = New System.Drawing.Point(508, 68)
        Me.DateTimePickerINICIO.Name = "DateTimePickerINICIO"
        Me.DateTimePickerINICIO.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePickerINICIO.TabIndex = 4
        '
        'DateTimePickerfin
        '
        Me.DateTimePickerfin.Location = New System.Drawing.Point(512, 123)
        Me.DateTimePickerfin.Name = "DateTimePickerfin"
        Me.DateTimePickerfin.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePickerfin.TabIndex = 5
        '
        'ESTADO_DE_CUENTA_2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DateTimePickerfin)
        Me.Controls.Add(Me.DateTimePickerINICIO)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnaplicarfiltro)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "ESTADO_DE_CUENTA_2"
        Me.Text = "ESTADO_DE_CUENTA_2"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnaplicarfiltro As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DateTimePickerINICIO As DateTimePicker
    Friend WithEvents DateTimePickerfin As DateTimePicker
End Class
