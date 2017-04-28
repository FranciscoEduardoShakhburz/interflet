<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteEstatusContenedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReporteEstatusContenedores))
        Me.gridContVacios = New System.Windows.Forms.DataGridView
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmiEliminar = New System.Windows.Forms.ToolStripMenuItem
        Me.DeshacerEliminaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CambiarAContSalienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MoverAContLlenosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnActualizar = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.btnExportar = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnGenerar = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnReporte = New System.Windows.Forms.Button
        Me.gridContLlenos = New System.Windows.Forms.DataGridView
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EliminarContenedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeshacerEliminaciónToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.MoverAContQueSalenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MoverAContVacíosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.btnRepSalidas = New System.Windows.Forms.Button
        Me.btnAgregarTramSencillo = New System.Windows.Forms.Button
        Me.btnArribaGridVac = New System.Windows.Forms.Button
        Me.btnAbajoGridVac = New System.Windows.Forms.Button
        Me.btnAbajoGridLle = New System.Windows.Forms.Button
        Me.btnArribaGridLle = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtBusqueda = New System.Windows.Forms.TextBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.gridSalientesVacios = New System.Windows.Forms.DataGridView
        Me.ContextMenuStrip3 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MoverAContVacíosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EliminarSalVacToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TabControl2 = New System.Windows.Forms.TabControl
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.gridSalientesLlenos = New System.Windows.Forms.DataGridView
        Me.ContextMenuStrip4 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MoverAContLlenosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EliminarSalLlenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.btnOrdenarGridVacios = New System.Windows.Forms.Button
        Me.btnOrdenarGridLlenos = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.etqContVaciosDAH = New System.Windows.Forms.Label
        Me.etqContVacDemorados = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.etqConVacSinDemora = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.etqConLlenosFecCierre = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.etqConLlenosDAH = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.etqContVacTot = New System.Windows.Forms.Label
        CType(Me.gridContVacios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.gridContLlenos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.gridSalientesVacios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip3.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.gridSalientesLlenos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip4.SuspendLayout()
        Me.SuspendLayout()
        '
        'gridContVacios
        '
        Me.gridContVacios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridContVacios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridContVacios.ContextMenuStrip = Me.ContextMenuStrip1
        Me.gridContVacios.Location = New System.Drawing.Point(6, 6)
        Me.gridContVacios.Name = "gridContVacios"
        Me.gridContVacios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridContVacios.Size = New System.Drawing.Size(1081, 314)
        Me.gridContVacios.TabIndex = 2
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiEliminar, Me.DeshacerEliminaciónToolStripMenuItem, Me.CambiarAContSalienteToolStripMenuItem, Me.MoverAContLlenosToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(198, 92)
        '
        'tsmiEliminar
        '
        Me.tsmiEliminar.Image = CType(resources.GetObject("tsmiEliminar.Image"), System.Drawing.Image)
        Me.tsmiEliminar.Name = "tsmiEliminar"
        Me.tsmiEliminar.Size = New System.Drawing.Size(197, 22)
        Me.tsmiEliminar.Text = "Eliminar contenedor"
        '
        'DeshacerEliminaciónToolStripMenuItem
        '
        Me.DeshacerEliminaciónToolStripMenuItem.Image = CType(resources.GetObject("DeshacerEliminaciónToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DeshacerEliminaciónToolStripMenuItem.Name = "DeshacerEliminaciónToolStripMenuItem"
        Me.DeshacerEliminaciónToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.DeshacerEliminaciónToolStripMenuItem.Text = "Deshacer eliminación"
        '
        'CambiarAContSalienteToolStripMenuItem
        '
        Me.CambiarAContSalienteToolStripMenuItem.Image = CType(resources.GetObject("CambiarAContSalienteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CambiarAContSalienteToolStripMenuItem.Name = "CambiarAContSalienteToolStripMenuItem"
        Me.CambiarAContSalienteToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.CambiarAContSalienteToolStripMenuItem.Text = "Mover a cont. salientes"
        '
        'MoverAContLlenosToolStripMenuItem1
        '
        Me.MoverAContLlenosToolStripMenuItem1.Image = CType(resources.GetObject("MoverAContLlenosToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.MoverAContLlenosToolStripMenuItem1.Name = "MoverAContLlenosToolStripMenuItem1"
        Me.MoverAContLlenosToolStripMenuItem1.Size = New System.Drawing.Size(197, 22)
        Me.MoverAContLlenosToolStripMenuItem1.Text = "Mover a cont. Llenos"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnActualizar)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Controls.Add(Me.btnExportar)
        Me.GroupBox1.Controls.Add(Me.btnSalir)
        Me.GroupBox1.Controls.Add(Me.btnGenerar)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(164, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(721, 68)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones del reporte"
        '
        'btnActualizar
        '
        Me.btnActualizar.Image = CType(resources.GetObject("btnActualizar.Image"), System.Drawing.Image)
        Me.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnActualizar.Location = New System.Drawing.Point(258, 19)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(120, 40)
        Me.btnActualizar.TabIndex = 8
        Me.btnActualizar.Text = "   Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(132, 19)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(120, 40)
        Me.btnGuardar.TabIndex = 7
        Me.btnGuardar.Text = "   Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnExportar
        '
        Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
        Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportar.Location = New System.Drawing.Point(384, 19)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(120, 40)
        Me.btnExportar.TabIndex = 6
        Me.btnExportar.Text = "   Exportar"
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(510, 19)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(120, 40)
        Me.btnSalir.TabIndex = 1
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnGenerar
        '
        Me.btnGenerar.Image = CType(resources.GetObject("btnGenerar.Image"), System.Drawing.Image)
        Me.btnGenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenerar.Location = New System.Drawing.Point(6, 19)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(120, 40)
        Me.btnGenerar.TabIndex = 0
        Me.btnGenerar.Text = "   Consultar reporte"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btnReporte)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(146, 68)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Generar reportes"
        '
        'btnReporte
        '
        Me.btnReporte.Image = CType(resources.GetObject("btnReporte.Image"), System.Drawing.Image)
        Me.btnReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReporte.Location = New System.Drawing.Point(10, 19)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(120, 40)
        Me.btnReporte.TabIndex = 12
        Me.btnReporte.Text = "   Elegir..."
        Me.btnReporte.UseVisualStyleBackColor = True
        '
        'gridContLlenos
        '
        Me.gridContLlenos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridContLlenos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridContLlenos.ContextMenuStrip = Me.ContextMenuStrip2
        Me.gridContLlenos.Location = New System.Drawing.Point(6, 6)
        Me.gridContLlenos.Name = "gridContLlenos"
        Me.gridContLlenos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridContLlenos.Size = New System.Drawing.Size(1081, 269)
        Me.gridContLlenos.TabIndex = 3
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EliminarContenedoresToolStripMenuItem, Me.DeshacerEliminaciónToolStripMenuItem1, Me.MoverAContQueSalenToolStripMenuItem, Me.MoverAContVacíosToolStripMenuItem1})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(204, 92)
        '
        'EliminarContenedoresToolStripMenuItem
        '
        Me.EliminarContenedoresToolStripMenuItem.Image = CType(resources.GetObject("EliminarContenedoresToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EliminarContenedoresToolStripMenuItem.Name = "EliminarContenedoresToolStripMenuItem"
        Me.EliminarContenedoresToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.EliminarContenedoresToolStripMenuItem.Text = "Eliminar contenedores"
        '
        'DeshacerEliminaciónToolStripMenuItem1
        '
        Me.DeshacerEliminaciónToolStripMenuItem1.Image = CType(resources.GetObject("DeshacerEliminaciónToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.DeshacerEliminaciónToolStripMenuItem1.Name = "DeshacerEliminaciónToolStripMenuItem1"
        Me.DeshacerEliminaciónToolStripMenuItem1.Size = New System.Drawing.Size(203, 22)
        Me.DeshacerEliminaciónToolStripMenuItem1.Text = "Deshacer eliminación"
        '
        'MoverAContQueSalenToolStripMenuItem
        '
        Me.MoverAContQueSalenToolStripMenuItem.Image = CType(resources.GetObject("MoverAContQueSalenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MoverAContQueSalenToolStripMenuItem.Name = "MoverAContQueSalenToolStripMenuItem"
        Me.MoverAContQueSalenToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.MoverAContQueSalenToolStripMenuItem.Text = "Mover a cont. Que salen"
        '
        'MoverAContVacíosToolStripMenuItem1
        '
        Me.MoverAContVacíosToolStripMenuItem1.Image = CType(resources.GetObject("MoverAContVacíosToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.MoverAContVacíosToolStripMenuItem1.Name = "MoverAContVacíosToolStripMenuItem1"
        Me.MoverAContVacíosToolStripMenuItem1.Size = New System.Drawing.Size(203, 22)
        Me.MoverAContVacíosToolStripMenuItem1.Text = "Mover a cont. Vacíos"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.TextBox4)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 444)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(436, 76)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Semáforo de alerta"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(112, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(166, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Pasado de fecha de demora"
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.Red
        Me.TextBox4.Location = New System.Drawing.Point(6, 19)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 3
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.btnRepSalidas)
        Me.GroupBox4.Controls.Add(Me.btnAgregarTramSencillo)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(891, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(271, 68)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Añadir información"
        '
        'btnRepSalidas
        '
        Me.btnRepSalidas.Image = CType(resources.GetObject("btnRepSalidas.Image"), System.Drawing.Image)
        Me.btnRepSalidas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRepSalidas.Location = New System.Drawing.Point(6, 19)
        Me.btnRepSalidas.Name = "btnRepSalidas"
        Me.btnRepSalidas.Size = New System.Drawing.Size(120, 40)
        Me.btnRepSalidas.TabIndex = 1
        Me.btnRepSalidas.Text = "        Rep. Salidas"
        Me.btnRepSalidas.UseVisualStyleBackColor = True
        '
        'btnAgregarTramSencillo
        '
        Me.btnAgregarTramSencillo.Image = CType(resources.GetObject("btnAgregarTramSencillo.Image"), System.Drawing.Image)
        Me.btnAgregarTramSencillo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregarTramSencillo.Location = New System.Drawing.Point(145, 19)
        Me.btnAgregarTramSencillo.Name = "btnAgregarTramSencillo"
        Me.btnAgregarTramSencillo.Size = New System.Drawing.Size(120, 40)
        Me.btnAgregarTramSencillo.TabIndex = 0
        Me.btnAgregarTramSencillo.Text = "     Rep. Tramo sencillo"
        Me.btnAgregarTramSencillo.UseVisualStyleBackColor = True
        '
        'btnArribaGridVac
        '
        Me.btnArribaGridVac.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnArribaGridVac.Image = CType(resources.GetObject("btnArribaGridVac.Image"), System.Drawing.Image)
        Me.btnArribaGridVac.Location = New System.Drawing.Point(1119, 168)
        Me.btnArribaGridVac.Name = "btnArribaGridVac"
        Me.btnArribaGridVac.Size = New System.Drawing.Size(43, 43)
        Me.btnArribaGridVac.TabIndex = 6
        Me.btnArribaGridVac.UseVisualStyleBackColor = True
        '
        'btnAbajoGridVac
        '
        Me.btnAbajoGridVac.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnAbajoGridVac.Image = CType(resources.GetObject("btnAbajoGridVac.Image"), System.Drawing.Image)
        Me.btnAbajoGridVac.Location = New System.Drawing.Point(1119, 301)
        Me.btnAbajoGridVac.Name = "btnAbajoGridVac"
        Me.btnAbajoGridVac.Size = New System.Drawing.Size(43, 43)
        Me.btnAbajoGridVac.TabIndex = 7
        Me.btnAbajoGridVac.UseVisualStyleBackColor = True
        '
        'btnAbajoGridLle
        '
        Me.btnAbajoGridLle.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnAbajoGridLle.Image = CType(resources.GetObject("btnAbajoGridLle.Image"), System.Drawing.Image)
        Me.btnAbajoGridLle.Location = New System.Drawing.Point(1119, 796)
        Me.btnAbajoGridLle.Name = "btnAbajoGridLle"
        Me.btnAbajoGridLle.Size = New System.Drawing.Size(43, 43)
        Me.btnAbajoGridLle.TabIndex = 9
        Me.btnAbajoGridLle.UseVisualStyleBackColor = True
        '
        'btnArribaGridLle
        '
        Me.btnArribaGridLle.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnArribaGridLle.Image = CType(resources.GetObject("btnArribaGridLle.Image"), System.Drawing.Image)
        Me.btnArribaGridLle.Location = New System.Drawing.Point(1119, 663)
        Me.btnArribaGridLle.Name = "btnArribaGridLle"
        Me.btnArribaGridLle.Size = New System.Drawing.Size(43, 43)
        Me.btnArribaGridLle.TabIndex = 8
        Me.btnArribaGridLle.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(454, 466)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(189, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Buscar contenedor / referencia:"
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Location = New System.Drawing.Point(457, 481)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(180, 20)
        Me.txtBusqueda.TabIndex = 11
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 86)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1101, 352)
        Me.TabControl1.TabIndex = 12
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.gridContVacios)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1093, 326)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Cont. Vacíos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.gridSalientesVacios)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1093, 326)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Cont. Que salen"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'gridSalientesVacios
        '
        Me.gridSalientesVacios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridSalientesVacios.ContextMenuStrip = Me.ContextMenuStrip3
        Me.gridSalientesVacios.Location = New System.Drawing.Point(6, 6)
        Me.gridSalientesVacios.Name = "gridSalientesVacios"
        Me.gridSalientesVacios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridSalientesVacios.Size = New System.Drawing.Size(1081, 314)
        Me.gridSalientesVacios.TabIndex = 0
        '
        'ContextMenuStrip3
        '
        Me.ContextMenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MoverAContVacíosToolStripMenuItem, Me.EliminarSalVacToolStripMenuItem})
        Me.ContextMenuStrip3.Name = "ContextMenuStrip3"
        Me.ContextMenuStrip3.Size = New System.Drawing.Size(186, 48)
        '
        'MoverAContVacíosToolStripMenuItem
        '
        Me.MoverAContVacíosToolStripMenuItem.Image = CType(resources.GetObject("MoverAContVacíosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MoverAContVacíosToolStripMenuItem.Name = "MoverAContVacíosToolStripMenuItem"
        Me.MoverAContVacíosToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.MoverAContVacíosToolStripMenuItem.Text = "Mover a cont. Vacíos"
        '
        'EliminarSalVacToolStripMenuItem
        '
        Me.EliminarSalVacToolStripMenuItem.Image = CType(resources.GetObject("EliminarSalVacToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EliminarSalVacToolStripMenuItem.Name = "EliminarSalVacToolStripMenuItem"
        Me.EliminarSalVacToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.EliminarSalVacToolStripMenuItem.Text = "Eliminar"
        '
        'TabControl2
        '
        Me.TabControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Location = New System.Drawing.Point(12, 587)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(1101, 307)
        Me.TabControl2.TabIndex = 14
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.gridContLlenos)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1093, 281)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Cont. Llenos"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.gridSalientesLlenos)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1093, 281)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Cont. Que salen"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'gridSalientesLlenos
        '
        Me.gridSalientesLlenos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridSalientesLlenos.ContextMenuStrip = Me.ContextMenuStrip4
        Me.gridSalientesLlenos.Location = New System.Drawing.Point(6, 6)
        Me.gridSalientesLlenos.Name = "gridSalientesLlenos"
        Me.gridSalientesLlenos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridSalientesLlenos.Size = New System.Drawing.Size(1081, 269)
        Me.gridSalientesLlenos.TabIndex = 0
        '
        'ContextMenuStrip4
        '
        Me.ContextMenuStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MoverAContLlenosToolStripMenuItem, Me.EliminarSalLlenToolStripMenuItem})
        Me.ContextMenuStrip4.Name = "ContextMenuStrip4"
        Me.ContextMenuStrip4.Size = New System.Drawing.Size(186, 70)
        '
        'MoverAContLlenosToolStripMenuItem
        '
        Me.MoverAContLlenosToolStripMenuItem.Image = CType(resources.GetObject("MoverAContLlenosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MoverAContLlenosToolStripMenuItem.Name = "MoverAContLlenosToolStripMenuItem"
        Me.MoverAContLlenosToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.MoverAContLlenosToolStripMenuItem.Text = "Mover a cont. Llenos"
        '
        'EliminarSalLlenToolStripMenuItem
        '
        Me.EliminarSalLlenToolStripMenuItem.Image = CType(resources.GetObject("EliminarSalLlenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EliminarSalLlenToolStripMenuItem.Name = "EliminarSalLlenToolStripMenuItem"
        Me.EliminarSalLlenToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.EliminarSalLlenToolStripMenuItem.Text = "Eliminar"
        '
        'btnOrdenarGridVacios
        '
        Me.btnOrdenarGridVacios.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnOrdenarGridVacios.Image = CType(resources.GetObject("btnOrdenarGridVacios.Image"), System.Drawing.Image)
        Me.btnOrdenarGridVacios.Location = New System.Drawing.Point(1119, 235)
        Me.btnOrdenarGridVacios.Name = "btnOrdenarGridVacios"
        Me.btnOrdenarGridVacios.Size = New System.Drawing.Size(43, 43)
        Me.btnOrdenarGridVacios.TabIndex = 15
        Me.btnOrdenarGridVacios.UseVisualStyleBackColor = True
        '
        'btnOrdenarGridLlenos
        '
        Me.btnOrdenarGridLlenos.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnOrdenarGridLlenos.Image = CType(resources.GetObject("btnOrdenarGridLlenos.Image"), System.Drawing.Image)
        Me.btnOrdenarGridLlenos.Location = New System.Drawing.Point(1119, 729)
        Me.btnOrdenarGridLlenos.Name = "btnOrdenarGridLlenos"
        Me.btnOrdenarGridLlenos.Size = New System.Drawing.Size(43, 43)
        Me.btnOrdenarGridLlenos.TabIndex = 16
        Me.btnOrdenarGridLlenos.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(888, 463)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Contenedores vacíos en DAH:"
        '
        'etqContVaciosDAH
        '
        Me.etqContVaciosDAH.AutoSize = True
        Me.etqContVaciosDAH.BackColor = System.Drawing.Color.Transparent
        Me.etqContVaciosDAH.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etqContVaciosDAH.Location = New System.Drawing.Point(1091, 463)
        Me.etqContVaciosDAH.Name = "etqContVaciosDAH"
        Me.etqContVaciosDAH.Size = New System.Drawing.Size(14, 13)
        Me.etqContVaciosDAH.TabIndex = 18
        Me.etqContVaciosDAH.Text = "0"
        '
        'etqContVacDemorados
        '
        Me.etqContVacDemorados.AutoSize = True
        Me.etqContVacDemorados.BackColor = System.Drawing.Color.Transparent
        Me.etqContVacDemorados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etqContVacDemorados.Location = New System.Drawing.Point(1091, 476)
        Me.etqContVacDemorados.Name = "etqContVacDemorados"
        Me.etqContVacDemorados.Size = New System.Drawing.Size(14, 13)
        Me.etqContVacDemorados.TabIndex = 20
        Me.etqContVacDemorados.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(888, 476)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(197, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Contenedores vacíos demorados:"
        '
        'etqConVacSinDemora
        '
        Me.etqConVacSinDemora.AutoSize = True
        Me.etqConVacSinDemora.BackColor = System.Drawing.Color.Transparent
        Me.etqConVacSinDemora.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etqConVacSinDemora.Location = New System.Drawing.Point(1091, 489)
        Me.etqConVacSinDemora.Name = "etqConVacSinDemora"
        Me.etqConVacSinDemora.Size = New System.Drawing.Size(14, 13)
        Me.etqConVacSinDemora.TabIndex = 22
        Me.etqConVacSinDemora.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(888, 489)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(197, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Contenedores vacíos sin demora:"
        '
        'etqConLlenosFecCierre
        '
        Me.etqConLlenosFecCierre.AutoSize = True
        Me.etqConLlenosFecCierre.BackColor = System.Drawing.Color.Transparent
        Me.etqConLlenosFecCierre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etqConLlenosFecCierre.Location = New System.Drawing.Point(1091, 549)
        Me.etqConLlenosFecCierre.Name = "etqConLlenosFecCierre"
        Me.etqConLlenosFecCierre.Size = New System.Drawing.Size(14, 13)
        Me.etqConLlenosFecCierre.TabIndex = 24
        Me.etqConLlenosFecCierre.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(888, 536)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(170, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Contenedores llenos en DAH"
        '
        'etqConLlenosDAH
        '
        Me.etqConLlenosDAH.AutoSize = True
        Me.etqConLlenosDAH.BackColor = System.Drawing.Color.Transparent
        Me.etqConLlenosDAH.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etqConLlenosDAH.Location = New System.Drawing.Point(1091, 523)
        Me.etqConLlenosDAH.Name = "etqConLlenosDAH"
        Me.etqConLlenosDAH.Size = New System.Drawing.Size(14, 13)
        Me.etqConLlenosDAH.TabIndex = 26
        Me.etqConLlenosDAH.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(888, 523)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(174, 13)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Contenedores llenos en DAH:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(888, 549)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(163, 13)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "por cumplir fecha de cierre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(888, 502)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(182, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Total de contenedores vacíos:"
        '
        'etqContVacTot
        '
        Me.etqContVacTot.AutoSize = True
        Me.etqContVacTot.BackColor = System.Drawing.Color.Transparent
        Me.etqContVacTot.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etqContVacTot.Location = New System.Drawing.Point(1091, 502)
        Me.etqContVacTot.Name = "etqContVacTot"
        Me.etqContVacTot.Size = New System.Drawing.Size(14, 13)
        Me.etqContVacTot.TabIndex = 29
        Me.etqContVacTot.Text = "0"
        '
        'ReporteEstatusContenedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1174, 906)
        Me.Controls.Add(Me.etqContVacTot)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.etqConLlenosDAH)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.etqConLlenosFecCierre)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.etqConVacSinDemora)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.etqContVacDemorados)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.etqContVaciosDAH)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnOrdenarGridLlenos)
        Me.Controls.Add(Me.btnOrdenarGridVacios)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnAbajoGridLle)
        Me.Controls.Add(Me.btnArribaGridLle)
        Me.Controls.Add(Me.btnAbajoGridVac)
        Me.Controls.Add(Me.btnArribaGridVac)
        Me.Controls.Add(Me.txtBusqueda)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ReporteEstatusContenedores"
        Me.Text = "Reporte de Estatus de Contenedores | Logística"
        CType(Me.gridContVacios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.gridContLlenos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.gridSalientesVacios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip3.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        CType(Me.gridSalientesLlenos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gridContVacios As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnGenerar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnExportar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnReporte As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents gridContLlenos As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAgregarTramSencillo As System.Windows.Forms.Button
    Friend WithEvents btnRepSalidas As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmiEliminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EliminarContenedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeshacerEliminaciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnArribaGridVac As System.Windows.Forms.Button
    Friend WithEvents btnAbajoGridVac As System.Windows.Forms.Button
    Friend WithEvents btnAbajoGridLle As System.Windows.Forms.Button
    Friend WithEvents btnArribaGridLle As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents gridSalientesVacios As System.Windows.Forms.DataGridView
    Friend WithEvents CambiarAContSalienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip3 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MoverAContVacíosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents gridSalientesLlenos As System.Windows.Forms.DataGridView
    Friend WithEvents DeshacerEliminaciónToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MoverAContQueSalenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip4 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MoverAContLlenosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MoverAContLlenosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MoverAContVacíosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnOrdenarGridVacios As System.Windows.Forms.Button
    Friend WithEvents btnOrdenarGridLlenos As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents etqContVaciosDAH As System.Windows.Forms.Label
    Friend WithEvents etqContVacDemorados As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents etqConVacSinDemora As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents etqConLlenosFecCierre As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents etqConLlenosDAH As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents etqContVacTot As System.Windows.Forms.Label
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents EliminarSalVacToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarSalLlenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
