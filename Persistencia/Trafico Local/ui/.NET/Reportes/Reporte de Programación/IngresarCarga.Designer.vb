<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IngresarCarga
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IngresarCarga))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtTipoProg = New System.Windows.Forms.TextBox
        Me.txtTerminal = New System.Windows.Forms.TextBox
        Me.txtAgencia = New System.Windows.Forms.TextBox
        Me.txtCliente = New System.Windows.Forms.TextBox
        Me.txtEntrega2 = New System.Windows.Forms.TextBox
        Me.txtDestino = New System.Windows.Forms.TextBox
        Me.dtePTA = New System.Windows.Forms.DateTimePicker
        Me.dteAlmacenaje = New System.Windows.Forms.DateTimePicker
        Me.dteDemora = New System.Windows.Forms.DateTimePicker
        Me.cmbTipo1 = New System.Windows.Forms.ComboBox
        Me.cmbDesc = New System.Windows.Forms.ComboBox
        Me.cmbViaja = New System.Windows.Forms.ComboBox
        Me.rTxtObservaciones = New System.Windows.Forms.RichTextBox
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.gridContenedores = New System.Windows.Forms.DataGridView
        Me.Contenedor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Peso = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.gridContenedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo de prog."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Terminal:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Agencia:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cliente:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(22, 116)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Viaja de día:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(58, 142)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Desc.:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(314, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Tipo:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(284, 38)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Entrega 2:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(296, 64)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Destino:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(296, 90)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Demora:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(274, 116)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(76, 13)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Almacenaje:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(11, 169)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(91, 13)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Observaciones"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(315, 142)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(35, 13)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "PTA:"
        '
        'txtTipoProg
        '
        Me.txtTipoProg.Location = New System.Drawing.Point(108, 9)
        Me.txtTipoProg.Name = "txtTipoProg"
        Me.txtTipoProg.Size = New System.Drawing.Size(152, 20)
        Me.txtTipoProg.TabIndex = 16
        '
        'txtTerminal
        '
        Me.txtTerminal.Location = New System.Drawing.Point(108, 35)
        Me.txtTerminal.Name = "txtTerminal"
        Me.txtTerminal.Size = New System.Drawing.Size(152, 20)
        Me.txtTerminal.TabIndex = 17
        '
        'txtAgencia
        '
        Me.txtAgencia.Location = New System.Drawing.Point(108, 61)
        Me.txtAgencia.Name = "txtAgencia"
        Me.txtAgencia.Size = New System.Drawing.Size(152, 20)
        Me.txtAgencia.TabIndex = 18
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(108, 87)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(152, 20)
        Me.txtCliente.TabIndex = 19
        '
        'txtEntrega2
        '
        Me.txtEntrega2.Location = New System.Drawing.Point(356, 35)
        Me.txtEntrega2.Name = "txtEntrega2"
        Me.txtEntrega2.Size = New System.Drawing.Size(152, 20)
        Me.txtEntrega2.TabIndex = 26
        '
        'txtDestino
        '
        Me.txtDestino.Location = New System.Drawing.Point(356, 61)
        Me.txtDestino.Name = "txtDestino"
        Me.txtDestino.Size = New System.Drawing.Size(152, 20)
        Me.txtDestino.TabIndex = 27
        '
        'dtePTA
        '
        Me.dtePTA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtePTA.Location = New System.Drawing.Point(356, 138)
        Me.dtePTA.Name = "dtePTA"
        Me.dtePTA.Size = New System.Drawing.Size(152, 20)
        Me.dtePTA.TabIndex = 30
        '
        'dteAlmacenaje
        '
        Me.dteAlmacenaje.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteAlmacenaje.Location = New System.Drawing.Point(356, 112)
        Me.dteAlmacenaje.Name = "dteAlmacenaje"
        Me.dteAlmacenaje.Size = New System.Drawing.Size(152, 20)
        Me.dteAlmacenaje.TabIndex = 29
        '
        'dteDemora
        '
        Me.dteDemora.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteDemora.Location = New System.Drawing.Point(356, 86)
        Me.dteDemora.Name = "dteDemora"
        Me.dteDemora.Size = New System.Drawing.Size(152, 20)
        Me.dteDemora.TabIndex = 28
        '
        'cmbTipo1
        '
        Me.cmbTipo1.FormattingEnabled = True
        Me.cmbTipo1.Items.AddRange(New Object() {"Normal", "Peligrosa"})
        Me.cmbTipo1.Location = New System.Drawing.Point(356, 9)
        Me.cmbTipo1.Name = "cmbTipo1"
        Me.cmbTipo1.Size = New System.Drawing.Size(152, 21)
        Me.cmbTipo1.TabIndex = 25
        '
        'cmbDesc
        '
        Me.cmbDesc.FormattingEnabled = True
        Me.cmbDesc.Items.AddRange(New Object() {"SI", "NO"})
        Me.cmbDesc.Location = New System.Drawing.Point(108, 139)
        Me.cmbDesc.Name = "cmbDesc"
        Me.cmbDesc.Size = New System.Drawing.Size(152, 21)
        Me.cmbDesc.TabIndex = 24
        '
        'cmbViaja
        '
        Me.cmbViaja.FormattingEnabled = True
        Me.cmbViaja.Items.AddRange(New Object() {"SI", "NO"})
        Me.cmbViaja.Location = New System.Drawing.Point(108, 113)
        Me.cmbViaja.Name = "cmbViaja"
        Me.cmbViaja.Size = New System.Drawing.Size(152, 21)
        Me.cmbViaja.TabIndex = 23
        '
        'rTxtObservaciones
        '
        Me.rTxtObservaciones.Location = New System.Drawing.Point(108, 166)
        Me.rTxtObservaciones.MaxLength = 500
        Me.rTxtObservaciones.Name = "rTxtObservaciones"
        Me.rTxtObservaciones.Size = New System.Drawing.Size(400, 141)
        Me.rTxtObservaciones.TabIndex = 31
        Me.rTxtObservaciones.Text = ""
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(124, 365)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(120, 40)
        Me.btnGuardar.TabIndex = 33
        Me.btnGuardar.Text = "   Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(315, 365)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(120, 40)
        Me.btnSalir.TabIndex = 34
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(537, 347)
        Me.TabControl1.TabIndex = 35
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Transparent
        Me.TabPage1.BackgroundImage = CType(resources.GetObject("TabPage1.BackgroundImage"), System.Drawing.Image)
        Me.TabPage1.Controls.Add(Me.dtePTA)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.dteAlmacenaje)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.dteDemora)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.cmbTipo1)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.cmbDesc)
        Me.TabPage1.Controls.Add(Me.cmbViaja)
        Me.TabPage1.Controls.Add(Me.rTxtObservaciones)
        Me.TabPage1.Controls.Add(Me.txtEntrega2)
        Me.TabPage1.Controls.Add(Me.txtTipoProg)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.txtTerminal)
        Me.TabPage1.Controls.Add(Me.txtDestino)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.txtAgencia)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.txtCliente)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(529, 321)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos generales"
        '
        'TabPage2
        '
        Me.TabPage2.BackgroundImage = CType(resources.GetObject("TabPage2.BackgroundImage"), System.Drawing.Image)
        Me.TabPage2.Controls.Add(Me.gridContenedores)
        Me.TabPage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(529, 321)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Contenedores"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'gridContenedores
        '
        Me.gridContenedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridContenedores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Contenedor, Me.Tipo, Me.Peso})
        Me.gridContenedores.Location = New System.Drawing.Point(6, 6)
        Me.gridContenedores.Name = "gridContenedores"
        Me.gridContenedores.Size = New System.Drawing.Size(517, 360)
        Me.gridContenedores.TabIndex = 0
        '
        'Contenedor
        '
        Me.Contenedor.HeaderText = "Num. Contenedor"
        Me.Contenedor.Name = "Contenedor"
        '
        'Tipo
        '
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        '
        'Peso
        '
        Me.Peso.HeaderText = "Peso"
        Me.Peso.Name = "Peso"
        '
        'IngresarCarga
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(565, 411)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "IngresarCarga"
        Me.Text = "Agregar carga de agencia externa | Generar programa"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.gridContenedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtTipoProg As System.Windows.Forms.TextBox
    Friend WithEvents txtTerminal As System.Windows.Forms.TextBox
    Friend WithEvents txtAgencia As System.Windows.Forms.TextBox
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents txtEntrega2 As System.Windows.Forms.TextBox
    Friend WithEvents txtDestino As System.Windows.Forms.TextBox
    Friend WithEvents rTxtObservaciones As System.Windows.Forms.RichTextBox
    Friend WithEvents cmbViaja As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDesc As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTipo1 As System.Windows.Forms.ComboBox
    Friend WithEvents dtePTA As System.Windows.Forms.DateTimePicker
    Friend WithEvents dteAlmacenaje As System.Windows.Forms.DateTimePicker
    Friend WithEvents dteDemora As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents gridContenedores As System.Windows.Forms.DataGridView
    Friend WithEvents Contenedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Peso As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
