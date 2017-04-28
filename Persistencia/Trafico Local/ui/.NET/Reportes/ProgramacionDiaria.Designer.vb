<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProgramacionDiaria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProgramacionDiaria))
        Me.grid = New System.Windows.Forms.DataGridView
        Me.bto_salir = New System.Windows.Forms.Button
        Me.bto_guardar = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'grid
        '
        Me.grid.AllowUserToAddRows = False
        Me.grid.AllowUserToDeleteRows = False
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Location = New System.Drawing.Point(6, 19)
        Me.grid.Name = "grid"
        Me.grid.Size = New System.Drawing.Size(843, 396)
        Me.grid.TabIndex = 0
        '
        'bto_salir
        '
        Me.bto_salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bto_salir.Image = CType(resources.GetObject("bto_salir.Image"), System.Drawing.Image)
        Me.bto_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bto_salir.Location = New System.Drawing.Point(308, 42)
        Me.bto_salir.Name = "bto_salir"
        Me.bto_salir.Size = New System.Drawing.Size(120, 40)
        Me.bto_salir.TabIndex = 1
        Me.bto_salir.Text = "Salir"
        Me.bto_salir.UseVisualStyleBackColor = True
        '
        'bto_guardar
        '
        Me.bto_guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bto_guardar.Image = CType(resources.GetObject("bto_guardar.Image"), System.Drawing.Image)
        Me.bto_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bto_guardar.Location = New System.Drawing.Point(434, 42)
        Me.bto_guardar.Name = "bto_guardar"
        Me.bto_guardar.Size = New System.Drawing.Size(120, 40)
        Me.bto_guardar.TabIndex = 3
        Me.bto_guardar.Text = "   Guardar"
        Me.bto_guardar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.grid)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(855, 421)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.bto_salir)
        Me.GroupBox2.Controls.Add(Me.bto_guardar)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 439)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(664, 146)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        'ProgramacionDiaria
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(879, 597)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(887, 631)
        Me.MinimumSize = New System.Drawing.Size(887, 631)
        Me.Name = "ProgramacionDiaria"
        Me.Text = "Programacion Diaria | Logística"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grid As System.Windows.Forms.DataGridView
    Friend WithEvents bto_salir As System.Windows.Forms.Button
    Friend WithEvents bto_guardar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
