<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCasetasGastos
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
        Me.gridF_iave = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.gridS_iave = New System.Windows.Forms.DataGridView
        Me.Label2 = New System.Windows.Forms.Label
        Me.gridF_efectivo = New System.Windows.Forms.DataGridView
        Me.gridS_efectivo = New System.Windows.Forms.DataGridView
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.grid_tramos = New System.Windows.Forms.DataGridView
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.grid_convenios = New System.Windows.Forms.DataGridView
        CType(Me.gridF_iave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridS_iave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridF_efectivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridS_efectivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_tramos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_convenios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridF_iave
        '
        Me.gridF_iave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridF_iave.Location = New System.Drawing.Point(24, 45)
        Me.gridF_iave.Name = "gridF_iave"
        Me.gridF_iave.Size = New System.Drawing.Size(260, 217)
        Me.gridF_iave.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(237, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Casetas en FULL"
        '
        'gridS_iave
        '
        Me.gridS_iave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridS_iave.Location = New System.Drawing.Point(24, 327)
        Me.gridS_iave.Name = "gridS_iave"
        Me.gridS_iave.Size = New System.Drawing.Size(260, 222)
        Me.gridS_iave.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(237, 279)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Casetas en Sencillo"
        '
        'gridF_efectivo
        '
        Me.gridF_efectivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridF_efectivo.Location = New System.Drawing.Point(321, 45)
        Me.gridF_efectivo.Name = "gridF_efectivo"
        Me.gridF_efectivo.Size = New System.Drawing.Size(240, 217)
        Me.gridF_efectivo.TabIndex = 4
        '
        'gridS_efectivo
        '
        Me.gridS_efectivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridS_efectivo.Location = New System.Drawing.Point(321, 327)
        Me.gridS_efectivo.Name = "gridS_efectivo"
        Me.gridS_efectivo.Size = New System.Drawing.Size(240, 222)
        Me.gridS_efectivo.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(94, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Casetas IAVE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(421, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Casetas Efectivo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(94, 297)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Cesatas IAVE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(421, 297)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Casetas Efectivo"
        '
        'grid_tramos
        '
        Me.grid_tramos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_tramos.Location = New System.Drawing.Point(603, 45)
        Me.grid_tramos.Name = "grid_tramos"
        Me.grid_tramos.Size = New System.Drawing.Size(178, 217)
        Me.grid_tramos.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(658, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "TRAMOS"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(736, 297)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "CONVENIO"
        '
        'grid_convenios
        '
        Me.grid_convenios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_convenios.Location = New System.Drawing.Point(581, 327)
        Me.grid_convenios.Name = "grid_convenios"
        Me.grid_convenios.Size = New System.Drawing.Size(380, 222)
        Me.grid_convenios.TabIndex = 13
        '
        'FrmCasetasGastos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(973, 580)
        Me.Controls.Add(Me.grid_convenios)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.grid_tramos)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.gridS_efectivo)
        Me.Controls.Add(Me.gridF_efectivo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.gridS_iave)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gridF_iave)
        Me.Name = "FrmCasetasGastos"
        Me.Text = "FrmCasetasGastos"
        CType(Me.gridF_iave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridS_iave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridF_efectivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridS_efectivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_tramos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_convenios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gridF_iave As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gridS_iave As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gridF_efectivo As System.Windows.Forms.DataGridView
    Friend WithEvents gridS_efectivo As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents grid_tramos As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents grid_convenios As System.Windows.Forms.DataGridView
End Class
