<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UnidadesPatio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UnidadesPatio))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dGVUnidades = New System.Windows.Forms.DataGridView
        Me.btnRefrescar = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        Me.etqTotal = New System.Windows.Forms.Label
        Me.etqTractos = New System.Windows.Forms.Label
        Me.btnExportar = New System.Windows.Forms.Button
        Me.colUnidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colRemolque1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDolly = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colRemolque2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSitio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colIgnicion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTiempoEstacionada = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTiempoSitio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.dGVUnidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.dGVUnidades)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(409, 452)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'dGVUnidades
        '
        Me.dGVUnidades.AllowUserToAddRows = False
        Me.dGVUnidades.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dGVUnidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dGVUnidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dGVUnidades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colUnidad, Me.colRemolque1, Me.colDolly, Me.colRemolque2, Me.colSitio, Me.colIgnicion, Me.colTiempoEstacionada, Me.colTiempoSitio})
        Me.dGVUnidades.Location = New System.Drawing.Point(6, 19)
        Me.dGVUnidades.Name = "dGVUnidades"
        Me.dGVUnidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dGVUnidades.Size = New System.Drawing.Size(397, 427)
        Me.dGVUnidades.TabIndex = 0
        '
        'btnRefrescar
        '
        Me.btnRefrescar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefrescar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefrescar.Image = CType(resources.GetObject("btnRefrescar.Image"), System.Drawing.Image)
        Me.btnRefrescar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRefrescar.Location = New System.Drawing.Point(335, 12)
        Me.btnRefrescar.Name = "btnRefrescar"
        Me.btnRefrescar.Size = New System.Drawing.Size(40, 40)
        Me.btnRefrescar.TabIndex = 1
        Me.btnRefrescar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(381, 12)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(40, 40)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'etqTotal
        '
        Me.etqTotal.AutoSize = True
        Me.etqTotal.BackColor = System.Drawing.Color.Transparent
        Me.etqTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etqTotal.Location = New System.Drawing.Point(9, 26)
        Me.etqTotal.Name = "etqTotal"
        Me.etqTotal.Size = New System.Drawing.Size(44, 13)
        Me.etqTotal.TabIndex = 3
        Me.etqTotal.Text = "Total: "
        '
        'etqTractos
        '
        Me.etqTractos.AutoSize = True
        Me.etqTractos.BackColor = System.Drawing.Color.Transparent
        Me.etqTractos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etqTractos.Location = New System.Drawing.Point(52, 26)
        Me.etqTractos.Name = "etqTractos"
        Me.etqTractos.Size = New System.Drawing.Size(69, 13)
        Me.etqTractos.TabIndex = 4
        Me.etqTractos.Text = "   0 tractos"
        '
        'btnExportar
        '
        Me.btnExportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
        Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportar.Location = New System.Drawing.Point(289, 12)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(40, 40)
        Me.btnExportar.TabIndex = 5
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'colUnidad
        '
        Me.colUnidad.HeaderText = "Unidad"
        Me.colUnidad.Name = "colUnidad"
        '
        'colRemolque1
        '
        Me.colRemolque1.HeaderText = "Remolque 1"
        Me.colRemolque1.Name = "colRemolque1"
        '
        'colDolly
        '
        Me.colDolly.HeaderText = "Dolly"
        Me.colDolly.Name = "colDolly"
        '
        'colRemolque2
        '
        Me.colRemolque2.HeaderText = "Remolque 2"
        Me.colRemolque2.Name = "colRemolque2"
        '
        'colSitio
        '
        Me.colSitio.HeaderText = "Sitio"
        Me.colSitio.Name = "colSitio"
        '
        'colIgnicion
        '
        Me.colIgnicion.HeaderText = "Ignicion"
        Me.colIgnicion.Name = "colIgnicion"
        '
        'colTiempoEstacionada
        '
        Me.colTiempoEstacionada.HeaderText = "Tiempo estacionada"
        Me.colTiempoEstacionada.Name = "colTiempoEstacionada"
        '
        'colTiempoSitio
        '
        Me.colTiempoSitio.HeaderText = "Tiempo en sitio"
        Me.colTiempoSitio.Name = "colTiempoSitio"
        '
        'UnidadesPatio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(433, 522)
        Me.Controls.Add(Me.btnExportar)
        Me.Controls.Add(Me.etqTractos)
        Me.Controls.Add(Me.etqTotal)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnRefrescar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "UnidadesPatio"
        Me.Text = "Unidades en patio"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dGVUnidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dGVUnidades As System.Windows.Forms.DataGridView
    Friend WithEvents btnRefrescar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents etqTotal As System.Windows.Forms.Label
    Friend WithEvents etqTractos As System.Windows.Forms.Label
    Friend WithEvents btnExportar As System.Windows.Forms.Button
    Friend WithEvents colUnidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colRemolque1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDolly As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colRemolque2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSitio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colIgnicion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTiempoEstacionada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTiempoSitio As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
