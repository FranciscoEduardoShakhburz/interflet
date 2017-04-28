<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEvaluacionLocal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEvaluacionLocal))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtOperador = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtUnidad = New System.Windows.Forms.TextBox
        Me.cmbTipoViaje = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.TxtSemana = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtViaje = New System.Windows.Forms.MaskedTextBox
        Me.btnExportar = New System.Windows.Forms.Button
        Me.btnConsultar = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbFecFin = New System.Windows.Forms.DateTimePicker
        Me.cmbFecIni = New System.Windows.Forms.DateTimePicker
        Me.Label30 = New System.Windows.Forms.Label
        Me.grdEvaluacion = New System.Windows.Forms.DataGridView
        Me.bto_reporte = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdEvaluacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.bto_reporte)
        Me.GroupBox1.Controls.Add(Me.txtOperador)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtUnidad)
        Me.GroupBox1.Controls.Add(Me.cmbTipoViaje)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Controls.Add(Me.TxtSemana)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtViaje)
        Me.GroupBox1.Controls.Add(Me.btnExportar)
        Me.GroupBox1.Controls.Add(Me.btnConsultar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbFecFin)
        Me.GroupBox1.Controls.Add(Me.cmbFecIni)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1151, 76)
        Me.GroupBox1.TabIndex = 81
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione una opción de consulta:"
        '
        'txtOperador
        '
        Me.txtOperador.Location = New System.Drawing.Point(283, 48)
        Me.txtOperador.Name = "txtOperador"
        Me.txtOperador.Size = New System.Drawing.Size(214, 21)
        Me.txtOperador.TabIndex = 89
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(279, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 14)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Operador:"
        '
        'txtUnidad
        '
        Me.txtUnidad.Location = New System.Drawing.Point(84, 48)
        Me.txtUnidad.Name = "txtUnidad"
        Me.txtUnidad.Size = New System.Drawing.Size(63, 21)
        Me.txtUnidad.TabIndex = 87
        '
        'cmbTipoViaje
        '
        Me.cmbTipoViaje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoViaje.FormattingEnabled = True
        Me.cmbTipoViaje.Location = New System.Drawing.Point(153, 46)
        Me.cmbTipoViaje.Name = "cmbTipoViaje"
        Me.cmbTipoViaje.Size = New System.Drawing.Size(121, 23)
        Me.cmbTipoViaje.TabIndex = 85
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(150, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 26)
        Me.Label6.TabIndex = 86
        Me.Label6.Text = "Tipo de Viaje:"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(80, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 14)
        Me.Label5.TabIndex = 83
        Me.Label5.Text = "Unidad:"
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardar.Location = New System.Drawing.Point(962, 31)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(85, 39)
        Me.btnGuardar.TabIndex = 82
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'TxtSemana
        '
        Me.TxtSemana.Location = New System.Drawing.Point(503, 49)
        Me.TxtSemana.MaxLength = 99
        Me.TxtSemana.Name = "TxtSemana"
        Me.TxtSemana.Size = New System.Drawing.Size(59, 21)
        Me.TxtSemana.TabIndex = 3
        Me.TxtSemana.Text = "0"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(500, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 14)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "Semana:"
        '
        'TxtViaje
        '
        Me.TxtViaje.Location = New System.Drawing.Point(13, 48)
        Me.TxtViaje.Mask = "9999999999"
        Me.TxtViaje.Name = "TxtViaje"
        Me.TxtViaje.Size = New System.Drawing.Size(64, 21)
        Me.TxtViaje.TabIndex = 1
        Me.TxtViaje.Text = "0"
        '
        'btnExportar
        '
        Me.btnExportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
        Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExportar.Location = New System.Drawing.Point(871, 31)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(85, 39)
        Me.btnExportar.TabIndex = 78
        Me.btnExportar.Text = "Exportar"
        Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(780, 31)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(85, 39)
        Me.btnConsultar.TabIndex = 6
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(671, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 14)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "Fecha Final:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(565, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 14)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "Fecha Inicial:"
        '
        'cmbFecFin
        '
        Me.cmbFecFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmbFecFin.Location = New System.Drawing.Point(674, 49)
        Me.cmbFecFin.Name = "cmbFecFin"
        Me.cmbFecFin.Size = New System.Drawing.Size(100, 21)
        Me.cmbFecFin.TabIndex = 5
        '
        'cmbFecIni
        '
        Me.cmbFecIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmbFecIni.Location = New System.Drawing.Point(568, 49)
        Me.cmbFecIni.Name = "cmbFecIni"
        Me.cmbFecIni.Size = New System.Drawing.Size(100, 21)
        Me.cmbFecIni.TabIndex = 4
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(10, 31)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(70, 14)
        Me.Label30.TabIndex = 70
        Me.Label30.Text = "# Viaje:"
        '
        'grdEvaluacion
        '
        Me.grdEvaluacion.AllowUserToOrderColumns = True
        Me.grdEvaluacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdEvaluacion.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.grdEvaluacion.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.grdEvaluacion.GridColor = System.Drawing.SystemColors.ControlLight
        Me.grdEvaluacion.Location = New System.Drawing.Point(0, 76)
        Me.grdEvaluacion.Name = "grdEvaluacion"
        Me.grdEvaluacion.RowHeadersWidth = 30
        Me.grdEvaluacion.Size = New System.Drawing.Size(1151, 545)
        Me.grdEvaluacion.TabIndex = 82
        '
        'bto_reporte
        '
        Me.bto_reporte.Location = New System.Drawing.Point(1053, 32)
        Me.bto_reporte.Name = "bto_reporte"
        Me.bto_reporte.Size = New System.Drawing.Size(86, 37)
        Me.bto_reporte.TabIndex = 90
        Me.bto_reporte.Text = "Reporte"
        Me.bto_reporte.UseVisualStyleBackColor = True
        '
        'frmEvaluacionLocal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1151, 621)
        Me.Controls.Add(Me.grdEvaluacion)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmEvaluacionLocal"
        Me.Text = "Evaluacion de Viajes Locales"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grdEvaluacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents TxtSemana As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtViaje As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnExportar As System.Windows.Forms.Button
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbFecFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbFecIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents grdEvaluacion As System.Windows.Forms.DataGridView
    Friend WithEvents cmbTipoViaje As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtUnidad As System.Windows.Forms.TextBox
    Friend WithEvents txtOperador As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bto_reporte As System.Windows.Forms.Button
End Class
