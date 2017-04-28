<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formReporteEvaluacion
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
        Me.lblFechaInicial = New System.Windows.Forms.Label
        Me.lblFechaFinal = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.gridDescuentoRendimiento = New System.Windows.Forms.DataGridView
        Me.btnExportar = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.gridTotalDescuento = New System.Windows.Forms.DataGridView
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.gridTiempoEnBaja = New System.Windows.Forms.DataGridView
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.gridExcesoVelocidad = New System.Windows.Forms.DataGridView
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.gridSobreRevoluciones = New System.Windows.Forms.DataGridView
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.gridTiempoArriba = New System.Windows.Forms.DataGridView
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.gridDescolgadas = New System.Windows.Forms.DataGridView
        Me.btnSalir = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.gridDescuentoRendimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.gridTotalDescuento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.gridTiempoEnBaja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.gridExcesoVelocidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.gridSobreRevoluciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.gridTiempoArriba, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.gridDescolgadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFechaInicial
        '
        Me.lblFechaInicial.AutoSize = True
        Me.lblFechaInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaInicial.Location = New System.Drawing.Point(13, 13)
        Me.lblFechaInicial.Name = "lblFechaInicial"
        Me.lblFechaInicial.Size = New System.Drawing.Size(156, 13)
        Me.lblFechaInicial.TabIndex = 0
        Me.lblFechaInicial.Text = "Fecha Inicial: 01/01/2014"
        '
        'lblFechaFinal
        '
        Me.lblFechaFinal.AutoSize = True
        Me.lblFechaFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaFinal.Location = New System.Drawing.Point(175, 13)
        Me.lblFechaFinal.Name = "lblFechaFinal"
        Me.lblFechaFinal.Size = New System.Drawing.Size(149, 13)
        Me.lblFechaFinal.TabIndex = 1
        Me.lblFechaFinal.Text = "Fecha Final: 01/01/2014"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.gridDescuentoRendimiento)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(932, 232)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Descuento por Rendimiento"
        '
        'gridDescuentoRendimiento
        '
        Me.gridDescuentoRendimiento.AllowUserToAddRows = False
        Me.gridDescuentoRendimiento.AllowUserToOrderColumns = True
        Me.gridDescuentoRendimiento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridDescuentoRendimiento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.gridDescuentoRendimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridDescuentoRendimiento.Location = New System.Drawing.Point(7, 20)
        Me.gridDescuentoRendimiento.Name = "gridDescuentoRendimiento"
        Me.gridDescuentoRendimiento.ReadOnly = True
        Me.gridDescuentoRendimiento.Size = New System.Drawing.Size(919, 206)
        Me.gridDescuentoRendimiento.TabIndex = 0
        '
        'btnExportar
        '
        Me.btnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportar.Location = New System.Drawing.Point(357, 8)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(75, 23)
        Me.btnExportar.TabIndex = 3
        Me.btnExportar.Text = "Exportar"
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.gridTotalDescuento)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 269)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(932, 205)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Total Descuento"
        '
        'gridTotalDescuento
        '
        Me.gridTotalDescuento.AllowUserToAddRows = False
        Me.gridTotalDescuento.AllowUserToDeleteRows = False
        Me.gridTotalDescuento.AllowUserToOrderColumns = True
        Me.gridTotalDescuento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridTotalDescuento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridTotalDescuento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridTotalDescuento.Location = New System.Drawing.Point(7, 19)
        Me.gridTotalDescuento.Name = "gridTotalDescuento"
        Me.gridTotalDescuento.ReadOnly = True
        Me.gridTotalDescuento.Size = New System.Drawing.Size(919, 180)
        Me.gridTotalDescuento.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Location = New System.Drawing.Point(16, 481)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(932, 245)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.gridTiempoEnBaja)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(924, 219)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Tiempo en Baja"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'gridTiempoEnBaja
        '
        Me.gridTiempoEnBaja.AllowUserToAddRows = False
        Me.gridTiempoEnBaja.AllowUserToDeleteRows = False
        Me.gridTiempoEnBaja.AllowUserToOrderColumns = True
        Me.gridTiempoEnBaja.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridTiempoEnBaja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridTiempoEnBaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridTiempoEnBaja.Location = New System.Drawing.Point(7, 7)
        Me.gridTiempoEnBaja.Name = "gridTiempoEnBaja"
        Me.gridTiempoEnBaja.ReadOnly = True
        Me.gridTiempoEnBaja.Size = New System.Drawing.Size(911, 206)
        Me.gridTiempoEnBaja.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.gridExcesoVelocidad)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(924, 219)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Exceso de Velocidad"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'gridExcesoVelocidad
        '
        Me.gridExcesoVelocidad.AllowUserToAddRows = False
        Me.gridExcesoVelocidad.AllowUserToDeleteRows = False
        Me.gridExcesoVelocidad.AllowUserToOrderColumns = True
        Me.gridExcesoVelocidad.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridExcesoVelocidad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridExcesoVelocidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridExcesoVelocidad.Location = New System.Drawing.Point(7, 6)
        Me.gridExcesoVelocidad.Name = "gridExcesoVelocidad"
        Me.gridExcesoVelocidad.ReadOnly = True
        Me.gridExcesoVelocidad.Size = New System.Drawing.Size(911, 206)
        Me.gridExcesoVelocidad.TabIndex = 1
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.gridSobreRevoluciones)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(924, 219)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Sobre revoluciones"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'gridSobreRevoluciones
        '
        Me.gridSobreRevoluciones.AllowUserToAddRows = False
        Me.gridSobreRevoluciones.AllowUserToDeleteRows = False
        Me.gridSobreRevoluciones.AllowUserToOrderColumns = True
        Me.gridSobreRevoluciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridSobreRevoluciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridSobreRevoluciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridSobreRevoluciones.Location = New System.Drawing.Point(7, 6)
        Me.gridSobreRevoluciones.Name = "gridSobreRevoluciones"
        Me.gridSobreRevoluciones.ReadOnly = True
        Me.gridSobreRevoluciones.Size = New System.Drawing.Size(911, 206)
        Me.gridSobreRevoluciones.TabIndex = 1
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.gridTiempoArriba)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(924, 219)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Tiempo arriba de 80 KM/H"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'gridTiempoArriba
        '
        Me.gridTiempoArriba.AllowUserToAddRows = False
        Me.gridTiempoArriba.AllowUserToDeleteRows = False
        Me.gridTiempoArriba.AllowUserToOrderColumns = True
        Me.gridTiempoArriba.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridTiempoArriba.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridTiempoArriba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridTiempoArriba.Location = New System.Drawing.Point(7, 6)
        Me.gridTiempoArriba.Name = "gridTiempoArriba"
        Me.gridTiempoArriba.ReadOnly = True
        Me.gridTiempoArriba.Size = New System.Drawing.Size(911, 206)
        Me.gridTiempoArriba.TabIndex = 1
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.gridDescolgadas)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(924, 219)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Number of Coast Out of Gear"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'gridDescolgadas
        '
        Me.gridDescolgadas.AllowUserToAddRows = False
        Me.gridDescolgadas.AllowUserToDeleteRows = False
        Me.gridDescolgadas.AllowUserToOrderColumns = True
        Me.gridDescolgadas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridDescolgadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridDescolgadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridDescolgadas.Location = New System.Drawing.Point(7, 7)
        Me.gridDescolgadas.Name = "gridDescolgadas"
        Me.gridDescolgadas.ReadOnly = True
        Me.gridDescolgadas.Size = New System.Drawing.Size(911, 206)
        Me.gridDescolgadas.TabIndex = 0
        '
        'btnSalir
        '
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(873, 8)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'formReporteEvaluacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(960, 745)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnExportar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblFechaFinal)
        Me.Controls.Add(Me.lblFechaInicial)
        Me.Name = "formReporteEvaluacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Evaluación"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.gridDescuentoRendimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.gridTotalDescuento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.gridTiempoEnBaja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.gridExcesoVelocidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.gridSobreRevoluciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.gridTiempoArriba, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        CType(Me.gridDescolgadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFechaInicial As System.Windows.Forms.Label
    Friend WithEvents lblFechaFinal As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents gridDescuentoRendimiento As System.Windows.Forms.DataGridView
    Friend WithEvents btnExportar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents gridTotalDescuento As System.Windows.Forms.DataGridView
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents gridTiempoEnBaja As System.Windows.Forms.DataGridView
    Friend WithEvents gridExcesoVelocidad As System.Windows.Forms.DataGridView
    Friend WithEvents gridSobreRevoluciones As System.Windows.Forms.DataGridView
    Friend WithEvents gridTiempoArriba As System.Windows.Forms.DataGridView
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents gridDescolgadas As System.Windows.Forms.DataGridView
End Class
