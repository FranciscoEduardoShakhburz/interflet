<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEvaluacionviaje
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEvaluacionviaje))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtJustificacion = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnReporteDiesel = New System.Windows.Forms.Button
        Me.txtUnidad = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmbArea = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.TxtOperador = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnBuscar2 = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.TxtSemana = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtViaje = New System.Windows.Forms.MaskedTextBox
        Me.btnExportar = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbFecFin = New System.Windows.Forms.DateTimePicker
        Me.cmbFecIni = New System.Windows.Forms.DateTimePicker
        Me.TxtCliente = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.grdEvaluacion = New System.Windows.Forms.DataGridView
        Me.Unidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Destino = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Operador = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Viaje = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CartasPorte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Peso = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KMReales = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KMReset = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LtsViaje = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RendRealCalc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RendimientoReset = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LtsReset = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DifEnLtsReset = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DesctoXReset = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FaltanteConAjuste = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RendEstandar = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LtsEstandar = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Motor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdEvaluacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.txtJustificacion)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btnSalir)
        Me.GroupBox1.Controls.Add(Me.btnReporteDiesel)
        Me.GroupBox1.Controls.Add(Me.txtUnidad)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cmbArea)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TxtOperador)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.btnBuscar2)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Controls.Add(Me.TxtSemana)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtViaje)
        Me.GroupBox1.Controls.Add(Me.btnExportar)
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
        Me.GroupBox1.Size = New System.Drawing.Size(1167, 93)
        Me.GroupBox1.TabIndex = 80
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione una opción de consulta:"
        '
        'txtJustificacion
        '
        Me.txtJustificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJustificacion.Location = New System.Drawing.Point(105, 69)
        Me.txtJustificacion.Name = "txtJustificacion"
        Me.txtJustificacion.Size = New System.Drawing.Size(287, 21)
        Me.txtJustificacion.TabIndex = 91
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 21)
        Me.Label7.TabIndex = 90
        Me.Label7.Text = "Justificación: "
        '
        'btnSalir
        '
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Location = New System.Drawing.Point(1070, 57)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(85, 23)
        Me.btnSalir.TabIndex = 89
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnReporteDiesel
        '
        Me.btnReporteDiesel.Location = New System.Drawing.Point(904, 57)
        Me.btnReporteDiesel.Name = "btnReporteDiesel"
        Me.btnReporteDiesel.Size = New System.Drawing.Size(162, 23)
        Me.btnReporteDiesel.TabIndex = 88
        Me.btnReporteDiesel.Text = "Reporte Diesel"
        Me.btnReporteDiesel.UseVisualStyleBackColor = True
        '
        'txtUnidad
        '
        Me.txtUnidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnidad.Location = New System.Drawing.Point(382, 38)
        Me.txtUnidad.Name = "txtUnidad"
        Me.txtUnidad.Size = New System.Drawing.Size(116, 21)
        Me.txtUnidad.TabIndex = 87
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(386, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 21)
        Me.Label6.TabIndex = 86
        Me.Label6.Text = "Unidad:"
        '
        'cmbArea
        '
        Me.cmbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbArea.FormattingEnabled = True
        Me.cmbArea.Location = New System.Drawing.Point(786, 38)
        Me.cmbArea.Name = "cmbArea"
        Me.cmbArea.Size = New System.Drawing.Size(101, 23)
        Me.cmbArea.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(783, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 15)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Sucursal:"
        '
        'TxtOperador
        '
        Me.TxtOperador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOperador.Location = New System.Drawing.Point(254, 38)
        Me.TxtOperador.Name = "TxtOperador"
        Me.TxtOperador.Size = New System.Drawing.Size(116, 21)
        Me.TxtOperador.TabIndex = 85
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(258, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 21)
        Me.Label5.TabIndex = 84
        Me.Label5.Text = "Operador:"
        '
        'btnBuscar2
        '
        Me.btnBuscar2.Location = New System.Drawing.Point(904, 10)
        Me.btnBuscar2.Name = "btnBuscar2"
        Me.btnBuscar2.Size = New System.Drawing.Size(71, 41)
        Me.btnBuscar2.TabIndex = 83
        Me.btnBuscar2.Text = "Buscar"
        Me.btnBuscar2.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardar.Location = New System.Drawing.Point(1070, 10)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(85, 41)
        Me.btnGuardar.TabIndex = 82
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'TxtSemana
        '
        Me.TxtSemana.Location = New System.Drawing.Point(507, 38)
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
        Me.Label4.Location = New System.Drawing.Point(504, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 14)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "Semana:"
        '
        'TxtViaje
        '
        Me.TxtViaje.Location = New System.Drawing.Point(13, 38)
        Me.TxtViaje.Mask = "9999999999"
        Me.TxtViaje.Name = "TxtViaje"
        Me.TxtViaje.Size = New System.Drawing.Size(64, 21)
        Me.TxtViaje.TabIndex = 1
        Me.TxtViaje.Text = "0"
        '
        'btnExportar
        '
        Me.btnExportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
        Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExportar.Location = New System.Drawing.Point(981, 10)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(85, 41)
        Me.btnExportar.TabIndex = 78
        Me.btnExportar.Text = "Exportar"
        Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(677, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 14)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "Fecha Final:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(568, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 14)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "Fecha Inicial:"
        '
        'cmbFecFin
        '
        Me.cmbFecFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmbFecFin.Location = New System.Drawing.Point(680, 38)
        Me.cmbFecFin.Name = "cmbFecFin"
        Me.cmbFecFin.Size = New System.Drawing.Size(100, 21)
        Me.cmbFecFin.TabIndex = 5
        '
        'cmbFecIni
        '
        Me.cmbFecIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmbFecIni.Location = New System.Drawing.Point(571, 38)
        Me.cmbFecIni.Name = "cmbFecIni"
        Me.cmbFecIni.Size = New System.Drawing.Size(100, 21)
        Me.cmbFecIni.TabIndex = 4
        '
        'TxtCliente
        '
        Me.TxtCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCliente.Location = New System.Drawing.Point(86, 38)
        Me.TxtCliente.Name = "TxtCliente"
        Me.TxtCliente.Size = New System.Drawing.Size(154, 21)
        Me.TxtCliente.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(84, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 14)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Cliente:"
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(7, 23)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(70, 14)
        Me.Label30.TabIndex = 70
        Me.Label30.Text = "# Viaje:"
        '
        'grdEvaluacion
        '
        Me.grdEvaluacion.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray
        Me.grdEvaluacion.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdEvaluacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdEvaluacion.BackgroundColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdEvaluacion.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grdEvaluacion.ColumnHeadersHeight = 44
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdEvaluacion.DefaultCellStyle = DataGridViewCellStyle3
        Me.grdEvaluacion.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.grdEvaluacion.GridColor = System.Drawing.SystemColors.ControlLight
        Me.grdEvaluacion.Location = New System.Drawing.Point(4, 99)
        Me.grdEvaluacion.Name = "grdEvaluacion"
        Me.grdEvaluacion.RowHeadersVisible = False
        Me.grdEvaluacion.RowHeadersWidth = 30
        Me.grdEvaluacion.Size = New System.Drawing.Size(1160, 509)
        Me.grdEvaluacion.TabIndex = 81
        '
        'Unidad
        '
        Me.Unidad.DataPropertyName = "Unidad"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Unidad.DefaultCellStyle = DataGridViewCellStyle4
        Me.Unidad.Frozen = True
        Me.Unidad.HeaderText = "Unidad"
        Me.Unidad.Name = "Unidad"
        Me.Unidad.ReadOnly = True
        Me.Unidad.Width = 45
        '
        'Destino
        '
        Me.Destino.DataPropertyName = "Destino"
        Me.Destino.Frozen = True
        Me.Destino.HeaderText = "Destino"
        Me.Destino.Name = "Destino"
        Me.Destino.ReadOnly = True
        Me.Destino.Width = 68
        '
        'Cliente
        '
        Me.Cliente.DataPropertyName = "Cliente"
        Me.Cliente.Frozen = True
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.Name = "Cliente"
        Me.Cliente.ReadOnly = True
        Me.Cliente.Width = 64
        '
        'Operador
        '
        Me.Operador.DataPropertyName = "Operador"
        Me.Operador.Frozen = True
        Me.Operador.HeaderText = "Operador"
        Me.Operador.Name = "Operador"
        Me.Operador.ReadOnly = True
        Me.Operador.Width = 76
        '
        'Viaje
        '
        Me.Viaje.DataPropertyName = "Viaje"
        Me.Viaje.Frozen = True
        Me.Viaje.HeaderText = "Viaje"
        Me.Viaje.Name = "Viaje"
        Me.Viaje.ReadOnly = True
        Me.Viaje.Width = 50
        '
        'CartasPorte
        '
        Me.CartasPorte.DataPropertyName = "Cartas Porte"
        Me.CartasPorte.Frozen = True
        Me.CartasPorte.HeaderText = "Cartas Porte"
        Me.CartasPorte.Name = "CartasPorte"
        Me.CartasPorte.ReadOnly = True
        Me.CartasPorte.Width = 80
        '
        'Peso
        '
        Me.Peso.DataPropertyName = "Peso"
        Me.Peso.Frozen = True
        Me.Peso.HeaderText = "Peso"
        Me.Peso.Name = "Peso"
        Me.Peso.ReadOnly = True
        Me.Peso.Width = 47
        '
        'KMReales
        '
        Me.KMReales.DataPropertyName = "KM Reales"
        Me.KMReales.Frozen = True
        Me.KMReales.HeaderText = "KM Reales"
        Me.KMReales.Name = "KMReales"
        Me.KMReales.ReadOnly = True
        Me.KMReales.Width = 60
        '
        'KMReset
        '
        Me.KMReset.DataPropertyName = "KM Reset"
        Me.KMReset.Frozen = True
        Me.KMReset.HeaderText = "KM Reset"
        Me.KMReset.Name = "KMReset"
        Me.KMReset.ReadOnly = True
        Me.KMReset.Width = 60
        '
        'LtsViaje
        '
        Me.LtsViaje.DataPropertyName = "Lts Viaje"
        Me.LtsViaje.Frozen = True
        Me.LtsViaje.HeaderText = "Lts Viaje"
        Me.LtsViaje.Name = "LtsViaje"
        Me.LtsViaje.ReadOnly = True
        Me.LtsViaje.Width = 50
        '
        'RendRealCalc
        '
        Me.RendRealCalc.DataPropertyName = "Rend_ Real Calc_"
        Me.RendRealCalc.Frozen = True
        Me.RendRealCalc.HeaderText = "Rend Real Calc"
        Me.RendRealCalc.Name = "RendRealCalc"
        Me.RendRealCalc.ReadOnly = True
        Me.RendRealCalc.Width = 60
        '
        'RendimientoReset
        '
        Me.RendimientoReset.DataPropertyName = "Rendimiento Reset"
        Me.RendimientoReset.Frozen = True
        Me.RendimientoReset.HeaderText = "Rend. Reset"
        Me.RendimientoReset.Name = "RendimientoReset"
        Me.RendimientoReset.ReadOnly = True
        Me.RendimientoReset.Width = 60
        '
        'LtsReset
        '
        Me.LtsReset.DataPropertyName = "Lts Reset"
        Me.LtsReset.Frozen = True
        Me.LtsReset.HeaderText = "Lts Reset"
        Me.LtsReset.Name = "LtsReset"
        Me.LtsReset.ReadOnly = True
        Me.LtsReset.Width = 50
        '
        'DifEnLtsReset
        '
        Me.DifEnLtsReset.DataPropertyName = "Dif en Lts Reset"
        Me.DifEnLtsReset.Frozen = True
        Me.DifEnLtsReset.HeaderText = "Dif en Lts Reset"
        Me.DifEnLtsReset.Name = "DifEnLtsReset"
        Me.DifEnLtsReset.ReadOnly = True
        Me.DifEnLtsReset.Width = 60
        '
        'DesctoXReset
        '
        Me.DesctoXReset.DataPropertyName = "Descto X Reset"
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.DesctoXReset.DefaultCellStyle = DataGridViewCellStyle5
        Me.DesctoXReset.Frozen = True
        Me.DesctoXReset.HeaderText = "Descto X Reset"
        Me.DesctoXReset.Name = "DesctoXReset"
        Me.DesctoXReset.ReadOnly = True
        Me.DesctoXReset.Width = 60
        '
        'FaltanteConAjuste
        '
        Me.FaltanteConAjuste.DataPropertyName = "Faltante con Ajuste"
        Me.FaltanteConAjuste.Frozen = True
        Me.FaltanteConAjuste.HeaderText = "Faltante con Ajuste"
        Me.FaltanteConAjuste.Name = "FaltanteConAjuste"
        Me.FaltanteConAjuste.ReadOnly = True
        Me.FaltanteConAjuste.Width = 60
        '
        'RendEstandar
        '
        Me.RendEstandar.DataPropertyName = "Rend_ Estandar"
        Me.RendEstandar.Frozen = True
        Me.RendEstandar.HeaderText = "Rend Estandar"
        Me.RendEstandar.Name = "RendEstandar"
        Me.RendEstandar.ReadOnly = True
        Me.RendEstandar.Width = 60
        '
        'LtsEstandar
        '
        Me.LtsEstandar.DataPropertyName = "Lts Estandar"
        Me.LtsEstandar.Frozen = True
        Me.LtsEstandar.HeaderText = "Lts Estandar"
        Me.LtsEstandar.Name = "LtsEstandar"
        Me.LtsEstandar.ReadOnly = True
        Me.LtsEstandar.Width = 60
        '
        'Motor
        '
        Me.Motor.DataPropertyName = "Motor"
        Me.Motor.Frozen = True
        Me.Motor.HeaderText = "Motor"
        Me.Motor.Name = "Motor"
        Me.Motor.ReadOnly = True
        Me.Motor.Width = 70
        '
        'frmEvaluacionviaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(1167, 613)
        Me.Controls.Add(Me.grdEvaluacion)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmEvaluacionviaje"
        Me.Text = "Evaluacion de Viajes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grdEvaluacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtViaje As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnExportar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbFecFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbFecIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents grdEvaluacion As System.Windows.Forms.DataGridView
    Friend WithEvents TxtSemana As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnBuscar2 As System.Windows.Forms.Button
    Friend WithEvents Unidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Destino As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Operador As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Viaje As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CartasPorte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Peso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KMReales As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KMReset As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LtsViaje As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RendRealCalc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RendimientoReset As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LtsReset As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DifEnLtsReset As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DesctoXReset As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FaltanteConAjuste As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RendEstandar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LtsEstandar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Motor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtOperador As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbArea As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtUnidad As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnReporteDiesel As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents txtJustificacion As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
