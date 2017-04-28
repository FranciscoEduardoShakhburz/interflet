<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UltimasCartasPorte
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UltimasCartasPorte))
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnGenerar = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        Me.rdBtnUnidad = New System.Windows.Forms.RadioButton
        Me.rdBtnDias = New System.Windows.Forms.RadioButton
        Me.chkActivos = New System.Windows.Forms.CheckBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(78, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Reporte de Cartas porte"
        '
        'btnGenerar
        '
        Me.btnGenerar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerar.Image = CType(resources.GetObject("btnGenerar.Image"), System.Drawing.Image)
        Me.btnGenerar.Location = New System.Drawing.Point(46, 119)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(140, 60)
        Me.btnGenerar.TabIndex = 1
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(236, 119)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(140, 60)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'rdBtnUnidad
        '
        Me.rdBtnUnidad.AutoSize = True
        Me.rdBtnUnidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdBtnUnidad.Location = New System.Drawing.Point(12, 47)
        Me.rdBtnUnidad.Name = "rdBtnUnidad"
        Me.rdBtnUnidad.Size = New System.Drawing.Size(201, 17)
        Me.rdBtnUnidad.TabIndex = 3
        Me.rdBtnUnidad.TabStop = True
        Me.rdBtnUnidad.Text = "Ordenar por numero de unidad:"
        Me.rdBtnUnidad.UseVisualStyleBackColor = True
        '
        'rdBtnDias
        '
        Me.rdBtnDias.AutoSize = True
        Me.rdBtnDias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdBtnDias.Location = New System.Drawing.Point(219, 47)
        Me.rdBtnDias.Name = "rdBtnDias"
        Me.rdBtnDias.Size = New System.Drawing.Size(218, 17)
        Me.rdBtnDias.TabIndex = 4
        Me.rdBtnDias.TabStop = True
        Me.rdBtnDias.Text = "Ordenar por no. de días sin movs."
        Me.rdBtnDias.UseVisualStyleBackColor = True
        '
        'chkActivos
        '
        Me.chkActivos.AutoSize = True
        Me.chkActivos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActivos.Location = New System.Drawing.Point(12, 85)
        Me.chkActivos.Name = "chkActivos"
        Me.chkActivos.Size = New System.Drawing.Size(195, 17)
        Me.chkActivos.TabIndex = 5
        Me.chkActivos.Text = "Mostrar solo unidades activas"
        Me.chkActivos.UseVisualStyleBackColor = True
        '
        'UltimasCartasPorte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 191)
        Me.Controls.Add(Me.chkActivos)
        Me.Controls.Add(Me.rdBtnDias)
        Me.Controls.Add(Me.rdBtnUnidad)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "UltimasCartasPorte"
        Me.Text = "Rep. Ultima Cartas Porte | "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnGenerar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents rdBtnUnidad As System.Windows.Forms.RadioButton
    Friend WithEvents rdBtnDias As System.Windows.Forms.RadioButton
    Friend WithEvents chkActivos As System.Windows.Forms.CheckBox
End Class
