<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteSalidas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReporteSalidas))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.dTPFecha = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.dGVViajes = New System.Windows.Forms.DataGridView
        Me.colFecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colUnidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colOperador = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPlacas = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colViaje = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDestino = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCartaPorte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colContenedores = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colObservaciones = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTipoOp = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colEntregarEn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colRemolque = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDolly = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colHoraDocumentacion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colHoraDocumentosEntregados = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnExportar = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rdBtnPendientes = New System.Windows.Forms.RadioButton
        Me.rdBtnGuardados = New System.Windows.Forms.RadioButton
        Me.btnEliminar = New System.Windows.Forms.Button
        Me.btnEditar = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.dGVViajes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.dTPFecha)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 85)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.Location = New System.Drawing.Point(132, 39)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(25, 25)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'dTPFecha
        '
        Me.dTPFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dTPFecha.Location = New System.Drawing.Point(30, 41)
        Me.dTPFecha.Name = "dTPFecha"
        Me.dTPFecha.Size = New System.Drawing.Size(96, 20)
        Me.dTPFecha.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha de programación"
        '
        'dGVViajes
        '
        Me.dGVViajes.AllowUserToAddRows = False
        Me.dGVViajes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dGVViajes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dGVViajes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dGVViajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dGVViajes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colFecha, Me.colUnidad, Me.colOperador, Me.colPlacas, Me.colViaje, Me.colCliente, Me.colDestino, Me.colCartaPorte, Me.colContenedores, Me.colObservaciones, Me.colTipoOp, Me.colEntregarEn, Me.colRemolque, Me.colDolly, Me.colHoraDocumentacion, Me.colHoraDocumentosEntregados})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dGVViajes.DefaultCellStyle = DataGridViewCellStyle2
        Me.dGVViajes.Location = New System.Drawing.Point(6, 19)
        Me.dGVViajes.Name = "dGVViajes"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dGVViajes.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dGVViajes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dGVViajes.Size = New System.Drawing.Size(876, 365)
        Me.dGVViajes.TabIndex = 2
        '
        'colFecha
        '
        Me.colFecha.HeaderText = "Fecha"
        Me.colFecha.Name = "colFecha"
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
        'colObservaciones
        '
        Me.colObservaciones.HeaderText = "Observaciones"
        Me.colObservaciones.Name = "colObservaciones"
        '
        'colTipoOp
        '
        Me.colTipoOp.HeaderText = "Tipo Op"
        Me.colTipoOp.Name = "colTipoOp"
        '
        'colEntregarEn
        '
        Me.colEntregarEn.HeaderText = "Entregar en"
        Me.colEntregarEn.Name = "colEntregarEn"
        '
        'colRemolque
        '
        Me.colRemolque.HeaderText = "Remolque"
        Me.colRemolque.Name = "colRemolque"
        '
        'colDolly
        '
        Me.colDolly.HeaderText = "Dolly"
        Me.colDolly.Name = "colDolly"
        '
        'colHoraDocumentacion
        '
        Me.colHoraDocumentacion.HeaderText = "Hora de documentación lista"
        Me.colHoraDocumentacion.Name = "colHoraDocumentacion"
        '
        'colHoraDocumentosEntregados
        '
        Me.colHoraDocumentosEntregados.HeaderText = "Hora documentos entregados"
        Me.colHoraDocumentosEntregados.Name = "colHoraDocumentosEntregados"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.dGVViajes)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 103)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(888, 390)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.btnGuardar)
        Me.GroupBox4.Controls.Add(Me.btnSalir)
        Me.GroupBox4.Controls.Add(Me.btnExportar)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(462, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(438, 85)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Opciones de sistema"
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(165, 24)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(40, 40)
        Me.btnGuardar.TabIndex = 3
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(257, 24)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(40, 40)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnExportar
        '
        Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
        Me.btnExportar.Location = New System.Drawing.Point(211, 24)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(40, 40)
        Me.btnExportar.TabIndex = 1
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.rdBtnPendientes)
        Me.GroupBox2.Controls.Add(Me.rdBtnGuardados)
        Me.GroupBox2.Controls.Add(Me.btnEliminar)
        Me.GroupBox2.Controls.Add(Me.btnEditar)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(218, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(238, 85)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Opciones de registros"
        '
        'rdBtnPendientes
        '
        Me.rdBtnPendientes.AutoSize = True
        Me.rdBtnPendientes.Location = New System.Drawing.Point(98, 24)
        Me.rdBtnPendientes.Name = "rdBtnPendientes"
        Me.rdBtnPendientes.Size = New System.Drawing.Size(110, 17)
        Me.rdBtnPendientes.TabIndex = 7
        Me.rdBtnPendientes.TabStop = True
        Me.rdBtnPendientes.Text = "Ver pendientes"
        Me.rdBtnPendientes.UseVisualStyleBackColor = True
        '
        'rdBtnGuardados
        '
        Me.rdBtnGuardados.AutoSize = True
        Me.rdBtnGuardados.Location = New System.Drawing.Point(98, 47)
        Me.rdBtnGuardados.Name = "rdBtnGuardados"
        Me.rdBtnGuardados.Size = New System.Drawing.Size(107, 17)
        Me.rdBtnGuardados.TabIndex = 6
        Me.rdBtnGuardados.TabStop = True
        Me.rdBtnGuardados.Text = "Ver guardados"
        Me.rdBtnGuardados.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.Location = New System.Drawing.Point(52, 24)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(40, 40)
        Me.btnEliminar.TabIndex = 5
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.Location = New System.Drawing.Point(6, 24)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(40, 40)
        Me.btnEditar.TabIndex = 4
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'ReporteSalidas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(912, 505)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ReporteSalidas"
        Me.Text = "Reporte de Salidas | Documentación Interflet"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dGVViajes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dTPFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents dGVViajes As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnExportar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents rdBtnPendientes As System.Windows.Forms.RadioButton
    Friend WithEvents rdBtnGuardados As System.Windows.Forms.RadioButton
    Friend WithEvents colFecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colUnidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colOperador As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPlacas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colViaje As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDestino As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCartaPorte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colContenedores As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colObservaciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTipoOp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEntregarEn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colRemolque As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDolly As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHoraDocumentacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHoraDocumentosEntregados As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
