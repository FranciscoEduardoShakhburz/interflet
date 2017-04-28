<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteViaje
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReporteViaje))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.tBFecRealCliente = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.tBFecProgCliente = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.tBFecRealViaje = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.tBFecProgViaje = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.tCReporte = New System.Windows.Forms.TabControl
        Me.tPDatosViaje = New System.Windows.Forms.TabPage
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.tbOpNegViaje = New System.Windows.Forms.TextBox
        Me.dGVSitios = New System.Windows.Forms.DataGridView
        Me.colSitio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label6 = New System.Windows.Forms.Label
        Me.tBFecLlegOpDA = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.bBuscar = New System.Windows.Forms.Button
        Me.tBNumeroViaje = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.bGuardar = New System.Windows.Forms.Button
        Me.bCerrar = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.tCReporte.SuspendLayout()
        Me.tPDatosViaje.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dGVSitios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tBFecRealCliente)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.tBFecProgCliente)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tBFecRealViaje)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tBFecProgViaje)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(429, 223)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'tBFecRealCliente
        '
        Me.tBFecRealCliente.Location = New System.Drawing.Point(318, 121)
        Me.tBFecRealCliente.Name = "tBFecRealCliente"
        Me.tBFecRealCliente.Size = New System.Drawing.Size(105, 26)
        Me.tBFecRealCliente.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(69, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(241, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Fecha real de llegada con cliente"
        '
        'tBFecProgCliente
        '
        Me.tBFecProgCliente.Location = New System.Drawing.Point(318, 89)
        Me.tBFecProgCliente.Name = "tBFecProgCliente"
        Me.tBFecProgCliente.Size = New System.Drawing.Size(105, 26)
        Me.tBFecProgCliente.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(305, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Fecha programada de llegada con cliente:"
        '
        'tBFecRealViaje
        '
        Me.tBFecRealViaje.Location = New System.Drawing.Point(318, 57)
        Me.tBFecRealViaje.Name = "tBFecRealViaje"
        Me.tBFecRealViaje.Size = New System.Drawing.Size(105, 26)
        Me.tBFecRealViaje.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(108, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(208, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Fecha real de salida de viaje"
        '
        'tBFecProgViaje
        '
        Me.tBFecProgViaje.Location = New System.Drawing.Point(318, 25)
        Me.tBFecProgViaje.Name = "tBFecProgViaje"
        Me.tBFecProgViaje.Size = New System.Drawing.Size(105, 26)
        Me.tBFecProgViaje.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(272, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha programada de salida de viaje:"
        '
        'tCReporte
        '
        Me.tCReporte.Controls.Add(Me.tPDatosViaje)
        Me.tCReporte.Controls.Add(Me.TabPage2)
        Me.tCReporte.Location = New System.Drawing.Point(12, 75)
        Me.tCReporte.Name = "tCReporte"
        Me.tCReporte.SelectedIndex = 0
        Me.tCReporte.Size = New System.Drawing.Size(449, 261)
        Me.tCReporte.TabIndex = 1
        '
        'tPDatosViaje
        '
        Me.tPDatosViaje.Controls.Add(Me.GroupBox1)
        Me.tPDatosViaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tPDatosViaje.Location = New System.Drawing.Point(4, 22)
        Me.tPDatosViaje.Name = "tPDatosViaje"
        Me.tPDatosViaje.Padding = New System.Windows.Forms.Padding(3)
        Me.tPDatosViaje.Size = New System.Drawing.Size(441, 235)
        Me.tPDatosViaje.TabIndex = 0
        Me.tPDatosViaje.Text = "Datos de viaje"
        Me.tPDatosViaje.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(441, 235)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Datos del operador"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.tbOpNegViaje)
        Me.GroupBox2.Controls.Add(Me.dGVSitios)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.tBFecLlegOpDA)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(429, 223)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 194)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(190, 20)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Operador se negó a viajar"
        '
        'tbOpNegViaje
        '
        Me.tbOpNegViaje.Location = New System.Drawing.Point(202, 191)
        Me.tbOpNegViaje.Name = "tbOpNegViaje"
        Me.tbOpNegViaje.Size = New System.Drawing.Size(221, 26)
        Me.tbOpNegViaje.TabIndex = 7
        '
        'dGVSitios
        '
        Me.dGVSitios.AllowUserToAddRows = False
        Me.dGVSitios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dGVSitios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dGVSitios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSitio})
        Me.dGVSitios.Location = New System.Drawing.Point(6, 89)
        Me.dGVSitios.Name = "dGVSitios"
        Me.dGVSitios.Size = New System.Drawing.Size(417, 96)
        Me.dGVSitios.TabIndex = 6
        '
        'colSitio
        '
        Me.colSitio.HeaderText = "Sitio"
        Me.colSitio.Name = "colSitio"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(214, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Paradas en zonas prohibidas"
        '
        'tBFecLlegOpDA
        '
        Me.tBFecLlegOpDA.Location = New System.Drawing.Point(276, 25)
        Me.tBFecLlegOpDA.Name = "tBFecLlegOpDA"
        Me.tBFecLlegOpDA.Size = New System.Drawing.Size(147, 26)
        Me.tBFecLlegOpDA.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Fecha de llegada del operador a DA"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.bBuscar)
        Me.GroupBox3.Controls.Add(Me.tBNumeroViaje)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(449, 57)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'bBuscar
        '
        Me.bBuscar.Image = CType(resources.GetObject("bBuscar.Image"), System.Drawing.Image)
        Me.bBuscar.Location = New System.Drawing.Point(254, 24)
        Me.bBuscar.Name = "bBuscar"
        Me.bBuscar.Size = New System.Drawing.Size(24, 24)
        Me.bBuscar.TabIndex = 7
        Me.bBuscar.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.bBuscar.UseVisualStyleBackColor = True
        '
        'tBNumeroViaje
        '
        Me.tBNumeroViaje.Location = New System.Drawing.Point(139, 25)
        Me.tBNumeroViaje.Name = "tBNumeroViaje"
        Me.tBNumeroViaje.Size = New System.Drawing.Size(109, 26)
        Me.tBNumeroViaje.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(126, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Número de viaje:"
        '
        'bGuardar
        '
        Me.bGuardar.Image = CType(resources.GetObject("bGuardar.Image"), System.Drawing.Image)
        Me.bGuardar.Location = New System.Drawing.Point(375, 342)
        Me.bGuardar.Name = "bGuardar"
        Me.bGuardar.Size = New System.Drawing.Size(40, 40)
        Me.bGuardar.TabIndex = 8
        Me.bGuardar.UseVisualStyleBackColor = True
        '
        'bCerrar
        '
        Me.bCerrar.Image = CType(resources.GetObject("bCerrar.Image"), System.Drawing.Image)
        Me.bCerrar.Location = New System.Drawing.Point(421, 342)
        Me.bCerrar.Name = "bCerrar"
        Me.bCerrar.Size = New System.Drawing.Size(40, 40)
        Me.bCerrar.TabIndex = 9
        Me.bCerrar.UseVisualStyleBackColor = True
        '
        'ReporteViaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 390)
        Me.Controls.Add(Me.bCerrar)
        Me.Controls.Add(Me.bGuardar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.tCReporte)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(481, 428)
        Me.MinimumSize = New System.Drawing.Size(481, 428)
        Me.Name = "ReporteViaje"
        Me.Text = "Reporte de viaje "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tCReporte.ResumeLayout(False)
        Me.tPDatosViaje.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dGVSitios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tBFecProgCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tBFecRealViaje As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tBFecProgViaje As System.Windows.Forms.TextBox
    Friend WithEvents tBFecRealCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tCReporte As System.Windows.Forms.TabControl
    Friend WithEvents tPDatosViaje As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tBFecLlegOpDA As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dGVSitios As System.Windows.Forms.DataGridView
    Friend WithEvents colSitio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbOpNegViaje As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents tBNumeroViaje As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents bBuscar As System.Windows.Forms.Button
    Friend WithEvents bGuardar As System.Windows.Forms.Button
    Friend WithEvents bCerrar As System.Windows.Forms.Button
End Class
