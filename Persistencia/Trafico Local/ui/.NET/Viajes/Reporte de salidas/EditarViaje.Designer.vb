<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarViaje
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditarViaje))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtDocsEntregados = New System.Windows.Forms.TextBox
        Me.rTBObservaciones = New System.Windows.Forms.RichTextBox
        Me.dTPFecha = New System.Windows.Forms.DateTimePicker
        Me.txtHoraDoc = New System.Windows.Forms.TextBox
        Me.txtDolly = New System.Windows.Forms.TextBox
        Me.txtRemolque1 = New System.Windows.Forms.TextBox
        Me.txtEntregarEn = New System.Windows.Forms.TextBox
        Me.txtTipoOp = New System.Windows.Forms.TextBox
        Me.txtCP = New System.Windows.Forms.TextBox
        Me.txtDestino = New System.Windows.Forms.TextBox
        Me.txtCliente = New System.Windows.Forms.TextBox
        Me.txtViaje = New System.Windows.Forms.TextBox
        Me.txtPlacas = New System.Windows.Forms.TextBox
        Me.txtOperador = New System.Windows.Forms.TextBox
        Me.txtUnidad = New System.Windows.Forms.TextBox
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.txtContenedores = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Unidad:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Operador:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Placas:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(62, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Viaje:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(285, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Cliente:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(281, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Destino:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(261, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Carta porte:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(281, 126)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Tipo op:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(515, 23)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Entregar en:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(514, 48)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Remolque 1:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(553, 74)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Dolly:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(529, 97)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(63, 13)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "Hora doc:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(501, 126)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(111, 13)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "Hora docs. egdos:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 152)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(95, 13)
        Me.Label18.TabIndex = 17
        Me.Label18.Text = "Observaciones:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtContenedores)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtDocsEntregados)
        Me.GroupBox1.Controls.Add(Me.rTBObservaciones)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dTPFecha)
        Me.GroupBox1.Controls.Add(Me.txtHoraDoc)
        Me.GroupBox1.Controls.Add(Me.txtDolly)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtRemolque1)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtEntregarEn)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtTipoOp)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtCP)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtDestino)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtCliente)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtViaje)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtPlacas)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtOperador)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtUnidad)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(750, 242)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'txtDocsEntregados
        '
        Me.txtDocsEntregados.Location = New System.Drawing.Point(618, 123)
        Me.txtDocsEntregados.Name = "txtDocsEntregados"
        Me.txtDocsEntregados.Size = New System.Drawing.Size(126, 20)
        Me.txtDocsEntregados.TabIndex = 20
        '
        'rTBObservaciones
        '
        Me.rTBObservaciones.Location = New System.Drawing.Point(107, 149)
        Me.rTBObservaciones.Name = "rTBObservaciones"
        Me.rTBObservaciones.Size = New System.Drawing.Size(637, 87)
        Me.rTBObservaciones.TabIndex = 19
        Me.rTBObservaciones.Text = ""
        '
        'dTPFecha
        '
        Me.dTPFecha.Enabled = False
        Me.dTPFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dTPFecha.Location = New System.Drawing.Point(107, 19)
        Me.dTPFecha.Name = "dTPFecha"
        Me.dTPFecha.Size = New System.Drawing.Size(148, 20)
        Me.dTPFecha.TabIndex = 15
        '
        'txtHoraDoc
        '
        Me.txtHoraDoc.Location = New System.Drawing.Point(598, 97)
        Me.txtHoraDoc.Name = "txtHoraDoc"
        Me.txtHoraDoc.Size = New System.Drawing.Size(146, 20)
        Me.txtHoraDoc.TabIndex = 12
        '
        'txtDolly
        '
        Me.txtDolly.Location = New System.Drawing.Point(598, 71)
        Me.txtDolly.Name = "txtDolly"
        Me.txtDolly.Size = New System.Drawing.Size(146, 20)
        Me.txtDolly.TabIndex = 11
        '
        'txtRemolque1
        '
        Me.txtRemolque1.Location = New System.Drawing.Point(598, 45)
        Me.txtRemolque1.Name = "txtRemolque1"
        Me.txtRemolque1.Size = New System.Drawing.Size(146, 20)
        Me.txtRemolque1.TabIndex = 10
        '
        'txtEntregarEn
        '
        Me.txtEntregarEn.Location = New System.Drawing.Point(598, 19)
        Me.txtEntregarEn.Name = "txtEntregarEn"
        Me.txtEntregarEn.Size = New System.Drawing.Size(146, 20)
        Me.txtEntregarEn.TabIndex = 9
        '
        'txtTipoOp
        '
        Me.txtTipoOp.Location = New System.Drawing.Point(341, 123)
        Me.txtTipoOp.Name = "txtTipoOp"
        Me.txtTipoOp.Size = New System.Drawing.Size(154, 20)
        Me.txtTipoOp.TabIndex = 8
        '
        'txtCP
        '
        Me.txtCP.Location = New System.Drawing.Point(341, 71)
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(154, 20)
        Me.txtCP.TabIndex = 7
        '
        'txtDestino
        '
        Me.txtDestino.Location = New System.Drawing.Point(341, 45)
        Me.txtDestino.Name = "txtDestino"
        Me.txtDestino.Size = New System.Drawing.Size(154, 20)
        Me.txtDestino.TabIndex = 6
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(341, 19)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(154, 20)
        Me.txtCliente.TabIndex = 5
        '
        'txtViaje
        '
        Me.txtViaje.Location = New System.Drawing.Point(107, 123)
        Me.txtViaje.Name = "txtViaje"
        Me.txtViaje.Size = New System.Drawing.Size(148, 20)
        Me.txtViaje.TabIndex = 3
        '
        'txtPlacas
        '
        Me.txtPlacas.Location = New System.Drawing.Point(107, 97)
        Me.txtPlacas.Name = "txtPlacas"
        Me.txtPlacas.Size = New System.Drawing.Size(148, 20)
        Me.txtPlacas.TabIndex = 2
        '
        'txtOperador
        '
        Me.txtOperador.Location = New System.Drawing.Point(107, 71)
        Me.txtOperador.Name = "txtOperador"
        Me.txtOperador.Size = New System.Drawing.Size(148, 20)
        Me.txtOperador.TabIndex = 1
        '
        'txtUnidad
        '
        Me.txtUnidad.Location = New System.Drawing.Point(107, 45)
        Me.txtUnidad.Name = "txtUnidad"
        Me.txtUnidad.Size = New System.Drawing.Size(148, 20)
        Me.txtUnidad.TabIndex = 0
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(676, 260)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(40, 40)
        Me.btnGuardar.TabIndex = 19
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(722, 260)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(40, 40)
        Me.btnCancelar.TabIndex = 20
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'txtContenedores
        '
        Me.txtContenedores.Location = New System.Drawing.Point(341, 97)
        Me.txtContenedores.Name = "txtContenedores"
        Me.txtContenedores.Size = New System.Drawing.Size(154, 20)
        Me.txtContenedores.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(298, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Cont:"
        '
        'EditarViaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(774, 312)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "EditarViaje"
        Me.Text = "Editar viaje | Reporte de salidas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dTPFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtHoraDoc As System.Windows.Forms.TextBox
    Friend WithEvents txtDolly As System.Windows.Forms.TextBox
    Friend WithEvents txtRemolque1 As System.Windows.Forms.TextBox
    Friend WithEvents txtEntregarEn As System.Windows.Forms.TextBox
    Friend WithEvents txtTipoOp As System.Windows.Forms.TextBox
    Friend WithEvents txtCP As System.Windows.Forms.TextBox
    Friend WithEvents txtDestino As System.Windows.Forms.TextBox
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents txtViaje As System.Windows.Forms.TextBox
    Friend WithEvents txtPlacas As System.Windows.Forms.TextBox
    Friend WithEvents txtOperador As System.Windows.Forms.TextBox
    Friend WithEvents txtUnidad As System.Windows.Forms.TextBox
    Friend WithEvents rTBObservaciones As System.Windows.Forms.RichTextBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents txtDocsEntregados As System.Windows.Forms.TextBox
    Friend WithEvents txtContenedores As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
