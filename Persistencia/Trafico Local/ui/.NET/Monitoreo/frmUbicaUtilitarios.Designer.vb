<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUbicaUtilitarios
    Inherits System.Windows.Forms.Form


    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub


    Private components As System.ComponentModel.IContainer




    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.grdUtilitarios = New System.Windows.Forms.DataGridView
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.grdUtilitarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()



        Me.grdUtilitarios.AllowUserToAddRows = False
        Me.grdUtilitarios.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        Me.grdUtilitarios.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdUtilitarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdUtilitarios.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.grdUtilitarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdUtilitarios.DefaultCellStyle = DataGridViewCellStyle2
        Me.grdUtilitarios.Location = New System.Drawing.Point(4, 7)
        Me.grdUtilitarios.Name = "grdUtilitarios"
        Me.grdUtilitarios.ReadOnly = True
        Me.grdUtilitarios.RowHeadersVisible = False
        Me.grdUtilitarios.Size = New System.Drawing.Size(837, 647)
        Me.grdUtilitarios.TabIndex = 0






        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(842, 656)
        Me.Controls.Add(Me.grdUtilitarios)
        Me.Name = "frmUbicaUtilitarios"
        Me.Text = "Ubicación de Vehiculos Utilitarios"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grdUtilitarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grdUtilitarios As System.Windows.Forms.DataGridView
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
