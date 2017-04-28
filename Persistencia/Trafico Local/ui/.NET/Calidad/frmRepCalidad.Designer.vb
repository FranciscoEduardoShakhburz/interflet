<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRepCalidad
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.UP_ReporteResetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProduccionInterfletdbReportes = New Interflet.ProduccionInterfletdbReportes
        Me.RepView1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.UP_ReporteResetTableAdapter = New Interflet.ProduccionInterfletdbReportesTableAdapters.UP_ReporteResetTableAdapter
        Me.PI_Calidad = New Interflet.PI_Calidad
        Me.UP_Consulta_ReporteCalidad_v2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UP_Consulta_ReporteCalidad_v2TableAdapter = New Interflet.PI_CalidadTableAdapters.UP_Consulta_ReporteCalidad_v2TableAdapter
        CType(Me.UP_ReporteResetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProduccionInterfletdbReportes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PI_Calidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UP_Consulta_ReporteCalidad_v2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UP_ReporteResetBindingSource
        '
        Me.UP_ReporteResetBindingSource.DataMember = "UP_ReporteReset"
        Me.UP_ReporteResetBindingSource.DataSource = Me.ProduccionInterfletdbReportes
        '
        'ProduccionInterfletdbReportes
        '
        Me.ProduccionInterfletdbReportes.DataSetName = "ProduccionInterfletdbReportes"
        Me.ProduccionInterfletdbReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RepView1
        '
        Me.RepView1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "ProduccionInterfletdbReportes_UP_ReporteReset"
        ReportDataSource1.Value = Me.UP_ReporteResetBindingSource
        ReportDataSource2.Name = "PI_Calidad_UP_Consulta_ReporteCalidad_v2"
        ReportDataSource2.Value = Me.UP_Consulta_ReporteCalidad_v2BindingSource
        Me.RepView1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RepView1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.RepView1.LocalReport.ReportEmbeddedResource = "Interflet.RepCalidad.rdlc"
        Me.RepView1.Location = New System.Drawing.Point(0, 0)
        Me.RepView1.Name = "RepView1"
        Me.RepView1.Size = New System.Drawing.Size(874, 765)
        Me.RepView1.TabIndex = 0
        '
        'UP_ReporteResetTableAdapter
        '
        Me.UP_ReporteResetTableAdapter.ClearBeforeFill = True
        '
        'PI_Calidad
        '
        Me.PI_Calidad.DataSetName = "PI_Calidad"
        Me.PI_Calidad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UP_Consulta_ReporteCalidad_v2BindingSource
        '
        Me.UP_Consulta_ReporteCalidad_v2BindingSource.DataMember = "UP_Consulta_ReporteCalidad_v2"
        Me.UP_Consulta_ReporteCalidad_v2BindingSource.DataSource = Me.PI_Calidad
        '
        'UP_Consulta_ReporteCalidad_v2TableAdapter
        '
        Me.UP_Consulta_ReporteCalidad_v2TableAdapter.ClearBeforeFill = True
        '
        'frmRepCalidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 765)
        Me.Controls.Add(Me.RepView1)
        Me.Name = "frmRepCalidad"
        Me.Text = "Indicadores de Calidad"
        CType(Me.UP_ReporteResetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProduccionInterfletdbReportes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PI_Calidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UP_Consulta_ReporteCalidad_v2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RepView1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents UP_ReporteResetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProduccionInterfletdbReportes As Interflet.ProduccionInterfletdbReportes
    Friend WithEvents UP_ReporteResetTableAdapter As Interflet.ProduccionInterfletdbReportesTableAdapters.UP_ReporteResetTableAdapter
    Friend WithEvents UP_Consulta_ReporteCalidad_v2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PI_Calidad As Interflet.PI_Calidad
    Friend WithEvents UP_Consulta_ReporteCalidad_v2TableAdapter As Interflet.PI_CalidadTableAdapters.UP_Consulta_ReporteCalidad_v2TableAdapter
End Class
