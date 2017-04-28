<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formRutas
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtRutas = New System.Windows.Forms.TextBox
        Me.gridRutas = New System.Windows.Forms.DataGridView
        Me.btnSeleccionar = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        CType(Me.gridRutas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre de Ruta:"
        '
        'txtRutas
        '
        Me.txtRutas.Location = New System.Drawing.Point(122, 10)
        Me.txtRutas.Name = "txtRutas"
        Me.txtRutas.Size = New System.Drawing.Size(297, 20)
        Me.txtRutas.TabIndex = 1
        '
        'gridRutas
        '
        Me.gridRutas.AllowUserToAddRows = False
        Me.gridRutas.AllowUserToDeleteRows = False
        Me.gridRutas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridRutas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridRutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridRutas.Location = New System.Drawing.Point(12, 36)
        Me.gridRutas.Name = "gridRutas"
        Me.gridRutas.ReadOnly = True
        Me.gridRutas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridRutas.Size = New System.Drawing.Size(580, 201)
        Me.gridRutas.TabIndex = 2
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionar.Location = New System.Drawing.Point(453, 7)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(116, 23)
        Me.btnSeleccionar.TabIndex = 3
        Me.btnSeleccionar.Text = "Seleccionar"
        Me.btnSeleccionar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Location = New System.Drawing.Point(262, 115)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(81, 23)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'formRutas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(604, 249)
        Me.Controls.Add(Me.btnSeleccionar)
        Me.Controls.Add(Me.txtRutas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gridRutas)
        Me.Controls.Add(Me.btnSalir)
        Me.Name = "formRutas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rutas de Viaje"
        CType(Me.gridRutas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRutas As System.Windows.Forms.TextBox
    Friend WithEvents gridRutas As System.Windows.Forms.DataGridView
    Friend WithEvents btnSeleccionar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
End Class
