<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGastosViaje
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGastosViaje))
        Me.grdGastosViaje = New System.Windows.Forms.DataGridView
        Me.IdNumGastoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescGastoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MontoGastoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ObservacionesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UPConsultaGastosViajeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PI_GastosViaje = New Interflet.PI_GastosViaje
        Me.gbGastos = New System.Windows.Forms.GroupBox
        Me.TxtSuma = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.TxtNoViaje = New System.Windows.Forms.MaskedTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.UP_Consulta_GastosViajeTableAdapter = New Interflet.PI_GastosViajeTableAdapters.UP_Consulta_GastosViajeTableAdapter
        CType(Me.grdGastosViaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UPConsultaGastosViajeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PI_GastosViaje, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbGastos.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdGastosViaje
        '
        Me.grdGastosViaje.AllowUserToAddRows = False
        Me.grdGastosViaje.AllowUserToDeleteRows = False
        Me.grdGastosViaje.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        Me.grdGastosViaje.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdGastosViaje.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdGastosViaje.AutoGenerateColumns = False
        Me.grdGastosViaje.BackgroundColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdGastosViaje.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grdGastosViaje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdGastosViaje.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdNumGastoDataGridViewTextBoxColumn, Me.DescGastoDataGridViewTextBoxColumn, Me.MontoGastoDataGridViewTextBoxColumn, Me.ObservacionesDataGridViewTextBoxColumn})
        Me.grdGastosViaje.DataSource = Me.UPConsultaGastosViajeBindingSource
        Me.grdGastosViaje.Location = New System.Drawing.Point(6, 64)
        Me.grdGastosViaje.Name = "grdGastosViaje"
        Me.grdGastosViaje.RowHeadersVisible = False
        Me.grdGastosViaje.RowHeadersWidth = 35
        Me.grdGastosViaje.Size = New System.Drawing.Size(405, 305)
        Me.grdGastosViaje.TabIndex = 0
        '
        'IdNumGastoDataGridViewTextBoxColumn
        '
        Me.IdNumGastoDataGridViewTextBoxColumn.DataPropertyName = "Id_Num_Gasto"
        Me.IdNumGastoDataGridViewTextBoxColumn.HeaderText = "Id_Num_Gasto"
        Me.IdNumGastoDataGridViewTextBoxColumn.Name = "IdNumGastoDataGridViewTextBoxColumn"
        Me.IdNumGastoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdNumGastoDataGridViewTextBoxColumn.Visible = False
        Me.IdNumGastoDataGridViewTextBoxColumn.Width = 5
        '
        'DescGastoDataGridViewTextBoxColumn
        '
        Me.DescGastoDataGridViewTextBoxColumn.DataPropertyName = "Desc_Gasto"
        Me.DescGastoDataGridViewTextBoxColumn.HeaderText = "Gasto"
        Me.DescGastoDataGridViewTextBoxColumn.Name = "DescGastoDataGridViewTextBoxColumn"
        Me.DescGastoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MontoGastoDataGridViewTextBoxColumn
        '
        Me.MontoGastoDataGridViewTextBoxColumn.DataPropertyName = "Monto_Gasto"
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.MontoGastoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.MontoGastoDataGridViewTextBoxColumn.HeaderText = "Monto"
        Me.MontoGastoDataGridViewTextBoxColumn.Name = "MontoGastoDataGridViewTextBoxColumn"
        Me.MontoGastoDataGridViewTextBoxColumn.Width = 80
        '
        'ObservacionesDataGridViewTextBoxColumn
        '
        Me.ObservacionesDataGridViewTextBoxColumn.DataPropertyName = "Observaciones"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.ObservacionesDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.ObservacionesDataGridViewTextBoxColumn.HeaderText = "Observaciones"
        Me.ObservacionesDataGridViewTextBoxColumn.Name = "ObservacionesDataGridViewTextBoxColumn"
        Me.ObservacionesDataGridViewTextBoxColumn.Width = 180
        '
        'UPConsultaGastosViajeBindingSource
        '
        Me.UPConsultaGastosViajeBindingSource.DataMember = "UP_Consulta_GastosViaje"
        Me.UPConsultaGastosViajeBindingSource.DataSource = Me.PI_GastosViaje
        '
        'PI_GastosViaje
        '
        Me.PI_GastosViaje.DataSetName = "PI_GastosViaje"
        Me.PI_GastosViaje.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gbGastos
        '
        Me.gbGastos.BackColor = System.Drawing.Color.Transparent
        Me.gbGastos.Controls.Add(Me.TxtSuma)
        Me.gbGastos.Controls.Add(Me.Label4)
        Me.gbGastos.Controls.Add(Me.btnGuardar)
        Me.gbGastos.Controls.Add(Me.TxtNoViaje)
        Me.gbGastos.Controls.Add(Me.Label1)
        Me.gbGastos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbGastos.Location = New System.Drawing.Point(6, 8)
        Me.gbGastos.Name = "gbGastos"
        Me.gbGastos.Size = New System.Drawing.Size(405, 50)
        Me.gbGastos.TabIndex = 14
        Me.gbGastos.TabStop = False
        Me.gbGastos.Text = "Gastos de Viaje"
        '
        'TxtSuma
        '
        Me.TxtSuma.Enabled = False
        Me.TxtSuma.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSuma.Location = New System.Drawing.Point(210, 21)
        Me.TxtSuma.Name = "TxtSuma"
        Me.TxtSuma.Size = New System.Drawing.Size(76, 21)
        Me.TxtSuma.TabIndex = 15
        Me.TxtSuma.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(164, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 15)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Suma:"
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(307, 14)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(77, 22)
        Me.btnGuardar.TabIndex = 14
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'TxtNoViaje
        '
        Me.TxtNoViaje.Location = New System.Drawing.Point(82, 21)
        Me.TxtNoViaje.Mask = "9999999999"
        Me.TxtNoViaje.Name = "TxtNoViaje"
        Me.TxtNoViaje.Size = New System.Drawing.Size(72, 21)
        Me.TxtNoViaje.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "No. Viaje:"
        '
        'UP_Consulta_GastosViajeTableAdapter
        '
        Me.UP_Consulta_GastosViajeTableAdapter.ClearBeforeFill = True
        '
        'frmGastosViaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(417, 378)
        Me.Controls.Add(Me.gbGastos)
        Me.Controls.Add(Me.grdGastosViaje)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmGastosViaje"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gastos del Viaje"
        CType(Me.grdGastosViaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UPConsultaGastosViajeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PI_GastosViaje, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbGastos.ResumeLayout(False)
        Me.gbGastos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grdGastosViaje As System.Windows.Forms.DataGridView
    Friend WithEvents gbGastos As System.Windows.Forms.GroupBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents TxtNoViaje As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UPConsultaGastosViajeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PI_GastosViaje As Interflet.PI_GastosViaje
    Friend WithEvents UP_Consulta_GastosViajeTableAdapter As Interflet.PI_GastosViajeTableAdapters.UP_Consulta_GastosViajeTableAdapter
    Friend WithEvents TxtSuma As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents IdNumGastoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescGastoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontoGastoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ObservacionesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
