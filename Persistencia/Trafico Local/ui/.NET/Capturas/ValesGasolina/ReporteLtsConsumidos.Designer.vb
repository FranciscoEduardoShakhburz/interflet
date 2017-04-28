<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteLtsConsumidos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReporteLtsConsumidos))
        Me.dGVVales = New System.Windows.Forms.DataGridView
        Me.colTracto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMarca = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colOperador = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colFecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colNoVale = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCombustible = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colLitros = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtNumVale = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dTPHasta = New System.Windows.Forms.DateTimePicker
        Me.dTPDesde = New System.Windows.Forms.DateTimePicker
        Me.rdBtnNumero = New System.Windows.Forms.RadioButton
        Me.rdBtnFechas = New System.Windows.Forms.RadioButton
        Me.btnIzquierda = New System.Windows.Forms.Button
        Me.btnDerecha = New System.Windows.Forms.Button
        Me.dGVFactura = New System.Windows.Forms.DataGridView
        Me.colNoTracto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMarc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colOpe = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colFec = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colVale = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colComb = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colLts = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCostoPorLt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colImporte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colKilometrajeInicial = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colKilometrajeFinal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colKmsRecorridos = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colRendimiento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtNum = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnExportar = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.dGVVales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dGVFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dGVVales
        '
        Me.dGVVales.AllowUserToAddRows = False
        Me.dGVVales.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dGVVales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dGVVales.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.dGVVales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dGVVales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colTracto, Me.colMarca, Me.colOperador, Me.colFecha, Me.colNoVale, Me.colCombustible, Me.colLitros})
        Me.dGVVales.Location = New System.Drawing.Point(12, 121)
        Me.dGVVales.Name = "dGVVales"
        Me.dGVVales.ReadOnly = True
        Me.dGVVales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dGVVales.Size = New System.Drawing.Size(450, 390)
        Me.dGVVales.TabIndex = 0
        '
        'colTracto
        '
        Me.colTracto.HeaderText = "No. TRACTO"
        Me.colTracto.Name = "colTracto"
        Me.colTracto.ReadOnly = True
        '
        'colMarca
        '
        Me.colMarca.HeaderText = "MARCA"
        Me.colMarca.Name = "colMarca"
        Me.colMarca.ReadOnly = True
        '
        'colOperador
        '
        Me.colOperador.HeaderText = "OPERADOR"
        Me.colOperador.Name = "colOperador"
        Me.colOperador.ReadOnly = True
        '
        'colFecha
        '
        Me.colFecha.HeaderText = "Fecha de consumo"
        Me.colFecha.Name = "colFecha"
        Me.colFecha.ReadOnly = True
        '
        'colNoVale
        '
        Me.colNoVale.HeaderText = "No. Vale"
        Me.colNoVale.Name = "colNoVale"
        Me.colNoVale.ReadOnly = True
        '
        'colCombustible
        '
        Me.colCombustible.HeaderText = "Combustible"
        Me.colCombustible.Name = "colCombustible"
        Me.colCombustible.ReadOnly = True
        '
        'colLitros
        '
        Me.colLitros.HeaderText = "Lts Cargados"
        Me.colLitros.Name = "colLitros"
        Me.colLitros.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtNumVale)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dTPHasta)
        Me.GroupBox1.Controls.Add(Me.dTPDesde)
        Me.GroupBox1.Controls.Add(Me.rdBtnNumero)
        Me.GroupBox1.Controls.Add(Me.rdBtnFechas)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(450, 103)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'txtNumVale
        '
        Me.txtNumVale.Location = New System.Drawing.Point(143, 72)
        Me.txtNumVale.Name = "txtNumVale"
        Me.txtNumVale.Size = New System.Drawing.Size(241, 20)
        Me.txtNumVale.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(244, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Hasta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(95, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Desde"
        '
        'dTPHasta
        '
        Me.dTPHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dTPHasta.Location = New System.Drawing.Point(290, 32)
        Me.dTPHasta.Name = "dTPHasta"
        Me.dTPHasta.Size = New System.Drawing.Size(94, 20)
        Me.dTPHasta.TabIndex = 3
        '
        'dTPDesde
        '
        Me.dTPDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dTPDesde.Location = New System.Drawing.Point(144, 32)
        Me.dTPDesde.Name = "dTPDesde"
        Me.dTPDesde.Size = New System.Drawing.Size(94, 20)
        Me.dTPDesde.TabIndex = 2
        '
        'rdBtnNumero
        '
        Me.rdBtnNumero.AutoSize = True
        Me.rdBtnNumero.Location = New System.Drawing.Point(19, 73)
        Me.rdBtnNumero.Name = "rdBtnNumero"
        Me.rdBtnNumero.Size = New System.Drawing.Size(118, 17)
        Me.rdBtnNumero.TabIndex = 1
        Me.rdBtnNumero.TabStop = True
        Me.rdBtnNumero.Text = "Número de vale:"
        Me.rdBtnNumero.UseVisualStyleBackColor = True
        '
        'rdBtnFechas
        '
        Me.rdBtnFechas.AutoSize = True
        Me.rdBtnFechas.Location = New System.Drawing.Point(19, 34)
        Me.rdBtnFechas.Name = "rdBtnFechas"
        Me.rdBtnFechas.Size = New System.Drawing.Size(70, 17)
        Me.rdBtnFechas.TabIndex = 0
        Me.rdBtnFechas.TabStop = True
        Me.rdBtnFechas.Text = "Fechas:"
        Me.rdBtnFechas.UseVisualStyleBackColor = True
        '
        'btnIzquierda
        '
        Me.btnIzquierda.Image = CType(resources.GetObject("btnIzquierda.Image"), System.Drawing.Image)
        Me.btnIzquierda.Location = New System.Drawing.Point(468, 243)
        Me.btnIzquierda.Name = "btnIzquierda"
        Me.btnIzquierda.Size = New System.Drawing.Size(40, 40)
        Me.btnIzquierda.TabIndex = 2
        Me.btnIzquierda.UseVisualStyleBackColor = True
        '
        'btnDerecha
        '
        Me.btnDerecha.Image = CType(resources.GetObject("btnDerecha.Image"), System.Drawing.Image)
        Me.btnDerecha.Location = New System.Drawing.Point(468, 289)
        Me.btnDerecha.Name = "btnDerecha"
        Me.btnDerecha.Size = New System.Drawing.Size(40, 40)
        Me.btnDerecha.TabIndex = 3
        Me.btnDerecha.UseVisualStyleBackColor = True
        '
        'dGVFactura
        '
        Me.dGVFactura.AllowUserToAddRows = False
        Me.dGVFactura.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dGVFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dGVFactura.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.dGVFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dGVFactura.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNoTracto, Me.colMarc, Me.colOpe, Me.colFec, Me.colVale, Me.colComb, Me.colLts, Me.colCostoPorLt, Me.colImporte, Me.colKilometrajeInicial, Me.colKilometrajeFinal, Me.colKmsRecorridos, Me.colRendimiento})
        Me.dGVFactura.Location = New System.Drawing.Point(514, 121)
        Me.dGVFactura.Name = "dGVFactura"
        Me.dGVFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dGVFactura.Size = New System.Drawing.Size(450, 390)
        Me.dGVFactura.TabIndex = 4
        '
        'colNoTracto
        '
        Me.colNoTracto.HeaderText = "No. TRACTO"
        Me.colNoTracto.Name = "colNoTracto"
        '
        'colMarc
        '
        Me.colMarc.HeaderText = "MARCA"
        Me.colMarc.Name = "colMarc"
        '
        'colOpe
        '
        Me.colOpe.HeaderText = "OPERADOR"
        Me.colOpe.Name = "colOpe"
        '
        'colFec
        '
        Me.colFec.HeaderText = "Fecha de consumo"
        Me.colFec.Name = "colFec"
        '
        'colVale
        '
        Me.colVale.HeaderText = "No. Vale"
        Me.colVale.Name = "colVale"
        '
        'colComb
        '
        Me.colComb.HeaderText = "Combustible"
        Me.colComb.Name = "colComb"
        '
        'colLts
        '
        Me.colLts.HeaderText = "Lts Cargados"
        Me.colLts.Name = "colLts"
        '
        'colCostoPorLt
        '
        Me.colCostoPorLt.HeaderText = "Costo x ltr"
        Me.colCostoPorLt.Name = "colCostoPorLt"
        '
        'colImporte
        '
        Me.colImporte.HeaderText = "Importe total c/IVA"
        Me.colImporte.Name = "colImporte"
        '
        'colKilometrajeInicial
        '
        Me.colKilometrajeInicial.HeaderText = "Kilometraje Inicial"
        Me.colKilometrajeInicial.Name = "colKilometrajeInicial"
        '
        'colKilometrajeFinal
        '
        Me.colKilometrajeFinal.HeaderText = "Kilometraje Final"
        Me.colKilometrajeFinal.Name = "colKilometrajeFinal"
        '
        'colKmsRecorridos
        '
        Me.colKmsRecorridos.HeaderText = "Kms recorridos"
        Me.colKmsRecorridos.Name = "colKmsRecorridos"
        '
        'colRendimiento
        '
        Me.colRendimiento.HeaderText = "Rend Km/Lt"
        Me.colRendimiento.Name = "colRendimiento"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Numero de Factura:"
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(131, 72)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(202, 20)
        Me.txtNum.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.btnExportar)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtNum)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(514, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(450, 103)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        '
        'btnExportar
        '
        Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
        Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportar.Location = New System.Drawing.Point(198, 22)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(120, 40)
        Me.btnExportar.TabIndex = 7
        Me.btnExportar.Text = "   Exportar"
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(324, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 40)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "   Exportar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ReporteLtsConsumidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(976, 523)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dGVFactura)
        Me.Controls.Add(Me.btnDerecha)
        Me.Controls.Add(Me.btnIzquierda)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dGVVales)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ReporteLtsConsumidos"
        Me.Text = "Reporte Lts. Consumidos | Vales de gasolina"
        CType(Me.dGVVales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dGVFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dGVVales As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnIzquierda As System.Windows.Forms.Button
    Friend WithEvents btnDerecha As System.Windows.Forms.Button
    Friend WithEvents dGVFactura As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNum As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dTPHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dTPDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents rdBtnNumero As System.Windows.Forms.RadioButton
    Friend WithEvents rdBtnFechas As System.Windows.Forms.RadioButton
    Friend WithEvents txtNumVale As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents colTracto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMarca As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colOperador As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNoVale As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCombustible As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colLitros As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNoTracto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMarc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colOpe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFec As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colVale As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colComb As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colLts As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCostoPorLt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colImporte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colKilometrajeInicial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colKilometrajeFinal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colKmsRecorridos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colRendimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnExportar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
