<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EscogerReporte
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EscogerReporte))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rdBtnResumen = New System.Windows.Forms.RadioButton
        Me.hastaPatio = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.desdePatio = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.hastaPendientes = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.desdePendientes = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.chkTodo = New System.Windows.Forms.CheckBox
        Me.chkPatio = New System.Windows.Forms.CheckBox
        Me.chkPendientes = New System.Windows.Forms.CheckBox
        Me.rdBtnReporteVisitas = New System.Windows.Forms.RadioButton
        Me.rdBtnReporteProgramacion = New System.Windows.Forms.RadioButton
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rdBtnResumen)
        Me.GroupBox1.Controls.Add(Me.hastaPatio)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.desdePatio)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.hastaPendientes)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.desdePendientes)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.chkTodo)
        Me.GroupBox1.Controls.Add(Me.chkPatio)
        Me.GroupBox1.Controls.Add(Me.chkPendientes)
        Me.GroupBox1.Controls.Add(Me.rdBtnReporteVisitas)
        Me.GroupBox1.Controls.Add(Me.rdBtnReporteProgramacion)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(326, 255)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione un reporte a generar"
        '
        'rdBtnResumen
        '
        Me.rdBtnResumen.AutoSize = True
        Me.rdBtnResumen.Location = New System.Drawing.Point(6, 228)
        Me.rdBtnResumen.Name = "rdBtnResumen"
        Me.rdBtnResumen.Size = New System.Drawing.Size(182, 20)
        Me.rdBtnResumen.TabIndex = 14
        Me.rdBtnResumen.TabStop = True
        Me.rdBtnResumen.Text = "Resumen de traslados"
        Me.rdBtnResumen.UseVisualStyleBackColor = True
        '
        'hastaPatio
        '
        Me.hastaPatio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.hastaPatio.Location = New System.Drawing.Point(212, 151)
        Me.hastaPatio.Name = "hastaPatio"
        Me.hastaPatio.Size = New System.Drawing.Size(99, 22)
        Me.hastaPatio.TabIndex = 13
        Me.hastaPatio.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(184, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "A:"
        Me.Label2.Visible = False
        '
        'desdePatio
        '
        Me.desdePatio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.desdePatio.Location = New System.Drawing.Point(79, 151)
        Me.desdePatio.Name = "desdePatio"
        Me.desdePatio.Size = New System.Drawing.Size(99, 22)
        Me.desdePatio.TabIndex = 11
        Me.desdePatio.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "De:"
        Me.Label4.Visible = False
        '
        'hastaPendientes
        '
        Me.hastaPendientes.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.hastaPendientes.Location = New System.Drawing.Point(212, 93)
        Me.hastaPendientes.Name = "hastaPendientes"
        Me.hastaPendientes.Size = New System.Drawing.Size(99, 22)
        Me.hastaPendientes.TabIndex = 9
        Me.hastaPendientes.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(184, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "A:"
        Me.Label3.Visible = False
        '
        'desdePendientes
        '
        Me.desdePendientes.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.desdePendientes.Location = New System.Drawing.Point(79, 93)
        Me.desdePendientes.Name = "desdePendientes"
        Me.desdePendientes.Size = New System.Drawing.Size(99, 22)
        Me.desdePendientes.TabIndex = 7
        Me.desdePendientes.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "De:"
        Me.Label1.Visible = False
        '
        'chkTodo
        '
        Me.chkTodo.AutoSize = True
        Me.chkTodo.Location = New System.Drawing.Point(44, 192)
        Me.chkTodo.Name = "chkTodo"
        Me.chkTodo.Size = New System.Drawing.Size(64, 20)
        Me.chkTodo.TabIndex = 4
        Me.chkTodo.Text = "Todo"
        Me.chkTodo.UseVisualStyleBackColor = True
        Me.chkTodo.Visible = False
        '
        'chkPatio
        '
        Me.chkPatio.AutoSize = True
        Me.chkPatio.Location = New System.Drawing.Point(44, 131)
        Me.chkPatio.Name = "chkPatio"
        Me.chkPatio.Size = New System.Drawing.Size(201, 20)
        Me.chkPatio.TabIndex = 3
        Me.chkPatio.Text = "Solo patio D. A. Hinojosa"
        Me.chkPatio.UseVisualStyleBackColor = True
        Me.chkPatio.Visible = False
        '
        'chkPendientes
        '
        Me.chkPendientes.AutoSize = True
        Me.chkPendientes.Location = New System.Drawing.Point(44, 73)
        Me.chkPendientes.Name = "chkPendientes"
        Me.chkPendientes.Size = New System.Drawing.Size(193, 20)
        Me.chkPendientes.TabIndex = 2
        Me.chkPendientes.Text = "Pendientes de trasladar"
        Me.chkPendientes.UseVisualStyleBackColor = True
        Me.chkPendientes.Visible = False
        '
        'rdBtnReporteVisitas
        '
        Me.rdBtnReporteVisitas.AutoSize = True
        Me.rdBtnReporteVisitas.Location = New System.Drawing.Point(6, 47)
        Me.rdBtnReporteVisitas.Name = "rdBtnReporteVisitas"
        Me.rdBtnReporteVisitas.Size = New System.Drawing.Size(153, 20)
        Me.rdBtnReporteVisitas.TabIndex = 1
        Me.rdBtnReporteVisitas.TabStop = True
        Me.rdBtnReporteVisitas.Text = "Reporte de visitas"
        Me.rdBtnReporteVisitas.UseVisualStyleBackColor = True
        '
        'rdBtnReporteProgramacion
        '
        Me.rdBtnReporteProgramacion.AutoSize = True
        Me.rdBtnReporteProgramacion.Location = New System.Drawing.Point(6, 21)
        Me.rdBtnReporteProgramacion.Name = "rdBtnReporteProgramacion"
        Me.rdBtnReporteProgramacion.Size = New System.Drawing.Size(197, 20)
        Me.rdBtnReporteProgramacion.TabIndex = 0
        Me.rdBtnReporteProgramacion.TabStop = True
        Me.rdBtnReporteProgramacion.Text = "Programación de cargas"
        Me.rdBtnReporteProgramacion.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(51, 274)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(120, 40)
        Me.btnAceptar.TabIndex = 1
        Me.btnAceptar.Text = "   Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(177, 273)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(120, 40)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "   Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'EscogerReporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(350, 326)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "EscogerReporte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Seleccionar..."
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdBtnReporteVisitas As System.Windows.Forms.RadioButton
    Friend WithEvents rdBtnReporteProgramacion As System.Windows.Forms.RadioButton
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents chkTodo As System.Windows.Forms.CheckBox
    Friend WithEvents chkPatio As System.Windows.Forms.CheckBox
    Friend WithEvents chkPendientes As System.Windows.Forms.CheckBox
    Friend WithEvents desdePendientes As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rdBtnResumen As System.Windows.Forms.RadioButton
    Friend WithEvents hastaPatio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents desdePatio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents hastaPendientes As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
