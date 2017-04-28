<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgregarCliente))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.tBHoras = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.tBCliente = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.tBNumeroCliente = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.dGVCorreos = New System.Windows.Forms.DataGridView
        Me.colCorreos = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btnEliminar = New System.Windows.Forms.Button
        Me.btnAgregar = New System.Windows.Forms.Button
        Me.tSMenu = New System.Windows.Forms.ToolStrip
        Me.tSBGuardar = New System.Windows.Forms.ToolStripButton
        Me.tSBSalir = New System.Windows.Forms.ToolStripButton
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dGVCorreos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.tSMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.tBHoras)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tBCliente)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tBNumeroCliente)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(425, 97)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'tBHoras
        '
        Me.tBHoras.Location = New System.Drawing.Point(126, 71)
        Me.tBHoras.Name = "tBHoras"
        Me.tBHoras.Size = New System.Drawing.Size(293, 20)
        Me.tBHoras.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(76, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Horas:"
        '
        'tBCliente
        '
        Me.tBCliente.Location = New System.Drawing.Point(126, 45)
        Me.tBCliente.Name = "tBCliente"
        Me.tBCliente.Size = New System.Drawing.Size(293, 20)
        Me.tBCliente.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cliente:"
        '
        'tBNumeroCliente
        '
        Me.tBNumeroCliente.Location = New System.Drawing.Point(126, 19)
        Me.tBNumeroCliente.Name = "tBNumeroCliente"
        Me.tBNumeroCliente.Size = New System.Drawing.Size(293, 20)
        Me.tBNumeroCliente.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Número de cliente:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.dGVCorreos)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 166)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(365, 223)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'dGVCorreos
        '
        Me.dGVCorreos.AllowUserToAddRows = False
        Me.dGVCorreos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dGVCorreos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dGVCorreos.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.dGVCorreos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dGVCorreos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCorreos})
        Me.dGVCorreos.Location = New System.Drawing.Point(6, 19)
        Me.dGVCorreos.Name = "dGVCorreos"
        Me.dGVCorreos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dGVCorreos.Size = New System.Drawing.Size(353, 198)
        Me.dGVCorreos.TabIndex = 0
        '
        'colCorreos
        '
        Me.colCorreos.HeaderText = "Correos"
        Me.colCorreos.Name = "colCorreos"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.btnEliminar)
        Me.GroupBox3.Controls.Add(Me.btnAgregar)
        Me.GroupBox3.Location = New System.Drawing.Point(385, 166)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(52, 223)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.Location = New System.Drawing.Point(6, 177)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(40, 40)
        Me.btnEliminar.TabIndex = 1
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.Location = New System.Drawing.Point(6, 19)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(40, 40)
        Me.btnAgregar.TabIndex = 0
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'tSMenu
        '
        Me.tSMenu.AutoSize = False
        Me.tSMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tSBGuardar, Me.tSBSalir})
        Me.tSMenu.Location = New System.Drawing.Point(0, 0)
        Me.tSMenu.Name = "tSMenu"
        Me.tSMenu.Size = New System.Drawing.Size(449, 60)
        Me.tSMenu.TabIndex = 3
        Me.tSMenu.Text = "ToolStrip1"
        '
        'tSBGuardar
        '
        Me.tSBGuardar.AutoSize = False
        Me.tSBGuardar.Image = CType(resources.GetObject("tSBGuardar.Image"), System.Drawing.Image)
        Me.tSBGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tSBGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tSBGuardar.Name = "tSBGuardar"
        Me.tSBGuardar.Size = New System.Drawing.Size(50, 55)
        Me.tSBGuardar.Text = "Guardar"
        Me.tSBGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tSBSalir
        '
        Me.tSBSalir.AutoSize = False
        Me.tSBSalir.Image = CType(resources.GetObject("tSBSalir.Image"), System.Drawing.Image)
        Me.tSBSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tSBSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tSBSalir.Name = "tSBSalir"
        Me.tSBSalir.Size = New System.Drawing.Size(50, 55)
        Me.tSBSalir.Text = "Salir"
        Me.tSBSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'AgregarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(449, 401)
        Me.Controls.Add(Me.tSMenu)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(457, 435)
        Me.MinimumSize = New System.Drawing.Size(457, 435)
        Me.Name = "AgregarCliente"
        Me.Text = "Agregar cliente | Catálogo de clientes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dGVCorreos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.tSMenu.ResumeLayout(False)
        Me.tSMenu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tBCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tBNumeroCliente As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents dGVCorreos As System.Windows.Forms.DataGridView
    Friend WithEvents tSMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents tSBGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tSBSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents colCorreos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tBHoras As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
