<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIndicadoresCalidad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIndicadoresCalidad))
        Me.gbfiltros = New System.Windows.Forms.GroupBox
        Me.radio24Horas = New System.Windows.Forms.RadioButton
        Me.radio12Horas = New System.Windows.Forms.RadioButton
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnExportar = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.TxtViaje = New System.Windows.Forms.MaskedTextBox
        Me.TxtCliente = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.cmbArea = New System.Windows.Forms.ComboBox
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.cmbFechaFin = New System.Windows.Forms.DateTimePicker
        Me.cmbFechaIni = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.grdIndicadores = New System.Windows.Forms.DataGridView
        Me.gbfiltros.SuspendLayout()
        CType(Me.grdIndicadores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbfiltros
        '
        Me.gbfiltros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbfiltros.BackColor = System.Drawing.Color.Transparent
        Me.gbfiltros.Controls.Add(Me.radio24Horas)
        Me.gbfiltros.Controls.Add(Me.radio12Horas)
        Me.gbfiltros.Controls.Add(Me.btnSalir)
        Me.gbfiltros.Controls.Add(Me.btnExportar)
        Me.gbfiltros.Controls.Add(Me.btnGuardar)
        Me.gbfiltros.Controls.Add(Me.TxtViaje)
        Me.gbfiltros.Controls.Add(Me.TxtCliente)
        Me.gbfiltros.Controls.Add(Me.Label4)
        Me.gbfiltros.Controls.Add(Me.Label30)
        Me.gbfiltros.Controls.Add(Me.cmbArea)
        Me.gbfiltros.Controls.Add(Me.btnBuscar)
        Me.gbfiltros.Controls.Add(Me.cmbFechaFin)
        Me.gbfiltros.Controls.Add(Me.cmbFechaIni)
        Me.gbfiltros.Controls.Add(Me.Label2)
        Me.gbfiltros.Controls.Add(Me.Label1)
        Me.gbfiltros.Controls.Add(Me.Label3)
        Me.gbfiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbfiltros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbfiltros.Location = New System.Drawing.Point(4, 7)
        Me.gbfiltros.Name = "gbfiltros"
        Me.gbfiltros.Size = New System.Drawing.Size(1116, 72)
        Me.gbfiltros.TabIndex = 1
        Me.gbfiltros.TabStop = False
        Me.gbfiltros.Text = "Seleccione los filtros de busqueda"
        '
        'radio24Horas
        '
        Me.radio24Horas.AutoSize = True
        Me.radio24Horas.BackColor = System.Drawing.Color.Transparent
        Me.radio24Horas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radio24Horas.Location = New System.Drawing.Point(953, 36)
        Me.radio24Horas.Name = "radio24Horas"
        Me.radio24Horas.Size = New System.Drawing.Size(76, 17)
        Me.radio24Horas.TabIndex = 78
        Me.radio24Horas.TabStop = True
        Me.radio24Horas.Text = "24 Horas"
        Me.radio24Horas.UseVisualStyleBackColor = False
        '
        'radio12Horas
        '
        Me.radio12Horas.AutoSize = True
        Me.radio12Horas.BackColor = System.Drawing.Color.Transparent
        Me.radio12Horas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radio12Horas.Location = New System.Drawing.Point(953, 20)
        Me.radio12Horas.Name = "radio12Horas"
        Me.radio12Horas.Size = New System.Drawing.Size(76, 17)
        Me.radio12Horas.TabIndex = 77
        Me.radio12Horas.TabStop = True
        Me.radio12Horas.Text = "12 Horas"
        Me.radio12Horas.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSalir.Location = New System.Drawing.Point(893, 13)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(54, 51)
        Me.btnSalir.TabIndex = 9
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnExportar
        '
        Me.btnExportar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnExportar.ForeColor = System.Drawing.Color.Black
        Me.btnExportar.Location = New System.Drawing.Point(814, 13)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(73, 51)
        Me.btnExportar.TabIndex = 8
        Me.btnExportar.Text = "Exportar"
        Me.btnExportar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnGuardar.Location = New System.Drawing.Point(737, 13)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(71, 51)
        Me.btnGuardar.TabIndex = 7
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'TxtViaje
        '
        Me.TxtViaje.Location = New System.Drawing.Point(9, 35)
        Me.TxtViaje.Mask = "9999999"
        Me.TxtViaje.Name = "TxtViaje"
        Me.TxtViaje.Size = New System.Drawing.Size(64, 21)
        Me.TxtViaje.TabIndex = 1
        Me.TxtViaje.Text = "0"
        '
        'TxtCliente
        '
        Me.TxtCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCliente.Location = New System.Drawing.Point(82, 35)
        Me.TxtCliente.Name = "TxtCliente"
        Me.TxtCliente.Size = New System.Drawing.Size(194, 21)
        Me.TxtCliente.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(80, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 14)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "Cliente:"
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(3, 20)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(70, 14)
        Me.Label30.TabIndex = 75
        Me.Label30.Text = "# Viaje:"
        '
        'cmbArea
        '
        Me.cmbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbArea.FormattingEnabled = True
        Me.cmbArea.Location = New System.Drawing.Point(529, 32)
        Me.cmbArea.Name = "cmbArea"
        Me.cmbArea.Size = New System.Drawing.Size(121, 23)
        Me.cmbArea.TabIndex = 5
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnBuscar.Location = New System.Drawing.Point(672, 13)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(59, 51)
        Me.btnBuscar.TabIndex = 6
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'cmbFechaFin
        '
        Me.cmbFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmbFechaFin.Location = New System.Drawing.Point(411, 34)
        Me.cmbFechaFin.Name = "cmbFechaFin"
        Me.cmbFechaFin.Size = New System.Drawing.Size(105, 21)
        Me.cmbFechaFin.TabIndex = 4
        '
        'cmbFechaIni
        '
        Me.cmbFechaIni.CustomFormat = "4"
        Me.cmbFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmbFechaIni.Location = New System.Drawing.Point(291, 35)
        Me.cmbFechaIni.Name = "cmbFechaIni"
        Me.cmbFechaIni.Size = New System.Drawing.Size(105, 21)
        Me.cmbFechaIni.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(408, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha Final"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(288, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha Inicial"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(526, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Área"
        '
        'grdIndicadores
        '
        Me.grdIndicadores.AllowUserToAddRows = False
        Me.grdIndicadores.AllowUserToDeleteRows = False
        Me.grdIndicadores.AllowUserToOrderColumns = True
        Me.grdIndicadores.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdIndicadores.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.grdIndicadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdIndicadores.Location = New System.Drawing.Point(10, 85)
        Me.grdIndicadores.Name = "grdIndicadores"
        Me.grdIndicadores.RowHeadersWidth = 15
        Me.grdIndicadores.Size = New System.Drawing.Size(1110, 673)
        Me.grdIndicadores.TabIndex = 2
        '
        'frmIndicadoresCalidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(1132, 770)
        Me.Controls.Add(Me.grdIndicadores)
        Me.Controls.Add(Me.gbfiltros)
        Me.Name = "frmIndicadoresCalidad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Captura Indicadores de Calidad"
        Me.gbfiltros.ResumeLayout(False)
        Me.gbfiltros.PerformLayout()
        CType(Me.grdIndicadores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbfiltros As System.Windows.Forms.GroupBox
    Friend WithEvents cmbArea As System.Windows.Forms.ComboBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents cmbFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbFechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtViaje As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TxtCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents grdIndicadores As System.Windows.Forms.DataGridView
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnExportar As System.Windows.Forms.Button
    Friend WithEvents radio12Horas As System.Windows.Forms.RadioButton
    Friend WithEvents radio24Horas As System.Windows.Forms.RadioButton
End Class
