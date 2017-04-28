<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteLocales
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
        Me.bto_guardar = New System.Windows.Forms.Button
        Me.grid1 = New System.Windows.Forms.DataGridView
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bto_guardar
        '
        Me.bto_guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bto_guardar.Location = New System.Drawing.Point(728, 28)
        Me.bto_guardar.Name = "bto_guardar"
        Me.bto_guardar.Size = New System.Drawing.Size(75, 23)
        Me.bto_guardar.TabIndex = 0
        Me.bto_guardar.Text = "Guardar"
        Me.bto_guardar.UseVisualStyleBackColor = True
        '
        'grid1
        '
        Me.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid1.Location = New System.Drawing.Point(12, 73)
        Me.grid1.Name = "grid1"
        Me.grid1.Size = New System.Drawing.Size(874, 150)
        Me.grid1.TabIndex = 1
        '
        'ReporteLocales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(898, 581)
        Me.Controls.Add(Me.grid1)
        Me.Controls.Add(Me.bto_guardar)
        Me.Name = "ReporteLocales"
        Me.Text = "ReporteLocales"
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bto_guardar As System.Windows.Forms.Button
    Friend WithEvents grid1 As System.Windows.Forms.DataGridView
End Class
