<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AsignacionOperadores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AsignacionOperadores))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.tSBCatOperadores = New System.Windows.Forms.ToolStripButton
        Me.tSBCatEquipo = New System.Windows.Forms.ToolStripButton
        Me.tSBReporte = New System.Windows.Forms.ToolStripButton
        Me.tSBSalir = New System.Windows.Forms.ToolStripButton
        Me.gBOperadores = New System.Windows.Forms.GroupBox
        Me.btnEditar = New System.Windows.Forms.Button
        Me.btnEliminar = New System.Windows.Forms.Button
        Me.btnAgregar = New System.Windows.Forms.Button
        Me.dTPFecha = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.dGVOperadores = New System.Windows.Forms.DataGridView
        Me.gBMovimientos = New System.Windows.Forms.GroupBox
        Me.rBTodosOperadores = New System.Windows.Forms.RadioButton
        Me.rBPorOperador = New System.Windows.Forms.RadioButton
        Me.dGVMovimientos = New System.Windows.Forms.DataGridView
        Me.colUnidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMovimiento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colHora = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colUbicacion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colLugar = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colRemolque1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDolly = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colRemolque2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colContenedor1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colContenedor2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colContenedor11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colContenedor22 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cMSCambiarEstatus = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CambiarEstatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.colOperador = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTipoOper = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colHoraEntrada = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colHoraManiobra = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colHoraAsignacion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colEstatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ToolStrip1.SuspendLayout()
        Me.gBOperadores.SuspendLayout()
        CType(Me.dGVOperadores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gBMovimientos.SuspendLayout()
        CType(Me.dGVMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cMSCambiarEstatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tSBCatOperadores, Me.tSBCatEquipo, Me.tSBReporte, Me.tSBSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(951, 70)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tSBCatOperadores
        '
        Me.tSBCatOperadores.AutoSize = False
        Me.tSBCatOperadores.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tSBCatOperadores.Image = CType(resources.GetObject("tSBCatOperadores.Image"), System.Drawing.Image)
        Me.tSBCatOperadores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tSBCatOperadores.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tSBCatOperadores.Name = "tSBCatOperadores"
        Me.tSBCatOperadores.Size = New System.Drawing.Size(90, 65)
        Me.tSBCatOperadores.Text = "Cat. Operadores"
        Me.tSBCatOperadores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tSBCatEquipo
        '
        Me.tSBCatEquipo.AutoSize = False
        Me.tSBCatEquipo.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tSBCatEquipo.Image = CType(resources.GetObject("tSBCatEquipo.Image"), System.Drawing.Image)
        Me.tSBCatEquipo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tSBCatEquipo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tSBCatEquipo.Name = "tSBCatEquipo"
        Me.tSBCatEquipo.Size = New System.Drawing.Size(90, 65)
        Me.tSBCatEquipo.Text = "Cat. Equipo"
        Me.tSBCatEquipo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tSBReporte
        '
        Me.tSBReporte.AutoSize = False
        Me.tSBReporte.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tSBReporte.Image = CType(resources.GetObject("tSBReporte.Image"), System.Drawing.Image)
        Me.tSBReporte.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tSBReporte.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tSBReporte.Name = "tSBReporte"
        Me.tSBReporte.Size = New System.Drawing.Size(153, 65)
        Me.tSBReporte.Text = "Reporte de movs. Diarios"
        Me.tSBReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tSBSalir
        '
        Me.tSBSalir.AutoSize = False
        Me.tSBSalir.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tSBSalir.Image = CType(resources.GetObject("tSBSalir.Image"), System.Drawing.Image)
        Me.tSBSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tSBSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tSBSalir.Name = "tSBSalir"
        Me.tSBSalir.Size = New System.Drawing.Size(90, 65)
        Me.tSBSalir.Text = "Salir"
        Me.tSBSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'gBOperadores
        '
        Me.gBOperadores.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gBOperadores.BackColor = System.Drawing.Color.Transparent
        Me.gBOperadores.Controls.Add(Me.btnEditar)
        Me.gBOperadores.Controls.Add(Me.btnEliminar)
        Me.gBOperadores.Controls.Add(Me.btnAgregar)
        Me.gBOperadores.Controls.Add(Me.dTPFecha)
        Me.gBOperadores.Controls.Add(Me.Label1)
        Me.gBOperadores.Controls.Add(Me.dGVOperadores)
        Me.gBOperadores.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gBOperadores.Location = New System.Drawing.Point(12, 73)
        Me.gBOperadores.Name = "gBOperadores"
        Me.gBOperadores.Size = New System.Drawing.Size(461, 473)
        Me.gBOperadores.TabIndex = 1
        Me.gBOperadores.TabStop = False
        Me.gBOperadores.Text = "Operadores"
        '
        'btnEditar
        '
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.Location = New System.Drawing.Point(285, 19)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(40, 40)
        Me.btnEditar.TabIndex = 5
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.Location = New System.Drawing.Point(239, 19)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(40, 40)
        Me.btnEliminar.TabIndex = 4
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.Location = New System.Drawing.Point(193, 19)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(40, 40)
        Me.btnAgregar.TabIndex = 3
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'dTPFecha
        '
        Me.dTPFecha.Enabled = False
        Me.dTPFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dTPFecha.Location = New System.Drawing.Point(58, 39)
        Me.dTPFecha.Name = "dTPFecha"
        Me.dTPFecha.Size = New System.Drawing.Size(95, 20)
        Me.dTPFecha.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Fecha:"
        '
        'dGVOperadores
        '
        Me.dGVOperadores.AllowUserToAddRows = False
        Me.dGVOperadores.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dGVOperadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dGVOperadores.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.dGVOperadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dGVOperadores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colOperador, Me.colTipoOper, Me.colHoraEntrada, Me.colHoraManiobra, Me.colHoraAsignacion, Me.colEstatus})
        Me.dGVOperadores.Location = New System.Drawing.Point(6, 65)
        Me.dGVOperadores.Name = "dGVOperadores"
        Me.dGVOperadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dGVOperadores.Size = New System.Drawing.Size(449, 402)
        Me.dGVOperadores.TabIndex = 0
        '
        'gBMovimientos
        '
        Me.gBMovimientos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gBMovimientos.BackColor = System.Drawing.Color.Transparent
        Me.gBMovimientos.Controls.Add(Me.rBTodosOperadores)
        Me.gBMovimientos.Controls.Add(Me.rBPorOperador)
        Me.gBMovimientos.Controls.Add(Me.dGVMovimientos)
        Me.gBMovimientos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gBMovimientos.Location = New System.Drawing.Point(479, 73)
        Me.gBMovimientos.Name = "gBMovimientos"
        Me.gBMovimientos.Size = New System.Drawing.Size(461, 473)
        Me.gBMovimientos.TabIndex = 2
        Me.gBMovimientos.TabStop = False
        Me.gBMovimientos.Text = "Movimientos"
        '
        'rBTodosOperadores
        '
        Me.rBTodosOperadores.AutoSize = True
        Me.rBTodosOperadores.Location = New System.Drawing.Point(110, 31)
        Me.rBTodosOperadores.Name = "rBTodosOperadores"
        Me.rBTodosOperadores.Size = New System.Drawing.Size(147, 17)
        Me.rBTodosOperadores.TabIndex = 2
        Me.rBTodosOperadores.TabStop = True
        Me.rBTodosOperadores.Text = "Todos los operadores"
        Me.rBTodosOperadores.UseVisualStyleBackColor = True
        '
        'rBPorOperador
        '
        Me.rBPorOperador.AutoSize = True
        Me.rBPorOperador.Location = New System.Drawing.Point(6, 31)
        Me.rBPorOperador.Name = "rBPorOperador"
        Me.rBPorOperador.Size = New System.Drawing.Size(98, 17)
        Me.rBPorOperador.TabIndex = 1
        Me.rBPorOperador.TabStop = True
        Me.rBPorOperador.Text = "Por operador"
        Me.rBPorOperador.UseVisualStyleBackColor = True
        '
        'dGVMovimientos
        '
        Me.dGVMovimientos.AllowUserToAddRows = False
        Me.dGVMovimientos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dGVMovimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dGVMovimientos.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.dGVMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dGVMovimientos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colUnidad, Me.colMovimiento, Me.colHora, Me.colUbicacion, Me.colLugar, Me.colRemolque1, Me.colDolly, Me.colRemolque2, Me.colContenedor1, Me.colContenedor2, Me.colContenedor11, Me.colContenedor22})
        Me.dGVMovimientos.Location = New System.Drawing.Point(6, 55)
        Me.dGVMovimientos.Name = "dGVMovimientos"
        Me.dGVMovimientos.Size = New System.Drawing.Size(449, 412)
        Me.dGVMovimientos.TabIndex = 0
        '
        'colUnidad
        '
        Me.colUnidad.HeaderText = "Unidad"
        Me.colUnidad.Name = "colUnidad"
        '
        'colMovimiento
        '
        Me.colMovimiento.HeaderText = "Movimiento"
        Me.colMovimiento.Name = "colMovimiento"
        '
        'colHora
        '
        Me.colHora.HeaderText = "Hora"
        Me.colHora.Name = "colHora"
        '
        'colUbicacion
        '
        Me.colUbicacion.HeaderText = "Ubicacion"
        Me.colUbicacion.Name = "colUbicacion"
        '
        'colLugar
        '
        Me.colLugar.HeaderText = "Lugar"
        Me.colLugar.Name = "colLugar"
        '
        'colRemolque1
        '
        Me.colRemolque1.HeaderText = "Remolque 1"
        Me.colRemolque1.Name = "colRemolque1"
        '
        'colDolly
        '
        Me.colDolly.HeaderText = "Dolly"
        Me.colDolly.Name = "colDolly"
        '
        'colRemolque2
        '
        Me.colRemolque2.HeaderText = "Remolque 2"
        Me.colRemolque2.Name = "colRemolque2"
        '
        'colContenedor1
        '
        Me.colContenedor1.HeaderText = "Contenedor 1"
        Me.colContenedor1.Name = "colContenedor1"
        '
        'colContenedor2
        '
        Me.colContenedor2.HeaderText = "Contenedor 2"
        Me.colContenedor2.Name = "colContenedor2"
        '
        'colContenedor11
        '
        Me.colContenedor11.HeaderText = "Contenedor 11"
        Me.colContenedor11.Name = "colContenedor11"
        '
        'colContenedor22
        '
        Me.colContenedor22.HeaderText = "Contenedor 22"
        Me.colContenedor22.Name = "colContenedor22"
        '
        'cMSCambiarEstatus
        '
        Me.cMSCambiarEstatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CambiarEstatusToolStripMenuItem})
        Me.cMSCambiarEstatus.Name = "cMSCambiarEstatus"
        Me.cMSCambiarEstatus.Size = New System.Drawing.Size(164, 26)
        '
        'CambiarEstatusToolStripMenuItem
        '
        Me.CambiarEstatusToolStripMenuItem.Name = "CambiarEstatusToolStripMenuItem"
        Me.CambiarEstatusToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.CambiarEstatusToolStripMenuItem.Text = "Cambiar estatus"
        '
        'colOperador
        '
        Me.colOperador.HeaderText = "Operador"
        Me.colOperador.Name = "colOperador"
        '
        'colTipoOper
        '
        Me.colTipoOper.HeaderText = "Tipo de operador"
        Me.colTipoOper.Name = "colTipoOper"
        '
        'colHoraEntrada
        '
        Me.colHoraEntrada.HeaderText = "Hora de Entrada"
        Me.colHoraEntrada.Name = "colHoraEntrada"
        '
        'colHoraManiobra
        '
        Me.colHoraManiobra.HeaderText = "Hora de entrega de maniobra"
        Me.colHoraManiobra.Name = "colHoraManiobra"
        '
        'colHoraAsignacion
        '
        Me.colHoraAsignacion.HeaderText = "Hora de asignación"
        Me.colHoraAsignacion.Name = "colHoraAsignacion"
        '
        'colEstatus
        '
        Me.colEstatus.HeaderText = "Estatus"
        Me.colEstatus.Name = "colEstatus"
        '
        'AsignacionOperadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(951, 558)
        Me.Controls.Add(Me.gBMovimientos)
        Me.Controls.Add(Me.gBOperadores)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AsignacionOperadores"
        Me.Text = "Operadores disponibles"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.gBOperadores.ResumeLayout(False)
        Me.gBOperadores.PerformLayout()
        CType(Me.dGVOperadores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gBMovimientos.ResumeLayout(False)
        Me.gBMovimientos.PerformLayout()
        CType(Me.dGVMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cMSCambiarEstatus.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tSBCatOperadores As System.Windows.Forms.ToolStripButton
    Friend WithEvents tSBCatEquipo As System.Windows.Forms.ToolStripButton
    Friend WithEvents gBOperadores As System.Windows.Forms.GroupBox
    Friend WithEvents dGVOperadores As System.Windows.Forms.DataGridView
    Friend WithEvents gBMovimientos As System.Windows.Forms.GroupBox
    Friend WithEvents dGVMovimientos As System.Windows.Forms.DataGridView
    Friend WithEvents dTPFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tSBReporte As System.Windows.Forms.ToolStripButton
    Friend WithEvents tSBSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents rBTodosOperadores As System.Windows.Forms.RadioButton
    Friend WithEvents rBPorOperador As System.Windows.Forms.RadioButton
    Friend WithEvents cMSCambiarEstatus As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CambiarEstatusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents colUnidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMovimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHora As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colUbicacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colLugar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colRemolque1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDolly As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colRemolque2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colContenedor1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colContenedor2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colContenedor11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colContenedor22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colOperador As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTipoOper As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHoraEntrada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHoraManiobra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHoraAsignacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEstatus As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
