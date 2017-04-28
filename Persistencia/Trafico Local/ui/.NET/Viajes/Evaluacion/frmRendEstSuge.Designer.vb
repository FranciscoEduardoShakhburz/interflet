<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRendEstSuge
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
        Me.grid = New System.Windows.Forms.DataGridView
        Me.bto_salir = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_cliente = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_destino = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt_mes = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_peso = New System.Windows.Forms.TextBox
        Me.bto_calcular = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_litros = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txt_rend = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txt_km = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txt_plaza = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txt_ruta = New System.Windows.Forms.TextBox
        Me.lbl_id = New System.Windows.Forms.Label
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid
        '
        Me.grid.AllowUserToAddRows = False
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Location = New System.Drawing.Point(12, 40)
        Me.grid.Name = "grid"
        Me.grid.ReadOnly = True
        Me.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid.Size = New System.Drawing.Size(1173, 233)
        Me.grid.TabIndex = 0
        '
        'bto_salir
        '
        Me.bto_salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bto_salir.Location = New System.Drawing.Point(800, 353)
        Me.bto_salir.Name = "bto_salir"
        Me.bto_salir.Size = New System.Drawing.Size(92, 23)
        Me.bto_salir.TabIndex = 1
        Me.bto_salir.Text = "SALIR"
        Me.bto_salir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-1, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cliente"
        '
        'txt_cliente
        '
        Me.txt_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cliente.Location = New System.Drawing.Point(61, 10)
        Me.txt_cliente.Name = "txt_cliente"
        Me.txt_cliente.Size = New System.Drawing.Size(182, 20)
        Me.txt_cliente.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(305, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Destino"
        '
        'txt_destino
        '
        Me.txt_destino.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_destino.Location = New System.Drawing.Point(372, 13)
        Me.txt_destino.Name = "txt_destino"
        Me.txt_destino.Size = New System.Drawing.Size(192, 20)
        Me.txt_destino.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(71, 349)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Meses Atras"
        '
        'txt_mes
        '
        Me.txt_mes.Location = New System.Drawing.Point(189, 349)
        Me.txt_mes.Name = "txt_mes"
        Me.txt_mes.Size = New System.Drawing.Size(78, 20)
        Me.txt_mes.TabIndex = 7
        Me.txt_mes.Text = "6"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(334, 356)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Rango +/- Peso"
        '
        'txt_peso
        '
        Me.txt_peso.Location = New System.Drawing.Point(483, 353)
        Me.txt_peso.Name = "txt_peso"
        Me.txt_peso.Size = New System.Drawing.Size(85, 20)
        Me.txt_peso.TabIndex = 9
        Me.txt_peso.Tag = ""
        Me.txt_peso.Text = "5"
        '
        'bto_calcular
        '
        Me.bto_calcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bto_calcular.Location = New System.Drawing.Point(659, 353)
        Me.bto_calcular.Name = "bto_calcular"
        Me.bto_calcular.Size = New System.Drawing.Size(82, 23)
        Me.bto_calcular.TabIndex = 10
        Me.bto_calcular.Text = "CALCULAR"
        Me.bto_calcular.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(150, 307)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Promedios"
        '
        'txt_litros
        '
        Me.txt_litros.Location = New System.Drawing.Point(264, 300)
        Me.txt_litros.Name = "txt_litros"
        Me.txt_litros.ReadOnly = True
        Me.txt_litros.Size = New System.Drawing.Size(113, 20)
        Me.txt_litros.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(314, 276)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Litros"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(448, 276)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Rend. Real"
        '
        'txt_rend
        '
        Me.txt_rend.Location = New System.Drawing.Point(433, 300)
        Me.txt_rend.Name = "txt_rend"
        Me.txt_rend.ReadOnly = True
        Me.txt_rend.Size = New System.Drawing.Size(100, 20)
        Me.txt_rend.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(619, 276)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "KMS"
        '
        'txt_km
        '
        Me.txt_km.Location = New System.Drawing.Point(583, 300)
        Me.txt_km.Name = "txt_km"
        Me.txt_km.ReadOnly = True
        Me.txt_km.Size = New System.Drawing.Size(100, 20)
        Me.txt_km.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(580, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Plaza"
        '
        'txt_plaza
        '
        Me.txt_plaza.Location = New System.Drawing.Point(622, 14)
        Me.txt_plaza.Name = "txt_plaza"
        Me.txt_plaza.Size = New System.Drawing.Size(100, 20)
        Me.txt_plaza.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(740, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Ruta"
        '
        'txt_ruta
        '
        Me.txt_ruta.Location = New System.Drawing.Point(780, 13)
        Me.txt_ruta.Name = "txt_ruta"
        Me.txt_ruta.Size = New System.Drawing.Size(121, 20)
        Me.txt_ruta.TabIndex = 21
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.Location = New System.Drawing.Point(249, 15)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(35, 13)
        Me.lbl_id.TabIndex = 22
        Me.lbl_id.Text = "Labe"
        '
        'frmRendEstSuge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1197, 397)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.txt_ruta)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_plaza)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_km)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_rend)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_litros)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.bto_calcular)
        Me.Controls.Add(Me.txt_peso)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_mes)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_destino)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_cliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bto_salir)
        Me.Controls.Add(Me.grid)
        Me.Name = "frmRendEstSuge"
        Me.Text = "frmRendEstSuge"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grid As System.Windows.Forms.DataGridView
    Friend WithEvents bto_salir As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_cliente As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_destino As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_mes As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_peso As System.Windows.Forms.TextBox
    Friend WithEvents bto_calcular As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_litros As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_rend As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_km As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_plaza As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_ruta As System.Windows.Forms.TextBox
    Friend WithEvents lbl_id As System.Windows.Forms.Label
End Class
