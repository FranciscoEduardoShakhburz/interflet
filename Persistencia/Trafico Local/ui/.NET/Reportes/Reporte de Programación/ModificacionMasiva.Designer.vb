<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificacionMasiva
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModificacionMasiva))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rdBtnLocales = New System.Windows.Forms.RadioButton
        Me.rdBtnForaneos = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.dteFechaTraslado = New System.Windows.Forms.DateTimePicker
        Me.txtNoVisita = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtTerminal = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmbMinutos = New System.Windows.Forms.ComboBox
        Me.cmbHoras = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.dteFecha = New System.Windows.Forms.DateTimePicker
        Me.txtUnidad = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtPlacas = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtOperador = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.rdBtnBoleta = New System.Windows.Forms.RadioButton
        Me.rdBtnVisita = New System.Windows.Forms.RadioButton
        Me.txtBusqueda = New System.Windows.Forms.TextBox
        Me.rdBtnContenedor = New System.Windows.Forms.RadioButton
        Me.rdBtnReferencia = New System.Windows.Forms.RadioButton
        Me.gridCargas = New System.Windows.Forms.DataGridView
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnEliminar = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtBloque = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.gridCargas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rdBtnLocales)
        Me.GroupBox1.Controls.Add(Me.rdBtnForaneos)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(270, 71)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de carga"
        '
        'rdBtnLocales
        '
        Me.rdBtnLocales.AutoSize = True
        Me.rdBtnLocales.Location = New System.Drawing.Point(6, 42)
        Me.rdBtnLocales.Name = "rdBtnLocales"
        Me.rdBtnLocales.Size = New System.Drawing.Size(134, 17)
        Me.rdBtnLocales.TabIndex = 1
        Me.rdBtnLocales.TabStop = True
        Me.rdBtnLocales.Text = "Locales y traslados"
        Me.rdBtnLocales.UseVisualStyleBackColor = True
        '
        'rdBtnForaneos
        '
        Me.rdBtnForaneos.AutoSize = True
        Me.rdBtnForaneos.Location = New System.Drawing.Point(6, 19)
        Me.rdBtnForaneos.Name = "rdBtnForaneos"
        Me.rdBtnForaneos.Size = New System.Drawing.Size(77, 17)
        Me.rdBtnForaneos.TabIndex = 0
        Me.rdBtnForaneos.TabStop = True
        Me.rdBtnForaneos.Text = "Foraneos"
        Me.rdBtnForaneos.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.txtBloque)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.dteFechaTraslado)
        Me.GroupBox2.Controls.Add(Me.txtNoVisita)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtTerminal)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.cmbMinutos)
        Me.GroupBox2.Controls.Add(Me.cmbHoras)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.dteFecha)
        Me.GroupBox2.Controls.Add(Me.txtUnidad)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtPlacas)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtOperador)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(288, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(288, 170)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos a modificar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Fecha de traslado:"
        '
        'dteFechaTraslado
        '
        Me.dteFechaTraslado.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteFechaTraslado.Location = New System.Drawing.Point(128, 145)
        Me.dteFechaTraslado.Name = "dteFechaTraslado"
        Me.dteFechaTraslado.Size = New System.Drawing.Size(93, 20)
        Me.dteFechaTraslado.TabIndex = 17
        '
        'txtNoVisita
        '
        Me.txtNoVisita.Location = New System.Drawing.Point(91, 14)
        Me.txtNoVisita.Name = "txtNoVisita"
        Me.txtNoVisita.Size = New System.Drawing.Size(186, 20)
        Me.txtNoVisita.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "No. de visita"
        '
        'txtTerminal
        '
        Me.txtTerminal.Location = New System.Drawing.Point(68, 92)
        Me.txtTerminal.Name = "txtTerminal"
        Me.txtTerminal.Size = New System.Drawing.Size(76, 20)
        Me.txtTerminal.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Terminal"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(210, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(11, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = ":"
        '
        'cmbMinutos
        '
        Me.cmbMinutos.FormattingEnabled = True
        Me.cmbMinutos.Location = New System.Drawing.Point(227, 118)
        Me.cmbMinutos.Name = "cmbMinutos"
        Me.cmbMinutos.Size = New System.Drawing.Size(50, 21)
        Me.cmbMinutos.TabIndex = 11
        '
        'cmbHoras
        '
        Me.cmbHoras.FormattingEnabled = True
        Me.cmbHoras.Location = New System.Drawing.Point(153, 118)
        Me.cmbHoras.Name = "cmbHoras"
        Me.cmbHoras.Size = New System.Drawing.Size(51, 21)
        Me.cmbHoras.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Fecha"
        '
        'dteFecha
        '
        Me.dteFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteFecha.Location = New System.Drawing.Point(54, 119)
        Me.dteFecha.Name = "dteFecha"
        Me.dteFecha.Size = New System.Drawing.Size(93, 20)
        Me.dteFecha.TabIndex = 6
        '
        'txtUnidad
        '
        Me.txtUnidad.Location = New System.Drawing.Point(200, 66)
        Me.txtUnidad.Name = "txtUnidad"
        Me.txtUnidad.Size = New System.Drawing.Size(77, 20)
        Me.txtUnidad.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(147, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Unidad"
        '
        'txtPlacas
        '
        Me.txtPlacas.Location = New System.Drawing.Point(68, 66)
        Me.txtPlacas.Name = "txtPlacas"
        Me.txtPlacas.Size = New System.Drawing.Size(76, 20)
        Me.txtPlacas.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Placas"
        '
        'txtOperador
        '
        Me.txtOperador.Location = New System.Drawing.Point(68, 40)
        Me.txtOperador.Name = "txtOperador"
        Me.txtOperador.Size = New System.Drawing.Size(209, 20)
        Me.txtOperador.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Operador"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.rdBtnBoleta)
        Me.GroupBox3.Controls.Add(Me.rdBtnVisita)
        Me.GroupBox3.Controls.Add(Me.txtBusqueda)
        Me.GroupBox3.Controls.Add(Me.rdBtnContenedor)
        Me.GroupBox3.Controls.Add(Me.rdBtnReferencia)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 89)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(270, 93)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Buscar por"
        '
        'rdBtnBoleta
        '
        Me.rdBtnBoleta.AutoSize = True
        Me.rdBtnBoleta.Location = New System.Drawing.Point(102, 42)
        Me.rdBtnBoleta.Name = "rdBtnBoleta"
        Me.rdBtnBoleta.Size = New System.Drawing.Size(102, 17)
        Me.rdBtnBoleta.TabIndex = 5
        Me.rdBtnBoleta.TabStop = True
        Me.rdBtnBoleta.Text = "No. de boleta"
        Me.rdBtnBoleta.UseVisualStyleBackColor = True
        '
        'rdBtnVisita
        '
        Me.rdBtnVisita.AutoSize = True
        Me.rdBtnVisita.Location = New System.Drawing.Point(102, 19)
        Me.rdBtnVisita.Name = "rdBtnVisita"
        Me.rdBtnVisita.Size = New System.Drawing.Size(97, 17)
        Me.rdBtnVisita.TabIndex = 4
        Me.rdBtnVisita.TabStop = True
        Me.rdBtnVisita.Text = "No. de visita"
        Me.rdBtnVisita.UseVisualStyleBackColor = True
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Location = New System.Drawing.Point(6, 65)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(132, 20)
        Me.txtBusqueda.TabIndex = 3
        '
        'rdBtnContenedor
        '
        Me.rdBtnContenedor.AutoSize = True
        Me.rdBtnContenedor.Location = New System.Drawing.Point(6, 42)
        Me.rdBtnContenedor.Name = "rdBtnContenedor"
        Me.rdBtnContenedor.Size = New System.Drawing.Size(90, 17)
        Me.rdBtnContenedor.TabIndex = 2
        Me.rdBtnContenedor.TabStop = True
        Me.rdBtnContenedor.Text = "Contenedor"
        Me.rdBtnContenedor.UseVisualStyleBackColor = True
        '
        'rdBtnReferencia
        '
        Me.rdBtnReferencia.AutoSize = True
        Me.rdBtnReferencia.Location = New System.Drawing.Point(6, 19)
        Me.rdBtnReferencia.Name = "rdBtnReferencia"
        Me.rdBtnReferencia.Size = New System.Drawing.Size(87, 17)
        Me.rdBtnReferencia.TabIndex = 1
        Me.rdBtnReferencia.TabStop = True
        Me.rdBtnReferencia.Text = "Referencia"
        Me.rdBtnReferencia.UseVisualStyleBackColor = True
        '
        'gridCargas
        '
        Me.gridCargas.AllowUserToAddRows = False
        Me.gridCargas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridCargas.Location = New System.Drawing.Point(18, 188)
        Me.gridCargas.Name = "gridCargas"
        Me.gridCargas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridCargas.Size = New System.Drawing.Size(558, 184)
        Me.gridCargas.TabIndex = 3
        '
        'btnAceptar
        '
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(78, 387)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(120, 40)
        Me.btnAceptar.TabIndex = 4
        Me.btnAceptar.Text = "   Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(238, 387)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(120, 40)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "   Cancelar"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(396, 387)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(120, 40)
        Me.btnEliminar.TabIndex = 6
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(147, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Bloque"
        '
        'txtBloque
        '
        Me.txtBloque.Location = New System.Drawing.Point(200, 93)
        Me.txtBloque.Name = "txtBloque"
        Me.txtBloque.Size = New System.Drawing.Size(77, 20)
        Me.txtBloque.TabIndex = 20
        '
        'ModificacionMasiva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(601, 439)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.gridCargas)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(609, 473)
        Me.MinimumSize = New System.Drawing.Size(609, 473)
        Me.Name = "ModificacionMasiva"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Modificacion de cargas | Reporte de Programación"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.gridCargas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdBtnLocales As System.Windows.Forms.RadioButton
    Friend WithEvents rdBtnForaneos As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rdBtnContenedor As System.Windows.Forms.RadioButton
    Friend WithEvents rdBtnReferencia As System.Windows.Forms.RadioButton
    Friend WithEvents txtOperador As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents txtUnidad As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPlacas As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gridCargas As System.Windows.Forms.DataGridView
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents rdBtnVisita As System.Windows.Forms.RadioButton
    Friend WithEvents dteFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents rdBtnBoleta As System.Windows.Forms.RadioButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbMinutos As System.Windows.Forms.ComboBox
    Friend WithEvents cmbHoras As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTerminal As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtNoVisita As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dteFechaTraslado As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtBloque As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
