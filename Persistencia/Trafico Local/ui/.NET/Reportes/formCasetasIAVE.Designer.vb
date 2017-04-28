<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formCasetasIAVE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formCasetasIAVE))
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtViaje = New System.Windows.Forms.TextBox
        Me.txtUnidad = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbFechaInicial = New System.Windows.Forms.DateTimePicker
        Me.cmbFechaFinal = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbCasetas = New System.Windows.Forms.ComboBox
        Me.btnBuscarbtnBuscar = New System.Windows.Forms.Button
        Me.btnExportar = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.gridCasetasIAVE = New System.Windows.Forms.DataGridView
        Me.btnSalir = New System.Windows.Forms.Button
        Me.cmbSucursal = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.gridCasetasIAVE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No. Viaje:"
        '
        'txtViaje
        '
        Me.txtViaje.Location = New System.Drawing.Point(17, 33)
        Me.txtViaje.Name = "txtViaje"
        Me.txtViaje.Size = New System.Drawing.Size(100, 20)
        Me.txtViaje.TabIndex = 1
        '
        'txtUnidad
        '
        Me.txtUnidad.Location = New System.Drawing.Point(140, 33)
        Me.txtUnidad.Name = "txtUnidad"
        Me.txtUnidad.Size = New System.Drawing.Size(100, 20)
        Me.txtUnidad.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(137, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Unidad:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(263, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Fecha Inicial:"
        '
        'cmbFechaInicial
        '
        Me.cmbFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmbFechaInicial.Location = New System.Drawing.Point(266, 33)
        Me.cmbFechaInicial.Name = "cmbFechaInicial"
        Me.cmbFechaInicial.Size = New System.Drawing.Size(102, 20)
        Me.cmbFechaInicial.TabIndex = 5
        '
        'cmbFechaFinal
        '
        Me.cmbFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmbFechaFinal.Location = New System.Drawing.Point(415, 33)
        Me.cmbFechaFinal.Name = "cmbFechaFinal"
        Me.cmbFechaFinal.Size = New System.Drawing.Size(102, 20)
        Me.cmbFechaFinal.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(412, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Fecha Final:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(552, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Casetas"
        '
        'cmbCasetas
        '
        Me.cmbCasetas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCasetas.FormattingEnabled = True
        Me.cmbCasetas.Items.AddRange(New Object() {"TODAS", "ACEPTADAS", "CANCELADAS", "PENDIENTES"})
        Me.cmbCasetas.Location = New System.Drawing.Point(555, 31)
        Me.cmbCasetas.Name = "cmbCasetas"
        Me.cmbCasetas.Size = New System.Drawing.Size(158, 21)
        Me.cmbCasetas.TabIndex = 9
        '
        'btnBuscarbtnBuscar
        '
        Me.btnBuscarbtnBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscarbtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarbtnBuscar.Location = New System.Drawing.Point(905, 17)
        Me.btnBuscarbtnBuscar.Name = "btnBuscarbtnBuscar"
        Me.btnBuscarbtnBuscar.Size = New System.Drawing.Size(75, 39)
        Me.btnBuscarbtnBuscar.TabIndex = 10
        Me.btnBuscarbtnBuscar.Text = "Buscar"
        Me.btnBuscarbtnBuscar.UseVisualStyleBackColor = True
        '
        'btnExportar
        '
        Me.btnExportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportar.Location = New System.Drawing.Point(986, 17)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(75, 39)
        Me.btnExportar.TabIndex = 11
        Me.btnExportar.Text = "Exportar"
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.gridCasetasIAVE)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 101)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1027, 574)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Resultado:"
        '
        'gridCasetasIAVE
        '
        Me.gridCasetasIAVE.AllowUserToAddRows = False
        Me.gridCasetasIAVE.AllowUserToDeleteRows = False
        Me.gridCasetasIAVE.AllowUserToOrderColumns = True
        Me.gridCasetasIAVE.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridCasetasIAVE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridCasetasIAVE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridCasetasIAVE.Location = New System.Drawing.Point(7, 20)
        Me.gridCasetasIAVE.Name = "gridCasetasIAVE"
        Me.gridCasetasIAVE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridCasetasIAVE.Size = New System.Drawing.Size(1014, 548)
        Me.gridCasetasIAVE.TabIndex = 0
        '
        'btnSalir
        '
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(430, 297)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 39)
        Me.btnSalir.TabIndex = 13
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'cmbSucursal
        '
        Me.cmbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSucursal.FormattingEnabled = True
        Me.cmbSucursal.Items.AddRange(New Object() {"Altamira", "Manzanillo", "Veracruz"})
        Me.cmbSucursal.Location = New System.Drawing.Point(734, 31)
        Me.cmbSucursal.Name = "cmbSucursal"
        Me.cmbSucursal.Size = New System.Drawing.Size(158, 21)
        Me.cmbSucursal.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(731, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Sucursal"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(587, 58)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 37)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "TODAS"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(731, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "ID: 1 = Altamira"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(731, 82)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "ID: 2 = Manzanillo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(835, 70)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "ID: 3 = Veracruz"
        '
        'formCasetasIAVE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(1067, 687)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmbSucursal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExportar)
        Me.Controls.Add(Me.btnBuscarbtnBuscar)
        Me.Controls.Add(Me.cmbCasetas)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbFechaFinal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbFechaInicial)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtUnidad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtViaje)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSalir)
        Me.Name = "formCasetasIAVE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Casetas IAVE"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.gridCasetasIAVE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtViaje As System.Windows.Forms.TextBox
    Friend WithEvents txtUnidad As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbFechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbCasetas As System.Windows.Forms.ComboBox
    Friend WithEvents btnBuscarbtnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnExportar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents gridCasetasIAVE As System.Windows.Forms.DataGridView
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents cmbSucursal As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
