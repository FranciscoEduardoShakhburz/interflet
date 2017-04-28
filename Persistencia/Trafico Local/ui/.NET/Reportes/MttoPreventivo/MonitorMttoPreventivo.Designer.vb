<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MonitorMttoPreventivo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MonitorMttoPreventivo))
        Me.gridMonitor = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnEliminar = New System.Windows.Forms.Button
        Me.btnAgregar = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnActualizar = New System.Windows.Forms.Button
        Me.btnExportar = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.Tracto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Kilometraje = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HrsMotor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UltServicio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCalcular = New System.Windows.Forms.DataGridViewButtonColumn
        Me.ProxServKM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ProxServHrs = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ProxServFecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.gridMonitor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'gridMonitor
        '
        Me.gridMonitor.AllowUserToAddRows = False
        Me.gridMonitor.AllowUserToOrderColumns = True
        Me.gridMonitor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridMonitor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridMonitor.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.gridMonitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridMonitor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Tracto, Me.Kilometraje, Me.HrsMotor, Me.UltServicio, Me.colCalcular, Me.ProxServKM, Me.ProxServHrs, Me.ProxServFecha})
        Me.gridMonitor.Location = New System.Drawing.Point(12, 101)
        Me.gridMonitor.Name = "gridMonitor"
        Me.gridMonitor.Size = New System.Drawing.Size(744, 431)
        Me.gridMonitor.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(261, 70)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Unidades"
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(132, 19)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(120, 40)
        Me.btnEliminar.TabIndex = 1
        Me.btnEliminar.Text = "   Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(6, 19)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(120, 40)
        Me.btnAgregar.TabIndex = 0
        Me.btnAgregar.Text = "   Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(12, 538)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(120, 40)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(362, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "dd/mm/aaaa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(667, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "dd/mm/aaaa"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btnActualizar)
        Me.GroupBox2.Controls.Add(Me.btnExportar)
        Me.GroupBox2.Controls.Add(Me.btnGuardar)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(279, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(477, 70)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Opciones"
        '
        'btnActualizar
        '
        Me.btnActualizar.Image = CType(resources.GetObject("btnActualizar.Image"), System.Drawing.Image)
        Me.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnActualizar.Location = New System.Drawing.Point(258, 19)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(120, 40)
        Me.btnActualizar.TabIndex = 2
        Me.btnActualizar.Text = "   Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnExportar
        '
        Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
        Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportar.Location = New System.Drawing.Point(132, 19)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(120, 40)
        Me.btnExportar.TabIndex = 1
        Me.btnExportar.Text = "   Exportar"
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(6, 19)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(120, 40)
        Me.btnGuardar.TabIndex = 0
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'Tracto
        '
        Me.Tracto.HeaderText = "Tracto"
        Me.Tracto.Name = "Tracto"
        '
        'Kilometraje
        '
        Me.Kilometraje.HeaderText = "Kilometraje"
        Me.Kilometraje.Name = "Kilometraje"
        '
        'HrsMotor
        '
        Me.HrsMotor.HeaderText = "Horas motor"
        Me.HrsMotor.Name = "HrsMotor"
        '
        'UltServicio
        '
        Me.UltServicio.HeaderText = "Fecha de último servicio"
        Me.UltServicio.Name = "UltServicio"
        '
        'colCalcular
        '
        Me.colCalcular.HeaderText = ""
        Me.colCalcular.Name = "colCalcular"
        Me.colCalcular.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colCalcular.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colCalcular.Text = "Calcular"
        '
        'ProxServKM
        '
        Me.ProxServKM.HeaderText = "Próximo servicio por km"
        Me.ProxServKM.Name = "ProxServKM"
        '
        'ProxServHrs
        '
        Me.ProxServHrs.HeaderText = "Próximo servicio por horas"
        Me.ProxServHrs.Name = "ProxServHrs"
        '
        'ProxServFecha
        '
        Me.ProxServFecha.HeaderText = "Próximo servicio por fecha"
        Me.ProxServFecha.Name = "ProxServFecha"
        '
        'MonitorMttoPreventivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(768, 590)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gridMonitor)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MonitorMttoPreventivo"
        Me.Text = "Mantenimiento Preventivo"
        CType(Me.gridMonitor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gridMonitor As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnExportar As System.Windows.Forms.Button
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents Tracto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Kilometraje As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HrsMotor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UltServicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCalcular As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents ProxServKM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProxServHrs As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProxServFecha As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
