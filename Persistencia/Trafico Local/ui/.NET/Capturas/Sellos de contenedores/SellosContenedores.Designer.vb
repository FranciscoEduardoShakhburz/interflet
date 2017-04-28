<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SellosContenedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SellosContenedores))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rdBtnSinCP = New System.Windows.Forms.RadioButton
        Me.dteHasta = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.dteDesde = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.rdBtnRango = New System.Windows.Forms.RadioButton
        Me.txtConsulta = New System.Windows.Forms.TextBox
        Me.rdBtnReferencia = New System.Windows.Forms.RadioButton
        Me.rdBtnContenedor = New System.Windows.Forms.RadioButton
        Me.btnAgrgarReg = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.rdBtnSinCPorte = New System.Windows.Forms.RadioButton
        Me.rdBtnPorBook = New System.Windows.Forms.RadioButton
        Me.txtRepo = New System.Windows.Forms.TextBox
        Me.rdBtnPorRefer = New System.Windows.Forms.RadioButton
        Me.btnGenerar = New System.Windows.Forms.Button
        Me.dteA = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.dteDe = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.rdBtnPeriodo = New System.Windows.Forms.RadioButton
        Me.gridRegistros = New System.Windows.Forms.DataGridView
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnEliminar = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.gridRegistros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rdBtnSinCP)
        Me.GroupBox1.Controls.Add(Me.dteHasta)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dteDesde)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.rdBtnRango)
        Me.GroupBox1.Controls.Add(Me.txtConsulta)
        Me.GroupBox1.Controls.Add(Me.rdBtnReferencia)
        Me.GroupBox1.Controls.Add(Me.rdBtnContenedor)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(319, 124)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Consultar por:"
        '
        'rdBtnSinCP
        '
        Me.rdBtnSinCP.AutoSize = True
        Me.rdBtnSinCP.Location = New System.Drawing.Point(215, 19)
        Me.rdBtnSinCP.Name = "rdBtnSinCP"
        Me.rdBtnSinCP.Size = New System.Drawing.Size(93, 17)
        Me.rdBtnSinCP.TabIndex = 13
        Me.rdBtnSinCP.TabStop = True
        Me.rdBtnSinCP.Text = "Sin C. Porte"
        Me.rdBtnSinCP.UseVisualStyleBackColor = True
        '
        'dteHasta
        '
        Me.dteHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteHasta.Location = New System.Drawing.Point(210, 91)
        Me.dteHasta.Name = "dteHasta"
        Me.dteHasta.Size = New System.Drawing.Size(98, 20)
        Me.dteHasta.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(160, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Hasta:"
        '
        'dteDesde
        '
        Me.dteDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteDesde.Location = New System.Drawing.Point(56, 91)
        Me.dteDesde.Name = "dteDesde"
        Me.dteDesde.Size = New System.Drawing.Size(98, 20)
        Me.dteDesde.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Desde:"
        '
        'rdBtnRango
        '
        Me.rdBtnRango.AutoSize = True
        Me.rdBtnRango.Location = New System.Drawing.Point(6, 68)
        Me.rdBtnRango.Name = "rdBtnRango"
        Me.rdBtnRango.Size = New System.Drawing.Size(122, 17)
        Me.rdBtnRango.TabIndex = 8
        Me.rdBtnRango.TabStop = True
        Me.rdBtnRango.Text = "Rango de fechas"
        Me.rdBtnRango.UseVisualStyleBackColor = True
        '
        'txtConsulta
        '
        Me.txtConsulta.Location = New System.Drawing.Point(6, 42)
        Me.txtConsulta.Name = "txtConsulta"
        Me.txtConsulta.Size = New System.Drawing.Size(195, 20)
        Me.txtConsulta.TabIndex = 5
        '
        'rdBtnReferencia
        '
        Me.rdBtnReferencia.AutoSize = True
        Me.rdBtnReferencia.Location = New System.Drawing.Point(114, 19)
        Me.rdBtnReferencia.Name = "rdBtnReferencia"
        Me.rdBtnReferencia.Size = New System.Drawing.Size(87, 17)
        Me.rdBtnReferencia.TabIndex = 4
        Me.rdBtnReferencia.TabStop = True
        Me.rdBtnReferencia.Text = "Referencia"
        Me.rdBtnReferencia.UseVisualStyleBackColor = True
        '
        'rdBtnContenedor
        '
        Me.rdBtnContenedor.AutoSize = True
        Me.rdBtnContenedor.Location = New System.Drawing.Point(6, 19)
        Me.rdBtnContenedor.Name = "rdBtnContenedor"
        Me.rdBtnContenedor.Size = New System.Drawing.Size(90, 17)
        Me.rdBtnContenedor.TabIndex = 3
        Me.rdBtnContenedor.TabStop = True
        Me.rdBtnContenedor.Text = "Contenedor"
        Me.rdBtnContenedor.UseVisualStyleBackColor = True
        '
        'btnAgrgarReg
        '
        Me.btnAgrgarReg.Image = CType(resources.GetObject("btnAgrgarReg.Image"), System.Drawing.Image)
        Me.btnAgrgarReg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgrgarReg.Location = New System.Drawing.Point(6, 19)
        Me.btnAgrgarReg.Name = "btnAgrgarReg"
        Me.btnAgrgarReg.Size = New System.Drawing.Size(120, 40)
        Me.btnAgrgarReg.TabIndex = 6
        Me.btnAgrgarReg.Text = "    Agregar       Registro"
        Me.btnAgrgarReg.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.rdBtnSinCPorte)
        Me.GroupBox3.Controls.Add(Me.rdBtnPorBook)
        Me.GroupBox3.Controls.Add(Me.txtRepo)
        Me.GroupBox3.Controls.Add(Me.rdBtnPorRefer)
        Me.GroupBox3.Controls.Add(Me.btnGenerar)
        Me.GroupBox3.Controls.Add(Me.dteA)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.dteDe)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.rdBtnPeriodo)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(581, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(382, 124)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Reportes"
        '
        'rdBtnSinCPorte
        '
        Me.rdBtnSinCPorte.AutoSize = True
        Me.rdBtnSinCPorte.Location = New System.Drawing.Point(157, 76)
        Me.rdBtnSinCPorte.Name = "rdBtnSinCPorte"
        Me.rdBtnSinCPorte.Size = New System.Drawing.Size(93, 17)
        Me.rdBtnSinCPorte.TabIndex = 16
        Me.rdBtnSinCPorte.TabStop = True
        Me.rdBtnSinCPorte.Text = "Sin C. Porte"
        Me.rdBtnSinCPorte.UseVisualStyleBackColor = True
        '
        'rdBtnPorBook
        '
        Me.rdBtnPorBook.AutoSize = True
        Me.rdBtnPorBook.Location = New System.Drawing.Point(279, 19)
        Me.rdBtnPorBook.Name = "rdBtnPorBook"
        Me.rdBtnPorBook.Size = New System.Drawing.Size(97, 17)
        Me.rdBtnPorBook.TabIndex = 15
        Me.rdBtnPorBook.TabStop = True
        Me.rdBtnPorBook.Text = "Por booking:"
        Me.rdBtnPorBook.UseVisualStyleBackColor = True
        '
        'txtRepo
        '
        Me.txtRepo.Location = New System.Drawing.Point(159, 42)
        Me.txtRepo.Name = "txtRepo"
        Me.txtRepo.Size = New System.Drawing.Size(217, 20)
        Me.txtRepo.TabIndex = 14
        '
        'rdBtnPorRefer
        '
        Me.rdBtnPorRefer.AutoSize = True
        Me.rdBtnPorRefer.Location = New System.Drawing.Point(157, 19)
        Me.rdBtnPorRefer.Name = "rdBtnPorRefer"
        Me.rdBtnPorRefer.Size = New System.Drawing.Size(109, 17)
        Me.rdBtnPorRefer.TabIndex = 6
        Me.rdBtnPorRefer.TabStop = True
        Me.rdBtnPorRefer.Text = "Por referencia:"
        Me.rdBtnPorRefer.UseVisualStyleBackColor = True
        '
        'btnGenerar
        '
        Me.btnGenerar.Image = CType(resources.GetObject("btnGenerar.Image"), System.Drawing.Image)
        Me.btnGenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenerar.Location = New System.Drawing.Point(256, 78)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(120, 40)
        Me.btnGenerar.TabIndex = 5
        Me.btnGenerar.Text = "   Generar"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'dteA
        '
        Me.dteA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteA.Location = New System.Drawing.Point(9, 94)
        Me.dteA.Name = "dteA"
        Me.dteA.Size = New System.Drawing.Size(98, 20)
        Me.dteA.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Hasta:"
        '
        'dteDe
        '
        Me.dteDe.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dteDe.Location = New System.Drawing.Point(9, 55)
        Me.dteDe.Name = "dteDe"
        Me.dteDe.Size = New System.Drawing.Size(98, 20)
        Me.dteDe.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Desde:"
        '
        'rdBtnPeriodo
        '
        Me.rdBtnPeriodo.AutoSize = True
        Me.rdBtnPeriodo.Location = New System.Drawing.Point(6, 19)
        Me.rdBtnPeriodo.Name = "rdBtnPeriodo"
        Me.rdBtnPeriodo.Size = New System.Drawing.Size(90, 17)
        Me.rdBtnPeriodo.TabIndex = 0
        Me.rdBtnPeriodo.TabStop = True
        Me.rdBtnPeriodo.Text = "Por periodo"
        Me.rdBtnPeriodo.UseVisualStyleBackColor = True
        '
        'gridRegistros
        '
        Me.gridRegistros.AllowUserToAddRows = False
        Me.gridRegistros.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridRegistros.Location = New System.Drawing.Point(12, 142)
        Me.gridRegistros.Name = "gridRegistros"
        Me.gridRegistros.ReadOnly = True
        Me.gridRegistros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridRegistros.Size = New System.Drawing.Size(957, 351)
        Me.gridRegistros.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.btnEliminar)
        Me.GroupBox2.Controls.Add(Me.btnAgrgarReg)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(337, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(238, 124)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Opciones de registros:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(132, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "sobre uno"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(132, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "doble clic"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(132, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "un registro, haga"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(132, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Para editar "
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(6, 71)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(120, 40)
        Me.btnEliminar.TabIndex = 7
        Me.btnEliminar.Text = "    Eliminar       Registro"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(12, 499)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(120, 40)
        Me.btnSalir.TabIndex = 10
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'SellosContenedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(981, 551)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gridRegistros)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SellosContenedores"
        Me.Text = "Sellos de contenedores "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.gridRegistros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtConsulta As System.Windows.Forms.TextBox
    Friend WithEvents rdBtnReferencia As System.Windows.Forms.RadioButton
    Friend WithEvents rdBtnContenedor As System.Windows.Forms.RadioButton
    Friend WithEvents gridRegistros As System.Windows.Forms.DataGridView
    Friend WithEvents btnAgrgarReg As System.Windows.Forms.Button
    Friend WithEvents dteHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dteDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rdBtnRango As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents rdBtnPeriodo As System.Windows.Forms.RadioButton
    Friend WithEvents btnGenerar As System.Windows.Forms.Button
    Friend WithEvents dteA As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dteDe As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents rdBtnSinCP As System.Windows.Forms.RadioButton
    Friend WithEvents rdBtnPorBook As System.Windows.Forms.RadioButton
    Friend WithEvents txtRepo As System.Windows.Forms.TextBox
    Friend WithEvents rdBtnPorRefer As System.Windows.Forms.RadioButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rdBtnSinCPorte As System.Windows.Forms.RadioButton
End Class
