<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Buscador
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
        Me.components = New System.ComponentModel.Container()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btn_agrega = New System.Windows.Forms.Button()
        Me.PapeleriaDataSet = New PAPELERIA_2._0.papeleriaDataSet()
        Me.PapeleriaDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.detalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PapeleriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PapeleriaDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(132, 54)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(446, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "BUSCAR:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.detalle, Me.cantidad, Me.precio})
        Me.DataGridView1.DataSource = Me.PapeleriaDataSetBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(75, 100)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(502, 204)
        Me.DataGridView1.TabIndex = 2
        '
        'btn_agrega
        '
        Me.btn_agrega.Location = New System.Drawing.Point(584, 52)
        Me.btn_agrega.Name = "btn_agrega"
        Me.btn_agrega.Size = New System.Drawing.Size(75, 23)
        Me.btn_agrega.TabIndex = 3
        Me.btn_agrega.Text = "Button1"
        Me.btn_agrega.UseVisualStyleBackColor = True
        '
        'PapeleriaDataSet
        '
        Me.PapeleriaDataSet.DataSetName = "papeleriaDataSet"
        Me.PapeleriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PapeleriaDataSetBindingSource
        '
        Me.PapeleriaDataSetBindingSource.DataSource = Me.PapeleriaDataSet
        Me.PapeleriaDataSetBindingSource.Position = 0
        '
        'codigo
        '
        Me.codigo.HeaderText = "codigo"
        Me.codigo.Name = "codigo"
        '
        'detalle
        '
        Me.detalle.HeaderText = "detalle"
        Me.detalle.Name = "detalle"
        '
        'cantidad
        '
        Me.cantidad.HeaderText = "cantidad"
        Me.cantidad.Name = "cantidad"
        '
        'precio
        '
        Me.precio.HeaderText = "precio"
        Me.precio.Name = "precio"
        '
        'Buscador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 338)
        Me.Controls.Add(Me.btn_agrega)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Buscador"
        Me.Text = "buscador"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PapeleriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PapeleriaDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_agrega As Button
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents detalle As DataGridViewTextBoxColumn
    Friend WithEvents PapeleriaDataSetBindingSource As BindingSource
    Friend WithEvents PapeleriaDataSet As papeleriaDataSet
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents precio As DataGridViewTextBoxColumn
End Class
