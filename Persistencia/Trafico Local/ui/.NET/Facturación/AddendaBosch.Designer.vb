<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddendaBosch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddendaBosch))
        Me.groupBox2 = New System.Windows.Forms.GroupBox
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnModificar = New System.Windows.Forms.Button
        Me.groupBox1 = New System.Windows.Forms.GroupBox
        Me.txtRuta = New System.Windows.Forms.TextBox
        Me.btnSelArchivo = New System.Windows.Forms.Button
        Me.dteHasta = New System.Windows.Forms.DateTimePicker
        Me.dteDesde = New System.Windows.Forms.DateTimePicker
        Me.label2 = New System.Windows.Forms.Label
        Me.label1 = New System.Windows.Forms.Label
        Me.buscarDestino = New System.Windows.Forms.FolderBrowserDialog
        Me.groupBox2.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBox2
        '
        Me.groupBox2.BackColor = System.Drawing.Color.Transparent
        Me.groupBox2.Controls.Add(Me.btnSalir)
        Me.groupBox2.Controls.Add(Me.btnModificar)
        Me.groupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox2.Location = New System.Drawing.Point(12, 138)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(461, 72)
        Me.groupBox2.TabIndex = 3
        Me.groupBox2.TabStop = False
        '
        'btnSalir
        '
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(262, 19)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(120, 40)
        Me.btnSalir.TabIndex = 1
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(67, 19)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(120, 40)
        Me.btnModificar.TabIndex = 0
        Me.btnModificar.Text = "      Modificar XML"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'groupBox1
        '
        Me.groupBox1.BackColor = System.Drawing.Color.Transparent
        Me.groupBox1.Controls.Add(Me.txtRuta)
        Me.groupBox1.Controls.Add(Me.btnSelArchivo)
        Me.groupBox1.Controls.Add(Me.dteHasta)
        Me.groupBox1.Controls.Add(Me.dteDesde)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(12, 12)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(461, 120)
        Me.groupBox1.TabIndex = 2
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Parámetros de búsqueda"
        '
        'txtRuta
        '
        Me.txtRuta.Enabled = False
        Me.txtRuta.Location = New System.Drawing.Point(135, 75)
        Me.txtRuta.Name = "txtRuta"
        Me.txtRuta.Size = New System.Drawing.Size(320, 20)
        Me.txtRuta.TabIndex = 6
        '
        'btnSelArchivo
        '
        Me.btnSelArchivo.Image = CType(resources.GetObject("btnSelArchivo.Image"), System.Drawing.Image)
        Me.btnSelArchivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSelArchivo.Location = New System.Drawing.Point(9, 64)
        Me.btnSelArchivo.Name = "btnSelArchivo"
        Me.btnSelArchivo.Size = New System.Drawing.Size(120, 40)
        Me.btnSelArchivo.TabIndex = 5
        Me.btnSelArchivo.Text = "   Guardar en"
        Me.btnSelArchivo.UseVisualStyleBackColor = True
        '
        'dteHasta
        '
        Me.dteHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteHasta.Location = New System.Drawing.Point(212, 27)
        Me.dteHasta.Name = "dteHasta"
        Me.dteHasta.Size = New System.Drawing.Size(97, 20)
        Me.dteHasta.TabIndex = 4
        '
        'dteDesde
        '
        Me.dteDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteDesde.Location = New System.Drawing.Point(53, 27)
        Me.dteDesde.Name = "dteDesde"
        Me.dteDesde.Size = New System.Drawing.Size(96, 20)
        Me.dteDesde.TabIndex = 3
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(168, 31)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(44, 13)
        Me.label2.TabIndex = 2
        Me.label2.Text = "Hasta:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(6, 31)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(47, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Desde:"
        '
        'AddendaBosch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(487, 221)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.groupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(495, 255)
        Me.MinimumSize = New System.Drawing.Size(495, 255)
        Me.Name = "AddendaBosch"
        Me.Text = "Agregar Addenda Cliente Bosch | Facturación"
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents btnSalir As System.Windows.Forms.Button
    Private WithEvents btnModificar As System.Windows.Forms.Button
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents txtRuta As System.Windows.Forms.TextBox
    Private WithEvents btnSelArchivo As System.Windows.Forms.Button
    Private WithEvents dteHasta As System.Windows.Forms.DateTimePicker
    Private WithEvents dteDesde As System.Windows.Forms.DateTimePicker
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents buscarDestino As System.Windows.Forms.FolderBrowserDialog
End Class
