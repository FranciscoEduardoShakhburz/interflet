<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEvaluacionLocal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEvaluacionLocal))
        Me.grid_evaluacion = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmb_fecini = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmb_fecfin = New System.Windows.Forms.DateTimePicker
        Me.bto_consultar = New System.Windows.Forms.Button
        Me.bto_excel = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.grid_his = New System.Windows.Forms.DataGridView
        Me.bto_guardar = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt_meses = New System.Windows.Forms.TextBox
        Me.roperador = New System.Windows.Forms.RadioButton
        Me.runidad = New System.Windows.Forms.RadioButton
        Me.rviaje = New System.Windows.Forms.RadioButton
        Me.txt_param = New System.Windows.Forms.TextBox
        Me.rfecha = New System.Windows.Forms.RadioButton
        CType(Me.grid_evaluacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_his, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid_evaluacion
        '
        Me.grid_evaluacion.AllowUserToAddRows = False
        Me.grid_evaluacion.AllowUserToDeleteRows = False
        Me.grid_evaluacion.AllowUserToOrderColumns = True
        Me.grid_evaluacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_evaluacion.Location = New System.Drawing.Point(12, 71)
        Me.grid_evaluacion.Name = "grid_evaluacion"
        Me.grid_evaluacion.Size = New System.Drawing.Size(1155, 260)
        Me.grid_evaluacion.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "DE:"
        '
        'cmb_fecini
        '
        Me.cmb_fecini.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmb_fecini.Location = New System.Drawing.Point(60, 7)
        Me.cmb_fecini.Name = "cmb_fecini"
        Me.cmb_fecini.Size = New System.Drawing.Size(98, 20)
        Me.cmb_fecini.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(176, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "A:"
        '
        'cmb_fecfin
        '
        Me.cmb_fecfin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmb_fecfin.Location = New System.Drawing.Point(201, 7)
        Me.cmb_fecfin.Name = "cmb_fecfin"
        Me.cmb_fecfin.Size = New System.Drawing.Size(92, 20)
        Me.cmb_fecfin.TabIndex = 4
        '
        'bto_consultar
        '
        Me.bto_consultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bto_consultar.Location = New System.Drawing.Point(719, 7)
        Me.bto_consultar.Name = "bto_consultar"
        Me.bto_consultar.Size = New System.Drawing.Size(96, 26)
        Me.bto_consultar.TabIndex = 5
        Me.bto_consultar.Text = "CONSULTAR"
        Me.bto_consultar.UseVisualStyleBackColor = True
        '
        'bto_excel
        '
        Me.bto_excel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bto_excel.Location = New System.Drawing.Point(852, 7)
        Me.bto_excel.Name = "bto_excel"
        Me.bto_excel.Size = New System.Drawing.Size(91, 26)
        Me.bto_excel.TabIndex = 6
        Me.bto_excel.Text = "EXCEL"
        Me.bto_excel.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(1099, 7)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(83, 26)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "SALIR"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'grid_his
        '
        Me.grid_his.AllowUserToAddRows = False
        Me.grid_his.AllowUserToDeleteRows = False
        Me.grid_his.AllowUserToOrderColumns = True
        Me.grid_his.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_his.Location = New System.Drawing.Point(12, 378)
        Me.grid_his.Name = "grid_his"
        Me.grid_his.ReadOnly = True
        Me.grid_his.Size = New System.Drawing.Size(1155, 240)
        Me.grid_his.TabIndex = 8
        '
        'bto_guardar
        '
        Me.bto_guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bto_guardar.Location = New System.Drawing.Point(978, 7)
        Me.bto_guardar.Name = "bto_guardar"
        Me.bto_guardar.Size = New System.Drawing.Size(89, 26)
        Me.bto_guardar.TabIndex = 9
        Me.bto_guardar.Text = "GUARDAR"
        Me.bto_guardar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 352)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "MESES"
        '
        'txt_meses
        '
        Me.txt_meses.Location = New System.Drawing.Point(94, 352)
        Me.txt_meses.Name = "txt_meses"
        Me.txt_meses.Size = New System.Drawing.Size(171, 20)
        Me.txt_meses.TabIndex = 11
        Me.txt_meses.Text = "1"
        '
        'roperador
        '
        Me.roperador.AutoSize = True
        Me.roperador.BackColor = System.Drawing.Color.Transparent
        Me.roperador.Location = New System.Drawing.Point(343, 9)
        Me.roperador.Name = "roperador"
        Me.roperador.Size = New System.Drawing.Size(69, 17)
        Me.roperador.TabIndex = 12
        Me.roperador.TabStop = True
        Me.roperador.Text = "Operador"
        Me.roperador.UseVisualStyleBackColor = False
        '
        'runidad
        '
        Me.runidad.AutoSize = True
        Me.runidad.BackColor = System.Drawing.Color.Transparent
        Me.runidad.Location = New System.Drawing.Point(443, 10)
        Me.runidad.Name = "runidad"
        Me.runidad.Size = New System.Drawing.Size(59, 17)
        Me.runidad.TabIndex = 13
        Me.runidad.TabStop = True
        Me.runidad.Text = "Unidad"
        Me.runidad.UseVisualStyleBackColor = False
        '
        'rviaje
        '
        Me.rviaje.AutoSize = True
        Me.rviaje.BackColor = System.Drawing.Color.Transparent
        Me.rviaje.Location = New System.Drawing.Point(531, 9)
        Me.rviaje.Name = "rviaje"
        Me.rviaje.Size = New System.Drawing.Size(55, 17)
        Me.rviaje.TabIndex = 14
        Me.rviaje.TabStop = True
        Me.rviaje.Text = "#Viaje"
        Me.rviaje.UseVisualStyleBackColor = False
        '
        'txt_param
        '
        Me.txt_param.Location = New System.Drawing.Point(390, 45)
        Me.txt_param.Name = "txt_param"
        Me.txt_param.Size = New System.Drawing.Size(168, 20)
        Me.txt_param.TabIndex = 15
        '
        'rfecha
        '
        Me.rfecha.AutoSize = True
        Me.rfecha.BackColor = System.Drawing.Color.Transparent
        Me.rfecha.Location = New System.Drawing.Point(609, 9)
        Me.rfecha.Name = "rfecha"
        Me.rfecha.Size = New System.Drawing.Size(55, 17)
        Me.rfecha.TabIndex = 16
        Me.rfecha.TabStop = True
        Me.rfecha.Text = "Fecha"
        Me.rfecha.UseVisualStyleBackColor = False
        '
        'FormEvaluacionLocal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1215, 643)
        Me.Controls.Add(Me.rfecha)
        Me.Controls.Add(Me.txt_param)
        Me.Controls.Add(Me.rviaje)
        Me.Controls.Add(Me.runidad)
        Me.Controls.Add(Me.roperador)
        Me.Controls.Add(Me.txt_meses)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.bto_guardar)
        Me.Controls.Add(Me.grid_his)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.bto_excel)
        Me.Controls.Add(Me.bto_consultar)
        Me.Controls.Add(Me.cmb_fecfin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmb_fecini)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grid_evaluacion)
        Me.Name = "FormEvaluacionLocal"
        Me.Text = "FormEvaluacionLocal"
        CType(Me.grid_evaluacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_his, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grid_evaluacion As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_fecini As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmb_fecfin As System.Windows.Forms.DateTimePicker
    Friend WithEvents bto_consultar As System.Windows.Forms.Button
    Friend WithEvents bto_excel As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents grid_his As System.Windows.Forms.DataGridView
    Friend WithEvents bto_guardar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_meses As System.Windows.Forms.TextBox
    Friend WithEvents roperador As System.Windows.Forms.RadioButton
    Friend WithEvents runidad As System.Windows.Forms.RadioButton
    Friend WithEvents rviaje As System.Windows.Forms.RadioButton
    Friend WithEvents txt_param As System.Windows.Forms.TextBox
    Friend WithEvents rfecha As System.Windows.Forms.RadioButton
End Class
