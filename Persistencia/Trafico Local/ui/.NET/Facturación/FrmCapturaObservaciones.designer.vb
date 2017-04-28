<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCapturaObservaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCapturaObservaciones))
        Me.cmd_errores = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.B_Guardar = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtObsev = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Textcp = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'cmd_errores
        '
        Me.cmd_errores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmd_errores.Enabled = False
        Me.cmd_errores.FormattingEnabled = True
        Me.cmd_errores.Items.AddRange(New Object() {"Mal Documentado", "Falta Documentacion", "Tarifa Erronea"})
        Me.cmd_errores.Location = New System.Drawing.Point(106, 53)
        Me.cmd_errores.Name = "cmd_errores"
        Me.cmd_errores.Size = New System.Drawing.Size(121, 21)
        Me.cmd_errores.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(53, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Errores"
        '
        'B_Guardar
        '
        Me.B_Guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_Guardar.Location = New System.Drawing.Point(426, 244)
        Me.B_Guardar.Name = "B_Guardar"
        Me.B_Guardar.Size = New System.Drawing.Size(75, 23)
        Me.B_Guardar.TabIndex = 2
        Me.B_Guardar.Text = "MODIFICAR"
        Me.B_Guardar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Observaciones :"
        '
        'txtObsev
        '
        Me.txtObsev.Enabled = False
        Me.txtObsev.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObsev.Location = New System.Drawing.Point(106, 78)
        Me.txtObsev.MaxLength = 500
        Me.txtObsev.Multiline = True
        Me.txtObsev.Name = "txtObsev"
        Me.txtObsev.Size = New System.Drawing.Size(569, 150)
        Me.txtObsev.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(507, 244)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "SALIR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Carta Porte:"
        '
        'Textcp
        '
        Me.Textcp.Enabled = False
        Me.Textcp.Location = New System.Drawing.Point(106, 12)
        Me.Textcp.Name = "Textcp"
        Me.Textcp.Size = New System.Drawing.Size(121, 20)
        Me.Textcp.TabIndex = 7
        '
        'FrmCapturaObservaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(687, 279)
        Me.Controls.Add(Me.Textcp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtObsev)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.B_Guardar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmd_errores)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCapturaObservaciones"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Observaciones"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmd_errores As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents B_Guardar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtObsev As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Textcp As System.Windows.Forms.TextBox

End Class
