<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdendaK_N
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdendaK_N))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.tBRuta = New System.Windows.Forms.TextBox
        Me.bSeleccionarRuta = New System.Windows.Forms.Button
        Me.dTPHasta = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.dTPDesde = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.bSalir = New System.Windows.Forms.Button
        Me.bModificar = New System.Windows.Forms.Button
        Me.fBDRutaDestino = New System.Windows.Forms.FolderBrowserDialog
        Me.rBFechas = New System.Windows.Forms.RadioButton
        Me.rBFactura = New System.Windows.Forms.RadioButton
        Me.tBFactura = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.tBFactura)
        Me.GroupBox1.Controls.Add(Me.rBFactura)
        Me.GroupBox1.Controls.Add(Me.rBFechas)
        Me.GroupBox1.Controls.Add(Me.tBRuta)
        Me.GroupBox1.Controls.Add(Me.bSeleccionarRuta)
        Me.GroupBox1.Controls.Add(Me.dTPHasta)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dTPDesde)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 14)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Size = New System.Drawing.Size(720, 162)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'tBRuta
        '
        Me.tBRuta.Enabled = False
        Me.tBRuta.Location = New System.Drawing.Point(175, 118)
        Me.tBRuta.Margin = New System.Windows.Forms.Padding(5)
        Me.tBRuta.Name = "tBRuta"
        Me.tBRuta.Size = New System.Drawing.Size(531, 31)
        Me.tBRuta.TabIndex = 8
        '
        'bSeleccionarRuta
        '
        Me.bSeleccionarRuta.Image = CType(resources.GetObject("bSeleccionarRuta.Image"), System.Drawing.Image)
        Me.bSeleccionarRuta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bSeleccionarRuta.Location = New System.Drawing.Point(10, 112)
        Me.bSeleccionarRuta.Margin = New System.Windows.Forms.Padding(5)
        Me.bSeleccionarRuta.Name = "bSeleccionarRuta"
        Me.bSeleccionarRuta.Size = New System.Drawing.Size(155, 40)
        Me.bSeleccionarRuta.TabIndex = 7
        Me.bSeleccionarRuta.Text = "   Guardar en"
        Me.bSeleccionarRuta.UseVisualStyleBackColor = True
        '
        'dTPHasta
        '
        Me.dTPHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dTPHasta.Location = New System.Drawing.Point(416, 34)
        Me.dTPHasta.Margin = New System.Windows.Forms.Padding(5)
        Me.dTPHasta.Name = "dTPHasta"
        Me.dTPHasta.Size = New System.Drawing.Size(156, 31)
        Me.dTPHasta.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(341, 40)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Hasta: "
        '
        'dTPDesde
        '
        Me.dTPDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dTPDesde.Location = New System.Drawing.Point(175, 34)
        Me.dTPDesde.Margin = New System.Windows.Forms.Padding(5)
        Me.dTPDesde.Name = "dTPDesde"
        Me.dTPDesde.Size = New System.Drawing.Size(156, 31)
        Me.dTPDesde.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(97, 40)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Desde: "
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.bSalir)
        Me.GroupBox2.Controls.Add(Me.bModificar)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 186)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox2.Size = New System.Drawing.Size(720, 84)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'bSalir
        '
        Me.bSalir.Image = CType(resources.GetObject("bSalir.Image"), System.Drawing.Image)
        Me.bSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bSalir.Location = New System.Drawing.Point(334, 34)
        Me.bSalir.Margin = New System.Windows.Forms.Padding(5)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(155, 40)
        Me.bSalir.TabIndex = 3
        Me.bSalir.Text = "Salir"
        Me.bSalir.UseVisualStyleBackColor = True
        '
        'bModificar
        '
        Me.bModificar.Enabled = False
        Me.bModificar.Image = CType(resources.GetObject("bModificar.Image"), System.Drawing.Image)
        Me.bModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bModificar.Location = New System.Drawing.Point(169, 34)
        Me.bModificar.Margin = New System.Windows.Forms.Padding(5)
        Me.bModificar.Name = "bModificar"
        Me.bModificar.Size = New System.Drawing.Size(155, 40)
        Me.bModificar.TabIndex = 2
        Me.bModificar.Text = "      Modificar XML"
        Me.bModificar.UseVisualStyleBackColor = True
        '
        'rBFechas
        '
        Me.rBFechas.AutoSize = True
        Me.rBFechas.Location = New System.Drawing.Point(8, 38)
        Me.rBFechas.Name = "rBFechas"
        Me.rBFechas.Size = New System.Drawing.Size(87, 27)
        Me.rBFechas.TabIndex = 9
        Me.rBFechas.TabStop = True
        Me.rBFechas.Text = "Fechas:"
        Me.rBFechas.UseVisualStyleBackColor = True
        '
        'rBFactura
        '
        Me.rBFactura.AutoSize = True
        Me.rBFactura.Location = New System.Drawing.Point(8, 74)
        Me.rBFactura.Name = "rBFactura"
        Me.rBFactura.Size = New System.Drawing.Size(92, 27)
        Me.rBFactura.TabIndex = 10
        Me.rBFactura.TabStop = True
        Me.rBFactura.Text = "Factura:"
        Me.rBFactura.UseVisualStyleBackColor = True
        '
        'tBFactura
        '
        Me.tBFactura.Location = New System.Drawing.Point(106, 73)
        Me.tBFactura.Name = "tBFactura"
        Me.tBFactura.Size = New System.Drawing.Size(225, 31)
        Me.tBFactura.TabIndex = 11
        '
        'AdendaK_N
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(748, 284)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "AdendaK_N"
        Me.Text = "Adenda Kuehne And Nagel"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dTPHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dTPDesde As System.Windows.Forms.DateTimePicker
    Private WithEvents bSalir As System.Windows.Forms.Button
    Private WithEvents bModificar As System.Windows.Forms.Button
    Private WithEvents tBRuta As System.Windows.Forms.TextBox
    Private WithEvents bSeleccionarRuta As System.Windows.Forms.Button
    Friend WithEvents fBDRutaDestino As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents tBFactura As System.Windows.Forms.TextBox
    Friend WithEvents rBFactura As System.Windows.Forms.RadioButton
    Friend WithEvents rBFechas As System.Windows.Forms.RadioButton
End Class
