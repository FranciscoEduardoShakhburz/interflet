<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formIngresoEIR
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formIngresoEIR))
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.dateFechaEIR = New System.Windows.Forms.DateTimePicker
        Me.dateFechaEntregaAA = New System.Windows.Forms.DateTimePicker
        Me.txtFolio = New System.Windows.Forms.TextBox
        Me.cmbServicio = New System.Windows.Forms.ComboBox
        Me.btnSalir = New System.Windows.Forms.Button
        Me.txtContenedor = New System.Windows.Forms.TextBox
        Me.gridEIR = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmbTerminales = New System.Windows.Forms.ComboBox
        Me.cmbAgencias = New System.Windows.Forms.ComboBox
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtBusquedaContenedor = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.labelFolioInterno = New System.Windows.Forms.Label
        Me.txtIdTerminal = New System.Windows.Forms.TextBox
        Me.txtIdAgencia = New System.Windows.Forms.TextBox
        CType(Me.gridEIR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(696, 93)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 12
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Fecha de EIR:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Fecha de Entrega A.A."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Folio:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(370, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Servicio:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(370, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Agencia Aduanal:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(370, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Terminal:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(5, 93)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Contenedor:"
        '
        'dateFechaEIR
        '
        Me.dateFechaEIR.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateFechaEIR.Location = New System.Drawing.Point(148, 12)
        Me.dateFechaEIR.Name = "dateFechaEIR"
        Me.dateFechaEIR.Size = New System.Drawing.Size(216, 20)
        Me.dateFechaEIR.TabIndex = 3
        '
        'dateFechaEntregaAA
        '
        Me.dateFechaEntregaAA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateFechaEntregaAA.Location = New System.Drawing.Point(148, 41)
        Me.dateFechaEntregaAA.Name = "dateFechaEntregaAA"
        Me.dateFechaEntregaAA.Size = New System.Drawing.Size(216, 20)
        Me.dateFechaEntregaAA.TabIndex = 4
        '
        'txtFolio
        '
        Me.txtFolio.Location = New System.Drawing.Point(148, 67)
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.Size = New System.Drawing.Size(216, 20)
        Me.txtFolio.TabIndex = 5
        '
        'cmbServicio
        '
        Me.cmbServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbServicio.FormattingEnabled = True
        Me.cmbServicio.Location = New System.Drawing.Point(514, 67)
        Me.cmbServicio.Name = "cmbServicio"
        Me.cmbServicio.Size = New System.Drawing.Size(257, 21)
        Me.cmbServicio.TabIndex = 11
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(615, 93)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 13
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'txtContenedor
        '
        Me.txtContenedor.Location = New System.Drawing.Point(148, 93)
        Me.txtContenedor.Name = "txtContenedor"
        Me.txtContenedor.Size = New System.Drawing.Size(216, 20)
        Me.txtContenedor.TabIndex = 6
        '
        'gridEIR
        '
        Me.gridEIR.AllowUserToAddRows = False
        Me.gridEIR.AllowUserToDeleteRows = False
        Me.gridEIR.AllowUserToOrderColumns = True
        Me.gridEIR.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridEIR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridEIR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridEIR.Location = New System.Drawing.Point(12, 162)
        Me.gridEIR.Name = "gridEIR"
        Me.gridEIR.ReadOnly = True
        Me.gridEIR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridEIR.Size = New System.Drawing.Size(789, 235)
        Me.gridEIR.TabIndex = 42
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtIdAgencia)
        Me.GroupBox1.Controls.Add(Me.txtIdTerminal)
        Me.GroupBox1.Controls.Add(Me.cmbTerminales)
        Me.GroupBox1.Controls.Add(Me.cmbAgencias)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnSalir)
        Me.GroupBox1.Controls.Add(Me.txtContenedor)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Controls.Add(Me.cmbServicio)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtFolio)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.dateFechaEntregaAA)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.dateFechaEIR)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(789, 123)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Contenedor"
        '
        'cmbTerminales
        '
        Me.cmbTerminales.FormattingEnabled = True
        Me.cmbTerminales.Location = New System.Drawing.Point(514, 13)
        Me.cmbTerminales.Name = "cmbTerminales"
        Me.cmbTerminales.Size = New System.Drawing.Size(257, 21)
        Me.cmbTerminales.TabIndex = 8
        '
        'cmbAgencias
        '
        Me.cmbAgencias.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbAgencias.FormattingEnabled = True
        Me.cmbAgencias.Location = New System.Drawing.Point(514, 42)
        Me.cmbAgencias.Name = "cmbAgencias"
        Me.cmbAgencias.Size = New System.Drawing.Size(257, 21)
        Me.cmbAgencias.TabIndex = 10
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(313, 4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(108, 23)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Contenedor:"
        '
        'txtBusquedaContenedor
        '
        Me.txtBusquedaContenedor.Location = New System.Drawing.Point(91, 6)
        Me.txtBusquedaContenedor.Name = "txtBusquedaContenedor"
        Me.txtBusquedaContenedor.Size = New System.Drawing.Size(216, 20)
        Me.txtBusquedaContenedor.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(437, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(172, 13)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Folio Interno del Contenedor:"
        '
        'labelFolioInterno
        '
        Me.labelFolioInterno.AutoSize = True
        Me.labelFolioInterno.BackColor = System.Drawing.Color.Transparent
        Me.labelFolioInterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelFolioInterno.Location = New System.Drawing.Point(615, 9)
        Me.labelFolioInterno.Name = "labelFolioInterno"
        Me.labelFolioInterno.Size = New System.Drawing.Size(84, 13)
        Me.labelFolioInterno.TabIndex = 41
        Me.labelFolioInterno.Text = "10000000000"
        '
        'txtIdTerminal
        '
        Me.txtIdTerminal.Location = New System.Drawing.Point(479, 13)
        Me.txtIdTerminal.Name = "txtIdTerminal"
        Me.txtIdTerminal.Size = New System.Drawing.Size(34, 20)
        Me.txtIdTerminal.TabIndex = 7
        '
        'txtIdAgencia
        '
        Me.txtIdAgencia.Location = New System.Drawing.Point(479, 42)
        Me.txtIdAgencia.Name = "txtIdAgencia"
        Me.txtIdAgencia.Size = New System.Drawing.Size(34, 20)
        Me.txtIdAgencia.TabIndex = 9
        '
        'formIngresoEIR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(813, 409)
        Me.Controls.Add(Me.labelFolioInterno)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtBusquedaContenedor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gridEIR)
        Me.Name = "formIngresoEIR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso de EIR"
        CType(Me.gridEIR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dateFechaEIR As System.Windows.Forms.DateTimePicker
    Friend WithEvents dateFechaEntregaAA As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtFolio As System.Windows.Forms.TextBox
    Friend WithEvents cmbServicio As System.Windows.Forms.ComboBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents txtContenedor As System.Windows.Forms.TextBox
    Friend WithEvents gridEIR As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBusquedaContenedor As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents labelFolioInterno As System.Windows.Forms.Label
    Friend WithEvents cmbAgencias As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTerminales As System.Windows.Forms.ComboBox
    Friend WithEvents txtIdAgencia As System.Windows.Forms.TextBox
    Friend WithEvents txtIdTerminal As System.Windows.Forms.TextBox
End Class
