<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteCalidad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReporteCalidad))
        Me.gbfiltros = New System.Windows.Forms.GroupBox
        Me.btnExportar = New System.Windows.Forms.Button
        Me.cmbArea = New System.Windows.Forms.ComboBox
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.cmbFechaFin = New System.Windows.Forms.DateTimePicker
        Me.cmbFechaIni = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.grdReporteGral = New System.Windows.Forms.DataGridView
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NoEcoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OperadorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PlacasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ViajeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ReferenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClientePlantaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DestinoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TalonCPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ContenedoresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TipoOperDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DollyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ETAPlantaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ObservacionesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TiempoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TardeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IMPODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EXPODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ContDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CGDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CamionetaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PermDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ExternoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DiaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UPConsultaReporteCalidadv2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PI_Calidad = New Interflet.PI_Calidad
        Me.grdTotalDiasMes = New System.Windows.Forms.DataGridView
        Me.grdTotalDiasSemana = New System.Windows.Forms.DataGridView
        Me.grdTotalXCliente = New System.Windows.Forms.DataGridView
        Me.gbCompleto = New System.Windows.Forms.GroupBox
        Me.gbDetalleCliente = New System.Windows.Forms.GroupBox
        Me.gbTotalesMes = New System.Windows.Forms.GroupBox
        Me.gbTotalesSemana = New System.Windows.Forms.GroupBox
        Me.UP_Consulta_ReporteCalidad_v2TableAdapter = New Interflet.PI_CalidadTableAdapters.UP_Consulta_ReporteCalidad_v2TableAdapter
        Me.cmbTipo = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.gbfiltros.SuspendLayout()
        CType(Me.grdReporteGral, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UPConsultaReporteCalidadv2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PI_Calidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdTotalDiasMes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdTotalDiasSemana, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdTotalXCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbCompleto.SuspendLayout()
        Me.gbDetalleCliente.SuspendLayout()
        Me.gbTotalesMes.SuspendLayout()
        Me.gbTotalesSemana.SuspendLayout()
        Me.SuspendLayout()



        Me.gbfiltros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbfiltros.BackColor = System.Drawing.Color.Transparent
        Me.gbfiltros.Controls.Add(Me.Label4)
        Me.gbfiltros.Controls.Add(Me.cmbTipo)
        Me.gbfiltros.Controls.Add(Me.btnExportar)
        Me.gbfiltros.Controls.Add(Me.cmbArea)
        Me.gbfiltros.Controls.Add(Me.btnBuscar)
        Me.gbfiltros.Controls.Add(Me.cmbFechaFin)
        Me.gbfiltros.Controls.Add(Me.cmbFechaIni)
        Me.gbfiltros.Controls.Add(Me.Label2)
        Me.gbfiltros.Controls.Add(Me.Label1)
        Me.gbfiltros.Controls.Add(Me.Label3)
        Me.gbfiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbfiltros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbfiltros.Location = New System.Drawing.Point(3, 5)
        Me.gbfiltros.Name = "gbfiltros"
        Me.gbfiltros.Size = New System.Drawing.Size(1109, 60)
        Me.gbfiltros.TabIndex = 0
        Me.gbfiltros.TabStop = False
        Me.gbfiltros.Text = "Seleccione los filtros de busqueda"



        Me.btnExportar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnExportar.Location = New System.Drawing.Point(999, 10)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(89, 36)
        Me.btnExportar.TabIndex = 7
        Me.btnExportar.Text = "Exportar"
        Me.btnExportar.UseVisualStyleBackColor = False



        Me.cmbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbArea.FormattingEnabled = True
        Me.cmbArea.Location = New System.Drawing.Point(482, 18)
        Me.cmbArea.Name = "cmbArea"
        Me.cmbArea.Size = New System.Drawing.Size(121, 23)
        Me.cmbArea.TabIndex = 5



        Me.btnBuscar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnBuscar.Location = New System.Drawing.Point(890, 10)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(103, 36)
        Me.btnBuscar.TabIndex = 4
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False



        Me.cmbFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmbFechaFin.Location = New System.Drawing.Point(313, 18)
        Me.cmbFechaFin.Name = "cmbFechaFin"
        Me.cmbFechaFin.Size = New System.Drawing.Size(105, 21)
        Me.cmbFechaFin.TabIndex = 3



        Me.cmbFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmbFechaIni.Location = New System.Drawing.Point(102, 18)
        Me.cmbFechaIni.Name = "cmbFechaIni"
        Me.cmbFechaIni.Size = New System.Drawing.Size(105, 21)
        Me.cmbFechaIni.TabIndex = 2



        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(230, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha Final"



        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha Inicial"



        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(442, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Área"



        Me.grdReporteGral.AllowUserToAddRows = False
        Me.grdReporteGral.AllowUserToDeleteRows = False
        Me.grdReporteGral.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        Me.grdReporteGral.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdReporteGral.AutoGenerateColumns = False
        Me.grdReporteGral.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.grdReporteGral.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FechaDataGridViewTextBoxColumn, Me.NoEcoDataGridViewTextBoxColumn, Me.OperadorDataGridViewTextBoxColumn, Me.PlacasDataGridViewTextBoxColumn, Me.ViajeDataGridViewTextBoxColumn, Me.ReferenciaDataGridViewTextBoxColumn, Me.ClientePlantaDataGridViewTextBoxColumn, Me.DestinoDataGridViewTextBoxColumn, Me.TalonCPDataGridViewTextBoxColumn, Me.ContenedoresDataGridViewTextBoxColumn, Me.TipoOperDataGridViewTextBoxColumn, Me.DollyDataGridViewTextBoxColumn, Me.ETAPlantaDataGridViewTextBoxColumn, Me.ObservacionesDataGridViewTextBoxColumn, Me.TiempoDataGridViewTextBoxColumn, Me.TardeDataGridViewTextBoxColumn, Me.IMPODataGridViewTextBoxColumn, Me.EXPODataGridViewTextBoxColumn, Me.ContDataGridViewTextBoxColumn, Me.CGDataGridViewTextBoxColumn, Me.CamionetaDataGridViewTextBoxColumn, Me.PermDataGridViewTextBoxColumn, Me.ExternoDataGridViewTextBoxColumn, Me.DiaDataGridViewTextBoxColumn})
        Me.grdReporteGral.DataSource = Me.UPConsultaReporteCalidadv2BindingSource
        Me.grdReporteGral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdReporteGral.Location = New System.Drawing.Point(3, 16)
        Me.grdReporteGral.Name = "grdReporteGral"
        Me.grdReporteGral.ReadOnly = True
        Me.grdReporteGral.RowHeadersWidth = 15
        Me.grdReporteGral.Size = New System.Drawing.Size(1103, 285)
        Me.grdReporteGral.TabIndex = 1



        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaDataGridViewTextBoxColumn.Width = 70



        Me.NoEcoDataGridViewTextBoxColumn.DataPropertyName = "No. Eco"
        Me.NoEcoDataGridViewTextBoxColumn.HeaderText = "Unidad"
        Me.NoEcoDataGridViewTextBoxColumn.Name = "NoEcoDataGridViewTextBoxColumn"
        Me.NoEcoDataGridViewTextBoxColumn.ReadOnly = True
        Me.NoEcoDataGridViewTextBoxColumn.Width = 50



        Me.OperadorDataGridViewTextBoxColumn.DataPropertyName = "Operador"
        Me.OperadorDataGridViewTextBoxColumn.HeaderText = "Operador"
        Me.OperadorDataGridViewTextBoxColumn.Name = "OperadorDataGridViewTextBoxColumn"
        Me.OperadorDataGridViewTextBoxColumn.ReadOnly = True



        Me.PlacasDataGridViewTextBoxColumn.DataPropertyName = "Placas"
        Me.PlacasDataGridViewTextBoxColumn.HeaderText = "Placas"
        Me.PlacasDataGridViewTextBoxColumn.Name = "PlacasDataGridViewTextBoxColumn"
        Me.PlacasDataGridViewTextBoxColumn.ReadOnly = True
        Me.PlacasDataGridViewTextBoxColumn.Width = 60



        Me.ViajeDataGridViewTextBoxColumn.DataPropertyName = "Viaje"
        Me.ViajeDataGridViewTextBoxColumn.HeaderText = "Viaje"
        Me.ViajeDataGridViewTextBoxColumn.Name = "ViajeDataGridViewTextBoxColumn"
        Me.ViajeDataGridViewTextBoxColumn.ReadOnly = True
        Me.ViajeDataGridViewTextBoxColumn.Width = 50



        Me.ReferenciaDataGridViewTextBoxColumn.DataPropertyName = "Referencia"
        Me.ReferenciaDataGridViewTextBoxColumn.HeaderText = "Referencia"
        Me.ReferenciaDataGridViewTextBoxColumn.Name = "ReferenciaDataGridViewTextBoxColumn"
        Me.ReferenciaDataGridViewTextBoxColumn.ReadOnly = True



        Me.ClientePlantaDataGridViewTextBoxColumn.DataPropertyName = "Cliente Planta"
        Me.ClientePlantaDataGridViewTextBoxColumn.HeaderText = "Planta Cliente"
        Me.ClientePlantaDataGridViewTextBoxColumn.Name = "ClientePlantaDataGridViewTextBoxColumn"
        Me.ClientePlantaDataGridViewTextBoxColumn.ReadOnly = True



        Me.DestinoDataGridViewTextBoxColumn.DataPropertyName = "destino"
        Me.DestinoDataGridViewTextBoxColumn.HeaderText = "Destino"
        Me.DestinoDataGridViewTextBoxColumn.Name = "DestinoDataGridViewTextBoxColumn"
        Me.DestinoDataGridViewTextBoxColumn.ReadOnly = True



        Me.TalonCPDataGridViewTextBoxColumn.DataPropertyName = "Talon CP"
        Me.TalonCPDataGridViewTextBoxColumn.HeaderText = "Talon CP"
        Me.TalonCPDataGridViewTextBoxColumn.Name = "TalonCPDataGridViewTextBoxColumn"
        Me.TalonCPDataGridViewTextBoxColumn.ReadOnly = True
        Me.TalonCPDataGridViewTextBoxColumn.Width = 70



        Me.ContenedoresDataGridViewTextBoxColumn.DataPropertyName = "Contenedores"
        Me.ContenedoresDataGridViewTextBoxColumn.HeaderText = "Contenedores"
        Me.ContenedoresDataGridViewTextBoxColumn.Name = "ContenedoresDataGridViewTextBoxColumn"
        Me.ContenedoresDataGridViewTextBoxColumn.ReadOnly = True



        Me.TipoOperDataGridViewTextBoxColumn.DataPropertyName = "Tipo Oper"
        Me.TipoOperDataGridViewTextBoxColumn.HeaderText = "Tipo Oper"
        Me.TipoOperDataGridViewTextBoxColumn.Name = "TipoOperDataGridViewTextBoxColumn"
        Me.TipoOperDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoOperDataGridViewTextBoxColumn.Width = 60



        Me.DollyDataGridViewTextBoxColumn.DataPropertyName = "Dolly"
        Me.DollyDataGridViewTextBoxColumn.HeaderText = "Dolly"
        Me.DollyDataGridViewTextBoxColumn.Name = "DollyDataGridViewTextBoxColumn"
        Me.DollyDataGridViewTextBoxColumn.ReadOnly = True
        Me.DollyDataGridViewTextBoxColumn.Width = 40



        Me.ETAPlantaDataGridViewTextBoxColumn.DataPropertyName = "ETA Planta"
        Me.ETAPlantaDataGridViewTextBoxColumn.HeaderText = "ETA Planta"
        Me.ETAPlantaDataGridViewTextBoxColumn.Name = "ETAPlantaDataGridViewTextBoxColumn"
        Me.ETAPlantaDataGridViewTextBoxColumn.ReadOnly = True
        Me.ETAPlantaDataGridViewTextBoxColumn.Width = 70



        Me.ObservacionesDataGridViewTextBoxColumn.DataPropertyName = "Observaciones"
        Me.ObservacionesDataGridViewTextBoxColumn.HeaderText = "Observaciones"
        Me.ObservacionesDataGridViewTextBoxColumn.Name = "ObservacionesDataGridViewTextBoxColumn"
        Me.ObservacionesDataGridViewTextBoxColumn.ReadOnly = True
        Me.ObservacionesDataGridViewTextBoxColumn.Width = 90



        Me.TiempoDataGridViewTextBoxColumn.DataPropertyName = "Tiempo"
        Me.TiempoDataGridViewTextBoxColumn.HeaderText = "Tiempo"
        Me.TiempoDataGridViewTextBoxColumn.Name = "TiempoDataGridViewTextBoxColumn"
        Me.TiempoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TiempoDataGridViewTextBoxColumn.Width = 50



        Me.TardeDataGridViewTextBoxColumn.DataPropertyName = "Tarde"
        Me.TardeDataGridViewTextBoxColumn.HeaderText = "Tarde"
        Me.TardeDataGridViewTextBoxColumn.Name = "TardeDataGridViewTextBoxColumn"
        Me.TardeDataGridViewTextBoxColumn.ReadOnly = True
        Me.TardeDataGridViewTextBoxColumn.Width = 40



        Me.IMPODataGridViewTextBoxColumn.DataPropertyName = "IMPO"
        Me.IMPODataGridViewTextBoxColumn.HeaderText = "IMPO"
        Me.IMPODataGridViewTextBoxColumn.Name = "IMPODataGridViewTextBoxColumn"
        Me.IMPODataGridViewTextBoxColumn.ReadOnly = True
        Me.IMPODataGridViewTextBoxColumn.Width = 40



        Me.EXPODataGridViewTextBoxColumn.DataPropertyName = "EXPO"
        Me.EXPODataGridViewTextBoxColumn.HeaderText = "EXPO"
        Me.EXPODataGridViewTextBoxColumn.Name = "EXPODataGridViewTextBoxColumn"
        Me.EXPODataGridViewTextBoxColumn.ReadOnly = True
        Me.EXPODataGridViewTextBoxColumn.Width = 40



        Me.ContDataGridViewTextBoxColumn.DataPropertyName = "Cont"
        Me.ContDataGridViewTextBoxColumn.HeaderText = "Cont"
        Me.ContDataGridViewTextBoxColumn.Name = "ContDataGridViewTextBoxColumn"
        Me.ContDataGridViewTextBoxColumn.ReadOnly = True
        Me.ContDataGridViewTextBoxColumn.Width = 40



        Me.CGDataGridViewTextBoxColumn.DataPropertyName = "CG"
        Me.CGDataGridViewTextBoxColumn.HeaderText = "CG"
        Me.CGDataGridViewTextBoxColumn.Name = "CGDataGridViewTextBoxColumn"
        Me.CGDataGridViewTextBoxColumn.ReadOnly = True
        Me.CGDataGridViewTextBoxColumn.Width = 30



        Me.CamionetaDataGridViewTextBoxColumn.DataPropertyName = "Camioneta"
        Me.CamionetaDataGridViewTextBoxColumn.HeaderText = "Camioneta"
        Me.CamionetaDataGridViewTextBoxColumn.Name = "CamionetaDataGridViewTextBoxColumn"
        Me.CamionetaDataGridViewTextBoxColumn.ReadOnly = True
        Me.CamionetaDataGridViewTextBoxColumn.Width = 60



        Me.PermDataGridViewTextBoxColumn.DataPropertyName = "Perm"
        Me.PermDataGridViewTextBoxColumn.HeaderText = "Perm"
        Me.PermDataGridViewTextBoxColumn.Name = "PermDataGridViewTextBoxColumn"
        Me.PermDataGridViewTextBoxColumn.ReadOnly = True
        Me.PermDataGridViewTextBoxColumn.Width = 40



        Me.ExternoDataGridViewTextBoxColumn.DataPropertyName = "Externo"
        Me.ExternoDataGridViewTextBoxColumn.HeaderText = "Externo"
        Me.ExternoDataGridViewTextBoxColumn.Name = "ExternoDataGridViewTextBoxColumn"
        Me.ExternoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ExternoDataGridViewTextBoxColumn.Width = 50



        Me.DiaDataGridViewTextBoxColumn.DataPropertyName = "Dia"
        Me.DiaDataGridViewTextBoxColumn.HeaderText = "Dia"
        Me.DiaDataGridViewTextBoxColumn.Name = "DiaDataGridViewTextBoxColumn"
        Me.DiaDataGridViewTextBoxColumn.ReadOnly = True
        Me.DiaDataGridViewTextBoxColumn.Width = 60



        Me.UPConsultaReporteCalidadv2BindingSource.DataMember = "UP_Consulta_ReporteCalidad_v2"
        Me.UPConsultaReporteCalidadv2BindingSource.DataSource = Me.PI_Calidad



        Me.PI_Calidad.DataSetName = "PI_Calidad"
        Me.PI_Calidad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema



        Me.grdTotalDiasMes.AllowUserToAddRows = False
        Me.grdTotalDiasMes.AllowUserToDeleteRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver
        Me.grdTotalDiasMes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.grdTotalDiasMes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdTotalDiasMes.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.grdTotalDiasMes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdTotalDiasMes.Location = New System.Drawing.Point(3, 16)
        Me.grdTotalDiasMes.Name = "grdTotalDiasMes"
        Me.grdTotalDiasMes.RowHeadersWidth = 15
        Me.grdTotalDiasMes.Size = New System.Drawing.Size(741, 51)
        Me.grdTotalDiasMes.TabIndex = 2



        Me.grdTotalDiasSemana.AllowUserToAddRows = False
        Me.grdTotalDiasSemana.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver
        Me.grdTotalDiasSemana.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.grdTotalDiasSemana.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.grdTotalDiasSemana.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdTotalDiasSemana.Location = New System.Drawing.Point(3, 16)
        Me.grdTotalDiasSemana.Name = "grdTotalDiasSemana"
        Me.grdTotalDiasSemana.RowHeadersWidth = 15
        Me.grdTotalDiasSemana.Size = New System.Drawing.Size(354, 51)
        Me.grdTotalDiasSemana.TabIndex = 3



        Me.grdTotalXCliente.AllowUserToAddRows = False
        Me.grdTotalXCliente.AllowUserToDeleteRows = False
        Me.grdTotalXCliente.AllowUserToOrderColumns = True
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver
        Me.grdTotalXCliente.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.grdTotalXCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdTotalXCliente.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.grdTotalXCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdTotalXCliente.Location = New System.Drawing.Point(3, 16)
        Me.grdTotalXCliente.Name = "grdTotalXCliente"
        Me.grdTotalXCliente.RowHeadersWidth = 15
        Me.grdTotalXCliente.Size = New System.Drawing.Size(1103, 269)
        Me.grdTotalXCliente.TabIndex = 4



        Me.gbCompleto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbCompleto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbCompleto.BackColor = System.Drawing.Color.Transparent
        Me.gbCompleto.Controls.Add(Me.grdReporteGral)
        Me.gbCompleto.Location = New System.Drawing.Point(3, 71)
        Me.gbCompleto.Name = "gbCompleto"
        Me.gbCompleto.Size = New System.Drawing.Size(1109, 304)
        Me.gbCompleto.TabIndex = 5
        Me.gbCompleto.TabStop = False
        Me.gbCompleto.Text = "Indicadores Detallados"



        Me.gbDetalleCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbDetalleCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbDetalleCliente.BackColor = System.Drawing.Color.Transparent
        Me.gbDetalleCliente.Controls.Add(Me.grdTotalXCliente)
        Me.gbDetalleCliente.Location = New System.Drawing.Point(3, 381)
        Me.gbDetalleCliente.Name = "gbDetalleCliente"
        Me.gbDetalleCliente.Size = New System.Drawing.Size(1109, 288)
        Me.gbDetalleCliente.TabIndex = 6
        Me.gbDetalleCliente.TabStop = False
        Me.gbDetalleCliente.Text = "Indicadores  Totales por Cliente"



        Me.gbTotalesMes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbTotalesMes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gbTotalesMes.BackColor = System.Drawing.Color.Transparent
        Me.gbTotalesMes.Controls.Add(Me.grdTotalDiasMes)
        Me.gbTotalesMes.Location = New System.Drawing.Point(2, 673)
        Me.gbTotalesMes.Name = "gbTotalesMes"
        Me.gbTotalesMes.Size = New System.Drawing.Size(747, 70)
        Me.gbTotalesMes.TabIndex = 7
        Me.gbTotalesMes.TabStop = False
        Me.gbTotalesMes.Text = "Indicadores Totales por día del mes"



        Me.gbTotalesSemana.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbTotalesSemana.BackColor = System.Drawing.Color.Transparent
        Me.gbTotalesSemana.Controls.Add(Me.grdTotalDiasSemana)
        Me.gbTotalesSemana.Location = New System.Drawing.Point(752, 673)
        Me.gbTotalesSemana.Name = "gbTotalesSemana"
        Me.gbTotalesSemana.Size = New System.Drawing.Size(360, 70)
        Me.gbTotalesSemana.TabIndex = 8
        Me.gbTotalesSemana.TabStop = False
        Me.gbTotalesSemana.Text = "Indicadores Totales por día de la semana"



        Me.UP_Consulta_ReporteCalidad_v2TableAdapter.ClearBeforeFill = True



        Me.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipo.FormattingEnabled = True
        Me.cmbTipo.Location = New System.Drawing.Point(678, 18)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(121, 23)
        Me.cmbTipo.TabIndex = 8



        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(633, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Tipo:"



        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1113, 745)
        Me.Controls.Add(Me.gbDetalleCliente)
        Me.Controls.Add(Me.gbCompleto)
        Me.Controls.Add(Me.gbTotalesSemana)
        Me.Controls.Add(Me.gbTotalesMes)
        Me.Controls.Add(Me.gbfiltros)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReporteCalidad"
        Me.Text = "Reporte de Indicadores de Calidad"
        Me.gbfiltros.ResumeLayout(False)
        Me.gbfiltros.PerformLayout()
        CType(Me.grdReporteGral, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UPConsultaReporteCalidadv2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PI_Calidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdTotalDiasMes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdTotalDiasSemana, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdTotalXCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbCompleto.ResumeLayout(False)
        Me.gbDetalleCliente.ResumeLayout(False)
        Me.gbTotalesMes.ResumeLayout(False)
        Me.gbTotalesSemana.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbfiltros As System.Windows.Forms.GroupBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents cmbFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbFechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbArea As System.Windows.Forms.ComboBox
    Friend WithEvents grdReporteGral As System.Windows.Forms.DataGridView
    Friend WithEvents UPConsultaReporteCalidadv2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PI_Calidad As Interflet.PI_Calidad
    Friend WithEvents UP_Consulta_ReporteCalidad_v2TableAdapter As Interflet.PI_CalidadTableAdapters.UP_Consulta_ReporteCalidad_v2TableAdapter
    Friend WithEvents grdTotalDiasMes As System.Windows.Forms.DataGridView
    Friend WithEvents grdTotalDiasSemana As System.Windows.Forms.DataGridView
    Friend WithEvents grdTotalXCliente As System.Windows.Forms.DataGridView
    Friend WithEvents gbCompleto As System.Windows.Forms.GroupBox
    Friend WithEvents gbDetalleCliente As System.Windows.Forms.GroupBox
    Friend WithEvents gbTotalesMes As System.Windows.Forms.GroupBox
    Friend WithEvents gbTotalesSemana As System.Windows.Forms.GroupBox
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoEcoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OperadorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PlacasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ViajeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReferenciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClientePlantaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DestinoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TalonCPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContenedoresDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoOperDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DollyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ETAPlantaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ObservacionesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TiempoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TardeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IMPODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EXPODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CGDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CamionetaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PermDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExternoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnExportar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbTipo As System.Windows.Forms.ComboBox
End Class
