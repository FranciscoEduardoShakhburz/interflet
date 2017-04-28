<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CapOperador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CapOperador))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.mTBHora = New System.Windows.Forms.MaskedTextBox
        Me.cmBEstatus = New System.Windows.Forms.ComboBox
        Me.cmBTipoOp = New System.Windows.Forms.ComboBox
        Me.txtOperador = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.mTBAsignacion = New System.Windows.Forms.MaskedTextBox
        Me.mTBEntregaManiobra = New System.Windows.Forms.MaskedTextBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.mTBEntregaManiobra)
        Me.GroupBox1.Controls.Add(Me.mTBAsignacion)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.mTBHora)
        Me.GroupBox1.Controls.Add(Me.cmBEstatus)
        Me.GroupBox1.Controls.Add(Me.cmBTipoOp)
        Me.GroupBox1.Controls.Add(Me.txtOperador)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(413, 212)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'mTBHora
        '
        Me.mTBHora.Location = New System.Drawing.Point(128, 81)
        Me.mTBHora.Mask = "00:00"
        Me.mTBHora.Name = "mTBHora"
        Me.mTBHora.Size = New System.Drawing.Size(35, 20)
        Me.mTBHora.TabIndex = 8
        Me.mTBHora.ValidatingType = GetType(Date)
        '
        'cmBEstatus
        '
        Me.cmBEstatus.FormattingEnabled = True
        Me.cmBEstatus.Items.AddRange(New Object() {"Disponible", "Asignado"})
        Me.cmBEstatus.Location = New System.Drawing.Point(128, 159)
        Me.cmBEstatus.Name = "cmBEstatus"
        Me.cmBEstatus.Size = New System.Drawing.Size(239, 24)
        Me.cmBEstatus.TabIndex = 7
        '
        'cmBTipoOp
        '
        Me.cmBTipoOp.FormattingEnabled = True
        Me.cmBTipoOp.Items.AddRange(New Object() {"Local", "Foráneo"})
        Me.cmBTipoOp.Location = New System.Drawing.Point(128, 51)
        Me.cmBTipoOp.Name = "cmBTipoOp"
        Me.cmBTipoOp.Size = New System.Drawing.Size(239, 24)
        Me.cmBTipoOp.TabIndex = 6
        '
        'txtOperador
        '
        Me.txtOperador.Location = New System.Drawing.Point(128, 25)
        Me.txtOperador.Name = "txtOperador"
        Me.txtOperador.Size = New System.Drawing.Size(239, 20)
        Me.txtOperador.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(73, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Estatus:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Hora de entrada:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tipo de operador:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Operador:"
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(339, 230)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(40, 40)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(385, 230)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(40, 40)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Entrega de maniobra:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Hora de asignación:"
        '
        'mTBAsignacion
        '
        Me.mTBAsignacion.Location = New System.Drawing.Point(128, 133)
        Me.mTBAsignacion.Mask = "00:00"
        Me.mTBAsignacion.Name = "mTBAsignacion"
        Me.mTBAsignacion.Size = New System.Drawing.Size(35, 20)
        Me.mTBAsignacion.TabIndex = 12
        Me.mTBAsignacion.ValidatingType = GetType(Date)
        '
        'mTBEntregaManiobra
        '
        Me.mTBEntregaManiobra.Location = New System.Drawing.Point(128, 107)
        Me.mTBEntregaManiobra.Mask = "00:00"
        Me.mTBEntregaManiobra.Name = "mTBEntregaManiobra"
        Me.mTBEntregaManiobra.Size = New System.Drawing.Size(35, 20)
        Me.mTBEntregaManiobra.TabIndex = 13
        Me.mTBEntregaManiobra.ValidatingType = GetType(Date)
        '
        'CapOperador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(437, 282)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CapOperador"
        Me.Text = "Agregar operador | Asignación de operadores"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtOperador As System.Windows.Forms.TextBox
    Friend WithEvents cmBEstatus As System.Windows.Forms.ComboBox
    Friend WithEvents cmBTipoOp As System.Windows.Forms.ComboBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents mTBHora As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents mTBEntregaManiobra As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mTBAsignacion As System.Windows.Forms.MaskedTextBox
End Class
