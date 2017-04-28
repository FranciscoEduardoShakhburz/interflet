<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formGastosPorRuta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formGastosPorRuta))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtRuta = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.grid_totales = New System.Windows.Forms.DataGridView
        Me.bto_consultar = New System.Windows.Forms.Button
        Me.FechaF = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.FechaI = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtManiobras = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtPension = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.radioCamioneta = New System.Windows.Forms.RadioButton
        Me.radioTracto = New System.Windows.Forms.RadioButton
        Me.btnSolicitud = New System.Windows.Forms.Button
        Me.btnSobres = New System.Windows.Forms.Button
        Me.btnExportar = New System.Windows.Forms.Button
        Me.btnAgregar = New System.Windows.Forms.Button
        Me.txtCantidadViajes = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.comboConfigViaje = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.gridGastosRuta = New System.Windows.Forms.DataGridView
        Me.btnSalir = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.grid_totales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.gridGastosRuta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtRuta)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.grid_totales)
        Me.GroupBox1.Controls.Add(Me.bto_consultar)
        Me.GroupBox1.Controls.Add(Me.FechaF)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.FechaI)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtManiobras)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtPension)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Controls.Add(Me.radioCamioneta)
        Me.GroupBox1.Controls.Add(Me.radioTracto)
        Me.GroupBox1.Controls.Add(Me.btnSolicitud)
        Me.GroupBox1.Controls.Add(Me.btnSobres)
        Me.GroupBox1.Controls.Add(Me.btnExportar)
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Controls.Add(Me.txtCantidadViajes)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.comboConfigViaje)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.btnSalir)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1162, 585)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gastos Por Ruta"
        '
        'txtRuta
        '
        Me.txtRuta.Location = New System.Drawing.Point(63, 20)
        Me.txtRuta.Name = "txtRuta"
        Me.txtRuta.Size = New System.Drawing.Size(217, 20)
        Me.txtRuta.TabIndex = 1
        Me.txtRuta.Text = "0"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(981, 480)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 52)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Sol. de Transf."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(37, 404)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 15)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "TOTALES"
        '
        'grid_totales
        '
        Me.grid_totales.AllowUserToAddRows = False
        Me.grid_totales.AllowUserToDeleteRows = False
        Me.grid_totales.AllowUserToOrderColumns = True
        Me.grid_totales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_totales.Location = New System.Drawing.Point(25, 422)
        Me.grid_totales.Name = "grid_totales"
        Me.grid_totales.ReadOnly = True
        Me.grid_totales.Size = New System.Drawing.Size(869, 155)
        Me.grid_totales.TabIndex = 22
        '
        'bto_consultar
        '
        Me.bto_consultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bto_consultar.Location = New System.Drawing.Point(346, 47)
        Me.bto_consultar.Name = "bto_consultar"
        Me.bto_consultar.Size = New System.Drawing.Size(75, 23)
        Me.bto_consultar.TabIndex = 21
        Me.bto_consultar.Text = "Consultar"
        Me.bto_consultar.UseVisualStyleBackColor = True
        '
        'FechaF
        '
        Me.FechaF.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaF.Location = New System.Drawing.Point(216, 48)
        Me.FechaF.Name = "FechaF"
        Me.FechaF.Size = New System.Drawing.Size(96, 20)
        Me.FechaF.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(191, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(19, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "A:"
        '
        'FechaI
        '
        Me.FechaI.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaI.Location = New System.Drawing.Point(63, 48)
        Me.FechaI.Name = "FechaI"
        Me.FechaI.Size = New System.Drawing.Size(97, 20)
        Me.FechaI.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "DE:"
        '
        'txtManiobras
        '
        Me.txtManiobras.Location = New System.Drawing.Point(822, 52)
        Me.txtManiobras.Name = "txtManiobras"
        Me.txtManiobras.Size = New System.Drawing.Size(72, 20)
        Me.txtManiobras.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(747, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Maniobras:"
        '
        'txtPension
        '
        Me.txtPension.Location = New System.Drawing.Point(822, 27)
        Me.txtPension.Name = "txtPension"
        Me.txtPension.Size = New System.Drawing.Size(72, 20)
        Me.txtPension.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(760, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Pensión:"
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(1062, 20)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 52)
        Me.btnGuardar.TabIndex = 10
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'radioCamioneta
        '
        Me.radioCamioneta.AutoSize = True
        Me.radioCamioneta.Location = New System.Drawing.Point(646, 53)
        Me.radioCamioneta.Name = "radioCamioneta"
        Me.radioCamioneta.Size = New System.Drawing.Size(75, 17)
        Me.radioCamioneta.TabIndex = 12
        Me.radioCamioneta.TabStop = True
        Me.radioCamioneta.Text = "Camioneta"
        Me.radioCamioneta.UseVisualStyleBackColor = True
        '
        'radioTracto
        '
        Me.radioTracto.AutoSize = True
        Me.radioTracto.Location = New System.Drawing.Point(550, 53)
        Me.radioTracto.Name = "radioTracto"
        Me.radioTracto.Size = New System.Drawing.Size(94, 17)
        Me.radioTracto.TabIndex = 11
        Me.radioTracto.TabStop = True
        Me.radioTracto.Text = "Tracto Camión"
        Me.radioTracto.UseVisualStyleBackColor = True
        '
        'btnSolicitud
        '
        Me.btnSolicitud.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSolicitud.Location = New System.Drawing.Point(981, 49)
        Me.btnSolicitud.Name = "btnSolicitud"
        Me.btnSolicitud.Size = New System.Drawing.Size(75, 23)
        Me.btnSolicitud.TabIndex = 9
        Me.btnSolicitud.Text = " Plan Ruta"
        Me.btnSolicitud.UseVisualStyleBackColor = True
        '
        'btnSobres
        '
        Me.btnSobres.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSobres.Location = New System.Drawing.Point(900, 49)
        Me.btnSobres.Name = "btnSobres"
        Me.btnSobres.Size = New System.Drawing.Size(75, 23)
        Me.btnSobres.TabIndex = 8
        Me.btnSobres.Text = "Sobres"
        Me.btnSobres.UseVisualStyleBackColor = True
        '
        'btnExportar
        '
        Me.btnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportar.Location = New System.Drawing.Point(981, 20)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(75, 23)
        Me.btnExportar.TabIndex = 7
        Me.btnExportar.Text = "Exportar"
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(900, 20)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 6
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txtCantidadViajes
        '
        Me.txtCantidadViajes.Location = New System.Drawing.Point(670, 27)
        Me.txtCantidadViajes.Name = "txtCantidadViajes"
        Me.txtCantidadViajes.Size = New System.Drawing.Size(72, 20)
        Me.txtCantidadViajes.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(547, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Cantidad de Viajes:"
        '
        'comboConfigViaje
        '
        Me.comboConfigViaje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboConfigViaje.FormattingEnabled = True
        Me.comboConfigViaje.Location = New System.Drawing.Point(413, 17)
        Me.comboConfigViaje.Name = "comboConfigViaje"
        Me.comboConfigViaje.Size = New System.Drawing.Size(121, 21)
        Me.comboConfigViaje.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(286, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Configuración Viaje:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ruta:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.gridGastosRuta)
        Me.GroupBox2.Location = New System.Drawing.Point(22, 76)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1113, 315)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Gastos"
        '
        'gridGastosRuta
        '
        Me.gridGastosRuta.AllowUserToAddRows = False
        Me.gridGastosRuta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridGastosRuta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridGastosRuta.Location = New System.Drawing.Point(18, 19)
        Me.gridGastosRuta.Name = "gridGastosRuta"
        Me.gridGastosRuta.Size = New System.Drawing.Size(1073, 290)
        Me.gridGastosRuta.TabIndex = 11
        '
        'btnSalir
        '
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(442, 234)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 9
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'formGastosPorRuta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(1187, 602)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "formGastosPorRuta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Módulo de Gastos por Ruta"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grid_totales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.gridGastosRuta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents comboConfigViaje As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtRuta As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSolicitud As System.Windows.Forms.Button
    Friend WithEvents btnSobres As System.Windows.Forms.Button
    Friend WithEvents btnExportar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents txtCantidadViajes As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gridGastosRuta As System.Windows.Forms.DataGridView
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents radioCamioneta As System.Windows.Forms.RadioButton
    Friend WithEvents radioTracto As System.Windows.Forms.RadioButton
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents txtManiobras As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPension As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents FechaF As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents FechaI As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents bto_consultar As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents grid_totales As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
