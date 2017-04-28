<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCatCasetas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCatCasetas))
        Me.grdCasetas = New System.Windows.Forms.DataGridView
        Me.IdNumOrigenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdNumDestinoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdNumCasetaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescCasetaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MontoCasetaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdRutaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BitActivoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.FecMovtoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.UserIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.bsCasetas = New System.Windows.Forms.BindingSource(Me.components)
        Me.PI_CatCasetas = New Interflet.ProduccionInterfletdbDataSet8
        Me.bnCasetas = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.btnExportar = New System.Windows.Forms.ToolStripButton
        Me.GuardarToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.Cat_CasetasTableAdapter = New Interflet.ProduccionInterfletdbDataSet8TableAdapters.Cat_CasetasTableAdapter
        Me.gbRuta = New System.Windows.Forms.GroupBox
        Me.cmbDestino = New System.Windows.Forms.ComboBox
        Me.bs_CatDestino = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProduccionInterfletdbDataSet1 = New Interflet.ProduccionInterfletdbDataSet1
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbOrigen = New System.Windows.Forms.ComboBox
        Me.TraficoplazaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProduccionInterfletdbDataSet2 = New Interflet.ProduccionInterfletdbDataSet2
        Me.Label4 = New System.Windows.Forms.Label
        Me.Trafico_plazaTableAdapter = New Interflet.ProduccionInterfletdbDataSet2TableAdapters.trafico_plazaTableAdapter
        Me.Cat_DestinoTableAdapter = New Interflet.ProduccionInterfletdbDataSet1TableAdapters.Cat_DestinoTableAdapter
        Me.Trafico_clienteTableAdapter1 = New Interflet.PI_ClientesTableAdapters.trafico_clienteTableAdapter
        CType(Me.grdCasetas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCasetas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PI_CatCasetas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bnCasetas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnCasetas.SuspendLayout()
        Me.gbRuta.SuspendLayout()
        CType(Me.bs_CatDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProduccionInterfletdbDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TraficoplazaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProduccionInterfletdbDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdCasetas
        '
        Me.grdCasetas.AllowUserToDeleteRows = False
        Me.grdCasetas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdCasetas.AutoGenerateColumns = False
        Me.grdCasetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdCasetas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdNumOrigenDataGridViewTextBoxColumn, Me.IdNumDestinoDataGridViewTextBoxColumn, Me.IdNumCasetaDataGridViewTextBoxColumn, Me.DescCasetaDataGridViewTextBoxColumn, Me.MontoCasetaDataGridViewTextBoxColumn, Me.IdRutaDataGridViewTextBoxColumn, Me.BitActivoDataGridViewCheckBoxColumn, Me.FecMovtoDataGridViewTextBoxColumn, Me.UserIdDataGridViewTextBoxColumn})
        Me.grdCasetas.DataSource = Me.bsCasetas
        Me.grdCasetas.Location = New System.Drawing.Point(3, 91)
        Me.grdCasetas.Name = "grdCasetas"
        Me.grdCasetas.Size = New System.Drawing.Size(505, 365)
        Me.grdCasetas.TabIndex = 0
        '
        'IdNumOrigenDataGridViewTextBoxColumn
        '
        Me.IdNumOrigenDataGridViewTextBoxColumn.DataPropertyName = "Id_Num_Origen"
        Me.IdNumOrigenDataGridViewTextBoxColumn.HeaderText = "Id_Num_Origen"
        Me.IdNumOrigenDataGridViewTextBoxColumn.Name = "IdNumOrigenDataGridViewTextBoxColumn"
        Me.IdNumOrigenDataGridViewTextBoxColumn.Visible = False
        '
        'IdNumDestinoDataGridViewTextBoxColumn
        '
        Me.IdNumDestinoDataGridViewTextBoxColumn.DataPropertyName = "Id_Num_Destino"
        Me.IdNumDestinoDataGridViewTextBoxColumn.HeaderText = "Id_Num_Destino"
        Me.IdNumDestinoDataGridViewTextBoxColumn.Name = "IdNumDestinoDataGridViewTextBoxColumn"
        Me.IdNumDestinoDataGridViewTextBoxColumn.Visible = False
        '
        'IdNumCasetaDataGridViewTextBoxColumn
        '
        Me.IdNumCasetaDataGridViewTextBoxColumn.DataPropertyName = "Id_Num_Caseta"
        Me.IdNumCasetaDataGridViewTextBoxColumn.HeaderText = "Id_Num_Caseta"
        Me.IdNumCasetaDataGridViewTextBoxColumn.Name = "IdNumCasetaDataGridViewTextBoxColumn"
        Me.IdNumCasetaDataGridViewTextBoxColumn.Visible = False
        '
        'DescCasetaDataGridViewTextBoxColumn
        '
        Me.DescCasetaDataGridViewTextBoxColumn.DataPropertyName = "Desc_Caseta"
        Me.DescCasetaDataGridViewTextBoxColumn.HeaderText = "Nombre de Caseta"
        Me.DescCasetaDataGridViewTextBoxColumn.Name = "DescCasetaDataGridViewTextBoxColumn"
        Me.DescCasetaDataGridViewTextBoxColumn.Width = 200
        '
        'MontoCasetaDataGridViewTextBoxColumn
        '
        Me.MontoCasetaDataGridViewTextBoxColumn.DataPropertyName = "Monto_Caseta"
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.MontoCasetaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.MontoCasetaDataGridViewTextBoxColumn.HeaderText = "Costo de Caseta"
        Me.MontoCasetaDataGridViewTextBoxColumn.Name = "MontoCasetaDataGridViewTextBoxColumn"
        Me.MontoCasetaDataGridViewTextBoxColumn.Width = 80
        '
        'IdRutaDataGridViewTextBoxColumn
        '
        Me.IdRutaDataGridViewTextBoxColumn.DataPropertyName = "Id_Ruta"
        Me.IdRutaDataGridViewTextBoxColumn.HeaderText = "Id_Ruta"
        Me.IdRutaDataGridViewTextBoxColumn.Name = "IdRutaDataGridViewTextBoxColumn"
        Me.IdRutaDataGridViewTextBoxColumn.Visible = False
        '
        'BitActivoDataGridViewCheckBoxColumn
        '
        Me.BitActivoDataGridViewCheckBoxColumn.DataPropertyName = "Bit_Activo"
        Me.BitActivoDataGridViewCheckBoxColumn.HeaderText = "Bit_Activo"
        Me.BitActivoDataGridViewCheckBoxColumn.Name = "BitActivoDataGridViewCheckBoxColumn"
        Me.BitActivoDataGridViewCheckBoxColumn.Width = 70
        '
        'FecMovtoDataGridViewTextBoxColumn
        '
        Me.FecMovtoDataGridViewTextBoxColumn.DataPropertyName = "Fec_Movto"
        Me.FecMovtoDataGridViewTextBoxColumn.HeaderText = "Fec_Movto"
        Me.FecMovtoDataGridViewTextBoxColumn.Name = "FecMovtoDataGridViewTextBoxColumn"
        Me.FecMovtoDataGridViewTextBoxColumn.Visible = False
        '
        'UserIdDataGridViewTextBoxColumn
        '
        Me.UserIdDataGridViewTextBoxColumn.DataPropertyName = "UserId"
        Me.UserIdDataGridViewTextBoxColumn.HeaderText = "UserId"
        Me.UserIdDataGridViewTextBoxColumn.Name = "UserIdDataGridViewTextBoxColumn"
        Me.UserIdDataGridViewTextBoxColumn.Visible = False
        '
        'bsCasetas
        '
        Me.bsCasetas.DataMember = "Cat_Casetas"
        Me.bsCasetas.DataSource = Me.PI_CatCasetas
        '
        'PI_CatCasetas
        '
        Me.PI_CatCasetas.DataSetName = "ProduccionInterfletdbDataSet8"
        Me.PI_CatCasetas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'bnCasetas
        '
        Me.bnCasetas.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.bnCasetas.BindingSource = Me.bsCasetas
        Me.bnCasetas.CountItem = Me.BindingNavigatorCountItem
        Me.bnCasetas.DeleteItem = Nothing
        Me.bnCasetas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.btnExportar, Me.GuardarToolStripButton})
        Me.bnCasetas.Location = New System.Drawing.Point(0, 0)
        Me.bnCasetas.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.bnCasetas.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.bnCasetas.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.bnCasetas.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.bnCasetas.Name = "bnCasetas"
        Me.bnCasetas.PositionItem = Me.BindingNavigatorPositionItem
        Me.bnCasetas.Size = New System.Drawing.Size(512, 25)
        Me.bnCasetas.TabIndex = 1
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        Me.BindingNavigatorAddNewItem.ToolTipText = "Nuevo Registro"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnExportar
        '
        Me.btnExportar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
        Me.btnExportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(23, 22)
        Me.btnExportar.Text = "ToolStripButton1"
        '
        'GuardarToolStripButton
        '
        Me.GuardarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GuardarToolStripButton.Image = CType(resources.GetObject("GuardarToolStripButton.Image"), System.Drawing.Image)
        Me.GuardarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GuardarToolStripButton.Name = "GuardarToolStripButton"
        Me.GuardarToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.GuardarToolStripButton.Text = "&Guardar"
        '
        'Cat_CasetasTableAdapter
        '
        Me.Cat_CasetasTableAdapter.ClearBeforeFill = True
        '
        'gbRuta
        '
        Me.gbRuta.Controls.Add(Me.cmbDestino)
        Me.gbRuta.Controls.Add(Me.Label1)
        Me.gbRuta.Controls.Add(Me.cmbOrigen)
        Me.gbRuta.Controls.Add(Me.Label4)
        Me.gbRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbRuta.Location = New System.Drawing.Point(3, 30)
        Me.gbRuta.Name = "gbRuta"
        Me.gbRuta.Size = New System.Drawing.Size(507, 53)
        Me.gbRuta.TabIndex = 14
        Me.gbRuta.TabStop = False
        Me.gbRuta.Text = "Seleccionar Ruta:"
        '
        'cmbDestino
        '
        Me.cmbDestino.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbDestino.DataSource = Me.bs_CatDestino
        Me.cmbDestino.DisplayMember = "Desc_Destino"
        Me.cmbDestino.FormattingEnabled = True
        Me.cmbDestino.Location = New System.Drawing.Point(318, 20)
        Me.cmbDestino.Name = "cmbDestino"
        Me.cmbDestino.Size = New System.Drawing.Size(179, 23)
        Me.cmbDestino.TabIndex = 17
        Me.cmbDestino.ValueMember = "Id_Num_Destino"
        '
        'bs_CatDestino
        '
        Me.bs_CatDestino.DataMember = "Cat_Destino"
        Me.bs_CatDestino.DataSource = Me.ProduccionInterfletdbDataSet1
        '
        'ProduccionInterfletdbDataSet1
        '
        Me.ProduccionInterfletdbDataSet1.DataSetName = "ProduccionInterfletdbDataSet1"
        Me.ProduccionInterfletdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(280, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 15)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Ruta"
        '
        'cmbOrigen
        '
        Me.cmbOrigen.DataSource = Me.TraficoplazaBindingSource
        Me.cmbOrigen.DisplayMember = "desc_plaza"
        Me.cmbOrigen.FormattingEnabled = True
        Me.cmbOrigen.Location = New System.Drawing.Point(95, 20)
        Me.cmbOrigen.Name = "cmbOrigen"
        Me.cmbOrigen.Size = New System.Drawing.Size(179, 23)
        Me.cmbOrigen.TabIndex = 14
        Me.cmbOrigen.ValueMember = "id_plaza"
        '
        'TraficoplazaBindingSource
        '
        Me.TraficoplazaBindingSource.DataMember = "trafico_plaza"
        Me.TraficoplazaBindingSource.DataSource = Me.ProduccionInterfletdbDataSet2
        '
        'ProduccionInterfletdbDataSet2
        '
        Me.ProduccionInterfletdbDataSet2.DataSetName = "ProduccionInterfletdbDataSet2"
        Me.ProduccionInterfletdbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 15)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Plaza Origen"
        '
        'Trafico_plazaTableAdapter
        '
        Me.Trafico_plazaTableAdapter.ClearBeforeFill = True
        '
        'Cat_DestinoTableAdapter
        '
        Me.Cat_DestinoTableAdapter.ClearBeforeFill = True
        '
        'Trafico_clienteTableAdapter1
        '
        Me.Trafico_clienteTableAdapter1.ClearBeforeFill = True
        '
        'frmCatCasetas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 461)
        Me.Controls.Add(Me.gbRuta)
        Me.Controls.Add(Me.bnCasetas)
        Me.Controls.Add(Me.grdCasetas)
        Me.Name = "frmCatCasetas"
        Me.Text = "Catalogo de Casetas de Rutas"
        CType(Me.grdCasetas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCasetas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PI_CatCasetas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bnCasetas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnCasetas.ResumeLayout(False)
        Me.bnCasetas.PerformLayout()
        Me.gbRuta.ResumeLayout(False)
        Me.gbRuta.PerformLayout()
        CType(Me.bs_CatDestino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProduccionInterfletdbDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TraficoplazaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProduccionInterfletdbDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdCasetas As System.Windows.Forms.DataGridView
    Friend WithEvents bsCasetas As System.Windows.Forms.BindingSource
    Friend WithEvents bnCasetas As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PI_CatCasetas As Interflet.ProduccionInterfletdbDataSet8
    Friend WithEvents Cat_CasetasTableAdapter As Interflet.ProduccionInterfletdbDataSet8TableAdapters.Cat_CasetasTableAdapter
    Friend WithEvents gbRuta As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbOrigen As System.Windows.Forms.ComboBox
    Friend WithEvents ProduccionInterfletdbDataSet2 As Interflet.ProduccionInterfletdbDataSet2
    Friend WithEvents TraficoplazaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Trafico_plazaTableAdapter As Interflet.ProduccionInterfletdbDataSet2TableAdapters.trafico_plazaTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbDestino As System.Windows.Forms.ComboBox
    Friend WithEvents ProduccionInterfletdbDataSet1 As Interflet.ProduccionInterfletdbDataSet1
    Friend WithEvents bs_CatDestino As System.Windows.Forms.BindingSource
    Friend WithEvents Cat_DestinoTableAdapter As Interflet.ProduccionInterfletdbDataSet1TableAdapters.Cat_DestinoTableAdapter
    Friend WithEvents IdNumOrigenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdNumDestinoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdNumCasetaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescCasetaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontoCasetaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdRutaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BitActivoDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents FecMovtoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UserIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnExportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents GuardarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents Trafico_clienteTableAdapter1 As Interflet.PI_ClientesTableAdapters.trafico_clienteTableAdapter
End Class
