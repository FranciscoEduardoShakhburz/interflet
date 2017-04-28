<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReporteFacPase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReporteFacPase))
        Me.Label1 = New System.Windows.Forms.Label
        Me.dt_fecIni = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.dt_fecFin = New System.Windows.Forms.DateTimePicker
        Me.bto_consultar = New System.Windows.Forms.Button
        Me.bto_Excel = New System.Windows.Forms.Button
        Me.bto_salir = New System.Windows.Forms.Button
        Me.grid = New System.Windows.Forms.DataGridView
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha Inicial"
        '
        'dt_fecIni
        '
        Me.dt_fecIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_fecIni.Location = New System.Drawing.Point(111, 14)
        Me.dt_fecIni.Name = "dt_fecIni"
        Me.dt_fecIni.Size = New System.Drawing.Size(99, 20)
        Me.dt_fecIni.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(230, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha Final"
        '
        'dt_fecFin
        '
        Me.dt_fecFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_fecFin.Location = New System.Drawing.Point(309, 14)
        Me.dt_fecFin.Name = "dt_fecFin"
        Me.dt_fecFin.Size = New System.Drawing.Size(94, 20)
        Me.dt_fecFin.TabIndex = 3
        '
        'bto_consultar
        '
        Me.bto_consultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bto_consultar.Location = New System.Drawing.Point(565, 14)
        Me.bto_consultar.Name = "bto_consultar"
        Me.bto_consultar.Size = New System.Drawing.Size(75, 23)
        Me.bto_consultar.TabIndex = 4
        Me.bto_consultar.Text = "Consultar"
        Me.bto_consultar.UseVisualStyleBackColor = True
        '
        'bto_Excel
        '
        Me.bto_Excel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bto_Excel.Location = New System.Drawing.Point(528, 273)
        Me.bto_Excel.Name = "bto_Excel"
        Me.bto_Excel.Size = New System.Drawing.Size(75, 23)
        Me.bto_Excel.TabIndex = 5
        Me.bto_Excel.Text = "Excel"
        Me.bto_Excel.UseVisualStyleBackColor = True
        '
        'bto_salir
        '
        Me.bto_salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bto_salir.Location = New System.Drawing.Point(461, 14)
        Me.bto_salir.Name = "bto_salir"
        Me.bto_salir.Size = New System.Drawing.Size(75, 23)
        Me.bto_salir.TabIndex = 6
        Me.bto_salir.Text = "Salir"
        Me.bto_salir.UseVisualStyleBackColor = True
        '
        'grid
        '
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Location = New System.Drawing.Point(15, 58)
        Me.grid.Name = "grid"
        Me.grid.Size = New System.Drawing.Size(641, 194)
        Me.grid.TabIndex = 7
        '
        'FrmReporteFacPase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(664, 308)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.bto_salir)
        Me.Controls.Add(Me.bto_Excel)
        Me.Controls.Add(Me.bto_consultar)
        Me.Controls.Add(Me.dt_fecFin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dt_fecIni)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmReporteFacPase"
        Me.Text = "FrmReporteFacPase"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dt_fecIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dt_fecFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents bto_consultar As System.Windows.Forms.Button
    Friend WithEvents bto_Excel As System.Windows.Forms.Button
    Friend WithEvents bto_salir As System.Windows.Forms.Button
    Friend WithEvents grid As System.Windows.Forms.DataGridView
End Class
