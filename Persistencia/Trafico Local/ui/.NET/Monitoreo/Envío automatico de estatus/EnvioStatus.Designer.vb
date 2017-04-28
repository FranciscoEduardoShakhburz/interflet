<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EnvioStatus
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EnvioStatus))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnActualizar = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnEnviar = New System.Windows.Forms.Button
        Me.btnEliminar = New System.Windows.Forms.Button
        Me.btnEditar = New System.Windows.Forms.Button
        Me.btnAgregar = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.dGVUnidades = New System.Windows.Forms.DataGridView
        Me.colUnidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colOperador = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPlacas = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colViaje = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colObservaciones = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colNumeroCliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDestino = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCartaPorte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colContenedores = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTipoOper = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDireccion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCorreos = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colComentarios = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colStatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colUbicacion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSeleccionado = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.sSEstado = New System.Windows.Forms.StatusStrip
        Me.tSSLEst = New System.Windows.Forms.ToolStripStatusLabel
        Me.tSPBProgreso = New System.Windows.Forms.ToolStripProgressBar
        Me.tSSLEstado = New System.Windows.Forms.ToolStripStatusLabel
        Me.chBMarcarTodos = New System.Windows.Forms.CheckBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dGVUnidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sSEstado.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnActualizar)
        Me.GroupBox1.Controls.Add(Me.btnSalir)
        Me.GroupBox1.Controls.Add(Me.btnEnviar)
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Controls.Add(Me.btnEditar)
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Font = New System.Drawing.Font("Ubuntu", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(770, 70)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones"
        '
        'btnActualizar
        '
        Me.btnActualizar.Image = CType(resources.GetObject("btnActualizar.Image"), System.Drawing.Image)
        Me.btnActualizar.Location = New System.Drawing.Point(190, 24)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(40, 40)
        Me.btnActualizar.TabIndex = 5
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(724, 24)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(40, 40)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnEnviar
        '
        Me.btnEnviar.Image = CType(resources.GetObject("btnEnviar.Image"), System.Drawing.Image)
        Me.btnEnviar.Location = New System.Drawing.Point(144, 24)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(40, 40)
        Me.btnEnviar.TabIndex = 3
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.Location = New System.Drawing.Point(98, 24)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(40, 40)
        Me.btnEliminar.TabIndex = 2
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.Location = New System.Drawing.Point(52, 24)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(40, 40)
        Me.btnEditar.TabIndex = 1
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.Location = New System.Drawing.Point(6, 24)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(40, 40)
        Me.btnAgregar.TabIndex = 0
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.dGVUnidades)
        Me.GroupBox2.Font = New System.Drawing.Font("Ubuntu", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 118)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(770, 422)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'dGVUnidades
        '
        Me.dGVUnidades.AllowUserToAddRows = False
        Me.dGVUnidades.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dGVUnidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dGVUnidades.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.dGVUnidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dGVUnidades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colUnidad, Me.colOperador, Me.colPlacas, Me.colViaje, Me.colObservaciones, Me.colNumeroCliente, Me.colCliente, Me.colDestino, Me.colCartaPorte, Me.colContenedores, Me.colTipoOper, Me.colDireccion, Me.colCorreos, Me.colComentarios, Me.colStatus, Me.colUbicacion, Me.colSeleccionado})
        Me.dGVUnidades.GridColor = System.Drawing.SystemColors.GrayText
        Me.dGVUnidades.Location = New System.Drawing.Point(6, 19)
        Me.dGVUnidades.Name = "dGVUnidades"
        Me.dGVUnidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dGVUnidades.Size = New System.Drawing.Size(758, 397)
        Me.dGVUnidades.TabIndex = 0
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
        'colCartaPorte
        '
        Me.colCartaPorte.HeaderText = "Carta porte"
        Me.colCartaPorte.Name = "colCartaPorte"
        '
        'colContenedores
        '
        Me.colContenedores.HeaderText = "Contenedores"
        Me.colContenedores.Name = "colContenedores"
        '
        'colTipoOper
        '
        Me.colTipoOper.HeaderText = "Tipo de oper."
        Me.colTipoOper.Name = "colTipoOper"
        '
        'colDireccion
        '
        Me.colDireccion.HeaderText = "Dirección de entrega"
        Me.colDireccion.Name = "colDireccion"
        '
        'colCorreos
        '
        Me.colCorreos.HeaderText = "Correos"
        Me.colCorreos.Name = "colCorreos"
        '
        'colComentarios
        '
        Me.colComentarios.HeaderText = "Comentarios"
        Me.colComentarios.Name = "colComentarios"
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
        'colSeleccionado
        '
        Me.colSeleccionado.HeaderText = "Seleccionado"
        Me.colSeleccionado.Name = "colSeleccionado"
        Me.colSeleccionado.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colSeleccionado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'sSEstado
        '
        Me.sSEstado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tSSLEst, Me.tSPBProgreso, Me.tSSLEstado})
        Me.sSEstado.Location = New System.Drawing.Point(0, 543)
        Me.sSEstado.Name = "sSEstado"
        Me.sSEstado.Size = New System.Drawing.Size(794, 22)
        Me.sSEstado.TabIndex = 2
        Me.sSEstado.Text = "StatusStrip1"
        '
        'tSSLEst
        '
        Me.tSSLEst.Name = "tSSLEst"
        Me.tSSLEst.Size = New System.Drawing.Size(187, 17)
        Me.tSSLEst.Text = "Sistema Interflet | Envío de estatus | "
        '
        'tSPBProgreso
        '
        Me.tSPBProgreso.Name = "tSPBProgreso"
        Me.tSPBProgreso.Size = New System.Drawing.Size(150, 16)
        '
        'tSSLEstado
        '
        Me.tSSLEstado.Name = "tSSLEstado"
        Me.tSSLEstado.Size = New System.Drawing.Size(33, 17)
        Me.tSSLEstado.Text = "Listo!"
        '
        'chBMarcarTodos
        '
        Me.chBMarcarTodos.AutoSize = True
        Me.chBMarcarTodos.BackColor = System.Drawing.Color.Transparent
        Me.chBMarcarTodos.Font = New System.Drawing.Font("Ubuntu", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chBMarcarTodos.Location = New System.Drawing.Point(12, 88)
        Me.chBMarcarTodos.Name = "chBMarcarTodos"
        Me.chBMarcarTodos.Size = New System.Drawing.Size(122, 24)
        Me.chBMarcarTodos.TabIndex = 3
        Me.chBMarcarTodos.Text = "Marcar todos"
        Me.chBMarcarTodos.UseVisualStyleBackColor = False
        '
        'EnvioStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(794, 565)
        Me.Controls.Add(Me.chBMarcarTodos)
        Me.Controls.Add(Me.sSEstado)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EnvioStatus"
        Me.Text = "Envio de status"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dGVUnidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sSEstado.ResumeLayout(False)
        Me.sSEstado.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnEnviar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dGVUnidades As System.Windows.Forms.DataGridView
    Friend WithEvents sSEstado As System.Windows.Forms.StatusStrip
    Friend WithEvents tSSLEst As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tSPBProgreso As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents tSSLEstado As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents colUnidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colOperador As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPlacas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colViaje As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colObservaciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNumeroCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDestino As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCartaPorte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colContenedores As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTipoOper As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDireccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCorreos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colComentarios As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colUbicacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSeleccionado As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents chBMarcarTodos As System.Windows.Forms.CheckBox
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
End Class
