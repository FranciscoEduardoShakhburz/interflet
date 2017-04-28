<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaCotizacion
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConsultaCotizacion))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label30 = New System.Windows.Forms.Label
        Me.TxtCliente = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbFecIni = New System.Windows.Forms.DateTimePicker
        Me.cmbFecFin = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TxtNoCotizacion = New System.Windows.Forms.MaskedTextBox
        Me.btnExportar = New System.Windows.Forms.Button
        Me.btnConsultar = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.UPConsultaCotizacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PI_ConsultaCotizacion = New Interflet.PI_ConsultaCotizacion
        Me.UP_Consulta_CotizacionTableAdapter = New Interflet.PI_ConsultaCotizacionTableAdapters.UP_Consulta_CotizacionTableAdapter
        Me.IdNumCotizacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaCotizacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OrigenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DestinoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TipoViajeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TipoRemolqueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PesoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CantKMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MontoCasetasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CantDiasViajeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CostoDieselDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MontoManiobrasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ComisionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SueldoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SeguroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VolumenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FrecuenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SobrecostoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IncrementoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TipoCotizacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Monto_TarifaSencillo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Monto_TarifalFull = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PorcUtilMinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PorcUtilMaxDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MontoUtilMinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MontoUtilMaxDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PorcUtilSencilloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PorcUtilFullDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ObservacionesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UPConsultaCotizacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PI_ConsultaCotizacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(13, 23)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(95, 14)
        Me.Label30.TabIndex = 70
        Me.Label30.Text = "# Cotización:"
        '
        'TxtCliente
        '
        Me.TxtCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCliente.Location = New System.Drawing.Point(120, 39)
        Me.TxtCliente.Name = "TxtCliente"
        Me.TxtCliente.Size = New System.Drawing.Size(194, 21)
        Me.TxtCliente.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(118, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 14)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Cliente:"
        '
        'cmbFecIni
        '
        Me.cmbFecIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmbFecIni.Location = New System.Drawing.Point(342, 39)
        Me.cmbFecIni.Name = "cmbFecIni"
        Me.cmbFecIni.Size = New System.Drawing.Size(100, 21)
        Me.cmbFecIni.TabIndex = 3
        '
        'cmbFecFin
        '
        Me.cmbFecFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmbFecFin.Location = New System.Drawing.Point(468, 39)
        Me.cmbFecFin.Name = "cmbFecFin"
        Me.cmbFecFin.Size = New System.Drawing.Size(100, 21)
        Me.cmbFecFin.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(339, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 14)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "Fecha Inicial:"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(465, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 14)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "Fecha Final:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.TxtNoCotizacion)
        Me.GroupBox1.Controls.Add(Me.btnExportar)
        Me.GroupBox1.Controls.Add(Me.btnConsultar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbFecFin)
        Me.GroupBox1.Controls.Add(Me.cmbFecIni)
        Me.GroupBox1.Controls.Add(Me.TxtCliente)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(836, 75)
        Me.GroupBox1.TabIndex = 79
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione una opción de consulta:"
        '
        'TxtNoCotizacion
        '
        Me.TxtNoCotizacion.Location = New System.Drawing.Point(19, 39)
        Me.TxtNoCotizacion.Mask = "99999"
        Me.TxtNoCotizacion.Name = "TxtNoCotizacion"
        Me.TxtNoCotizacion.Size = New System.Drawing.Size(78, 21)
        Me.TxtNoCotizacion.TabIndex = 79
        '
        'btnExportar
        '
        Me.btnExportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
        Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExportar.Location = New System.Drawing.Point(688, 28)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(77, 33)
        Me.btnExportar.TabIndex = 78
        Me.btnExportar.Text = "Exportar"
        Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(588, 28)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(85, 33)
        Me.btnConsultar.TabIndex = 5
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdNumCotizacionDataGridViewTextBoxColumn, Me.FechaCotizacionDataGridViewTextBoxColumn, Me.OrigenDataGridViewTextBoxColumn, Me.DestinoDataGridViewTextBoxColumn, Me.ClienteDataGridViewTextBoxColumn, Me.TipoViajeDataGridViewTextBoxColumn, Me.TipoRemolqueDataGridViewTextBoxColumn, Me.PesoDataGridViewTextBoxColumn, Me.CantKMDataGridViewTextBoxColumn, Me.MontoCasetasDataGridViewTextBoxColumn, Me.CantDiasViajeDataGridViewTextBoxColumn, Me.CostoDieselDataGridViewTextBoxColumn, Me.MontoManiobrasDataGridViewTextBoxColumn, Me.ComisionDataGridViewTextBoxColumn, Me.SueldoDataGridViewTextBoxColumn, Me.SeguroDataGridViewTextBoxColumn, Me.VolumenDataGridViewTextBoxColumn, Me.FrecuenciaDataGridViewTextBoxColumn, Me.SobrecostoDataGridViewTextBoxColumn, Me.IncrementoDataGridViewTextBoxColumn, Me.TipoCotizacionDataGridViewTextBoxColumn, Me.Monto_TarifaSencillo, Me.Monto_TarifalFull, Me.PorcUtilMinDataGridViewTextBoxColumn, Me.PorcUtilMaxDataGridViewTextBoxColumn, Me.MontoUtilMinDataGridViewTextBoxColumn, Me.MontoUtilMaxDataGridViewTextBoxColumn, Me.PorcUtilSencilloDataGridViewTextBoxColumn, Me.PorcUtilFullDataGridViewTextBoxColumn, Me.ObservacionesDataGridViewTextBoxColumn, Me.UsuarioDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.UPConsultaCotizacionBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(6, 91)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 30
        Me.DataGridView1.Size = New System.Drawing.Size(836, 489)
        Me.DataGridView1.TabIndex = 80
        '
        'UPConsultaCotizacionBindingSource
        '
        Me.UPConsultaCotizacionBindingSource.DataMember = "UP_Consulta_Cotizacion"
        Me.UPConsultaCotizacionBindingSource.DataSource = Me.PI_ConsultaCotizacion
        '
        'PI_ConsultaCotizacion
        '
        Me.PI_ConsultaCotizacion.DataSetName = "PI_ConsultaCotizacion"
        Me.PI_ConsultaCotizacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UP_Consulta_CotizacionTableAdapter
        '
        Me.UP_Consulta_CotizacionTableAdapter.ClearBeforeFill = True
        '
        'IdNumCotizacionDataGridViewTextBoxColumn
        '
        Me.IdNumCotizacionDataGridViewTextBoxColumn.DataPropertyName = "Id_Num_Cotizacion"
        Me.IdNumCotizacionDataGridViewTextBoxColumn.HeaderText = "# Cotizacion"
        Me.IdNumCotizacionDataGridViewTextBoxColumn.Name = "IdNumCotizacionDataGridViewTextBoxColumn"
        Me.IdNumCotizacionDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdNumCotizacionDataGridViewTextBoxColumn.Width = 80
        '
        'FechaCotizacionDataGridViewTextBoxColumn
        '
        Me.FechaCotizacionDataGridViewTextBoxColumn.DataPropertyName = "FechaCotizacion"
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.FechaCotizacionDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.FechaCotizacionDataGridViewTextBoxColumn.HeaderText = "Fecha de Cotizacion"
        Me.FechaCotizacionDataGridViewTextBoxColumn.Name = "FechaCotizacionDataGridViewTextBoxColumn"
        Me.FechaCotizacionDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaCotizacionDataGridViewTextBoxColumn.Width = 80
        '
        'OrigenDataGridViewTextBoxColumn
        '
        Me.OrigenDataGridViewTextBoxColumn.DataPropertyName = "Origen"
        Me.OrigenDataGridViewTextBoxColumn.HeaderText = "Origen"
        Me.OrigenDataGridViewTextBoxColumn.Name = "OrigenDataGridViewTextBoxColumn"
        Me.OrigenDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DestinoDataGridViewTextBoxColumn
        '
        Me.DestinoDataGridViewTextBoxColumn.DataPropertyName = "Destino"
        Me.DestinoDataGridViewTextBoxColumn.HeaderText = "Ruta"
        Me.DestinoDataGridViewTextBoxColumn.Name = "DestinoDataGridViewTextBoxColumn"
        Me.DestinoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClienteDataGridViewTextBoxColumn
        '
        Me.ClienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.Name = "ClienteDataGridViewTextBoxColumn"
        Me.ClienteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TipoViajeDataGridViewTextBoxColumn
        '
        Me.TipoViajeDataGridViewTextBoxColumn.DataPropertyName = "TipoViaje"
        Me.TipoViajeDataGridViewTextBoxColumn.HeaderText = "Tipo de Viaje"
        Me.TipoViajeDataGridViewTextBoxColumn.Name = "TipoViajeDataGridViewTextBoxColumn"
        Me.TipoViajeDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoViajeDataGridViewTextBoxColumn.Width = 80
        '
        'TipoRemolqueDataGridViewTextBoxColumn
        '
        Me.TipoRemolqueDataGridViewTextBoxColumn.DataPropertyName = "TipoRemolque"
        Me.TipoRemolqueDataGridViewTextBoxColumn.HeaderText = "Tipo de Remolque"
        Me.TipoRemolqueDataGridViewTextBoxColumn.Name = "TipoRemolqueDataGridViewTextBoxColumn"
        Me.TipoRemolqueDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PesoDataGridViewTextBoxColumn
        '
        Me.PesoDataGridViewTextBoxColumn.DataPropertyName = "Peso"
        Me.PesoDataGridViewTextBoxColumn.HeaderText = "Peso"
        Me.PesoDataGridViewTextBoxColumn.Name = "PesoDataGridViewTextBoxColumn"
        Me.PesoDataGridViewTextBoxColumn.ReadOnly = True
        Me.PesoDataGridViewTextBoxColumn.Width = 60
        '
        'CantKMDataGridViewTextBoxColumn
        '
        Me.CantKMDataGridViewTextBoxColumn.DataPropertyName = "Cant_KM"
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.CantKMDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.CantKMDataGridViewTextBoxColumn.HeaderText = "Cant. de KM"
        Me.CantKMDataGridViewTextBoxColumn.Name = "CantKMDataGridViewTextBoxColumn"
        Me.CantKMDataGridViewTextBoxColumn.ReadOnly = True
        Me.CantKMDataGridViewTextBoxColumn.Width = 70
        '
        'MontoCasetasDataGridViewTextBoxColumn
        '
        Me.MontoCasetasDataGridViewTextBoxColumn.DataPropertyName = "Monto_Casetas"
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.MontoCasetasDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.MontoCasetasDataGridViewTextBoxColumn.HeaderText = "Monto de Casetas"
        Me.MontoCasetasDataGridViewTextBoxColumn.Name = "MontoCasetasDataGridViewTextBoxColumn"
        Me.MontoCasetasDataGridViewTextBoxColumn.ReadOnly = True
        Me.MontoCasetasDataGridViewTextBoxColumn.Width = 80
        '
        'CantDiasViajeDataGridViewTextBoxColumn
        '
        Me.CantDiasViajeDataGridViewTextBoxColumn.DataPropertyName = "Cant_DiasViaje"
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.CantDiasViajeDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.CantDiasViajeDataGridViewTextBoxColumn.HeaderText = "Dias de Viaje"
        Me.CantDiasViajeDataGridViewTextBoxColumn.Name = "CantDiasViajeDataGridViewTextBoxColumn"
        Me.CantDiasViajeDataGridViewTextBoxColumn.ReadOnly = True
        Me.CantDiasViajeDataGridViewTextBoxColumn.Width = 70
        '
        'CostoDieselDataGridViewTextBoxColumn
        '
        Me.CostoDieselDataGridViewTextBoxColumn.DataPropertyName = "Costo_Diesel"
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.CostoDieselDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.CostoDieselDataGridViewTextBoxColumn.HeaderText = "Costo de Diesel"
        Me.CostoDieselDataGridViewTextBoxColumn.Name = "CostoDieselDataGridViewTextBoxColumn"
        Me.CostoDieselDataGridViewTextBoxColumn.ReadOnly = True
        Me.CostoDieselDataGridViewTextBoxColumn.Width = 70
        '
        'MontoManiobrasDataGridViewTextBoxColumn
        '
        Me.MontoManiobrasDataGridViewTextBoxColumn.DataPropertyName = "Monto_Maniobras"
        DataGridViewCellStyle6.Format = "C2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.MontoManiobrasDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.MontoManiobrasDataGridViewTextBoxColumn.HeaderText = "Monto de Maniobras"
        Me.MontoManiobrasDataGridViewTextBoxColumn.Name = "MontoManiobrasDataGridViewTextBoxColumn"
        Me.MontoManiobrasDataGridViewTextBoxColumn.ReadOnly = True
        Me.MontoManiobrasDataGridViewTextBoxColumn.Width = 80
        '
        'ComisionDataGridViewTextBoxColumn
        '
        Me.ComisionDataGridViewTextBoxColumn.DataPropertyName = "Comision"
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.ComisionDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.ComisionDataGridViewTextBoxColumn.HeaderText = "% Comision"
        Me.ComisionDataGridViewTextBoxColumn.Name = "ComisionDataGridViewTextBoxColumn"
        Me.ComisionDataGridViewTextBoxColumn.ReadOnly = True
        Me.ComisionDataGridViewTextBoxColumn.Width = 70
        '
        'SueldoDataGridViewTextBoxColumn
        '
        Me.SueldoDataGridViewTextBoxColumn.DataPropertyName = "Sueldo"
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.SueldoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle8
        Me.SueldoDataGridViewTextBoxColumn.HeaderText = "% Sueldo"
        Me.SueldoDataGridViewTextBoxColumn.Name = "SueldoDataGridViewTextBoxColumn"
        Me.SueldoDataGridViewTextBoxColumn.ReadOnly = True
        Me.SueldoDataGridViewTextBoxColumn.Width = 80
        '
        'SeguroDataGridViewTextBoxColumn
        '
        Me.SeguroDataGridViewTextBoxColumn.DataPropertyName = "Seguro"
        Me.SeguroDataGridViewTextBoxColumn.HeaderText = "Seguro de Contenedor"
        Me.SeguroDataGridViewTextBoxColumn.Name = "SeguroDataGridViewTextBoxColumn"
        Me.SeguroDataGridViewTextBoxColumn.ReadOnly = True
        Me.SeguroDataGridViewTextBoxColumn.Width = 80
        '
        'VolumenDataGridViewTextBoxColumn
        '
        Me.VolumenDataGridViewTextBoxColumn.DataPropertyName = "Volumen"
        DataGridViewCellStyle9.Format = "N0"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.VolumenDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle9
        Me.VolumenDataGridViewTextBoxColumn.HeaderText = "Volumen"
        Me.VolumenDataGridViewTextBoxColumn.Name = "VolumenDataGridViewTextBoxColumn"
        Me.VolumenDataGridViewTextBoxColumn.ReadOnly = True
        Me.VolumenDataGridViewTextBoxColumn.Width = 70
        '
        'FrecuenciaDataGridViewTextBoxColumn
        '
        Me.FrecuenciaDataGridViewTextBoxColumn.DataPropertyName = "Frecuencia"
        Me.FrecuenciaDataGridViewTextBoxColumn.HeaderText = "Frecuencia"
        Me.FrecuenciaDataGridViewTextBoxColumn.Name = "FrecuenciaDataGridViewTextBoxColumn"
        Me.FrecuenciaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FrecuenciaDataGridViewTextBoxColumn.Width = 80
        '
        'SobrecostoDataGridViewTextBoxColumn
        '
        Me.SobrecostoDataGridViewTextBoxColumn.DataPropertyName = "Sobrecosto"
        DataGridViewCellStyle10.Format = "N2"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.SobrecostoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle10
        Me.SobrecostoDataGridViewTextBoxColumn.HeaderText = "% Sobrecosto"
        Me.SobrecostoDataGridViewTextBoxColumn.Name = "SobrecostoDataGridViewTextBoxColumn"
        Me.SobrecostoDataGridViewTextBoxColumn.ReadOnly = True
        Me.SobrecostoDataGridViewTextBoxColumn.Width = 80
        '
        'IncrementoDataGridViewTextBoxColumn
        '
        Me.IncrementoDataGridViewTextBoxColumn.DataPropertyName = "Incremento"
        Me.IncrementoDataGridViewTextBoxColumn.HeaderText = "Incremento"
        Me.IncrementoDataGridViewTextBoxColumn.Name = "IncrementoDataGridViewTextBoxColumn"
        Me.IncrementoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IncrementoDataGridViewTextBoxColumn.Visible = False
        Me.IncrementoDataGridViewTextBoxColumn.Width = 80
        '
        'TipoCotizacionDataGridViewTextBoxColumn
        '
        Me.TipoCotizacionDataGridViewTextBoxColumn.DataPropertyName = "TipoCotizacion"
        Me.TipoCotizacionDataGridViewTextBoxColumn.HeaderText = "Tipo de Cotizacion"
        Me.TipoCotizacionDataGridViewTextBoxColumn.Name = "TipoCotizacionDataGridViewTextBoxColumn"
        Me.TipoCotizacionDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoCotizacionDataGridViewTextBoxColumn.Width = 80
        '
        'Monto_TarifaSencillo
        '
        Me.Monto_TarifaSencillo.DataPropertyName = "Monto_TarifaSencillo"
        DataGridViewCellStyle11.Format = "C2"
        DataGridViewCellStyle11.NullValue = Nothing
        Me.Monto_TarifaSencillo.DefaultCellStyle = DataGridViewCellStyle11
        Me.Monto_TarifaSencillo.HeaderText = "Tarifa Viaje Sencillo"
        Me.Monto_TarifaSencillo.Name = "Monto_TarifaSencillo"
        Me.Monto_TarifaSencillo.ReadOnly = True
        Me.Monto_TarifaSencillo.Width = 80
        '
        'Monto_TarifalFull
        '
        Me.Monto_TarifalFull.DataPropertyName = "Monto_TarifaFull"
        DataGridViewCellStyle12.Format = "C2"
        DataGridViewCellStyle12.NullValue = Nothing
        Me.Monto_TarifalFull.DefaultCellStyle = DataGridViewCellStyle12
        Me.Monto_TarifalFull.HeaderText = "Tarifa Viaje Full"
        Me.Monto_TarifalFull.Name = "Monto_TarifalFull"
        Me.Monto_TarifalFull.ReadOnly = True
        Me.Monto_TarifalFull.Width = 80
        '
        'PorcUtilMinDataGridViewTextBoxColumn
        '
        Me.PorcUtilMinDataGridViewTextBoxColumn.DataPropertyName = "PorcUtilMin"
        Me.PorcUtilMinDataGridViewTextBoxColumn.HeaderText = "% Utilidad Minima"
        Me.PorcUtilMinDataGridViewTextBoxColumn.Name = "PorcUtilMinDataGridViewTextBoxColumn"
        Me.PorcUtilMinDataGridViewTextBoxColumn.ReadOnly = True
        Me.PorcUtilMinDataGridViewTextBoxColumn.Width = 80
        '
        'PorcUtilMaxDataGridViewTextBoxColumn
        '
        Me.PorcUtilMaxDataGridViewTextBoxColumn.DataPropertyName = "PorcUtilMax"
        Me.PorcUtilMaxDataGridViewTextBoxColumn.HeaderText = "% Utilidad Maxima"
        Me.PorcUtilMaxDataGridViewTextBoxColumn.Name = "PorcUtilMaxDataGridViewTextBoxColumn"
        Me.PorcUtilMaxDataGridViewTextBoxColumn.ReadOnly = True
        Me.PorcUtilMaxDataGridViewTextBoxColumn.Width = 80
        '
        'MontoUtilMinDataGridViewTextBoxColumn
        '
        Me.MontoUtilMinDataGridViewTextBoxColumn.DataPropertyName = "Monto_UtilMin"
        Me.MontoUtilMinDataGridViewTextBoxColumn.HeaderText = "Monto Utilidad Minima"
        Me.MontoUtilMinDataGridViewTextBoxColumn.Name = "MontoUtilMinDataGridViewTextBoxColumn"
        Me.MontoUtilMinDataGridViewTextBoxColumn.ReadOnly = True
        Me.MontoUtilMinDataGridViewTextBoxColumn.Width = 80
        '
        'MontoUtilMaxDataGridViewTextBoxColumn
        '
        Me.MontoUtilMaxDataGridViewTextBoxColumn.DataPropertyName = "Monto_UtilMax"
        Me.MontoUtilMaxDataGridViewTextBoxColumn.HeaderText = "Monto Utilidad Maxima"
        Me.MontoUtilMaxDataGridViewTextBoxColumn.Name = "MontoUtilMaxDataGridViewTextBoxColumn"
        Me.MontoUtilMaxDataGridViewTextBoxColumn.ReadOnly = True
        Me.MontoUtilMaxDataGridViewTextBoxColumn.Width = 80
        '
        'PorcUtilSencilloDataGridViewTextBoxColumn
        '
        Me.PorcUtilSencilloDataGridViewTextBoxColumn.DataPropertyName = "PorcUtilSencillo"
        Me.PorcUtilSencilloDataGridViewTextBoxColumn.HeaderText = "% Utilidad Sencillo"
        Me.PorcUtilSencilloDataGridViewTextBoxColumn.Name = "PorcUtilSencilloDataGridViewTextBoxColumn"
        Me.PorcUtilSencilloDataGridViewTextBoxColumn.ReadOnly = True
        Me.PorcUtilSencilloDataGridViewTextBoxColumn.Width = 80
        '
        'PorcUtilFullDataGridViewTextBoxColumn
        '
        Me.PorcUtilFullDataGridViewTextBoxColumn.DataPropertyName = "PorcUtilFull"
        Me.PorcUtilFullDataGridViewTextBoxColumn.HeaderText = "% Utilidad Full"
        Me.PorcUtilFullDataGridViewTextBoxColumn.Name = "PorcUtilFullDataGridViewTextBoxColumn"
        Me.PorcUtilFullDataGridViewTextBoxColumn.ReadOnly = True
        Me.PorcUtilFullDataGridViewTextBoxColumn.Width = 80
        '
        'ObservacionesDataGridViewTextBoxColumn
        '
        Me.ObservacionesDataGridViewTextBoxColumn.DataPropertyName = "Observaciones"
        Me.ObservacionesDataGridViewTextBoxColumn.HeaderText = "Observaciones"
        Me.ObservacionesDataGridViewTextBoxColumn.Name = "ObservacionesDataGridViewTextBoxColumn"
        Me.ObservacionesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UsuarioDataGridViewTextBoxColumn
        '
        Me.UsuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.HeaderText = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.Name = "UsuarioDataGridViewTextBoxColumn"
        Me.UsuarioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FrmConsultaCotizacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(848, 589)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmConsultaCotizacion"
        Me.Text = " Consulta de Cotizaciones"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UPConsultaCotizacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PI_ConsultaCotizacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents TxtCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbFecIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbFecFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents btnExportar As System.Windows.Forms.Button
    Friend WithEvents TxtNoCotizacion As System.Windows.Forms.MaskedTextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents UPConsultaCotizacionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PI_ConsultaCotizacion As Interflet.PI_ConsultaCotizacion
    Friend WithEvents UP_Consulta_CotizacionTableAdapter As Interflet.PI_ConsultaCotizacionTableAdapters.UP_Consulta_CotizacionTableAdapter
    Friend WithEvents MontoUtilSencilloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontoUtilFullDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdNumCotizacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaCotizacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrigenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DestinoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoViajeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoRemolqueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PesoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantKMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontoCasetasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantDiasViajeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostoDieselDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontoManiobrasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComisionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SueldoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SeguroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VolumenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FrecuenciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SobrecostoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IncrementoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoCotizacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Monto_TarifaSencillo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Monto_TarifalFull As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PorcUtilMinDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PorcUtilMaxDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontoUtilMinDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontoUtilMaxDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PorcUtilSencilloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PorcUtilFullDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ObservacionesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsuarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
