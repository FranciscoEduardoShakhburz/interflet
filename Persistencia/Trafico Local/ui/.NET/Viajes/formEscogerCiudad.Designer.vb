<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formEscogerCiudad
    Inherits System.Windows.Forms.Form


    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub


    Private components As System.ComponentModel.IContainer




    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.comboCiudades = New System.Windows.Forms.ComboBox
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(120, 65)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(108, 44)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Controls.Add(Me.btnAceptar)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.comboCiudades)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(238, 131)
        Me.Panel1.TabIndex = 3
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(6, 65)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(108, 44)
        Me.btnAceptar.TabIndex = 2
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "¿Desea Cargar datos de otra Ciudad?"
        '
        'comboCiudades
        '
        Me.comboCiudades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboCiudades.FormattingEnabled = True
        Me.comboCiudades.Items.AddRange(New Object() {"Selecciona una ciudad disponible....", "Altamira", "Manzanillo", "Veracruz"})
        Me.comboCiudades.Location = New System.Drawing.Point(6, 28)
        Me.comboCiudades.Name = "comboCiudades"
        Me.comboCiudades.Size = New System.Drawing.Size(222, 21)
        Me.comboCiudades.TabIndex = 1
        '
        'formEscogerCiudad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(254, 153)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "formEscogerCiudad"
        Me.Text = "Cargar Datos Externos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents comboCiudades As System.Windows.Forms.ComboBox
End Class
