<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formHorarioCliente
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
        Me.lblUnidad = New System.Windows.Forms.Label
        Me.gridClientes = New System.Windows.Forms.DataGridView
        CType(Me.gridClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUnidad
        '
        Me.lblUnidad.AutoSize = True
        Me.lblUnidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnidad.Location = New System.Drawing.Point(12, 9)
        Me.lblUnidad.Name = "lblUnidad"
        Me.lblUnidad.Size = New System.Drawing.Size(98, 13)
        Me.lblUnidad.TabIndex = 0
        Me.lblUnidad.Text = "Unidad T-00000"
        '
        'gridClientes
        '
        Me.gridClientes.AllowUserToAddRows = False
        Me.gridClientes.AllowUserToDeleteRows = False
        Me.gridClientes.AllowUserToOrderColumns = True
        Me.gridClientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridClientes.Location = New System.Drawing.Point(15, 26)
        Me.gridClientes.Name = "gridClientes"
        Me.gridClientes.ReadOnly = True
        Me.gridClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridClientes.Size = New System.Drawing.Size(579, 233)
        Me.gridClientes.TabIndex = 1
        '
        'formHorarioCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 271)
        Me.Controls.Add(Me.gridClientes)
        Me.Controls.Add(Me.lblUnidad)
        Me.Name = "formHorarioCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Selecciona la hora de Entrada o Salida con Cliente"
        CType(Me.gridClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblUnidad As System.Windows.Forms.Label
    Friend WithEvents gridClientes As System.Windows.Forms.DataGridView
End Class
