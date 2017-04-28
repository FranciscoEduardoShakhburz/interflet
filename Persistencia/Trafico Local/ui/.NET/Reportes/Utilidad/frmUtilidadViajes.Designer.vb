<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUtilidadViajes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUtilidadViajes))
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtCartaPorte = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmbConfigViaje = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmbOficina = New System.Windows.Forms.ComboBox
        Me.TxtOperador = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtSemana = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtViaje = New System.Windows.Forms.MaskedTextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbFecFin = New System.Windows.Forms.DateTimePicker
        Me.cmbFecIni = New System.Windows.Forms.DateTimePicker
        Me.TxtCliente = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.btnExportar = New System.Windows.Forms.Button
        Me.btnConsultar = New System.Windows.Forms.Button
        Me.grdUtilidadViaje = New System.Windows.Forms.DataGridView
        Me.btnGlobalMap = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtJustificacion = New System.Windows.Forms.TextBox
        Me.btnResumen = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.grid = New System.Windows.Forms.DataGridView
        Me.bto_guardar = New System.Windows.Forms.Button
        Me.ch_historico = New System.Windows.Forms.CheckBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdUtilidadViaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtCartaPorte)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cmbConfigViaje)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cmbOficina)
        Me.GroupBox1.Controls.Add(Me.TxtOperador)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtSemana)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtViaje)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbFecFin)
        Me.GroupBox1.Controls.Add(Me.cmbFecIni)
        Me.GroupBox1.Controls.Add(Me.TxtCliente)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1061, 65)
        Me.GroupBox1.TabIndex = 81
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione una opción de consulta:"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(79, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 14)
        Me.Label8.TabIndex = 89
        Me.Label8.Text = "C.P."
        '
        'txtCartaPorte
        '
        Me.txtCartaPorte.Location = New System.Drawing.Point(82, 38)
        Me.txtCartaPorte.Name = "txtCartaPorte"
        Me.txtCartaPorte.Size = New System.Drawing.Size(97, 21)
        Me.txtCartaPorte.TabIndex = 88
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(542, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 14)
        Me.Label7.TabIndex = 87
        Me.Label7.Text = "Tipo de Viaje:"
        '
        'cmbConfigViaje
        '
        Me.cmbConfigViaje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbConfigViaje.FormattingEnabled = True
        Me.cmbConfigViaje.Location = New System.Drawing.Point(545, 36)
        Me.cmbConfigViaje.Name = "cmbConfigViaje"
        Me.cmbConfigViaje.Size = New System.Drawing.Size(121, 23)
        Me.cmbConfigViaje.TabIndex = 86
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(881, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 14)
        Me.Label6.TabIndex = 85
        Me.Label6.Text = "Oficina:"
        '
        'cmbOficina
        '
        Me.cmbOficina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOficina.FormattingEnabled = True
        Me.cmbOficina.Items.AddRange(New Object() {"Oficina Altamira", "Oficina Manzanillo", "Oficina Veracruz"})
        Me.cmbOficina.Location = New System.Drawing.Point(884, 37)
        Me.cmbOficina.Name = "cmbOficina"
        Me.cmbOficina.Size = New System.Drawing.Size(140, 23)
        Me.cmbOficina.TabIndex = 84
        '
        'TxtOperador
        '
        Me.TxtOperador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOperador.Location = New System.Drawing.Point(328, 38)
        Me.TxtOperador.Name = "TxtOperador"
        Me.TxtOperador.Size = New System.Drawing.Size(146, 21)
        Me.TxtOperador.TabIndex = 83
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(325, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 15)
        Me.Label5.TabIndex = 82
        Me.Label5.Text = "Operador:"
        '
        'TxtSemana
        '
        Me.TxtSemana.Location = New System.Drawing.Point(480, 38)
        Me.TxtSemana.MaxLength = 99
        Me.TxtSemana.Name = "TxtSemana"
        Me.TxtSemana.Size = New System.Drawing.Size(59, 21)
        Me.TxtSemana.TabIndex = 3
        Me.TxtSemana.Text = "0"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(479, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 14)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "Semana:"
        '
        'TxtViaje
        '
        Me.TxtViaje.Location = New System.Drawing.Point(13, 37)
        Me.TxtViaje.Mask = "9999999999"
        Me.TxtViaje.Name = "TxtViaje"
        Me.TxtViaje.Size = New System.Drawing.Size(64, 21)
        Me.TxtViaje.TabIndex = 1
        Me.TxtViaje.Text = "0"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(775, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 14)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "Fecha Final:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(669, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 14)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "Fecha Inicial:"
        '
        'cmbFecFin
        '
        Me.cmbFecFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmbFecFin.Location = New System.Drawing.Point(778, 37)
        Me.cmbFecFin.Name = "cmbFecFin"
        Me.cmbFecFin.Size = New System.Drawing.Size(100, 21)
        Me.cmbFecFin.TabIndex = 5
        '
        'cmbFecIni
        '
        Me.cmbFecIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmbFecIni.Location = New System.Drawing.Point(672, 38)
        Me.cmbFecIni.Name = "cmbFecIni"
        Me.cmbFecIni.Size = New System.Drawing.Size(100, 21)
        Me.cmbFecIni.TabIndex = 4
        '
        'TxtCliente
        '
        Me.TxtCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCliente.Location = New System.Drawing.Point(185, 38)
        Me.TxtCliente.Name = "TxtCliente"
        Me.TxtCliente.Size = New System.Drawing.Size(137, 21)
        Me.TxtCliente.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(182, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 14)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Cliente:"
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(7, 18)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(70, 14)
        Me.Label30.TabIndex = 70
        Me.Label30.Text = "# Viaje:"
        '
        'btnExportar
        '
        Me.btnExportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
        Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExportar.Location = New System.Drawing.Point(199, 17)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(90, 60)
        Me.btnExportar.TabIndex = 78
        Me.btnExportar.Text = "Exportar"
        Me.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'btnConsultar
        '
        Me.btnConsultar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConsultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultar.Location = New System.Drawing.Point(6, 17)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(90, 60)
        Me.btnConsultar.TabIndex = 6
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'grdUtilidadViaje
        '
        Me.grdUtilidadViaje.AllowUserToAddRows = False
        Me.grdUtilidadViaje.AllowUserToDeleteRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdUtilidadViaje.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.grdUtilidadViaje.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdUtilidadViaje.BackgroundColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdUtilidadViaje.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.grdUtilidadViaje.ColumnHeadersHeight = 35
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdUtilidadViaje.DefaultCellStyle = DataGridViewCellStyle11
        Me.grdUtilidadViaje.Location = New System.Drawing.Point(15, 64)
        Me.grdUtilidadViaje.Name = "grdUtilidadViaje"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdUtilidadViaje.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.grdUtilidadViaje.RowHeadersWidth = 15
        Me.grdUtilidadViaje.Size = New System.Drawing.Size(1011, 238)
        Me.grdUtilidadViaje.TabIndex = 82
        '
        'btnGlobalMap
        '
        Me.btnGlobalMap.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGlobalMap.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGlobalMap.Location = New System.Drawing.Point(103, 19)
        Me.btnGlobalMap.Name = "btnGlobalMap"
        Me.btnGlobalMap.Size = New System.Drawing.Size(90, 60)
        Me.btnGlobalMap.TabIndex = 83
        Me.btnGlobalMap.Text = "Global Map"
        Me.btnGlobalMap.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(53, 611)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 16)
        Me.Label9.TabIndex = 90
        Me.Label9.Text = "Justificación:"
        '
        'txtJustificacion
        '
        Me.txtJustificacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtJustificacion.Location = New System.Drawing.Point(56, 630)
        Me.txtJustificacion.Name = "txtJustificacion"
        Me.txtJustificacion.Size = New System.Drawing.Size(222, 20)
        Me.txtJustificacion.TabIndex = 90
        '
        'btnResumen
        '
        Me.btnResumen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnResumen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResumen.Location = New System.Drawing.Point(55, 102)
        Me.btnResumen.Name = "btnResumen"
        Me.btnResumen.Size = New System.Drawing.Size(90, 60)
        Me.btnResumen.TabIndex = 91
        Me.btnResumen.Text = "Resumen de Viajes"
        Me.btnResumen.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.Location = New System.Drawing.Point(7, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 60)
        Me.Button1.TabIndex = 92
        Me.Button1.Text = "Diferentes"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'grid
        '
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Location = New System.Drawing.Point(15, 320)
        Me.grid.Name = "grid"
        Me.grid.Size = New System.Drawing.Size(1011, 215)
        Me.grid.TabIndex = 93
        '
        'bto_guardar
        '
        Me.bto_guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bto_guardar.Location = New System.Drawing.Point(103, 17)
        Me.bto_guardar.Name = "bto_guardar"
        Me.bto_guardar.Size = New System.Drawing.Size(90, 60)
        Me.bto_guardar.TabIndex = 94
        Me.bto_guardar.Text = "Guardar"
        Me.bto_guardar.UseVisualStyleBackColor = True
        '
        'ch_historico
        '
        Me.ch_historico.AutoSize = True
        Me.ch_historico.BackColor = System.Drawing.Color.Transparent
        Me.ch_historico.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ch_historico.ForeColor = System.Drawing.Color.Black
        Me.ch_historico.Location = New System.Drawing.Point(56, 580)
        Me.ch_historico.Name = "ch_historico"
        Me.ch_historico.Size = New System.Drawing.Size(123, 17)
        Me.ch_historico.TabIndex = 95
        Me.ch_historico.Text = "VER HISTORICO"
        Me.ch_historico.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.btnGlobalMap)
        Me.GroupBox2.Controls.Add(Me.btnResumen)
        Me.GroupBox2.Location = New System.Drawing.Point(642, 548)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(199, 168)
        Me.GroupBox2.TabIndex = 96
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.btnConsultar)
        Me.GroupBox3.Controls.Add(Me.btnExportar)
        Me.GroupBox3.Controls.Add(Me.bto_guardar)
        Me.GroupBox3.Location = New System.Drawing.Point(304, 567)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(295, 83)
        Me.GroupBox3.TabIndex = 97
        Me.GroupBox3.TabStop = False
        '
        'frmUtilidadViajes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1061, 728)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ch_historico)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.txtJustificacion)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grdUtilidadViaje)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmUtilidadViajes"
        Me.Text = "Reporte de Utilidad de Viajes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grdUtilidadViaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtSemana As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtViaje As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnExportar As System.Windows.Forms.Button
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbFecFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbFecIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents grdUtilidadViaje As System.Windows.Forms.DataGridView
    Friend WithEvents TxtOperador As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbOficina As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbConfigViaje As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCartaPorte As System.Windows.Forms.TextBox
    Friend WithEvents btnGlobalMap As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtJustificacion As System.Windows.Forms.TextBox
    Friend WithEvents btnResumen As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents grid As System.Windows.Forms.DataGridView
    Friend WithEvents bto_guardar As System.Windows.Forms.Button
    Friend WithEvents ch_historico As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
End Class
