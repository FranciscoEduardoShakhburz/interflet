<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CatUnidades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CatUnidades))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnAgregar = New System.Windows.Forms.ToolStripButton
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton
        Me.btnEditar = New System.Windows.Forms.ToolStripButton
        Me.btnSalir = New System.Windows.Forms.ToolStripButton
        Me.gridUnidades = New System.Windows.Forms.DataGridView
        Me.eco = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.marca = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.modelo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.numSerie = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.año = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ToolStrip1.SuspendLayout()
        CType(Me.gridUnidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAgregar, Me.btnEliminar, Me.btnEditar, Me.btnSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(568, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnAgregar
        '
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(66, 22)
        Me.btnAgregar.Text = "Agregar"
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(63, 22)
        Me.btnEliminar.Text = "Eliminar"
        '
        'btnEditar
        '
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(55, 22)
        Me.btnEditar.Text = "Editar"
        '
        'btnSalir
        '
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(47, 22)
        Me.btnSalir.Text = "Salir"
        '
        'gridUnidades
        '
        Me.gridUnidades.AllowUserToAddRows = False
        Me.gridUnidades.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridUnidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridUnidades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.eco, Me.marca, Me.modelo, Me.numSerie, Me.año})
        Me.gridUnidades.Location = New System.Drawing.Point(12, 28)
        Me.gridUnidades.Name = "gridUnidades"
        Me.gridUnidades.ReadOnly = True
        Me.gridUnidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridUnidades.Size = New System.Drawing.Size(544, 415)
        Me.gridUnidades.TabIndex = 1
        '
        'eco
        '
        Me.eco.HeaderText = "No. Económico"
        Me.eco.Name = "eco"
        Me.eco.ReadOnly = True
        '
        'marca
        '
        Me.marca.HeaderText = "Marca"
        Me.marca.Name = "marca"
        Me.marca.ReadOnly = True
        '
        'modelo
        '
        Me.modelo.HeaderText = "Modelo"
        Me.modelo.Name = "modelo"
        Me.modelo.ReadOnly = True
        '
        'numSerie
        '
        Me.numSerie.HeaderText = "No. De serie"
        Me.numSerie.Name = "numSerie"
        Me.numSerie.ReadOnly = True
        '
        'año
        '
        Me.año.HeaderText = "Año"
        Me.año.Name = "año"
        Me.año.ReadOnly = True
        '
        'CatUnidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(568, 455)
        Me.Controls.Add(Me.gridUnidades)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CatUnidades"
        Me.Text = "Catálogo de unidades | Vales de gasolina"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.gridUnidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents gridUnidades As System.Windows.Forms.DataGridView
    Friend WithEvents eco As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents marca As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents modelo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numSerie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents año As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
