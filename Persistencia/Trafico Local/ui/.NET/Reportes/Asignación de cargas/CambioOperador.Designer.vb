<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CambioOperador
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.tCUnidades = New System.Windows.Forms.TabControl
        Me.tPAltamira = New System.Windows.Forms.TabPage
        Me.dGVAltamira = New System.Windows.Forms.DataGridView
        Me.colId = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colEconomico = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPlacas = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colOperador = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCel = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colFechaVencExamenMedico = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colFechaVencLic = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tPManzanillo = New System.Windows.Forms.TabPage
        Me.dGVManzanillo = New System.Windows.Forms.DataGridView
        Me.colIdMzo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colEconomicoMzo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPlacasMzo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colOperadorMzo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCelMzo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colFechaVencExamenMedicoMzo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colFechaVencLicMzo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tPVeracruz = New System.Windows.Forms.TabPage
        Me.dGVVeracruz = New System.Windows.Forms.DataGridView
        Me.colIdVer = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colEconomicoVer = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPlacasVer = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colOperadorVer = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCelVer = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colFechaVencExamenMedicoVer = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colFechaVencLicVer = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.tCUnidades.SuspendLayout()
        Me.tPAltamira.SuspendLayout()
        CType(Me.dGVAltamira, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tPManzanillo.SuspendLayout()
        CType(Me.dGVManzanillo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tPVeracruz.SuspendLayout()
        CType(Me.dGVVeracruz, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 29)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(319, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seleccione un operador del catálogo"
        '
        'tCUnidades
        '
        Me.tCUnidades.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tCUnidades.Controls.Add(Me.tPAltamira)
        Me.tCUnidades.Controls.Add(Me.tPManzanillo)
        Me.tCUnidades.Controls.Add(Me.tPVeracruz)
        Me.tCUnidades.Location = New System.Drawing.Point(12, 72)
        Me.tCUnidades.Name = "tCUnidades"
        Me.tCUnidades.SelectedIndex = 0
        Me.tCUnidades.Size = New System.Drawing.Size(678, 359)
        Me.tCUnidades.TabIndex = 1
        '
        'tPAltamira
        '
        Me.tPAltamira.Controls.Add(Me.dGVAltamira)
        Me.tPAltamira.Location = New System.Drawing.Point(4, 31)
        Me.tPAltamira.Name = "tPAltamira"
        Me.tPAltamira.Padding = New System.Windows.Forms.Padding(3)
        Me.tPAltamira.Size = New System.Drawing.Size(670, 324)
        Me.tPAltamira.TabIndex = 0
        Me.tPAltamira.Text = "Altamira"
        Me.tPAltamira.UseVisualStyleBackColor = True
        '
        'dGVAltamira
        '
        Me.dGVAltamira.AllowUserToAddRows = False
        Me.dGVAltamira.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dGVAltamira.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dGVAltamira.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dGVAltamira.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colId, Me.colEconomico, Me.colPlacas, Me.colOperador, Me.colCel, Me.colFechaVencExamenMedico, Me.colFechaVencLic})
        Me.dGVAltamira.Location = New System.Drawing.Point(6, 6)
        Me.dGVAltamira.Name = "dGVAltamira"
        Me.dGVAltamira.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dGVAltamira.Size = New System.Drawing.Size(658, 312)
        Me.dGVAltamira.TabIndex = 0
        '
        'colId
        '
        Me.colId.HeaderText = "Id"
        Me.colId.Name = "colId"
        Me.colId.Visible = False
        '
        'colEconomico
        '
        Me.colEconomico.HeaderText = "Económico"
        Me.colEconomico.Name = "colEconomico"
        '
        'colPlacas
        '
        Me.colPlacas.HeaderText = "Placas"
        Me.colPlacas.Name = "colPlacas"
        '
        'colOperador
        '
        Me.colOperador.HeaderText = "Operador"
        Me.colOperador.Name = "colOperador"
        '
        'colCel
        '
        Me.colCel.HeaderText = "Celular asignado"
        Me.colCel.Name = "colCel"
        '
        'colFechaVencExamenMedico
        '
        Me.colFechaVencExamenMedico.HeaderText = "Fecha de vencimiento de examen médico"
        Me.colFechaVencExamenMedico.Name = "colFechaVencExamenMedico"
        '
        'colFechaVencLic
        '
        Me.colFechaVencLic.HeaderText = "Fecha de vencimiento de licencia"
        Me.colFechaVencLic.Name = "colFechaVencLic"
        '
        'tPManzanillo
        '
        Me.tPManzanillo.Controls.Add(Me.dGVManzanillo)
        Me.tPManzanillo.Location = New System.Drawing.Point(4, 31)
        Me.tPManzanillo.Name = "tPManzanillo"
        Me.tPManzanillo.Padding = New System.Windows.Forms.Padding(3)
        Me.tPManzanillo.Size = New System.Drawing.Size(670, 324)
        Me.tPManzanillo.TabIndex = 1
        Me.tPManzanillo.Text = "Manzanillo"
        Me.tPManzanillo.UseVisualStyleBackColor = True
        '
        'dGVManzanillo
        '
        Me.dGVManzanillo.AllowUserToAddRows = False
        Me.dGVManzanillo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dGVManzanillo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dGVManzanillo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dGVManzanillo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colIdMzo, Me.colEconomicoMzo, Me.colPlacasMzo, Me.colOperadorMzo, Me.colCelMzo, Me.colFechaVencExamenMedicoMzo, Me.colFechaVencLicMzo})
        Me.dGVManzanillo.Location = New System.Drawing.Point(6, 6)
        Me.dGVManzanillo.Name = "dGVManzanillo"
        Me.dGVManzanillo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dGVManzanillo.Size = New System.Drawing.Size(658, 312)
        Me.dGVManzanillo.TabIndex = 1
        '
        'colIdMzo
        '
        Me.colIdMzo.HeaderText = "Id"
        Me.colIdMzo.Name = "colIdMzo"
        Me.colIdMzo.Visible = False
        '
        'colEconomicoMzo
        '
        Me.colEconomicoMzo.HeaderText = "Económico"
        Me.colEconomicoMzo.Name = "colEconomicoMzo"
        '
        'colPlacasMzo
        '
        Me.colPlacasMzo.HeaderText = "Placas"
        Me.colPlacasMzo.Name = "colPlacasMzo"
        '
        'colOperadorMzo
        '
        Me.colOperadorMzo.HeaderText = "Operador"
        Me.colOperadorMzo.Name = "colOperadorMzo"
        '
        'colCelMzo
        '
        Me.colCelMzo.HeaderText = "Celular asignado"
        Me.colCelMzo.Name = "colCelMzo"
        '
        'colFechaVencExamenMedicoMzo
        '
        Me.colFechaVencExamenMedicoMzo.HeaderText = "Fecha de vencimiento de examen médico"
        Me.colFechaVencExamenMedicoMzo.Name = "colFechaVencExamenMedicoMzo"
        '
        'colFechaVencLicMzo
        '
        Me.colFechaVencLicMzo.HeaderText = "Fecha de vencimiento de licencia"
        Me.colFechaVencLicMzo.Name = "colFechaVencLicMzo"
        '
        'tPVeracruz
        '
        Me.tPVeracruz.Controls.Add(Me.dGVVeracruz)
        Me.tPVeracruz.Location = New System.Drawing.Point(4, 31)
        Me.tPVeracruz.Name = "tPVeracruz"
        Me.tPVeracruz.Size = New System.Drawing.Size(670, 324)
        Me.tPVeracruz.TabIndex = 2
        Me.tPVeracruz.Text = "Veracruz"
        Me.tPVeracruz.UseVisualStyleBackColor = True
        '
        'dGVVeracruz
        '
        Me.dGVVeracruz.AllowUserToAddRows = False
        Me.dGVVeracruz.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dGVVeracruz.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dGVVeracruz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dGVVeracruz.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colIdVer, Me.colEconomicoVer, Me.colPlacasVer, Me.colOperadorVer, Me.colCelVer, Me.colFechaVencExamenMedicoVer, Me.colFechaVencLicVer})
        Me.dGVVeracruz.Location = New System.Drawing.Point(6, 6)
        Me.dGVVeracruz.Name = "dGVVeracruz"
        Me.dGVVeracruz.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dGVVeracruz.Size = New System.Drawing.Size(658, 312)
        Me.dGVVeracruz.TabIndex = 1
        '
        'colIdVer
        '
        Me.colIdVer.HeaderText = "Id"
        Me.colIdVer.Name = "colIdVer"
        Me.colIdVer.Visible = False
        '
        'colEconomicoVer
        '
        Me.colEconomicoVer.HeaderText = "Económico"
        Me.colEconomicoVer.Name = "colEconomicoVer"
        '
        'colPlacasVer
        '
        Me.colPlacasVer.HeaderText = "Placas"
        Me.colPlacasVer.Name = "colPlacasVer"
        '
        'colOperadorVer
        '
        Me.colOperadorVer.HeaderText = "Operador"
        Me.colOperadorVer.Name = "colOperadorVer"
        '
        'colCelVer
        '
        Me.colCelVer.HeaderText = "Celular asignado"
        Me.colCelVer.Name = "colCelVer"
        '
        'colFechaVencExamenMedicoVer
        '
        Me.colFechaVencExamenMedicoVer.HeaderText = "Fecha de vencimiento de examen médico"
        Me.colFechaVencExamenMedicoVer.Name = "colFechaVencExamenMedicoVer"
        '
        'colFechaVencLicVer
        '
        Me.colFechaVencLicVer.HeaderText = "Fecha de vencimiento de licencia"
        Me.colFechaVencLicVer.Name = "colFechaVencLicVer"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(678, 54)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'CambioOperador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 443)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tCUnidades)
        Me.Font = New System.Drawing.Font("Gadugi", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "CambioOperador"
        Me.Text = "Cambio de operador | Asignación de cargas"
        Me.tCUnidades.ResumeLayout(False)
        Me.tPAltamira.ResumeLayout(False)
        CType(Me.dGVAltamira, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tPManzanillo.ResumeLayout(False)
        CType(Me.dGVManzanillo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tPVeracruz.ResumeLayout(False)
        CType(Me.dGVVeracruz, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tCUnidades As System.Windows.Forms.TabControl
    Friend WithEvents tPAltamira As System.Windows.Forms.TabPage
    Friend WithEvents tPManzanillo As System.Windows.Forms.TabPage
    Friend WithEvents tPVeracruz As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dGVAltamira As System.Windows.Forms.DataGridView
    Friend WithEvents dGVManzanillo As System.Windows.Forms.DataGridView
    Friend WithEvents dGVVeracruz As System.Windows.Forms.DataGridView
    Friend WithEvents colId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEconomico As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPlacas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colOperador As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFechaVencExamenMedico As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFechaVencLic As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colIdMzo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEconomicoMzo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPlacasMzo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colOperadorMzo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCelMzo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFechaVencExamenMedicoMzo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFechaVencLicMzo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colIdVer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEconomicoVer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPlacasVer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colOperadorVer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCelVer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFechaVencExamenMedicoVer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFechaVencLicVer As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
