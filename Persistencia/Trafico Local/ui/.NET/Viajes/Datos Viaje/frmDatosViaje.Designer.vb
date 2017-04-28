<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDatosViaje
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDatosViaje))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtNoViaje = New System.Windows.Forms.MaskedTextBox
        Me.gbKm = New System.Windows.Forms.GroupBox
        Me.TxtKmFinal = New System.Windows.Forms.TextBox
        Me.TxtKmReset = New System.Windows.Forms.TextBox
        Me.TxtKmInicial = New System.Windows.Forms.TextBox
        Me.TxtKmViaje = New System.Windows.Forms.MaskedTextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.gbDias = New System.Windows.Forms.GroupBox
        Me.TxtFecFin = New System.Windows.Forms.TextBox
        Me.TxtFecIni = New System.Windows.Forms.TextBox
        Me.TxtTotDias = New System.Windows.Forms.MaskedTextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmbFechaIni = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.gbEquipos = New System.Windows.Forms.GroupBox
        Me.grdUnidades = New System.Windows.Forms.DataGridView
        Me.Id_Combustible = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Id_Vale = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Unidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.id_UnidadC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.litros = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.checkLitros = New System.Windows.Forms.CheckBox
        Me.cmbTipoViaje = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.gbRemolques = New System.Windows.Forms.GroupBox
        Me.grdRemolques = New System.Windows.Forms.DataGridView
        Me.Remolque = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TipoRem = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TxtUnidad = New System.Windows.Forms.MaskedTextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.TxtSemana = New System.Windows.Forms.MaskedTextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.gbCartasPorte = New System.Windows.Forms.GroupBox
        Me.btnEliminarCP = New System.Windows.Forms.Button
        Me.grdCartasPorte = New System.Windows.Forms.DataGridView
        Me.TxtCPReparto = New System.Windows.Forms.TextBox
        Me.btnCPReparto = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.btnGastos = New System.Windows.Forms.Button
        Me.btnCasetas = New System.Windows.Forms.Button
        Me.gbReset = New System.Windows.Forms.GroupBox
        Me.grdReset = New System.Windows.Forms.DataGridView
        Me.desc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.val = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.grdResetCAT = New System.Windows.Forms.DataGridView
        Me.Label15 = New System.Windows.Forms.Label
        Me.TxtObservaciones = New System.Windows.Forms.RichTextBox
        Me.gbContenedores = New System.Windows.Forms.GroupBox
        Me.grdContenedores = New System.Windows.Forms.DataGridView
        Me.Contenedor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TipoCont = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.gbLitros = New System.Windows.Forms.GroupBox
        Me.TxtComplemento = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.TxtLtsReset = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.TxtLitrosLis = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.TxtOperador = New System.Windows.Forms.MaskedTextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.cmbConfViaje = New System.Windows.Forms.ComboBox
        Me.ckbUrgente = New System.Windows.Forms.CheckBox
        Me.TxtManiobras = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.gbMovimientos = New System.Windows.Forms.GroupBox
        Me.grdMovimientos = New System.Windows.Forms.DataGridView
        Me.Movim = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.contenedor11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Contenedor22 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Tamano1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Tamano2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Tamano11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tamano22 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Remolque1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Remolque2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TipoRem1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TipoRem2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.cmbArea = New System.Windows.Forms.ComboBox
        Me.btnSalir = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtMovimientos = New System.Windows.Forms.TextBox
        Me.UPConsultaMovimientosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.grid_operador = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.gbKm.SuspendLayout()
        Me.gbDias.SuspendLayout()
        Me.gbEquipos.SuspendLayout()
        CType(Me.grdUnidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbRemolques.SuspendLayout()
        CType(Me.grdRemolques, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbCartasPorte.SuspendLayout()
        CType(Me.grdCartasPorte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbReset.SuspendLayout()
        CType(Me.grdReset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdResetCAT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbContenedores.SuspendLayout()
        CType(Me.grdContenedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbLitros.SuspendLayout()
        Me.gbMovimientos.SuspendLayout()
        CType(Me.grdMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UPConsultaMovimientosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_operador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(103, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No. Viaje:"
        '
        'TxtNoViaje
        '
        Me.TxtNoViaje.Location = New System.Drawing.Point(106, 24)
        Me.TxtNoViaje.Mask = "9999999999"
        Me.TxtNoViaje.Name = "TxtNoViaje"
        Me.TxtNoViaje.Size = New System.Drawing.Size(102, 20)
        Me.TxtNoViaje.SkipLiterals = False
        Me.TxtNoViaje.TabIndex = 1
        '
        'gbKm
        '
        Me.gbKm.BackColor = System.Drawing.Color.Transparent
        Me.gbKm.Controls.Add(Me.TxtKmFinal)
        Me.gbKm.Controls.Add(Me.TxtKmReset)
        Me.gbKm.Controls.Add(Me.TxtKmInicial)
        Me.gbKm.Controls.Add(Me.TxtKmViaje)
        Me.gbKm.Controls.Add(Me.Label3)
        Me.gbKm.Controls.Add(Me.Label2)
        Me.gbKm.Controls.Add(Me.Label16)
        Me.gbKm.Controls.Add(Me.Label4)
        Me.gbKm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbKm.Location = New System.Drawing.Point(9, 51)
        Me.gbKm.Name = "gbKm"
        Me.gbKm.Size = New System.Drawing.Size(211, 154)
        Me.gbKm.TabIndex = 2
        Me.gbKm.TabStop = False
        Me.gbKm.Text = "Km Reales"
        '
        'TxtKmFinal
        '
        Me.TxtKmFinal.Location = New System.Drawing.Point(111, 54)
        Me.TxtKmFinal.Name = "TxtKmFinal"
        Me.TxtKmFinal.Size = New System.Drawing.Size(77, 21)
        Me.TxtKmFinal.TabIndex = 5
        Me.TxtKmFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtKmReset
        '
        Me.TxtKmReset.Enabled = False
        Me.TxtKmReset.Location = New System.Drawing.Point(117, 117)
        Me.TxtKmReset.Name = "TxtKmReset"
        Me.TxtKmReset.Size = New System.Drawing.Size(71, 21)
        Me.TxtKmReset.TabIndex = 7
        Me.TxtKmReset.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtKmInicial
        '
        Me.TxtKmInicial.Enabled = False
        Me.TxtKmInicial.Location = New System.Drawing.Point(111, 24)
        Me.TxtKmInicial.Name = "TxtKmInicial"
        Me.TxtKmInicial.Size = New System.Drawing.Size(77, 21)
        Me.TxtKmInicial.TabIndex = 4
        Me.TxtKmInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtKmViaje
        '
        Me.TxtKmViaje.Enabled = False
        Me.TxtKmViaje.Location = New System.Drawing.Point(117, 91)
        Me.TxtKmViaje.Name = "TxtKmViaje"
        Me.TxtKmViaje.Size = New System.Drawing.Size(71, 21)
        Me.TxtKmViaje.TabIndex = 6
        Me.TxtKmViaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Km Final:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Km Inicial:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(15, 119)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(100, 15)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Kms en Reset:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Kms de Viaje:"
        '
        'gbDias
        '
        Me.gbDias.BackColor = System.Drawing.Color.Transparent
        Me.gbDias.Controls.Add(Me.TxtFecFin)
        Me.gbDias.Controls.Add(Me.TxtFecIni)
        Me.gbDias.Controls.Add(Me.TxtTotDias)
        Me.gbDias.Controls.Add(Me.Label7)
        Me.gbDias.Controls.Add(Me.cmbFechaIni)
        Me.gbDias.Controls.Add(Me.Label5)
        Me.gbDias.Controls.Add(Me.Label6)
        Me.gbDias.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDias.Location = New System.Drawing.Point(225, 55)
        Me.gbDias.Name = "gbDias"
        Me.gbDias.Size = New System.Drawing.Size(273, 151)
        Me.gbDias.TabIndex = 3
        Me.gbDias.TabStop = False
        Me.gbDias.Text = "Dias de Viaje"
        '
        'TxtFecFin
        '
        Me.TxtFecFin.Enabled = False
        Me.TxtFecFin.Location = New System.Drawing.Point(94, 56)
        Me.TxtFecFin.Name = "TxtFecFin"
        Me.TxtFecFin.Size = New System.Drawing.Size(173, 21)
        Me.TxtFecFin.TabIndex = 9
        '
        'TxtFecIni
        '
        Me.TxtFecIni.Enabled = False
        Me.TxtFecIni.Location = New System.Drawing.Point(96, 28)
        Me.TxtFecIni.Name = "TxtFecIni"
        Me.TxtFecIni.Size = New System.Drawing.Size(173, 21)
        Me.TxtFecIni.TabIndex = 6
        '
        'TxtTotDias
        '
        Me.TxtTotDias.Enabled = False
        Me.TxtTotDias.Location = New System.Drawing.Point(118, 111)
        Me.TxtTotDias.Mask = "999"
        Me.TxtTotDias.Name = "TxtTotDias"
        Me.TxtTotDias.Size = New System.Drawing.Size(64, 21)
        Me.TxtTotDias.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 114)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 15)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Total de Dias:"
        '
        'cmbFechaIni
        '
        Me.cmbFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cmbFechaIni.Location = New System.Drawing.Point(112, 28)
        Me.cmbFechaIni.Name = "cmbFechaIni"
        Me.cmbFechaIni.Size = New System.Drawing.Size(99, 21)
        Me.cmbFechaIni.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Fecha Final:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 15)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Fecha Inicial:"
        '
        'gbEquipos
        '
        Me.gbEquipos.BackColor = System.Drawing.Color.Transparent
        Me.gbEquipos.Controls.Add(Me.grdUnidades)
        Me.gbEquipos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbEquipos.Location = New System.Drawing.Point(226, 51)
        Me.gbEquipos.Name = "gbEquipos"
        Me.gbEquipos.Size = New System.Drawing.Size(272, 155)
        Me.gbEquipos.TabIndex = 21
        Me.gbEquipos.TabStop = False
        Me.gbEquipos.Text = "Unidades"
        Me.gbEquipos.Visible = False
        '
        'grdUnidades
        '
        Me.grdUnidades.AllowUserToAddRows = False
        Me.grdUnidades.AllowUserToDeleteRows = False
        Me.grdUnidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdUnidades.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.grdUnidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdUnidades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_Combustible, Me.Id_Vale, Me.Unidad, Me.id_UnidadC, Me.litros})
        Me.grdUnidades.Location = New System.Drawing.Point(7, 24)
        Me.grdUnidades.Name = "grdUnidades"
        Me.grdUnidades.ReadOnly = True
        Me.grdUnidades.RowHeadersWidth = 10
        Me.grdUnidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdUnidades.Size = New System.Drawing.Size(255, 120)
        Me.grdUnidades.TabIndex = 1
        '
        'Id_Combustible
        '
        Me.Id_Combustible.HeaderText = "id_combustible"
        Me.Id_Combustible.Name = "Id_Combustible"
        Me.Id_Combustible.ReadOnly = True
        Me.Id_Combustible.Visible = False
        '
        'Id_Vale
        '
        Me.Id_Vale.HeaderText = "Vale"
        Me.Id_Vale.Name = "Id_Vale"
        Me.Id_Vale.ReadOnly = True
        '
        'Unidad
        '
        Me.Unidad.HeaderText = "Unidad"
        Me.Unidad.Name = "Unidad"
        Me.Unidad.ReadOnly = True
        '
        'id_UnidadC
        '
        Me.id_UnidadC.HeaderText = "UnidadC"
        Me.id_UnidadC.Name = "id_UnidadC"
        Me.id_UnidadC.ReadOnly = True
        Me.id_UnidadC.Visible = False
        '
        'litros
        '
        Me.litros.HeaderText = "litros"
        Me.litros.Name = "litros"
        Me.litros.ReadOnly = True
        '
        'checkLitros
        '
        Me.checkLitros.AutoSize = True
        Me.checkLitros.BackColor = System.Drawing.Color.Transparent
        Me.checkLitros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkLitros.Location = New System.Drawing.Point(505, 547)
        Me.checkLitros.Name = "checkLitros"
        Me.checkLitros.Size = New System.Drawing.Size(220, 17)
        Me.checkLitros.TabIndex = 2
        Me.checkLitros.Text = "Usar un reset para todos los vales"
        Me.checkLitros.UseVisualStyleBackColor = False
        '
        'cmbTipoViaje
        '
        Me.cmbTipoViaje.FormattingEnabled = True
        Me.cmbTipoViaje.Items.AddRange(New Object() {"Foraneo", "Local", "Almacen"})
        Me.cmbTipoViaje.Location = New System.Drawing.Point(214, 24)
        Me.cmbTipoViaje.Name = "cmbTipoViaje"
        Me.cmbTipoViaje.Size = New System.Drawing.Size(106, 21)
        Me.cmbTipoViaje.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(211, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 15)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Tipo de Viaje:"
        '
        'gbRemolques
        '
        Me.gbRemolques.BackColor = System.Drawing.Color.Transparent
        Me.gbRemolques.Controls.Add(Me.grdRemolques)
        Me.gbRemolques.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbRemolques.Location = New System.Drawing.Point(505, 209)
        Me.gbRemolques.Name = "gbRemolques"
        Me.gbRemolques.Size = New System.Drawing.Size(213, 108)
        Me.gbRemolques.TabIndex = 6
        Me.gbRemolques.TabStop = False
        Me.gbRemolques.Text = "Remolques"
        '
        'grdRemolques
        '
        Me.grdRemolques.AllowUserToAddRows = False
        Me.grdRemolques.AllowUserToDeleteRows = False
        Me.grdRemolques.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.grdRemolques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdRemolques.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Remolque, Me.TipoRem})
        Me.grdRemolques.Location = New System.Drawing.Point(9, 19)
        Me.grdRemolques.Name = "grdRemolques"
        Me.grdRemolques.ReadOnly = True
        Me.grdRemolques.RowHeadersVisible = False
        Me.grdRemolques.Size = New System.Drawing.Size(200, 73)
        Me.grdRemolques.TabIndex = 0
        '
        'Remolque
        '
        Me.Remolque.HeaderText = "Remolque"
        Me.Remolque.Name = "Remolque"
        Me.Remolque.ReadOnly = True
        Me.Remolque.Width = 75
        '
        'TipoRem
        '
        Me.TipoRem.HeaderText = "Tipo"
        Me.TipoRem.Name = "TipoRem"
        Me.TipoRem.ReadOnly = True
        Me.TipoRem.Width = 120
        '
        'TxtUnidad
        '
        Me.TxtUnidad.Enabled = False
        Me.TxtUnidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUnidad.Location = New System.Drawing.Point(538, 23)
        Me.TxtUnidad.Name = "TxtUnidad"
        Me.TxtUnidad.Size = New System.Drawing.Size(53, 21)
        Me.TxtUnidad.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(535, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 15)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Unidad:"
        '
        'TxtSemana
        '
        Me.TxtSemana.Enabled = False
        Me.TxtSemana.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSemana.Location = New System.Drawing.Point(597, 23)
        Me.TxtSemana.Name = "TxtSemana"
        Me.TxtSemana.Size = New System.Drawing.Size(61, 21)
        Me.TxtSemana.TabIndex = 10
        Me.TxtSemana.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(594, 8)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 15)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Semana:"
        '
        'gbCartasPorte
        '
        Me.gbCartasPorte.BackColor = System.Drawing.Color.Transparent
        Me.gbCartasPorte.Controls.Add(Me.btnEliminarCP)
        Me.gbCartasPorte.Controls.Add(Me.grdCartasPorte)
        Me.gbCartasPorte.Controls.Add(Me.TxtCPReparto)
        Me.gbCartasPorte.Controls.Add(Me.btnCPReparto)
        Me.gbCartasPorte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbCartasPorte.Location = New System.Drawing.Point(500, 51)
        Me.gbCartasPorte.Name = "gbCartasPorte"
        Me.gbCartasPorte.Size = New System.Drawing.Size(416, 155)
        Me.gbCartasPorte.TabIndex = 11
        Me.gbCartasPorte.TabStop = False
        Me.gbCartasPorte.Text = "Cartas Porte"
        '
        'btnEliminarCP
        '
        Me.btnEliminarCP.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnEliminarCP.Location = New System.Drawing.Point(280, 119)
        Me.btnEliminarCP.Name = "btnEliminarCP"
        Me.btnEliminarCP.Size = New System.Drawing.Size(116, 25)
        Me.btnEliminarCP.TabIndex = 29
        Me.btnEliminarCP.Text = "Eliminar C.P."
        Me.btnEliminarCP.UseVisualStyleBackColor = False
        '
        'grdCartasPorte
        '
        Me.grdCartasPorte.AllowUserToAddRows = False
        Me.grdCartasPorte.AllowUserToDeleteRows = False
        Me.grdCartasPorte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdCartasPorte.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.grdCartasPorte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdCartasPorte.Location = New System.Drawing.Point(9, 19)
        Me.grdCartasPorte.Name = "grdCartasPorte"
        Me.grdCartasPorte.ReadOnly = True
        Me.grdCartasPorte.RowHeadersVisible = False
        Me.grdCartasPorte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdCartasPorte.Size = New System.Drawing.Size(399, 96)
        Me.grdCartasPorte.TabIndex = 1
        '
        'TxtCPReparto
        '
        Me.TxtCPReparto.Location = New System.Drawing.Point(61, 121)
        Me.TxtCPReparto.Name = "TxtCPReparto"
        Me.TxtCPReparto.Size = New System.Drawing.Size(110, 21)
        Me.TxtCPReparto.TabIndex = 8
        Me.TxtCPReparto.Text = "CP-"
        '
        'btnCPReparto
        '
        Me.btnCPReparto.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCPReparto.Location = New System.Drawing.Point(177, 119)
        Me.btnCPReparto.Name = "btnCPReparto"
        Me.btnCPReparto.Size = New System.Drawing.Size(97, 25)
        Me.btnCPReparto.TabIndex = 28
        Me.btnCPReparto.Text = "Agregar C.P."
        Me.btnCPReparto.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardar.Location = New System.Drawing.Point(664, 567)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(70, 43)
        Me.btnGuardar.TabIndex = 13
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnGastos
        '
        Me.btnGastos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGastos.Image = CType(resources.GetObject("btnGastos.Image"), System.Drawing.Image)
        Me.btnGastos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGastos.Location = New System.Drawing.Point(588, 567)
        Me.btnGastos.Name = "btnGastos"
        Me.btnGastos.Size = New System.Drawing.Size(70, 43)
        Me.btnGastos.TabIndex = 12
        Me.btnGastos.Text = "Gastos"
        Me.btnGastos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGastos.UseVisualStyleBackColor = True
        '
        'btnCasetas
        '
        Me.btnCasetas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCasetas.Image = CType(resources.GetObject("btnCasetas.Image"), System.Drawing.Image)
        Me.btnCasetas.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCasetas.Location = New System.Drawing.Point(512, 567)
        Me.btnCasetas.Name = "btnCasetas"
        Me.btnCasetas.Size = New System.Drawing.Size(70, 43)
        Me.btnCasetas.TabIndex = 11
        Me.btnCasetas.Text = "Casetas"
        Me.btnCasetas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCasetas.UseVisualStyleBackColor = True
        '
        'gbReset
        '
        Me.gbReset.BackColor = System.Drawing.Color.Transparent
        Me.gbReset.Controls.Add(Me.grdReset)
        Me.gbReset.Controls.Add(Me.grdResetCAT)
        Me.gbReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbReset.Location = New System.Drawing.Point(9, 209)
        Me.gbReset.Name = "gbReset"
        Me.gbReset.Size = New System.Drawing.Size(478, 420)
        Me.gbReset.TabIndex = 15
        Me.gbReset.TabStop = False
        Me.gbReset.Text = "Datos de Reseteo"
        '
        'grdReset
        '
        Me.grdReset.AllowUserToAddRows = False
        Me.grdReset.AllowUserToDeleteRows = False
        Me.grdReset.AllowUserToOrderColumns = True
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver
        Me.grdReset.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.grdReset.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdReset.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.grdReset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdReset.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.desc, Me.val})
        Me.grdReset.Location = New System.Drawing.Point(7, 20)
        Me.grdReset.Name = "grdReset"
        Me.grdReset.ReadOnly = True
        Me.grdReset.RowHeadersWidth = 20
        Me.grdReset.Size = New System.Drawing.Size(461, 392)
        Me.grdReset.TabIndex = 0
        Me.grdReset.Visible = False
        '
        'desc
        '
        Me.desc.HeaderText = "Descripción"
        Me.desc.Name = "desc"
        Me.desc.ReadOnly = True
        Me.desc.Width = 250
        '
        'val
        '
        Me.val.HeaderText = "Valor"
        Me.val.Name = "val"
        Me.val.ReadOnly = True
        '
        'grdResetCAT
        '
        Me.grdResetCAT.AllowUserToAddRows = False
        Me.grdResetCAT.AllowUserToDeleteRows = False
        Me.grdResetCAT.AllowUserToOrderColumns = True
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver
        Me.grdResetCAT.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.grdResetCAT.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdResetCAT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.grdResetCAT.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.grdResetCAT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdResetCAT.Location = New System.Drawing.Point(7, 20)
        Me.grdResetCAT.Name = "grdResetCAT"
        Me.grdResetCAT.ReadOnly = True
        Me.grdResetCAT.RowHeadersWidth = 20
        Me.grdResetCAT.Size = New System.Drawing.Size(461, 392)
        Me.grdResetCAT.TabIndex = 1
        Me.grdResetCAT.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(502, 446)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(169, 15)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "Observaciones Operador:"
        '
        'TxtObservaciones
        '
        Me.TxtObservaciones.Location = New System.Drawing.Point(505, 465)
        Me.TxtObservaciones.Name = "TxtObservaciones"
        Me.TxtObservaciones.Size = New System.Drawing.Size(218, 76)
        Me.TxtObservaciones.TabIndex = 17
        Me.TxtObservaciones.Text = ""
        '
        'gbContenedores
        '
        Me.gbContenedores.BackColor = System.Drawing.Color.Transparent
        Me.gbContenedores.Controls.Add(Me.grdContenedores)
        Me.gbContenedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbContenedores.Location = New System.Drawing.Point(505, 324)
        Me.gbContenedores.Name = "gbContenedores"
        Me.gbContenedores.Size = New System.Drawing.Size(212, 112)
        Me.gbContenedores.TabIndex = 22
        Me.gbContenedores.TabStop = False
        Me.gbContenedores.Text = "Contenedores"
        '
        'grdContenedores
        '
        Me.grdContenedores.AllowUserToAddRows = False
        Me.grdContenedores.AllowUserToDeleteRows = False
        Me.grdContenedores.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.grdContenedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdContenedores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Contenedor, Me.TipoCont})
        Me.grdContenedores.Location = New System.Drawing.Point(8, 20)
        Me.grdContenedores.Name = "grdContenedores"
        Me.grdContenedores.ReadOnly = True
        Me.grdContenedores.RowHeadersVisible = False
        Me.grdContenedores.Size = New System.Drawing.Size(200, 82)
        Me.grdContenedores.TabIndex = 0
        '
        'Contenedor
        '
        Me.Contenedor.HeaderText = "Contenedor"
        Me.Contenedor.Name = "Contenedor"
        Me.Contenedor.ReadOnly = True
        Me.Contenedor.Width = 130
        '
        'TipoCont
        '
        Me.TipoCont.HeaderText = "Tipo"
        Me.TipoCont.Name = "TipoCont"
        Me.TipoCont.ReadOnly = True
        Me.TipoCont.Width = 50
        '
        'gbLitros
        '
        Me.gbLitros.BackColor = System.Drawing.Color.Transparent
        Me.gbLitros.Controls.Add(Me.TxtComplemento)
        Me.gbLitros.Controls.Add(Me.Label19)
        Me.gbLitros.Controls.Add(Me.TxtLtsReset)
        Me.gbLitros.Controls.Add(Me.Label18)
        Me.gbLitros.Controls.Add(Me.TxtLitrosLis)
        Me.gbLitros.Controls.Add(Me.Label17)
        Me.gbLitros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbLitros.Location = New System.Drawing.Point(724, 212)
        Me.gbLitros.Name = "gbLitros"
        Me.gbLitros.Size = New System.Drawing.Size(193, 104)
        Me.gbLitros.TabIndex = 23
        Me.gbLitros.TabStop = False
        Me.gbLitros.Text = "Litros de Diesel"
        '
        'TxtComplemento
        '
        Me.TxtComplemento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtComplemento.Location = New System.Drawing.Point(105, 73)
        Me.TxtComplemento.Name = "TxtComplemento"
        Me.TxtComplemento.Size = New System.Drawing.Size(79, 20)
        Me.TxtComplemento.TabIndex = 9
        Me.TxtComplemento.Text = "0"
        Me.TxtComplemento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(7, 75)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(100, 15)
        Me.Label19.TabIndex = 25
        Me.Label19.Text = "Complemento:"
        '
        'TxtLtsReset
        '
        Me.TxtLtsReset.Enabled = False
        Me.TxtLtsReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLtsReset.Location = New System.Drawing.Point(105, 47)
        Me.TxtLtsReset.Name = "TxtLtsReset"
        Me.TxtLtsReset.Size = New System.Drawing.Size(79, 20)
        Me.TxtLtsReset.TabIndex = 24
        Me.TxtLtsReset.Text = "0"
        Me.TxtLtsReset.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(7, 48)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(48, 15)
        Me.Label18.TabIndex = 23
        Me.Label18.Text = "Reset:"
        '
        'TxtLitrosLis
        '
        Me.TxtLitrosLis.Enabled = False
        Me.TxtLitrosLis.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLitrosLis.Location = New System.Drawing.Point(105, 21)
        Me.TxtLitrosLis.Name = "TxtLitrosLis"
        Me.TxtLitrosLis.Size = New System.Drawing.Size(79, 20)
        Me.TxtLitrosLis.TabIndex = 22
        Me.TxtLitrosLis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(7, 24)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(96, 15)
        Me.Label17.TabIndex = 21
        Me.Label17.Text = "Sistema SAM:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(661, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 15)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Operador:"
        '
        'TxtOperador
        '
        Me.TxtOperador.Enabled = False
        Me.TxtOperador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOperador.Location = New System.Drawing.Point(664, 24)
        Me.TxtOperador.Name = "TxtOperador"
        Me.TxtOperador.Size = New System.Drawing.Size(247, 21)
        Me.TxtOperador.TabIndex = 25
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(340, 8)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(92, 15)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Config. Viaje:"
        '
        'cmbConfViaje
        '
        Me.cmbConfViaje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbConfViaje.FormattingEnabled = True
        Me.cmbConfViaje.Location = New System.Drawing.Point(342, 23)
        Me.cmbConfViaje.Name = "cmbConfViaje"
        Me.cmbConfViaje.Size = New System.Drawing.Size(187, 21)
        Me.cmbConfViaje.TabIndex = 2
        '
        'ckbUrgente
        '
        Me.ckbUrgente.AutoSize = True
        Me.ckbUrgente.BackColor = System.Drawing.Color.Transparent
        Me.ckbUrgente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbUrgente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ckbUrgente.Location = New System.Drawing.Point(727, 389)
        Me.ckbUrgente.Name = "ckbUrgente"
        Me.ckbUrgente.Size = New System.Drawing.Size(113, 19)
        Me.ckbUrgente.TabIndex = 27
        Me.ckbUrgente.Text = "Viaje Urgente"
        Me.ckbUrgente.UseVisualStyleBackColor = False
        '
        'TxtManiobras
        '
        Me.TxtManiobras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtManiobras.Location = New System.Drawing.Point(727, 352)
        Me.TxtManiobras.Name = "TxtManiobras"
        Me.TxtManiobras.Size = New System.Drawing.Size(125, 21)
        Me.TxtManiobras.TabIndex = 10
        Me.TxtManiobras.Text = "0"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(723, 333)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(143, 15)
        Me.Label20.TabIndex = 30
        Me.Label20.Text = "Gastos de Maniobras"
        '
        'gbMovimientos
        '
        Me.gbMovimientos.BackColor = System.Drawing.Color.Transparent
        Me.gbMovimientos.Controls.Add(Me.grdMovimientos)
        Me.gbMovimientos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbMovimientos.Location = New System.Drawing.Point(2, 211)
        Me.gbMovimientos.Name = "gbMovimientos"
        Me.gbMovimientos.Size = New System.Drawing.Size(501, 418)
        Me.gbMovimientos.TabIndex = 31
        Me.gbMovimientos.TabStop = False
        Me.gbMovimientos.Text = "Seleccione el movimiento"
        '
        'grdMovimientos
        '
        Me.grdMovimientos.AllowUserToAddRows = False
        Me.grdMovimientos.AllowUserToDeleteRows = False
        Me.grdMovimientos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdMovimientos.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.grdMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdMovimientos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Movim, Me.contenedor11, Me.Contenedor22, Me.Tamano1, Me.Tamano2, Me.Tamano11, Me.tamano22, Me.Remolque1, Me.Remolque2, Me.TipoRem1, Me.TipoRem2})
        Me.grdMovimientos.Location = New System.Drawing.Point(7, 29)
        Me.grdMovimientos.Name = "grdMovimientos"
        Me.grdMovimientos.ReadOnly = True
        Me.grdMovimientos.RowHeadersVisible = False
        Me.grdMovimientos.RowHeadersWidth = 4
        Me.grdMovimientos.Size = New System.Drawing.Size(485, 388)
        Me.grdMovimientos.TabIndex = 1
        '
        'Movim
        '
        Me.Movim.DataPropertyName = "Movim"
        Me.Movim.HeaderText = "Movim"
        Me.Movim.Name = "Movim"
        Me.Movim.ReadOnly = True
        Me.Movim.Visible = False
        '
        'contenedor11
        '
        Me.contenedor11.DataPropertyName = "contenedor11"
        Me.contenedor11.HeaderText = "contenedor11"
        Me.contenedor11.Name = "contenedor11"
        Me.contenedor11.ReadOnly = True
        Me.contenedor11.Visible = False
        '
        'Contenedor22
        '
        Me.Contenedor22.DataPropertyName = "Contenedor22"
        Me.Contenedor22.HeaderText = "Contenedor22"
        Me.Contenedor22.Name = "Contenedor22"
        Me.Contenedor22.ReadOnly = True
        Me.Contenedor22.Visible = False
        '
        'Tamano1
        '
        Me.Tamano1.DataPropertyName = "Tamano1"
        Me.Tamano1.HeaderText = "Tamano1"
        Me.Tamano1.Name = "Tamano1"
        Me.Tamano1.ReadOnly = True
        Me.Tamano1.Visible = False
        '
        'Tamano2
        '
        Me.Tamano2.DataPropertyName = "Tamano2"
        Me.Tamano2.HeaderText = "Tamano2"
        Me.Tamano2.Name = "Tamano2"
        Me.Tamano2.ReadOnly = True
        Me.Tamano2.Visible = False
        '
        'Tamano11
        '
        Me.Tamano11.DataPropertyName = "Tamano11"
        Me.Tamano11.HeaderText = "Tamano11"
        Me.Tamano11.Name = "Tamano11"
        Me.Tamano11.ReadOnly = True
        Me.Tamano11.Visible = False
        '
        'tamano22
        '
        Me.tamano22.DataPropertyName = "tamano22"
        Me.tamano22.HeaderText = "tamano22"
        Me.tamano22.Name = "tamano22"
        Me.tamano22.ReadOnly = True
        Me.tamano22.Visible = False
        '
        'Remolque1
        '
        Me.Remolque1.DataPropertyName = "Remolque1"
        Me.Remolque1.HeaderText = "Remolque1"
        Me.Remolque1.Name = "Remolque1"
        Me.Remolque1.ReadOnly = True
        Me.Remolque1.Visible = False
        '
        'Remolque2
        '
        Me.Remolque2.DataPropertyName = "Remolque2"
        Me.Remolque2.HeaderText = "Remolque2"
        Me.Remolque2.Name = "Remolque2"
        Me.Remolque2.ReadOnly = True
        Me.Remolque2.Visible = False
        '
        'TipoRem1
        '
        Me.TipoRem1.DataPropertyName = "TipoRem1"
        Me.TipoRem1.HeaderText = "TipoRem1"
        Me.TipoRem1.Name = "TipoRem1"
        Me.TipoRem1.ReadOnly = True
        Me.TipoRem1.Visible = False
        '
        'TipoRem2
        '
        Me.TipoRem2.DataPropertyName = "TipoRem2"
        Me.TipoRem2.HeaderText = "TipoRem2"
        Me.TipoRem2.Name = "TipoRem2"
        Me.TipoRem2.ReadOnly = True
        Me.TipoRem2.Visible = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(740, 567)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 43)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Imprimir Reset"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 15)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Sucursal:"
        '
        'cmbArea
        '
        Me.cmbArea.FormattingEnabled = True
        Me.cmbArea.Items.AddRange(New Object() {"Altamira", "Manzanillo", "Veracruz"})
        Me.cmbArea.Location = New System.Drawing.Point(9, 24)
        Me.cmbArea.Name = "cmbArea"
        Me.cmbArea.Size = New System.Drawing.Size(92, 21)
        Me.cmbArea.TabIndex = 0
        '
        'btnSalir
        '
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(821, 567)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 43)
        Me.btnSalir.TabIndex = 15
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(724, 411)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 15)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Movimientos:"
        '
        'txtMovimientos
        '
        Me.txtMovimientos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMovimientos.Location = New System.Drawing.Point(727, 429)
        Me.txtMovimientos.Name = "txtMovimientos"
        Me.txtMovimientos.Size = New System.Drawing.Size(125, 21)
        Me.txtMovimientos.TabIndex = 35
        Me.txtMovimientos.Text = "0"
        '
        'UPConsultaMovimientosBindingSource
        '
        Me.UPConsultaMovimientosBindingSource.DataMember = "UP_Consulta_Movimientos"
        '
        'grid_operador
        '
        Me.grid_operador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_operador.Location = New System.Drawing.Point(6, 18)
        Me.grid_operador.Name = "grid_operador"
        Me.grid_operador.Size = New System.Drawing.Size(302, 126)
        Me.grid_operador.TabIndex = 36
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.grid_operador)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(922, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(314, 155)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Operadores"
        '
        'frmDatosViaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(1248, 655)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.checkLitros)
        Me.Controls.Add(Me.txtMovimientos)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.cmbArea)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.gbEquipos)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.gbDias)
        Me.Controls.Add(Me.gbMovimientos)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.TxtManiobras)
        Me.Controls.Add(Me.ckbUrgente)
        Me.Controls.Add(Me.cmbConfViaje)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TxtOperador)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TxtObservaciones)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.gbReset)
        Me.Controls.Add(Me.btnCasetas)
        Me.Controls.Add(Me.btnGastos)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.gbCartasPorte)
        Me.Controls.Add(Me.TxtSemana)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TxtUnidad)
        Me.Controls.Add(Me.gbRemolques)
        Me.Controls.Add(Me.cmbTipoViaje)
        Me.Controls.Add(Me.gbKm)
        Me.Controls.Add(Me.TxtNoViaje)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.gbLitros)
        Me.Controls.Add(Me.gbContenedores)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmDatosViaje"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos de Viaje "
        Me.gbKm.ResumeLayout(False)
        Me.gbKm.PerformLayout()
        Me.gbDias.ResumeLayout(False)
        Me.gbDias.PerformLayout()
        Me.gbEquipos.ResumeLayout(False)
        CType(Me.grdUnidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbRemolques.ResumeLayout(False)
        CType(Me.grdRemolques, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbCartasPorte.ResumeLayout(False)
        Me.gbCartasPorte.PerformLayout()
        CType(Me.grdCartasPorte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbReset.ResumeLayout(False)
        CType(Me.grdReset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdResetCAT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbContenedores.ResumeLayout(False)
        CType(Me.grdContenedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbLitros.ResumeLayout(False)
        Me.gbLitros.PerformLayout()
        Me.gbMovimientos.ResumeLayout(False)
        CType(Me.grdMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UPConsultaMovimientosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_operador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtNoViaje As System.Windows.Forms.MaskedTextBox
    Friend WithEvents gbKm As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtKmViaje As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents gbDias As System.Windows.Forms.GroupBox
    Friend WithEvents TxtTotDias As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbFechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbTipoViaje As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents gbRemolques As System.Windows.Forms.GroupBox
    Friend WithEvents TxtUnidad As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtSemana As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents gbCartasPorte As System.Windows.Forms.GroupBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnGastos As System.Windows.Forms.Button
    Friend WithEvents btnCasetas As System.Windows.Forms.Button
    Friend WithEvents gbReset As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TxtObservaciones As System.Windows.Forms.RichTextBox
    Friend WithEvents grdReset As System.Windows.Forms.DataGridView
    Friend WithEvents grdResetCAT As System.Windows.Forms.DataGridView
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TxtKmInicial As System.Windows.Forms.TextBox
    Friend WithEvents TxtKmReset As System.Windows.Forms.TextBox
    Friend WithEvents TxtFecIni As System.Windows.Forms.TextBox
    Friend WithEvents gbEquipos As System.Windows.Forms.GroupBox
    Friend WithEvents gbContenedores As System.Windows.Forms.GroupBox
    Friend WithEvents gbLitros As System.Windows.Forms.GroupBox
    Friend WithEvents TxtLtsReset As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TxtLitrosLis As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TxtComplemento As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents desc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents val As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtKmFinal As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TxtOperador As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmbConfViaje As System.Windows.Forms.ComboBox
    Friend WithEvents grdUnidades As System.Windows.Forms.DataGridView
    Friend WithEvents ckbUrgente As System.Windows.Forms.CheckBox
    Friend WithEvents UPConsultaMovimientosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PI_Movimientos As Interflet.PI_Movimientos
    Friend WithEvents UP_Consulta_MovimientosTableAdapter As Interflet.PI_MovimientosTableAdapters.UP_Consulta_MovimientosTableAdapter
    Friend WithEvents TxtFecFin As System.Windows.Forms.TextBox
    Friend WithEvents btnCPReparto As System.Windows.Forms.Button
    Friend WithEvents TxtCPReparto As System.Windows.Forms.TextBox
    Friend WithEvents TxtManiobras As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents gbMovimientos As System.Windows.Forms.GroupBox
    Friend WithEvents grdMovimientos As System.Windows.Forms.DataGridView
    Friend WithEvents grdRemolques As System.Windows.Forms.DataGridView
    Friend WithEvents grdContenedores As System.Windows.Forms.DataGridView
    Friend WithEvents Movim As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents contenedor11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Contenedor22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tamano1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tamano2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tamano11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tamano22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Remolque1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Remolque2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoRem1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoRem2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Contenedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoCont As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Remolque As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoRem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdCartasPorte As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbArea As System.Windows.Forms.ComboBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtMovimientos As System.Windows.Forms.TextBox
    Friend WithEvents btnEliminarCP As System.Windows.Forms.Button
    Friend WithEvents UP_Consulta_EvaluacionTableAdapter1 As Interflet.PI_EvaluacionTableAdapters.UP_Consulta_EvaluacionTableAdapter
    Friend WithEvents checkLitros As System.Windows.Forms.CheckBox
    Friend WithEvents Id_Combustible As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id_Vale As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Unidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_UnidadC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents litros As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grid_operador As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
