<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaseFacturacion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_Guia = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_fec_guia = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt_cliente = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_fec_pase = New System.Windows.Forms.TextBox
        Me.bto_rechazar = New System.Windows.Forms.Button
        Me.bto_salir = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_observaciones = New System.Windows.Forms.TextBox
        Me.bto_guardar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No.Guia"
        '
        'txt_Guia
        '
        Me.txt_Guia.Location = New System.Drawing.Point(75, 12)
        Me.txt_Guia.MaxLength = 10
        Me.txt_Guia.Name = "txt_Guia"
        Me.txt_Guia.Size = New System.Drawing.Size(96, 20)
        Me.txt_Guia.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(271, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha Guia"
        '
        'txt_fec_guia
        '
        Me.txt_fec_guia.Enabled = False
        Me.txt_fec_guia.Location = New System.Drawing.Point(385, 12)
        Me.txt_fec_guia.Name = "txt_fec_guia"
        Me.txt_fec_guia.Size = New System.Drawing.Size(135, 20)
        Me.txt_fec_guia.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Cliente"
        '
        'txt_cliente
        '
        Me.txt_cliente.Enabled = False
        Me.txt_cliente.Location = New System.Drawing.Point(75, 52)
        Me.txt_cliente.Name = "txt_cliente"
        Me.txt_cliente.Size = New System.Drawing.Size(164, 20)
        Me.txt_cliente.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(271, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Fecha Pase"
        '
        'txt_fec_pase
        '
        Me.txt_fec_pase.Enabled = False
        Me.txt_fec_pase.Location = New System.Drawing.Point(385, 55)
        Me.txt_fec_pase.Name = "txt_fec_pase"
        Me.txt_fec_pase.Size = New System.Drawing.Size(135, 20)
        Me.txt_fec_pase.TabIndex = 7
        '
        'bto_rechazar
        '
        Me.bto_rechazar.Location = New System.Drawing.Point(75, 118)
        Me.bto_rechazar.Name = "bto_rechazar"
        Me.bto_rechazar.Size = New System.Drawing.Size(75, 23)
        Me.bto_rechazar.TabIndex = 8
        Me.bto_rechazar.Text = "Rechazar"
        Me.bto_rechazar.UseVisualStyleBackColor = True
        '
        'bto_salir
        '
        Me.bto_salir.Location = New System.Drawing.Point(75, 217)
        Me.bto_salir.Name = "bto_salir"
        Me.bto_salir.Size = New System.Drawing.Size(75, 23)
        Me.bto_salir.TabIndex = 9
        Me.bto_salir.Text = "Salir"
        Me.bto_salir.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(229, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Observaciones"
        '
        'txt_observaciones
        '
        Me.txt_observaciones.Enabled = False
        Me.txt_observaciones.Location = New System.Drawing.Point(232, 120)
        Me.txt_observaciones.Multiline = True
        Me.txt_observaciones.Name = "txt_observaciones"
        Me.txt_observaciones.Size = New System.Drawing.Size(319, 137)
        Me.txt_observaciones.TabIndex = 11
        '
        'bto_guardar
        '
        Me.bto_guardar.Location = New System.Drawing.Point(75, 166)
        Me.bto_guardar.Name = "bto_guardar"
        Me.bto_guardar.Size = New System.Drawing.Size(75, 23)
        Me.bto_guardar.TabIndex = 12
        Me.bto_guardar.Text = "Guardar"
        Me.bto_guardar.UseVisualStyleBackColor = True
        '
        'PaseFacturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(575, 278)
        Me.Controls.Add(Me.bto_guardar)
        Me.Controls.Add(Me.txt_observaciones)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.bto_salir)
        Me.Controls.Add(Me.bto_rechazar)
        Me.Controls.Add(Me.txt_fec_pase)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_cliente)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_fec_guia)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_Guia)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.Name = "PaseFacturacion"
        Me.Text = "Pase Facturacion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_Guia As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_fec_guia As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_cliente As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_fec_pase As System.Windows.Forms.TextBox
    Friend WithEvents bto_rechazar As System.Windows.Forms.Button
    Friend WithEvents bto_salir As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_observaciones As System.Windows.Forms.TextBox
    Friend WithEvents bto_guardar As System.Windows.Forms.Button

End Class
