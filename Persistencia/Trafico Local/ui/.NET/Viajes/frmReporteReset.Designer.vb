<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteReset
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
        Me.ReportViewer = New Microsoft.Reporting.WinForms.ReportViewer
        Me.ProduccionInterfletdbReportes = New Interflet.ProduccionInterfletdbReportes
        Me.BS_ReporteReset = New System.Windows.Forms.BindingSource(Me.components)
        Me.UP_ReporteResetTableAdapter = New Interflet.ProduccionInterfletdbReportesTableAdapters.UP_ReporteResetTableAdapter
        CType(Me.ProduccionInterfletdbReportes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_ReporteReset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()



        Me.ReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "ProduccionInterfletdbReportes_UP_ReporteReset"
        ReportDataSource1.Value = Me.BS_ReporteReset
        Me.ReportViewer.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer.LocalReport.ReportEmbeddedResource = "Interflet.Report1.rdlc"
        Me.ReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer.Name = "ReportViewer"
        Me.ReportViewer.Size = New System.Drawing.Size(801, 401)
        Me.ReportViewer.TabIndex = 0



        Me.ProduccionInterfletdbReportes.DataSetName = "ProduccionInterfletdbReportes"
        Me.ProduccionInterfletdbReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema



        Me.BS_ReporteReset.DataMember = "UP_ReporteReset"
        Me.BS_ReporteReset.DataSource = Me.ProduccionInterfletdbReportes



        Me.UP_ReporteResetTableAdapter.ClearBeforeFill = True



        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 401)
        Me.Controls.Add(Me.ReportViewer)
        Me.Name = "frmReporteReset"
        Me.Text = "Reporte Reset"
        CType(Me.ProduccionInterfletdbReportes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_ReporteReset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ProduccionInterfletdbReportes As Interflet.ProduccionInterfletdbReportes
    Friend WithEvents ReportViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents BS_ReporteReset As System.Windows.Forms.BindingSource
    Friend WithEvents UP_ReporteResetTableAdapter As Interflet.ProduccionInterfletdbReportesTableAdapters.UP_ReporteResetTableAdapter
End Class
