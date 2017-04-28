<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscadorCargas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BuscadorCargas))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.txtBusqueda = New System.Windows.Forms.TextBox
        Me.rdBtnContenedor = New System.Windows.Forms.RadioButton
        Me.rdBtnReferencia = New System.Windows.Forms.RadioButton
        Me.gridCargas = New System.Windows.Forms.DataGridView
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmbTipo = New System.Windows.Forms.ComboBox
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.Referencia = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Contenedor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Peso = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TermOrigen = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fechaDemora = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fechaAlmacenaje = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.gridCargas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.txtBusqueda)
        Me.GroupBox1.Controls.Add(Me.rdBtnContenedor)
        Me.GroupBox1.Controls.Add(Me.rdBtnReferencia)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(387, 85)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar por:"
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(195, 31)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(120, 40)
        Me.btnBuscar.TabIndex = 3
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Location = New System.Drawing.Point(6, 51)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(183, 20)
        Me.txtBusqueda.TabIndex = 2
        '
        'rdBtnContenedor
        '
        Me.rdBtnContenedor.AutoSize = True
        Me.rdBtnContenedor.Location = New System.Drawing.Point(99, 28)
        Me.rdBtnContenedor.Name = "rdBtnContenedor"
        Me.rdBtnContenedor.Size = New System.Drawing.Size(90, 17)
        Me.rdBtnContenedor.TabIndex = 1
        Me.rdBtnContenedor.TabStop = True
        Me.rdBtnContenedor.Text = "Contenedor"
        Me.rdBtnContenedor.UseVisualStyleBackColor = True
        '
        'rdBtnReferencia
        '
        Me.rdBtnReferencia.AutoSize = True
        Me.rdBtnReferencia.Location = New System.Drawing.Point(6, 28)
        Me.rdBtnReferencia.Name = "rdBtnReferencia"
        Me.rdBtnReferencia.Size = New System.Drawing.Size(87, 17)
        Me.rdBtnReferencia.TabIndex = 0
        Me.rdBtnReferencia.TabStop = True
        Me.rdBtnReferencia.Text = "Referencia"
        Me.rdBtnReferencia.UseVisualStyleBackColor = True
        '
        'gridCargas
        '
        Me.gridCargas.AllowUserToAddRows = False
        Me.gridCargas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridCargas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridCargas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Referencia, Me.Cliente, Me.Contenedor, Me.Tipo, Me.Peso, Me.TermOrigen, Me.fechaDemora, Me.fechaAlmacenaje})
        Me.gridCargas.Location = New System.Drawing.Point(12, 126)
        Me.gridCargas.Name = "gridCargas"
        Me.gridCargas.Size = New System.Drawing.Size(846, 268)
        Me.gridCargas.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.cmbTipo)
        Me.GroupBox2.Controls.Add(Me.btnSalir)
        Me.GroupBox2.Controls.Add(Me.btnGuardar)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(405, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(453, 85)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Opciones"
        '
        'cmbTipo
        '
        Me.cmbTipo.FormattingEnabled = True
        Me.cmbTipo.Items.AddRange(New Object() {"LOCAL", "TRASLADO"})
        Me.cmbTipo.Location = New System.Drawing.Point(6, 42)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(121, 21)
        Me.cmbTipo.TabIndex = 2
        '
        'btnSalir
        '
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(259, 31)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(120, 40)
        Me.btnSalir.TabIndex = 1
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(133, 31)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(120, 40)
        Me.btnGuardar.TabIndex = 0
        Me.btnGuardar.Text = "   Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'Referencia
        '
        Me.Referencia.HeaderText = "Referencia"
        Me.Referencia.Name = "Referencia"
        '
        'Cliente
        '
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.Name = "Cliente"
        '
        'Contenedor
        '
        Me.Contenedor.HeaderText = "Contenedor"
        Me.Contenedor.Name = "Contenedor"
        '
        'Tipo
        '
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        '
        'Peso
        '
        Me.Peso.HeaderText = "Peso"
        Me.Peso.Name = "Peso"
        '
        'TermOrigen
        '
        Me.TermOrigen.HeaderText = "Terminal Origen"
        Me.TermOrigen.Name = "TermOrigen"
        '
        'fechaDemora
        '
        Me.fechaDemora.HeaderText = "Fecha de demora"
        Me.fechaDemora.Name = "fechaDemora"
        '
        'fechaAlmacenaje
        '
        Me.fechaAlmacenaje.HeaderText = "Fecha de almacenaje"
        Me.fechaAlmacenaje.Name = "fechaAlmacenaje"
        '
        'BuscadorCargas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(870, 406)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gridCargas)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "BuscadorCargas"
        Me.Text = "Buscador de cargas D.A. Hinojosa | Rep. De programación"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.gridCargas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents rdBtnContenedor As System.Windows.Forms.RadioButton
    Friend WithEvents rdBtnReferencia As System.Windows.Forms.RadioButton
    Friend WithEvents gridCargas As System.Windows.Forms.DataGridView
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents cmbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents Referencia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Contenedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Peso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TermOrigen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fechaDemora As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fechaAlmacenaje As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
