<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CatValeGasolina
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CatValeGasolina))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnExportar = New System.Windows.Forms.Button
        Me.btnEliminar = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnAgregar = New System.Windows.Forms.Button
        Me.gridVales = New System.Windows.Forms.DataGridView
        Me.unidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.operador = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.vale = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.combustible = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.kilometraje = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.CatálogosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UnidadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LitrosConsumidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dteHasta = New System.Windows.Forms.DateTimePicker
        Me.dteDesde = New System.Windows.Forms.DateTimePicker
        Me.txtBusqueda = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.gridVales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnExportar)
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Controls.Add(Me.btnSalir)
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(497, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(510, 66)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones"
        '
        'btnExportar
        '
        Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
        Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportar.Location = New System.Drawing.Point(258, 19)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(120, 40)
        Me.btnExportar.TabIndex = 3
        Me.btnExportar.Text = "   Exportar"
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(132, 19)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(120, 40)
        Me.btnEliminar.TabIndex = 2
        Me.btnEliminar.Text = "      Eliminar vale"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(384, 19)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(120, 40)
        Me.btnSalir.TabIndex = 1
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(6, 19)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(120, 40)
        Me.btnAgregar.TabIndex = 0
        Me.btnAgregar.Text = "      Agregar vale"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'gridVales
        '
        Me.gridVales.AllowUserToAddRows = False
        Me.gridVales.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridVales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridVales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridVales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.unidad, Me.operador, Me.fecha, Me.vale, Me.cantidad, Me.combustible, Me.kilometraje})
        Me.gridVales.Location = New System.Drawing.Point(12, 99)
        Me.gridVales.Name = "gridVales"
        Me.gridVales.ReadOnly = True
        Me.gridVales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridVales.Size = New System.Drawing.Size(995, 269)
        Me.gridVales.TabIndex = 1
        '
        'unidad
        '
        Me.unidad.HeaderText = "Unidad"
        Me.unidad.Name = "unidad"
        Me.unidad.ReadOnly = True
        '
        'operador
        '
        Me.operador.HeaderText = "Operador"
        Me.operador.Name = "operador"
        Me.operador.ReadOnly = True
        '
        'fecha
        '
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        '
        'vale
        '
        Me.vale.HeaderText = "No. De vale"
        Me.vale.Name = "vale"
        Me.vale.ReadOnly = True
        '
        'cantidad
        '
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        '
        'combustible
        '
        Me.combustible.HeaderText = "Combustible"
        Me.combustible.Name = "combustible"
        Me.combustible.ReadOnly = True
        '
        'kilometraje
        '
        Me.kilometraje.HeaderText = "Kilometraje"
        Me.kilometraje.Name = "kilometraje"
        Me.kilometraje.ReadOnly = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CatálogosToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1019, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CatálogosToolStripMenuItem
        '
        Me.CatálogosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UnidadesToolStripMenuItem})
        Me.CatálogosToolStripMenuItem.Name = "CatálogosToolStripMenuItem"
        Me.CatálogosToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.CatálogosToolStripMenuItem.Text = "Catálogos"
        '
        'UnidadesToolStripMenuItem
        '
        Me.UnidadesToolStripMenuItem.Name = "UnidadesToolStripMenuItem"
        Me.UnidadesToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.UnidadesToolStripMenuItem.Text = "Unidades"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LitrosConsumidosToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'LitrosConsumidosToolStripMenuItem
        '
        Me.LitrosConsumidosToolStripMenuItem.Image = CType(resources.GetObject("LitrosConsumidosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LitrosConsumidosToolStripMenuItem.Name = "LitrosConsumidosToolStripMenuItem"
        Me.LitrosConsumidosToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.LitrosConsumidosToolStripMenuItem.Text = "Litros consumidos"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btnBuscar)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.dteHasta)
        Me.GroupBox2.Controls.Add(Me.dteDesde)
        Me.GroupBox2.Controls.Add(Me.txtBusqueda)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(479, 66)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Buscar por:"
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(350, 19)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(120, 40)
        Me.btnBuscar.TabIndex = 6
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(210, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Fechas:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(227, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "a"
        '
        'dteHasta
        '
        Me.dteHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteHasta.Location = New System.Drawing.Point(247, 32)
        Me.dteHasta.Name = "dteHasta"
        Me.dteHasta.Size = New System.Drawing.Size(97, 20)
        Me.dteHasta.TabIndex = 3
        '
        'dteDesde
        '
        Me.dteDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteDesde.Location = New System.Drawing.Point(124, 32)
        Me.dteDesde.Name = "dteDesde"
        Me.dteDesde.Size = New System.Drawing.Size(97, 20)
        Me.dteDesde.TabIndex = 2
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Location = New System.Drawing.Point(6, 32)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(100, 20)
        Me.txtBusqueda.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No. Vale:"
        '
        'CatValeGasolina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1019, 380)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gridVales)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "CatValeGasolina"
        Me.Text = "Vales de gasolina"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.gridVales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents gridVales As System.Windows.Forms.DataGridView
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CatálogosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UnidadesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dteHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dteDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents unidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents operador As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vale As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents combustible As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kilometraje As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnExportar As System.Windows.Forms.Button
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LitrosConsumidosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
