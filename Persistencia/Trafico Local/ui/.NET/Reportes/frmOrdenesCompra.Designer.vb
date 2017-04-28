<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmOrdenesCompra
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()

        InitializeComponent()
    End Sub

	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub

    Private components As System.ComponentModel.IContainer
    Public ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents cmbTipo As System.Windows.Forms.ComboBox
    Public WithEvents cmdDetalle As System.Windows.Forms.Button
    Public WithEvents txtTotal As System.Windows.Forms.TextBox
    Public WithEvents txtTotEnTiempo As System.Windows.Forms.TextBox
    Public WithEvents txtEnTiempo As System.Windows.Forms.TextBox
    Public WithEvents txtCantDias As System.Windows.Forms.TextBox
    Public WithEvents cmdProcesar As System.Windows.Forms.Button
    Public WithEvents dtFecFin As AxMSComCtl2.AxDTPicker
    Public WithEvents dtFecIni As AxMSComCtl2.AxDTPicker
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents cmdDetalle2 As System.Windows.Forms.Button
    Public WithEvents txtTotal2 As System.Windows.Forms.TextBox
    Public WithEvents txtTotEnTiempo2 As System.Windows.Forms.TextBox
    Public WithEvents txtEnTiempo2 As System.Windows.Forms.TextBox
    Public WithEvents Label16 As System.Windows.Forms.Label
    Public WithEvents Label15 As System.Windows.Forms.Label
    Public WithEvents Label14 As System.Windows.Forms.Label
    Public WithEvents Label13 As System.Windows.Forms.Label
    Public WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Public WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label



	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrdenesCompra))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmbTipo = New System.Windows.Forms.ComboBox
        Me.cmdDetalle = New System.Windows.Forms.Button
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.txtTotEnTiempo = New System.Windows.Forms.TextBox
        Me.txtEnTiempo = New System.Windows.Forms.TextBox
        Me.txtCantDias = New System.Windows.Forms.TextBox
        Me.cmdProcesar = New System.Windows.Forms.Button
        Me.dtFecFin = New AxMSComCtl2.AxDTPicker
        Me.dtFecIni = New AxMSComCtl2.AxDTPicker
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Frame2 = New System.Windows.Forms.GroupBox
        Me.cmdDetalle2 = New System.Windows.Forms.Button
        Me.txtTotal2 = New System.Windows.Forms.TextBox
        Me.txtTotEnTiempo2 = New System.Windows.Forms.TextBox
        Me.txtEnTiempo2 = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.dtFecFin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFecIni, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame1.SuspendLayout()
        Me.Frame2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbTipo
        '
        Me.cmbTipo.BackColor = System.Drawing.SystemColors.Window
        Me.cmbTipo.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbTipo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbTipo.Location = New System.Drawing.Point(528, 19)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbTipo.Size = New System.Drawing.Size(121, 21)
        Me.cmbTipo.TabIndex = 19
        '
        'cmdDetalle
        '
        Me.cmdDetalle.BackColor = System.Drawing.SystemColors.Control
        Me.cmdDetalle.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDetalle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdDetalle.Location = New System.Drawing.Point(608, 96)
        Me.cmdDetalle.Name = "cmdDetalle"
        Me.cmdDetalle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdDetalle.Size = New System.Drawing.Size(65, 33)
        Me.cmdDetalle.TabIndex = 10
        Me.cmdDetalle.Text = "Ver Detalle"
        Me.cmdDetalle.UseVisualStyleBackColor = False
        '
        'txtTotal
        '
        Me.txtTotal.AcceptsReturn = True
        Me.txtTotal.BackColor = System.Drawing.SystemColors.Window
        Me.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTotal.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTotal.Location = New System.Drawing.Point(440, 104)
        Me.txtTotal.MaxLength = 0
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTotal.Size = New System.Drawing.Size(65, 25)
        Me.txtTotal.TabIndex = 9
        '
        'txtTotEnTiempo
        '
        Me.txtTotEnTiempo.AcceptsReturn = True
        Me.txtTotEnTiempo.BackColor = System.Drawing.SystemColors.Window
        Me.txtTotEnTiempo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTotEnTiempo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTotEnTiempo.Location = New System.Drawing.Point(224, 104)
        Me.txtTotEnTiempo.MaxLength = 0
        Me.txtTotEnTiempo.Name = "txtTotEnTiempo"
        Me.txtTotEnTiempo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTotEnTiempo.Size = New System.Drawing.Size(65, 25)
        Me.txtTotEnTiempo.TabIndex = 8
        '
        'txtEnTiempo
        '
        Me.txtEnTiempo.AcceptsReturn = True
        Me.txtEnTiempo.BackColor = System.Drawing.SystemColors.Window
        Me.txtEnTiempo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEnTiempo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtEnTiempo.Location = New System.Drawing.Point(24, 104)
        Me.txtEnTiempo.MaxLength = 0
        Me.txtEnTiempo.Name = "txtEnTiempo"
        Me.txtEnTiempo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtEnTiempo.Size = New System.Drawing.Size(48, 25)
        Me.txtEnTiempo.TabIndex = 7
        '
        'txtCantDias
        '
        Me.txtCantDias.AcceptsReturn = True
        Me.txtCantDias.BackColor = System.Drawing.SystemColors.Window
        Me.txtCantDias.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCantDias.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCantDias.Location = New System.Drawing.Point(424, 17)
        Me.txtCantDias.MaxLength = 0
        Me.txtCantDias.Name = "txtCantDias"
        Me.txtCantDias.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCantDias.Size = New System.Drawing.Size(41, 25)
        Me.txtCantDias.TabIndex = 3
        '
        'cmdProcesar
        '
        Me.cmdProcesar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdProcesar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdProcesar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdProcesar.Location = New System.Drawing.Point(664, 16)
        Me.cmdProcesar.Name = "cmdProcesar"
        Me.cmdProcesar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdProcesar.Size = New System.Drawing.Size(73, 26)
        Me.cmdProcesar.TabIndex = 4
        Me.cmdProcesar.Text = "Procesar"
        Me.cmdProcesar.UseVisualStyleBackColor = False
        '
        'dtFecFin
        '
        Me.dtFecFin.Location = New System.Drawing.Point(247, 19)
        Me.dtFecFin.Name = "dtFecFin"
        Me.dtFecFin.OcxState = CType(resources.GetObject("dtFecFin.OcxState"), System.Windows.Forms.AxHost.State)
        Me.dtFecFin.Size = New System.Drawing.Size(89, 25)
        Me.dtFecFin.TabIndex = 2
        '
        'dtFecIni
        '
        Me.dtFecIni.Location = New System.Drawing.Point(84, 15)
        Me.dtFecIni.Name = "dtFecIni"
        Me.dtFecIni.OcxState = CType(resources.GetObject("dtFecIni.OcxState"), System.Windows.Forms.AxHost.State)
        Me.dtFecIni.Size = New System.Drawing.Size(89, 25)
        Me.dtFecIni.TabIndex = 1
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.Transparent
        Me.Frame1.Controls.Add(Me.Label9)
        Me.Frame1.Controls.Add(Me.Label8)
        Me.Frame1.Controls.Add(Me.Label7)
        Me.Frame1.Controls.Add(Me.Label6)
        Me.Frame1.Controls.Add(Me.Label5)
        Me.Frame1.Controls.Add(Me.Label4)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(8, 64)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(713, 89)
        Me.Frame1.TabIndex = 12
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Indicadores de Ordenes de Compra"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(496, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(81, 33)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "No. Total de Ordenes"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(432, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(86, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Total Elementos:"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(288, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(141, 29)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "No. de Ordenes entregadas en Tiempo"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(216, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(89, 17)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Total Cumplidos:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(64, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(113, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "% Entregas en Tiempo"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(8, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(137, 17)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Porcentaje de Satisfacción:"
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.Color.Transparent
        Me.Frame2.Controls.Add(Me.cmdDetalle2)
        Me.Frame2.Controls.Add(Me.txtTotal2)
        Me.Frame2.Controls.Add(Me.txtTotEnTiempo2)
        Me.Frame2.Controls.Add(Me.txtEnTiempo2)
        Me.Frame2.Controls.Add(Me.Label16)
        Me.Frame2.Controls.Add(Me.Label15)
        Me.Frame2.Controls.Add(Me.Label14)
        Me.Frame2.Controls.Add(Me.Label13)
        Me.Frame2.Controls.Add(Me.Label12)
        Me.Frame2.Controls.Add(Me.Label11)
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(8, 168)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(713, 89)
        Me.Frame2.TabIndex = 20
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "Indicadores Reparación de Piezas"
        '
        'cmdDetalle2
        '
        Me.cmdDetalle2.BackColor = System.Drawing.SystemColors.Control
        Me.cmdDetalle2.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDetalle2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdDetalle2.Location = New System.Drawing.Point(600, 32)
        Me.cmdDetalle2.Name = "cmdDetalle2"
        Me.cmdDetalle2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdDetalle2.Size = New System.Drawing.Size(65, 33)
        Me.cmdDetalle2.TabIndex = 30
        Me.cmdDetalle2.Text = "Ver Detalle"
        Me.cmdDetalle2.UseVisualStyleBackColor = False
        '
        'txtTotal2
        '
        Me.txtTotal2.AcceptsReturn = True
        Me.txtTotal2.BackColor = System.Drawing.SystemColors.Window
        Me.txtTotal2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTotal2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTotal2.Location = New System.Drawing.Point(432, 40)
        Me.txtTotal2.MaxLength = 0
        Me.txtTotal2.Name = "txtTotal2"
        Me.txtTotal2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTotal2.Size = New System.Drawing.Size(65, 25)
        Me.txtTotal2.TabIndex = 27
        '
        'txtTotEnTiempo2
        '
        Me.txtTotEnTiempo2.AcceptsReturn = True
        Me.txtTotEnTiempo2.BackColor = System.Drawing.SystemColors.Window
        Me.txtTotEnTiempo2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTotEnTiempo2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTotEnTiempo2.Location = New System.Drawing.Point(216, 40)
        Me.txtTotEnTiempo2.MaxLength = 0
        Me.txtTotEnTiempo2.Name = "txtTotEnTiempo2"
        Me.txtTotEnTiempo2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTotEnTiempo2.Size = New System.Drawing.Size(65, 25)
        Me.txtTotEnTiempo2.TabIndex = 24
        '
        'txtEnTiempo2
        '
        Me.txtEnTiempo2.AcceptsReturn = True
        Me.txtEnTiempo2.BackColor = System.Drawing.SystemColors.Window
        Me.txtEnTiempo2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEnTiempo2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtEnTiempo2.Location = New System.Drawing.Point(16, 40)
        Me.txtEnTiempo2.MaxLength = 0
        Me.txtEnTiempo2.Name = "txtEnTiempo2"
        Me.txtEnTiempo2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtEnTiempo2.Size = New System.Drawing.Size(48, 25)
        Me.txtEnTiempo2.TabIndex = 21
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(496, 40)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label16.Size = New System.Drawing.Size(81, 33)
        Me.Label16.TabIndex = 29
        Me.Label16.Text = "No. Total de Reparaciones"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(432, 24)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(86, 13)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Total Elementos:"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(288, 40)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(133, 29)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "No. de Reparaciones entregadas en Tiempo"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(216, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(89, 17)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Total Cumplidos:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(64, 48)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(113, 13)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "% Entregas en Tiempo"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(8, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(137, 17)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Porcentaje de Satisfacción:"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(480, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(49, 32)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Tipo de Reporte"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(344, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(81, 33)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Cantidad de Días Permitidos:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(176, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Fecha Final:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(8, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha Inicial:"
        '
        'frmOrdenesCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(752, 271)
        Me.Controls.Add(Me.cmbTipo)
        Me.Controls.Add(Me.cmdDetalle)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtTotEnTiempo)
        Me.Controls.Add(Me.txtEnTiempo)
        Me.Controls.Add(Me.txtCantDias)
        Me.Controls.Add(Me.cmdProcesar)
        Me.Controls.Add(Me.dtFecFin)
        Me.Controls.Add(Me.dtFecIni)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(4, 30)
        Me.Name = "frmOrdenesCompra"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Indicadores Ordenes / Reparaciones"
        CType(Me.dtFecFin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFecIni, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.Frame2.ResumeLayout(False)
        Me.Frame2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region 
End Class