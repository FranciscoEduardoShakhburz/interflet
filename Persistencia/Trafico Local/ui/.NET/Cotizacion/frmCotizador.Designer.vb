<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCotizador
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCotizador))
        Me.grdResultado = New System.Windows.Forms.DataGridView
        Me.Tarifa = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MtoUtil = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PorcUtil = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Interflet_ConceptosValores = New Interflet.Interflet_ConceptosValores
        Me.cmbDestino = New System.Windows.Forms.ComboBox
        Me.TraficorutaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProduccionInterfletdbDataSet1 = New Interflet.ProduccionInterfletdbDataSet1
        Me.Cat_DestinoTableAdapter = New Interflet.ProduccionInterfletdbDataSet1TableAdapters.Cat_DestinoTableAdapter
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtKm = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbOrigen = New System.Windows.Forms.ComboBox
        Me.TraficoplazaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProduccionInterfletdbDataSet2 = New Interflet.ProduccionInterfletdbDataSet2
        Me.Label4 = New System.Windows.Forms.Label
        Me.Trafico_plazaTableAdapter = New Interflet.ProduccionInterfletdbDataSet2TableAdapters.trafico_plazaTableAdapter
        Me.DieselTableAdapter = New Interflet.ProduccionInterfletdbDataSet4TableAdapters.UP_Consulta_CostoDieselTableAdapter
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtTiempo = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtRendDiesel = New System.Windows.Forms.TextBox
        Me.TxtCasetas = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.TxtCtoDieConsumo = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.BSDiesel = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProduccionInterfletdbDataSet4 = New Interflet.ProduccionInterfletdbDataSet4
        Me.TxtSueldoOper = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.TxtManiobras = New System.Windows.Forms.TextBox
        Me.btnCalcular = New System.Windows.Forms.Button
        Me.btnExportar = New System.Windows.Forms.Button
        Me.TxtComision = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.cmbTipoViaje = New System.Windows.Forms.ComboBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TxtUtilMax = New System.Windows.Forms.TextBox
        Me.TxtUtilMin = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.TxtMtoUtilMax = New System.Windows.Forms.TextBox
        Me.TxtMtoUtilMin = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.TxtIncremento = New System.Windows.Forms.MaskedTextBox
        Me.grdResultadoFull = New System.Windows.Forms.DataGridView
        Me.TarifaFull = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MtoUtilFull = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PorcUtilFull = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label17 = New System.Windows.Forms.Label
        Me.TxtCliente = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.TxtVolumen = New System.Windows.Forms.TextBox
        Me.TxtFrecuencia = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.TxtSobrecosto = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.TxtCtoDiesel = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.cmbTipoRemolque = New System.Windows.Forms.ComboBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox
        Me.cmbTipoCotizacion = New System.Windows.Forms.ComboBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.BtnGuardar = New System.Windows.Forms.Button
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.TxtCotizacionSen = New System.Windows.Forms.TextBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.TxtCotizacionFull = New System.Windows.Forms.TextBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.TxtNoCotizacion = New System.Windows.Forms.TextBox
        Me.TxtPorcCotSen = New System.Windows.Forms.TextBox
        Me.Label31 = New System.Windows.Forms.Label
        Me.TxtPorcCotFull = New System.Windows.Forms.TextBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.TxtObservaciones = New System.Windows.Forms.RichTextBox
        CType(Me.grdResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Interflet_ConceptosValores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TraficorutaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProduccionInterfletdbDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TraficoplazaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProduccionInterfletdbDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSDiesel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProduccionInterfletdbDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.grdResultadoFull, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdResultado
        '
        Me.grdResultado.AllowUserToAddRows = False
        Me.grdResultado.AllowUserToDeleteRows = False
        Me.grdResultado.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.grdResultado.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdResultado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdResultado.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.grdResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdResultado.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grdResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdResultado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Tarifa, Me.MtoUtil, Me.PorcUtil})
        Me.grdResultado.GridColor = System.Drawing.SystemColors.Desktop
        Me.grdResultado.Location = New System.Drawing.Point(364, 35)
        Me.grdResultado.Name = "grdResultado"
        Me.grdResultado.ReadOnly = True
        Me.grdResultado.RowHeadersVisible = False
        Me.grdResultado.RowHeadersWidth = 35
        Me.grdResultado.Size = New System.Drawing.Size(306, 384)
        Me.grdResultado.TabIndex = 0
        '
        'Tarifa
        '
        Me.Tarifa.HeaderText = "Tarifa de Contenedor"
        Me.Tarifa.Name = "Tarifa"
        Me.Tarifa.ReadOnly = True
        '
        'MtoUtil
        '
        Me.MtoUtil.HeaderText = "Monto de Utilidad"
        Me.MtoUtil.Name = "MtoUtil"
        Me.MtoUtil.ReadOnly = True
        '
        'PorcUtil
        '
        Me.PorcUtil.HeaderText = "Porcentaje de Utilidad"
        Me.PorcUtil.Name = "PorcUtil"
        Me.PorcUtil.ReadOnly = True
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = Me.Interflet_ConceptosValores
        Me.BindingSource1.Position = 0
        '
        'Interflet_ConceptosValores
        '
        Me.Interflet_ConceptosValores.DataSetName = "Interflet_ConceptosValores"
        Me.Interflet_ConceptosValores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbDestino
        '
        Me.cmbDestino.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbDestino.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TraficorutaBindingSource, "Desc_Destino", True))
        Me.cmbDestino.DataSource = Me.TraficorutaBindingSource
        Me.cmbDestino.DisplayMember = "Desc_Destino"
        Me.cmbDestino.FormattingEnabled = True
        Me.cmbDestino.Location = New System.Drawing.Point(184, 39)
        Me.cmbDestino.Name = "cmbDestino"
        Me.cmbDestino.Size = New System.Drawing.Size(170, 21)
        Me.cmbDestino.TabIndex = 2
        Me.cmbDestino.ValueMember = "Id_Num_Destino"
        '
        'TraficorutaBindingSource
        '
        Me.TraficorutaBindingSource.DataMember = "Cat_Destino"
        Me.TraficorutaBindingSource.DataSource = Me.ProduccionInterfletdbDataSet1
        '
        'ProduccionInterfletdbDataSet1
        '
        Me.ProduccionInterfletdbDataSet1.DataSetName = "ProduccionInterfletdbDataSet1"
        Me.ProduccionInterfletdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Cat_DestinoTableAdapter
        '
        Me.Cat_DestinoTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(181, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Ruta"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtKm
        '
        Me.TxtKm.Enabled = False
        Me.TxtKm.Location = New System.Drawing.Point(123, 204)
        Me.TxtKm.Name = "TxtKm"
        Me.TxtKm.Size = New System.Drawing.Size(80, 20)
        Me.TxtKm.TabIndex = 3
        Me.TxtKm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(123, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 35)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Kilometros de Viaje:"
        '
        'cmbOrigen
        '
        Me.cmbOrigen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbOrigen.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TraficoplazaBindingSource, "desc_plaza", True))
        Me.cmbOrigen.DataSource = Me.TraficoplazaBindingSource
        Me.cmbOrigen.DisplayMember = "desc_plaza"
        Me.cmbOrigen.FormattingEnabled = True
        Me.cmbOrigen.Location = New System.Drawing.Point(12, 39)
        Me.cmbOrigen.Name = "cmbOrigen"
        Me.cmbOrigen.Size = New System.Drawing.Size(157, 21)
        Me.cmbOrigen.TabIndex = 1
        Me.cmbOrigen.ValueMember = "id_plaza"
        '
        'TraficoplazaBindingSource
        '
        Me.TraficoplazaBindingSource.DataMember = "trafico_plaza"
        Me.TraficoplazaBindingSource.DataSource = Me.ProduccionInterfletdbDataSet2
        '
        'ProduccionInterfletdbDataSet2
        '
        Me.ProduccionInterfletdbDataSet2.DataSetName = "ProduccionInterfletdbDataSet2"
        Me.ProduccionInterfletdbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Plaza Origen"
        '
        'Trafico_plazaTableAdapter
        '
        Me.Trafico_plazaTableAdapter.ClearBeforeFill = True
        '
        'DieselTableAdapter
        '
        Me.DieselTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(233, 174)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 35)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Días de Viaje"
        '
        'TxtTiempo
        '
        Me.TxtTiempo.Enabled = False
        Me.TxtTiempo.Location = New System.Drawing.Point(234, 204)
        Me.TxtTiempo.Name = "TxtTiempo"
        Me.TxtTiempo.Size = New System.Drawing.Size(70, 20)
        Me.TxtTiempo.TabIndex = 11
        Me.TxtTiempo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(123, 242)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 35)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Rendimiento Diesel"
        '
        'TxtRendDiesel
        '
        Me.TxtRendDiesel.Enabled = False
        Me.TxtRendDiesel.Location = New System.Drawing.Point(123, 271)
        Me.TxtRendDiesel.Name = "TxtRendDiesel"
        Me.TxtRendDiesel.Size = New System.Drawing.Size(80, 20)
        Me.TxtRendDiesel.TabIndex = 13
        Me.TxtRendDiesel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtCasetas
        '
        Me.TxtCasetas.Enabled = False
        Me.TxtCasetas.Location = New System.Drawing.Point(12, 272)
        Me.TxtCasetas.Name = "TxtCasetas"
        Me.TxtCasetas.Size = New System.Drawing.Size(78, 20)
        Me.TxtCasetas.TabIndex = 14
        Me.TxtCasetas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 242)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 35)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Monto de Casetas"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(228, 311)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 35)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "% Comisión Vendedor"
        '
        'TxtCtoDieConsumo
        '
        Me.TxtCtoDieConsumo.Enabled = False
        Me.TxtCtoDieConsumo.Location = New System.Drawing.Point(12, 342)
        Me.TxtCtoDieConsumo.Name = "TxtCtoDieConsumo"
        Me.TxtCtoDieConsumo.Size = New System.Drawing.Size(78, 20)
        Me.TxtCtoDieConsumo.TabIndex = 18
        Me.TxtCtoDieConsumo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 312)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 35)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "$ Diesel Consumido"
        '
        'BSDiesel
        '
        Me.BSDiesel.DataSource = Me.ProduccionInterfletdbDataSet4
        Me.BSDiesel.Position = 0
        '
        'ProduccionInterfletdbDataSet4
        '
        Me.ProduccionInterfletdbDataSet4.DataSetName = "ProduccionInterfletdbDataSet4"
        Me.ProduccionInterfletdbDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TxtSueldoOper
        '
        Me.TxtSueldoOper.Location = New System.Drawing.Point(12, 408)
        Me.TxtSueldoOper.Name = "TxtSueldoOper"
        Me.TxtSueldoOper.Size = New System.Drawing.Size(78, 20)
        Me.TxtSueldoOper.TabIndex = 10
        Me.TxtSueldoOper.Text = "10"
        Me.TxtSueldoOper.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 377)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 35)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "% Sueldo Operador"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(119, 323)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 15)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "$ Maniobras"
        '
        'TxtManiobras
        '
        Me.TxtManiobras.Location = New System.Drawing.Point(119, 342)
        Me.TxtManiobras.Name = "TxtManiobras"
        Me.TxtManiobras.Size = New System.Drawing.Size(87, 20)
        Me.TxtManiobras.TabIndex = 8
        Me.TxtManiobras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnCalcular
        '
        Me.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.Location = New System.Drawing.Point(364, 675)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(89, 31)
        Me.btnCalcular.TabIndex = 18
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnExportar
        '
        Me.btnExportar.Enabled = False
        Me.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportar.Location = New System.Drawing.Point(472, 675)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(89, 31)
        Me.btnExportar.TabIndex = 19
        Me.btnExportar.Text = "Exportar"
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'TxtComision
        '
        Me.TxtComision.Location = New System.Drawing.Point(228, 342)
        Me.TxtComision.Name = "TxtComision"
        Me.TxtComision.Size = New System.Drawing.Size(80, 20)
        Me.TxtComision.TabIndex = 9
        Me.TxtComision.Text = "1"
        Me.TxtComision.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 121)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 15)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "Tipo de Viaje"
        '
        'cmbTipoViaje
        '
        Me.cmbTipoViaje.FormattingEnabled = True
        Me.cmbTipoViaje.Items.AddRange(New Object() {"Sencillo", "Full"})
        Me.cmbTipoViaje.Location = New System.Drawing.Point(12, 140)
        Me.cmbTipoViaje.Name = "cmbTipoViaje"
        Me.cmbTipoViaje.Size = New System.Drawing.Size(126, 21)
        Me.cmbTipoViaje.TabIndex = 4
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(362, 538)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(308, 97)
        Me.TabControl1.TabIndex = 17
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Transparent
        Me.TabPage1.Controls.Add(Me.TxtUtilMax)
        Me.TabPage1.Controls.Add(Me.TxtUtilMin)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(300, 69)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Consulta por Porcentaje"
        '
        'TxtUtilMax
        '
        Me.TxtUtilMax.Location = New System.Drawing.Point(159, 39)
        Me.TxtUtilMax.Name = "TxtUtilMax"
        Me.TxtUtilMax.Size = New System.Drawing.Size(88, 22)
        Me.TxtUtilMax.TabIndex = 39
        '
        'TxtUtilMin
        '
        Me.TxtUtilMin.Location = New System.Drawing.Point(160, 10)
        Me.TxtUtilMin.Name = "TxtUtilMin"
        Me.TxtUtilMin.Size = New System.Drawing.Size(88, 22)
        Me.TxtUtilMin.TabIndex = 38
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(11, 41)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(128, 15)
        Me.Label15.TabIndex = 37
        Me.Label15.Text = "% Utilidad Maxima"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(11, 11)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(125, 15)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "% Utilidad Minima"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Transparent
        Me.TabPage2.Controls.Add(Me.TxtMtoUtilMax)
        Me.TabPage2.Controls.Add(Me.TxtMtoUtilMin)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(300, 69)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Consulta por Precio"
        '
        'TxtMtoUtilMax
        '
        Me.TxtMtoUtilMax.Location = New System.Drawing.Point(160, 37)
        Me.TxtMtoUtilMax.Name = "TxtMtoUtilMax"
        Me.TxtMtoUtilMax.Size = New System.Drawing.Size(88, 21)
        Me.TxtMtoUtilMax.TabIndex = 43
        '
        'TxtMtoUtilMin
        '
        Me.TxtMtoUtilMin.Location = New System.Drawing.Point(160, 10)
        Me.TxtMtoUtilMin.Name = "TxtMtoUtilMin"
        Me.TxtMtoUtilMin.Size = New System.Drawing.Size(88, 21)
        Me.TxtMtoUtilMin.TabIndex = 42
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(11, 39)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(111, 15)
        Me.Label12.TabIndex = 41
        Me.Label12.Text = "$ Tarifa Maxima"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(11, 11)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(108, 15)
        Me.Label13.TabIndex = 40
        Me.Label13.Text = "$ Tarifa Minima"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(121, 510)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(79, 15)
        Me.Label16.TabIndex = 41
        Me.Label16.Text = "Incremento"
        '
        'TxtIncremento
        '
        Me.TxtIncremento.Location = New System.Drawing.Point(121, 525)
        Me.TxtIncremento.Mask = "99999"
        Me.TxtIncremento.Name = "TxtIncremento"
        Me.TxtIncremento.Size = New System.Drawing.Size(85, 20)
        Me.TxtIncremento.TabIndex = 15
        Me.TxtIncremento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtIncremento.ValidatingType = GetType(Integer)
        '
        'grdResultadoFull
        '
        Me.grdResultadoFull.AllowUserToAddRows = False
        Me.grdResultadoFull.AllowUserToDeleteRows = False
        Me.grdResultadoFull.AllowUserToOrderColumns = True
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.grdResultadoFull.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.grdResultadoFull.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.grdResultadoFull.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdResultadoFull.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.grdResultadoFull.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdResultadoFull.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TarifaFull, Me.MtoUtilFull, Me.PorcUtilFull})
        Me.grdResultadoFull.GridColor = System.Drawing.SystemColors.ControlLight
        Me.grdResultadoFull.Location = New System.Drawing.Point(674, 36)
        Me.grdResultadoFull.Name = "grdResultadoFull"
        Me.grdResultadoFull.ReadOnly = True
        Me.grdResultadoFull.RowHeadersVisible = False
        Me.grdResultadoFull.Size = New System.Drawing.Size(306, 383)
        Me.grdResultadoFull.TabIndex = 42
        '
        'TarifaFull
        '
        Me.TarifaFull.HeaderText = "Tarifa de Contenedor"
        Me.TarifaFull.Name = "TarifaFull"
        Me.TarifaFull.ReadOnly = True
        '
        'MtoUtilFull
        '
        Me.MtoUtilFull.HeaderText = "Monto de Utilidad"
        Me.MtoUtilFull.Name = "MtoUtilFull"
        Me.MtoUtilFull.ReadOnly = True
        '
        'PorcUtilFull
        '
        Me.PorcUtilFull.HeaderText = "Porcentaje de Utilidad"
        Me.PorcUtilFull.Name = "PorcUtilFull"
        Me.PorcUtilFull.ReadOnly = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(12, 69)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(52, 15)
        Me.Label17.TabIndex = 43
        Me.Label17.Text = "Cliente"
        '
        'TxtCliente
        '
        Me.TxtCliente.Location = New System.Drawing.Point(12, 86)
        Me.TxtCliente.MaxLength = 250
        Me.TxtCliente.Name = "TxtCliente"
        Me.TxtCliente.Size = New System.Drawing.Size(338, 20)
        Me.TxtCliente.TabIndex = 3
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(12, 450)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(63, 15)
        Me.Label18.TabIndex = 46
        Me.Label18.Text = "Volumen"
        '
        'TxtVolumen
        '
        Me.TxtVolumen.Location = New System.Drawing.Point(12, 466)
        Me.TxtVolumen.Name = "TxtVolumen"
        Me.TxtVolumen.Size = New System.Drawing.Size(90, 20)
        Me.TxtVolumen.TabIndex = 12
        '
        'TxtFrecuencia
        '
        Me.TxtFrecuencia.Location = New System.Drawing.Point(159, 466)
        Me.TxtFrecuencia.MaxLength = 100
        Me.TxtFrecuencia.Name = "TxtFrecuencia"
        Me.TxtFrecuencia.Size = New System.Drawing.Size(140, 20)
        Me.TxtFrecuencia.TabIndex = 13
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(159, 450)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(78, 15)
        Me.Label19.TabIndex = 48
        Me.Label19.Text = "Frecuencia"
        '
        'TxtSobrecosto
        '
        Me.TxtSobrecosto.Location = New System.Drawing.Point(9, 525)
        Me.TxtSobrecosto.Name = "TxtSobrecosto"
        Me.TxtSobrecosto.Size = New System.Drawing.Size(80, 20)
        Me.TxtSobrecosto.TabIndex = 14
        Me.TxtSobrecosto.Text = "0"
        Me.TxtSobrecosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(9, 509)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(98, 21)
        Me.Label20.TabIndex = 51
        Me.Label20.Text = "% Sobrecosto"
        '
        'TxtCtoDiesel
        '
        Me.TxtCtoDiesel.Location = New System.Drawing.Point(232, 271)
        Me.TxtCtoDiesel.Name = "TxtCtoDiesel"
        Me.TxtCtoDiesel.Size = New System.Drawing.Size(74, 20)
        Me.TxtCtoDiesel.TabIndex = 7
        Me.TxtCtoDiesel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(232, 255)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(60, 15)
        Me.Label21.TabIndex = 53
        Me.Label21.Text = "$ Diesel"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.CheckAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(119, 408)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(210, 19)
        Me.CheckBox1.TabIndex = 11
        Me.CheckBox1.Text = "Tiene Seguro de Contenedor"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(185, 121)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(125, 15)
        Me.Label22.TabIndex = 55
        Me.Label22.Text = "Tipo de Remolque"
        '
        'cmbTipoRemolque
        '
        Me.cmbTipoRemolque.FormattingEnabled = True
        Me.cmbTipoRemolque.Items.AddRange(New Object() {"Chasis Fijo de 24'", "Chasis de 40'", "Chasis Extendible 30'-40'"})
        Me.cmbTipoRemolque.Location = New System.Drawing.Point(184, 140)
        Me.cmbTipoRemolque.Name = "cmbTipoRemolque"
        Me.cmbTipoRemolque.Size = New System.Drawing.Size(126, 21)
        Me.cmbTipoRemolque.TabIndex = 5
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(12, 186)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(39, 15)
        Me.Label23.TabIndex = 57
        Me.Label23.Text = "Peso"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(12, 204)
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(86, 20)
        Me.MaskedTextBox1.TabIndex = 6
        '
        'cmbTipoCotizacion
        '
        Me.cmbTipoCotizacion.FormattingEnabled = True
        Me.cmbTipoCotizacion.Items.AddRange(New Object() {"Sencillo", "Full", "Sencillo - Full"})
        Me.cmbTipoCotizacion.Location = New System.Drawing.Point(9, 581)
        Me.cmbTipoCotizacion.Name = "cmbTipoCotizacion"
        Me.cmbTipoCotizacion.Size = New System.Drawing.Size(126, 21)
        Me.cmbTipoCotizacion.TabIndex = 16
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(9, 564)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(126, 15)
        Me.Label24.TabIndex = 59
        Me.Label24.Text = "Tipo de Cotización"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Enabled = False
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Location = New System.Drawing.Point(583, 675)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(89, 31)
        Me.BtnGuardar.TabIndex = 20
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(99, 469)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(52, 15)
        Me.Label25.TabIndex = 61
        Me.Label25.Text = "Cargas"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(363, 17)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(180, 16)
        Me.Label26.TabIndex = 62
        Me.Label26.Text = "Cotización Viaje Sencillo"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(673, 18)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(149, 16)
        Me.Label27.TabIndex = 63
        Me.Label27.Text = "Cotización Viaje Full"
        '
        'TxtCotizacionSen
        '
        Me.TxtCotizacionSen.Enabled = False
        Me.TxtCotizacionSen.Location = New System.Drawing.Point(414, 449)
        Me.TxtCotizacionSen.Name = "TxtCotizacionSen"
        Me.TxtCotizacionSen.Size = New System.Drawing.Size(91, 20)
        Me.TxtCotizacionSen.TabIndex = 64
        Me.TxtCotizacionSen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(412, 418)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(108, 34)
        Me.Label28.TabIndex = 65
        Me.Label28.Text = "$ Tarifa Viaje Sencillo"
        '
        'TxtCotizacionFull
        '
        Me.TxtCotizacionFull.Enabled = False
        Me.TxtCotizacionFull.Location = New System.Drawing.Point(743, 448)
        Me.TxtCotizacionFull.Name = "TxtCotizacionFull"
        Me.TxtCotizacionFull.Size = New System.Drawing.Size(90, 20)
        Me.TxtCotizacionFull.TabIndex = 66
        Me.TxtCotizacionFull.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(741, 417)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(92, 34)
        Me.Label29.TabIndex = 67
        Me.Label29.Text = "$ Tarifa Viaje Full"
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(687, 541)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(102, 14)
        Me.Label30.TabIndex = 68
        Me.Label30.Text = "# Cotización:"
        Me.Label30.Visible = False
        '
        'TxtNoCotizacion
        '
        Me.TxtNoCotizacion.Enabled = False
        Me.TxtNoCotizacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNoCotizacion.Location = New System.Drawing.Point(689, 559)
        Me.TxtNoCotizacion.Name = "TxtNoCotizacion"
        Me.TxtNoCotizacion.Size = New System.Drawing.Size(78, 21)
        Me.TxtNoCotizacion.TabIndex = 69
        Me.TxtNoCotizacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtNoCotizacion.Visible = False
        '
        'TxtPorcCotSen
        '
        Me.TxtPorcCotSen.Enabled = False
        Me.TxtPorcCotSen.Location = New System.Drawing.Point(521, 449)
        Me.TxtPorcCotSen.Name = "TxtPorcCotSen"
        Me.TxtPorcCotSen.Size = New System.Drawing.Size(91, 20)
        Me.TxtPorcCotSen.TabIndex = 70
        Me.TxtPorcCotSen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(519, 418)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(106, 34)
        Me.Label31.TabIndex = 71
        Me.Label31.Text = "% Utilidad Viaje Sencillo"
        '
        'TxtPorcCotFull
        '
        Me.TxtPorcCotFull.Enabled = False
        Me.TxtPorcCotFull.Location = New System.Drawing.Point(847, 448)
        Me.TxtPorcCotFull.Name = "TxtPorcCotFull"
        Me.TxtPorcCotFull.Size = New System.Drawing.Size(69, 20)
        Me.TxtPorcCotFull.TabIndex = 72
        Me.TxtPorcCotFull.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(845, 417)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(82, 34)
        Me.Label32.TabIndex = 73
        Me.Label32.Text = "% Utilidad Viaje Full"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(12, 624)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(101, 15)
        Me.Label33.TabIndex = 74
        Me.Label33.Text = "Observaciones"
        '
        'TxtObservaciones
        '
        Me.TxtObservaciones.Location = New System.Drawing.Point(12, 643)
        Me.TxtObservaciones.Name = "TxtObservaciones"
        Me.TxtObservaciones.Size = New System.Drawing.Size(287, 81)
        Me.TxtObservaciones.TabIndex = 75
        Me.TxtObservaciones.Text = ""
        '
        'frmCotizador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(982, 736)
        Me.Controls.Add(Me.TxtObservaciones)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.TxtPorcCotFull)
        Me.Controls.Add(Me.TxtPorcCotSen)
        Me.Controls.Add(Me.TxtNoCotizacion)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.TxtCotizacionFull)
        Me.Controls.Add(Me.TxtCotizacionSen)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.cmbTipoCotizacion)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.cmbTipoRemolque)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.TxtCtoDiesel)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.TxtSobrecosto)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.TxtFrecuencia)
        Me.Controls.Add(Me.TxtVolumen)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.TxtCliente)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.grdResultadoFull)
        Me.Controls.Add(Me.TxtIncremento)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.cmbTipoViaje)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TxtComision)
        Me.Controls.Add(Me.btnExportar)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.TxtManiobras)
        Me.Controls.Add(Me.TxtSueldoOper)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtCtoDieConsumo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtCasetas)
        Me.Controls.Add(Me.TxtRendDiesel)
        Me.Controls.Add(Me.TxtTiempo)
        Me.Controls.Add(Me.cmbOrigen)
        Me.Controls.Add(Me.TxtKm)
        Me.Controls.Add(Me.cmbDestino)
        Me.Controls.Add(Me.grdResultado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label29)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "frmCotizador"
        Me.Text = "Cotizador de Viajes Foraneos"
        CType(Me.grdResultado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Interflet_ConceptosValores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TraficorutaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProduccionInterfletdbDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TraficoplazaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProduccionInterfletdbDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSDiesel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProduccionInterfletdbDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.grdResultadoFull, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents grdResultado As System.Windows.Forms.DataGridView
    Friend WithEvents Interflet_ConceptosValores As Interflet.Interflet_ConceptosValores
    Friend WithEvents cmbDestino As System.Windows.Forms.ComboBox
    Friend WithEvents ProduccionInterfletdbDataSet1 As Interflet.ProduccionInterfletdbDataSet1
    Friend WithEvents TraficorutaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Cat_DestinoTableAdapter As Interflet.ProduccionInterfletdbDataSet1TableAdapters.Cat_DestinoTableAdapter
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtKm As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbOrigen As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ProduccionInterfletdbDataSet2 As Interflet.ProduccionInterfletdbDataSet2
    Friend WithEvents TraficoplazaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Trafico_plazaTableAdapter As Interflet.ProduccionInterfletdbDataSet2TableAdapters.trafico_plazaTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtTiempo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtRendDiesel As System.Windows.Forms.TextBox
    Friend WithEvents TxtCasetas As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtCtoDieConsumo As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BSDiesel As System.Windows.Forms.BindingSource
    Friend WithEvents ProduccionInterfletdbDataSet4 As Interflet.ProduccionInterfletdbDataSet4
    Friend WithEvents DieselTableAdapter As Interflet.ProduccionInterfletdbDataSet4TableAdapters.UP_Consulta_CostoDieselTableAdapter
    Friend WithEvents TxtSueldoOper As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtManiobras As System.Windows.Forms.TextBox
    Friend WithEvents btnCalcular As System.Windows.Forms.Button
    Friend WithEvents Tarifa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MtoUtil As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PorcUtil As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnExportar As System.Windows.Forms.Button
    Friend WithEvents TxtComision As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmbTipoViaje As System.Windows.Forms.ComboBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TxtUtilMax As System.Windows.Forms.TextBox
    Friend WithEvents TxtUtilMin As System.Windows.Forms.TextBox
    Friend WithEvents TxtMtoUtilMax As System.Windows.Forms.TextBox
    Friend WithEvents TxtMtoUtilMin As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TxtIncremento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents grdResultadoFull As System.Windows.Forms.DataGridView
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TxtCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TxtVolumen As System.Windows.Forms.TextBox
    Friend WithEvents TxtFrecuencia As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TxtSobrecosto As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents TxtCtoDiesel As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cmbTipoRemolque As System.Windows.Forms.ComboBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmbTipoCotizacion As System.Windows.Forms.ComboBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents TarifaFull As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MtoUtilFull As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PorcUtilFull As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents TxtCotizacionSen As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents TxtCotizacionFull As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents TxtNoCotizacion As System.Windows.Forms.TextBox
    Friend WithEvents TxtPorcCotSen As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents TxtPorcCotFull As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents TxtObservaciones As System.Windows.Forms.RichTextBox
End Class
