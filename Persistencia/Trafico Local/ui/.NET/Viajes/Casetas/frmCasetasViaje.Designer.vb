<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCasetasViaje
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCasetasViaje))
        Me.gbCasetas = New System.Windows.Forms.GroupBox
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnBorrar = New System.Windows.Forms.Button
        Me.TxtSuma = New System.Windows.Forms.TextBox
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.TxtDestino = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtOrigen = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtNoViaje = New System.Windows.Forms.MaskedTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.grdCasetas = New System.Windows.Forms.DataGridView
        Me.grdCasetasSatelital = New System.Windows.Forms.DataGridView
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.gridCasetasIAVE = New System.Windows.Forms.DataGridView
        Me.Label7 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnActualizarIAVE = New System.Windows.Forms.Button
        Me.checkCruzoTodas = New System.Windows.Forms.CheckBox
        Me.gbCasetas.SuspendLayout()
        CType(Me.grdCasetas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdCasetasSatelital, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridCasetasIAVE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbCasetas
        '
        Me.gbCasetas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbCasetas.BackColor = System.Drawing.Color.Transparent
        Me.gbCasetas.Controls.Add(Me.btnSalir)
        Me.gbCasetas.Controls.Add(Me.btnBorrar)
        Me.gbCasetas.Controls.Add(Me.TxtSuma)
        Me.gbCasetas.Controls.Add(Me.btnGuardar)
        Me.gbCasetas.Controls.Add(Me.TxtDestino)
        Me.gbCasetas.Controls.Add(Me.Label3)
        Me.gbCasetas.Controls.Add(Me.TxtOrigen)
        Me.gbCasetas.Controls.Add(Me.Label2)
        Me.gbCasetas.Controls.Add(Me.TxtNoViaje)
        Me.gbCasetas.Controls.Add(Me.Label1)
        Me.gbCasetas.Controls.Add(Me.Label4)
        Me.gbCasetas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbCasetas.Location = New System.Drawing.Point(7, 8)
        Me.gbCasetas.Name = "gbCasetas"
        Me.gbCasetas.Size = New System.Drawing.Size(885, 70)
        Me.gbCasetas.TabIndex = 0
        Me.gbCasetas.TabStop = False
        Me.gbCasetas.Text = "Casetas del Viaje"
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Location = New System.Drawing.Point(762, 20)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(117, 34)
        Me.btnSalir.TabIndex = 14
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnBorrar
        '
        Me.btnBorrar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnBorrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBorrar.Enabled = False
        Me.btnBorrar.Location = New System.Drawing.Point(535, 20)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(70, 34)
        Me.btnBorrar.TabIndex = 13
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = False
        '
        'TxtSuma
        '
        Me.TxtSuma.Enabled = False
        Me.TxtSuma.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSuma.Location = New System.Drawing.Point(665, 26)
        Me.TxtSuma.Name = "TxtSuma"
        Me.TxtSuma.Size = New System.Drawing.Size(76, 21)
        Me.TxtSuma.TabIndex = 11
        Me.TxtSuma.Text = "0"
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnGuardar.Location = New System.Drawing.Point(453, 20)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(76, 34)
        Me.btnGuardar.TabIndex = 10
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'TxtDestino
        '
        Me.TxtDestino.Enabled = False
        Me.TxtDestino.Location = New System.Drawing.Point(244, 33)
        Me.TxtDestino.Name = "TxtDestino"
        Me.TxtDestino.Size = New System.Drawing.Size(203, 21)
        Me.TxtDestino.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(246, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Ruta:"
        '
        'TxtOrigen
        '
        Me.TxtOrigen.Enabled = False
        Me.TxtOrigen.Location = New System.Drawing.Point(86, 33)
        Me.TxtOrigen.Name = "TxtOrigen"
        Me.TxtOrigen.Size = New System.Drawing.Size(150, 21)
        Me.TxtOrigen.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(86, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Plaza Origen:"
        '
        'TxtNoViaje
        '
        Me.TxtNoViaje.Enabled = False
        Me.TxtNoViaje.Location = New System.Drawing.Point(7, 33)
        Me.TxtNoViaje.Mask = "9999999999"
        Me.TxtNoViaje.Name = "TxtNoViaje"
        Me.TxtNoViaje.Size = New System.Drawing.Size(72, 21)
        Me.TxtNoViaje.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "No. Viaje:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(611, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 15)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Suma:"
        '
        'grdCasetas
        '
        Me.grdCasetas.AllowUserToAddRows = False
        Me.grdCasetas.AllowUserToDeleteRows = False
        Me.grdCasetas.AllowUserToOrderColumns = True
        Me.grdCasetas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdCasetas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdCasetas.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.grdCasetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdCasetas.GridColor = System.Drawing.SystemColors.ControlLight
        Me.grdCasetas.Location = New System.Drawing.Point(15, 113)
        Me.grdCasetas.Name = "grdCasetas"
        Me.grdCasetas.RowHeadersWidth = 15
        Me.grdCasetas.Size = New System.Drawing.Size(531, 214)
        Me.grdCasetas.TabIndex = 1
        '
        'grdCasetasSatelital
        '
        Me.grdCasetasSatelital.AllowUserToAddRows = False
        Me.grdCasetasSatelital.AllowUserToDeleteRows = False
        Me.grdCasetasSatelital.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdCasetasSatelital.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdCasetasSatelital.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.grdCasetasSatelital.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdCasetasSatelital.Location = New System.Drawing.Point(552, 114)
        Me.grdCasetasSatelital.Name = "grdCasetasSatelital"
        Me.grdCasetasSatelital.ReadOnly = True
        Me.grdCasetasSatelital.RowHeadersWidth = 15
        Me.grdCasetasSatelital.Size = New System.Drawing.Size(343, 213)
        Me.grdCasetasSatelital.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 15)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Casetas LIS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(549, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 15)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Casetas Satelital"
        '
        'gridCasetasIAVE
        '
        Me.gridCasetasIAVE.AllowUserToAddRows = False
        Me.gridCasetasIAVE.AllowUserToDeleteRows = False
        Me.gridCasetasIAVE.AllowUserToOrderColumns = True
        Me.gridCasetasIAVE.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridCasetasIAVE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridCasetasIAVE.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.gridCasetasIAVE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridCasetasIAVE.Location = New System.Drawing.Point(14, 347)
        Me.gridCasetasIAVE.Name = "gridCasetasIAVE"
        Me.gridCasetasIAVE.Size = New System.Drawing.Size(880, 194)
        Me.gridCasetasIAVE.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 329)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 15)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Casetas IAVE"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(96, 81)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 26)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Agregar Casetas"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'btnActualizarIAVE
        '
        Me.btnActualizarIAVE.Location = New System.Drawing.Point(434, 81)
        Me.btnActualizarIAVE.Name = "btnActualizarIAVE"
        Me.btnActualizarIAVE.Size = New System.Drawing.Size(112, 26)
        Me.btnActualizarIAVE.TabIndex = 20
        Me.btnActualizarIAVE.Text = "Actualizar IAVE"
        Me.btnActualizarIAVE.UseVisualStyleBackColor = True
        '
        'checkCruzoTodas
        '
        Me.checkCruzoTodas.AutoSize = True
        Me.checkCruzoTodas.BackColor = System.Drawing.Color.Transparent
        Me.checkCruzoTodas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkCruzoTodas.Location = New System.Drawing.Point(214, 85)
        Me.checkCruzoTodas.Name = "checkCruzoTodas"
        Me.checkCruzoTodas.Size = New System.Drawing.Size(175, 17)
        Me.checkCruzoTodas.TabIndex = 15
        Me.checkCruzoTodas.Text = "¿Cruzó todas las casetas?"
        Me.checkCruzoTodas.UseVisualStyleBackColor = False
        '
        'frmCasetasViaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(904, 553)
        Me.Controls.Add(Me.checkCruzoTodas)
        Me.Controls.Add(Me.btnActualizarIAVE)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.gridCasetasIAVE)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.grdCasetasSatelital)
        Me.Controls.Add(Me.grdCasetas)
        Me.Controls.Add(Me.gbCasetas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCasetasViaje"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Casetas a Transitar en el Viaje"
        Me.gbCasetas.ResumeLayout(False)
        Me.gbCasetas.PerformLayout()
        CType(Me.grdCasetas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdCasetasSatelital, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridCasetasIAVE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbCasetas As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtNoViaje As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtDestino As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtOrigen As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents TxtSuma As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents grdCasetas As System.Windows.Forms.DataGridView
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents grdCasetasSatelital As System.Windows.Forms.DataGridView
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents gridCasetasIAVE As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnActualizarIAVE As System.Windows.Forms.Button
    Friend WithEvents checkCruzoTodas As System.Windows.Forms.CheckBox
End Class
