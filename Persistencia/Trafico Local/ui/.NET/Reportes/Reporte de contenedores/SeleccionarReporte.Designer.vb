<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SeleccionarReporte
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SeleccionarReporte))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rdbtnCargasPase = New System.Windows.Forms.RadioButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.dteHasta = New System.Windows.Forms.DateTimePicker
        Me.dteDesde = New System.Windows.Forms.DateTimePicker
        Me.rdBtnRepGeneral = New System.Windows.Forms.RadioButton
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rdbtnCargasPase)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dteHasta)
        Me.GroupBox1.Controls.Add(Me.dteDesde)
        Me.GroupBox1.Controls.Add(Me.rdBtnRepGeneral)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(391, 116)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione un reporte:"
        '
        'rdbtnCargasPase
        '
        Me.rdbtnCargasPase.AutoSize = True
        Me.rdbtnCargasPase.Location = New System.Drawing.Point(35, 83)
        Me.rdbtnCargasPase.Name = "rdbtnCargasPase"
        Me.rdbtnCargasPase.Size = New System.Drawing.Size(204, 17)
        Me.rdbtnCargasPase.TabIndex = 5
        Me.rdbtnCargasPase.TabStop = True
        Me.rdbtnCargasPase.Text = "Cargas en patio DAH con pase "
        Me.rdbtnCargasPase.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(206, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Hasta:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Desde:"
        '
        'dteHasta
        '
        Me.dteHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteHasta.Location = New System.Drawing.Point(256, 47)
        Me.dteHasta.Name = "dteHasta"
        Me.dteHasta.Size = New System.Drawing.Size(95, 20)
        Me.dteHasta.TabIndex = 2
        '
        'dteDesde
        '
        Me.dteDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteDesde.Location = New System.Drawing.Point(105, 47)
        Me.dteDesde.Name = "dteDesde"
        Me.dteDesde.Size = New System.Drawing.Size(95, 20)
        Me.dteDesde.TabIndex = 1
        '
        'rdBtnRepGeneral
        '
        Me.rdBtnRepGeneral.AutoSize = True
        Me.rdBtnRepGeneral.Location = New System.Drawing.Point(35, 24)
        Me.rdBtnRepGeneral.Name = "rdBtnRepGeneral"
        Me.rdBtnRepGeneral.Size = New System.Drawing.Size(116, 17)
        Me.rdBtnRepGeneral.TabIndex = 0
        Me.rdBtnRepGeneral.TabStop = True
        Me.rdBtnRepGeneral.Text = "Reporte general"
        Me.rdBtnRepGeneral.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(157, 134)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(120, 40)
        Me.btnAceptar.TabIndex = 1
        Me.btnAceptar.Text = "   Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(283, 134)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(120, 40)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "   Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'SeleccionarReporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(415, 182)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(423, 216)
        Me.MinimumSize = New System.Drawing.Size(423, 216)
        Me.Name = "SeleccionarReporte"
        Me.Text = "Reportes | Estatus de contenedores"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents dteDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents rdBtnRepGeneral As System.Windows.Forms.RadioButton
    Friend WithEvents rdbtnCargasPase As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dteHasta As System.Windows.Forms.DateTimePicker
End Class
