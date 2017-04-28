<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectorColumnas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SelectorColumnas))
        Me.gridColumnas = New System.Windows.Forms.DataGridView
        Me.colColumna = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSeleccionada = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        CType(Me.gridColumnas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridColumnas
        '
        Me.gridColumnas.AllowUserToAddRows = False
        Me.gridColumnas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridColumnas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridColumnas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colColumna, Me.colSeleccionada})
        Me.gridColumnas.Location = New System.Drawing.Point(12, 12)
        Me.gridColumnas.Name = "gridColumnas"
        Me.gridColumnas.Size = New System.Drawing.Size(467, 371)
        Me.gridColumnas.TabIndex = 0
        '
        'colColumna
        '
        Me.colColumna.HeaderText = "Columna"
        Me.colColumna.Name = "colColumna"
        '
        'colSeleccionada
        '
        Me.colSeleccionada.HeaderText = "Seleccionada"
        Me.colSeleccionada.Name = "colSeleccionada"
        '
        'btnAceptar
        '
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.Location = New System.Drawing.Point(403, 389)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(35, 35)
        Me.btnAceptar.TabIndex = 1
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(444, 389)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(35, 35)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'SelectorColumnas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(491, 431)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.gridColumnas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(499, 465)
        Me.MinimumSize = New System.Drawing.Size(499, 465)
        Me.Name = "SelectorColumnas"
        Me.Text = "Selector de columnas | Seguimiento de embarques"
        CType(Me.gridColumnas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gridColumnas As System.Windows.Forms.DataGridView
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents colColumna As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSeleccionada As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
