<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResumenCargas
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ResumenCargas))
        Me.gridResumen = New System.Windows.Forms.DataGridView
        Me.cMSResumen = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MoverAColaDeEsperaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ArmarFullToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CombinarEnUnaSolaCargaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.btnExportar = New System.Windows.Forms.Button
        Me.tCResumen = New System.Windows.Forms.TabControl
        Me.tPResumen = New System.Windows.Forms.TabPage
        Me.tPCola = New System.Windows.Forms.TabPage
        Me.dGVCola = New System.Windows.Forms.DataGridView
        Me.cMSColaEspera = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MovarAResumenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EliminarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DuplicarCargaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.colNo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colContenedor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTipo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colReferencia = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTipo1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colEntregarEn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDestino = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTerminal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colStatus = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDemora = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colNaviera = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colOperacion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCargaPeligrosa = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPlanta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCita = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.gridResumen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cMSResumen.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tCResumen.SuspendLayout()
        Me.tPResumen.SuspendLayout()
        Me.tPCola.SuspendLayout()
        CType(Me.dGVCola, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cMSColaEspera.SuspendLayout()
        Me.SuspendLayout()
        '
        'gridResumen
        '
        Me.gridResumen.AllowUserToAddRows = False
        Me.gridResumen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridResumen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridResumen.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.gridResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridResumen.ContextMenuStrip = Me.cMSResumen
        Me.gridResumen.Location = New System.Drawing.Point(6, 6)
        Me.gridResumen.Name = "gridResumen"
        Me.gridResumen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridResumen.Size = New System.Drawing.Size(786, 325)
        Me.gridResumen.TabIndex = 0
        '
        'cMSResumen
        '
        Me.cMSResumen.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MoverAColaDeEsperaToolStripMenuItem, Me.EliminarToolStripMenuItem, Me.ArmarFullToolStripMenuItem, Me.CombinarEnUnaSolaCargaToolStripMenuItem, Me.DuplicarCargaToolStripMenuItem})
        Me.cMSResumen.Name = "cMSResumen"
        Me.cMSResumen.Size = New System.Drawing.Size(223, 114)
        '
        'MoverAColaDeEsperaToolStripMenuItem
        '
        Me.MoverAColaDeEsperaToolStripMenuItem.Image = CType(resources.GetObject("MoverAColaDeEsperaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MoverAColaDeEsperaToolStripMenuItem.Name = "MoverAColaDeEsperaToolStripMenuItem"
        Me.MoverAColaDeEsperaToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.MoverAColaDeEsperaToolStripMenuItem.Text = "Mover a cola de espera"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = CType(resources.GetObject("EliminarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'ArmarFullToolStripMenuItem
        '
        Me.ArmarFullToolStripMenuItem.Image = CType(resources.GetObject("ArmarFullToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ArmarFullToolStripMenuItem.Name = "ArmarFullToolStripMenuItem"
        Me.ArmarFullToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.ArmarFullToolStripMenuItem.Text = "Armar Full"
        '
        'CombinarEnUnaSolaCargaToolStripMenuItem
        '
        Me.CombinarEnUnaSolaCargaToolStripMenuItem.Image = CType(resources.GetObject("CombinarEnUnaSolaCargaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CombinarEnUnaSolaCargaToolStripMenuItem.Name = "CombinarEnUnaSolaCargaToolStripMenuItem"
        Me.CombinarEnUnaSolaCargaToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.CombinarEnUnaSolaCargaToolStripMenuItem.Text = "Combinar en una sola carga"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnSalir)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Controls.Add(Me.btnExportar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(806, 61)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(740, 15)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(60, 40)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(674, 15)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(60, 40)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnExportar
        '
        Me.btnExportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
        Me.btnExportar.Location = New System.Drawing.Point(608, 15)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(60, 40)
        Me.btnExportar.TabIndex = 0
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'tCResumen
        '
        Me.tCResumen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tCResumen.Controls.Add(Me.tPResumen)
        Me.tCResumen.Controls.Add(Me.tPCola)
        Me.tCResumen.Location = New System.Drawing.Point(12, 79)
        Me.tCResumen.Name = "tCResumen"
        Me.tCResumen.SelectedIndex = 0
        Me.tCResumen.Size = New System.Drawing.Size(806, 363)
        Me.tCResumen.TabIndex = 3
        '
        'tPResumen
        '
        Me.tPResumen.Controls.Add(Me.gridResumen)
        Me.tPResumen.Location = New System.Drawing.Point(4, 22)
        Me.tPResumen.Name = "tPResumen"
        Me.tPResumen.Padding = New System.Windows.Forms.Padding(3)
        Me.tPResumen.Size = New System.Drawing.Size(798, 337)
        Me.tPResumen.TabIndex = 0
        Me.tPResumen.Text = "Resumen"
        Me.tPResumen.UseVisualStyleBackColor = True
        '
        'tPCola
        '
        Me.tPCola.Controls.Add(Me.dGVCola)
        Me.tPCola.Location = New System.Drawing.Point(4, 22)
        Me.tPCola.Name = "tPCola"
        Me.tPCola.Padding = New System.Windows.Forms.Padding(3)
        Me.tPCola.Size = New System.Drawing.Size(798, 337)
        Me.tPCola.TabIndex = 1
        Me.tPCola.Text = "Cola de espera"
        Me.tPCola.UseVisualStyleBackColor = True
        '
        'dGVCola
        '
        Me.dGVCola.AllowUserToAddRows = False
        Me.dGVCola.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dGVCola.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dGVCola.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.dGVCola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dGVCola.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNo, Me.colContenedor, Me.colTipo, Me.colReferencia, Me.colCliente, Me.colTipo1, Me.colEntregarEn, Me.colDestino, Me.colTerminal, Me.colStatus, Me.colDemora, Me.colNaviera, Me.colOperacion, Me.colCargaPeligrosa, Me.colPlanta, Me.colCita})
        Me.dGVCola.ContextMenuStrip = Me.cMSColaEspera
        Me.dGVCola.Location = New System.Drawing.Point(6, 6)
        Me.dGVCola.Name = "dGVCola"
        Me.dGVCola.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dGVCola.Size = New System.Drawing.Size(786, 325)
        Me.dGVCola.TabIndex = 0
        '
        'cMSColaEspera
        '
        Me.cMSColaEspera.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MovarAResumenToolStripMenuItem, Me.EliminarToolStripMenuItem1})
        Me.cMSColaEspera.Name = "cMSColaEspera"
        Me.cMSColaEspera.Size = New System.Drawing.Size(167, 48)
        '
        'MovarAResumenToolStripMenuItem
        '
        Me.MovarAResumenToolStripMenuItem.Name = "MovarAResumenToolStripMenuItem"
        Me.MovarAResumenToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.MovarAResumenToolStripMenuItem.Text = "Movar a resumen"
        '
        'EliminarToolStripMenuItem1
        '
        Me.EliminarToolStripMenuItem1.Name = "EliminarToolStripMenuItem1"
        Me.EliminarToolStripMenuItem1.Size = New System.Drawing.Size(166, 22)
        Me.EliminarToolStripMenuItem1.Text = "Eliminar"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'DuplicarCargaToolStripMenuItem
        '
        Me.DuplicarCargaToolStripMenuItem.Image = CType(resources.GetObject("DuplicarCargaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DuplicarCargaToolStripMenuItem.Name = "DuplicarCargaToolStripMenuItem"
        Me.DuplicarCargaToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.DuplicarCargaToolStripMenuItem.Text = "Duplicar carga"
        '
        'colNo
        '
        Me.colNo.HeaderText = "No"
        Me.colNo.Name = "colNo"
        '
        'colContenedor
        '
        Me.colContenedor.HeaderText = "Contenedor"
        Me.colContenedor.Name = "colContenedor"
        '
        'colTipo
        '
        Me.colTipo.HeaderText = "Tipo"
        Me.colTipo.Name = "colTipo"
        '
        'colReferencia
        '
        Me.colReferencia.HeaderText = "Referencia"
        Me.colReferencia.Name = "colReferencia"
        '
        'colCliente
        '
        Me.colCliente.HeaderText = "Cliente"
        Me.colCliente.Name = "colCliente"
        '
        'colTipo1
        '
        Me.colTipo1.HeaderText = "Tipo1"
        Me.colTipo1.Name = "colTipo1"
        '
        'colEntregarEn
        '
        Me.colEntregarEn.HeaderText = "Entregar en"
        Me.colEntregarEn.Name = "colEntregarEn"
        '
        'colDestino
        '
        Me.colDestino.HeaderText = "Destino"
        Me.colDestino.Name = "colDestino"
        '
        'colTerminal
        '
        Me.colTerminal.HeaderText = "Terminal"
        Me.colTerminal.Name = "colTerminal"
        '
        'colStatus
        '
        Me.colStatus.HeaderText = "Status"
        Me.colStatus.Name = "colStatus"
        '
        'colDemora
        '
        Me.colDemora.HeaderText = "Demora"
        Me.colDemora.Name = "colDemora"
        '
        'colNaviera
        '
        Me.colNaviera.HeaderText = "Naviera"
        Me.colNaviera.Name = "colNaviera"
        '
        'colOperacion
        '
        Me.colOperacion.HeaderText = "Operación"
        Me.colOperacion.Name = "colOperacion"
        '
        'colCargaPeligrosa
        '
        Me.colCargaPeligrosa.HeaderText = "Carga peligrosa"
        Me.colCargaPeligrosa.Name = "colCargaPeligrosa"
        '
        'colPlanta
        '
        Me.colPlanta.HeaderText = "Planta"
        Me.colPlanta.Name = "colPlanta"
        '
        'colCita
        '
        Me.colCita.HeaderText = "Cita"
        Me.colCita.Name = "colCita"
        '
        'ResumenCargas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(830, 454)
        Me.Controls.Add(Me.tCResumen)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ResumenCargas"
        Me.Text = "Resumen de cargas | Reporte de programación"
        CType(Me.gridResumen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cMSResumen.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.tCResumen.ResumeLayout(False)
        Me.tPResumen.ResumeLayout(False)
        Me.tPCola.ResumeLayout(False)
        CType(Me.dGVCola, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cMSColaEspera.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gridResumen As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnExportar As System.Windows.Forms.Button
    Friend WithEvents cMSResumen As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MoverAColaDeEsperaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tCResumen As System.Windows.Forms.TabControl
    Friend WithEvents tPResumen As System.Windows.Forms.TabPage
    Friend WithEvents tPCola As System.Windows.Forms.TabPage
    Friend WithEvents dGVCola As System.Windows.Forms.DataGridView
    Friend WithEvents cMSColaEspera As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MovarAResumenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArmarFullToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CombinarEnUnaSolaCargaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DuplicarCargaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents colNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colContenedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colReferencia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTipo1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEntregarEn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDestino As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTerminal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDemora As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNaviera As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colOperacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCargaPeligrosa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPlanta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCita As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
