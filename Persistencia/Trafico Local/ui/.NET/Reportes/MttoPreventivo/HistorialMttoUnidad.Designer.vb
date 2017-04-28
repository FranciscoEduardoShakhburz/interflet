<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HistorialMttoUnidad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HistorialMttoUnidad))
        Me.dGVHistorial = New System.Windows.Forms.DataGridView
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.colFecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colHora = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMotivo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colObservaciones = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.dGVHistorial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dGVHistorial
        '
        Me.dGVHistorial.AllowUserToAddRows = False
        Me.dGVHistorial.AllowUserToOrderColumns = True
        Me.dGVHistorial.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dGVHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dGVHistorial.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.dGVHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dGVHistorial.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colFecha, Me.colHora, Me.colMotivo, Me.colObservaciones})
        Me.dGVHistorial.Location = New System.Drawing.Point(12, 39)
        Me.dGVHistorial.Name = "dGVHistorial"
        Me.dGVHistorial.Size = New System.Drawing.Size(766, 215)
        Me.dGVHistorial.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(790, 36)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(33, 33)
        Me.ToolStripButton1.Text = "btn1"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(33, 33)
        Me.ToolStripButton2.Text = "btn2"
        Me.ToolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'colFecha
        '
        Me.colFecha.HeaderText = "FECHA DE MTTO."
        Me.colFecha.Name = "colFecha"
        '
        'colHora
        '
        Me.colHora.HeaderText = "HORA DE MTTO."
        Me.colHora.Name = "colHora"
        '
        'colMotivo
        '
        Me.colMotivo.HeaderText = "MOTIVO DE MANTENIMIENTO"
        Me.colMotivo.Name = "colMotivo"
        '
        'colObservaciones
        '
        Me.colObservaciones.HeaderText = "OBSERVACIONES"
        Me.colObservaciones.Name = "colObservaciones"
        '
        'HistorialMttoUnidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(790, 266)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.dGVHistorial)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "HistorialMttoUnidad"
        Me.Text = "Historial de mtto. De unidades | Mtto. Preventivo"
        CType(Me.dGVHistorial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dGVHistorial As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents colFecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHora As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMotivo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colObservaciones As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
