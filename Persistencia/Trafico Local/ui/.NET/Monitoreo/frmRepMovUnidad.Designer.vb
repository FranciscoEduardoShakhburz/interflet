<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRepMovUnidad
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
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRepMovUnidad))
        Me.gbFiltros = New System.Windows.Forms.GroupBox
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbFecFin = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtUnidad = New System.Windows.Forms.TextBox
        Me.cmbFecIni = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.grdUbicacionUnidad = New System.Windows.Forms.DataGridView
        Me.btnExportar = New System.Windows.Forms.Button
        Me.UPConsultaUbicacionUnidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QFSUbicacion = New Interflet.QFSUbicacion
        Me.UP_Consulta_UbicacionUnidadTableAdapter = New Interflet.QFSUbicacionTableAdapters.UP_Consulta_UbicacionUnidadTableAdapter
        Me.UnidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LatitudeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LongitudDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UbicacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VelocidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Operador = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.gbFiltros.SuspendLayout()
        CType(Me.grdUbicacionUnidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UPConsultaUbicacionUnidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QFSUbicacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()



        Me.gbFiltros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbFiltros.BackColor = System.Drawing.Color.Transparent
        Me.gbFiltros.Controls.Add(Me.btnExportar)
        Me.gbFiltros.Controls.Add(Me.btnBuscar)
        Me.gbFiltros.Controls.Add(Me.Label3)
        Me.gbFiltros.Controls.Add(Me.cmbFecFin)
        Me.gbFiltros.Controls.Add(Me.Label2)
        Me.gbFiltros.Controls.Add(Me.TxtUnidad)
        Me.gbFiltros.Controls.Add(Me.cmbFecIni)
        Me.gbFiltros.Controls.Add(Me.Label1)
        Me.gbFiltros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbFiltros.Location = New System.Drawing.Point(3, 9)
        Me.gbFiltros.Name = "gbFiltros"
        Me.gbFiltros.Size = New System.Drawing.Size(820, 71)
        Me.gbFiltros.TabIndex = 0
        Me.gbFiltros.TabStop = False
        Me.gbFiltros.Text = "Seleccione los parametros de busqueda"



        Me.btnBuscar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnBuscar.Location = New System.Drawing.Point(429, 29)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(88, 24)
        Me.btnBuscar.TabIndex = 6
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False



        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(287, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Fecha Final:"



        Me.cmbFecFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmbFecFin.Location = New System.Drawing.Point(290, 39)
        Me.cmbFecFin.Name = "cmbFecFin"
        Me.cmbFecFin.Size = New System.Drawing.Size(99, 21)
        Me.cmbFecFin.TabIndex = 4



        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(162, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha Inicial:"



        Me.TxtUnidad.Location = New System.Drawing.Point(12, 39)
        Me.TxtUnidad.Name = "TxtUnidad"
        Me.TxtUnidad.Size = New System.Drawing.Size(124, 21)
        Me.TxtUnidad.TabIndex = 2



        Me.cmbFecIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmbFecIni.Location = New System.Drawing.Point(165, 39)
        Me.cmbFecIni.Name = "cmbFecIni"
        Me.cmbFecIni.Size = New System.Drawing.Size(99, 21)
        Me.cmbFecIni.TabIndex = 1



        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Unidad:"



        Me.grdUbicacionUnidad.AllowUserToAddRows = False
        Me.grdUbicacionUnidad.AllowUserToDeleteRows = False
        Me.grdUbicacionUnidad.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray
        Me.grdUbicacionUnidad.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdUbicacionUnidad.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdUbicacionUnidad.AutoGenerateColumns = False
        Me.grdUbicacionUnidad.BackgroundColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdUbicacionUnidad.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grdUbicacionUnidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdUbicacionUnidad.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UnidadDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.LatitudeDataGridViewTextBoxColumn, Me.LongitudDataGridViewTextBoxColumn, Me.UbicacionDataGridViewTextBoxColumn, Me.VelocidadDataGridViewTextBoxColumn, Me.Operador})
        Me.grdUbicacionUnidad.DataSource = Me.UPConsultaUbicacionUnidadBindingSource
        Me.grdUbicacionUnidad.Location = New System.Drawing.Point(3, 86)
        Me.grdUbicacionUnidad.Name = "grdUbicacionUnidad"
        Me.grdUbicacionUnidad.ReadOnly = True
        Me.grdUbicacionUnidad.RowHeadersWidth = 20
        Me.grdUbicacionUnidad.Size = New System.Drawing.Size(820, 615)
        Me.grdUbicacionUnidad.TabIndex = 1



        Me.btnExportar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnExportar.Location = New System.Drawing.Point(545, 30)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(79, 23)
        Me.btnExportar.TabIndex = 7
        Me.btnExportar.Text = "Exportar"
        Me.btnExportar.UseVisualStyleBackColor = False



        Me.UPConsultaUbicacionUnidadBindingSource.DataMember = "UP_Consulta_UbicacionUnidad"
        Me.UPConsultaUbicacionUnidadBindingSource.DataSource = Me.QFSUbicacion



        Me.QFSUbicacion.DataSetName = "QFSUbicacion"
        Me.QFSUbicacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema



        Me.UP_Consulta_UbicacionUnidadTableAdapter.ClearBeforeFill = True



        Me.UnidadDataGridViewTextBoxColumn.DataPropertyName = "Unidad"
        Me.UnidadDataGridViewTextBoxColumn.HeaderText = "Unidad"
        Me.UnidadDataGridViewTextBoxColumn.Name = "UnidadDataGridViewTextBoxColumn"
        Me.UnidadDataGridViewTextBoxColumn.ReadOnly = True
        Me.UnidadDataGridViewTextBoxColumn.Width = 60



        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaDataGridViewTextBoxColumn.Width = 130



        Me.LatitudeDataGridViewTextBoxColumn.DataPropertyName = "latitude"
        Me.LatitudeDataGridViewTextBoxColumn.HeaderText = "latitude"
        Me.LatitudeDataGridViewTextBoxColumn.Name = "LatitudeDataGridViewTextBoxColumn"
        Me.LatitudeDataGridViewTextBoxColumn.ReadOnly = True
        Me.LatitudeDataGridViewTextBoxColumn.Visible = False



        Me.LongitudDataGridViewTextBoxColumn.DataPropertyName = "longitud"
        Me.LongitudDataGridViewTextBoxColumn.HeaderText = "longitud"
        Me.LongitudDataGridViewTextBoxColumn.Name = "LongitudDataGridViewTextBoxColumn"
        Me.LongitudDataGridViewTextBoxColumn.ReadOnly = True
        Me.LongitudDataGridViewTextBoxColumn.Visible = False



        Me.UbicacionDataGridViewTextBoxColumn.DataPropertyName = "Ubicacion"
        Me.UbicacionDataGridViewTextBoxColumn.HeaderText = "Ubicacion"
        Me.UbicacionDataGridViewTextBoxColumn.Name = "UbicacionDataGridViewTextBoxColumn"
        Me.UbicacionDataGridViewTextBoxColumn.ReadOnly = True
        Me.UbicacionDataGridViewTextBoxColumn.Width = 300



        Me.VelocidadDataGridViewTextBoxColumn.DataPropertyName = "Velocidad"
        Me.VelocidadDataGridViewTextBoxColumn.HeaderText = "Velocidad"
        Me.VelocidadDataGridViewTextBoxColumn.Name = "VelocidadDataGridViewTextBoxColumn"
        Me.VelocidadDataGridViewTextBoxColumn.ReadOnly = True
        Me.VelocidadDataGridViewTextBoxColumn.Width = 80



        Me.Operador.DataPropertyName = "Operador"
        Me.Operador.HeaderText = "Operador"
        Me.Operador.Name = "Operador"
        Me.Operador.ReadOnly = True
        Me.Operador.Width = 200



        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(826, 703)
        Me.Controls.Add(Me.grdUbicacionUnidad)
        Me.Controls.Add(Me.gbFiltros)
        Me.Name = "frmRepMovUnidad"
        Me.Text = "Reporte de Movimientos de Unidad"
        Me.gbFiltros.ResumeLayout(False)
        Me.gbFiltros.PerformLayout()
        CType(Me.grdUbicacionUnidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UPConsultaUbicacionUnidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QFSUbicacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbFiltros As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbFecFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtUnidad As System.Windows.Forms.TextBox
    Friend WithEvents cmbFecIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents grdUbicacionUnidad As System.Windows.Forms.DataGridView
    Friend WithEvents UPConsultaUbicacionUnidadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents QFSUbicacion As Interflet.QFSUbicacion
    Friend WithEvents UP_Consulta_UbicacionUnidadTableAdapter As Interflet.QFSUbicacionTableAdapters.UP_Consulta_UbicacionUnidadTableAdapter
    Friend WithEvents btnExportar As System.Windows.Forms.Button
    Friend WithEvents UnidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LatitudeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LongitudDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UbicacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VelocidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Operador As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
