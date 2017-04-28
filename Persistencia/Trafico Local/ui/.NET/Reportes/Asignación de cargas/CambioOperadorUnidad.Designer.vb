<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CambioOperadorUnidad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CambioOperadorUnidad))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rTBOtro = New System.Windows.Forms.RichTextBox
        Me.rBOtro = New System.Windows.Forms.RadioButton
        Me.rBPenalizacion = New System.Windows.Forms.RadioButton
        Me.rBNoSePresento = New System.Windows.Forms.RadioButton
        Me.rBNegoViaje = New System.Windows.Forms.RadioButton
        Me.bGuardar = New System.Windows.Forms.Button
        Me.bSalir = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rTBOtro)
        Me.GroupBox1.Controls.Add(Me.rBOtro)
        Me.GroupBox1.Controls.Add(Me.rBPenalizacion)
        Me.GroupBox1.Controls.Add(Me.rBNoSePresento)
        Me.GroupBox1.Controls.Add(Me.rBNegoViaje)
        Me.GroupBox1.Font = New System.Drawing.Font("Ubuntu", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(345, 198)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Motivo del cambio"
        '
        'rTBOtro
        '
        Me.rTBOtro.Location = New System.Drawing.Point(6, 140)
        Me.rTBOtro.Name = "rTBOtro"
        Me.rTBOtro.Size = New System.Drawing.Size(333, 52)
        Me.rTBOtro.TabIndex = 6
        Me.rTBOtro.Text = ""
        '
        'rBOtro
        '
        Me.rBOtro.AutoSize = True
        Me.rBOtro.Location = New System.Drawing.Point(6, 111)
        Me.rBOtro.Name = "rBOtro"
        Me.rBOtro.Size = New System.Drawing.Size(60, 23)
        Me.rBOtro.TabIndex = 5
        Me.rBOtro.TabStop = True
        Me.rBOtro.Text = "Otro"
        Me.rBOtro.UseVisualStyleBackColor = True
        '
        'rBPenalizacion
        '
        Me.rBPenalizacion.AutoSize = True
        Me.rBPenalizacion.Location = New System.Drawing.Point(6, 82)
        Me.rBPenalizacion.Name = "rBPenalizacion"
        Me.rBPenalizacion.Size = New System.Drawing.Size(184, 23)
        Me.rBPenalizacion.TabIndex = 4
        Me.rBPenalizacion.TabStop = True
        Me.rBPenalizacion.Text = "Tiene una penalización"
        Me.rBPenalizacion.UseVisualStyleBackColor = True
        '
        'rBNoSePresento
        '
        Me.rBNoSePresento.AutoSize = True
        Me.rBNoSePresento.Location = New System.Drawing.Point(6, 53)
        Me.rBNoSePresento.Name = "rBNoSePresento"
        Me.rBNoSePresento.Size = New System.Drawing.Size(197, 23)
        Me.rBNoSePresento.TabIndex = 3
        Me.rBNoSePresento.TabStop = True
        Me.rBNoSePresento.Text = "No se presentó a laborar"
        Me.rBNoSePresento.UseVisualStyleBackColor = True
        '
        'rBNegoViaje
        '
        Me.rBNegoViaje.AutoSize = True
        Me.rBNegoViaje.Location = New System.Drawing.Point(6, 24)
        Me.rBNegoViaje.Name = "rBNegoViaje"
        Me.rBNegoViaje.Size = New System.Drawing.Size(132, 23)
        Me.rBNegoViaje.TabIndex = 2
        Me.rBNegoViaje.TabStop = True
        Me.rBNegoViaje.Text = "Se negó a viajar"
        Me.rBNegoViaje.UseVisualStyleBackColor = True
        '
        'bGuardar
        '
        Me.bGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bGuardar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.bGuardar.Image = CType(resources.GetObject("bGuardar.Image"), System.Drawing.Image)
        Me.bGuardar.Location = New System.Drawing.Point(271, 216)
        Me.bGuardar.Name = "bGuardar"
        Me.bGuardar.Size = New System.Drawing.Size(40, 40)
        Me.bGuardar.TabIndex = 1
        Me.bGuardar.UseVisualStyleBackColor = True
        '
        'bSalir
        '
        Me.bSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bSalir.Image = CType(resources.GetObject("bSalir.Image"), System.Drawing.Image)
        Me.bSalir.Location = New System.Drawing.Point(317, 216)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(40, 40)
        Me.bSalir.TabIndex = 2
        Me.bSalir.UseVisualStyleBackColor = True
        '
        'CambioOperador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 268)
        Me.Controls.Add(Me.bSalir)
        Me.Controls.Add(Me.bGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(377, 302)
        Me.MinimumSize = New System.Drawing.Size(377, 302)
        Me.Name = "CambioOperador"
        Me.Text = "Cambio de operador | Asignación de cargas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents bGuardar As System.Windows.Forms.Button
    Friend WithEvents bSalir As System.Windows.Forms.Button
    Friend WithEvents rBOtro As System.Windows.Forms.RadioButton
    Friend WithEvents rBPenalizacion As System.Windows.Forms.RadioButton
    Friend WithEvents rBNoSePresento As System.Windows.Forms.RadioButton
    Friend WithEvents rBNegoViaje As System.Windows.Forms.RadioButton
    Friend WithEvents rTBOtro As System.Windows.Forms.RichTextBox
End Class
