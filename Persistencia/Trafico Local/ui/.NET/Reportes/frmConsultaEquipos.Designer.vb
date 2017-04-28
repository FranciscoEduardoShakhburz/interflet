<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaEquipos
    Inherits System.Windows.Forms.Form


    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub


    Private components As System.ComponentModel.IContainer




    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultaEquipos))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbUbicacion = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbEquipo = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.btnExportar = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        Me.gridResultado = New System.Windows.Forms.DataGridView
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.gridUbicacion = New System.Windows.Forms.DataGridView
        Me.chkBajas = New System.Windows.Forms.CheckBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.gridResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.gridUbicacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmbUbicacion)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbEquipo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(811, 96)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones de Búsqueda"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(649, 30)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(156, 20)
        Me.txtDescripcion.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(554, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Descripción:"
        '
        'cmbUbicacion
        '
        Me.cmbUbicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUbicacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbUbicacion.FormattingEnabled = True
        Me.cmbUbicacion.Location = New System.Drawing.Point(367, 30)
        Me.cmbUbicacion.Name = "cmbUbicacion"
        Me.cmbUbicacion.Size = New System.Drawing.Size(131, 21)
        Me.cmbUbicacion.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(259, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Ubicación:"
        '
        'cmbEquipo
        '
        Me.cmbEquipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbEquipo.FormattingEnabled = True
        Me.cmbEquipo.Location = New System.Drawing.Point(63, 30)
        Me.cmbEquipo.Name = "cmbEquipo"
        Me.cmbEquipo.Size = New System.Drawing.Size(132, 21)
        Me.cmbEquipo.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Equipo:"
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(845, 13)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(94, 22)
        Me.btnBuscar.TabIndex = 8
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnExportar
        '
        Me.btnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportar.Location = New System.Drawing.Point(845, 43)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(94, 22)
        Me.btnExportar.TabIndex = 9
        Me.btnExportar.Text = "Exportar"
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(845, 71)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(94, 22)
        Me.btnSalir.TabIndex = 10
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'gridResultado
        '
        Me.gridResultado.AllowUserToAddRows = False
        Me.gridResultado.AllowUserToDeleteRows = False
        Me.gridResultado.AllowUserToOrderColumns = True
        Me.gridResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridResultado.Location = New System.Drawing.Point(16, 19)
        Me.gridResultado.MultiSelect = False
        Me.gridResultado.Name = "gridResultado"
        Me.gridResultado.ReadOnly = True
        Me.gridResultado.Size = New System.Drawing.Size(911, 211)
        Me.gridResultado.TabIndex = 11
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.gridResultado)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 120)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(946, 253)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultado de Búsqueda"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.gridUbicacion)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 399)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(946, 246)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ubicación del Equipo"
        '
        'gridUbicacion
        '
        Me.gridUbicacion.AllowUserToOrderColumns = True
        Me.gridUbicacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridUbicacion.Location = New System.Drawing.Point(16, 19)
        Me.gridUbicacion.MultiSelect = False
        Me.gridUbicacion.Name = "gridUbicacion"
        Me.gridUbicacion.Size = New System.Drawing.Size(911, 211)
        Me.gridUbicacion.TabIndex = 12
        '
        'chkBajas
        '
        Me.chkBajas.AutoSize = True
        Me.chkBajas.BackColor = System.Drawing.Color.Transparent
        Me.chkBajas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBajas.Location = New System.Drawing.Point(845, 99)
        Me.chkBajas.Name = "chkBajas"
        Me.chkBajas.Size = New System.Drawing.Size(109, 17)
        Me.chkBajas.TabIndex = 14
        Me.chkBajas.Text = "¿Incluir bajas?"
        Me.chkBajas.UseVisualStyleBackColor = False
        '
        'frmConsultaEquipos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(970, 657)
        Me.Controls.Add(Me.chkBajas)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnExportar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmConsultaEquipos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Equipos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.gridResultado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.gridUbicacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbEquipo As System.Windows.Forms.ComboBox
    Friend WithEvents cmbUbicacion As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnExportar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents gridResultado As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents gridUbicacion As System.Windows.Forms.DataGridView
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents chkBajas As System.Windows.Forms.CheckBox
End Class
