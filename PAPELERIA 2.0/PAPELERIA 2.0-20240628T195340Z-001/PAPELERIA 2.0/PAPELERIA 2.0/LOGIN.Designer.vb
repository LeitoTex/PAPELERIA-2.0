﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LOGIN
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
        Me.TXT_PASS = New System.Windows.Forms.TextBox()
        Me.TXT_USER = New System.Windows.Forms.TextBox()
        Me.LBL_PASS = New System.Windows.Forms.Label()
        Me.LBL_USUARIO = New System.Windows.Forms.Label()
        Me.BTN_CANCELAR = New System.Windows.Forms.Button()
        Me.BTN_OK = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TXT_PASS
        '
        Me.TXT_PASS.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.TXT_PASS.Location = New System.Drawing.Point(348, 114)
        Me.TXT_PASS.Name = "TXT_PASS"
        Me.TXT_PASS.Size = New System.Drawing.Size(174, 24)
        Me.TXT_PASS.TabIndex = 2
        Me.TXT_PASS.Text = "456"
        '
        'TXT_USER
        '
        Me.TXT_USER.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.TXT_USER.Location = New System.Drawing.Point(348, 69)
        Me.TXT_USER.Name = "TXT_USER"
        Me.TXT_USER.Size = New System.Drawing.Size(174, 24)
        Me.TXT_USER.TabIndex = 1
        Me.TXT_USER.Text = "leito"
        '
        'LBL_PASS
        '
        Me.LBL_PASS.AutoSize = True
        Me.LBL_PASS.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.LBL_PASS.Location = New System.Drawing.Point(154, 121)
        Me.LBL_PASS.Name = "LBL_PASS"
        Me.LBL_PASS.Size = New System.Drawing.Size(100, 18)
        Me.LBL_PASS.TabIndex = 10
        Me.LBL_PASS.Text = "PASSWORD:"
        '
        'LBL_USUARIO
        '
        Me.LBL_USUARIO.AutoSize = True
        Me.LBL_USUARIO.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.LBL_USUARIO.Location = New System.Drawing.Point(154, 77)
        Me.LBL_USUARIO.Name = "LBL_USUARIO"
        Me.LBL_USUARIO.Size = New System.Drawing.Size(79, 18)
        Me.LBL_USUARIO.TabIndex = 9
        Me.LBL_USUARIO.Text = "USUARIO:"
        '
        'BTN_CANCELAR
        '
        Me.BTN_CANCELAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.BTN_CANCELAR.Location = New System.Drawing.Point(348, 185)
        Me.BTN_CANCELAR.Name = "BTN_CANCELAR"
        Me.BTN_CANCELAR.Size = New System.Drawing.Size(129, 43)
        Me.BTN_CANCELAR.TabIndex = 4
        Me.BTN_CANCELAR.Text = "CANCELAR"
        Me.BTN_CANCELAR.UseVisualStyleBackColor = True
        '
        'BTN_OK
        '
        Me.BTN_OK.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.BTN_OK.Location = New System.Drawing.Point(158, 184)
        Me.BTN_OK.Name = "BTN_OK"
        Me.BTN_OK.Size = New System.Drawing.Size(127, 43)
        Me.BTN_OK.TabIndex = 3
        Me.BTN_OK.Text = "OK"
        Me.BTN_OK.UseVisualStyleBackColor = True
        '
        'LOGIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 340)
        Me.Controls.Add(Me.TXT_PASS)
        Me.Controls.Add(Me.TXT_USER)
        Me.Controls.Add(Me.LBL_PASS)
        Me.Controls.Add(Me.LBL_USUARIO)
        Me.Controls.Add(Me.BTN_CANCELAR)
        Me.Controls.Add(Me.BTN_OK)
        Me.Name = "LOGIN"
        Me.Text = "LOGIN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXT_PASS As TextBox
    Friend WithEvents TXT_USER As TextBox
    Friend WithEvents LBL_PASS As Label
    Friend WithEvents LBL_USUARIO As Label
    Friend WithEvents BTN_CANCELAR As Button
    Friend WithEvents BTN_OK As Button
End Class
