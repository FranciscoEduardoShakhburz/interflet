<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SeguimientoEmbarques
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SeguimientoEmbarques))
        Me.gridInfo = New System.Windows.Forms.DataGridView
        Me.btnActualizar = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.pBar = New System.Windows.Forms.ProgressBar
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExportarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VistaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SelectorDeColumnasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EstadìsticasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.dTPFecha = New System.Windows.Forms.DateTimePicker
        Me.cmBStatus = New System.Windows.Forms.ComboBox
        Me.dTPFechaDoc = New System.Windows.Forms.DateTimePicker
        Me.rBTodo = New System.Windows.Forms.RadioButton
        Me.rBFechaSal = New System.Windows.Forms.RadioButton
        Me.rBFechaDoc = New System.Windows.Forms.RadioButton
        Me.rBEstatus = New System.Windows.Forms.RadioButton
        Me.colFecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colHora = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colFechaDoc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colEco = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPlacas = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colFlota = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSitio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colViaje = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colIgnicion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTiempoEstacionada = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCartaPorte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colFechaSalPatio2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colHoraSalPatio2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colEquipoArrastre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTipoRemolques = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTiempo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colAlerta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCel = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colOperador = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colReferencia = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTipoOperacion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colContenedor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCargaConDaño = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colFechaProgEnt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colFechaCliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colLlegoATiempo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDestino = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colRuta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colFueraRuta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colStatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colHoraStatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colComentarios = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.gridInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gridInfo
        '
        Me.gridInfo.AllowUserToAddRows = False
        Me.gridInfo.AllowUserToOrderColumns = True
        Me.gridInfo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridInfo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colFecha, Me.colHora, Me.colFechaDoc, Me.colEco, Me.colPlacas, Me.colFlota, Me.colSitio, Me.colViaje, Me.colIgnicion, Me.colTiempoEstacionada, Me.colCartaPorte, Me.colFechaSalPatio2, Me.colHoraSalPatio2, Me.colEquipoArrastre, Me.colTipoRemolques, Me.colTiempo, Me.colAlerta, Me.colCel, Me.colOperador, Me.colCliente, Me.colReferencia, Me.colTipoOperacion, Me.colContenedor, Me.colCargaConDaño, Me.colFechaProgEnt, Me.colFechaCliente, Me.colLlegoATiempo, Me.colDestino, Me.colRuta, Me.colFueraRuta, Me.colStatus, Me.colHoraStatus, Me.colComentarios})
        Me.gridInfo.Location = New System.Drawing.Point(12, 120)
        Me.gridInfo.Name = "gridInfo"
        Me.gridInfo.ReadOnly = True
        Me.gridInfo.Size = New System.Drawing.Size(1043, 479)
        Me.gridInfo.TabIndex = 0
        '
        'btnActualizar
        '
        Me.btnActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.Image = CType(resources.GetObject("btnActualizar.Image"), System.Drawing.Image)
        Me.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnActualizar.Location = New System.Drawing.Point(917, 15)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(120, 40)
        Me.btnActualizar.TabIndex = 1
        Me.btnActualizar.Text = "   Refrescar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.pBar)
        Me.GroupBox1.Controls.Add(Me.btnActualizar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1043, 61)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'pBar
        '
        Me.pBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pBar.Location = New System.Drawing.Point(6, 15)
        Me.pBar.Minimum = 1
        Me.pBar.Name = "pBar"
        Me.pBar.Size = New System.Drawing.Size(905, 40)
        Me.pBar.TabIndex = 2
        Me.pBar.Value = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.VistaToolStripMenuItem, Me.OpcionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1067, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuardarToolStripMenuItem, Me.ExportarToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.Image = CType(resources.GetObject("GuardarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.GuardarToolStripMenuItem.Text = "Guardar"
        '
        'ExportarToolStripMenuItem
        '
        Me.ExportarToolStripMenuItem.Image = CType(resources.GetObject("ExportarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExportarToolStripMenuItem.Name = "ExportarToolStripMenuItem"
        Me.ExportarToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ExportarToolStripMenuItem.Text = "Exportar a Excel"
        '
        'VistaToolStripMenuItem
        '
        Me.VistaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectorDeColumnasToolStripMenuItem})
        Me.VistaToolStripMenuItem.Name = "VistaToolStripMenuItem"
        Me.VistaToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.VistaToolStripMenuItem.Text = "Vista"
        '
        'SelectorDeColumnasToolStripMenuItem
        '
        Me.SelectorDeColumnasToolStripMenuItem.Image = CType(resources.GetObject("SelectorDeColumnasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SelectorDeColumnasToolStripMenuItem.Name = "SelectorDeColumnasToolStripMenuItem"
        Me.SelectorDeColumnasToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.SelectorDeColumnasToolStripMenuItem.Text = "Selector de columnas"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EstadìsticasToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'EstadìsticasToolStripMenuItem
        '
        Me.EstadìsticasToolStripMenuItem.Image = CType(resources.GetObject("EstadìsticasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EstadìsticasToolStripMenuItem.Name = "EstadìsticasToolStripMenuItem"
        Me.EstadìsticasToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.EstadìsticasToolStripMenuItem.Text = "Estadísticas"
        '
        'dTPFecha
        '
        Me.dTPFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dTPFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dTPFecha.Location = New System.Drawing.Point(193, 94)
        Me.dTPFecha.Name = "dTPFecha"
        Me.dTPFecha.Size = New System.Drawing.Size(96, 20)
        Me.dTPFecha.TabIndex = 5
        '
        'cmBStatus
        '
        Me.cmBStatus.FormattingEnabled = True
        Me.cmBStatus.Items.AddRange(New Object() {"TODO", "TRANSITO", "REGRESO", "CLIENTE", "PATIO", "PATIO MTY"})
        Me.cmBStatus.Location = New System.Drawing.Point(644, 95)
        Me.cmBStatus.Name = "cmBStatus"
        Me.cmBStatus.Size = New System.Drawing.Size(121, 21)
        Me.cmBStatus.TabIndex = 7
        '
        'dTPFechaDoc
        '
        Me.dTPFechaDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dTPFechaDoc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dTPFechaDoc.Location = New System.Drawing.Point(469, 94)
        Me.dTPFechaDoc.Name = "dTPFechaDoc"
        Me.dTPFechaDoc.Size = New System.Drawing.Size(96, 20)
        Me.dTPFechaDoc.TabIndex = 11
        '
        'rBTodo
        '
        Me.rBTodo.AutoSize = True
        Me.rBTodo.BackColor = System.Drawing.Color.Transparent
        Me.rBTodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rBTodo.Location = New System.Drawing.Point(12, 96)
        Me.rBTodo.Name = "rBTodo"
        Me.rBTodo.Size = New System.Drawing.Size(54, 17)
        Me.rBTodo.TabIndex = 13
        Me.rBTodo.TabStop = True
        Me.rBTodo.Text = "Todo"
        Me.rBTodo.UseVisualStyleBackColor = False
        '
        'rBFechaSal
        '
        Me.rBFechaSal.AutoSize = True
        Me.rBFechaSal.BackColor = System.Drawing.Color.Transparent
        Me.rBFechaSal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rBFechaSal.Location = New System.Drawing.Point(72, 96)
        Me.rBFechaSal.Name = "rBFechaSal"
        Me.rBFechaSal.Size = New System.Drawing.Size(115, 17)
        Me.rBFechaSal.TabIndex = 14
        Me.rBFechaSal.TabStop = True
        Me.rBFechaSal.Text = "Fecha de salida"
        Me.rBFechaSal.UseVisualStyleBackColor = False
        '
        'rBFechaDoc
        '
        Me.rBFechaDoc.AutoSize = True
        Me.rBFechaDoc.BackColor = System.Drawing.Color.Transparent
        Me.rBFechaDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rBFechaDoc.Location = New System.Drawing.Point(295, 96)
        Me.rBFechaDoc.Name = "rBFechaDoc"
        Me.rBFechaDoc.Size = New System.Drawing.Size(168, 17)
        Me.rBFechaDoc.TabIndex = 15
        Me.rBFechaDoc.TabStop = True
        Me.rBFechaDoc.Text = "Fecha de documentación"
        Me.rBFechaDoc.UseVisualStyleBackColor = False
        '
        'rBEstatus
        '
        Me.rBEstatus.AutoSize = True
        Me.rBEstatus.BackColor = System.Drawing.Color.Transparent
        Me.rBEstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rBEstatus.Location = New System.Drawing.Point(571, 96)
        Me.rBEstatus.Name = "rBEstatus"
        Me.rBEstatus.Size = New System.Drawing.Size(67, 17)
        Me.rBEstatus.TabIndex = 16
        Me.rBEstatus.TabStop = True
        Me.rBEstatus.Text = "Estatus"
        Me.rBEstatus.UseVisualStyleBackColor = False
        '
        'colFecha
        '
        Me.colFecha.HeaderText = "FECHA DE SALIDA"
        Me.colFecha.Name = "colFecha"
        Me.colFecha.ReadOnly = True
        '
        'colHora
        '
        Me.colHora.HeaderText = "HORA DE SALIDA"
        Me.colHora.Name = "colHora"
        Me.colHora.ReadOnly = True
        '
        'colFechaDoc
        '
        Me.colFechaDoc.HeaderText = "FECHA DE DOCUMENTACION"
        Me.colFechaDoc.Name = "colFechaDoc"
        Me.colFechaDoc.ReadOnly = True
        '
        'colEco
        '
        Me.colEco.HeaderText = "ECO"
        Me.colEco.Name = "colEco"
        Me.colEco.ReadOnly = True
        '
        'colPlacas
        '
        Me.colPlacas.HeaderText = "PLACAS"
        Me.colPlacas.Name = "colPlacas"
        Me.colPlacas.ReadOnly = True
        '
        'colFlota
        '
        Me.colFlota.HeaderText = "FLOTA"
        Me.colFlota.Name = "colFlota"
        Me.colFlota.ReadOnly = True
        '
        'colSitio
        '
        Me.colSitio.HeaderText = "SITIO"
        Me.colSitio.Name = "colSitio"
        Me.colSitio.ReadOnly = True
        '
        'colViaje
        '
        Me.colViaje.HeaderText = "VIAJE"
        Me.colViaje.Name = "colViaje"
        Me.colViaje.ReadOnly = True
        '
        'colIgnicion
        '
        Me.colIgnicion.HeaderText = "IGNICION"
        Me.colIgnicion.Name = "colIgnicion"
        Me.colIgnicion.ReadOnly = True
        '
        'colTiempoEstacionada
        '
        Me.colTiempoEstacionada.HeaderText = "Tiempo de estacionamiento"
        Me.colTiempoEstacionada.Name = "colTiempoEstacionada"
        Me.colTiempoEstacionada.ReadOnly = True
        '
        'colCartaPorte
        '
        Me.colCartaPorte.HeaderText = "CARTA PORTE"
        Me.colCartaPorte.Name = "colCartaPorte"
        Me.colCartaPorte.ReadOnly = True
        '
        'colFechaSalPatio2
        '
        Me.colFechaSalPatio2.HeaderText = "FECHA DE SALIDA DEL PATIO 2"
        Me.colFechaSalPatio2.Name = "colFechaSalPatio2"
        Me.colFechaSalPatio2.ReadOnly = True
        '
        'colHoraSalPatio2
        '
        Me.colHoraSalPatio2.HeaderText = "HORA DE SALIDA DEL PATIO 2"
        Me.colHoraSalPatio2.Name = "colHoraSalPatio2"
        Me.colHoraSalPatio2.ReadOnly = True
        '
        'colEquipoArrastre
        '
        Me.colEquipoArrastre.HeaderText = "EQUIPO DE ARRASTRE"
        Me.colEquipoArrastre.Name = "colEquipoArrastre"
        Me.colEquipoArrastre.ReadOnly = True
        '
        'colTipoRemolques
        '
        Me.colTipoRemolques.HeaderText = "TIPOS DE REMOLQUE"
        Me.colTipoRemolques.Name = "colTipoRemolques"
        Me.colTipoRemolques.ReadOnly = True
        '
        'colTiempo
        '
        Me.colTiempo.HeaderText = "TIEMPO SIN EMITIR POSICIÓN"
        Me.colTiempo.Name = "colTiempo"
        Me.colTiempo.ReadOnly = True
        '
        'colAlerta
        '
        Me.colAlerta.HeaderText = "ALERTA"
        Me.colAlerta.Name = "colAlerta"
        Me.colAlerta.ReadOnly = True
        '
        'colCel
        '
        Me.colCel.HeaderText = "CEL"
        Me.colCel.Name = "colCel"
        Me.colCel.ReadOnly = True
        '
        'colOperador
        '
        Me.colOperador.HeaderText = "OPERADOR"
        Me.colOperador.Name = "colOperador"
        Me.colOperador.ReadOnly = True
        '
        'colCliente
        '
        Me.colCliente.HeaderText = "CLIENTE"
        Me.colCliente.Name = "colCliente"
        Me.colCliente.ReadOnly = True
        '
        'colReferencia
        '
        Me.colReferencia.HeaderText = "REFERENCIA"
        Me.colReferencia.Name = "colReferencia"
        Me.colReferencia.ReadOnly = True
        '
        'colTipoOperacion
        '
        Me.colTipoOperacion.HeaderText = "TIPO DE OPERACION"
        Me.colTipoOperacion.Name = "colTipoOperacion"
        Me.colTipoOperacion.ReadOnly = True
        '
        'colContenedor
        '
        Me.colContenedor.HeaderText = "CONTENEDOR"
        Me.colContenedor.Name = "colContenedor"
        Me.colContenedor.ReadOnly = True
        '
        'colCargaConDaño
        '
        Me.colCargaConDaño.HeaderText = "CARGA DAÑADA"
        Me.colCargaConDaño.Name = "colCargaConDaño"
        Me.colCargaConDaño.ReadOnly = True
        '
        'colFechaProgEnt
        '
        Me.colFechaProgEnt.HeaderText = "FECHA PROGRAMADA DE ENTREGA"
        Me.colFechaProgEnt.Name = "colFechaProgEnt"
        Me.colFechaProgEnt.ReadOnly = True
        '
        'colFechaCliente
        '
        Me.colFechaCliente.HeaderText = "FECHA DE LLEGADA CON CLIENTE"
        Me.colFechaCliente.Name = "colFechaCliente"
        Me.colFechaCliente.ReadOnly = True
        '
        'colLlegoATiempo
        '
        Me.colLlegoATiempo.HeaderText = "¿LLEGÓ A TIEMPO?"
        Me.colLlegoATiempo.Name = "colLlegoATiempo"
        Me.colLlegoATiempo.ReadOnly = True
        '
        'colDestino
        '
        Me.colDestino.HeaderText = "DESTINO"
        Me.colDestino.Name = "colDestino"
        Me.colDestino.ReadOnly = True
        '
        'colRuta
        '
        Me.colRuta.HeaderText = "RUTA"
        Me.colRuta.Name = "colRuta"
        Me.colRuta.ReadOnly = True
        '
        'colFueraRuta
        '
        Me.colFueraRuta.HeaderText = "¿Esta en ruta?"
        Me.colFueraRuta.Name = "colFueraRuta"
        Me.colFueraRuta.ReadOnly = True
        '
        'colStatus
        '
        Me.colStatus.HeaderText = "STATUS"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.ReadOnly = True
        '
        'colHoraStatus
        '
        Me.colHoraStatus.HeaderText = "HORA"
        Me.colHoraStatus.Name = "colHoraStatus"
        Me.colHoraStatus.ReadOnly = True
        '
        'colComentarios
        '
        Me.colComentarios.HeaderText = "COMENTARIOS"
        Me.colComentarios.Name = "colComentarios"
        Me.colComentarios.ReadOnly = True
        '
        'SeguimientoEmbarques
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1067, 611)
        Me.Controls.Add(Me.rBEstatus)
        Me.Controls.Add(Me.rBFechaDoc)
        Me.Controls.Add(Me.rBFechaSal)
        Me.Controls.Add(Me.rBTodo)
        Me.Controls.Add(Me.dTPFechaDoc)
        Me.Controls.Add(Me.cmBStatus)
        Me.Controls.Add(Me.dTPFecha)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gridInfo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "SeguimientoEmbarques"
        Me.Text = "Seguimiento de embarques"
        CType(Me.gridInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gridInfo As System.Windows.Forms.DataGridView
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents pBar As System.Windows.Forms.ProgressBar
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VistaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelectorDeColumnasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpcionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EstadìsticasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dTPFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmBStatus As System.Windows.Forms.ComboBox
    Friend WithEvents dTPFechaDoc As System.Windows.Forms.DateTimePicker
    Friend WithEvents rBTodo As System.Windows.Forms.RadioButton
    Friend WithEvents rBFechaSal As System.Windows.Forms.RadioButton
    Friend WithEvents rBFechaDoc As System.Windows.Forms.RadioButton
    Friend WithEvents rBEstatus As System.Windows.Forms.RadioButton
    Friend WithEvents colFecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHora As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFechaDoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEco As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPlacas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFlota As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSitio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colViaje As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colIgnicion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTiempoEstacionada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCartaPorte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFechaSalPatio2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHoraSalPatio2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEquipoArrastre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTipoRemolques As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTiempo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAlerta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colOperador As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colReferencia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTipoOperacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colContenedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCargaConDaño As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFechaProgEnt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFechaCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colLlegoATiempo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDestino As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colRuta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFueraRuta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHoraStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colComentarios As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
