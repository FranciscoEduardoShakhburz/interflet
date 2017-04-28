<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SeleccionarPrioridadCargas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SeleccionarPrioridadCargas))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dGVPrioridad = New System.Windows.Forms.DataGridView
        Me.colPrioridad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colContenedor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDestino = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.bAceptar = New System.Windows.Forms.Button
        Me.bCancelar = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.dGVPrioridad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dGVPrioridad)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(828, 137)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione la prioridad de las cargas:"
        '
        'dGVPrioridad
        '
        Me.dGVPrioridad.AllowUserToAddRows = False
        Me.dGVPrioridad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dGVPrioridad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dGVPrioridad.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colPrioridad, Me.colContenedor, Me.colDestino, Me.colCliente})
        Me.dGVPrioridad.Location = New System.Drawing.Point(8, 25)
        Me.dGVPrioridad.Margin = New System.Windows.Forms.Padding(4)
        Me.dGVPrioridad.Name = "dGVPrioridad"
        Me.dGVPrioridad.Size = New System.Drawing.Size(812, 104)
        Me.dGVPrioridad.TabIndex = 1
        '
        'colPrioridad
        '
        Me.colPrioridad.HeaderText = "Prioridad"
        Me.colPrioridad.Name = "colPrioridad"
        '
        'colContenedor
        '
        Me.colContenedor.HeaderText = "Contenedor"
        Me.colContenedor.Name = "colContenedor"
        '
        'colDestino
        '
        Me.colDestino.HeaderText = "Destino"
        Me.colDestino.Name = "colDestino"
        '
        'colCliente
        '
        Me.colCliente.HeaderText = "Cliente"
        Me.colCliente.Name = "colCliente"
        '
        'bAceptar
        '
        Me.bAceptar.Image = CType(resources.GetObject("bAceptar.Image"), System.Drawing.Image)
        Me.bAceptar.Location = New System.Drawing.Point(756, 157)
        Me.bAceptar.Name = "bAceptar"
        Me.bAceptar.Size = New System.Drawing.Size(40, 40)
        Me.bAceptar.TabIndex = 1
        Me.bAceptar.UseVisualStyleBackColor = True
        '
        'bCancelar
        '
        Me.bCancelar.Image = CType(resources.GetObject("bCancelar.Image"), System.Drawing.Image)
        Me.bCancelar.Location = New System.Drawing.Point(802, 157)
        Me.bCancelar.Name = "bCancelar"
        Me.bCancelar.Size = New System.Drawing.Size(40, 40)
        Me.bCancelar.TabIndex = 2
        Me.bCancelar.UseVisualStyleBackColor = True
        '
        'SeleccionarPrioridadCargas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 209)
        Me.Controls.Add(Me.bCancelar)
        Me.Controls.Add(Me.bAceptar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "SeleccionarPrioridadCargas"
        Me.Text = "SeleccionarPrioridadCargas"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dGVPrioridad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dGVPrioridad As System.Windows.Forms.DataGridView
    Friend WithEvents bAceptar As System.Windows.Forms.Button
    Friend WithEvents bCancelar As System.Windows.Forms.Button
    Friend WithEvents colPrioridad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colContenedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDestino As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCliente As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
