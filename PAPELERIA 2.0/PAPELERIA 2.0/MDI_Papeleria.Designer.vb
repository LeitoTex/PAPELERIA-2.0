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
        Me.OtrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BTN_CONTADOS = New System.Windows.Forms.Button()
        Me.BTN_CREDITO = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
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
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OtrosToolStripMenuItem, Me.ComprasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(670, 24)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OtrosToolStripMenuItem
        '
        Me.OtrosToolStripMenuItem.Name = "OtrosToolStripMenuItem"
        Me.OtrosToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.OtrosToolStripMenuItem.Text = "Ventas"
        '
        'ComprasToolStripMenuItem
        '
        Me.ComprasToolStripMenuItem.Name = "ComprasToolStripMenuItem"
        Me.ComprasToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.ComprasToolStripMenuItem.Text = "Compras"
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(176, 46)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 45)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "CREDITO"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MDI_Papeleria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 314)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BTN_CREDITO)
        Me.Controls.Add(Me.BTN_CONTADOS)
        Me.Controls.Add(Me.btn_lgout)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.Name = "MDI_Papeleria"
        Me.Text = "MDI_Papeleria"
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
    Friend WithEvents OtrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BTN_CONTADOS As Button
    Friend WithEvents BTN_CREDITO As Button
    Friend WithEvents Button1 As Button
End Class
