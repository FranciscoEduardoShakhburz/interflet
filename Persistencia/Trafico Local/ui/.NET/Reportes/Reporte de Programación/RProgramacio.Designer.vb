<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RProgramacio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RProgramacio))
        Me.bto_subir = New System.Windows.Forms.Button
        Me.bto_archivo = New System.Windows.Forms.Button
        Me.txt_archivo = New System.Windows.Forms.TextBox
        Me.bto_salir = New System.Windows.Forms.Button
        Me.cmb_fecini = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmb_fin = New System.Windows.Forms.DateTimePicker
        Me.Button1 = New System.Windows.Forms.Button
        Me.bto_guardar = New System.Windows.Forms.Button
        Me.ch_todos = New System.Windows.Forms.CheckBox
        Me.grid2 = New System.Windows.Forms.DataGridView
        Me.conTxtGridLocales = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.menuCambiarOp = New System.Windows.Forms.ToolStripMenuItem
        Me.rcontenedor = New System.Windows.Forms.RadioButton
        Me.rreferencia = New System.Windows.Forms.RadioButton
        Me.txt_param = New System.Windows.Forms.TextBox
        Me.bto_buscar = New System.Windows.Forms.Button
        Me.r_impo = New System.Windows.Forms.RadioButton
        Me.r_expo = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btoReporte = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.gridImpo = New System.Windows.Forms.DataGridView
        Me.conTxtGridForaneos = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmiCambOperador = New System.Windows.Forms.ToolStripMenuItem
        Me.AñadirFechaDeModulaciònToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.IngresarFolioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.gridExpo = New System.Windows.Forms.DataGridView
        Me.rBtnBucarImpo = New System.Windows.Forms.RadioButton
        Me.rBtnBuscarExpo = New System.Windows.Forms.RadioButton
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.btnModificar = New System.Windows.Forms.Button
        Me.btnAgregarCarga = New System.Windows.Forms.Button
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ProgramaDeCargasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GenerarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.btnBuscador = New System.Windows.Forms.Button
        Me.btnGenerarResumen = New System.Windows.Forms.Button
        CType(Me.grid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.conTxtGridLocales.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.gridImpo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.conTxtGridForaneos.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.gridExpo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bto_subir
        '
        Me.bto_subir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bto_subir.Image = CType(resources.GetObject("bto_subir.Image"), System.Drawing.Image)
        Me.bto_subir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bto_subir.Location = New System.Drawing.Point(309, 18)
        Me.bto_subir.Name = "bto_subir"
        Me.bto_subir.Size = New System.Drawing.Size(120, 40)
        Me.bto_subir.TabIndex = 0
        Me.bto_subir.Text = "Subir"
        Me.bto_subir.UseVisualStyleBackColor = True
        '
        'bto_archivo
        '
        Me.bto_archivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bto_archivo.Image = CType(resources.GetObject("bto_archivo.Image"), System.Drawing.Image)
        Me.bto_archivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bto_archivo.Location = New System.Drawing.Point(183, 18)
        Me.bto_archivo.Name = "bto_archivo"
        Me.bto_archivo.Size = New System.Drawing.Size(120, 40)
        Me.bto_archivo.TabIndex = 1
        Me.bto_archivo.Text = "     Seleccionar"
        Me.bto_archivo.UseVisualStyleBackColor = True
        '
        'txt_archivo
        '
        Me.txt_archivo.BackColor = System.Drawing.Color.White
        Me.txt_archivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_archivo.Location = New System.Drawing.Point(6, 42)
        Me.txt_archivo.Name = "txt_archivo"
        Me.txt_archivo.ReadOnly = True
        Me.txt_archivo.Size = New System.Drawing.Size(171, 20)
        Me.txt_archivo.TabIndex = 2
        '
        'bto_salir
        '
        Me.bto_salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bto_salir.Image = CType(resources.GetObject("bto_salir.Image"), System.Drawing.Image)
        Me.bto_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bto_salir.Location = New System.Drawing.Point(667, 18)
        Me.bto_salir.Name = "bto_salir"
        Me.bto_salir.Size = New System.Drawing.Size(120, 40)
        Me.bto_salir.TabIndex = 3
        Me.bto_salir.Text = "Salir"
        Me.bto_salir.UseVisualStyleBackColor = True
        '
        'cmb_fecini
        '
        Me.cmb_fecini.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmb_fecini.Location = New System.Drawing.Point(59, 15)
        Me.cmb_fecini.Name = "cmb_fecini"
        Me.cmb_fecini.Size = New System.Drawing.Size(95, 20)
        Me.cmb_fecini.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Desde:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Hasta:"
        '
        'cmb_fin
        '
        Me.cmb_fin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmb_fin.Location = New System.Drawing.Point(59, 41)
        Me.cmb_fin.Name = "cmb_fin"
        Me.cmb_fin.Size = New System.Drawing.Size(95, 20)
        Me.cmb_fin.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(289, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 40)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "   Consultar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'bto_guardar
        '
        Me.bto_guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bto_guardar.Image = CType(resources.GetObject("bto_guardar.Image"), System.Drawing.Image)
        Me.bto_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bto_guardar.Location = New System.Drawing.Point(541, 18)
        Me.bto_guardar.Name = "bto_guardar"
        Me.bto_guardar.Size = New System.Drawing.Size(120, 40)
        Me.bto_guardar.TabIndex = 10
        Me.bto_guardar.Text = "   Guardar"
        Me.bto_guardar.UseVisualStyleBackColor = True
        '
        'ch_todos
        '
        Me.ch_todos.AutoSize = True
        Me.ch_todos.BackColor = System.Drawing.Color.Transparent
        Me.ch_todos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ch_todos.Location = New System.Drawing.Point(160, 31)
        Me.ch_todos.Name = "ch_todos"
        Me.ch_todos.Size = New System.Drawing.Size(123, 17)
        Me.ch_todos.TabIndex = 11
        Me.ch_todos.Text = "Sin Fecha Planta"
        Me.ch_todos.UseVisualStyleBackColor = False
        '
        'grid2
        '
        Me.grid2.AllowUserToDeleteRows = False
        Me.grid2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid2.ContextMenuStrip = Me.conTxtGridLocales
        Me.grid2.Location = New System.Drawing.Point(6, 19)
        Me.grid2.Name = "grid2"
        Me.grid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid2.Size = New System.Drawing.Size(1224, 272)
        Me.grid2.TabIndex = 12
        '
        'conTxtGridLocales
        '
        Me.conTxtGridLocales.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuCambiarOp})
        Me.conTxtGridLocales.Name = "conTxtGridLocales"
        Me.conTxtGridLocales.Size = New System.Drawing.Size(188, 26)
        '
        'menuCambiarOp
        '
        Me.menuCambiarOp.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuCambiarOp.Image = CType(resources.GetObject("menuCambiarOp.Image"), System.Drawing.Image)
        Me.menuCambiarOp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.menuCambiarOp.Name = "menuCambiarOp"
        Me.menuCambiarOp.Size = New System.Drawing.Size(187, 22)
        Me.menuCambiarOp.Text = "Cambiar operador"
        '
        'rcontenedor
        '
        Me.rcontenedor.AutoSize = True
        Me.rcontenedor.BackColor = System.Drawing.Color.Transparent
        Me.rcontenedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rcontenedor.Location = New System.Drawing.Point(6, 19)
        Me.rcontenedor.Name = "rcontenedor"
        Me.rcontenedor.Size = New System.Drawing.Size(90, 17)
        Me.rcontenedor.TabIndex = 14
        Me.rcontenedor.TabStop = True
        Me.rcontenedor.Text = "Contenedor"
        Me.rcontenedor.UseVisualStyleBackColor = False
        '
        'rreferencia
        '
        Me.rreferencia.AutoSize = True
        Me.rreferencia.BackColor = System.Drawing.Color.Transparent
        Me.rreferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rreferencia.Location = New System.Drawing.Point(102, 19)
        Me.rreferencia.Name = "rreferencia"
        Me.rreferencia.Size = New System.Drawing.Size(87, 17)
        Me.rreferencia.TabIndex = 15
        Me.rreferencia.TabStop = True
        Me.rreferencia.Text = "Referencia"
        Me.rreferencia.UseVisualStyleBackColor = False
        '
        'txt_param
        '
        Me.txt_param.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_param.Location = New System.Drawing.Point(343, 383)
        Me.txt_param.Name = "txt_param"
        Me.txt_param.Size = New System.Drawing.Size(127, 20)
        Me.txt_param.TabIndex = 16
        '
        'bto_buscar
        '
        Me.bto_buscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bto_buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bto_buscar.Image = CType(resources.GetObject("bto_buscar.Image"), System.Drawing.Image)
        Me.bto_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bto_buscar.Location = New System.Drawing.Point(476, 372)
        Me.bto_buscar.Name = "bto_buscar"
        Me.bto_buscar.Size = New System.Drawing.Size(120, 40)
        Me.bto_buscar.TabIndex = 17
        Me.bto_buscar.Text = "Buscar"
        Me.bto_buscar.UseVisualStyleBackColor = True
        '
        'r_impo
        '
        Me.r_impo.AutoSize = True
        Me.r_impo.BackColor = System.Drawing.Color.Transparent
        Me.r_impo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r_impo.Location = New System.Drawing.Point(70, 19)
        Me.r_impo.Name = "r_impo"
        Me.r_impo.Size = New System.Drawing.Size(56, 17)
        Me.r_impo.TabIndex = 18
        Me.r_impo.TabStop = True
        Me.r_impo.Text = "IMPO"
        Me.r_impo.UseVisualStyleBackColor = False
        '
        'r_expo
        '
        Me.r_expo.AutoSize = True
        Me.r_expo.BackColor = System.Drawing.Color.Transparent
        Me.r_expo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r_expo.Location = New System.Drawing.Point(6, 19)
        Me.r_expo.Name = "r_expo"
        Me.r_expo.Size = New System.Drawing.Size(58, 17)
        Me.r_expo.TabIndex = 19
        Me.r_expo.TabStop = True
        Me.r_expo.Text = "EXPO"
        Me.r_expo.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.grid2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 424)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1236, 297)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Locales"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.txt_archivo)
        Me.GroupBox2.Controls.Add(Me.r_expo)
        Me.GroupBox2.Controls.Add(Me.r_impo)
        Me.GroupBox2.Controls.Add(Me.bto_archivo)
        Me.GroupBox2.Controls.Add(Me.bto_subir)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(435, 78)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cargar archivo"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.btoReporte)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.cmb_fecini)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.cmb_fin)
        Me.GroupBox3.Controls.Add(Me.ch_todos)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.bto_guardar)
        Me.GroupBox3.Controls.Add(Me.bto_salir)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(453, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(795, 78)
        Me.GroupBox3.TabIndex = 22
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Opciones"
        '
        'btoReporte
        '
        Me.btoReporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btoReporte.Image = CType(resources.GetObject("btoReporte.Image"), System.Drawing.Image)
        Me.btoReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btoReporte.Location = New System.Drawing.Point(415, 18)
        Me.btoReporte.Name = "btoReporte"
        Me.btoReporte.Size = New System.Drawing.Size(120, 40)
        Me.btoReporte.TabIndex = 12
        Me.btoReporte.Text = "   Reporte"
        Me.btoReporte.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 96)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1236, 263)
        Me.TabControl1.TabIndex = 23
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.gridImpo)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1228, 237)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "IMPO"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'gridImpo
        '
        Me.gridImpo.AllowUserToAddRows = False
        Me.gridImpo.AllowUserToDeleteRows = False
        Me.gridImpo.AllowUserToOrderColumns = True
        Me.gridImpo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridImpo.ContextMenuStrip = Me.conTxtGridForaneos
        Me.gridImpo.Location = New System.Drawing.Point(8, 6)
        Me.gridImpo.Name = "gridImpo"
        Me.gridImpo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridImpo.Size = New System.Drawing.Size(1214, 225)
        Me.gridImpo.TabIndex = 5
        '
        'conTxtGridForaneos
        '
        Me.conTxtGridForaneos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiCambOperador, Me.AñadirFechaDeModulaciònToolStripMenuItem, Me.EliminarToolStripMenuItem, Me.IngresarFolioToolStripMenuItem})
        Me.conTxtGridForaneos.Name = "conTxtGridForaneos"
        Me.conTxtGridForaneos.Size = New System.Drawing.Size(242, 92)
        '
        'tsmiCambOperador
        '
        Me.tsmiCambOperador.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsmiCambOperador.Image = CType(resources.GetObject("tsmiCambOperador.Image"), System.Drawing.Image)
        Me.tsmiCambOperador.Name = "tsmiCambOperador"
        Me.tsmiCambOperador.Size = New System.Drawing.Size(241, 22)
        Me.tsmiCambOperador.Text = "Cambiar operador"
        '
        'AñadirFechaDeModulaciònToolStripMenuItem
        '
        Me.AñadirFechaDeModulaciònToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AñadirFechaDeModulaciònToolStripMenuItem.Image = CType(resources.GetObject("AñadirFechaDeModulaciònToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AñadirFechaDeModulaciònToolStripMenuItem.Name = "AñadirFechaDeModulaciònToolStripMenuItem"
        Me.AñadirFechaDeModulaciònToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.AñadirFechaDeModulaciònToolStripMenuItem.Text = "Añadir fecha de modulación"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EliminarToolStripMenuItem.Image = CType(resources.GetObject("EliminarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'IngresarFolioToolStripMenuItem
        '
        Me.IngresarFolioToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IngresarFolioToolStripMenuItem.Image = CType(resources.GetObject("IngresarFolioToolStripMenuItem.Image"), System.Drawing.Image)
        Me.IngresarFolioToolStripMenuItem.Name = "IngresarFolioToolStripMenuItem"
        Me.IngresarFolioToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.IngresarFolioToolStripMenuItem.Text = "Ingresar folio"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.gridExpo)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1228, 237)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "EXPO"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'gridExpo
        '
        Me.gridExpo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridExpo.Location = New System.Drawing.Point(6, 6)
        Me.gridExpo.Name = "gridExpo"
        Me.gridExpo.Size = New System.Drawing.Size(1216, 225)
        Me.gridExpo.TabIndex = 0
        '
        'rBtnBucarImpo
        '
        Me.rBtnBucarImpo.AutoSize = True
        Me.rBtnBucarImpo.BackColor = System.Drawing.Color.Transparent
        Me.rBtnBucarImpo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rBtnBucarImpo.Location = New System.Drawing.Point(6, 19)
        Me.rBtnBucarImpo.Name = "rBtnBucarImpo"
        Me.rBtnBucarImpo.Size = New System.Drawing.Size(56, 17)
        Me.rBtnBucarImpo.TabIndex = 24
        Me.rBtnBucarImpo.TabStop = True
        Me.rBtnBucarImpo.Text = "IMPO"
        Me.rBtnBucarImpo.UseVisualStyleBackColor = False
        '
        'rBtnBuscarExpo
        '
        Me.rBtnBuscarExpo.AutoSize = True
        Me.rBtnBuscarExpo.BackColor = System.Drawing.Color.Transparent
        Me.rBtnBuscarExpo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rBtnBuscarExpo.Location = New System.Drawing.Point(68, 19)
        Me.rBtnBuscarExpo.Name = "rBtnBuscarExpo"
        Me.rBtnBuscarExpo.Size = New System.Drawing.Size(58, 17)
        Me.rBtnBuscarExpo.TabIndex = 25
        Me.rBtnBuscarExpo.TabStop = True
        Me.rBtnBuscarExpo.Text = "EXPO"
        Me.rBtnBuscarExpo.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.rBtnBucarImpo)
        Me.GroupBox4.Controls.Add(Me.rBtnBuscarExpo)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 365)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(126, 51)
        Me.GroupBox4.TabIndex = 27
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Buscar:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.rcontenedor)
        Me.GroupBox5.Controls.Add(Me.rreferencia)
        Me.GroupBox5.Location = New System.Drawing.Point(144, 365)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(193, 51)
        Me.GroupBox5.TabIndex = 28
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Por:"
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(602, 372)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(120, 40)
        Me.btnModificar.TabIndex = 29
        Me.btnModificar.Text = "     Modificar   visitas"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnAgregarCarga
        '
        Me.btnAgregarCarga.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarCarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarCarga.Image = CType(resources.GetObject("btnAgregarCarga.Image"), System.Drawing.Image)
        Me.btnAgregarCarga.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregarCarga.Location = New System.Drawing.Point(854, 372)
        Me.btnAgregarCarga.Name = "btnAgregarCarga"
        Me.btnAgregarCarga.Size = New System.Drawing.Size(120, 40)
        Me.btnAgregarCarga.TabIndex = 30
        Me.btnAgregarCarga.Text = "       Agregar      carga"
        Me.btnAgregarCarga.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramaDeCargasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1254, 24)
        Me.MenuStrip1.TabIndex = 31
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProgramaDeCargasToolStripMenuItem
        '
        Me.ProgramaDeCargasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerarToolStripMenuItem})
        Me.ProgramaDeCargasToolStripMenuItem.Name = "ProgramaDeCargasToolStripMenuItem"
        Me.ProgramaDeCargasToolStripMenuItem.Size = New System.Drawing.Size(117, 20)
        Me.ProgramaDeCargasToolStripMenuItem.Text = "Programa de Cargas"
        '
        'GenerarToolStripMenuItem
        '
        Me.GenerarToolStripMenuItem.Name = "GenerarToolStripMenuItem"
        Me.GenerarToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.GenerarToolStripMenuItem.Text = "Generar"
        '
        'btnBuscador
        '
        Me.btnBuscador.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnBuscador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscador.Image = CType(resources.GetObject("btnBuscador.Image"), System.Drawing.Image)
        Me.btnBuscador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscador.Location = New System.Drawing.Point(728, 372)
        Me.btnBuscador.Name = "btnBuscador"
        Me.btnBuscador.Size = New System.Drawing.Size(120, 40)
        Me.btnBuscador.TabIndex = 32
        Me.btnBuscador.Text = "       Buscar         cargas"
        Me.btnBuscador.UseVisualStyleBackColor = True
        '
        'btnGenerarResumen
        '
        Me.btnGenerarResumen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnGenerarResumen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerarResumen.Image = CType(resources.GetObject("btnGenerarResumen.Image"), System.Drawing.Image)
        Me.btnGenerarResumen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenerarResumen.Location = New System.Drawing.Point(980, 372)
        Me.btnGenerarResumen.Name = "btnGenerarResumen"
        Me.btnGenerarResumen.Size = New System.Drawing.Size(120, 40)
        Me.btnGenerarResumen.TabIndex = 33
        Me.btnGenerarResumen.Text = "       Generar          resumen"
        Me.btnGenerarResumen.UseVisualStyleBackColor = True
        '
        'RProgramacio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1254, 733)
        Me.Controls.Add(Me.btnGenerarResumen)
        Me.Controls.Add(Me.btnBuscador)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnAgregarCarga)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.bto_buscar)
        Me.Controls.Add(Me.txt_param)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1262, 762)
        Me.Name = "RProgramacio"
        Me.Text = "Reporte Programación | Logística"
        CType(Me.grid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.conTxtGridLocales.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.gridImpo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.conTxtGridForaneos.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.gridExpo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bto_subir As System.Windows.Forms.Button
    Friend WithEvents bto_archivo As System.Windows.Forms.Button
    Friend WithEvents txt_archivo As System.Windows.Forms.TextBox
    Friend WithEvents bto_salir As System.Windows.Forms.Button
    Friend WithEvents cmb_fecini As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmb_fin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents bto_guardar As System.Windows.Forms.Button
    Friend WithEvents ch_todos As System.Windows.Forms.CheckBox
    Friend WithEvents grid2 As System.Windows.Forms.DataGridView
    Friend WithEvents rcontenedor As System.Windows.Forms.RadioButton
    Friend WithEvents rreferencia As System.Windows.Forms.RadioButton
    Friend WithEvents txt_param As System.Windows.Forms.TextBox
    Friend WithEvents bto_buscar As System.Windows.Forms.Button
    Friend WithEvents r_impo As System.Windows.Forms.RadioButton
    Friend WithEvents r_expo As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btoReporte As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents gridImpo As System.Windows.Forms.DataGridView
    Friend WithEvents gridExpo As System.Windows.Forms.DataGridView
    Friend WithEvents rBtnBucarImpo As System.Windows.Forms.RadioButton
    Friend WithEvents rBtnBuscarExpo As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents conTxtGridLocales As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents menuCambiarOp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents conTxtGridForaneos As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmiCambOperador As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AñadirFechaDeModulaciònToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnAgregarCarga As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ProgramaDeCargasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnBuscador As System.Windows.Forms.Button
    Friend WithEvents IngresarFolioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnGenerarResumen As System.Windows.Forms.Button
End Class
