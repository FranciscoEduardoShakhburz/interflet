<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IngresarRegistro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IngresarRegistro))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtEdad = New System.Windows.Forms.TextBox
        Me.dteFechaNac = New System.Windows.Forms.DateTimePicker
        Me.Label13 = New System.Windows.Forms.Label
        Me.cmbPuesto = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.cmbTipoOp = New System.Windows.Forms.ComboBox
        Me.cmbModalidad = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtTipoLic = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtTelefono2 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtRFC = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.cmbEstatus = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtObservaciones = New System.Windows.Forms.RichTextBox
        Me.txtRecomendado = New System.Windows.Forms.TextBox
        Me.txtTelefono1 = New System.Windows.Forms.TextBox
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.dteFecha = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtEdad)
        Me.GroupBox1.Controls.Add(Me.dteFechaNac)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.cmbPuesto)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.cmbTipoOp)
        Me.GroupBox1.Controls.Add(Me.cmbModalidad)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtTipoLic)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtTelefono2)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtRFC)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cmbEstatus)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtObservaciones)
        Me.GroupBox1.Controls.Add(Me.txtRecomendado)
        Me.GroupBox1.Controls.Add(Me.txtTelefono1)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.dteFecha)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(825, 259)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del candidato"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(213, 74)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 13)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Edad:"
        '
        'txtEdad
        '
        Me.txtEdad.BackColor = System.Drawing.SystemColors.Window
        Me.txtEdad.Enabled = False
        Me.txtEdad.Location = New System.Drawing.Point(259, 71)
        Me.txtEdad.MaxLength = 13
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(74, 20)
        Me.txtEdad.TabIndex = 15
        '
        'dteFechaNac
        '
        Me.dteFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteFechaNac.Location = New System.Drawing.Point(107, 70)
        Me.dteFechaNac.Name = "dteFechaNac"
        Me.dteFechaNac.Size = New System.Drawing.Size(100, 20)
        Me.dteFechaNac.TabIndex = 14
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(8, 74)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(93, 13)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Fecha de nac.:"
        '
        'cmbPuesto
        '
        Me.cmbPuesto.FormattingEnabled = True
        Me.cmbPuesto.Items.AddRange(New Object() {"OP. TRACTOCAMIÓN", "OP. CAMIONETA", "MECÁNICO", "HOJALATERO", "ELÉCTRICO", "SOLDADOR", "AYUDANTE", "OTRO"})
        Me.cmbPuesto.Location = New System.Drawing.Point(459, 96)
        Me.cmbPuesto.Name = "cmbPuesto"
        Me.cmbPuesto.Size = New System.Drawing.Size(121, 21)
        Me.cmbPuesto.TabIndex = 7
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(403, 100)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 13)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Puesto:"
        '
        'cmbTipoOp
        '
        Me.cmbTipoOp.FormattingEnabled = True
        Me.cmbTipoOp.Items.AddRange(New Object() {"LOCAL", "FORÁNEO"})
        Me.cmbTipoOp.Location = New System.Drawing.Point(700, 97)
        Me.cmbTipoOp.Name = "cmbTipoOp"
        Me.cmbTipoOp.Size = New System.Drawing.Size(114, 21)
        Me.cmbTipoOp.TabIndex = 8
        '
        'cmbModalidad
        '
        Me.cmbModalidad.FormattingEnabled = True
        Me.cmbModalidad.Items.AddRange(New Object() {"SENCILLO", "FULL"})
        Me.cmbModalidad.Location = New System.Drawing.Point(459, 123)
        Me.cmbModalidad.Name = "cmbModalidad"
        Me.cmbModalidad.Size = New System.Drawing.Size(121, 21)
        Me.cmbModalidad.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(341, 126)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(112, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Modalidad de vje.:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(586, 100)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(108, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Tipo de operador:"
        '
        'txtTipoLic
        '
        Me.txtTipoLic.Location = New System.Drawing.Point(459, 71)
        Me.txtTipoLic.Name = "txtTipoLic"
        Me.txtTipoLic.Size = New System.Drawing.Size(355, 20)
        Me.txtTipoLic.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(351, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Tipo de licencia:"
        '
        'txtTelefono2
        '
        Me.txtTelefono2.Location = New System.Drawing.Point(107, 148)
        Me.txtTelefono2.Name = "txtTelefono2"
        Me.txtTelefono2.Size = New System.Drawing.Size(226, 20)
        Me.txtTelefono2.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(29, 151)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Teléfono 2:"
        '
        'txtRFC
        '
        Me.txtRFC.BackColor = System.Drawing.SystemColors.Window
        Me.txtRFC.Location = New System.Drawing.Point(107, 96)
        Me.txtRFC.MaxLength = 13
        Me.txtRFC.Name = "txtRFC"
        Me.txtRFC.Size = New System.Drawing.Size(226, 20)
        Me.txtRFC.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(58, 99)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "R.F.C:"
        '
        'cmbEstatus
        '
        Me.cmbEstatus.Enabled = False
        Me.cmbEstatus.FormattingEnabled = True
        Me.cmbEstatus.Items.AddRange(New Object() {"ACTIVO", "INACTIVO", "NO APLICA", "RECOMENDABLE", "NO RECOMENDABLE"})
        Me.cmbEstatus.Location = New System.Drawing.Point(700, 123)
        Me.cmbEstatus.Name = "cmbEstatus"
        Me.cmbEstatus.Size = New System.Drawing.Size(114, 21)
        Me.cmbEstatus.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(641, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Estatus:"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(107, 174)
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(707, 71)
        Me.txtObservaciones.TabIndex = 11
        Me.txtObservaciones.Text = ""
        '
        'txtRecomendado
        '
        Me.txtRecomendado.Location = New System.Drawing.Point(459, 45)
        Me.txtRecomendado.Name = "txtRecomendado"
        Me.txtRecomendado.Size = New System.Drawing.Size(355, 20)
        Me.txtRecomendado.TabIndex = 5
        '
        'txtTelefono1
        '
        Me.txtTelefono1.Location = New System.Drawing.Point(107, 122)
        Me.txtTelefono1.Name = "txtTelefono1"
        Me.txtTelefono1.Size = New System.Drawing.Size(226, 20)
        Me.txtTelefono1.TabIndex = 3
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(107, 45)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(226, 20)
        Me.txtNombre.TabIndex = 1
        '
        'dteFecha
        '
        Me.dteFecha.Enabled = False
        Me.dteFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteFecha.Location = New System.Drawing.Point(107, 19)
        Me.dteFecha.Name = "dteFecha"
        Me.dteFecha.Size = New System.Drawing.Size(100, 20)
        Me.dteFecha.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Observaciones:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(339, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Recomendado por:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Teléfono 1:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha:"
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(591, 277)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(120, 40)
        Me.btnGuardar.TabIndex = 12
        Me.btnGuardar.Text = "   Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(717, 277)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(120, 40)
        Me.btnCancelar.TabIndex = 13
        Me.btnCancelar.Text = "   Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'IngresarRegistro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(852, 327)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(857, 361)
        Me.Name = "IngresarRegistro"
        Me.Text = "Ingresar registro | Regsitro de cadidatos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRecomendado As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono1 As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents dteFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As System.Windows.Forms.RichTextBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents cmbEstatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtRFC As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtTipoLic As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTelefono2 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbModalidad As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbTipoOp As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPuesto As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtEdad As System.Windows.Forms.TextBox
    Friend WithEvents dteFechaNac As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
