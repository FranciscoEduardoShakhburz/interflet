<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BitacoraViaje
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BitacoraViaje))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.bRefrescar = New System.Windows.Forms.Button
        Me.bSalir = New System.Windows.Forms.Button
        Me.bGuardar = New System.Windows.Forms.Button
        Me.bCargarInfo = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.dGVViajes = New System.Windows.Forms.DataGridView
        Me.colTipoUnidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colStatusViaje = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colUnidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colOperador = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPlacas = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colViaje = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colObservaciones = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colNumeroCliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDestino = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colContenedor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTipoOperacion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDireccionEntrega = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colStatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colUbicacion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.bCancelar = New System.Windows.Forms.Button
        Me.bEditar = New System.Windows.Forms.Button
        Me.dGVBitacora = New System.Windows.Forms.DataGridView
        Me.colNumero = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTipoSuceso = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSuceso = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colObservacionesSuc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.bAgregar = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.cBEstatusViaje = New System.Windows.Forms.ComboBox
        Me.rBTodos = New System.Windows.Forms.RadioButton
        Me.rBLocales = New System.Windows.Forms.RadioButton
        Me.rBForaneos = New System.Windows.Forms.RadioButton
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dGVViajes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dGVBitacora, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.bRefrescar)
        Me.GroupBox1.Controls.Add(Me.bSalir)
        Me.GroupBox1.Controls.Add(Me.bGuardar)
        Me.GroupBox1.Controls.Add(Me.bCargarInfo)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(387, 115)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones"
        '
        'bRefrescar
        '
        Me.bRefrescar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.bRefrescar.Image = CType(resources.GetObject("bRefrescar.Image"), System.Drawing.Image)
        Me.bRefrescar.Location = New System.Drawing.Point(98, 47)
        Me.bRefrescar.Name = "bRefrescar"
        Me.bRefrescar.Size = New System.Drawing.Size(40, 40)
        Me.bRefrescar.TabIndex = 3
        Me.bRefrescar.UseVisualStyleBackColor = True
        '
        'bSalir
        '
        Me.bSalir.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.bSalir.Image = CType(resources.GetObject("bSalir.Image"), System.Drawing.Image)
        Me.bSalir.Location = New System.Drawing.Point(144, 47)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(40, 40)
        Me.bSalir.TabIndex = 2
        Me.bSalir.UseVisualStyleBackColor = True
        '
        'bGuardar
        '
        Me.bGuardar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.bGuardar.Image = CType(resources.GetObject("bGuardar.Image"), System.Drawing.Image)
        Me.bGuardar.Location = New System.Drawing.Point(52, 47)
        Me.bGuardar.Name = "bGuardar"
        Me.bGuardar.Size = New System.Drawing.Size(40, 40)
        Me.bGuardar.TabIndex = 1
        Me.bGuardar.UseVisualStyleBackColor = True
        '
        'bCargarInfo
        '
        Me.bCargarInfo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.bCargarInfo.Image = CType(resources.GetObject("bCargarInfo.Image"), System.Drawing.Image)
        Me.bCargarInfo.Location = New System.Drawing.Point(6, 47)
        Me.bCargarInfo.Name = "bCargarInfo"
        Me.bCargarInfo.Size = New System.Drawing.Size(40, 40)
        Me.bCargarInfo.TabIndex = 0
        Me.bCargarInfo.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.dGVViajes)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 133)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(709, 318)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Reporte de viajes"
        '
        'dGVViajes
        '
        Me.dGVViajes.AllowUserToAddRows = False
        Me.dGVViajes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dGVViajes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dGVViajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dGVViajes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colTipoUnidad, Me.colStatusViaje, Me.colUnidad, Me.colOperador, Me.colPlacas, Me.colViaje, Me.colObservaciones, Me.colNumeroCliente, Me.colCliente, Me.colDestino, Me.colCP, Me.colContenedor, Me.colTipoOperacion, Me.colDireccionEntrega, Me.colStatus, Me.colUbicacion})
        Me.dGVViajes.Location = New System.Drawing.Point(6, 25)
        Me.dGVViajes.Name = "dGVViajes"
        Me.dGVViajes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dGVViajes.Size = New System.Drawing.Size(697, 287)
        Me.dGVViajes.TabIndex = 0
        '
        'colTipoUnidad
        '
        Me.colTipoUnidad.HeaderText = "Tipo de unidad"
        Me.colTipoUnidad.Name = "colTipoUnidad"
        Me.colTipoUnidad.Visible = False
        '
        'colStatusViaje
        '
        Me.colStatusViaje.HeaderText = "Estatus de viaje"
        Me.colStatusViaje.Name = "colStatusViaje"
        '
        'colUnidad
        '
        Me.colUnidad.HeaderText = "Unidad"
        Me.colUnidad.Name = "colUnidad"
        '
        'colOperador
        '
        Me.colOperador.HeaderText = "Operador"
        Me.colOperador.Name = "colOperador"
        '
        'colPlacas
        '
        Me.colPlacas.HeaderText = "Placas"
        Me.colPlacas.Name = "colPlacas"
        '
        'colViaje
        '
        Me.colViaje.HeaderText = "Viaje"
        Me.colViaje.Name = "colViaje"
        '
        'colObservaciones
        '
        Me.colObservaciones.HeaderText = "Observaciones"
        Me.colObservaciones.Name = "colObservaciones"
        '
        'colNumeroCliente
        '
        Me.colNumeroCliente.HeaderText = "Número de cliente"
        Me.colNumeroCliente.Name = "colNumeroCliente"
        '
        'colCliente
        '
        Me.colCliente.HeaderText = "Cliente"
        Me.colCliente.Name = "colCliente"
        '
        'colDestino
        '
        Me.colDestino.HeaderText = "Destino"
        Me.colDestino.Name = "colDestino"
        '
        'colCP
        '
        Me.colCP.HeaderText = "Carta porte"
        Me.colCP.Name = "colCP"
        '
        'colContenedor
        '
        Me.colContenedor.HeaderText = "Contenedor"
        Me.colContenedor.Name = "colContenedor"
        '
        'colTipoOperacion
        '
        Me.colTipoOperacion.HeaderText = "Tipo de operación"
        Me.colTipoOperacion.Name = "colTipoOperacion"
        '
        'colDireccionEntrega
        '
        Me.colDireccionEntrega.HeaderText = "Dirección de entrega"
        Me.colDireccionEntrega.Name = "colDireccionEntrega"
        '
        'colStatus
        '
        Me.colStatus.HeaderText = "Status"
        Me.colStatus.Name = "colStatus"
        '
        'colUbicacion
        '
        Me.colUbicacion.HeaderText = "Ubicación"
        Me.colUbicacion.Name = "colUbicacion"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.bCancelar)
        Me.GroupBox3.Controls.Add(Me.bEditar)
        Me.GroupBox3.Controls.Add(Me.dGVBitacora)
        Me.GroupBox3.Controls.Add(Me.bAgregar)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 457)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(709, 162)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Bitácora"
        '
        'bCancelar
        '
        Me.bCancelar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bCancelar.Image = CType(resources.GetObject("bCancelar.Image"), System.Drawing.Image)
        Me.bCancelar.Location = New System.Drawing.Point(663, 113)
        Me.bCancelar.Name = "bCancelar"
        Me.bCancelar.Size = New System.Drawing.Size(40, 40)
        Me.bCancelar.TabIndex = 5
        Me.bCancelar.UseVisualStyleBackColor = True
        Me.bCancelar.Visible = False
        '
        'bEditar
        '
        Me.bEditar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bEditar.Image = CType(resources.GetObject("bEditar.Image"), System.Drawing.Image)
        Me.bEditar.Location = New System.Drawing.Point(663, 69)
        Me.bEditar.Name = "bEditar"
        Me.bEditar.Size = New System.Drawing.Size(40, 40)
        Me.bEditar.TabIndex = 4
        Me.bEditar.UseVisualStyleBackColor = True
        Me.bEditar.Visible = False
        '
        'dGVBitacora
        '
        Me.dGVBitacora.AllowUserToAddRows = False
        Me.dGVBitacora.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dGVBitacora.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dGVBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dGVBitacora.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNumero, Me.colTipoSuceso, Me.colSuceso, Me.colObservacionesSuc})
        Me.dGVBitacora.Location = New System.Drawing.Point(6, 25)
        Me.dGVBitacora.Name = "dGVBitacora"
        Me.dGVBitacora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dGVBitacora.Size = New System.Drawing.Size(651, 126)
        Me.dGVBitacora.TabIndex = 1
        '
        'colNumero
        '
        Me.colNumero.HeaderText = "N°"
        Me.colNumero.Name = "colNumero"
        '
        'colTipoSuceso
        '
        Me.colTipoSuceso.HeaderText = "Tipo de suceso"
        Me.colTipoSuceso.Name = "colTipoSuceso"
        '
        'colSuceso
        '
        Me.colSuceso.HeaderText = "Sucesos"
        Me.colSuceso.Name = "colSuceso"
        '
        'colObservacionesSuc
        '
        Me.colObservacionesSuc.HeaderText = "Observaciones"
        Me.colObservacionesSuc.Name = "colObservacionesSuc"
        '
        'bAgregar
        '
        Me.bAgregar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bAgregar.Image = CType(resources.GetObject("bAgregar.Image"), System.Drawing.Image)
        Me.bAgregar.Location = New System.Drawing.Point(663, 23)
        Me.bAgregar.Name = "bAgregar"
        Me.bAgregar.Size = New System.Drawing.Size(40, 40)
        Me.bAgregar.TabIndex = 3
        Me.bAgregar.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.cBEstatusViaje)
        Me.GroupBox4.Controls.Add(Me.rBTodos)
        Me.GroupBox4.Controls.Add(Me.rBLocales)
        Me.GroupBox4.Controls.Add(Me.rBForaneos)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(405, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(316, 115)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Filtro"
        '
        'cBEstatusViaje
        '
        Me.cBEstatusViaje.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.cBEstatusViaje.FormattingEnabled = True
        Me.cBEstatusViaje.Location = New System.Drawing.Point(116, 54)
        Me.cBEstatusViaje.Name = "cBEstatusViaje"
        Me.cBEstatusViaje.Size = New System.Drawing.Size(194, 28)
        Me.cBEstatusViaje.TabIndex = 3
        '
        'rBTodos
        '
        Me.rBTodos.AutoSize = True
        Me.rBTodos.Location = New System.Drawing.Point(6, 85)
        Me.rBTodos.Name = "rBTodos"
        Me.rBTodos.Size = New System.Drawing.Size(71, 24)
        Me.rBTodos.TabIndex = 2
        Me.rBTodos.TabStop = True
        Me.rBTodos.Text = "Todos"
        Me.rBTodos.UseVisualStyleBackColor = True
        '
        'rBLocales
        '
        Me.rBLocales.AutoSize = True
        Me.rBLocales.Location = New System.Drawing.Point(6, 55)
        Me.rBLocales.Name = "rBLocales"
        Me.rBLocales.Size = New System.Drawing.Size(82, 24)
        Me.rBLocales.TabIndex = 1
        Me.rBLocales.TabStop = True
        Me.rBLocales.Text = "Locales"
        Me.rBLocales.UseVisualStyleBackColor = True
        '
        'rBForaneos
        '
        Me.rBForaneos.AutoSize = True
        Me.rBForaneos.Location = New System.Drawing.Point(6, 25)
        Me.rBForaneos.Name = "rBForaneos"
        Me.rBForaneos.Size = New System.Drawing.Size(95, 24)
        Me.rBForaneos.TabIndex = 0
        Me.rBForaneos.TabStop = True
        Me.rBForaneos.Text = "Foráneos"
        Me.rBForaneos.UseVisualStyleBackColor = True
        '
        'BitacoraViaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 631)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "BitacoraViaje"
        Me.Text = "Bitácora de viaje"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dGVViajes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dGVBitacora, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents bSalir As System.Windows.Forms.Button
    Friend WithEvents bGuardar As System.Windows.Forms.Button
    Friend WithEvents bCargarInfo As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dGVViajes As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dGVBitacora As System.Windows.Forms.DataGridView
    Friend WithEvents bAgregar As System.Windows.Forms.Button
    Friend WithEvents bEditar As System.Windows.Forms.Button
    Friend WithEvents bCancelar As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rBTodos As System.Windows.Forms.RadioButton
    Friend WithEvents rBLocales As System.Windows.Forms.RadioButton
    Friend WithEvents rBForaneos As System.Windows.Forms.RadioButton
    Friend WithEvents colTipoUnidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStatusViaje As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colUnidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colOperador As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPlacas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colViaje As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colObservaciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNumeroCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDestino As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colContenedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTipoOperacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDireccionEntrega As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colUbicacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cBEstatusViaje As System.Windows.Forms.ComboBox
    Friend WithEvents colNumero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTipoSuceso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSuceso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colObservacionesSuc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bRefrescar As System.Windows.Forms.Button
End Class
