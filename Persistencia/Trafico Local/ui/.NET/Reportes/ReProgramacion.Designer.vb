<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReProgramacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReProgramacion))
        Me.txt_contenedor = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_observaciones = New System.Windows.Forms.TextBox
        Me.bto_salir = New System.Windows.Forms.Button
        Me.bto_agregar = New System.Windows.Forms.Button
        Me.cmb_fec = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.bto_guardar = New System.Windows.Forms.Button
        Me.grid = New System.Windows.Forms.DataGridView
        Me.Contenedor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Referencia = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_referencia = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.bto_quitar = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_contenedor
        '
        Me.txt_contenedor.Location = New System.Drawing.Point(112, 71)
        Me.txt_contenedor.Name = "txt_contenedor"
        Me.txt_contenedor.Size = New System.Drawing.Size(139, 20)
        Me.txt_contenedor.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 300)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Observaciones"
        '
        'txt_observaciones
        '
        Me.txt_observaciones.Location = New System.Drawing.Point(9, 316)
        Me.txt_observaciones.Multiline = True
        Me.txt_observaciones.Name = "txt_observaciones"
        Me.txt_observaciones.Size = New System.Drawing.Size(405, 113)
        Me.txt_observaciones.TabIndex = 4
        '
        'bto_salir
        '
        Me.bto_salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bto_salir.Image = CType(resources.GetObject("bto_salir.Image"), System.Drawing.Image)
        Me.bto_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bto_salir.Location = New System.Drawing.Point(31, 198)
        Me.bto_salir.Name = "bto_salir"
        Me.bto_salir.Size = New System.Drawing.Size(120, 40)
        Me.bto_salir.TabIndex = 5
        Me.bto_salir.Text = "Salir"
        Me.bto_salir.UseVisualStyleBackColor = True
        '
        'bto_agregar
        '
        Me.bto_agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bto_agregar.Image = CType(resources.GetObject("bto_agregar.Image"), System.Drawing.Image)
        Me.bto_agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bto_agregar.Location = New System.Drawing.Point(277, 14)
        Me.bto_agregar.Name = "bto_agregar"
        Me.bto_agregar.Size = New System.Drawing.Size(120, 40)
        Me.bto_agregar.TabIndex = 6
        Me.bto_agregar.Text = "   Agregar"
        Me.bto_agregar.UseVisualStyleBackColor = True
        '
        'cmb_fec
        '
        Me.cmb_fec.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmb_fec.Location = New System.Drawing.Point(15, 44)
        Me.cmb_fec.Name = "cmb_fec"
        Me.cmb_fec.Size = New System.Drawing.Size(153, 20)
        Me.cmb_fec.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Fecha de Re-programación"
        '
        'bto_guardar
        '
        Me.bto_guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bto_guardar.Image = CType(resources.GetObject("bto_guardar.Image"), System.Drawing.Image)
        Me.bto_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bto_guardar.Location = New System.Drawing.Point(31, 152)
        Me.bto_guardar.Name = "bto_guardar"
        Me.bto_guardar.Size = New System.Drawing.Size(120, 40)
        Me.bto_guardar.TabIndex = 9
        Me.bto_guardar.Text = "   Guardar"
        Me.bto_guardar.UseVisualStyleBackColor = True
        '
        'grid
        '
        Me.grid.AllowUserToAddRows = False
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Contenedor, Me.Cliente, Me.Referencia})
        Me.grid.Location = New System.Drawing.Point(9, 129)
        Me.grid.Name = "grid"
        Me.grid.ReadOnly = True
        Me.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid.Size = New System.Drawing.Size(405, 168)
        Me.grid.TabIndex = 10
        '
        'Contenedor
        '
        Me.Contenedor.HeaderText = "Contenedor"
        Me.Contenedor.Name = "Contenedor"
        Me.Contenedor.ReadOnly = True
        '
        'Cliente
        '
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.Name = "Cliente"
        Me.Cliente.ReadOnly = True
        '
        'Referencia
        '
        Me.Referencia.HeaderText = "Referencia"
        Me.Referencia.Name = "Referencia"
        Me.Referencia.ReadOnly = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(33, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Referencia:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "No. Contenedor:"
        '
        'txt_referencia
        '
        Me.txt_referencia.Location = New System.Drawing.Point(112, 25)
        Me.txt_referencia.Name = "txt_referencia"
        Me.txt_referencia.Size = New System.Drawing.Size(139, 20)
        Me.txt_referencia.TabIndex = 12
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.bto_quitar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_referencia)
        Me.GroupBox1.Controls.Add(Me.txt_observaciones)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_contenedor)
        Me.GroupBox1.Controls.Add(Me.bto_agregar)
        Me.GroupBox1.Controls.Add(Me.grid)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(420, 435)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'bto_quitar
        '
        Me.bto_quitar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bto_quitar.Image = CType(resources.GetObject("bto_quitar.Image"), System.Drawing.Image)
        Me.bto_quitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bto_quitar.Location = New System.Drawing.Point(277, 60)
        Me.bto_quitar.Name = "bto_quitar"
        Me.bto_quitar.Size = New System.Drawing.Size(120, 40)
        Me.bto_quitar.TabIndex = 13
        Me.bto_quitar.Text = "   Quitar"
        Me.bto_quitar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.bto_salir)
        Me.GroupBox3.Controls.Add(Me.cmb_fec)
        Me.GroupBox3.Controls.Add(Me.bto_guardar)
        Me.GroupBox3.Location = New System.Drawing.Point(438, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(178, 435)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        '
        'ReProgramacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(630, 455)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(638, 489)
        Me.MinimumSize = New System.Drawing.Size(638, 489)
        Me.Name = "ReProgramacion"
        Me.Text = "Re-Programacion | Logística"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_contenedor As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_observaciones As System.Windows.Forms.TextBox
    Friend WithEvents bto_salir As System.Windows.Forms.Button
    Friend WithEvents bto_agregar As System.Windows.Forms.Button
    Friend WithEvents cmb_fec As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents bto_guardar As System.Windows.Forms.Button
    Friend WithEvents grid As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_referencia As System.Windows.Forms.TextBox
    Friend WithEvents Contenedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Referencia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents bto_quitar As System.Windows.Forms.Button
End Class
