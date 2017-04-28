<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formOperadores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formOperadores))
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtOperador = New System.Windows.Forms.TextBox
        Me.gridOperadores = New System.Windows.Forms.DataGridView
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnSeleccionar = New System.Windows.Forms.Button
        CType(Me.gridOperadores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre del Operador:"
        '
        'txtOperador
        '
        Me.txtOperador.Location = New System.Drawing.Point(130, 10)
        Me.txtOperador.Name = "txtOperador"
        Me.txtOperador.Size = New System.Drawing.Size(464, 20)
        Me.txtOperador.TabIndex = 1
        '
        'gridOperadores
        '
        Me.gridOperadores.AllowUserToAddRows = False
        Me.gridOperadores.AllowUserToDeleteRows = False
        Me.gridOperadores.AllowUserToOrderColumns = True
        Me.gridOperadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridOperadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridOperadores.Location = New System.Drawing.Point(16, 36)
        Me.gridOperadores.Name = "gridOperadores"
        Me.gridOperadores.ReadOnly = True
        Me.gridOperadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridOperadores.Size = New System.Drawing.Size(578, 251)
        Me.gridOperadores.TabIndex = 2
        '
        'btnSalir
        '
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Location = New System.Drawing.Point(438, 293)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSeleccionar.Location = New System.Drawing.Point(519, 293)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(75, 23)
        Me.btnSeleccionar.TabIndex = 4
        Me.btnSeleccionar.Text = "Seleccionar"
        Me.btnSeleccionar.UseVisualStyleBackColor = True
        '
        'formOperadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(606, 328)
        Me.Controls.Add(Me.btnSeleccionar)
        Me.Controls.Add(Me.gridOperadores)
        Me.Controls.Add(Me.txtOperador)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSalir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "formOperadores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catálogo de Operadores"
        CType(Me.gridOperadores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtOperador As System.Windows.Forms.TextBox
    Friend WithEvents gridOperadores As System.Windows.Forms.DataGridView
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnSeleccionar As System.Windows.Forms.Button
End Class
