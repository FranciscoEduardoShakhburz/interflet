<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InputDialog
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
        Me.grupoActivar = New System.Windows.Forms.GroupBox
        Me.gpViaje = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmbAcepto = New System.Windows.Forms.ComboBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtHoraAlerta = New System.Windows.Forms.TextBox
        Me.txtOperador = New System.Windows.Forms.TextBox
        Me.txtUnidad = New System.Windows.Forms.TextBox
        Me.txtNoViaje = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.txtObservaciones = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.grupoPosponer = New System.Windows.Forms.GroupBox
        Me.btnPosponer = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtPosponer = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.radioPosponer = New System.Windows.Forms.RadioButton
        Me.radioActivar = New System.Windows.Forms.RadioButton
        Me.Label8 = New System.Windows.Forms.Label
        Me.grupoActivar.SuspendLayout()
        Me.gpViaje.SuspendLayout()
        Me.grupoPosponer.SuspendLayout()
        Me.SuspendLayout()



        Me.grupoActivar.Controls.Add(Me.gpViaje)
        Me.grupoActivar.Controls.Add(Me.btnCancelar)
        Me.grupoActivar.Controls.Add(Me.btnGuardar)
        Me.grupoActivar.Controls.Add(Me.txtObservaciones)
        Me.grupoActivar.Controls.Add(Me.Label2)
        Me.grupoActivar.Location = New System.Drawing.Point(13, 67)
        Me.grupoActivar.Name = "grupoActivar"
        Me.grupoActivar.Size = New System.Drawing.Size(351, 355)
        Me.grupoActivar.TabIndex = 0
        Me.grupoActivar.TabStop = False
        Me.grupoActivar.Text = "Información Importante"



        Me.gpViaje.Controls.Add(Me.Label7)
        Me.gpViaje.Controls.Add(Me.cmbAcepto)
        Me.gpViaje.Controls.Add(Me.TextBox1)
        Me.gpViaje.Controls.Add(Me.Label6)
        Me.gpViaje.Controls.Add(Me.txtHoraAlerta)
        Me.gpViaje.Controls.Add(Me.txtOperador)
        Me.gpViaje.Controls.Add(Me.txtUnidad)
        Me.gpViaje.Controls.Add(Me.txtNoViaje)
        Me.gpViaje.Controls.Add(Me.Label1)
        Me.gpViaje.Controls.Add(Me.Label5)
        Me.gpViaje.Controls.Add(Me.Label3)
        Me.gpViaje.Controls.Add(Me.Label4)
        Me.gpViaje.Location = New System.Drawing.Point(15, 19)
        Me.gpViaje.Name = "gpViaje"
        Me.gpViaje.Size = New System.Drawing.Size(321, 176)
        Me.gpViaje.TabIndex = 9
        Me.gpViaje.TabStop = False
        Me.gpViaje.Text = "Datos de Viaje"



        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "¿Acepta descanso?"



        Me.cmbAcepto.FormattingEnabled = True
        Me.cmbAcepto.Items.AddRange(New Object() {"Sí", "No"})
        Me.cmbAcepto.Location = New System.Drawing.Point(131, 138)
        Me.cmbAcepto.Name = "cmbAcepto"
        Me.cmbAcepto.Size = New System.Drawing.Size(167, 21)
        Me.cmbAcepto.TabIndex = 15



        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(131, 111)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(167, 20)
        Me.TextBox1.TabIndex = 14



        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Velocidad:"



        Me.txtHoraAlerta.Enabled = False
        Me.txtHoraAlerta.Location = New System.Drawing.Point(131, 85)
        Me.txtHoraAlerta.Name = "txtHoraAlerta"
        Me.txtHoraAlerta.Size = New System.Drawing.Size(167, 20)
        Me.txtHoraAlerta.TabIndex = 12



        Me.txtOperador.Enabled = False
        Me.txtOperador.Location = New System.Drawing.Point(131, 60)
        Me.txtOperador.Name = "txtOperador"
        Me.txtOperador.Size = New System.Drawing.Size(167, 20)
        Me.txtOperador.TabIndex = 11



        Me.txtUnidad.Enabled = False
        Me.txtUnidad.Location = New System.Drawing.Point(131, 36)
        Me.txtUnidad.Name = "txtUnidad"
        Me.txtUnidad.Size = New System.Drawing.Size(167, 20)
        Me.txtUnidad.TabIndex = 10



        Me.txtNoViaje.Enabled = False
        Me.txtNoViaje.Location = New System.Drawing.Point(131, 13)
        Me.txtNoViaje.Name = "txtNoViaje"
        Me.txtNoViaje.Size = New System.Drawing.Size(167, 20)
        Me.txtNoViaje.TabIndex = 9



        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "No.Viaje:"



        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Hora de Alerta:"



        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Unidad:"



        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Operador:"



        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(15, 305)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(131, 32)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True



        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(205, 305)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(131, 32)
        Me.btnGuardar.TabIndex = 3
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True



        Me.txtObservaciones.Location = New System.Drawing.Point(15, 214)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(321, 85)
        Me.txtObservaciones.TabIndex = 2



        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 198)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Observaciones:"



        Me.grupoPosponer.Controls.Add(Me.btnPosponer)
        Me.grupoPosponer.Controls.Add(Me.Label10)
        Me.grupoPosponer.Controls.Add(Me.txtPosponer)
        Me.grupoPosponer.Controls.Add(Me.Label9)
        Me.grupoPosponer.Location = New System.Drawing.Point(12, 69)
        Me.grupoPosponer.Name = "grupoPosponer"
        Me.grupoPosponer.Size = New System.Drawing.Size(351, 355)
        Me.grupoPosponer.TabIndex = 10
        Me.grupoPosponer.TabStop = False
        Me.grupoPosponer.Text = "Posponer Descanso"



        Me.btnPosponer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPosponer.Location = New System.Drawing.Point(38, 45)
        Me.btnPosponer.Name = "btnPosponer"
        Me.btnPosponer.Size = New System.Drawing.Size(267, 39)
        Me.btnPosponer.TabIndex = 3
        Me.btnPosponer.Text = "Guardar"
        Me.btnPosponer.UseVisualStyleBackColor = True



        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(282, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "horas."



        Me.txtPosponer.Location = New System.Drawing.Point(227, 16)
        Me.txtPosponer.Name = "txtPosponer"
        Me.txtPosponer.Size = New System.Drawing.Size(49, 20)
        Me.txtPosponer.TabIndex = 1



        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(7, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(223, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Posponer el descanso para dentro de "



        Me.radioPosponer.AutoSize = True
        Me.radioPosponer.Location = New System.Drawing.Point(236, 44)
        Me.radioPosponer.Name = "radioPosponer"
        Me.radioPosponer.Size = New System.Drawing.Size(121, 17)
        Me.radioPosponer.TabIndex = 14
        Me.radioPosponer.TabStop = True
        Me.radioPosponer.Text = "Posponer Descanso"
        Me.radioPosponer.UseVisualStyleBackColor = True



        Me.radioActivar.AutoSize = True
        Me.radioActivar.Location = New System.Drawing.Point(51, 44)
        Me.radioActivar.Name = "radioActivar"
        Me.radioActivar.Size = New System.Drawing.Size(109, 17)
        Me.radioActivar.TabIndex = 13
        Me.radioActivar.TabStop = True
        Me.radioActivar.Text = "Activar Descanso"
        Me.radioActivar.UseVisualStyleBackColor = True



        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(91, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(198, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "¡El Operador necesita Descansar!"



        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 436)
        Me.Controls.Add(Me.grupoPosponer)
        Me.Controls.Add(Me.radioPosponer)
        Me.Controls.Add(Me.radioActivar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.grupoActivar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "InputDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "¡Alerta! | ¡El Operador debe descansar!"
        Me.grupoActivar.ResumeLayout(False)
        Me.grupoActivar.PerformLayout()
        Me.gpViaje.ResumeLayout(False)
        Me.gpViaje.PerformLayout()
        Me.grupoPosponer.ResumeLayout(False)
        Me.grupoPosponer.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grupoActivar As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gpViaje As System.Windows.Forms.GroupBox
    Friend WithEvents txtHoraAlerta As System.Windows.Forms.TextBox
    Friend WithEvents txtOperador As System.Windows.Forms.TextBox
    Friend WithEvents txtUnidad As System.Windows.Forms.TextBox
    Friend WithEvents txtNoViaje As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbAcepto As System.Windows.Forms.ComboBox
    Friend WithEvents radioPosponer As System.Windows.Forms.RadioButton
    Friend WithEvents radioActivar As System.Windows.Forms.RadioButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents grupoPosponer As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtPosponer As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnPosponer As System.Windows.Forms.Button
End Class
