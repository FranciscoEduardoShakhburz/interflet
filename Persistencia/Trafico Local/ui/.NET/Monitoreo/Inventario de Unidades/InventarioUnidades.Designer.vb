<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InventarioUnidades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InventarioUnidades))
        Me.gpoControles = New System.Windows.Forms.GroupBox
        Me.btoGuardar = New System.Windows.Forms.Button
        Me.btoSalir = New System.Windows.Forms.Button
        Me.btoExportar = New System.Windows.Forms.Button
        Me.btoGenerar = New System.Windows.Forms.Button
        Me.gridUnidades = New System.Windows.Forms.DataGridView
        Me.FECHA_LLEGADA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ECO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CEL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OPERADOR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CLIENTE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DESTINO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.STATUS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HORARIO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ETA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btoReporte = New System.Windows.Forms.Button
        Me.dteHasta = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.dteDesde = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ClavesCelularesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AbrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UnidadesSiniestradasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.gpoControles.SuspendLayout()
        CType(Me.gridUnidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpoControles
        '
        Me.gpoControles.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpoControles.BackColor = System.Drawing.Color.Transparent
        Me.gpoControles.Controls.Add(Me.btoGuardar)
        Me.gpoControles.Controls.Add(Me.btoSalir)
        Me.gpoControles.Controls.Add(Me.btoExportar)
        Me.gpoControles.Controls.Add(Me.btoGenerar)
        Me.gpoControles.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpoControles.Location = New System.Drawing.Point(444, 27)
        Me.gpoControles.Name = "gpoControles"
        Me.gpoControles.Size = New System.Drawing.Size(550, 77)
        Me.gpoControles.TabIndex = 0
        Me.gpoControles.TabStop = False
        Me.gpoControles.Text = "Inventario"
        '
        'btoGuardar
        '
        Me.btoGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btoGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btoGuardar.Image = CType(resources.GetObject("btoGuardar.Image"), System.Drawing.Image)
        Me.btoGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btoGuardar.Location = New System.Drawing.Point(132, 21)
        Me.btoGuardar.Name = "btoGuardar"
        Me.btoGuardar.Size = New System.Drawing.Size(120, 40)
        Me.btoGuardar.TabIndex = 7
        Me.btoGuardar.Text = "   Guardar"
        Me.btoGuardar.UseVisualStyleBackColor = True
        '
        'btoSalir
        '
        Me.btoSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btoSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btoSalir.Image = CType(resources.GetObject("btoSalir.Image"), System.Drawing.Image)
        Me.btoSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btoSalir.Location = New System.Drawing.Point(384, 21)
        Me.btoSalir.Name = "btoSalir"
        Me.btoSalir.Size = New System.Drawing.Size(120, 40)
        Me.btoSalir.TabIndex = 6
        Me.btoSalir.Text = "Salir"
        Me.btoSalir.UseVisualStyleBackColor = True
        '
        'btoExportar
        '
        Me.btoExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btoExportar.Image = CType(resources.GetObject("btoExportar.Image"), System.Drawing.Image)
        Me.btoExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btoExportar.Location = New System.Drawing.Point(258, 21)
        Me.btoExportar.Name = "btoExportar"
        Me.btoExportar.Size = New System.Drawing.Size(120, 40)
        Me.btoExportar.TabIndex = 5
        Me.btoExportar.Text = "   Exportar"
        Me.btoExportar.UseVisualStyleBackColor = True
        '
        'btoGenerar
        '
        Me.btoGenerar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btoGenerar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btoGenerar.Image = CType(resources.GetObject("btoGenerar.Image"), System.Drawing.Image)
        Me.btoGenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btoGenerar.Location = New System.Drawing.Point(6, 21)
        Me.btoGenerar.Name = "btoGenerar"
        Me.btoGenerar.Size = New System.Drawing.Size(120, 40)
        Me.btoGenerar.TabIndex = 4
        Me.btoGenerar.Text = "   Generar"
        Me.btoGenerar.UseVisualStyleBackColor = True
        '
        'gridUnidades
        '
        Me.gridUnidades.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridUnidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridUnidades.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.gridUnidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridUnidades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FECHA_LLEGADA, Me.ECO, Me.CEL, Me.OPERADOR, Me.CLIENTE, Me.DESTINO, Me.STATUS, Me.HORARIO, Me.ETA})
        Me.gridUnidades.Location = New System.Drawing.Point(12, 110)
        Me.gridUnidades.Name = "gridUnidades"
        Me.gridUnidades.Size = New System.Drawing.Size(982, 674)
        Me.gridUnidades.TabIndex = 1
        '
        'FECHA_LLEGADA
        '
        Me.FECHA_LLEGADA.HeaderText = "FECHA LLEGADA"
        Me.FECHA_LLEGADA.Name = "FECHA_LLEGADA"
        '
        'ECO
        '
        Me.ECO.HeaderText = "ECO"
        Me.ECO.Name = "ECO"
        '
        'CEL
        '
        Me.CEL.HeaderText = "CEL"
        Me.CEL.Name = "CEL"
        '
        'OPERADOR
        '
        Me.OPERADOR.HeaderText = "OPERADOR"
        Me.OPERADOR.Name = "OPERADOR"
        '
        'CLIENTE
        '
        Me.CLIENTE.HeaderText = "CLIENTE"
        Me.CLIENTE.Name = "CLIENTE"
        '
        'DESTINO
        '
        Me.DESTINO.HeaderText = "DESTINO"
        Me.DESTINO.Name = "DESTINO"
        '
        'STATUS
        '
        Me.STATUS.HeaderText = " STATUS"
        Me.STATUS.Name = "STATUS"
        '
        'HORARIO
        '
        Me.HORARIO.HeaderText = "HORARIO"
        Me.HORARIO.Name = "HORARIO"
        '
        'ETA
        '
        Me.ETA.HeaderText = "ETA"
        Me.ETA.Name = "ETA"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btoReporte)
        Me.GroupBox1.Controls.Add(Me.dteHasta)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dteDesde)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(426, 77)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Generar reporte"
        '
        'btoReporte
        '
        Me.btoReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btoReporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btoReporte.Image = CType(resources.GetObject("btoReporte.Image"), System.Drawing.Image)
        Me.btoReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btoReporte.Location = New System.Drawing.Point(275, 21)
        Me.btoReporte.Name = "btoReporte"
        Me.btoReporte.Size = New System.Drawing.Size(120, 40)
        Me.btoReporte.TabIndex = 8
        Me.btoReporte.Text = "   Reporte"
        Me.btoReporte.UseVisualStyleBackColor = True
        '
        'dteHasta
        '
        Me.dteHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteHasta.Location = New System.Drawing.Point(149, 41)
        Me.dteHasta.Name = "dteHasta"
        Me.dteHasta.Size = New System.Drawing.Size(94, 20)
        Me.dteHasta.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(146, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Hasta:"
        '
        'dteDesde
        '
        Me.dteDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteDesde.Location = New System.Drawing.Point(31, 41)
        Me.dteDesde.Name = "dteDesde"
        Me.dteDesde.Size = New System.Drawing.Size(94, 20)
        Me.dteDesde.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Desde:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClavesCelularesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1006, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ClavesCelularesToolStripMenuItem
        '
        Me.ClavesCelularesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrirToolStripMenuItem, Me.UnidadesSiniestradasToolStripMenuItem})
        Me.ClavesCelularesToolStripMenuItem.Name = "ClavesCelularesToolStripMenuItem"
        Me.ClavesCelularesToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.ClavesCelularesToolStripMenuItem.Text = "Catálogos"
        '
        'AbrirToolStripMenuItem
        '
        Me.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        Me.AbrirToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.AbrirToolStripMenuItem.Text = "Claves de celulares"
        '
        'UnidadesSiniestradasToolStripMenuItem
        '
        Me.UnidadesSiniestradasToolStripMenuItem.Name = "UnidadesSiniestradasToolStripMenuItem"
        Me.UnidadesSiniestradasToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.UnidadesSiniestradasToolStripMenuItem.Text = "Unidades siniestradas"
        '
        'InventarioUnidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.CancelButton = Me.btoSalir
        Me.ClientSize = New System.Drawing.Size(1006, 796)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gridUnidades)
        Me.Controls.Add(Me.gpoControles)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "InventarioUnidades"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Inventario de unidades | Monitoreo"
        Me.gpoControles.ResumeLayout(False)
        CType(Me.gridUnidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gpoControles As System.Windows.Forms.GroupBox
    Friend WithEvents gridUnidades As System.Windows.Forms.DataGridView
    Friend WithEvents btoGenerar As System.Windows.Forms.Button
    Friend WithEvents btoExportar As System.Windows.Forms.Button
    Friend WithEvents btoSalir As System.Windows.Forms.Button
    Friend WithEvents btoGuardar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dteHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dteDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btoReporte As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ClavesCelularesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbrirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FECHA_LLEGADA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ECO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CEL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OPERADOR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIENTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESTINO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents STATUS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HORARIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ETA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnidadesSiniestradasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
