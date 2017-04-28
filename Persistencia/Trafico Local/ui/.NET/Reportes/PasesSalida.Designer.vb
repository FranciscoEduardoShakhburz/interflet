<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PasesSalida
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PasesSalida))
        Me.grid = New System.Windows.Forms.DataGridView
        Me.bto_salir = New System.Windows.Forms.Button
        Me.bto_excel = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.dteHasta = New System.Windows.Forms.DateTimePicker
        Me.dteDesde = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.bto_consultar = New System.Windows.Forms.Button
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'grid
        '
        Me.grid.AllowUserToAddRows = False
        Me.grid.AllowUserToDeleteRows = False
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid.DefaultCellStyle = DataGridViewCellStyle8
        Me.grid.Location = New System.Drawing.Point(6, 19)
        Me.grid.Name = "grid"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.grid.Size = New System.Drawing.Size(851, 316)
        Me.grid.TabIndex = 0
        '
        'bto_salir
        '
        Me.bto_salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bto_salir.Image = CType(resources.GetObject("bto_salir.Image"), System.Drawing.Image)
        Me.bto_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bto_salir.Location = New System.Drawing.Point(410, 22)
        Me.bto_salir.Name = "bto_salir"
        Me.bto_salir.Size = New System.Drawing.Size(120, 40)
        Me.bto_salir.TabIndex = 1
        Me.bto_salir.Text = "Salir"
        Me.bto_salir.UseVisualStyleBackColor = True
        '
        'bto_excel
        '
        Me.bto_excel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bto_excel.Image = CType(resources.GetObject("bto_excel.Image"), System.Drawing.Image)
        Me.bto_excel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bto_excel.Location = New System.Drawing.Point(284, 22)
        Me.bto_excel.Name = "bto_excel"
        Me.bto_excel.Size = New System.Drawing.Size(120, 40)
        Me.bto_excel.TabIndex = 3
        Me.bto_excel.Text = "Excel"
        Me.bto_excel.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.grid)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 95)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(863, 341)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.dteHasta)
        Me.GroupBox2.Controls.Add(Me.dteDesde)
        Me.GroupBox2.Controls.Add(Me.bto_salir)
        Me.GroupBox2.Controls.Add(Me.bto_excel)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.bto_consultar)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(863, 77)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtrar búsqueda por fechas"
        '
        'dteHasta
        '
        Me.dteHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteHasta.Location = New System.Drawing.Point(59, 44)
        Me.dteHasta.Name = "dteHasta"
        Me.dteHasta.Size = New System.Drawing.Size(93, 20)
        Me.dteHasta.TabIndex = 4
        '
        'dteDesde
        '
        Me.dteDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteDesde.Location = New System.Drawing.Point(59, 18)
        Me.dteDesde.Name = "dteDesde"
        Me.dteDesde.Size = New System.Drawing.Size(93, 20)
        Me.dteDesde.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Hasta:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Desde:"
        '
        'bto_consultar
        '
        Me.bto_consultar.Image = CType(resources.GetObject("bto_consultar.Image"), System.Drawing.Image)
        Me.bto_consultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bto_consultar.Location = New System.Drawing.Point(158, 22)
        Me.bto_consultar.Name = "bto_consultar"
        Me.bto_consultar.Size = New System.Drawing.Size(120, 40)
        Me.bto_consultar.TabIndex = 0
        Me.bto_consultar.Text = "   Consultar"
        Me.bto_consultar.UseVisualStyleBackColor = True
        '
        'PasesSalida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(884, 588)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(892, 622)
        Me.MinimumSize = New System.Drawing.Size(892, 622)
        Me.Name = "PasesSalida"
        Me.Text = "Pases de Salida | Logística"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grid As System.Windows.Forms.DataGridView
    Friend WithEvents bto_salir As System.Windows.Forms.Button
    Friend WithEvents bto_excel As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents bto_consultar As System.Windows.Forms.Button
    Friend WithEvents dteHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dteDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
