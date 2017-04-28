<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistroCandidatos
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistroCandidatos))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtRFC = New System.Windows.Forms.TextBox
        Me.rdBtnRFC = New System.Windows.Forms.RadioButton
        Me.cmbEstatus = New System.Windows.Forms.ComboBox
        Me.rdBtnEstatus = New System.Windows.Forms.RadioButton
        Me.txtCandidato = New System.Windows.Forms.TextBox
        Me.rdBtnNombre = New System.Windows.Forms.RadioButton
        Me.rdBtnFechas = New System.Windows.Forms.RadioButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.dteHasta = New System.Windows.Forms.DateTimePicker
        Me.dteDesde = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnEliminar = New System.Windows.Forms.Button
        Me.btnAgregar = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btnExportar = New System.Windows.Forms.Button
        Me.gridRegistros = New System.Windows.Forms.DataGridView
        Me.contMenuGrid = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CambiarEstatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.gridRegistros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.contMenuGrid.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtRFC)
        Me.GroupBox1.Controls.Add(Me.rdBtnRFC)
        Me.GroupBox1.Controls.Add(Me.cmbEstatus)
        Me.GroupBox1.Controls.Add(Me.rdBtnEstatus)
        Me.GroupBox1.Controls.Add(Me.txtCandidato)
        Me.GroupBox1.Controls.Add(Me.rdBtnNombre)
        Me.GroupBox1.Controls.Add(Me.rdBtnFechas)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dteHasta)
        Me.GroupBox1.Controls.Add(Me.dteDesde)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(408, 148)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones de búsqueda"
        '
        'txtRFC
        '
        Me.txtRFC.Location = New System.Drawing.Point(6, 118)
        Me.txtRFC.Name = "txtRFC"
        Me.txtRFC.Size = New System.Drawing.Size(180, 20)
        Me.txtRFC.TabIndex = 10
        '
        'rdBtnRFC
        '
        Me.rdBtnRFC.AutoSize = True
        Me.rdBtnRFC.Location = New System.Drawing.Point(6, 95)
        Me.rdBtnRFC.Name = "rdBtnRFC"
        Me.rdBtnRFC.Size = New System.Drawing.Size(84, 17)
        Me.rdBtnRFC.TabIndex = 9
        Me.rdBtnRFC.TabStop = True
        Me.rdBtnRFC.Text = "Por R.F.C:"
        Me.rdBtnRFC.UseVisualStyleBackColor = True
        '
        'cmbEstatus
        '
        Me.cmbEstatus.FormattingEnabled = True
        Me.cmbEstatus.Items.AddRange(New Object() {"ACTIVO", "INACTIVO", "NO APLICA", "RECOMENDABLE", "NO RECOMENDABLE"})
        Me.cmbEstatus.Location = New System.Drawing.Point(299, 69)
        Me.cmbEstatus.Name = "cmbEstatus"
        Me.cmbEstatus.Size = New System.Drawing.Size(103, 21)
        Me.cmbEstatus.TabIndex = 8
        '
        'rdBtnEstatus
        '
        Me.rdBtnEstatus.AutoSize = True
        Me.rdBtnEstatus.Location = New System.Drawing.Point(200, 71)
        Me.rdBtnEstatus.Name = "rdBtnEstatus"
        Me.rdBtnEstatus.Size = New System.Drawing.Size(93, 17)
        Me.rdBtnEstatus.TabIndex = 7
        Me.rdBtnEstatus.TabStop = True
        Me.rdBtnEstatus.Text = "Por estatus:"
        Me.rdBtnEstatus.UseVisualStyleBackColor = True
        '
        'txtCandidato
        '
        Me.txtCandidato.Location = New System.Drawing.Point(200, 43)
        Me.txtCandidato.Name = "txtCandidato"
        Me.txtCandidato.Size = New System.Drawing.Size(202, 20)
        Me.txtCandidato.TabIndex = 6
        '
        'rdBtnNombre
        '
        Me.rdBtnNombre.AutoSize = True
        Me.rdBtnNombre.Location = New System.Drawing.Point(200, 19)
        Me.rdBtnNombre.Name = "rdBtnNombre"
        Me.rdBtnNombre.Size = New System.Drawing.Size(171, 17)
        Me.rdBtnNombre.TabIndex = 5
        Me.rdBtnNombre.TabStop = True
        Me.rdBtnNombre.Text = "Por nombre de candidato:"
        Me.rdBtnNombre.UseVisualStyleBackColor = True
        '
        'rdBtnFechas
        '
        Me.rdBtnFechas.AutoSize = True
        Me.rdBtnFechas.Location = New System.Drawing.Point(6, 19)
        Me.rdBtnFechas.Name = "rdBtnFechas"
        Me.rdBtnFechas.Size = New System.Drawing.Size(144, 17)
        Me.rdBtnFechas.TabIndex = 4
        Me.rdBtnFechas.TabStop = True
        Me.rdBtnFechas.Text = "Por rango de fechas:"
        Me.rdBtnFechas.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Hasta:"
        '
        'dteHasta
        '
        Me.dteHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteHasta.Location = New System.Drawing.Point(59, 68)
        Me.dteHasta.Name = "dteHasta"
        Me.dteHasta.Size = New System.Drawing.Size(127, 20)
        Me.dteHasta.TabIndex = 2
        '
        'dteDesde
        '
        Me.dteDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteDesde.Location = New System.Drawing.Point(59, 42)
        Me.dteDesde.Name = "dteDesde"
        Me.dteDesde.Size = New System.Drawing.Size(127, 20)
        Me.dteDesde.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Desde:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.btnEliminar)
        Me.GroupBox2.Controls.Add(Me.btnAgregar)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(426, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(353, 148)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Opciones de registro"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(132, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(216, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "sobre el registro que desee modificar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(132, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Para editar, haga doble clic"
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(6, 83)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(120, 40)
        Me.btnEliminar.TabIndex = 1
        Me.btnEliminar.Text = "   Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(6, 37)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(120, 40)
        Me.btnAgregar.TabIndex = 0
        Me.btnAgregar.Text = "   Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.btnExportar)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(785, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(239, 148)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Opciones de reporte"
        '
        'btnExportar
        '
        Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
        Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportar.Location = New System.Drawing.Point(63, 58)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(120, 40)
        Me.btnExportar.TabIndex = 0
        Me.btnExportar.Text = "  Exportar"
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'gridRegistros
        '
        Me.gridRegistros.AllowUserToAddRows = False
        Me.gridRegistros.AllowUserToOrderColumns = True
        Me.gridRegistros.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridRegistros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridRegistros.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.gridRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridRegistros.ContextMenuStrip = Me.contMenuGrid
        Me.gridRegistros.Location = New System.Drawing.Point(12, 166)
        Me.gridRegistros.Name = "gridRegistros"
        Me.gridRegistros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridRegistros.Size = New System.Drawing.Size(1012, 331)
        Me.gridRegistros.TabIndex = 3
        '
        'contMenuGrid
        '
        Me.contMenuGrid.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CambiarEstatusToolStripMenuItem})
        Me.contMenuGrid.Name = "contMenuGrid"
        Me.contMenuGrid.Size = New System.Drawing.Size(164, 26)
        '
        'CambiarEstatusToolStripMenuItem
        '
        Me.CambiarEstatusToolStripMenuItem.Name = "CambiarEstatusToolStripMenuItem"
        Me.CambiarEstatusToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.CambiarEstatusToolStripMenuItem.Text = "Cambiar estatus"
        '
        'RegistroCandidatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1036, 509)
        Me.Controls.Add(Me.gridRegistros)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RegistroCandidatos"
        Me.Text = "Registro de candidatos | INPLANT"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.gridRegistros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.contMenuGrid.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents gridRegistros As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dteHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dteDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCandidato As System.Windows.Forms.TextBox
    Friend WithEvents rdBtnNombre As System.Windows.Forms.RadioButton
    Friend WithEvents rdBtnFechas As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbEstatus As System.Windows.Forms.ComboBox
    Friend WithEvents rdBtnEstatus As System.Windows.Forms.RadioButton
    Friend WithEvents btnExportar As System.Windows.Forms.Button
    Friend WithEvents txtRFC As System.Windows.Forms.TextBox
    Friend WithEvents rdBtnRFC As System.Windows.Forms.RadioButton
    Friend WithEvents contMenuGrid As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CambiarEstatusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
