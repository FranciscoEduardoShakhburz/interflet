<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarBitacora
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgregarBitacora))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rTBObservaciones = New System.Windows.Forms.RichTextBox
        Me.rBObservacion = New System.Windows.Forms.RadioButton
        Me.rBOpNoSePresento = New System.Windows.Forms.RadioButton
        Me.rBParadaSinNot = New System.Windows.Forms.RadioButton
        Me.rBParadaZonaPro = New System.Windows.Forms.RadioButton
        Me.rBOpNegoViajar = New System.Windows.Forms.RadioButton
        Me.bGuardar = New System.Windows.Forms.Button
        Me.bSalir = New System.Windows.Forms.Button
        Me.rBOpAbandonoUnidad = New System.Windows.Forms.RadioButton
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.rBOpAbandonoUnidad)
        Me.GroupBox1.Controls.Add(Me.rTBObservaciones)
        Me.GroupBox1.Controls.Add(Me.rBObservacion)
        Me.GroupBox1.Controls.Add(Me.rBOpNoSePresento)
        Me.GroupBox1.Controls.Add(Me.rBParadaSinNot)
        Me.GroupBox1.Controls.Add(Me.rBParadaZonaPro)
        Me.GroupBox1.Controls.Add(Me.rBOpNegoViajar)
        Me.GroupBox1.Font = New System.Drawing.Font("Ubuntu", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(444, 312)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones"
        '
        'rTBObservaciones
        '
        Me.rTBObservaciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rTBObservaciones.Location = New System.Drawing.Point(6, 198)
        Me.rTBObservaciones.Name = "rTBObservaciones"
        Me.rTBObservaciones.Size = New System.Drawing.Size(432, 108)
        Me.rTBObservaciones.TabIndex = 6
        Me.rTBObservaciones.Text = ""
        '
        'rBObservacion
        '
        Me.rBObservacion.AutoSize = True
        Me.rBObservacion.Location = New System.Drawing.Point(6, 169)
        Me.rBObservacion.Name = "rBObservacion"
        Me.rBObservacion.Size = New System.Drawing.Size(114, 23)
        Me.rBObservacion.TabIndex = 5
        Me.rBObservacion.TabStop = True
        Me.rBObservacion.Text = "Observación"
        Me.rBObservacion.UseVisualStyleBackColor = True
        '
        'rBOpNoSePresento
        '
        Me.rBOpNoSePresento.AutoSize = True
        Me.rBOpNoSePresento.Location = New System.Drawing.Point(6, 140)
        Me.rBOpNoSePresento.Name = "rBOpNoSePresento"
        Me.rBOpNoSePresento.Size = New System.Drawing.Size(205, 23)
        Me.rBOpNoSePresento.TabIndex = 4
        Me.rBOpNoSePresento.TabStop = True
        Me.rBOpNoSePresento.Text = "Operador no se presentó "
        Me.rBOpNoSePresento.UseVisualStyleBackColor = True
        '
        'rBParadaSinNot
        '
        Me.rBParadaSinNot.AutoSize = True
        Me.rBParadaSinNot.Location = New System.Drawing.Point(6, 111)
        Me.rBParadaSinNot.Name = "rBParadaSinNot"
        Me.rBParadaSinNot.Size = New System.Drawing.Size(245, 23)
        Me.rBParadaSinNot.TabIndex = 2
        Me.rBParadaSinNot.TabStop = True
        Me.rBParadaSinNot.Text = "Parada sin notificar a monitoreo"
        Me.rBParadaSinNot.UseVisualStyleBackColor = True
        '
        'rBParadaZonaPro
        '
        Me.rBParadaZonaPro.AutoSize = True
        Me.rBParadaZonaPro.Location = New System.Drawing.Point(6, 53)
        Me.rBParadaZonaPro.Name = "rBParadaZonaPro"
        Me.rBParadaZonaPro.Size = New System.Drawing.Size(200, 23)
        Me.rBParadaZonaPro.TabIndex = 1
        Me.rBParadaZonaPro.TabStop = True
        Me.rBParadaZonaPro.Text = "Parada en zona prohibida"
        Me.rBParadaZonaPro.UseVisualStyleBackColor = True
        '
        'rBOpNegoViajar
        '
        Me.rBOpNegoViajar.AutoSize = True
        Me.rBOpNegoViajar.Location = New System.Drawing.Point(6, 24)
        Me.rBOpNegoViajar.Name = "rBOpNegoViajar"
        Me.rBOpNegoViajar.Size = New System.Drawing.Size(202, 23)
        Me.rBOpNegoViajar.TabIndex = 0
        Me.rBOpNegoViajar.TabStop = True
        Me.rBOpNegoViajar.Text = "Operador se negó a viajar"
        Me.rBOpNegoViajar.UseVisualStyleBackColor = True
        '
        'bGuardar
        '
        Me.bGuardar.Image = CType(resources.GetObject("bGuardar.Image"), System.Drawing.Image)
        Me.bGuardar.Location = New System.Drawing.Point(370, 330)
        Me.bGuardar.Name = "bGuardar"
        Me.bGuardar.Size = New System.Drawing.Size(40, 40)
        Me.bGuardar.TabIndex = 1
        Me.bGuardar.UseVisualStyleBackColor = True
        '
        'bSalir
        '
        Me.bSalir.Image = CType(resources.GetObject("bSalir.Image"), System.Drawing.Image)
        Me.bSalir.Location = New System.Drawing.Point(416, 330)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(40, 40)
        Me.bSalir.TabIndex = 2
        Me.bSalir.UseVisualStyleBackColor = True
        '
        'rBOpAbandonoUnidad
        '
        Me.rBOpAbandonoUnidad.AutoSize = True
        Me.rBOpAbandonoUnidad.Location = New System.Drawing.Point(6, 82)
        Me.rBOpAbandonoUnidad.Name = "rBOpAbandonoUnidad"
        Me.rBOpAbandonoUnidad.Size = New System.Drawing.Size(233, 23)
        Me.rBOpAbandonoUnidad.TabIndex = 7
        Me.rBOpAbandonoUnidad.TabStop = True
        Me.rBOpAbandonoUnidad.Text = "Operador abandonó la unidad"
        Me.rBOpAbandonoUnidad.UseVisualStyleBackColor = True
        '
        'AgregarBitacora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 382)
        Me.Controls.Add(Me.bSalir)
        Me.Controls.Add(Me.bGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "AgregarBitacora"
        Me.Text = "Agregar bitácora"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rBParadaSinNot As System.Windows.Forms.RadioButton
    Friend WithEvents rBParadaZonaPro As System.Windows.Forms.RadioButton
    Friend WithEvents rBOpNegoViajar As System.Windows.Forms.RadioButton
    Friend WithEvents rBOpNoSePresento As System.Windows.Forms.RadioButton
    Friend WithEvents rBObservacion As System.Windows.Forms.RadioButton
    Friend WithEvents rTBObservaciones As System.Windows.Forms.RichTextBox
    Friend WithEvents bGuardar As System.Windows.Forms.Button
    Friend WithEvents bSalir As System.Windows.Forms.Button
    Friend WithEvents rBOpAbandonoUnidad As System.Windows.Forms.RadioButton
End Class
