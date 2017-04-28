<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CapturaEstadias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CapturaEstadias))
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.dGVContenedores = New System.Windows.Forms.DataGridView
        Me.colContenedor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.dGVCP = New System.Windows.Forms.DataGridView
        Me.colCP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtCliente1 = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.txtTipoOper = New System.Windows.Forms.TextBox
        Me.txtDestino = New System.Windows.Forms.TextBox
        Me.txtCliente = New System.Windows.Forms.TextBox
        Me.txtNoViaje = New System.Windows.Forms.TextBox
        Me.txtPlacas = New System.Windows.Forms.TextBox
        Me.txtOperador = New System.Windows.Forms.TextBox
        Me.txtEconomico = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtCargo = New System.Windows.Forms.TextBox
        Me.txtEnviadas = New System.Windows.Forms.TextBox
        Me.txtAutorizadas = New System.Windows.Forms.TextBox
        Me.txtDiasEstadia = New System.Windows.Forms.TextBox
        Me.txtHorasDespues = New System.Windows.Forms.TextBox
        Me.txtHorasLibres = New System.Windows.Forms.TextBox
        Me.txtHorasPlanta = New System.Windows.Forms.TextBox
        Me.txtDias = New System.Windows.Forms.TextBox
        Me.mTBSalida = New System.Windows.Forms.MaskedTextBox
        Me.mTBHoraLlegada = New System.Windows.Forms.MaskedTextBox
        Me.dTPSalidaPlanta = New System.Windows.Forms.DateTimePicker
        Me.dTPLlegadaCliente = New System.Windows.Forms.DateTimePicker
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dGVContenedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dGVCP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(626, 338)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(40, 40)
        Me.btnGuardar.TabIndex = 2
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(672, 338)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(40, 40)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(700, 320)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Gray
        Me.TabPage1.BackgroundImage = CType(resources.GetObject("TabPage1.BackgroundImage"), System.Drawing.Image)
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(692, 294)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos de Viaje"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.dGVContenedores)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(349, 148)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(337, 140)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Contenedores"
        '
        'dGVContenedores
        '
        Me.dGVContenedores.AllowUserToAddRows = False
        Me.dGVContenedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dGVContenedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dGVContenedores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colContenedor})
        Me.dGVContenedores.Location = New System.Drawing.Point(6, 19)
        Me.dGVContenedores.Name = "dGVContenedores"
        Me.dGVContenedores.Size = New System.Drawing.Size(325, 115)
        Me.dGVContenedores.TabIndex = 4
        '
        'colContenedor
        '
        Me.colContenedor.HeaderText = "Contenedor"
        Me.colContenedor.Name = "colContenedor"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.dGVCP)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(6, 148)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(337, 140)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Cartas Porte"
        '
        'dGVCP
        '
        Me.dGVCP.AllowUserToAddRows = False
        Me.dGVCP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dGVCP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dGVCP.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCP})
        Me.dGVCP.Location = New System.Drawing.Point(6, 19)
        Me.dGVCP.Name = "dGVCP"
        Me.dGVCP.Size = New System.Drawing.Size(325, 115)
        Me.dGVCP.TabIndex = 3
        '
        'colCP
        '
        Me.colCP.HeaderText = "C.P."
        Me.colCP.Name = "colCP"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtCliente1)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.txtTipoOper)
        Me.GroupBox1.Controls.Add(Me.txtDestino)
        Me.GroupBox1.Controls.Add(Me.txtCliente)
        Me.GroupBox1.Controls.Add(Me.txtNoViaje)
        Me.GroupBox1.Controls.Add(Me.txtPlacas)
        Me.GroupBox1.Controls.Add(Me.txtOperador)
        Me.GroupBox1.Controls.Add(Me.txtEconomico)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(680, 136)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de viaje"
        '
        'txtCliente1
        '
        Me.txtCliente1.Location = New System.Drawing.Point(423, 23)
        Me.txtCliente1.Name = "txtCliente1"
        Me.txtCliente1.Size = New System.Drawing.Size(251, 20)
        Me.txtCliente1.TabIndex = 19
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(360, 26)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(57, 13)
        Me.Label20.TabIndex = 18
        Me.Label20.Text = "Cliente1:"
        '
        'txtTipoOper
        '
        Me.txtTipoOper.Location = New System.Drawing.Point(423, 101)
        Me.txtTipoOper.Name = "txtTipoOper"
        Me.txtTipoOper.Size = New System.Drawing.Size(251, 20)
        Me.txtTipoOper.TabIndex = 17
        '
        'txtDestino
        '
        Me.txtDestino.Location = New System.Drawing.Point(423, 75)
        Me.txtDestino.Name = "txtDestino"
        Me.txtDestino.Size = New System.Drawing.Size(251, 20)
        Me.txtDestino.TabIndex = 14
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(423, 49)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(251, 20)
        Me.txtCliente.TabIndex = 13
        '
        'txtNoViaje
        '
        Me.txtNoViaje.Location = New System.Drawing.Point(85, 101)
        Me.txtNoViaje.Name = "txtNoViaje"
        Me.txtNoViaje.Size = New System.Drawing.Size(246, 20)
        Me.txtNoViaje.TabIndex = 12
        '
        'txtPlacas
        '
        Me.txtPlacas.Location = New System.Drawing.Point(85, 75)
        Me.txtPlacas.Name = "txtPlacas"
        Me.txtPlacas.Size = New System.Drawing.Size(246, 20)
        Me.txtPlacas.TabIndex = 11
        '
        'txtOperador
        '
        Me.txtOperador.Location = New System.Drawing.Point(85, 49)
        Me.txtOperador.Name = "txtOperador"
        Me.txtOperador.Size = New System.Drawing.Size(246, 20)
        Me.txtOperador.TabIndex = 10
        '
        'txtEconomico
        '
        Me.txtEconomico.Location = New System.Drawing.Point(85, 23)
        Me.txtEconomico.Name = "txtEconomico"
        Me.txtEconomico.Size = New System.Drawing.Size(246, 20)
        Me.txtEconomico.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(359, 104)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "T. Oper.:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(363, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Destino:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(367, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Cliente:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "No. Viaje:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Placas:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Operador:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Económico:"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TabPage2.BackgroundImage = CType(resources.GetObject("TabPage2.BackgroundImage"), System.Drawing.Image)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(692, 294)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Datos de Estadía"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.txtCargo)
        Me.GroupBox2.Controls.Add(Me.txtEnviadas)
        Me.GroupBox2.Controls.Add(Me.txtAutorizadas)
        Me.GroupBox2.Controls.Add(Me.txtDiasEstadia)
        Me.GroupBox2.Controls.Add(Me.txtHorasDespues)
        Me.GroupBox2.Controls.Add(Me.txtHorasLibres)
        Me.GroupBox2.Controls.Add(Me.txtHorasPlanta)
        Me.GroupBox2.Controls.Add(Me.txtDias)
        Me.GroupBox2.Controls.Add(Me.mTBSalida)
        Me.GroupBox2.Controls.Add(Me.mTBHoraLlegada)
        Me.GroupBox2.Controls.Add(Me.dTPSalidaPlanta)
        Me.GroupBox2.Controls.Add(Me.dTPLlegadaCliente)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(7, 79)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(679, 136)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de estadía"
        '
        'txtCargo
        '
        Me.txtCargo.Location = New System.Drawing.Point(600, 48)
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.Size = New System.Drawing.Size(46, 20)
        Me.txtCargo.TabIndex = 21
        Me.txtCargo.Text = "0"
        '
        'txtEnviadas
        '
        Me.txtEnviadas.Location = New System.Drawing.Point(599, 22)
        Me.txtEnviadas.Name = "txtEnviadas"
        Me.txtEnviadas.Size = New System.Drawing.Size(46, 20)
        Me.txtEnviadas.TabIndex = 20
        Me.txtEnviadas.Text = "0"
        '
        'txtAutorizadas
        '
        Me.txtAutorizadas.Location = New System.Drawing.Point(440, 100)
        Me.txtAutorizadas.Name = "txtAutorizadas"
        Me.txtAutorizadas.Size = New System.Drawing.Size(46, 20)
        Me.txtAutorizadas.TabIndex = 19
        Me.txtAutorizadas.Text = "0"
        '
        'txtDiasEstadia
        '
        Me.txtDiasEstadia.Location = New System.Drawing.Point(440, 74)
        Me.txtDiasEstadia.Name = "txtDiasEstadia"
        Me.txtDiasEstadia.Size = New System.Drawing.Size(46, 20)
        Me.txtDiasEstadia.TabIndex = 18
        Me.txtDiasEstadia.Text = "0"
        '
        'txtHorasDespues
        '
        Me.txtHorasDespues.Location = New System.Drawing.Point(440, 48)
        Me.txtHorasDespues.Name = "txtHorasDespues"
        Me.txtHorasDespues.Size = New System.Drawing.Size(46, 20)
        Me.txtHorasDespues.TabIndex = 17
        Me.txtHorasDespues.Text = "0"
        '
        'txtHorasLibres
        '
        Me.txtHorasLibres.Location = New System.Drawing.Point(440, 22)
        Me.txtHorasLibres.Name = "txtHorasLibres"
        Me.txtHorasLibres.Size = New System.Drawing.Size(46, 20)
        Me.txtHorasLibres.TabIndex = 16
        Me.txtHorasLibres.Text = "0"
        '
        'txtHorasPlanta
        '
        Me.txtHorasPlanta.Location = New System.Drawing.Point(135, 99)
        Me.txtHorasPlanta.Name = "txtHorasPlanta"
        Me.txtHorasPlanta.Size = New System.Drawing.Size(100, 20)
        Me.txtHorasPlanta.TabIndex = 15
        Me.txtHorasPlanta.Text = "0"
        '
        'txtDias
        '
        Me.txtDias.Location = New System.Drawing.Point(135, 73)
        Me.txtDias.Name = "txtDias"
        Me.txtDias.Size = New System.Drawing.Size(100, 20)
        Me.txtDias.TabIndex = 14
        Me.txtDias.Text = "0"
        '
        'mTBSalida
        '
        Me.mTBSalida.Location = New System.Drawing.Point(241, 48)
        Me.mTBSalida.Mask = "00:00"
        Me.mTBSalida.Name = "mTBSalida"
        Me.mTBSalida.Size = New System.Drawing.Size(39, 20)
        Me.mTBSalida.TabIndex = 13
        '
        'mTBHoraLlegada
        '
        Me.mTBHoraLlegada.Location = New System.Drawing.Point(241, 22)
        Me.mTBHoraLlegada.Mask = "00:00"
        Me.mTBHoraLlegada.Name = "mTBHoraLlegada"
        Me.mTBHoraLlegada.Size = New System.Drawing.Size(39, 20)
        Me.mTBHoraLlegada.TabIndex = 12
        Me.mTBHoraLlegada.ValidatingType = GetType(Date)
        '
        'dTPSalidaPlanta
        '
        Me.dTPSalidaPlanta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dTPSalidaPlanta.Location = New System.Drawing.Point(135, 47)
        Me.dTPSalidaPlanta.Name = "dTPSalidaPlanta"
        Me.dTPSalidaPlanta.Size = New System.Drawing.Size(100, 20)
        Me.dTPSalidaPlanta.TabIndex = 11
        '
        'dTPLlegadaCliente
        '
        Me.dTPLlegadaCliente.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dTPLlegadaCliente.Location = New System.Drawing.Point(135, 21)
        Me.dTPLlegadaCliente.Name = "dTPLlegadaCliente"
        Me.dTPLlegadaCliente.Size = New System.Drawing.Size(100, 20)
        Me.dTPLlegadaCliente.TabIndex = 10
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(492, 51)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(102, 13)
        Me.Label19.TabIndex = 9
        Me.Label19.Text = "Cgo. En sistema:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(357, 103)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(77, 13)
        Me.Label18.TabIndex = 8
        Me.Label18.Text = "Autorizadas:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(530, 25)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(63, 13)
        Me.Label17.TabIndex = 7
        Me.Label17.Text = "Enviadas:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(331, 76)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(103, 13)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Días de estadía:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(286, 51)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(148, 13)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "Hrs. Después de 12 hrs.:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(362, 25)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 13)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Hrs. Libres:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(28, 102)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(101, 13)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Horas en planta:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(91, 76)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(38, 13)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Días:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(26, 51)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(103, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Salida de planta:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(123, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Llegada con cliente:"
        '
        'CapturaEstadias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(724, 390)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "CapturaEstadias"
        Me.Text = "CapturaEstadias"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dGVContenedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dGVCP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCliente1 As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtTipoOper As System.Windows.Forms.TextBox
    Friend WithEvents txtDestino As System.Windows.Forms.TextBox
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents txtNoViaje As System.Windows.Forms.TextBox
    Friend WithEvents txtPlacas As System.Windows.Forms.TextBox
    Friend WithEvents txtOperador As System.Windows.Forms.TextBox
    Friend WithEvents txtEconomico As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCargo As System.Windows.Forms.TextBox
    Friend WithEvents txtEnviadas As System.Windows.Forms.TextBox
    Friend WithEvents txtAutorizadas As System.Windows.Forms.TextBox
    Friend WithEvents txtDiasEstadia As System.Windows.Forms.TextBox
    Friend WithEvents txtHorasDespues As System.Windows.Forms.TextBox
    Friend WithEvents txtHorasLibres As System.Windows.Forms.TextBox
    Friend WithEvents txtHorasPlanta As System.Windows.Forms.TextBox
    Friend WithEvents txtDias As System.Windows.Forms.TextBox
    Friend WithEvents mTBSalida As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mTBHoraLlegada As System.Windows.Forms.MaskedTextBox
    Friend WithEvents dTPSalidaPlanta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dTPLlegadaCliente As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dGVCP As System.Windows.Forms.DataGridView
    Friend WithEvents dGVContenedores As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents colContenedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCP As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
