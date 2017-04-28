<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarUnidad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgregarUnidad))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dTPLicencia = New System.Windows.Forms.DateTimePicker
        Me.dTPExmaneMedico = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.tBCelular = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.tBOperador = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.tBPlacas = New System.Windows.Forms.TextBox
        Me.tBEconomico = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.bGuardar = New System.Windows.Forms.Button
        Me.bSalir = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dTPLicencia)
        Me.GroupBox1.Controls.Add(Me.dTPExmaneMedico)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tBCelular)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tBOperador)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tBPlacas)
        Me.GroupBox1.Controls.Add(Me.tBEconomico)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 16)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.GroupBox1.Size = New System.Drawing.Size(442, 278)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos generales"
        '
        'dTPLicencia
        '
        Me.dTPLicencia.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dTPLicencia.Location = New System.Drawing.Point(181, 243)
        Me.dTPLicencia.Name = "dTPLicencia"
        Me.dTPLicencia.Size = New System.Drawing.Size(252, 25)
        Me.dTPLicencia.TabIndex = 15
        '
        'dTPExmaneMedico
        '
        Me.dTPExmaneMedico.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dTPExmaneMedico.Location = New System.Drawing.Point(181, 189)
        Me.dTPExmaneMedico.Name = "dTPExmaneMedico"
        Me.dTPExmaneMedico.Size = New System.Drawing.Size(252, 25)
        Me.dTPExmaneMedico.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 246)
        Me.Label8.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 19)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "de licencia:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 227)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(160, 19)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Fecha de vencimiento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 192)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 19)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "de examen médico:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 173)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(160, 19)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Fecha de vencimiento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 138)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 19)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Celular asignado:"
        '
        'tBCelular
        '
        Me.tBCelular.Location = New System.Drawing.Point(150, 135)
        Me.tBCelular.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tBCelular.Name = "tBCelular"
        Me.tBCelular.Size = New System.Drawing.Size(282, 25)
        Me.tBCelular.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(59, 103)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Operador:"
        '
        'tBOperador
        '
        Me.tBOperador.Location = New System.Drawing.Point(150, 100)
        Me.tBOperador.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tBOperador.Name = "tBOperador"
        Me.tBOperador.Size = New System.Drawing.Size(282, 25)
        Me.tBOperador.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(83, 68)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Placas:"
        '
        'tBPlacas
        '
        Me.tBPlacas.Location = New System.Drawing.Point(150, 65)
        Me.tBPlacas.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tBPlacas.Name = "tBPlacas"
        Me.tBPlacas.Size = New System.Drawing.Size(282, 25)
        Me.tBPlacas.TabIndex = 2
        '
        'tBEconomico
        '
        Me.tBEconomico.Location = New System.Drawing.Point(150, 30)
        Me.tBEconomico.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tBEconomico.Name = "tBEconomico"
        Me.tBEconomico.Size = New System.Drawing.Size(282, 25)
        Me.tBEconomico.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Económico:"
        '
        'bGuardar
        '
        Me.bGuardar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.bGuardar.Image = CType(resources.GetObject("bGuardar.Image"), System.Drawing.Image)
        Me.bGuardar.Location = New System.Drawing.Point(371, 304)
        Me.bGuardar.Name = "bGuardar"
        Me.bGuardar.Size = New System.Drawing.Size(40, 40)
        Me.bGuardar.TabIndex = 2
        Me.bGuardar.UseVisualStyleBackColor = True
        '
        'bSalir
        '
        Me.bSalir.Image = CType(resources.GetObject("bSalir.Image"), System.Drawing.Image)
        Me.bSalir.Location = New System.Drawing.Point(417, 304)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(40, 40)
        Me.bSalir.TabIndex = 3
        Me.bSalir.UseVisualStyleBackColor = True
        '
        'AgregarUnidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 356)
        Me.Controls.Add(Me.bSalir)
        Me.Controls.Add(Me.bGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Ubuntu", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "AgregarUnidad"
        Me.Text = "AgregarUnidad"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tBOperador As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tBPlacas As System.Windows.Forms.TextBox
    Friend WithEvents tBEconomico As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tBCelular As System.Windows.Forms.TextBox
    Friend WithEvents bGuardar As System.Windows.Forms.Button
    Friend WithEvents bSalir As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dTPLicencia As System.Windows.Forms.DateTimePicker
    Friend WithEvents dTPExmaneMedico As System.Windows.Forms.DateTimePicker
End Class
