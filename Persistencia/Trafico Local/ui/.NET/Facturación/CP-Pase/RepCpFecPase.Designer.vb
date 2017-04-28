<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepCpFecPase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RepCpFecPase))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.dGVCP = New System.Windows.Forms.DataGridView
        Me.colFPase = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colImpreso = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.dTPHasta = New System.Windows.Forms.DateTimePicker
        Me.dTPDesde = New System.Windows.Forms.DateTimePicker
        Me.cBSucursal = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnExportar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.dGVCP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.dGVCP)
        Me.GroupBox1.Controls.Add(Me.dTPHasta)
        Me.GroupBox1.Controls.Add(Me.dTPDesde)
        Me.GroupBox1.Controls.Add(Me.cBSucursal)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(444, 278)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones de reporte"
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.Location = New System.Drawing.Point(398, 19)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(40, 40)
        Me.btnBuscar.TabIndex = 3
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'dGVCP
        '
        Me.dGVCP.AllowUserToAddRows = False
        Me.dGVCP.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dGVCP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dGVCP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dGVCP.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colFPase, Me.colCP, Me.colImpreso})
        Me.dGVCP.Location = New System.Drawing.Point(9, 66)
        Me.dGVCP.Name = "dGVCP"
        Me.dGVCP.Size = New System.Drawing.Size(429, 206)
        Me.dGVCP.TabIndex = 6
        '
        'colFPase
        '
        Me.colFPase.HeaderText = "Fecha de pase"
        Me.colFPase.Name = "colFPase"
        '
        'colCP
        '
        Me.colCP.HeaderText = "Carta porte"
        Me.colCP.Name = "colCP"
        '
        'colImpreso
        '
        Me.colImpreso.HeaderText = "Impreso"
        Me.colImpreso.Name = "colImpreso"
        Me.colImpreso.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colImpreso.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'dTPHasta
        '
        Me.dTPHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dTPHasta.Location = New System.Drawing.Point(100, 36)
        Me.dTPHasta.Name = "dTPHasta"
        Me.dTPHasta.Size = New System.Drawing.Size(88, 20)
        Me.dTPHasta.TabIndex = 5
        '
        'dTPDesde
        '
        Me.dTPDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dTPDesde.Location = New System.Drawing.Point(6, 36)
        Me.dTPDesde.Name = "dTPDesde"
        Me.dTPDesde.Size = New System.Drawing.Size(88, 20)
        Me.dTPDesde.TabIndex = 4
        '
        'cBSucursal
        '
        Me.cBSucursal.FormattingEnabled = True
        Me.cBSucursal.Items.AddRange(New Object() {"ALTAMIRA", "MANZANILLO", "VERACRUZ", "TODAS"})
        Me.cBSucursal.Location = New System.Drawing.Point(194, 35)
        Me.cBSucursal.Name = "cBSucursal"
        Me.cBSucursal.Size = New System.Drawing.Size(182, 25)
        Me.cBSucursal.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(191, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Sucursal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(97, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Hasta:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Desde:"
        '
        'btnExportar
        '
        Me.btnExportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
        Me.btnExportar.Location = New System.Drawing.Point(58, 296)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(40, 40)
        Me.btnExportar.TabIndex = 1
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(104, 296)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(40, 40)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(12, 296)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(40, 40)
        Me.btnGuardar.TabIndex = 3
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'RepCpFecPase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(468, 348)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnExportar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "RepCpFecPase"
        Me.Text = "Cp con F. Pase"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dGVCP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dTPHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dTPDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents cBSucursal As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnExportar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents dGVCP As System.Windows.Forms.DataGridView
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents colFPase As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colImpreso As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
End Class
