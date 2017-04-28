<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRepViajesEvaluados
    Inherits System.Windows.Forms.Form


    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub


    Private components As System.ComponentModel.IContainer




    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRepViajesEvaluados))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TxtOperador = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtUnidad = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnBuscar2 = New System.Windows.Forms.Button
        Me.TxtSemana = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtViaje = New System.Windows.Forms.MaskedTextBox
        Me.btnExportar = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbFecFin = New System.Windows.Forms.DateTimePicker
        Me.cmbFecIni = New System.Windows.Forms.DateTimePicker
        Me.TxtCliente = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.grdReporte = New System.Windows.Forms.DataGridView
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdReporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()



        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.TxtOperador)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TxtUnidad)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.btnBuscar2)
        Me.GroupBox1.Controls.Add(Me.TxtSemana)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtViaje)
        Me.GroupBox1.Controls.Add(Me.btnExportar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbFecFin)
        Me.GroupBox1.Controls.Add(Me.cmbFecIni)
        Me.GroupBox1.Controls.Add(Me.TxtCliente)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(947, 76)
        Me.GroupBox1.TabIndex = 81
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione una opción de consulta:"



        Me.TxtOperador.Location = New System.Drawing.Point(429, 38)
        Me.TxtOperador.Name = "TxtOperador"
        Me.TxtOperador.Size = New System.Drawing.Size(96, 21)
        Me.TxtOperador.TabIndex = 87



        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(430, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 15)
        Me.Label6.TabIndex = 86
        Me.Label6.Text = "Operador:"



        Me.TxtUnidad.Location = New System.Drawing.Point(358, 38)
        Me.TxtUnidad.Name = "TxtUnidad"
        Me.TxtUnidad.Size = New System.Drawing.Size(64, 21)
        Me.TxtUnidad.TabIndex = 85



        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(356, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 15)
        Me.Label5.TabIndex = 84
        Me.Label5.Text = "Unidad:"



        Me.btnBuscar2.Location = New System.Drawing.Point(758, 31)
        Me.btnBuscar2.Name = "btnBuscar2"
        Me.btnBuscar2.Size = New System.Drawing.Size(82, 33)
        Me.btnBuscar2.TabIndex = 83
        Me.btnBuscar2.Text = "Buscar"
        Me.btnBuscar2.UseVisualStyleBackColor = True



        Me.TxtSemana.Location = New System.Drawing.Point(293, 37)
        Me.TxtSemana.MaxLength = 99
        Me.TxtSemana.Name = "TxtSemana"
        Me.TxtSemana.Size = New System.Drawing.Size(59, 21)
        Me.TxtSemana.TabIndex = 3
        Me.TxtSemana.Text = "0"



        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(293, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 14)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "Semana:"



        Me.TxtViaje.Location = New System.Drawing.Point(13, 38)
        Me.TxtViaje.Mask = "9999999999"
        Me.TxtViaje.Name = "TxtViaje"
        Me.TxtViaje.Size = New System.Drawing.Size(64, 21)
        Me.TxtViaje.TabIndex = 1
        Me.TxtViaje.Text = "0"



        Me.btnExportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
        Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExportar.Location = New System.Drawing.Point(848, 30)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(85, 33)
        Me.btnExportar.TabIndex = 78
        Me.btnExportar.Text = "Exportar"
        Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnExportar.UseVisualStyleBackColor = True



        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(638, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 14)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "Fecha Final:"



        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(529, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 14)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "Fecha Inicial:"



        Me.cmbFecFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmbFecFin.Location = New System.Drawing.Point(641, 38)
        Me.cmbFecFin.Name = "cmbFecFin"
        Me.cmbFecFin.Size = New System.Drawing.Size(100, 21)
        Me.cmbFecFin.TabIndex = 5



        Me.cmbFecIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmbFecIni.Location = New System.Drawing.Point(532, 38)
        Me.cmbFecIni.Name = "cmbFecIni"
        Me.cmbFecIni.Size = New System.Drawing.Size(100, 21)
        Me.cmbFecIni.TabIndex = 4



        Me.TxtCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCliente.Location = New System.Drawing.Point(86, 38)
        Me.TxtCliente.Name = "TxtCliente"
        Me.TxtCliente.Size = New System.Drawing.Size(194, 21)
        Me.TxtCliente.TabIndex = 2



        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(84, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 14)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Cliente:"



        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(7, 23)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(70, 14)
        Me.Label30.TabIndex = 70
        Me.Label30.Text = "# Viaje:"



        Me.grdReporte.AllowUserToAddRows = False
        Me.grdReporte.AllowUserToDeleteRows = False
        Me.grdReporte.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.grdReporte.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdReporte.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.grdReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdReporte.GridColor = System.Drawing.SystemColors.ControlLight
        Me.grdReporte.Location = New System.Drawing.Point(6, 83)
        Me.grdReporte.Name = "grdReporte"
        Me.grdReporte.ReadOnly = True
        Me.grdReporte.RowHeadersWidth = 20
        Me.grdReporte.Size = New System.Drawing.Size(937, 689)
        Me.grdReporte.TabIndex = 82



        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(947, 778)
        Me.Controls.Add(Me.grdReporte)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmRepViajesEvaluados"
        Me.Text = "Reporte de Viajes Evaluados"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grdReporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBuscar2 As System.Windows.Forms.Button
    Friend WithEvents TxtSemana As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtViaje As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnExportar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbFecIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents TxtOperador As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtUnidad As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbFecFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents grdReporte As System.Windows.Forms.DataGridView
End Class
