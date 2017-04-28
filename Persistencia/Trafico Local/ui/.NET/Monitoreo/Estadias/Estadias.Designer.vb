<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Estadias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Estadias))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.mTBViaje = New System.Windows.Forms.MaskedTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.dTPFechaHasta = New System.Windows.Forms.DateTimePicker
        Me.dTPFechaDesde = New System.Windows.Forms.DateTimePicker
        Me.txtCliente = New System.Windows.Forms.TextBox
        Me.txtUnidad = New System.Windows.Forms.TextBox
        Me.rBFecha = New System.Windows.Forms.RadioButton
        Me.rBCliente = New System.Windows.Forms.RadioButton
        Me.rBViaje = New System.Windows.Forms.RadioButton
        Me.rBUnidad = New System.Windows.Forms.RadioButton
        Me.dGVEstadias = New System.Windows.Forms.DataGridView
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnEditar = New System.Windows.Forms.Button
        Me.btnEliminar = New System.Windows.Forms.Button
        Me.btnAgregar = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnExportar = New System.Windows.Forms.Button
        Me.btnRefrescar = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.dGVEstadias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.mTBViaje)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dTPFechaHasta)
        Me.GroupBox1.Controls.Add(Me.dTPFechaDesde)
        Me.GroupBox1.Controls.Add(Me.txtCliente)
        Me.GroupBox1.Controls.Add(Me.txtUnidad)
        Me.GroupBox1.Controls.Add(Me.rBFecha)
        Me.GroupBox1.Controls.Add(Me.rBCliente)
        Me.GroupBox1.Controls.Add(Me.rBViaje)
        Me.GroupBox1.Controls.Add(Me.rBUnidad)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(352, 132)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Búsqueda:"
        '
        'mTBViaje
        '
        Me.mTBViaje.Location = New System.Drawing.Point(133, 45)
        Me.mTBViaje.Mask = "9999999"
        Me.mTBViaje.Name = "mTBViaje"
        Me.mTBViaje.Size = New System.Drawing.Size(209, 20)
        Me.mTBViaje.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(199, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Hasta"
        '
        'dTPFechaHasta
        '
        Me.dTPFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dTPFechaHasta.Location = New System.Drawing.Point(245, 97)
        Me.dTPFechaHasta.Name = "dTPFechaHasta"
        Me.dTPFechaHasta.Size = New System.Drawing.Size(97, 20)
        Me.dTPFechaHasta.TabIndex = 8
        '
        'dTPFechaDesde
        '
        Me.dTPFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dTPFechaDesde.Location = New System.Drawing.Point(96, 97)
        Me.dTPFechaDesde.Name = "dTPFechaDesde"
        Me.dTPFechaDesde.Size = New System.Drawing.Size(97, 20)
        Me.dTPFechaDesde.TabIndex = 7
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(102, 71)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(240, 20)
        Me.txtCliente.TabIndex = 6
        '
        'txtUnidad
        '
        Me.txtUnidad.Location = New System.Drawing.Point(102, 19)
        Me.txtUnidad.Name = "txtUnidad"
        Me.txtUnidad.Size = New System.Drawing.Size(240, 20)
        Me.txtUnidad.TabIndex = 4
        '
        'rBFecha
        '
        Me.rBFecha.AutoSize = True
        Me.rBFecha.Location = New System.Drawing.Point(6, 99)
        Me.rBFecha.Name = "rBFecha"
        Me.rBFecha.Size = New System.Drawing.Size(84, 17)
        Me.rBFecha.TabIndex = 3
        Me.rBFecha.TabStop = True
        Me.rBFecha.Text = "Por fecha:"
        Me.rBFecha.UseVisualStyleBackColor = True
        '
        'rBCliente
        '
        Me.rBCliente.AutoSize = True
        Me.rBCliente.Location = New System.Drawing.Point(6, 72)
        Me.rBCliente.Name = "rBCliente"
        Me.rBCliente.Size = New System.Drawing.Size(90, 17)
        Me.rBCliente.TabIndex = 2
        Me.rBCliente.TabStop = True
        Me.rBCliente.Text = "Por cliente:"
        Me.rBCliente.UseVisualStyleBackColor = True
        '
        'rBViaje
        '
        Me.rBViaje.AutoSize = True
        Me.rBViaje.Location = New System.Drawing.Point(6, 46)
        Me.rBViaje.Name = "rBViaje"
        Me.rBViaje.Size = New System.Drawing.Size(121, 17)
        Me.rBViaje.TabIndex = 1
        Me.rBViaje.TabStop = True
        Me.rBViaje.Text = "Por no. De viaje:"
        Me.rBViaje.UseVisualStyleBackColor = True
        '
        'rBUnidad
        '
        Me.rBUnidad.AutoSize = True
        Me.rBUnidad.Location = New System.Drawing.Point(6, 20)
        Me.rBUnidad.Name = "rBUnidad"
        Me.rBUnidad.Size = New System.Drawing.Size(90, 17)
        Me.rBUnidad.TabIndex = 0
        Me.rBUnidad.TabStop = True
        Me.rBUnidad.Text = "Por unidad:"
        Me.rBUnidad.UseVisualStyleBackColor = True
        '
        'dGVEstadias
        '
        Me.dGVEstadias.AllowUserToAddRows = False
        Me.dGVEstadias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dGVEstadias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dGVEstadias.Location = New System.Drawing.Point(12, 150)
        Me.dGVEstadias.Name = "dGVEstadias"
        Me.dGVEstadias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dGVEstadias.Size = New System.Drawing.Size(884, 338)
        Me.dGVEstadias.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btnEditar)
        Me.GroupBox2.Controls.Add(Me.btnEliminar)
        Me.GroupBox2.Controls.Add(Me.btnAgregar)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(370, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(168, 132)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Opciones de registro:"
        '
        'btnEditar
        '
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.Location = New System.Drawing.Point(110, 49)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(40, 40)
        Me.btnEditar.TabIndex = 2
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.Location = New System.Drawing.Point(64, 49)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(40, 40)
        Me.btnEliminar.TabIndex = 1
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.Location = New System.Drawing.Point(18, 49)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(40, 40)
        Me.btnAgregar.TabIndex = 0
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.btnSalir)
        Me.GroupBox3.Controls.Add(Me.btnExportar)
        Me.GroupBox3.Controls.Add(Me.btnRefrescar)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(544, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(352, 132)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Opciones de sistema:"
        '
        'btnSalir
        '
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(212, 51)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(40, 40)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnExportar
        '
        Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
        Me.btnExportar.Location = New System.Drawing.Point(166, 51)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(40, 40)
        Me.btnExportar.TabIndex = 1
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'btnRefrescar
        '
        Me.btnRefrescar.Image = CType(resources.GetObject("btnRefrescar.Image"), System.Drawing.Image)
        Me.btnRefrescar.Location = New System.Drawing.Point(120, 51)
        Me.btnRefrescar.Name = "btnRefrescar"
        Me.btnRefrescar.Size = New System.Drawing.Size(40, 40)
        Me.btnRefrescar.TabIndex = 0
        Me.btnRefrescar.UseVisualStyleBackColor = True
        '
        'Estadias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(908, 500)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dGVEstadias)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Estadias"
        Me.Text = "Estadias"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dGVEstadias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dGVEstadias As System.Windows.Forms.DataGridView
    Friend WithEvents rBViaje As System.Windows.Forms.RadioButton
    Friend WithEvents rBUnidad As System.Windows.Forms.RadioButton
    Friend WithEvents dTPFechaDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents txtUnidad As System.Windows.Forms.TextBox
    Friend WithEvents rBFecha As System.Windows.Forms.RadioButton
    Friend WithEvents rBCliente As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dTPFechaHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnExportar As System.Windows.Forms.Button
    Friend WithEvents btnRefrescar As System.Windows.Forms.Button
    Friend WithEvents mTBViaje As System.Windows.Forms.MaskedTextBox
End Class
