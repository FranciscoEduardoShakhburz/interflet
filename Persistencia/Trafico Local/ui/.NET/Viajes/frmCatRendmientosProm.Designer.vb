<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCatRendmientosProm
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
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCatRendmientosProm))
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbOrigen = New System.Windows.Forms.ComboBox
        Me.ProduccionInterfletdbDataSet2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProduccionInterfletdbDataSet2 = New Interflet.ProduccionInterfletdbDataSet2
        Me.gbFiltros = New System.Windows.Forms.GroupBox
        Me.btnConsultar = New System.Windows.Forms.Button
        Me.cmbCliente = New System.Windows.Forms.ComboBox
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PI_Clientes = New Interflet.PI_Clientes
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbDestino = New System.Windows.Forms.ComboBox
        Me.TraficorutaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PI_Ruta = New Interflet.PI_Ruta
        Me.Label2 = New System.Windows.Forms.Label
        Me.ProduccionInterfletdbDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProduccionInterfletdbDataSet1 = New Interflet.ProduccionInterfletdbDataSet1
        Me.Trafico_plazaTableAdapter = New Interflet.ProduccionInterfletdbDataSet2TableAdapters.trafico_plazaTableAdapter
        Me.Cat_DestinoTableAdapter = New Interflet.ProduccionInterfletdbDataSet1TableAdapters.Cat_DestinoTableAdapter
        Me.ClienteTableAdapter = New Interflet.PI_ClientesTableAdapters.clienteTableAdapter
        Me.grdRendimientos = New System.Windows.Forms.DataGridView
        Me.TipoMotor = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.TraficomotorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PI_TipoMotor = New Interflet.PI_TipoMotor
        Me.TipoViaje2 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.TraficotipoviajeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProduccionInterfletdbDataSet9 = New Interflet.ProduccionInterfletdbDataSet9
        Me.Id_Num_Origen = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Id_Num_Destino = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Id_Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TipoViaje = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Id_Tipo_Motor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RangoPesoIni = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RangoPesoFin = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KmPromedio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LtsPromedio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RendPromedio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CantViajes = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FecMovtoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UserIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CatRendimientosEstBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PI_Rendimientos = New Interflet.PI_Rendimientos
        Me.Cat_RendimientosEstTableAdapter = New Interflet.PI_RendimientosTableAdapters.Cat_RendimientosEstTableAdapter
        Me.Trafico_motorTableAdapter = New Interflet.PI_TipoMotorTableAdapters.trafico_motorTableAdapter
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton
        Me.btnExportar = New System.Windows.Forms.ToolStripButton
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.CortarToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.TraficoplazaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Trafico_rutaTableAdapter = New Interflet.PI_RutaTableAdapters.trafico_rutaTableAdapter
        Me.Trafico_clienteTableAdapter = New Interflet.PI_ClientesTableAdapters.trafico_clienteTableAdapter
        Me.Trafico_tipo_viajeTableAdapter = New Interflet.ProduccionInterfletdbDataSet9TableAdapters.trafico_tipo_viajeTableAdapter
        CType(Me.ProduccionInterfletdbDataSet2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProduccionInterfletdbDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbFiltros.SuspendLayout()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PI_Clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TraficorutaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PI_Ruta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProduccionInterfletdbDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProduccionInterfletdbDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdRendimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TraficomotorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PI_TipoMotor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TraficotipoviajeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProduccionInterfletdbDataSet9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CatRendimientosEstBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PI_Rendimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.TraficoplazaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 15)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Plaza Origen"
        '
        'cmbOrigen
        '
        Me.cmbOrigen.DataSource = Me.ProduccionInterfletdbDataSet2BindingSource
        Me.cmbOrigen.DisplayMember = "trafico_plaza.desc_plaza"
        Me.cmbOrigen.FormattingEnabled = True
        Me.cmbOrigen.Location = New System.Drawing.Point(10, 41)
        Me.cmbOrigen.Name = "cmbOrigen"
        Me.cmbOrigen.Size = New System.Drawing.Size(170, 23)
        Me.cmbOrigen.TabIndex = 1
        Me.cmbOrigen.ValueMember = "id_plaza"
        '
        'ProduccionInterfletdbDataSet2BindingSource
        '
        Me.ProduccionInterfletdbDataSet2BindingSource.DataSource = Me.ProduccionInterfletdbDataSet2
        Me.ProduccionInterfletdbDataSet2BindingSource.Position = 0
        '
        'ProduccionInterfletdbDataSet2
        '
        Me.ProduccionInterfletdbDataSet2.DataSetName = "ProduccionInterfletdbDataSet2"
        Me.ProduccionInterfletdbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gbFiltros
        '
        Me.gbFiltros.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbFiltros.BackColor = System.Drawing.Color.Transparent
        Me.gbFiltros.Controls.Add(Me.btnConsultar)
        Me.gbFiltros.Controls.Add(Me.cmbCliente)
        Me.gbFiltros.Controls.Add(Me.Label1)
        Me.gbFiltros.Controls.Add(Me.cmbDestino)
        Me.gbFiltros.Controls.Add(Me.Label2)
        Me.gbFiltros.Controls.Add(Me.Label4)
        Me.gbFiltros.Controls.Add(Me.cmbOrigen)
        Me.gbFiltros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbFiltros.Location = New System.Drawing.Point(7, 10)
        Me.gbFiltros.Name = "gbFiltros"
        Me.gbFiltros.Size = New System.Drawing.Size(800, 89)
        Me.gbFiltros.TabIndex = 14
        Me.gbFiltros.TabStop = False
        Me.gbFiltros.Text = "Seleccione los Filtros:"
        '
        'btnConsultar
        '
        Me.btnConsultar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnConsultar.Location = New System.Drawing.Point(672, 37)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(80, 24)
        Me.btnConsultar.TabIndex = 18
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = False
        '
        'cmbCliente
        '
        Me.cmbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCliente.DataSource = Me.ClienteBindingSource
        Me.cmbCliente.DisplayMember = "nombre1"
        Me.cmbCliente.DropDownWidth = 300
        Me.cmbCliente.FormattingEnabled = True
        Me.cmbCliente.ItemHeight = 15
        Me.cmbCliente.Location = New System.Drawing.Point(392, 40)
        Me.cmbCliente.MaxDropDownItems = 12
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.Size = New System.Drawing.Size(274, 23)
        Me.cmbCliente.TabIndex = 3
        Me.cmbCliente.ValueMember = "id_cliente"
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "trafico_cliente"
        Me.ClienteBindingSource.DataSource = Me.PI_Clientes
        '
        'PI_Clientes
        '
        Me.PI_Clientes.DataSetName = "PI_Clientes"
        Me.PI_Clientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(391, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Cliente"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbDestino
        '
        Me.cmbDestino.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbDestino.DataSource = Me.TraficorutaBindingSource
        Me.cmbDestino.DisplayMember = "desc_ruta"
        Me.cmbDestino.FormattingEnabled = True
        Me.cmbDestino.Location = New System.Drawing.Point(186, 40)
        Me.cmbDestino.Name = "cmbDestino"
        Me.cmbDestino.Size = New System.Drawing.Size(200, 23)
        Me.cmbDestino.TabIndex = 2
        Me.cmbDestino.ValueMember = "id_ruta"
        '
        'TraficorutaBindingSource
        '
        Me.TraficorutaBindingSource.DataMember = "trafico_ruta"
        Me.TraficorutaBindingSource.DataSource = Me.PI_Ruta
        '
        'PI_Ruta
        '
        Me.PI_Ruta.DataSetName = "PI_Ruta"
        Me.PI_Ruta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(183, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 15)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Ruta"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProduccionInterfletdbDataSet1BindingSource
        '
        Me.ProduccionInterfletdbDataSet1BindingSource.DataMember = "Cat_Destino"
        Me.ProduccionInterfletdbDataSet1BindingSource.DataSource = Me.ProduccionInterfletdbDataSet1
        '
        'ProduccionInterfletdbDataSet1
        '
        Me.ProduccionInterfletdbDataSet1.DataSetName = "ProduccionInterfletdbDataSet1"
        Me.ProduccionInterfletdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Trafico_plazaTableAdapter
        '
        Me.Trafico_plazaTableAdapter.ClearBeforeFill = True
        '
        'Cat_DestinoTableAdapter
        '
        Me.Cat_DestinoTableAdapter.ClearBeforeFill = True
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'grdRendimientos
        '
        Me.grdRendimientos.AllowUserToAddRows = False
        Me.grdRendimientos.AllowUserToOrderColumns = True
        Me.grdRendimientos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdRendimientos.AutoGenerateColumns = False
        Me.grdRendimientos.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.grdRendimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdRendimientos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TipoMotor, Me.TipoViaje2, Me.Id_Num_Origen, Me.Id_Num_Destino, Me.Id_Cliente, Me.TipoViaje, Me.Id_Tipo_Motor, Me.RangoPesoIni, Me.RangoPesoFin, Me.KmPromedio, Me.LtsPromedio, Me.RendPromedio, Me.CantViajes, Me.FecMovtoDataGridViewTextBoxColumn, Me.UserIdDataGridViewTextBoxColumn})
        Me.grdRendimientos.DataSource = Me.CatRendimientosEstBindingSource
        Me.grdRendimientos.Location = New System.Drawing.Point(4, 132)
        Me.grdRendimientos.Name = "grdRendimientos"
        Me.grdRendimientos.RowHeadersWidth = 20
        Me.grdRendimientos.Size = New System.Drawing.Size(803, 479)
        Me.grdRendimientos.TabIndex = 15
        '
        'TipoMotor
        '
        Me.TipoMotor.DataSource = Me.TraficomotorBindingSource
        Me.TipoMotor.DisplayMember = "desc_motor"
        Me.TipoMotor.HeaderText = "Tipo de Motor"
        Me.TipoMotor.Name = "TipoMotor"
        Me.TipoMotor.ValueMember = "id_tipo_motor"
        Me.TipoMotor.Width = 150
        '
        'TraficomotorBindingSource
        '
        Me.TraficomotorBindingSource.DataMember = "trafico_motor"
        Me.TraficomotorBindingSource.DataSource = Me.PI_TipoMotor
        '
        'PI_TipoMotor
        '
        Me.PI_TipoMotor.DataSetName = "PI_TipoMotor"
        Me.PI_TipoMotor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TipoViaje2
        '
        Me.TipoViaje2.DataSource = Me.TraficotipoviajeBindingSource
        Me.TipoViaje2.DisplayMember = "tipoviaje"
        Me.TipoViaje2.HeaderText = "Tipo de Viaje"
        Me.TipoViaje2.Name = "TipoViaje2"
        '
        'TraficotipoviajeBindingSource
        '
        Me.TraficotipoviajeBindingSource.DataMember = "trafico_tipo_viaje"
        Me.TraficotipoviajeBindingSource.DataSource = Me.ProduccionInterfletdbDataSet9
        '
        'ProduccionInterfletdbDataSet9
        '
        Me.ProduccionInterfletdbDataSet9.DataSetName = "ProduccionInterfletdbDataSet9"
        Me.ProduccionInterfletdbDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Id_Num_Origen
        '
        Me.Id_Num_Origen.DataPropertyName = "Id_Num_Origen"
        Me.Id_Num_Origen.HeaderText = "Id_Num_Origen"
        Me.Id_Num_Origen.Name = "Id_Num_Origen"
        Me.Id_Num_Origen.Visible = False
        '
        'Id_Num_Destino
        '
        Me.Id_Num_Destino.DataPropertyName = "Id_Num_Destino"
        Me.Id_Num_Destino.HeaderText = "Id_Num_Destino"
        Me.Id_Num_Destino.Name = "Id_Num_Destino"
        Me.Id_Num_Destino.Visible = False
        '
        'Id_Cliente
        '
        Me.Id_Cliente.DataPropertyName = "Id_Cliente"
        Me.Id_Cliente.HeaderText = "Id_Cliente"
        Me.Id_Cliente.Name = "Id_Cliente"
        Me.Id_Cliente.Visible = False
        '
        'TipoViaje
        '
        Me.TipoViaje.DataPropertyName = "TipoViaje"
        Me.TipoViaje.HeaderText = "TipoViaje"
        Me.TipoViaje.Name = "TipoViaje"
        Me.TipoViaje.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TipoViaje.Visible = False
        '
        'Id_Tipo_Motor
        '
        Me.Id_Tipo_Motor.DataPropertyName = "Id_Tipo_Motor"
        Me.Id_Tipo_Motor.HeaderText = "Id_Tipo_Motor"
        Me.Id_Tipo_Motor.Name = "Id_Tipo_Motor"
        Me.Id_Tipo_Motor.Visible = False
        '
        'RangoPesoIni
        '
        Me.RangoPesoIni.DataPropertyName = "RangoPesoIni"
        Me.RangoPesoIni.HeaderText = "Rango de Peso Inicial"
        Me.RangoPesoIni.Name = "RangoPesoIni"
        Me.RangoPesoIni.Width = 90
        '
        'RangoPesoFin
        '
        Me.RangoPesoFin.DataPropertyName = "RangoPesoFin"
        Me.RangoPesoFin.HeaderText = "Rango de Peso Final"
        Me.RangoPesoFin.Name = "RangoPesoFin"
        Me.RangoPesoFin.Width = 90
        '
        'KmPromedio
        '
        Me.KmPromedio.DataPropertyName = "KmPromedio"
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.KmPromedio.DefaultCellStyle = DataGridViewCellStyle1
        Me.KmPromedio.HeaderText = "KM Promedio"
        Me.KmPromedio.Name = "KmPromedio"
        Me.KmPromedio.Width = 70
        '
        'LtsPromedio
        '
        Me.LtsPromedio.DataPropertyName = "LtsPromedio"
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.LtsPromedio.DefaultCellStyle = DataGridViewCellStyle2
        Me.LtsPromedio.HeaderText = "Litros Promedio"
        Me.LtsPromedio.Name = "LtsPromedio"
        Me.LtsPromedio.Width = 70
        '
        'RendPromedio
        '
        Me.RendPromedio.DataPropertyName = "RendPromedio"
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.RendPromedio.DefaultCellStyle = DataGridViewCellStyle3
        Me.RendPromedio.HeaderText = "Rendimiento Promedio"
        Me.RendPromedio.Name = "RendPromedio"
        Me.RendPromedio.Width = 70
        '
        'CantViajes
        '
        Me.CantViajes.DataPropertyName = "CantViajes"
        DataGridViewCellStyle4.Format = "N0"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.CantViajes.DefaultCellStyle = DataGridViewCellStyle4
        Me.CantViajes.HeaderText = "Cantidad de Viajes"
        Me.CantViajes.Name = "CantViajes"
        Me.CantViajes.Width = 70
        '
        'FecMovtoDataGridViewTextBoxColumn
        '
        Me.FecMovtoDataGridViewTextBoxColumn.DataPropertyName = "Fec_Movto"
        Me.FecMovtoDataGridViewTextBoxColumn.HeaderText = "Fec_Movto"
        Me.FecMovtoDataGridViewTextBoxColumn.Name = "FecMovtoDataGridViewTextBoxColumn"
        Me.FecMovtoDataGridViewTextBoxColumn.Visible = False
        '
        'UserIdDataGridViewTextBoxColumn
        '
        Me.UserIdDataGridViewTextBoxColumn.DataPropertyName = "UserId"
        Me.UserIdDataGridViewTextBoxColumn.HeaderText = "UserId"
        Me.UserIdDataGridViewTextBoxColumn.Name = "UserIdDataGridViewTextBoxColumn"
        Me.UserIdDataGridViewTextBoxColumn.Visible = False
        '
        'CatRendimientosEstBindingSource
        '
        Me.CatRendimientosEstBindingSource.DataMember = "Cat_RendimientosEst"
        Me.CatRendimientosEstBindingSource.DataSource = Me.PI_Rendimientos
        '
        'PI_Rendimientos
        '
        Me.PI_Rendimientos.DataSetName = "PI_Rendimientos"
        Me.PI_Rendimientos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Cat_RendimientosEstTableAdapter
        '
        Me.Cat_RendimientosEstTableAdapter.ClearBeforeFill = True
        '
        'Trafico_motorTableAdapter
        '
        Me.Trafico_motorTableAdapter.ClearBeforeFill = True
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.BindingSource = Me.CatRendimientosEstBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Dock = System.Windows.Forms.DockStyle.None
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.btnGuardar, Me.btnExportar, Me.toolStripSeparator, Me.CortarToolStripButton})
        Me.BindingNavigator1.Location = New System.Drawing.Point(5, 106)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(308, 25)
        Me.BindingNavigator1.TabIndex = 16
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnGuardar
        '
        Me.btnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(23, 22)
        '
        'btnExportar
        '
        Me.btnExportar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnExportar.Enabled = False
        Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
        Me.btnExportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(23, 22)
        Me.btnExportar.Text = "ToolStripButton1"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'CortarToolStripButton
        '
        Me.CortarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CortarToolStripButton.Image = CType(resources.GetObject("CortarToolStripButton.Image"), System.Drawing.Image)
        Me.CortarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CortarToolStripButton.Name = "CortarToolStripButton"
        Me.CortarToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.CortarToolStripButton.Text = "Cort&ar"
        '
        'TraficoplazaBindingSource
        '
        Me.TraficoplazaBindingSource.DataMember = "trafico_plaza"
        Me.TraficoplazaBindingSource.DataSource = Me.ProduccionInterfletdbDataSet2BindingSource
        '
        'Trafico_rutaTableAdapter
        '
        Me.Trafico_rutaTableAdapter.ClearBeforeFill = True
        '
        'Trafico_clienteTableAdapter
        '
        Me.Trafico_clienteTableAdapter.ClearBeforeFill = True
        '
        'Trafico_tipo_viajeTableAdapter
        '
        Me.Trafico_tipo_viajeTableAdapter.ClearBeforeFill = True
        '
        'frmCatRendmientosProm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(810, 615)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.grdRendimientos)
        Me.Controls.Add(Me.gbFiltros)
        Me.Name = "frmCatRendmientosProm"
        Me.Text = "Catálogo de Rendmientos Promedio"
        CType(Me.ProduccionInterfletdbDataSet2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProduccionInterfletdbDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbFiltros.ResumeLayout(False)
        Me.gbFiltros.PerformLayout()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PI_Clientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TraficorutaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PI_Ruta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProduccionInterfletdbDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProduccionInterfletdbDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdRendimientos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TraficomotorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PI_TipoMotor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TraficotipoviajeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProduccionInterfletdbDataSet9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CatRendimientosEstBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PI_Rendimientos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.TraficoplazaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbOrigen As System.Windows.Forms.ComboBox
    Friend WithEvents gbFiltros As System.Windows.Forms.GroupBox
    Friend WithEvents cmbDestino As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ProduccionInterfletdbDataSet2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProduccionInterfletdbDataSet2 As Interflet.ProduccionInterfletdbDataSet2
    Friend WithEvents Trafico_plazaTableAdapter As Interflet.ProduccionInterfletdbDataSet2TableAdapters.trafico_plazaTableAdapter
    Friend WithEvents ProduccionInterfletdbDataSet1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProduccionInterfletdbDataSet1 As Interflet.ProduccionInterfletdbDataSet1
    Friend WithEvents Cat_DestinoTableAdapter As Interflet.ProduccionInterfletdbDataSet1TableAdapters.Cat_DestinoTableAdapter
    Friend WithEvents cmbCliente As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PI_Clientes As Interflet.PI_Clientes
    Friend WithEvents ClienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClienteTableAdapter As Interflet.PI_ClientesTableAdapters.clienteTableAdapter
    Friend WithEvents grdRendimientos As System.Windows.Forms.DataGridView
    Friend WithEvents PI_Rendimientos As Interflet.PI_Rendimientos
    Friend WithEvents CatRendimientosEstBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Cat_RendimientosEstTableAdapter As Interflet.PI_RendimientosTableAdapters.Cat_RendimientosEstTableAdapter
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents PI_TipoMotor As Interflet.PI_TipoMotor
    Friend WithEvents TraficomotorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Trafico_motorTableAdapter As Interflet.PI_TipoMotorTableAdapters.trafico_motorTableAdapter
    Friend WithEvents TipoMotorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents TraficoplazaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PI_Ruta As Interflet.PI_Ruta
    Friend WithEvents TraficorutaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Trafico_rutaTableAdapter As Interflet.PI_RutaTableAdapters.trafico_rutaTableAdapter
    Friend WithEvents Trafico_clienteTableAdapter As Interflet.PI_ClientesTableAdapters.trafico_clienteTableAdapter
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CortarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ProduccionInterfletdbDataSet9 As Interflet.ProduccionInterfletdbDataSet9
    Friend WithEvents TraficotipoviajeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Trafico_tipo_viajeTableAdapter As Interflet.ProduccionInterfletdbDataSet9TableAdapters.trafico_tipo_viajeTableAdapter
    Friend WithEvents TipoMotor As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents TipoViaje2 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Id_Num_Origen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id_Num_Destino As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id_Cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoViaje As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id_Tipo_Motor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RangoPesoIni As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RangoPesoFin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KmPromedio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LtsPromedio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RendPromedio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantViajes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FecMovtoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UserIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
