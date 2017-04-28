<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporte
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.ProduccionInterfletdbReportes = New Interflet.ProduccionInterfletdbReportes
        Me.UP_PruebaReporteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UP_PruebaReporteTableAdapter = New Interflet.ProduccionInterfletdbReportesTableAdapters.UP_PruebaReporteTableAdapter
        Me.ReportViewer = New Microsoft.Reporting.WinForms.ReportViewer
        CType(Me.ProduccionInterfletdbReportes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UP_PruebaReporteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProduccionInterfletdbReportes
        '
        Me.ProduccionInterfletdbReportes.DataSetName = "ProduccionInterfletdbReportes"
        Me.ProduccionInterfletdbReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UP_PruebaReporteBindingSource
        '
        Me.UP_PruebaReporteBindingSource.DataMember = "UP_PruebaReporte"
        Me.UP_PruebaReporteBindingSource.DataSource = Me.ProduccionInterfletdbReportes
        '
        'UP_PruebaReporteTableAdapter
        '
        Me.UP_PruebaReporteTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer
        '
        Me.ReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "ProduccionInterfletdbReportes_UP_PruebaReporte"
        ReportDataSource1.Value = Me.UP_PruebaReporteBindingSource
        Me.ReportViewer.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer.LocalReport.ReportEmbeddedResource = "Interflet.CatConceptos.rdlc"
        Me.ReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer.Name = "ReportViewer"
        Me.ReportViewer.Size = New System.Drawing.Size(801, 401)
        Me.ReportViewer.TabIndex = 0
        '
        'frmReporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 401)
        Me.Controls.Add(Me.ReportViewer)
        Me.Name = "frmReporte"
        Me.Text = "frmReporte"
        CType(Me.ProduccionInterfletdbReportes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UP_PruebaReporteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UP_PruebaReporteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProduccionInterfletdbReportes As Interflet.ProduccionInterfletdbReportes
    Friend WithEvents UP_PruebaReporteTableAdapter As Interflet.ProduccionInterfletdbReportesTableAdapters.UP_PruebaReporteTableAdapter
    Friend WithEvents ReportViewer As Microsoft.Reporting.WinForms.ReportViewer
End Class
