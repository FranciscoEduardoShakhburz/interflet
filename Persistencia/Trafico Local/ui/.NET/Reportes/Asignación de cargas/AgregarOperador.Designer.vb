<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarOperador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgregarOperador))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmBDisponible = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtUnidad = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtIdOperador = New System.Windows.Forms.TextBox
        Me.rTBObservaciones = New System.Windows.Forms.RichTextBox
        Me.cmBModalidad = New System.Windows.Forms.ComboBox
        Me.txtOperador = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cmBDisponible)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtUnidad)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtIdOperador)
        Me.GroupBox1.Controls.Add(Me.rTBObservaciones)
        Me.GroupBox1.Controls.Add(Me.cmBModalidad)
        Me.GroupBox1.Controls.Add(Me.txtOperador)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(547, 183)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'cmBDisponible
        '
        Me.cmBDisponible.FormattingEnabled = True
        Me.cmBDisponible.Items.AddRange(New Object() {"DISPONIBLE", "NO DISPONILBLE"})
        Me.cmBDisponible.Location = New System.Drawing.Point(107, 66)
        Me.cmBDisponible.Name = "cmBDisponible"
        Me.cmBDisponible.Size = New System.Drawing.Size(208, 21)
        Me.cmBDisponible.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Disponible:"
        '
        'txtUnidad
        '
        Me.txtUnidad.Location = New System.Drawing.Point(107, 39)
        Me.txtUnidad.Name = "txtUnidad"
        Me.txtUnidad.Size = New System.Drawing.Size(166, 20)
        Me.txtUnidad.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(50, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Unidad:"
        '
        'txtIdOperador
        '
        Me.txtIdOperador.Enabled = False
        Me.txtIdOperador.Location = New System.Drawing.Point(107, 13)
        Me.txtIdOperador.Name = "txtIdOperador"
        Me.txtIdOperador.Size = New System.Drawing.Size(65, 20)
        Me.txtIdOperador.TabIndex = 0
        '
        'rTBObservaciones
        '
        Me.rTBObservaciones.Location = New System.Drawing.Point(107, 93)
        Me.rTBObservaciones.Name = "rTBObservaciones"
        Me.rTBObservaciones.Size = New System.Drawing.Size(434, 84)
        Me.rTBObservaciones.TabIndex = 5
        Me.rTBObservaciones.Text = ""
        '
        'cmBModalidad
        '
        Me.cmBModalidad.FormattingEnabled = True
        Me.cmBModalidad.Items.AddRange(New Object() {"Sencillo", "Full"})
        Me.cmBModalidad.Location = New System.Drawing.Point(354, 39)
        Me.cmBModalidad.Name = "cmBModalidad"
        Me.cmBModalidad.Size = New System.Drawing.Size(187, 21)
        Me.cmBModalidad.TabIndex = 3
        '
        'txtOperador
        '
        Me.txtOperador.Location = New System.Drawing.Point(178, 13)
        Me.txtOperador.Name = "txtOperador"
        Me.txtOperador.Size = New System.Drawing.Size(363, 20)
        Me.txtOperador.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Observaciones:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(279, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Modalidad:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Operador:"
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(473, 201)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(40, 40)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(519, 201)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(40, 40)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'AgregarOperador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(571, 253)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(579, 287)
        Me.MinimumSize = New System.Drawing.Size(579, 287)
        Me.Name = "AgregarOperador"
        Me.Text = "Agregar operador | Operadores disponibles"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents rTBObservaciones As System.Windows.Forms.RichTextBox
    Friend WithEvents cmBModalidad As System.Windows.Forms.ComboBox
    Friend WithEvents txtOperador As System.Windows.Forms.TextBox
    Friend WithEvents cmBDisponible As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtUnidad As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtIdOperador As System.Windows.Forms.TextBox
End Class
