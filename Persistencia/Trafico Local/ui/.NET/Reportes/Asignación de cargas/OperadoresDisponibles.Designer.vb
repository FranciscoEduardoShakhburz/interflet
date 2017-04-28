<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OperadoresDisponibles
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OperadoresDisponibles))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnEliminar = New System.Windows.Forms.Button
        Me.btnEditar = New System.Windows.Forms.Button
        Me.btnAgregar = New System.Windows.Forms.Button
        Me.dGVOperadores = New System.Windows.Forms.DataGridView
        Me.colOperador = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colNombreOperador = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colUnidadAsignada = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colModalidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDisponible = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.colObservaciones = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.dGVOperadores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Controls.Add(Me.btnEditar)
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(672, 67)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.Location = New System.Drawing.Point(98, 19)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(40, 40)
        Me.btnEliminar.TabIndex = 2
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.Location = New System.Drawing.Point(52, 19)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(40, 40)
        Me.btnEditar.TabIndex = 1
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.Location = New System.Drawing.Point(6, 19)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(40, 40)
        Me.btnAgregar.TabIndex = 0
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'dGVOperadores
        '
        Me.dGVOperadores.AllowUserToAddRows = False
        Me.dGVOperadores.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dGVOperadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dGVOperadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dGVOperadores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colOperador, Me.colNombreOperador, Me.colUnidadAsignada, Me.colModalidad, Me.colDisponible, Me.colObservaciones})
        Me.dGVOperadores.Location = New System.Drawing.Point(12, 85)
        Me.dGVOperadores.Name = "dGVOperadores"
        Me.dGVOperadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dGVOperadores.Size = New System.Drawing.Size(672, 298)
        Me.dGVOperadores.TabIndex = 1
        '
        'colOperador
        '
        Me.colOperador.HeaderText = "Operador"
        Me.colOperador.Name = "colOperador"
        '
        'colNombreOperador
        '
        Me.colNombreOperador.HeaderText = "Nombre"
        Me.colNombreOperador.Name = "colNombreOperador"
        '
        'colUnidadAsignada
        '
        Me.colUnidadAsignada.HeaderText = "Unidad"
        Me.colUnidadAsignada.Name = "colUnidadAsignada"
        '
        'colModalidad
        '
        Me.colModalidad.HeaderText = "Modalidad"
        Me.colModalidad.Name = "colModalidad"
        '
        'colDisponible
        '
        Me.colDisponible.HeaderText = "Disponible"
        Me.colDisponible.Name = "colDisponible"
        '
        'colObservaciones
        '
        Me.colObservaciones.HeaderText = "Observaciones"
        Me.colObservaciones.Name = "colObservaciones"
        Me.colObservaciones.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colObservaciones.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(564, 389)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(120, 40)
        Me.btnSalir.TabIndex = 1
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(438, 389)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(120, 40)
        Me.btnGuardar.TabIndex = 2
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'OperadoresDisponibles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(696, 442)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.dGVOperadores)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "OperadoresDisponibles"
        Me.Text = "Operadores disponibles | Asignación de cargas"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dGVOperadores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents dGVOperadores As System.Windows.Forms.DataGridView
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents colOperador As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNombreOperador As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colUnidadAsignada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colModalidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDisponible As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colObservaciones As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
