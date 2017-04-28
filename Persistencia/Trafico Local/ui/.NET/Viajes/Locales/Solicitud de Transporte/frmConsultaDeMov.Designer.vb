<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaDeMov
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultaDeMov))
        Me.grid_datos = New System.Windows.Forms.DataGridView
        Me.cmb_movimiento = New System.Windows.Forms.ComboBox
        Me.bto_consultar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_unidad = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtp_de = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Time = New System.Windows.Forms.Timer(Me.components)
        Me.bto_automatico = New System.Windows.Forms.Button
        Me.bto_ahora = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.grid_datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'grid_datos
        '
        Me.grid_datos.AllowUserToAddRows = False
        Me.grid_datos.AllowUserToDeleteRows = False
        Me.grid_datos.AllowUserToOrderColumns = True
        Me.grid_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_datos.Location = New System.Drawing.Point(12, 12)
        Me.grid_datos.Name = "grid_datos"
        Me.grid_datos.ReadOnly = True
        Me.grid_datos.Size = New System.Drawing.Size(797, 150)
        Me.grid_datos.TabIndex = 0
        '
        'cmb_movimiento
        '
        Me.cmb_movimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_movimiento.FormattingEnabled = True
        Me.cmb_movimiento.Items.AddRange(New Object() {"Traslado", "Reexpedicion", "Directo", "Planta", "Entrega de Vacio"})
        Me.cmb_movimiento.Location = New System.Drawing.Point(128, 189)
        Me.cmb_movimiento.Name = "cmb_movimiento"
        Me.cmb_movimiento.Size = New System.Drawing.Size(131, 21)
        Me.cmb_movimiento.TabIndex = 1
        '
        'bto_consultar
        '
        Me.bto_consultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bto_consultar.Location = New System.Drawing.Point(6, 10)
        Me.bto_consultar.Name = "bto_consultar"
        Me.bto_consultar.Size = New System.Drawing.Size(90, 50)
        Me.bto_consultar.TabIndex = 2
        Me.bto_consultar.Text = "Consultar"
        Me.bto_consultar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 192)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Tipo de Movimiento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(265, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Unidad"
        '
        'txt_unidad
        '
        Me.txt_unidad.Location = New System.Drawing.Point(318, 189)
        Me.txt_unidad.Name = "txt_unidad"
        Me.txt_unidad.Size = New System.Drawing.Size(100, 20)
        Me.txt_unidad.TabIndex = 5
        Me.txt_unidad.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "DE:"
        '
        'dtp_de
        '
        Me.dtp_de.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_de.Location = New System.Drawing.Point(40, 21)
        Me.dtp_de.Name = "dtp_de"
        Me.dtp_de.Size = New System.Drawing.Size(91, 20)
        Me.dtp_de.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(148, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(19, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "A:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(173, 21)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(97, 20)
        Me.DateTimePicker1.TabIndex = 10
        '
        'Time
        '
        Me.Time.Enabled = True
        Me.Time.Interval = 48000
        '
        'bto_automatico
        '
        Me.bto_automatico.Enabled = False
        Me.bto_automatico.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bto_automatico.Location = New System.Drawing.Point(6, 122)
        Me.bto_automatico.Name = "bto_automatico"
        Me.bto_automatico.Size = New System.Drawing.Size(90, 50)
        Me.bto_automatico.TabIndex = 11
        Me.bto_automatico.Text = "Automatico"
        Me.bto_automatico.UseVisualStyleBackColor = True
        '
        'bto_ahora
        '
        Me.bto_ahora.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bto_ahora.Location = New System.Drawing.Point(6, 66)
        Me.bto_ahora.Name = "bto_ahora"
        Me.bto_ahora.Size = New System.Drawing.Size(90, 50)
        Me.bto_ahora.TabIndex = 12
        Me.bto_ahora.Text = "Ahora"
        Me.bto_ahora.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.bto_consultar)
        Me.GroupBox1.Controls.Add(Me.bto_ahora)
        Me.GroupBox1.Controls.Add(Me.bto_automatico)
        Me.GroupBox1.Location = New System.Drawing.Point(819, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(102, 233)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.dtp_de)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(444, 168)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(282, 58)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Rango de Fechas"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(6, 178)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 50)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmConsultaDeMov
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(933, 242)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txt_unidad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_movimiento)
        Me.Controls.Add(Me.grid_datos)
        Me.Name = "frmConsultaDeMov"
        Me.Text = "Consulta de Tiempos"
        CType(Me.grid_datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grid_datos As System.Windows.Forms.DataGridView
    Friend WithEvents cmb_movimiento As System.Windows.Forms.ComboBox
    Friend WithEvents bto_consultar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_unidad As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtp_de As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Time As System.Windows.Forms.Timer
    Friend WithEvents bto_automatico As System.Windows.Forms.Button
    Friend WithEvents bto_ahora As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
