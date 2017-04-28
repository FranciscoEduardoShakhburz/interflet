<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CatalogoUnidades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CatalogoUnidades))
        Me.tSMenu = New System.Windows.Forms.ToolStrip
        Me.tSBAgregar = New System.Windows.Forms.ToolStripButton
        Me.tSBEliminar = New System.Windows.Forms.ToolStripButton
        Me.tSSSeparador = New System.Windows.Forms.ToolStripSeparator
        Me.tSBSalir = New System.Windows.Forms.ToolStripButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rBOperador = New System.Windows.Forms.RadioButton
        Me.rBEconomico = New System.Windows.Forms.RadioButton
        Me.tBFiltro = New System.Windows.Forms.TextBox
        Me.tCUnidades = New System.Windows.Forms.TabControl
        Me.tPAltamira = New System.Windows.Forms.TabPage
        Me.dGVAltamira = New System.Windows.Forms.DataGridView
        Me.colId = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colEconomico = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPlacas = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colOperador = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCel = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colFechaVencExamenMedico = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colFechaVencLicencia = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tPManzanillo = New System.Windows.Forms.TabPage
        Me.dGVManzanillo = New System.Windows.Forms.DataGridView
        Me.colIdMzo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colEconomicoMzo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPlacasMzo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colOperadorMzo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCelMzo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colFechaVencExamenMedicoMzo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colFechaVencLicenciaMzo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tPVeracruz = New System.Windows.Forms.TabPage
        Me.dGVVeracruz = New System.Windows.Forms.DataGridView
        Me.colIdVer = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colEconomicoVer = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPlacasVer = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colOperadorVer = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCelVer = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colFechaVencExamenMedicoVer = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colFechaVencLicenciaVer = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tSMenu.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tCUnidades.SuspendLayout()
        Me.tPAltamira.SuspendLayout()
        CType(Me.dGVAltamira, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tPManzanillo.SuspendLayout()
        CType(Me.dGVManzanillo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tPVeracruz.SuspendLayout()
        CType(Me.dGVVeracruz, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tSMenu
        '
        Me.tSMenu.AutoSize = False
        Me.tSMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tSMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tSBAgregar, Me.tSBEliminar, Me.tSSSeparador, Me.tSBSalir})
        Me.tSMenu.Location = New System.Drawing.Point(0, 0)
        Me.tSMenu.Name = "tSMenu"
        Me.tSMenu.Size = New System.Drawing.Size(631, 65)
        Me.tSMenu.TabIndex = 3
        Me.tSMenu.Text = "ToolStrip1"
        '
        'tSBAgregar
        '
        Me.tSBAgregar.AutoSize = False
        Me.tSBAgregar.Image = CType(resources.GetObject("tSBAgregar.Image"), System.Drawing.Image)
        Me.tSBAgregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tSBAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tSBAgregar.Name = "tSBAgregar"
        Me.tSBAgregar.Size = New System.Drawing.Size(60, 60)
        Me.tSBAgregar.Text = "Agregar"
        Me.tSBAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tSBEliminar
        '
        Me.tSBEliminar.AutoSize = False
        Me.tSBEliminar.Image = CType(resources.GetObject("tSBEliminar.Image"), System.Drawing.Image)
        Me.tSBEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tSBEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tSBEliminar.Name = "tSBEliminar"
        Me.tSBEliminar.Size = New System.Drawing.Size(60, 60)
        Me.tSBEliminar.Text = "Eliminar"
        Me.tSBEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tSSSeparador
        '
        Me.tSSSeparador.Name = "tSSSeparador"
        Me.tSSSeparador.Size = New System.Drawing.Size(6, 65)
        '
        'tSBSalir
        '
        Me.tSBSalir.AutoSize = False
        Me.tSBSalir.Image = CType(resources.GetObject("tSBSalir.Image"), System.Drawing.Image)
        Me.tSBSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tSBSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tSBSalir.Name = "tSBSalir"
        Me.tSBSalir.Size = New System.Drawing.Size(60, 60)
        Me.tSBSalir.Text = "Salir"
        Me.tSBSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rBOperador)
        Me.GroupBox1.Controls.Add(Me.rBEconomico)
        Me.GroupBox1.Controls.Add(Me.tBFiltro)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(607, 85)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtro de búsqueda"
        '
        'rBOperador
        '
        Me.rBOperador.AutoSize = True
        Me.rBOperador.Location = New System.Drawing.Point(187, 23)
        Me.rBOperador.Name = "rBOperador"
        Me.rBOperador.Size = New System.Drawing.Size(97, 22)
        Me.rBOperador.TabIndex = 2
        Me.rBOperador.TabStop = True
        Me.rBOperador.Text = "Operador"
        Me.rBOperador.UseVisualStyleBackColor = True
        '
        'rBEconomico
        '
        Me.rBEconomico.AutoSize = True
        Me.rBEconomico.Location = New System.Drawing.Point(6, 24)
        Me.rBEconomico.Name = "rBEconomico"
        Me.rBEconomico.Size = New System.Drawing.Size(175, 22)
        Me.rBEconomico.TabIndex = 1
        Me.rBEconomico.TabStop = True
        Me.rBEconomico.Text = "Número económico"
        Me.rBEconomico.UseVisualStyleBackColor = True
        '
        'tBFiltro
        '
        Me.tBFiltro.Location = New System.Drawing.Point(6, 54)
        Me.tBFiltro.Name = "tBFiltro"
        Me.tBFiltro.Size = New System.Drawing.Size(377, 24)
        Me.tBFiltro.TabIndex = 0
        '
        'tCUnidades
        '
        Me.tCUnidades.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tCUnidades.Controls.Add(Me.tPAltamira)
        Me.tCUnidades.Controls.Add(Me.tPManzanillo)
        Me.tCUnidades.Controls.Add(Me.tPVeracruz)
        Me.tCUnidades.Location = New System.Drawing.Point(12, 159)
        Me.tCUnidades.Name = "tCUnidades"
        Me.tCUnidades.SelectedIndex = 0
        Me.tCUnidades.Size = New System.Drawing.Size(607, 297)
        Me.tCUnidades.TabIndex = 6
        '
        'tPAltamira
        '
        Me.tPAltamira.Controls.Add(Me.dGVAltamira)
        Me.tPAltamira.Location = New System.Drawing.Point(4, 29)
        Me.tPAltamira.Name = "tPAltamira"
        Me.tPAltamira.Padding = New System.Windows.Forms.Padding(3)
        Me.tPAltamira.Size = New System.Drawing.Size(599, 264)
        Me.tPAltamira.TabIndex = 0
        Me.tPAltamira.Text = "Altamira"
        Me.tPAltamira.UseVisualStyleBackColor = True
        '
        'dGVAltamira
        '
        Me.dGVAltamira.AllowUserToAddRows = False
        Me.dGVAltamira.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dGVAltamira.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dGVAltamira.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.dGVAltamira.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dGVAltamira.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colId, Me.colEconomico, Me.colPlacas, Me.colOperador, Me.colCel, Me.colFechaVencExamenMedico, Me.colFechaVencLicencia})
        Me.dGVAltamira.Location = New System.Drawing.Point(6, 6)
        Me.dGVAltamira.Name = "dGVAltamira"
        Me.dGVAltamira.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dGVAltamira.Size = New System.Drawing.Size(587, 252)
        Me.dGVAltamira.TabIndex = 1
        '
        'colId
        '
        Me.colId.HeaderText = "Id"
        Me.colId.Name = "colId"
        Me.colId.Visible = False
        '
        'colEconomico
        '
        Me.colEconomico.HeaderText = "Económico"
        Me.colEconomico.Name = "colEconomico"
        '
        'colPlacas
        '
        Me.colPlacas.HeaderText = "Placas"
        Me.colPlacas.Name = "colPlacas"
        '
        'colOperador
        '
        Me.colOperador.HeaderText = "Operador"
        Me.colOperador.Name = "colOperador"
        '
        'colCel
        '
        Me.colCel.HeaderText = "Celular asignado"
        Me.colCel.Name = "colCel"
        '
        'colFechaVencExamenMedico
        '
        Me.colFechaVencExamenMedico.HeaderText = "Fecha de vencimiento E. M."
        Me.colFechaVencExamenMedico.Name = "colFechaVencExamenMedico"
        '
        'colFechaVencLicencia
        '
        Me.colFechaVencLicencia.HeaderText = "Fecha de vencimiento de licencia"
        Me.colFechaVencLicencia.Name = "colFechaVencLicencia"
        '
        'tPManzanillo
        '
        Me.tPManzanillo.Controls.Add(Me.dGVManzanillo)
        Me.tPManzanillo.Location = New System.Drawing.Point(4, 29)
        Me.tPManzanillo.Name = "tPManzanillo"
        Me.tPManzanillo.Padding = New System.Windows.Forms.Padding(3)
        Me.tPManzanillo.Size = New System.Drawing.Size(599, 264)
        Me.tPManzanillo.TabIndex = 1
        Me.tPManzanillo.Text = "Manzanillo"
        Me.tPManzanillo.UseVisualStyleBackColor = True
        '
        'dGVManzanillo
        '
        Me.dGVManzanillo.AllowUserToAddRows = False
        Me.dGVManzanillo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dGVManzanillo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dGVManzanillo.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.dGVManzanillo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dGVManzanillo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colIdMzo, Me.colEconomicoMzo, Me.colPlacasMzo, Me.colOperadorMzo, Me.colCelMzo, Me.colFechaVencExamenMedicoMzo, Me.colFechaVencLicenciaMzo})
        Me.dGVManzanillo.Location = New System.Drawing.Point(6, 6)
        Me.dGVManzanillo.Name = "dGVManzanillo"
        Me.dGVManzanillo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dGVManzanillo.Size = New System.Drawing.Size(587, 252)
        Me.dGVManzanillo.TabIndex = 2
        '
        'colIdMzo
        '
        Me.colIdMzo.HeaderText = "Id"
        Me.colIdMzo.Name = "colIdMzo"
        Me.colIdMzo.Visible = False
        '
        'colEconomicoMzo
        '
        Me.colEconomicoMzo.HeaderText = "Económico"
        Me.colEconomicoMzo.Name = "colEconomicoMzo"
        '
        'colPlacasMzo
        '
        Me.colPlacasMzo.HeaderText = "Placas"
        Me.colPlacasMzo.Name = "colPlacasMzo"
        '
        'colOperadorMzo
        '
        Me.colOperadorMzo.HeaderText = "Operador"
        Me.colOperadorMzo.Name = "colOperadorMzo"
        '
        'colCelMzo
        '
        Me.colCelMzo.HeaderText = "Celular asignado"
        Me.colCelMzo.Name = "colCelMzo"
        '
        'colFechaVencExamenMedicoMzo
        '
        Me.colFechaVencExamenMedicoMzo.HeaderText = "Fecha de vencimiento E. M."
        Me.colFechaVencExamenMedicoMzo.Name = "colFechaVencExamenMedicoMzo"
        '
        'colFechaVencLicenciaMzo
        '
        Me.colFechaVencLicenciaMzo.HeaderText = "Fecha de vencimiento de licencia"
        Me.colFechaVencLicenciaMzo.Name = "colFechaVencLicenciaMzo"
        '
        'tPVeracruz
        '
        Me.tPVeracruz.Controls.Add(Me.dGVVeracruz)
        Me.tPVeracruz.Location = New System.Drawing.Point(4, 29)
        Me.tPVeracruz.Name = "tPVeracruz"
        Me.tPVeracruz.Size = New System.Drawing.Size(599, 264)
        Me.tPVeracruz.TabIndex = 2
        Me.tPVeracruz.Text = "Veracruz"
        Me.tPVeracruz.UseVisualStyleBackColor = True
        '
        'dGVVeracruz
        '
        Me.dGVVeracruz.AllowUserToAddRows = False
        Me.dGVVeracruz.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dGVVeracruz.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dGVVeracruz.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.dGVVeracruz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dGVVeracruz.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colIdVer, Me.colEconomicoVer, Me.colPlacasVer, Me.colOperadorVer, Me.colCelVer, Me.colFechaVencExamenMedicoVer, Me.colFechaVencLicenciaVer})
        Me.dGVVeracruz.Location = New System.Drawing.Point(6, 6)
        Me.dGVVeracruz.Name = "dGVVeracruz"
        Me.dGVVeracruz.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dGVVeracruz.Size = New System.Drawing.Size(587, 252)
        Me.dGVVeracruz.TabIndex = 2
        '
        'colIdVer
        '
        Me.colIdVer.HeaderText = "Id"
        Me.colIdVer.Name = "colIdVer"
        Me.colIdVer.Visible = False
        '
        'colEconomicoVer
        '
        Me.colEconomicoVer.HeaderText = "Económico"
        Me.colEconomicoVer.Name = "colEconomicoVer"
        '
        'colPlacasVer
        '
        Me.colPlacasVer.HeaderText = "Placas"
        Me.colPlacasVer.Name = "colPlacasVer"
        '
        'colOperadorVer
        '
        Me.colOperadorVer.HeaderText = "Operador"
        Me.colOperadorVer.Name = "colOperadorVer"
        '
        'colCelVer
        '
        Me.colCelVer.HeaderText = "Celular asignado"
        Me.colCelVer.Name = "colCelVer"
        '
        'colFechaVencExamenMedicoVer
        '
        Me.colFechaVencExamenMedicoVer.HeaderText = "Fecha de vencimiento E. M."
        Me.colFechaVencExamenMedicoVer.Name = "colFechaVencExamenMedicoVer"
        '
        'colFechaVencLicenciaVer
        '
        Me.colFechaVencLicenciaVer.HeaderText = "Fecha de vencimiento de licencia"
        Me.colFechaVencLicenciaVer.Name = "colFechaVencLicenciaVer"
        '
        'CatalogoUnidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(631, 468)
        Me.Controls.Add(Me.tCUnidades)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tSMenu)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "CatalogoUnidades"
        Me.Text = "Catalogo de asignación de unidades / operadores"
        Me.tSMenu.ResumeLayout(False)
        Me.tSMenu.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tCUnidades.ResumeLayout(False)
        Me.tPAltamira.ResumeLayout(False)
        CType(Me.dGVAltamira, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tPManzanillo.ResumeLayout(False)
        CType(Me.dGVManzanillo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tPVeracruz.ResumeLayout(False)
        CType(Me.dGVVeracruz, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tSMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents tSBAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tSBEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tSSSeparador As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tSBSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tBFiltro As System.Windows.Forms.TextBox
    Friend WithEvents rBOperador As System.Windows.Forms.RadioButton
    Friend WithEvents rBEconomico As System.Windows.Forms.RadioButton
    Friend WithEvents tCUnidades As System.Windows.Forms.TabControl
    Friend WithEvents tPAltamira As System.Windows.Forms.TabPage
    Friend WithEvents tPManzanillo As System.Windows.Forms.TabPage
    Friend WithEvents dGVAltamira As System.Windows.Forms.DataGridView
    Friend WithEvents colId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEconomico As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPlacas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colOperador As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFechaVencExamenMedico As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFechaVencLicencia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dGVManzanillo As System.Windows.Forms.DataGridView
    Friend WithEvents tPVeracruz As System.Windows.Forms.TabPage
    Friend WithEvents dGVVeracruz As System.Windows.Forms.DataGridView
    Friend WithEvents colIdMzo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEconomicoMzo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPlacasMzo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colOperadorMzo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCelMzo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFechaVencExamenMedicoMzo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFechaVencLicenciaMzo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colIdVer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEconomicoVer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPlacasVer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colOperadorVer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCelVer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFechaVencExamenMedicoVer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFechaVencLicenciaVer As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
