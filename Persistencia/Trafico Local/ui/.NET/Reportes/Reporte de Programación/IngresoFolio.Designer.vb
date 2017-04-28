<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IngresoFolio
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IngresoFolio))
        Me.grid = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_folio = New System.Windows.Forms.TextBox
        Me.bto_salir = New System.Windows.Forms.Button
        Me.bto_guardar = New System.Windows.Forms.Button
        Me.dteFechaBoleta = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmbMinutoBoleta = New System.Windows.Forms.ComboBox
        Me.cmbHoraBoleta = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Datos = New System.Windows.Forms.TabControl
        Me.tabBoleta = New System.Windows.Forms.TabPage
        Me.tabVisita = New System.Windows.Forms.TabPage
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtBloque = New System.Windows.Forms.TextBox
        Me.txtPlacas = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmbMinutoVisita = New System.Windows.Forms.ComboBox
        Me.txtUnidad = New System.Windows.Forms.TextBox
        Me.cmbHoraVisita = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtOperador = New System.Windows.Forms.TextBox
        Me.dteFechaVisita = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtFolioVisita = New System.Windows.Forms.TextBox
        Me.chkTodos = New System.Windows.Forms.CheckBox
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Datos.SuspendLayout()
        Me.tabBoleta.SuspendLayout()
        Me.tabVisita.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'grid
        '
        Me.grid.AllowUserToAddRows = False
        Me.grid.AllowUserToDeleteRows = False
        Me.grid.AllowUserToOrderColumns = True
        Me.grid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid.DefaultCellStyle = DataGridViewCellStyle6
        Me.grid.Location = New System.Drawing.Point(12, 173)
        Me.grid.Name = "grid"
        Me.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid.Size = New System.Drawing.Size(845, 231)
        Me.grid.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "No. Folio:"
        '
        'txt_folio
        '
        Me.txt_folio.Location = New System.Drawing.Point(74, 28)
        Me.txt_folio.Name = "txt_folio"
        Me.txt_folio.Size = New System.Drawing.Size(101, 20)
        Me.txt_folio.TabIndex = 2
        '
        'bto_salir
        '
        Me.bto_salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bto_salir.Image = CType(resources.GetObject("bto_salir.Image"), System.Drawing.Image)
        Me.bto_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bto_salir.Location = New System.Drawing.Point(8, 118)
        Me.bto_salir.Name = "bto_salir"
        Me.bto_salir.Size = New System.Drawing.Size(120, 40)
        Me.bto_salir.TabIndex = 3
        Me.bto_salir.Text = "Salir"
        Me.bto_salir.UseVisualStyleBackColor = True
        '
        'bto_guardar
        '
        Me.bto_guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bto_guardar.Image = CType(resources.GetObject("bto_guardar.Image"), System.Drawing.Image)
        Me.bto_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bto_guardar.Location = New System.Drawing.Point(8, 56)
        Me.bto_guardar.Name = "bto_guardar"
        Me.bto_guardar.Size = New System.Drawing.Size(120, 40)
        Me.bto_guardar.TabIndex = 4
        Me.bto_guardar.Text = "   Guardar"
        Me.bto_guardar.UseVisualStyleBackColor = True
        '
        'dteFechaBoleta
        '
        Me.dteFechaBoleta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteFechaBoleta.Location = New System.Drawing.Point(233, 27)
        Me.dteFechaBoleta.Name = "dteFechaBoleta"
        Me.dteFechaBoleta.Size = New System.Drawing.Size(95, 20)
        Me.dteFechaBoleta.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(181, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Fecha:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(334, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Hora:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cmbMinutoBoleta)
        Me.GroupBox1.Controls.Add(Me.cmbHoraBoleta)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_folio)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.dteFechaBoleta)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(965, 60)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de boleta"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(428, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(11, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = ":"
        '
        'cmbMinutoBoleta
        '
        Me.cmbMinutoBoleta.FormattingEnabled = True
        Me.cmbMinutoBoleta.Location = New System.Drawing.Point(445, 28)
        Me.cmbMinutoBoleta.Name = "cmbMinutoBoleta"
        Me.cmbMinutoBoleta.Size = New System.Drawing.Size(44, 21)
        Me.cmbMinutoBoleta.TabIndex = 8
        '
        'cmbHoraBoleta
        '
        Me.cmbHoraBoleta.FormattingEnabled = True
        Me.cmbHoraBoleta.Location = New System.Drawing.Point(378, 28)
        Me.cmbHoraBoleta.Name = "cmbHoraBoleta"
        Me.cmbHoraBoleta.Size = New System.Drawing.Size(44, 21)
        Me.cmbHoraBoleta.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.bto_guardar)
        Me.GroupBox2.Controls.Add(Me.bto_salir)
        Me.GroupBox2.Location = New System.Drawing.Point(863, 173)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(134, 231)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        '
        'Datos
        '
        Me.Datos.Controls.Add(Me.tabBoleta)
        Me.Datos.Controls.Add(Me.tabVisita)
        Me.Datos.Location = New System.Drawing.Point(12, 12)
        Me.Datos.Name = "Datos"
        Me.Datos.SelectedIndex = 0
        Me.Datos.Size = New System.Drawing.Size(985, 132)
        Me.Datos.TabIndex = 16
        '
        'tabBoleta
        '
        Me.tabBoleta.AutoScroll = True
        Me.tabBoleta.Controls.Add(Me.GroupBox1)
        Me.tabBoleta.Location = New System.Drawing.Point(4, 22)
        Me.tabBoleta.Name = "tabBoleta"
        Me.tabBoleta.Padding = New System.Windows.Forms.Padding(3)
        Me.tabBoleta.Size = New System.Drawing.Size(977, 106)
        Me.tabBoleta.TabIndex = 0
        Me.tabBoleta.Text = "Boleta"
        Me.tabBoleta.UseVisualStyleBackColor = True
        '
        'tabVisita
        '
        Me.tabVisita.Controls.Add(Me.GroupBox3)
        Me.tabVisita.Location = New System.Drawing.Point(4, 22)
        Me.tabVisita.Name = "tabVisita"
        Me.tabVisita.Padding = New System.Windows.Forms.Padding(3)
        Me.tabVisita.Size = New System.Drawing.Size(977, 106)
        Me.tabVisita.TabIndex = 1
        Me.tabVisita.Text = "Visita"
        Me.tabVisita.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.txtBloque)
        Me.GroupBox3.Controls.Add(Me.txtPlacas)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.cmbMinutoVisita)
        Me.GroupBox3.Controls.Add(Me.txtUnidad)
        Me.GroupBox3.Controls.Add(Me.cmbHoraVisita)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.txtOperador)
        Me.GroupBox3.Controls.Add(Me.dteFechaVisita)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.txtFolioVisita)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(965, 94)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos de visita"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 57)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 13)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Bloque:"
        '
        'txtBloque
        '
        Me.txtBloque.Location = New System.Drawing.Point(70, 54)
        Me.txtBloque.Name = "txtBloque"
        Me.txtBloque.Size = New System.Drawing.Size(101, 20)
        Me.txtBloque.TabIndex = 28
        '
        'txtPlacas
        '
        Me.txtPlacas.Location = New System.Drawing.Point(434, 28)
        Me.txtPlacas.Name = "txtPlacas"
        Me.txtPlacas.Size = New System.Drawing.Size(55, 20)
        Me.txtPlacas.TabIndex = 18
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(379, 31)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 13)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Placas:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(857, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(11, 13)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = ":"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "No. Folio:"
        '
        'cmbMinutoVisita
        '
        Me.cmbMinutoVisita.FormattingEnabled = True
        Me.cmbMinutoVisita.Location = New System.Drawing.Point(874, 28)
        Me.cmbMinutoVisita.Name = "cmbMinutoVisita"
        Me.cmbMinutoVisita.Size = New System.Drawing.Size(44, 21)
        Me.cmbMinutoVisita.TabIndex = 26
        '
        'txtUnidad
        '
        Me.txtUnidad.Location = New System.Drawing.Point(551, 28)
        Me.txtUnidad.Name = "txtUnidad"
        Me.txtUnidad.Size = New System.Drawing.Size(53, 20)
        Me.txtUnidad.TabIndex = 20
        '
        'cmbHoraVisita
        '
        Me.cmbHoraVisita.FormattingEnabled = True
        Me.cmbHoraVisita.Location = New System.Drawing.Point(807, 28)
        Me.cmbHoraVisita.Name = "cmbHoraVisita"
        Me.cmbHoraVisita.Size = New System.Drawing.Size(44, 21)
        Me.cmbHoraVisita.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(494, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Unidad:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(763, 31)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Hora:"
        '
        'txtOperador
        '
        Me.txtOperador.Location = New System.Drawing.Point(246, 28)
        Me.txtOperador.Name = "txtOperador"
        Me.txtOperador.Size = New System.Drawing.Size(127, 20)
        Me.txtOperador.TabIndex = 16
        '
        'dteFechaVisita
        '
        Me.dteFechaVisita.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteFechaVisita.Location = New System.Drawing.Point(662, 27)
        Me.dteFechaVisita.Name = "dteFechaVisita"
        Me.dteFechaVisita.Size = New System.Drawing.Size(95, 20)
        Me.dteFechaVisita.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(177, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Operador:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(610, 31)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Fecha:"
        '
        'txtFolioVisita
        '
        Me.txtFolioVisita.Location = New System.Drawing.Point(70, 28)
        Me.txtFolioVisita.Name = "txtFolioVisita"
        Me.txtFolioVisita.Size = New System.Drawing.Size(101, 20)
        Me.txtFolioVisita.TabIndex = 14
        '
        'chkTodos
        '
        Me.chkTodos.AutoSize = True
        Me.chkTodos.BackColor = System.Drawing.Color.Transparent
        Me.chkTodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTodos.Location = New System.Drawing.Point(12, 150)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Size = New System.Drawing.Size(128, 17)
        Me.chkTodos.TabIndex = 17
        Me.chkTodos.Text = "Seleccionar todos"
        Me.chkTodos.UseVisualStyleBackColor = False
        '
        'IngresoFolio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1009, 416)
        Me.Controls.Add(Me.chkTodos)
        Me.Controls.Add(Me.Datos)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.grid)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "IngresoFolio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Ingreso de Folios | Logística"
        Me.TopMost = True
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.Datos.ResumeLayout(False)
        Me.tabBoleta.ResumeLayout(False)
        Me.tabVisita.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grid As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_folio As System.Windows.Forms.TextBox
    Friend WithEvents bto_salir As System.Windows.Forms.Button
    Friend WithEvents bto_guardar As System.Windows.Forms.Button
    Friend WithEvents dteFechaBoleta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbMinutoBoleta As System.Windows.Forms.ComboBox
    Friend WithEvents cmbHoraBoleta As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Datos As System.Windows.Forms.TabControl
    Friend WithEvents tabBoleta As System.Windows.Forms.TabPage
    Friend WithEvents tabVisita As System.Windows.Forms.TabPage
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtFolioVisita As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtOperador As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtUnidad As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbMinutoVisita As System.Windows.Forms.ComboBox
    Friend WithEvents cmbHoraVisita As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dteFechaVisita As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
    Friend WithEvents txtPlacas As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtBloque As System.Windows.Forms.TextBox
End Class
