<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MonitorUnidadesRuta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MonitorUnidadesRuta))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnExportar = New System.Windows.Forms.Button
        Me.btnRefrescar = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        Me.pBar = New System.Windows.Forms.ProgressBar
        Me.dGVMonitor = New System.Windows.Forms.DataGridView
        Me.colUnidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colFlota = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSitio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDestino = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colStatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colHora = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colAlerta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colHoraAlerta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colEstaEnRuta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colIgnicion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTiempoEstacionada = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTiempoMismoSitio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colObservaciones = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.rTBComentarios = New System.Windows.Forms.RichTextBox
        Me.chBSoloFuera = New System.Windows.Forms.CheckBox
        Me.chBLectura = New System.Windows.Forms.CheckBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.dGVMonitor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnExportar)
        Me.GroupBox1.Controls.Add(Me.btnRefrescar)
        Me.GroupBox1.Controls.Add(Me.btnSalir)
        Me.GroupBox1.Controls.Add(Me.pBar)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(892, 73)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btnExportar
        '
        Me.btnExportar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
        Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportar.Location = New System.Drawing.Point(640, 19)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(120, 40)
        Me.btnExportar.TabIndex = 5
        Me.btnExportar.Text = "   Exportar"
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'btnRefrescar
        '
        Me.btnRefrescar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnRefrescar.Image = CType(resources.GetObject("btnRefrescar.Image"), System.Drawing.Image)
        Me.btnRefrescar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRefrescar.Location = New System.Drawing.Point(514, 19)
        Me.btnRefrescar.Name = "btnRefrescar"
        Me.btnRefrescar.Size = New System.Drawing.Size(120, 40)
        Me.btnRefrescar.TabIndex = 4
        Me.btnRefrescar.Text = "   Refrescar"
        Me.btnRefrescar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(766, 19)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(120, 40)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'pBar
        '
        Me.pBar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pBar.Location = New System.Drawing.Point(6, 19)
        Me.pBar.Name = "pBar"
        Me.pBar.Size = New System.Drawing.Size(502, 40)
        Me.pBar.TabIndex = 2
        '
        'dGVMonitor
        '
        Me.dGVMonitor.AllowUserToAddRows = False
        Me.dGVMonitor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dGVMonitor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dGVMonitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dGVMonitor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colUnidad, Me.colFlota, Me.colSitio, Me.colDestino, Me.colStatus, Me.colHora, Me.colAlerta, Me.colHoraAlerta, Me.colEstaEnRuta, Me.colIgnicion, Me.colTiempoEstacionada, Me.colTiempoMismoSitio, Me.colObservaciones})
        Me.dGVMonitor.Location = New System.Drawing.Point(12, 114)
        Me.dGVMonitor.Name = "dGVMonitor"
        Me.dGVMonitor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dGVMonitor.Size = New System.Drawing.Size(892, 323)
        Me.dGVMonitor.TabIndex = 14
        '
        'colUnidad
        '
        Me.colUnidad.FillWeight = 76.74863!
        Me.colUnidad.HeaderText = "Unidad"
        Me.colUnidad.Name = "colUnidad"
        '
        'colFlota
        '
        Me.colFlota.FillWeight = 64.34692!
        Me.colFlota.HeaderText = "Flota"
        Me.colFlota.Name = "colFlota"
        '
        'colSitio
        '
        Me.colSitio.FillWeight = 237.9467!
        Me.colSitio.HeaderText = "Sitio"
        Me.colSitio.Name = "colSitio"
        '
        'colDestino
        '
        Me.colDestino.FillWeight = 133.5687!
        Me.colDestino.HeaderText = "Destino"
        Me.colDestino.Name = "colDestino"
        '
        'colStatus
        '
        Me.colStatus.FillWeight = 127.9087!
        Me.colStatus.HeaderText = "Status"
        Me.colStatus.Name = "colStatus"
        '
        'colHora
        '
        Me.colHora.FillWeight = 76.19198!
        Me.colHora.HeaderText = "Hora Estatus"
        Me.colHora.Name = "colHora"
        '
        'colAlerta
        '
        Me.colAlerta.FillWeight = 52.37395!
        Me.colAlerta.HeaderText = "Alerta"
        Me.colAlerta.Name = "colAlerta"
        Me.colAlerta.Visible = False
        '
        'colHoraAlerta
        '
        Me.colHoraAlerta.FillWeight = 77.06171!
        Me.colHoraAlerta.HeaderText = "Hora alerta"
        Me.colHoraAlerta.Name = "colHoraAlerta"
        Me.colHoraAlerta.Visible = False
        '
        'colEstaEnRuta
        '
        Me.colEstaEnRuta.FillWeight = 62.67171!
        Me.colEstaEnRuta.HeaderText = "¿Esta en ruta?"
        Me.colEstaEnRuta.Name = "colEstaEnRuta"
        '
        'colIgnicion
        '
        Me.colIgnicion.FillWeight = 62.16628!
        Me.colIgnicion.HeaderText = "Ignición"
        Me.colIgnicion.Name = "colIgnicion"
        '
        'colTiempoEstacionada
        '
        Me.colTiempoEstacionada.FillWeight = 97.48726!
        Me.colTiempoEstacionada.HeaderText = "Tiempo de estacionamiento"
        Me.colTiempoEstacionada.Name = "colTiempoEstacionada"
        '
        'colTiempoMismoSitio
        '
        Me.colTiempoMismoSitio.HeaderText = "Tiempo en mismo sitio"
        Me.colTiempoMismoSitio.Name = "colTiempoMismoSitio"
        Me.colTiempoMismoSitio.ReadOnly = True
        '
        'colObservaciones
        '
        Me.colObservaciones.FillWeight = 156.203!
        Me.colObservaciones.HeaderText = "Observaciones"
        Me.colObservaciones.Name = "colObservaciones"
        '
        'rTBComentarios
        '
        Me.rTBComentarios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rTBComentarios.Font = New System.Drawing.Font("Ubuntu", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rTBComentarios.Location = New System.Drawing.Point(12, 443)
        Me.rTBComentarios.Name = "rTBComentarios"
        Me.rTBComentarios.Size = New System.Drawing.Size(892, 63)
        Me.rTBComentarios.TabIndex = 15
        Me.rTBComentarios.Text = ""
        '
        'chBSoloFuera
        '
        Me.chBSoloFuera.AutoSize = True
        Me.chBSoloFuera.BackColor = System.Drawing.Color.Transparent
        Me.chBSoloFuera.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chBSoloFuera.Location = New System.Drawing.Point(12, 91)
        Me.chBSoloFuera.Name = "chBSoloFuera"
        Me.chBSoloFuera.Size = New System.Drawing.Size(265, 17)
        Me.chBSoloFuera.TabIndex = 16
        Me.chBSoloFuera.Text = "Mostrar solo fuera de ruta y estacionados."
        Me.chBSoloFuera.UseVisualStyleBackColor = False
        '
        'chBLectura
        '
        Me.chBLectura.AutoSize = True
        Me.chBLectura.BackColor = System.Drawing.Color.Transparent
        Me.chBLectura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chBLectura.Location = New System.Drawing.Point(283, 91)
        Me.chBLectura.Name = "chBLectura"
        Me.chBLectura.Size = New System.Drawing.Size(98, 17)
        Me.chBLectura.TabIndex = 17
        Me.chBLectura.Text = "Sólo lectura."
        Me.chBLectura.UseVisualStyleBackColor = False
        '
        'MonitorUnidadesRuta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(916, 519)
        Me.Controls.Add(Me.chBSoloFuera)
        Me.Controls.Add(Me.chBLectura)
        Me.Controls.Add(Me.dGVMonitor)
        Me.Controls.Add(Me.rTBComentarios)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MonitorUnidadesRuta"
        Me.Text = "Monitor de unidades en ruta"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dGVMonitor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents pBar As System.Windows.Forms.ProgressBar
    Friend WithEvents btnExportar As System.Windows.Forms.Button
    Friend WithEvents btnRefrescar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents dGVMonitor As System.Windows.Forms.DataGridView
    Friend WithEvents rTBComentarios As System.Windows.Forms.RichTextBox
    Friend WithEvents chBSoloFuera As System.Windows.Forms.CheckBox
    Friend WithEvents chBLectura As System.Windows.Forms.CheckBox
    Friend WithEvents colUnidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFlota As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSitio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDestino As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHora As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAlerta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHoraAlerta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEstaEnRuta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colIgnicion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTiempoEstacionada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTiempoMismoSitio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colObservaciones As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
