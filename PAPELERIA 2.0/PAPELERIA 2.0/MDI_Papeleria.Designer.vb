<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MDI_Papeleria
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.btn_lgout = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REGISTRARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PROVEEDORToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CLIENTEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.USUARIOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BTN_CONTADOS = New System.Windows.Forms.Button()
        Me.BTN_CREDITO = New System.Windows.Forms.Button()
        Me.BTN_DEVOLUCION = New System.Windows.Forms.Button()
        Me.BTN_NOTA = New System.Windows.Forms.Button()
        Me.StatusStrip.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 292)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(670, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(42, 17)
        Me.ToolStripStatusLabel.Text = "Estado"
        '
        'btn_lgout
        '
        Me.btn_lgout.Location = New System.Drawing.Point(547, 227)
        Me.btn_lgout.Name = "btn_lgout"
        Me.btn_lgout.Size = New System.Drawing.Size(62, 46)
        Me.btn_lgout.TabIndex = 11
        Me.btn_lgout.Text = "LOGOUT"
        Me.btn_lgout.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComprasToolStripMenuItem, Me.REGISTRARToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(670, 24)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ComprasToolStripMenuItem
        '
        Me.ComprasToolStripMenuItem.Name = "ComprasToolStripMenuItem"
        Me.ComprasToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.ComprasToolStripMenuItem.Text = "Compras"
        '
        'REGISTRARToolStripMenuItem
        '
        Me.REGISTRARToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PROVEEDORToolStripMenuItem, Me.CLIENTEToolStripMenuItem, Me.USUARIOToolStripMenuItem})
        Me.REGISTRARToolStripMenuItem.Name = "REGISTRARToolStripMenuItem"
        Me.REGISTRARToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.REGISTRARToolStripMenuItem.Text = "Registrar"
        '
        'PROVEEDORToolStripMenuItem
        '
        Me.PROVEEDORToolStripMenuItem.Name = "PROVEEDORToolStripMenuItem"
        Me.PROVEEDORToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.PROVEEDORToolStripMenuItem.Text = "PROVEEDOR"
        '
        'CLIENTEToolStripMenuItem
        '
        Me.CLIENTEToolStripMenuItem.Name = "CLIENTEToolStripMenuItem"
        Me.CLIENTEToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.CLIENTEToolStripMenuItem.Text = "CLIENTE"
        '
        'USUARIOToolStripMenuItem
        '
        Me.USUARIOToolStripMenuItem.Name = "USUARIOToolStripMenuItem"
        Me.USUARIOToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.USUARIOToolStripMenuItem.Text = "USUARIO"
        '
        'BTN_CONTADOS
        '
        Me.BTN_CONTADOS.Location = New System.Drawing.Point(12, 46)
        Me.BTN_CONTADOS.Name = "BTN_CONTADOS"
        Me.BTN_CONTADOS.Size = New System.Drawing.Size(76, 45)
        Me.BTN_CONTADOS.TabIndex = 15
        Me.BTN_CONTADOS.Text = "CONTADO"
        Me.BTN_CONTADOS.UseVisualStyleBackColor = True
        '
        'BTN_CREDITO
        '
        Me.BTN_CREDITO.Location = New System.Drawing.Point(94, 46)
        Me.BTN_CREDITO.Name = "BTN_CREDITO"
        Me.BTN_CREDITO.Size = New System.Drawing.Size(76, 45)
        Me.BTN_CREDITO.TabIndex = 17
        Me.BTN_CREDITO.Text = "CREDITO"
        Me.BTN_CREDITO.UseVisualStyleBackColor = True
        '
        'BTN_DEVOLUCION
        '
        Me.BTN_DEVOLUCION.Location = New System.Drawing.Point(243, 46)
        Me.BTN_DEVOLUCION.Name = "BTN_DEVOLUCION"
        Me.BTN_DEVOLUCION.Size = New System.Drawing.Size(96, 45)
        Me.BTN_DEVOLUCION.TabIndex = 19
        Me.BTN_DEVOLUCION.Text = "DEVOLUCIÓN"
        Me.BTN_DEVOLUCION.UseVisualStyleBackColor = True
        '
        'BTN_NOTA
        '
        Me.BTN_NOTA.Location = New System.Drawing.Point(360, 46)
        Me.BTN_NOTA.Name = "BTN_NOTA"
        Me.BTN_NOTA.Size = New System.Drawing.Size(76, 45)
        Me.BTN_NOTA.TabIndex = 20
        Me.BTN_NOTA.Text = "NOTA DE CREDITO"
        Me.BTN_NOTA.UseVisualStyleBackColor = True
        '
        'MDI_Papeleria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 314)
        Me.Controls.Add(Me.BTN_NOTA)
        Me.Controls.Add(Me.BTN_DEVOLUCION)
        Me.Controls.Add(Me.BTN_CREDITO)
        Me.Controls.Add(Me.BTN_CONTADOS)
        Me.Controls.Add(Me.btn_lgout)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.Name = "MDI_Papeleria"
        Me.Text = "NUEVO SOL"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents btn_lgout As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ComprasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BTN_CONTADOS As Button
    Friend WithEvents BTN_CREDITO As Button
    Friend WithEvents REGISTRARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PROVEEDORToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CLIENTEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents USUARIOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BTN_DEVOLUCION As Button
    Friend WithEvents BTN_NOTA As Button
End Class
