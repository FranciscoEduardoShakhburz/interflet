<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reporte_tramo_sencillo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reporte_tramo_sencillo))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.bto_excel = New System.Windows.Forms.Button
        Me.bto_salir = New System.Windows.Forms.Button
        Me.bto_consultar = New System.Windows.Forms.Button
        Me.cmb_fec = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.grid = New System.Windows.Forms.DataGridView
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.bto_excel)
        Me.GroupBox1.Controls.Add(Me.bto_salir)
        Me.GroupBox1.Controls.Add(Me.bto_consultar)
        Me.GroupBox1.Controls.Add(Me.cmb_fec)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(698, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(166, 420)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'bto_excel
        '
        Me.bto_excel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bto_excel.Image = CType(resources.GetObject("bto_excel.Image"), System.Drawing.Image)
        Me.bto_excel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bto_excel.Location = New System.Drawing.Point(30, 208)
        Me.bto_excel.Name = "bto_excel"
        Me.bto_excel.Size = New System.Drawing.Size(120, 40)
        Me.bto_excel.TabIndex = 11
        Me.bto_excel.Text = "   Exportar"
        Me.bto_excel.UseVisualStyleBackColor = True
        '
        'bto_salir
        '
        Me.bto_salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bto_salir.Image = CType(resources.GetObject("bto_salir.Image"), System.Drawing.Image)
        Me.bto_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bto_salir.Location = New System.Drawing.Point(30, 254)
        Me.bto_salir.Name = "bto_salir"
        Me.bto_salir.Size = New System.Drawing.Size(120, 40)
        Me.bto_salir.TabIndex = 10
        Me.bto_salir.Text = "Salir"
        Me.bto_salir.UseVisualStyleBackColor = True
        '
        'bto_consultar
        '
        Me.bto_consultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bto_consultar.Image = CType(resources.GetObject("bto_consultar.Image"), System.Drawing.Image)
        Me.bto_consultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bto_consultar.Location = New System.Drawing.Point(30, 162)
        Me.bto_consultar.Name = "bto_consultar"
        Me.bto_consultar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bto_consultar.Size = New System.Drawing.Size(120, 40)
        Me.bto_consultar.TabIndex = 9
        Me.bto_consultar.Text = "   Consultar"
        Me.bto_consultar.UseVisualStyleBackColor = True
        '
        'cmb_fec
        '
        Me.cmb_fec.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmb_fec.Location = New System.Drawing.Point(30, 44)
        Me.cmb_fec.Name = "cmb_fec"
        Me.cmb_fec.Size = New System.Drawing.Size(104, 20)
        Me.cmb_fec.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(56, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "FECHA"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.grid)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(680, 585)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'grid
        '
        Me.grid.AllowUserToAddRows = False
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Location = New System.Drawing.Point(6, 19)
        Me.grid.Name = "grid"
        Me.grid.ReadOnly = True
        Me.grid.Size = New System.Drawing.Size(668, 560)
        Me.grid.TabIndex = 1
        '
        'Reporte_tramo_sencillo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Chartreuse
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(876, 609)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(884, 643)
        Me.MinimumSize = New System.Drawing.Size(884, 643)
        Me.Name = "Reporte_tramo_sencillo"
        Me.Text = "Tramo Sencillo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents bto_excel As System.Windows.Forms.Button
    Friend WithEvents bto_salir As System.Windows.Forms.Button
    Friend WithEvents bto_consultar As System.Windows.Forms.Button
    Friend WithEvents cmb_fec As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents grid As System.Windows.Forms.DataGridView
End Class
