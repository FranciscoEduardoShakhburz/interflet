<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUbicaViajes
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.grdUbicaViajes = New System.Windows.Forms.DataGridView
        Me.gridViajesClientes = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnConfiguracion = New System.Windows.Forms.Button
        CType(Me.grdUbicaViajes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridViajesClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()



        Me.Timer1.Interval = 10000



        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 10000



        Me.grdUbicaViajes.AllowUserToAddRows = False
        Me.grdUbicaViajes.AllowUserToDeleteRows = False
        Me.grdUbicaViajes.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        Me.grdUbicaViajes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdUbicaViajes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdUbicaViajes.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.grdUbicaViajes.Location = New System.Drawing.Point(19, 451)
        Me.grdUbicaViajes.Name = "grdUbicaViajes"
        Me.grdUbicaViajes.ReadOnly = True
        Me.grdUbicaViajes.RowHeadersVisible = False
        Me.grdUbicaViajes.Size = New System.Drawing.Size(1032, 333)
        Me.grdUbicaViajes.TabIndex = 1



        Me.gridViajesClientes.AllowUserToAddRows = False
        Me.gridViajesClientes.AllowUserToDeleteRows = False
        Me.gridViajesClientes.AllowUserToOrderColumns = True
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver
        Me.gridViajesClientes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.gridViajesClientes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridViajesClientes.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.gridViajesClientes.Location = New System.Drawing.Point(19, 68)
        Me.gridViajesClientes.Name = "gridViajesClientes"
        Me.gridViajesClientes.ReadOnly = True
        Me.gridViajesClientes.RowHeadersVisible = False
        Me.gridViajesClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridViajesClientes.Size = New System.Drawing.Size(1032, 298)
        Me.gridViajesClientes.TabIndex = 2



        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(14, 419)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 29)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Viaje de Vuelta"



        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Location = New System.Drawing.Point(14, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(207, 29)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Viaje de Entrega"



        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Brown
        Me.Label3.Location = New System.Drawing.Point(209, 431)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(653, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Los viajes con fondo rojo son del cliente Vitro Vidrio y Cristal S.A. de C.V. que" & _
            " rebasan los 70 KM/H de Velocidad"



        Me.btnConfiguracion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConfiguracion.Location = New System.Drawing.Point(947, 12)
        Me.btnConfiguracion.Name = "btnConfiguracion"
        Me.btnConfiguracion.Size = New System.Drawing.Size(104, 23)
        Me.btnConfiguracion.TabIndex = 6
        Me.btnConfiguracion.Text = "Configuración"
        Me.btnConfiguracion.UseVisualStyleBackColor = True



        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1069, 823)
        Me.Controls.Add(Me.btnConfiguracion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grdUbicaViajes)
        Me.Controls.Add(Me.gridViajesClientes)
        Me.Name = "frmUbicaViajes"
        Me.Text = "Ubicación de Viajes en Transito"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grdUbicaViajes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridViajesClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents grdUbicaViajes As System.Windows.Forms.DataGridView
    Friend WithEvents gridViajesClientes As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnConfiguracion As System.Windows.Forms.Button
End Class
