<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formConfiguracion
    Inherits System.Windows.Forms.Form


    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub


    Private components As System.ComponentModel.IContainer




    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtContrasena = New System.Windows.Forms.MaskedTextBox
        Me.btnValidar = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtNuevaContrasena = New System.Windows.Forms.MaskedTextBox
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtMovimiento = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtDescanso = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnSalir = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()



        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Contraseña:"



        Me.txtContrasena.Location = New System.Drawing.Point(94, 10)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContrasena.Size = New System.Drawing.Size(158, 20)
        Me.txtContrasena.TabIndex = 1



        Me.btnValidar.Location = New System.Drawing.Point(258, 8)
        Me.btnValidar.Name = "btnValidar"
        Me.btnValidar.Size = New System.Drawing.Size(116, 23)
        Me.btnValidar.TabIndex = 2
        Me.btnValidar.Text = "Validar"
        Me.btnValidar.UseVisualStyleBackColor = True



        Me.GroupBox1.Controls.Add(Me.txtNuevaContrasena)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtMovimiento)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtDescanso)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(575, 235)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Configuración "



        Me.txtNuevaContrasena.Location = New System.Drawing.Point(306, 93)
        Me.txtNuevaContrasena.Name = "txtNuevaContrasena"
        Me.txtNuevaContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNuevaContrasena.Size = New System.Drawing.Size(158, 20)
        Me.txtNuevaContrasena.TabIndex = 5



        Me.btnGuardar.Location = New System.Drawing.Point(223, 145)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(116, 55)
        Me.btnGuardar.TabIndex = 4
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True



        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(100, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Cambiar Contraseña:"



        Me.txtMovimiento.Location = New System.Drawing.Point(306, 64)
        Me.txtMovimiento.Name = "txtMovimiento"
        Me.txtMovimiento.Size = New System.Drawing.Size(158, 20)
        Me.txtMovimiento.TabIndex = 4



        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(100, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(191, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Limite de Tracto sin Movimiento:"



        Me.txtDescanso.Location = New System.Drawing.Point(306, 36)
        Me.txtDescanso.Name = "txtDescanso"
        Me.txtDescanso.Size = New System.Drawing.Size(158, 20)
        Me.txtDescanso.TabIndex = 2



        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(100, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tiempo de Descanso en horas:"



        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Location = New System.Drawing.Point(532, 8)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(59, 23)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True



        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(604, 296)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnValidar)
        Me.Controls.Add(Me.txtContrasena)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "formConfiguracion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuración Monitoreo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtContrasena As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnValidar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescanso As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtMovimiento As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents txtNuevaContrasena As System.Windows.Forms.MaskedTextBox
End Class
