<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnticiposEspeciales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AnticiposEspeciales))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtDiesel2 = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.cmBArea = New System.Windows.Forms.ComboBox
        Me.txtIdOperador = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtDiferencia = New System.Windows.Forms.TextBox
        Me.txtSaldoComprobado = New System.Windows.Forms.TextBox
        Me.txtDiesel1 = New System.Windows.Forms.TextBox
        Me.txtTransferencia = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtNoViaje = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnEliminar = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtTotal)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtDiesel2)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.cmBArea)
        Me.GroupBox1.Controls.Add(Me.txtIdOperador)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtDiferencia)
        Me.GroupBox1.Controls.Add(Me.txtSaldoComprobado)
        Me.GroupBox1.Controls.Add(Me.txtDiesel1)
        Me.GroupBox1.Controls.Add(Me.txtTransferencia)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNoViaje)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(412, 254)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(148, 176)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(258, 20)
        Me.txtTotal.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(102, 179)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Total:"
        '
        'txtDiesel2
        '
        Me.txtDiesel2.Location = New System.Drawing.Point(148, 150)
        Me.txtDiesel2.Name = "txtDiesel2"
        Me.txtDiesel2.Size = New System.Drawing.Size(258, 20)
        Me.txtDiesel2.TabIndex = 5
        Me.txtDiesel2.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 153)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(136, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Ant. Diesel Si Vale (2):"
        Me.Label8.Visible = False
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(214, 72)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(192, 20)
        Me.txtNombre.TabIndex = 2
        '
        'cmBArea
        '
        Me.cmBArea.FormattingEnabled = True
        Me.cmBArea.Items.AddRange(New Object() {"Altamira", "Manzanillo", "Veracruz"})
        Me.cmBArea.Location = New System.Drawing.Point(148, 45)
        Me.cmBArea.Name = "cmBArea"
        Me.cmBArea.Size = New System.Drawing.Size(258, 21)
        Me.cmBArea.TabIndex = 1
        '
        'txtIdOperador
        '
        Me.txtIdOperador.Location = New System.Drawing.Point(148, 72)
        Me.txtIdOperador.Name = "txtIdOperador"
        Me.txtIdOperador.Size = New System.Drawing.Size(60, 20)
        Me.txtIdOperador.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(79, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Operador:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(105, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Area:"
        '
        'txtDiferencia
        '
        Me.txtDiferencia.Location = New System.Drawing.Point(148, 228)
        Me.txtDiferencia.Name = "txtDiferencia"
        Me.txtDiferencia.Size = New System.Drawing.Size(258, 20)
        Me.txtDiferencia.TabIndex = 8
        '
        'txtSaldoComprobado
        '
        Me.txtSaldoComprobado.Location = New System.Drawing.Point(148, 202)
        Me.txtSaldoComprobado.Name = "txtSaldoComprobado"
        Me.txtSaldoComprobado.Size = New System.Drawing.Size(258, 20)
        Me.txtSaldoComprobado.TabIndex = 7
        '
        'txtDiesel1
        '
        Me.txtDiesel1.Location = New System.Drawing.Point(148, 124)
        Me.txtDiesel1.Name = "txtDiesel1"
        Me.txtDiesel1.Size = New System.Drawing.Size(258, 20)
        Me.txtDiesel1.TabIndex = 4
        '
        'txtTransferencia
        '
        Me.txtTransferencia.Location = New System.Drawing.Point(148, 98)
        Me.txtTransferencia.Name = "txtTransferencia"
        Me.txtTransferencia.Size = New System.Drawing.Size(258, 20)
        Me.txtTransferencia.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(73, 231)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Diferencia:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Saldo comprobado:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Ant. Diesel Si Vale (1):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Ant. Especial Trans.:"
        '
        'txtNoViaje
        '
        Me.txtNoViaje.Location = New System.Drawing.Point(148, 19)
        Me.txtNoViaje.Name = "txtNoViaje"
        Me.txtNoViaje.Size = New System.Drawing.Size(258, 20)
        Me.txtNoViaje.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(79, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "No. Viaje:"
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(338, 272)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(40, 40)
        Me.btnGuardar.TabIndex = 9
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(384, 272)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(40, 40)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.Location = New System.Drawing.Point(12, 272)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(40, 40)
        Me.btnEliminar.TabIndex = 7
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'AnticiposEspeciales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(436, 324)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(444, 306)
        Me.Name = "AnticiposEspeciales"
        Me.Text = "Anticipos Especiales"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNoViaje As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents txtDiferencia As System.Windows.Forms.TextBox
    Friend WithEvents txtSaldoComprobado As System.Windows.Forms.TextBox
    Friend WithEvents txtDiesel1 As System.Windows.Forms.TextBox
    Friend WithEvents txtTransferencia As System.Windows.Forms.TextBox
    Friend WithEvents cmBArea As System.Windows.Forms.ComboBox
    Friend WithEvents txtIdOperador As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents txtDiesel2 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
