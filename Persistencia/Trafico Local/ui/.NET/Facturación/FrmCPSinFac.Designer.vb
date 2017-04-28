<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCPSinFac
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCPSinFac))
        Me.Label1 = New System.Windows.Forms.Label
        Me.FechaI = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.FechaF = New System.Windows.Forms.DateTimePicker
        Me.ConsultaCP = New System.Windows.Forms.Button
        Me.Grid = New System.Windows.Forms.DataGridView
        Me.Button4 = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmdPlaza = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtTotalFac = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtTotalMonto = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.cmb_tipo = New System.Windows.Forms.ComboBox
        Me.gridtop = New System.Windows.Forms.DataGridView
        Me.Label3 = New System.Windows.Forms.Label
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridtop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha Inicial:"
        '
        'FechaI
        '
        Me.FechaI.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaI.Location = New System.Drawing.Point(102, 16)
        Me.FechaI.Name = "FechaI"
        Me.FechaI.Size = New System.Drawing.Size(87, 20)
        Me.FechaI.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(208, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha Final: "
        '
        'FechaF
        '
        Me.FechaF.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaF.Location = New System.Drawing.Point(295, 16)
        Me.FechaF.Name = "FechaF"
        Me.FechaF.Size = New System.Drawing.Size(87, 20)
        Me.FechaF.TabIndex = 3
        '
        'ConsultaCP
        '
        Me.ConsultaCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConsultaCP.Location = New System.Drawing.Point(811, 10)
        Me.ConsultaCP.Name = "ConsultaCP"
        Me.ConsultaCP.Size = New System.Drawing.Size(89, 23)
        Me.ConsultaCP.TabIndex = 4
        Me.ConsultaCP.Text = "Consultar"
        Me.ConsultaCP.UseVisualStyleBackColor = True
        '
        'Grid
        '
        Me.Grid.AllowUserToAddRows = False
        Me.Grid.AllowUserToDeleteRows = False
        Me.Grid.AllowUserToOrderColumns = True
        Me.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid.Location = New System.Drawing.Point(4, 68)
        Me.Grid.Name = "Grid"
        Me.Grid.ReadOnly = True
        Me.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grid.Size = New System.Drawing.Size(913, 316)
        Me.Grid.TabIndex = 7
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(828, 402)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(87, 23)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "Excel"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(397, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Plaza"
        '
        'cmdPlaza
        '
        Me.cmdPlaza.DisplayMember = "1"
        Me.cmdPlaza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmdPlaza.FormattingEnabled = True
        Me.cmdPlaza.Items.AddRange(New Object() {"Altamira", "Manzanillo", "Veracruz", "Todas"})
        Me.cmdPlaza.Location = New System.Drawing.Point(441, 15)
        Me.cmdPlaza.Name = "cmdPlaza"
        Me.cmdPlaza.Size = New System.Drawing.Size(133, 21)
        Me.cmdPlaza.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 412)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Total CP:"
        '
        'txtTotalFac
        '
        Me.txtTotalFac.Enabled = False
        Me.txtTotalFac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalFac.Location = New System.Drawing.Point(78, 405)
        Me.txtTotalFac.Name = "txtTotalFac"
        Me.txtTotalFac.Size = New System.Drawing.Size(87, 20)
        Me.txtTotalFac.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(184, 412)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Total Monto"
        '
        'txtTotalMonto
        '
        Me.txtTotalMonto.Enabled = False
        Me.txtTotalMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalMonto.Location = New System.Drawing.Point(265, 405)
        Me.txtTotalMonto.Name = "txtTotalMonto"
        Me.txtTotalMonto.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalMonto.TabIndex = 21
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(811, 36)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 26)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "SALIR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cmb_tipo
        '
        Me.cmb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipo.FormattingEnabled = True
        Me.cmb_tipo.Items.AddRange(New Object() {"C.P con Fecha de Pase", "C.P Sin Fecha de Pase", "Todas Las C.P"})
        Me.cmb_tipo.Location = New System.Drawing.Point(599, 15)
        Me.cmb_tipo.Name = "cmb_tipo"
        Me.cmb_tipo.Size = New System.Drawing.Size(133, 21)
        Me.cmb_tipo.TabIndex = 25
        '
        'gridtop
        '
        Me.gridtop.AllowUserToAddRows = False
        Me.gridtop.AllowUserToDeleteRows = False
        Me.gridtop.AllowUserToOrderColumns = True
        Me.gridtop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridtop.Location = New System.Drawing.Point(932, 68)
        Me.gridtop.Name = "gridtop"
        Me.gridtop.ReadOnly = True
        Me.gridtop.Size = New System.Drawing.Size(252, 178)
        Me.gridtop.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(992, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 16)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Top 5 Clientes"
        '
        'FrmCPSinFac
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1196, 438)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.gridtop)
        Me.Controls.Add(Me.cmb_tipo)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtTotalMonto)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtTotalFac)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmdPlaza)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.ConsultaCP)
        Me.Controls.Add(Me.FechaF)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FechaI)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmCPSinFac"
        Me.Text = "C.P Pendientes de Facturar"
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridtop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FechaI As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents FechaF As System.Windows.Forms.DateTimePicker
    Friend WithEvents ConsultaCP As System.Windows.Forms.Button
    Friend WithEvents Grid As System.Windows.Forms.DataGridView
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmdPlaza As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTotalFac As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtTotalMonto As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cmb_tipo As System.Windows.Forms.ComboBox
    Friend WithEvents gridtop As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
