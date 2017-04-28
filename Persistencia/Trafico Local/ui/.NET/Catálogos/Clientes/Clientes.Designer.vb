<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clientes))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.dGVClientes = New System.Windows.Forms.DataGridView
        Me.tSMenu = New System.Windows.Forms.ToolStrip
        Me.tSBAgregar = New System.Windows.Forms.ToolStripButton
        Me.tSBEditar = New System.Windows.Forms.ToolStripButton
        Me.tSBEliminar = New System.Windows.Forms.ToolStripButton
        Me.tSSSeparador = New System.Windows.Forms.ToolStripSeparator
        Me.tSBSalir = New System.Windows.Forms.ToolStripButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.tBBusqueda = New System.Windows.Forms.TextBox
        Me.rBNombre = New System.Windows.Forms.RadioButton
        Me.rBNumero = New System.Windows.Forms.RadioButton
        Me.colNumeroCliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colNombre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCorreos = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colHoras = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox2.SuspendLayout()
        CType(Me.dGVClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tSMenu.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.dGVClientes)
        Me.GroupBox2.Font = New System.Drawing.Font("Ubuntu", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 154)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(571, 310)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'dGVClientes
        '
        Me.dGVClientes.AllowUserToAddRows = False
        Me.dGVClientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dGVClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dGVClientes.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.dGVClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dGVClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNumeroCliente, Me.colNombre, Me.colCorreos, Me.colHoras})
        Me.dGVClientes.Location = New System.Drawing.Point(6, 19)
        Me.dGVClientes.Name = "dGVClientes"
        Me.dGVClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dGVClientes.Size = New System.Drawing.Size(559, 285)
        Me.dGVClientes.TabIndex = 0
        '
        'tSMenu
        '
        Me.tSMenu.AutoSize = False
        Me.tSMenu.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tSMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tSBAgregar, Me.tSBEditar, Me.tSBEliminar, Me.tSSSeparador, Me.tSBSalir})
        Me.tSMenu.Location = New System.Drawing.Point(0, 0)
        Me.tSMenu.Name = "tSMenu"
        Me.tSMenu.Size = New System.Drawing.Size(595, 65)
        Me.tSMenu.TabIndex = 2
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
        'tSBEditar
        '
        Me.tSBEditar.AutoSize = False
        Me.tSBEditar.Image = CType(resources.GetObject("tSBEditar.Image"), System.Drawing.Image)
        Me.tSBEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tSBEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tSBEditar.Name = "tSBEditar"
        Me.tSBEditar.Size = New System.Drawing.Size(60, 60)
        Me.tSBEditar.Text = "Editar"
        Me.tSBEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.tBBusqueda)
        Me.GroupBox1.Controls.Add(Me.rBNombre)
        Me.GroupBox1.Controls.Add(Me.rBNumero)
        Me.GroupBox1.Font = New System.Drawing.Font("Ubuntu", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(571, 80)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtro de búsqueda"
        '
        'tBBusqueda
        '
        Me.tBBusqueda.Location = New System.Drawing.Point(6, 49)
        Me.tBBusqueda.Name = "tBBusqueda"
        Me.tBBusqueda.Size = New System.Drawing.Size(355, 25)
        Me.tBBusqueda.TabIndex = 2
        '
        'rBNombre
        '
        Me.rBNombre.AutoSize = True
        Me.rBNombre.Location = New System.Drawing.Point(171, 19)
        Me.rBNombre.Name = "rBNombre"
        Me.rBNombre.Size = New System.Drawing.Size(83, 24)
        Me.rBNombre.TabIndex = 1
        Me.rBNombre.TabStop = True
        Me.rBNombre.Text = "Nombre"
        Me.rBNombre.UseVisualStyleBackColor = True
        '
        'rBNumero
        '
        Me.rBNumero.AutoSize = True
        Me.rBNumero.Location = New System.Drawing.Point(6, 19)
        Me.rBNumero.Name = "rBNumero"
        Me.rBNumero.Size = New System.Drawing.Size(159, 24)
        Me.rBNumero.TabIndex = 0
        Me.rBNumero.TabStop = True
        Me.rBNumero.Text = "Número de cliente"
        Me.rBNumero.UseVisualStyleBackColor = True
        '
        'colNumeroCliente
        '
        Me.colNumeroCliente.HeaderText = "Número de cliente"
        Me.colNumeroCliente.Name = "colNumeroCliente"
        '
        'colNombre
        '
        Me.colNombre.HeaderText = "Nombre de cliente"
        Me.colNombre.Name = "colNombre"
        '
        'colCorreos
        '
        Me.colCorreos.HeaderText = "Correos"
        Me.colCorreos.Name = "colCorreos"
        '
        'colHoras
        '
        Me.colHoras.HeaderText = "Horas"
        Me.colHoras.Name = "colHoras"
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(595, 476)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tSMenu)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Clientes"
        Me.Text = "Clientes"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dGVClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tSMenu.ResumeLayout(False)
        Me.tSMenu.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tSMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents tSBAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tSBEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents dGVClientes As System.Windows.Forms.DataGridView
    Friend WithEvents tSBEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tSSSeparador As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tSBSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tBBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents rBNombre As System.Windows.Forms.RadioButton
    Friend WithEvents rBNumero As System.Windows.Forms.RadioButton
    Friend WithEvents colNumeroCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCorreos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHoras As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
