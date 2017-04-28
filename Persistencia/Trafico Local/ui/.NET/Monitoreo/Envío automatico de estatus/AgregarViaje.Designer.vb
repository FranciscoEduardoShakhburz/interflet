<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarViaje
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgregarViaje))
        Me.tCDatos = New System.Windows.Forms.TabControl
        Me.tPGeneral = New System.Windows.Forms.TabPage
        Me.gBDatos = New System.Windows.Forms.GroupBox
        Me.cBTipoOper = New System.Windows.Forms.ComboBox
        Me.tBDireccion = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.btnBuscarCliente = New System.Windows.Forms.Button
        Me.tBNumeroCliente = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.rTBComentarios = New System.Windows.Forms.RichTextBox
        Me.tBContenedor = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.tBObservaciones = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.tBCP = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.tBDestino = New System.Windows.Forms.TextBox
        Me.tBCliente = New System.Windows.Forms.TextBox
        Me.tBViaje = New System.Windows.Forms.TextBox
        Me.tBPlacas = New System.Windows.Forms.TextBox
        Me.tBOperador = New System.Windows.Forms.TextBox
        Me.tBUnidad = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.tPCorreos = New System.Windows.Forms.TabPage
        Me.dGVCorreos = New System.Windows.Forms.DataGridView
        Me.colCorreos = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        Me.tCDatos.SuspendLayout()
        Me.tPGeneral.SuspendLayout()
        Me.gBDatos.SuspendLayout()
        Me.tPCorreos.SuspendLayout()
        CType(Me.dGVCorreos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tCDatos
        '
        Me.tCDatos.Controls.Add(Me.tPGeneral)
        Me.tCDatos.Controls.Add(Me.tPCorreos)
        Me.tCDatos.Location = New System.Drawing.Point(12, 12)
        Me.tCDatos.Name = "tCDatos"
        Me.tCDatos.SelectedIndex = 0
        Me.tCDatos.Size = New System.Drawing.Size(533, 355)
        Me.tCDatos.TabIndex = 0
        '
        'tPGeneral
        '
        Me.tPGeneral.BackgroundImage = CType(resources.GetObject("tPGeneral.BackgroundImage"), System.Drawing.Image)
        Me.tPGeneral.Controls.Add(Me.gBDatos)
        Me.tPGeneral.Location = New System.Drawing.Point(4, 22)
        Me.tPGeneral.Name = "tPGeneral"
        Me.tPGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tPGeneral.Size = New System.Drawing.Size(525, 329)
        Me.tPGeneral.TabIndex = 0
        Me.tPGeneral.Text = "Datos generales"
        Me.tPGeneral.UseVisualStyleBackColor = True
        '
        'gBDatos
        '
        Me.gBDatos.Controls.Add(Me.cBTipoOper)
        Me.gBDatos.Controls.Add(Me.tBDireccion)
        Me.gBDatos.Controls.Add(Me.Label11)
        Me.gBDatos.Controls.Add(Me.Label12)
        Me.gBDatos.Controls.Add(Me.btnBuscarCliente)
        Me.gBDatos.Controls.Add(Me.tBNumeroCliente)
        Me.gBDatos.Controls.Add(Me.Label10)
        Me.gBDatos.Controls.Add(Me.rTBComentarios)
        Me.gBDatos.Controls.Add(Me.tBContenedor)
        Me.gBDatos.Controls.Add(Me.Label9)
        Me.gBDatos.Controls.Add(Me.tBObservaciones)
        Me.gBDatos.Controls.Add(Me.Label8)
        Me.gBDatos.Controls.Add(Me.tBCP)
        Me.gBDatos.Controls.Add(Me.Label7)
        Me.gBDatos.Controls.Add(Me.Label6)
        Me.gBDatos.Controls.Add(Me.Label5)
        Me.gBDatos.Controls.Add(Me.Label4)
        Me.gBDatos.Controls.Add(Me.tBDestino)
        Me.gBDatos.Controls.Add(Me.tBCliente)
        Me.gBDatos.Controls.Add(Me.tBViaje)
        Me.gBDatos.Controls.Add(Me.tBPlacas)
        Me.gBDatos.Controls.Add(Me.tBOperador)
        Me.gBDatos.Controls.Add(Me.tBUnidad)
        Me.gBDatos.Controls.Add(Me.Label3)
        Me.gBDatos.Controls.Add(Me.Label2)
        Me.gBDatos.Controls.Add(Me.Label1)
        Me.gBDatos.Font = New System.Drawing.Font("Ubuntu", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gBDatos.Location = New System.Drawing.Point(6, 6)
        Me.gBDatos.Name = "gBDatos"
        Me.gBDatos.Size = New System.Drawing.Size(513, 317)
        Me.gBDatos.TabIndex = 1
        Me.gBDatos.TabStop = False
        '
        'cBTipoOper
        '
        Me.cBTipoOper.FormattingEnabled = True
        Me.cBTipoOper.Items.AddRange(New Object() {"IMPO", "EXPO"})
        Me.cBTipoOper.Location = New System.Drawing.Point(128, 179)
        Me.cBTipoOper.Name = "cBTipoOper"
        Me.cBTipoOper.Size = New System.Drawing.Size(100, 27)
        Me.cBTipoOper.TabIndex = 24
        '
        'tBDireccion
        '
        Me.tBDireccion.Location = New System.Drawing.Point(319, 179)
        Me.tBDireccion.Name = "tBDireccion"
        Me.tBDireccion.Size = New System.Drawing.Size(188, 25)
        Me.tBDireccion.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(234, 182)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 19)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Dirección:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(18, 182)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 19)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Tipo de oper.:"
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.Image = CType(resources.GetObject("btnBuscarCliente.Image"), System.Drawing.Image)
        Me.btnBuscarCliente.Location = New System.Drawing.Point(482, 117)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(25, 25)
        Me.btnBuscarCliente.TabIndex = 13
        Me.btnBuscarCliente.UseVisualStyleBackColor = True
        '
        'tBNumeroCliente
        '
        Me.tBNumeroCliente.Location = New System.Drawing.Point(128, 117)
        Me.tBNumeroCliente.Name = "tBNumeroCliente"
        Me.tBNumeroCliente.ReadOnly = True
        Me.tBNumeroCliente.Size = New System.Drawing.Size(100, 25)
        Me.tBNumeroCliente.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(20, 244)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 19)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Comentarios:"
        '
        'rTBComentarios
        '
        Me.rTBComentarios.Location = New System.Drawing.Point(128, 241)
        Me.rTBComentarios.Name = "rTBComentarios"
        Me.rTBComentarios.Size = New System.Drawing.Size(379, 70)
        Me.rTBComentarios.TabIndex = 12
        Me.rTBComentarios.Text = ""
        '
        'tBContenedor
        '
        Me.tBContenedor.Location = New System.Drawing.Point(338, 210)
        Me.tBContenedor.Name = "tBContenedor"
        Me.tBContenedor.Size = New System.Drawing.Size(169, 25)
        Me.tBContenedor.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(234, 213)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 19)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Contenedor:"
        '
        'tBObservaciones
        '
        Me.tBObservaciones.Location = New System.Drawing.Point(128, 210)
        Me.tBObservaciones.Name = "tBObservaciones"
        Me.tBObservaciones.Size = New System.Drawing.Size(100, 25)
        Me.tBObservaciones.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 213)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 19)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Observaciones:"
        '
        'tBCP
        '
        Me.tBCP.Location = New System.Drawing.Point(358, 148)
        Me.tBCP.Name = "tBCP"
        Me.tBCP.Size = New System.Drawing.Size(149, 25)
        Me.tBCP.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(55, 151)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 19)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Destino:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(285, 151)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 19)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Carta P.:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(59, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 19)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Cliente:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(283, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 19)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Viaje:"
        '
        'tBDestino
        '
        Me.tBDestino.Location = New System.Drawing.Point(128, 148)
        Me.tBDestino.Name = "tBDestino"
        Me.tBDestino.Size = New System.Drawing.Size(151, 25)
        Me.tBDestino.TabIndex = 6
        '
        'tBCliente
        '
        Me.tBCliente.Location = New System.Drawing.Point(234, 117)
        Me.tBCliente.Name = "tBCliente"
        Me.tBCliente.ReadOnly = True
        Me.tBCliente.Size = New System.Drawing.Size(242, 25)
        Me.tBCliente.TabIndex = 5
        '
        'tBViaje
        '
        Me.tBViaje.Location = New System.Drawing.Point(334, 86)
        Me.tBViaje.Name = "tBViaje"
        Me.tBViaje.Size = New System.Drawing.Size(173, 25)
        Me.tBViaje.TabIndex = 3
        '
        'tBPlacas
        '
        Me.tBPlacas.Location = New System.Drawing.Point(128, 86)
        Me.tBPlacas.Name = "tBPlacas"
        Me.tBPlacas.Size = New System.Drawing.Size(149, 25)
        Me.tBPlacas.TabIndex = 2
        '
        'tBOperador
        '
        Me.tBOperador.Location = New System.Drawing.Point(128, 55)
        Me.tBOperador.Name = "tBOperador"
        Me.tBOperador.Size = New System.Drawing.Size(379, 25)
        Me.tBOperador.TabIndex = 1
        '
        'tBUnidad
        '
        Me.tBUnidad.Location = New System.Drawing.Point(128, 24)
        Me.tBUnidad.Name = "tBUnidad"
        Me.tBUnidad.Size = New System.Drawing.Size(100, 25)
        Me.tBUnidad.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(65, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Placas:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Operador:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Unidad:"
        '
        'tPCorreos
        '
        Me.tPCorreos.BackgroundImage = CType(resources.GetObject("tPCorreos.BackgroundImage"), System.Drawing.Image)
        Me.tPCorreos.Controls.Add(Me.dGVCorreos)
        Me.tPCorreos.Font = New System.Drawing.Font("Ubuntu", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tPCorreos.Location = New System.Drawing.Point(4, 22)
        Me.tPCorreos.Name = "tPCorreos"
        Me.tPCorreos.Padding = New System.Windows.Forms.Padding(3)
        Me.tPCorreos.Size = New System.Drawing.Size(525, 329)
        Me.tPCorreos.TabIndex = 1
        Me.tPCorreos.Text = "Correos"
        Me.tPCorreos.UseVisualStyleBackColor = True
        '
        'dGVCorreos
        '
        Me.dGVCorreos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dGVCorreos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dGVCorreos.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.dGVCorreos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dGVCorreos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCorreos})
        Me.dGVCorreos.Location = New System.Drawing.Point(6, 6)
        Me.dGVCorreos.Name = "dGVCorreos"
        Me.dGVCorreos.Size = New System.Drawing.Size(513, 317)
        Me.dGVCorreos.TabIndex = 0
        '
        'colCorreos
        '
        Me.colCorreos.HeaderText = "Correos"
        Me.colCorreos.Name = "colCorreos"
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(459, 373)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(40, 40)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(505, 373)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(40, 40)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'AgregarViaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(557, 425)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.tCDatos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(565, 428)
        Me.Name = "AgregarViaje"
        Me.Text = "Agregar viaje | Envío de status"
        Me.tCDatos.ResumeLayout(False)
        Me.tPGeneral.ResumeLayout(False)
        Me.gBDatos.ResumeLayout(False)
        Me.gBDatos.PerformLayout()
        Me.tPCorreos.ResumeLayout(False)
        CType(Me.dGVCorreos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tCDatos As System.Windows.Forms.TabControl
    Friend WithEvents tPGeneral As System.Windows.Forms.TabPage
    Friend WithEvents gBDatos As System.Windows.Forms.GroupBox
    Friend WithEvents tBContenedor As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tBObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tBCP As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tBDestino As System.Windows.Forms.TextBox
    Friend WithEvents tBCliente As System.Windows.Forms.TextBox
    Friend WithEvents tBViaje As System.Windows.Forms.TextBox
    Friend WithEvents tBPlacas As System.Windows.Forms.TextBox
    Friend WithEvents tBOperador As System.Windows.Forms.TextBox
    Friend WithEvents tBUnidad As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tPCorreos As System.Windows.Forms.TabPage
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents dGVCorreos As System.Windows.Forms.DataGridView
    Friend WithEvents colCorreos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents rTBComentarios As System.Windows.Forms.RichTextBox
    Friend WithEvents tBNumeroCliente As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscarCliente As System.Windows.Forms.Button
    Friend WithEvents tBDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cBTipoOper As System.Windows.Forms.ComboBox
End Class
