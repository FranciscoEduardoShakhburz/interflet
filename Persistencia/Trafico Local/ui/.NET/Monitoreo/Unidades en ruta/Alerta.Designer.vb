<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alerta
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Alerta))
        Me.tiempoTranscurrido = New System.Windows.Forms.Label
        Me.btnVisto = New System.Windows.Forms.Button
        Me.btnProcedimiento = New System.Windows.Forms.Button
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox5 = New System.Windows.Forms.PictureBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.tiempo = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.etqUnidad = New System.Windows.Forms.Label
        Me.etqMensaje = New System.Windows.Forms.Label
        Me.etqTSS = New System.Windows.Forms.Label
        Me.rTBObservaciones = New System.Windows.Forms.RichTextBox
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tiempoTranscurrido
        '
        Me.tiempoTranscurrido.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tiempoTranscurrido.AutoSize = True
        Me.tiempoTranscurrido.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tiempoTranscurrido.Location = New System.Drawing.Point(411, 11)
        Me.tiempoTranscurrido.Name = "tiempoTranscurrido"
        Me.tiempoTranscurrido.Size = New System.Drawing.Size(151, 37)
        Me.tiempoTranscurrido.TabIndex = 17
        Me.tiempoTranscurrido.Text = "00:00:00"
        '
        'btnVisto
        '
        Me.btnVisto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVisto.BackColor = System.Drawing.Color.Transparent
        Me.btnVisto.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnVisto.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVisto.Location = New System.Drawing.Point(240, 537)
        Me.btnVisto.Name = "btnVisto"
        Me.btnVisto.Size = New System.Drawing.Size(568, 41)
        Me.btnVisto.TabIndex = 16
        Me.btnVisto.Text = "ALERTA ATENDIDA"
        Me.btnVisto.UseVisualStyleBackColor = False
        '
        'btnProcedimiento
        '
        Me.btnProcedimiento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcedimiento.BackColor = System.Drawing.Color.Transparent
        Me.btnProcedimiento.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnProcedimiento.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcedimiento.Location = New System.Drawing.Point(240, 490)
        Me.btnProcedimiento.Name = "btnProcedimiento"
        Me.btnProcedimiento.Size = New System.Drawing.Size(568, 41)
        Me.btnProcedimiento.TabIndex = 15
        Me.btnProcedimiento.Text = "ABRIR PROCEDIMIENTO"
        Me.btnProcedimiento.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.InitialImage = Nothing
        Me.PictureBox2.Location = New System.Drawing.Point(12, 14)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(222, 189)
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(12, 389)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(222, 189)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.InitialImage = Nothing
        Me.PictureBox5.Location = New System.Drawing.Point(814, 389)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(222, 189)
        Me.PictureBox5.TabIndex = 12
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.InitialImage = Nothing
        Me.PictureBox4.Location = New System.Drawing.Point(814, 14)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(222, 189)
        Me.PictureBox4.TabIndex = 11
        Me.PictureBox4.TabStop = False
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'tiempo
        '
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(395, 214)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 37)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "LA UNIDAD"
        '
        'etqUnidad
        '
        Me.etqUnidad.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.etqUnidad.AutoSize = True
        Me.etqUnidad.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etqUnidad.Location = New System.Drawing.Point(441, 251)
        Me.etqUnidad.Name = "etqUnidad"
        Me.etqUnidad.Size = New System.Drawing.Size(36, 37)
        Me.etqUnidad.TabIndex = 19
        Me.etqUnidad.Text = "X"
        '
        'etqMensaje
        '
        Me.etqMensaje.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.etqMensaje.AutoSize = True
        Me.etqMensaje.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etqMensaje.Location = New System.Drawing.Point(223, 288)
        Me.etqMensaje.Name = "etqMensaje"
        Me.etqMensaje.Size = New System.Drawing.Size(599, 37)
        Me.etqMensaje.TabIndex = 20
        Me.etqMensaje.Text = "HA EXCEDIDO EL TIEMPO ESTIMADO"
        '
        'etqTSS
        '
        Me.etqTSS.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.etqTSS.AutoSize = True
        Me.etqTSS.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etqTSS.Location = New System.Drawing.Point(276, 325)
        Me.etqTSS.Name = "etqTSS"
        Me.etqTSS.Size = New System.Drawing.Size(79, 37)
        Me.etqTSS.TabIndex = 21
        Me.etqTSS.Text = "TSS"
        '
        'rTBObservaciones
        '
        Me.rTBObservaciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rTBObservaciones.Location = New System.Drawing.Point(240, 405)
        Me.rTBObservaciones.Name = "rTBObservaciones"
        Me.rTBObservaciones.Size = New System.Drawing.Size(568, 79)
        Me.rTBObservaciones.TabIndex = 22
        Me.rTBObservaciones.Text = ""
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(240, 389)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Observaciones:"
        '
        'Alerta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1048, 588)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.rTBObservaciones)
        Me.Controls.Add(Me.etqTSS)
        Me.Controls.Add(Me.etqMensaje)
        Me.Controls.Add(Me.etqUnidad)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tiempoTranscurrido)
        Me.Controls.Add(Me.btnVisto)
        Me.Controls.Add(Me.btnProcedimiento)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Alerta"
        Me.Text = "¡Alerta!"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tiempoTranscurrido As System.Windows.Forms.Label
    Friend WithEvents btnVisto As System.Windows.Forms.Button
    Friend WithEvents btnProcedimiento As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents tiempo As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents etqUnidad As System.Windows.Forms.Label
    Friend WithEvents etqMensaje As System.Windows.Forms.Label
    Friend WithEvents etqTSS As System.Windows.Forms.Label
    Friend WithEvents rTBObservaciones As System.Windows.Forms.RichTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
