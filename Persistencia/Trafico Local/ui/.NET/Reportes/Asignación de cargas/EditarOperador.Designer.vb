<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarOperador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditarOperador))
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dTPFechaVencSeg = New System.Windows.Forms.DateTimePicker
        Me.dTPFechaVencLic = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.tBManejaMPeligroso = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.tBTelefono = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.tBOperador = New System.Windows.Forms.TextBox
        Me.tBOperadorId = New System.Windows.Forms.TextBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.tBEconomico = New System.Windows.Forms.TextBox
        Me.tBStatus = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.tBFechaLlegada = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(371, 241)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(40, 40)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(417, 241)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(40, 40)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Ubuntu", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(445, 223)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 28)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(437, 191)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos del operador"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.dTPFechaVencSeg)
        Me.GroupBox1.Controls.Add(Me.dTPFechaVencLic)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.tBManejaMPeligroso)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tBTelefono)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tBOperador)
        Me.GroupBox1.Controls.Add(Me.tBOperadorId)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(425, 179)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'dTPFechaVencSeg
        '
        Me.dTPFechaVencSeg.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dTPFechaVencSeg.Location = New System.Drawing.Point(177, 86)
        Me.dTPFechaVencSeg.Name = "dTPFechaVencSeg"
        Me.dTPFechaVencSeg.Size = New System.Drawing.Size(116, 25)
        Me.dTPFechaVencSeg.TabIndex = 14
        '
        'dTPFechaVencLic
        '
        Me.dTPFechaVencLic.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dTPFechaVencLic.Location = New System.Drawing.Point(177, 55)
        Me.dTPFechaVencLic.Name = "dTPFechaVencLic"
        Me.dTPFechaVencLic.Size = New System.Drawing.Size(116, 25)
        Me.dTPFechaVencLic.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(165, 19)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Maneja mat. peligroso:"
        '
        'tBManejaMPeligroso
        '
        Me.tBManejaMPeligroso.Location = New System.Drawing.Point(177, 117)
        Me.tBManejaMPeligroso.Name = "tBManejaMPeligroso"
        Me.tBManejaMPeligroso.Size = New System.Drawing.Size(76, 25)
        Me.tBManejaMPeligroso.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(46, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 19)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Venc. de seguro:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 19)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Venc. de licencia:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(94, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Teléfono:"
        '
        'tBTelefono
        '
        Me.tBTelefono.Location = New System.Drawing.Point(177, 148)
        Me.tBTelefono.Name = "tBTelefono"
        Me.tBTelefono.Size = New System.Drawing.Size(76, 25)
        Me.tBTelefono.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(90, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Operador:"
        '
        'tBOperador
        '
        Me.tBOperador.Location = New System.Drawing.Point(241, 24)
        Me.tBOperador.Name = "tBOperador"
        Me.tBOperador.Size = New System.Drawing.Size(178, 25)
        Me.tBOperador.TabIndex = 3
        '
        'tBOperadorId
        '
        Me.tBOperadorId.Location = New System.Drawing.Point(177, 24)
        Me.tBOperadorId.Name = "tBOperadorId"
        Me.tBOperadorId.Size = New System.Drawing.Size(58, 25)
        Me.tBOperadorId.TabIndex = 2
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 28)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(437, 191)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Datos de la unidad"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.tBEconomico)
        Me.GroupBox2.Controls.Add(Me.tBStatus)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.tBFechaLlegada)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(425, 179)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 19)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Num. Económico:"
        '
        'tBEconomico
        '
        Me.tBEconomico.Location = New System.Drawing.Point(142, 24)
        Me.tBEconomico.Name = "tBEconomico"
        Me.tBEconomico.Size = New System.Drawing.Size(116, 25)
        Me.tBEconomico.TabIndex = 4
        '
        'tBStatus
        '
        Me.tBStatus.Location = New System.Drawing.Point(142, 86)
        Me.tBStatus.Name = "tBStatus"
        Me.tBStatus.Size = New System.Drawing.Size(116, 25)
        Me.tBStatus.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(79, 89)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 19)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Status:"
        '
        'tBFechaLlegada
        '
        Me.tBFechaLlegada.Location = New System.Drawing.Point(142, 55)
        Me.tBFechaLlegada.Name = "tBFechaLlegada"
        Me.tBFechaLlegada.Size = New System.Drawing.Size(116, 25)
        Me.tBFechaLlegada.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 19)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Fecha de llegada:"
        '
        'EditarOperador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 293)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(477, 327)
        Me.MinimumSize = New System.Drawing.Size(477, 327)
        Me.Name = "EditarOperador"
        Me.Text = "EditarOperador"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tBTelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tBOperador As System.Windows.Forms.TextBox
    Friend WithEvents tBOperadorId As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tBManejaMPeligroso As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tBStatus As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tBFechaLlegada As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dTPFechaVencLic As System.Windows.Forms.DateTimePicker
    Friend WithEvents dTPFechaVencSeg As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tBEconomico As System.Windows.Forms.TextBox
End Class
