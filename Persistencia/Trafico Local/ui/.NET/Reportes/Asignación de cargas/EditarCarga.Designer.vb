<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarCarga
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditarCarga))
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.tBNumero = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.tBEsPeligrosa = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.tBNaviera = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.tBDemoras = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.tBReferencia = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.tBContenedor = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.tBPlanta = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.tBOperacion = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.tBDestino = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.tBEntregarEn = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.tBConfiguracion = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.tBCliente = New System.Windows.Forms.TextBox
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(417, 241)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(40, 40)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(371, 241)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(40, 40)
        Me.btnGuardar.TabIndex = 3
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Ubuntu", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(445, 223)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 28)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(437, 191)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos del contenedor"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tBNumero)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.tBEsPeligrosa)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.tBNaviera)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tBDemoras)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tBReferencia)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tBContenedor)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(425, 179)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'tBNumero
        '
        Me.tBNumero.Location = New System.Drawing.Point(117, 24)
        Me.tBNumero.Name = "tBNumero"
        Me.tBNumero.Size = New System.Drawing.Size(40, 25)
        Me.tBNumero.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(41, 27)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 19)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Número:"
        '
        'tBEsPeligrosa
        '
        Me.tBEsPeligrosa.Location = New System.Drawing.Point(117, 148)
        Me.tBEsPeligrosa.Name = "tBEsPeligrosa"
        Me.tBEsPeligrosa.Size = New System.Drawing.Size(272, 25)
        Me.tBEsPeligrosa.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 19)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "¿Es peligroso?"
        '
        'tBNaviera
        '
        Me.tBNaviera.Location = New System.Drawing.Point(117, 117)
        Me.tBNaviera.Name = "tBNaviera"
        Me.tBNaviera.Size = New System.Drawing.Size(272, 25)
        Me.tBNaviera.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Naviera:"
        '
        'tBDemoras
        '
        Me.tBDemoras.Location = New System.Drawing.Point(117, 86)
        Me.tBDemoras.Name = "tBDemoras"
        Me.tBDemoras.Size = New System.Drawing.Size(272, 25)
        Me.tBDemoras.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Demoras:"
        '
        'tBReferencia
        '
        Me.tBReferencia.Location = New System.Drawing.Point(117, 55)
        Me.tBReferencia.Name = "tBReferencia"
        Me.tBReferencia.Size = New System.Drawing.Size(272, 25)
        Me.tBReferencia.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Referencia:"
        '
        'tBContenedor
        '
        Me.tBContenedor.Location = New System.Drawing.Point(267, 24)
        Me.tBContenedor.Name = "tBContenedor"
        Me.tBContenedor.Size = New System.Drawing.Size(122, 25)
        Me.tBContenedor.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(163, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Contenedor:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 28)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(437, 191)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Datos de entrega"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.tBPlanta)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.tBOperacion)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.tBDestino)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.tBEntregarEn)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.tBConfiguracion)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.tBCliente)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(425, 179)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(191, 58)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(110, 19)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Fec. En planta:"
        '
        'tBPlanta
        '
        Me.tBPlanta.Location = New System.Drawing.Point(307, 55)
        Me.tBPlanta.Name = "tBPlanta"
        Me.tBPlanta.Size = New System.Drawing.Size(96, 25)
        Me.tBPlanta.TabIndex = 27
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(31, 151)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 19)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Operación:"
        '
        'tBOperacion
        '
        Me.tBOperacion.Location = New System.Drawing.Point(123, 148)
        Me.tBOperacion.Name = "tBOperacion"
        Me.tBOperacion.Size = New System.Drawing.Size(280, 25)
        Me.tBOperacion.TabIndex = 25
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(50, 120)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 19)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Destino:"
        '
        'tBDestino
        '
        Me.tBDestino.Location = New System.Drawing.Point(123, 117)
        Me.tBDestino.Name = "tBDestino"
        Me.tBDestino.Size = New System.Drawing.Size(280, 25)
        Me.tBDestino.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(21, 89)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 19)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Entregar en:"
        '
        'tBEntregarEn
        '
        Me.tBEntregarEn.Location = New System.Drawing.Point(123, 86)
        Me.tBEntregarEn.Name = "tBEntregarEn"
        Me.tBEntregarEn.Size = New System.Drawing.Size(280, 25)
        Me.tBEntregarEn.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 19)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Configuración:"
        '
        'tBConfiguracion
        '
        Me.tBConfiguracion.Location = New System.Drawing.Point(123, 55)
        Me.tBConfiguracion.Name = "tBConfiguracion"
        Me.tBConfiguracion.Size = New System.Drawing.Size(62, 25)
        Me.tBConfiguracion.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(54, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 19)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Cliente:"
        '
        'tBCliente
        '
        Me.tBCliente.Location = New System.Drawing.Point(123, 24)
        Me.tBCliente.Name = "tBCliente"
        Me.tBCliente.Size = New System.Drawing.Size(280, 25)
        Me.tBCliente.TabIndex = 17
        '
        'EditarCarga
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 293)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(477, 327)
        Me.MinimumSize = New System.Drawing.Size(477, 327)
        Me.Name = "EditarCarga"
        Me.Text = "EditarCarga"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tBNaviera As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tBDemoras As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tBReferencia As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tBContenedor As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tBEsPeligrosa As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tBOperacion As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tBDestino As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tBEntregarEn As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tBConfiguracion As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tBCliente As System.Windows.Forms.TextBox
    Friend WithEvents tBNumero As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tBPlanta As System.Windows.Forms.TextBox
End Class
