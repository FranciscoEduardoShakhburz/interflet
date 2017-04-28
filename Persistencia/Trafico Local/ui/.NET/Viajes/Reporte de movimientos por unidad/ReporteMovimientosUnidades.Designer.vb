<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteMovimientosUnidades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReporteMovimientosUnidades))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.tBUnidad = New System.Windows.Forms.TextBox
        Me.dTPHasta = New System.Windows.Forms.DateTimePicker
        Me.dTPDesde = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.bSalir = New System.Windows.Forms.Button
        Me.bExportar = New System.Windows.Forms.Button
        Me.bConsultar = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.dGVInfo = New System.Windows.Forms.DataGridView
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dGVInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tBUnidad)
        Me.GroupBox1.Controls.Add(Me.dTPHasta)
        Me.GroupBox1.Controls.Add(Me.dTPDesde)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.bSalir)
        Me.GroupBox1.Controls.Add(Me.bExportar)
        Me.GroupBox1.Controls.Add(Me.bConsultar)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 14)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Size = New System.Drawing.Size(698, 116)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de consulta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 78)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 23)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Unidad:"
        '
        'tBUnidad
        '
        Me.tBUnidad.Location = New System.Drawing.Point(91, 75)
        Me.tBUnidad.Margin = New System.Windows.Forms.Padding(5)
        Me.tBUnidad.Name = "tBUnidad"
        Me.tBUnidad.Size = New System.Drawing.Size(156, 31)
        Me.tBUnidad.TabIndex = 7
        '
        'dTPHasta
        '
        Me.dTPHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dTPHasta.Location = New System.Drawing.Point(328, 34)
        Me.dTPHasta.Margin = New System.Windows.Forms.Padding(5)
        Me.dTPHasta.Name = "dTPHasta"
        Me.dTPHasta.Size = New System.Drawing.Size(156, 31)
        Me.dTPHasta.TabIndex = 6
        '
        'dTPDesde
        '
        Me.dTPDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dTPDesde.Location = New System.Drawing.Point(91, 34)
        Me.dTPDesde.Margin = New System.Windows.Forms.Padding(5)
        Me.dTPDesde.Name = "dTPDesde"
        Me.dTPDesde.Size = New System.Drawing.Size(156, 31)
        Me.dTPDesde.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(257, 44)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Hasta:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 44)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Desde:"
        '
        'bSalir
        '
        Me.bSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bSalir.Image = CType(resources.GetObject("bSalir.Image"), System.Drawing.Image)
        Me.bSalir.Location = New System.Drawing.Point(648, 34)
        Me.bSalir.Margin = New System.Windows.Forms.Padding(5)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(40, 40)
        Me.bSalir.TabIndex = 2
        Me.bSalir.UseVisualStyleBackColor = True
        '
        'bExportar
        '
        Me.bExportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bExportar.Image = CType(resources.GetObject("bExportar.Image"), System.Drawing.Image)
        Me.bExportar.Location = New System.Drawing.Point(598, 34)
        Me.bExportar.Margin = New System.Windows.Forms.Padding(5)
        Me.bExportar.Name = "bExportar"
        Me.bExportar.Size = New System.Drawing.Size(40, 40)
        Me.bExportar.TabIndex = 1
        Me.bExportar.UseVisualStyleBackColor = True
        '
        'bConsultar
        '
        Me.bConsultar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bConsultar.Image = CType(resources.GetObject("bConsultar.Image"), System.Drawing.Image)
        Me.bConsultar.Location = New System.Drawing.Point(548, 34)
        Me.bConsultar.Margin = New System.Windows.Forms.Padding(5)
        Me.bConsultar.Name = "bConsultar"
        Me.bConsultar.Size = New System.Drawing.Size(40, 40)
        Me.bConsultar.TabIndex = 0
        Me.bConsultar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.dGVInfo)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 140)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox2.Size = New System.Drawing.Size(698, 308)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'dGVInfo
        '
        Me.dGVInfo.AllowUserToAddRows = False
        Me.dGVInfo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dGVInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dGVInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        Me.dGVInfo.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.dGVInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dGVInfo.Location = New System.Drawing.Point(10, 34)
        Me.dGVInfo.Margin = New System.Windows.Forms.Padding(5)
        Me.dGVInfo.Name = "dGVInfo"
        Me.dGVInfo.ReadOnly = True
        Me.dGVInfo.Size = New System.Drawing.Size(676, 263)
        Me.dGVInfo.TabIndex = 0
        '
        'ReporteMovimientosUnidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(726, 462)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "ReporteMovimientosUnidades"
        Me.Text = "Reporte de movimientos de unidades"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dGVInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents bSalir As System.Windows.Forms.Button
    Friend WithEvents bExportar As System.Windows.Forms.Button
    Friend WithEvents bConsultar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dGVInfo As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tBUnidad As System.Windows.Forms.TextBox
    Friend WithEvents dTPHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dTPDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
