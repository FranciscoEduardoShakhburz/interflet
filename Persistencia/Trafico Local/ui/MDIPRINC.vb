Option Strict Off
Option Explicit On

'Imports CotizadorInterflet
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Threading
Imports System.Net.Mail
Imports System.Data
Imports System.Net
Imports System.IO

Friend Class MDIPRINC

    Inherits System.Windows.Forms.Form
    Private hilo As Thread
    Private hiloStart As ThreadStart
    Private CallExportarReporte As MethodInvoker

    Private Sub MDIPRINC_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Environment.MachineName.Contains("DAH-100") Or Environment.MachineName.Contains("DAH-171") Then
            Cursor.Current = Cursors.WaitCursor
            'hiloStart = New ThreadStart(AddressOf exportarBackground)
            'CallExportarReporte = New MethodInvoker(AddressOf Me.exportarReporte)
            'hilo = New Thread(hiloStart)
            'hilo.IsBackground = True
            'hilo.Name = "Exportar reporte"
            'hilo.Start()
            Cursor.Current = Cursors.Arrow
        End If
    End Sub

    Private Sub MDIPRINC_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Dispose()
    End Sub

#Region "Reportes"
    Private Sub LiquidacionesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LiquidacionesToolStripMenuItem1.Click

    End Sub

    Private Sub ReporteDeLiquidacionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteDeLiquidacionesToolStripMenuItem.Click
        formLiquidaciones.Show()
    End Sub

    Private Sub ConsultaDeEquiposToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaDeEquiposToolStripMenuItem.Click
        frmConsultaEquipos.Show()
    End Sub


    Private Sub IndicadoresÓrdenesReparacionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IndicadoresÓrdenesReparacionesToolStripMenuItem.Click
        frmOrdenesCompra.Show()
    End Sub

#End Region

#Region "Cotizaciones"
    Private Sub CatálogoDeConceptosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CatálogoDeConceptosToolStripMenuItem.Click
        frm_Cat_Conceptos.Show()
    End Sub

    Private Sub CatálogoDeDestinosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CatálogoDeDestinosToolStripMenuItem.Click
        frmcatDestinos.Show()
    End Sub

    Private Sub CotizarViajeForáneoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CotizarViajeForáneoToolStripMenuItem.Click
        frmCotizador.Show()
    End Sub

    Private Sub ConsultaDeCotizacionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaDeCotizacionesToolStripMenuItem.Click
        FrmConsultaCotizacion.Show()
    End Sub

    Private Sub CotizadorVersión20ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CotizadorVersión20ToolStripMenuItem.Click
        Dim portada As CotizadorInterflet.Portada = New CotizadorInterflet.Portada()
        portada.Show()
    End Sub
#End Region

#Region "Viajes"
    Private Sub DatosViajeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatosViajeToolStripMenuItem.Click
        Cursor.Current = Cursors.AppStarting
        frmDatosViaje.MdiParent = Me
        frmDatosViaje.Show()
    End Sub

    Private Sub EvaluaciónDeViajesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EvaluaciónDeViajesToolStripMenuItem1.Click
        frmEvaluacionviaje.Show()
    End Sub

    Private Sub EvaluaciónDeLocalesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EvaluaciónDeLocalesToolStripMenuItem1.Click
        frmEvaluacionLocal.Show()
    End Sub

    Private Sub RendimientosPromedioToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RendimientosPromedioToolStripMenuItem1.Click
        frmCatRendmientosProm.Show()
    End Sub

    Private Sub FactoresDeAjusteToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FactoresDeAjusteToolStripMenuItem1.Click
        frmCatFactorAjuste.Show()
    End Sub

    Private Sub ReporteDeUtilidadToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteDeUtilidadToolStripMenuItem1.Click
        frmUtilidadViajes.Show()
    End Sub

    Private Sub ReporteDeViajesEvaluadosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteDeViajesEvaluadosToolStripMenuItem1.Click
        frmRepViajesEvaluados.Show()
    End Sub

    Private Sub ReporteDeKilómetrosFinalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteDeKilómetrosFinalesToolStripMenuItem.Click
        formKilometraje.Show()
    End Sub

    Private Sub EmailsXClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmailsXClienteToolStripMenuItem.Click
        formClientes.Show()
    End Sub

    Private Sub EvaluaciónDeViajesVersión20ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EvaluaciónDeViajesVersión20ToolStripMenuItem.Click
        formEvaluacionViaje.Show()
    End Sub
#End Region

#Region "Calidad"
    Private Sub CapturaDeIndicadoresDeCalidadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CapturaDeIndicadoresDeCalidadToolStripMenuItem.Click
        frmIndicadoresCalidad.Show()
    End Sub

    Private Sub ReporteDeIndicadoresDeCalidadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteDeIndicadoresDeCalidadToolStripMenuItem.Click
        frmReporteCalidad.Show()
    End Sub

#End Region

#Region "Monitoreo"
    Private Sub UbicaciónDeViajesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UbicaciónDeViajesToolStripMenuItem.Click
        frmUbicaViajes.Show()
    End Sub

    Private Sub UbicaciónDeUtilitariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UbicaciónDeUtilitariosToolStripMenuItem.Click
        frmUbicaUtilitarios.Show()
    End Sub

    Private Sub ReporteDeMovimientosDeUnidadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteDeMovimientosDeUnidadToolStripMenuItem.Click
        frmRepMovUnidad.Show()
    End Sub


#End Region

    Private Sub TiposDeViajeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TiposDeViajeToolStripMenuItem.Click
        formTipoViaje.Show()
    End Sub

    Private Sub CapturaDeOtrosValesDeDieselToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CapturaDeOtrosValesDeDieselToolStripMenuItem.Click

    End Sub

    Private Sub CasetasIAVEToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CasetasIAVEToolStripMenuItem.Click
        formCasetasIAVE.Show()
    End Sub

    Private Sub ConceptosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConceptosToolStripMenuItem.Click
        formCatGastos.Show()
    End Sub

    Private Sub GastosPorRutaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GastosPorRutaToolStripMenuItem.Click
        formGastosPorRuta.Show()
    End Sub

    Private Sub ReporteDeGastosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteDeGastosToolStripMenuItem.Click
        formReporteGastos.Show()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProveedoresToolStripMenuItem.Click
        formProveedores.Show()
    End Sub

    Private Sub AgenciasAduanalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgenciasAduanalesToolStripMenuItem.Click
        Dim agencia As formAgenciaAduanal = New formAgenciaAduanal("NUEVA")
        agencia.Show()
    End Sub

    Private Sub TerminalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TerminalesToolStripMenuItem.Click
        Dim terminal As formTerminales = New formTerminales("NUEVA")
        terminal.Show()
    End Sub

    Private Sub IngresoDeEIRsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IngresoDeEIRsToolStripMenuItem.Click
        formIngresoEIR.Show()
    End Sub

    Private Sub ReporteDeEIRsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteDeEIRsToolStripMenuItem.Click
        formReporteEIR.Show()
    End Sub

    Private Sub SolicitudDeTransporteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SolicitudDeTransporteToolStripMenuItem.Click
        formSolicitudTransporte.Show()
    End Sub

    Private Sub TiposDeMercancíaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TiposDeMercancíaToolStripMenuItem.Click
        formTiposMercancia.Show()
    End Sub

    Private Sub TiposDeProgramacionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TiposDeProgramacionesToolStripMenuItem.Click
        formTiposProgramacion.Show()
    End Sub

    Private Sub TiposDeContenedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TiposDeContenedorToolStripMenuItem.Click
        formTiposContenedor.Show()
    End Sub

    Private Sub TipoDeMovimientosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipoDeMovimientosToolStripMenuItem.Click
        formTiposMovimiento.Show()
    End Sub

    Private Sub SeguimientoDeSolicitudToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SeguimientoDeSolicitudToolStripMenuItem.Click
        formSeguimiento.Show()
    End Sub

    Private Sub AltaDeEjecutivosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaDeEjecutivosToolStripMenuItem.Click
        formEjecutivos.Show()
    End Sub

    Private Sub CasetasXViajeFaltaCapturaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CasetasXViajeFaltaCapturaToolStripMenuItem.Click
        FormCasetasPendientesCaptura.Show()
    End Sub

    Private Sub FacturasFechaPaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Acceso.Show()
    End Sub

    Private Sub CPSinFacturarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmCPSinFac.Show()
    End Sub

    Private Sub PendientesPorFacturarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PendientesPorFacturarToolStripMenuItem.Click
        FrmCPSinFac.Show()
    End Sub

    Private Sub ConFechaDePaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConFechaDePaseToolStripMenuItem.Click
        Acceso.Show()
    End Sub

    Private Sub ReporteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteToolStripMenuItem.Click
        FrmReporteFacPase.Show()
    End Sub

    Private Sub ConsultaUbicacionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaUbicacionToolStripMenuItem.Click
        frmConsultaDeMov.Show()
    End Sub

    Private Sub MainMenu1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MainMenu1.ItemClicked

    End Sub

    Private Sub EvaluacionLocales20ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EvaluacionLocales20ToolStripMenuItem.Click
        FormEvaluacionLocal.Show()
    End Sub

    Private Sub ReporteProgramacionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteProgramacionToolStripMenuItem.Click

        Cursor.Current = Cursors.AppStarting
        RProgramacio.MdiParent = Me
        RProgramacio.Show()

    End Sub

    Private Sub PaseDeSalidaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaseDeSalidaToolStripMenuItem.Click

        Cursor.Current = Cursors.AppStarting
        PasesSalida.MdiParent = Me
        PasesSalida.Show()

    End Sub

    Private Sub ReProgramacionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReProgramacionToolStripMenuItem.Click

        Cursor.Current = Cursors.AppStarting
        ReProgramacion.MdiParent = Me
        ReProgramacion.Show()

    End Sub

    Private Sub ProgramacionDiariaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgramacionDiariaToolStripMenuItem.Click

        Cursor.Current = Cursors.AppStarting
        ProgramacionDiaria.MdiParent = Me
        ProgramacionDiaria.Show()

    End Sub

    Private Sub ReporteTramoSencilloToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteTramoSencilloToolStripMenuItem.Click

        Cursor.Current = Cursors.AppStarting
        Reporte_tramo_sencillo.MdiParent = Me
        Reporte_tramo_sencillo.Show()

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub

    Private Sub EstatusDeContenedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EstatusDeContenedoresToolStripMenuItem.Click

        Cursor.Current = Cursors.AppStarting
        ReporteEstatusContenedores.MdiParent = Me
        ReporteEstatusContenedores.Show()

    End Sub

    Private Sub AgregarAddendaAClienteBoschToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarAddendaAClienteBoschToolStripMenuItem.Click

        Cursor.Current = Cursors.AppStarting
        AddendaBosch.MdiParent = Me
        AddendaBosch.Show()

    End Sub

    Private Sub InventarioDeUnidadesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InventarioDeUnidadesToolStripMenuItem1.Click

        Cursor.Current = Cursors.AppStarting
        InventarioUnidades.MdiParent = Me
        InventarioUnidades.Show()

    End Sub

    Private Sub ContToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContToolStripMenuItem.Click

        Cursor.Current = Cursors.AppStarting
        Dim cont As SeguimientoEmbarques = New SeguimientoEmbarques()
        cont.MdiParent = Me
        cont.Show()

    End Sub

    Private Sub ReporteDeCPPorUnidadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteDeCPPorUnidadToolStripMenuItem.Click

        Cursor.Current = Cursors.AppStarting
        UltimasCartasPorte.MdiParent = Me
        UltimasCartasPorte.Show()

    End Sub

    Private Sub SellosDeContenedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SellosDeContenedoresToolStripMenuItem.Click

        Cursor.Current = Cursors.AppStarting
        SellosContenedores.MdiParent = Me
        SellosContenedores.Show()

    End Sub

    Private Sub CaptContToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CaptContToolStripMenuItem.Click

        Cursor.Current = Cursors.AppStarting
        CaptSeguimientoEmbarques.MdiParent = Me
        CaptSeguimientoEmbarques.Show()

    End Sub

    Private Sub CrearAsignaciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrearAsignaciónToolStripMenuItem.Click

        Cursor.Current = Cursors.AppStarting
        'AsignacionCargas.MdiParent = Me
        'AsignacionCargas.Show()

    End Sub

    Private Sub AutorizarOperadorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AutorizarOperadorToolStripMenuItem.Click

        Cursor.Current = Cursors.AppStarting
        AutorizarOperador.MdiParent = Me
        AutorizarOperador.Show()

    End Sub

    Private Sub MttoPreventivoDeUnidadesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MttoPreventivoDeUnidadesToolStripMenuItem.Click

        Cursor.Current = Cursors.AppStarting
        MonitorMttoPreventivo.MdiParent = Me
        MonitorMttoPreventivo.Show()

    End Sub

    Private Sub ValesDeGasolinaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ValesDeGasolinaToolStripMenuItem.Click

        Cursor.Current = Cursors.AppStarting
        CatValeGasolina.MdiParent = Me
        CatValeGasolina.Show()

    End Sub

    Private Sub MonitorDeUnidadesEnRutaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MonitorDeUnidadesEnRutaToolStripMenuItem.Click

        'Dim monitor As MonitorUnidadesEnRuta = New MonitorUnidadesEnRuta()
        'monitor.Show()
        Dim monitor As MonitorUniRuta = New MonitorUniRuta()
        monitor.Show()

    End Sub

    Private Sub EstadiasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EstadiasToolStripMenuItem.Click

        Dim estadias As Estadias = New Estadias()
        estadias.MdiParent = Me
        estadias.Show()

    End Sub

    Private Sub AsignacionDeOperadoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AsignacionDeOperadoresToolStripMenuItem.Click

        Dim asig As AsignacionOperadores = New AsignacionOperadores()
        asig.MdiParent = Me
        asig.Show()

    End Sub

    Private Sub UnidadesEnPatioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnidadesEnPatioToolStripMenuItem.Click

        Cursor.Current = Cursors.WaitCursor
        Dim unidades As UnidadesPatio = New UnidadesPatio()
        unidades.Show()
        Cursor.Current = Cursors.Arrow

    End Sub

    Private Sub EnvíoDeCorreosAClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnvíoDeCorreosAClientesToolStripMenuItem.Click

        Dim env As EnvioStatus = New EnvioStatus()
        env.MdiParent = Me
        env.Show()

    End Sub

    Private Sub ReporteDeSalidasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteDeSalidasToolStripMenuItem.Click

        Dim rep As ReporteSalidas = New ReporteSalidas()
        rep.MdiParent = Me
        rep.Show()

    End Sub

    Private Sub AlertasDeTramoSencilloToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlertasDeTramoSencilloToolStripMenuItem.Click

        Dim ale As AlertasTramoSencillo = New AlertasTramoSencillo()
        ale.MdiParent = Me
        ale.Show()

    End Sub

    Private Sub AnticiposEspecialesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnticiposEspecialesToolStripMenuItem.Click

        Dim ant As AnticiposEspeciales = New AnticiposEspeciales()
        ant.MdiParent = Me
        ant.Show()

    End Sub

    Private Sub ReporteDeCPConFPaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteDeCPConFPaseToolStripMenuItem.Click

        Dim repo As RepCpFecPase = New RepCpFecPase()
        repo.MdiParent = Me
        repo.Show()

    End Sub

    Private Sub ClientesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem1.Click

        Dim clientes As Clientes
        clientes = New Clientes()
        clientes.ShowDialog(Me)

    End Sub

    Private Sub MonitorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim moni As MonitorUniRuta
        moni = New MonitorUniRuta()
        moni.Show()

    End Sub

    Private Sub CargasYAsignacionV2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CargasYAsignacionV2ToolStripMenuItem.Click

        Dim cargas As CargasAsignacion
        cargas = New CargasAsignacion()
        cargas.MdiParent = Me
        cargas.Show()


    End Sub

    Private Sub ReporteDeViajeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteDeViajeToolStripMenuItem.Click

        Dim reporte As ReporteViaje
        reporte = New ReporteViaje()
        reporte.MdiParent = Me
        reporte.Show()

    End Sub

    Private Sub BitácoraDeViajesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BitácoraDeViajesToolStripMenuItem.Click

        Dim bv As BitacoraViaje
        bv = New BitacoraViaje()
        bv.ShowDialog(Me)

    End Sub

    Private Sub UnidadesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnidadesToolStripMenuItem.Click

        Dim catUn As CatalogoUnidades
        catUn = New CatalogoUnidades()
        catUn.ShowDialog(Me)

    End Sub

    Private Sub AgregarAdendaAClienteKNToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarAdendaAClienteKNToolStripMenuItem.Click

        Dim adenda As AdendaK_N = New AdendaK_N()
        adenda.MdiParent = Me
        adenda.Show()

    End Sub

    Private Sub ReporteDeMovtosDeUnidadesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteDeMovtosDeUnidadesToolStripMenuItem.Click

        Dim reporte As ReporteMovimientosUnidades = New ReporteMovimientosUnidades()
        reporte.MdiParent = Me
        reporte.Show()

    End Sub

    Public Sub exportarBackground()

        While True

            Me.BeginInvoke(CallExportarReporte)
            Thread.Sleep(18000000)

        End While
    End Sub

    Private Sub exportarReporte()
        Try
            Dim App As New Microsoft.Office.Interop.Excel.Application
            Dim borders As Microsoft.Office.Interop.Excel.Borders
            Dim libro As Microsoft.Office.Interop.Excel.Workbook
            Dim hoja As Microsoft.Office.Interop.Excel.Worksheet
            Dim columnas As Integer
            Dim filas As Integer
            Dim dT As DataTable
            Dim tipo As Integer
            Dim ruta As String
            Dim fecha As Date

            libro = App.Workbooks.Add
            hoja = libro.Worksheets.Add()

            If Date.Now.Day = 27 And Date.Now.Hour >= 9 Then

                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ''''''  ESTE REPORTE SE ENVÍA LOS DÍAS 27 DE CADA MES. A PETICIÓN DEL   ''''''
                ''''''  CLIENTE, ESTE DÍA PUEDE VARIAR Y SOLO ES CUESTIÓN DE CAMBIAR    ''''''        
                ''''''  LAS CONDICIONES DE ACUERDO AL DÍA QUE NOS SOLICITEN.            ''''''
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

                tipo = 1
                ruta = "C:\Reporte de Movimientos Embraco.xlsx"

                If File.Exists(ruta) Then

                    File.Delete(ruta)

                End If

                fecha = Me.consultarUltimaFechaEnvio(tipo)

                If fecha.Day = 27 Then

                    Exit Sub

                End If

                dT = Me.consultarInformacionReporte1(fecha.AddDays(1), DateAndTime.Now)

            Else

                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ''''''  ESTE REPORTE SE ENVÍA EL PRIMER DÍA HÁBIL DE CADA MES.          ''''''
                ''''''  REPORTE DE FACTURACIÓN DE MOVIMIENTOS DE EMBRACO.                ''''''        
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

                tipo = 2
                ruta = "C:\Reporte de Facturacion Embraco.xlsx"

                If File.Exists(ruta) Then

                    File.Delete(ruta)

                End If

                fecha = Me.consultarUltimaFechaEnvio(tipo)

                If Not fecha.Month = Date.Now.Month And Weekday(Date.Now, FirstDayOfWeek.Sunday) >= 2 And Weekday(Date.Now, FirstDayOfWeek.Sunday) <= 6 Then

                    dT = Me.consultarInformacionReporte2(Date.Now)

                Else

                    Exit Sub

                End If
            End If

            filas = dT.Rows.Count
            columnas = dT.Columns.Count

            If filas > 0 Then
                For i As Integer = 0 To columnas - 2

                    hoja.Cells.Item(1, i + 1) = dT.Columns(i).ColumnName

                Next

                For fila As Integer = 0 To filas - 1
                    For columna As Integer = 0 To columnas - 2
                        If (columna + 1) = 5 Then

                            hoja.Cells.Item(fila + 2, columna + 1) = Me.consultarTipoMercancia(dT.Rows(fila)(columnas - 1).ToString())

                        Else

                            hoja.Cells.Item(fila + 2, columna + 1) = dT.Rows(fila)(columna).ToString()

                        End If
                    Next
                Next

                borders = hoja.Range("A1", "I" & filas + 1).Borders
                borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous
                borders.Weight = 2.0R
                'hoja.Range("A1", "M1").MergeCells = True
                hoja.Range("A1", "I1").Interior.Color = ColorTranslator.ToOle(Color.Green)
                hoja.Range("A1", "I1").Font.Size = 11
                hoja.Range("A1", "I1").Font.Color = ColorTranslator.ToOle(Color.White)
                hoja.Range("A1", "I1").Font.Bold = 1
                hoja.Range("A1", "I" & filas + 1).WrapText = True
                hoja.Range("A1", "I" & filas + 1).Font.Size = 11
                hoja.Range("A1", "I" & filas + 1).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
                hoja.Range("A1", "I" & filas + 1).VerticalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
                hoja.Columns.AutoFit()
                libro.SaveAs(ruta)
                hoja = Nothing
                libro = Nothing
                App = Nothing
                GC.Collect()
                Me.eliminarProcesosExcel()
                Me.enviarReporte(ruta, fecha.AddDays(1).ToString("dd/MM/yyyy"), Date.Now.ToString("dd/MM/yyyy"), tipo)
                Me.guardarEnvio(tipo)

            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error al generar Reporte Embraco", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Function consultarInformacionReporte1(ByVal desde As Date, ByVal hasta As Date) As DataTable

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dT As DataTable
        Dim dS As DataSet

        dT = New DataTable()
        dS = New DataSet()

        Try

            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand("UP_ReporteMvtosEmbraco", conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandTimeout = 600
            conexion.Open()

            With comando.Parameters

                .AddWithValue("@fechaDesde", desde)
                .AddWithValue("@fechaHasta", hasta)

            End With

            sDA = New SqlDataAdapter(comando)
            sDA.Fill(dS)
            conexion.Close()
            comando.Dispose()
            conexion.Dispose()

            If dS.Tables.Count > 0 Then

                dT = dS.Tables(0)

            End If
        Catch ex As Exception

            MessageBox.Show("Error al consultar la información del reporte: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        Return dT

    End Function

    Private Function consultarInformacionReporte2(ByVal fecha As Date) As DataTable

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dT As DataTable
        Dim dS As DataSet

        dT = New DataTable()
        dS = New DataSet()

        Try

            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand("UP_ReporteMvtosEmbraco_2", conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandTimeout = 600
            conexion.Open()

            With comando.Parameters

                .AddWithValue("@fechaActual", fecha)

            End With

            sDA = New SqlDataAdapter(comando)
            sDA.Fill(dS)
            conexion.Close()
            comando.Dispose()
            conexion.Dispose()

            If dS.Tables.Count > 0 Then

                dT = dS.Tables(0)

            End If
        Catch ex As Exception

            MessageBox.Show("Error al consultar la información del reporte: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        Return dT

    End Function

    Private Sub enviarReporte(ByVal ruta As String, ByVal desde As String, ByVal hasta As String, ByVal tipo As Integer)

        Dim mensaje As MailMessage
        Dim smtp As SmtpClient
        Dim dominio As String = "@hinojosa.com.mx"

        Dim usuarioDe As String
        Dim contrasena As String
        Dim idPersonalDe As Integer
        'Prueba
        idPersonalDe = 6942 'Omar
        usuarioDe = ObtenerDatosCorreo.nombreUsuario(idPersonalDe)
        contrasena = ObtenerDatosCorreo.contrasena(idPersonalDe)
        usuarioDe = usuarioDe & dominio

        Dim idPersonalParaKarla As Integer
        Dim usuarioParaKarla As String
        Dim idPersonalParaMelina As Integer
        Dim usuarioParaMelina As String
        Dim idPersonalParaAndres As Integer
        Dim usuarioParaAndres As String

        idPersonalParaKarla = 10011 'Karla
        usuarioParaKarla = ObtenerDatosCorreo.nombreUsuario(idPersonalParaKarla)
        usuarioParaKarla = usuarioParaKarla & dominio

        idPersonalParaMelina = 492 'Melina
        usuarioParaMelina = ObtenerDatosCorreo.nombreUsuario(idPersonalParaMelina)
        usuarioParaMelina = usuarioParaMelina & dominio

        idPersonalParaAndres = 122 ' Andres
        usuarioParaAndres = ObtenerDatosCorreo.nombreUsuario(idPersonalParaAndres)
        usuarioParaAndres = usuarioParaAndres & dominio

        Try

            mensaje = New MailMessage()
            smtp = New SmtpClient()
            mensaje.From = New MailAddress(usuarioDe, "Sistema Interflet")
            mensaje.To.Add(usuarioParaKarla)
            mensaje.CC.Add(usuarioParaMelina)
            mensaje.CC.Add(usuarioParaAndres)
            mensaje.Bcc.Add(usuarioDe)
            'mensaje.To.Add(usuarioDe)
            mensaje.Subject = IIf(tipo = 1, "Reporte de movimientos Interflet del " & desde & " al " & hasta, "Reporte de movimientos facturados Interflet")
            mensaje.Body = "<h2 style='font-family: ""Microsoft Yi Baiti""; font-size: 16px;'> Hola Karla, buenos días.</h2><br /><h4 style='font-family: ""Microsoft Yi Baiti""; font-size: 16px;'>Recibe un cordial saludo de nuestra parte, esperando que te encuentres bien en todos los aspectos. Adjunto a este correo encontrarás el reporte de movimientos efectuados en el mes. Para cualquier duda, quedo al pendiente de tus comentarios.</h4><br /><h4 style='font-family: ""Microsoft Yi Baiti""; font-size: 16px;'>Saludos cordiales.</h4>"
            mensaje.IsBodyHtml = True
            mensaje.Priority = MailPriority.Normal
            mensaje.Attachments.Add(New Attachment(ruta))
            smtp.EnableSsl = True
            smtp.Port = 587
            smtp.Host = "smtp.office365.com"
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network
            smtp.Credentials = New NetworkCredential(usuarioDe, contrasena)
            smtp.Send(mensaje)

        Catch ex As Exception

            MessageBox.Show("Error al enviar el correo: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub eliminarProcesosExcel()

        For Each p As Process In System.Diagnostics.Process.GetProcessesByName("EXCEL")

            p.Kill()

        Next
    End Sub

    Private Function consultarUltimaFechaEnvio(ByVal tipo As Integer) As Date

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim consulta As String
        Dim fecha As Date

        fecha = Date.Now

        Try

            consulta = "SELECT TOP(1) fechaEnvio FROM SistemaInterflet_EnvioReportesEmbraco WHERE tipoReporte = " & tipo & " ORDER BY fechaEnvio DESC"
            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand(consulta, conexion)
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 1000
            conexion.Open()
            fecha = Convert.ToDateTime(comando.ExecuteScalar().ToString())
            conexion.Close()
            comando.Dispose()
            conexion.Dispose()

        Catch ex As Exception

            MessageBox.Show("Error: " & ex.Message)

        End Try

        Return fecha

    End Function

    Private Sub guardarEnvio(ByVal tipo As Integer)

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim consulta As String

        Try

            consulta = "INSERT INTO SistemaInterflet_EnvioReportesEmbraco VALUES (GETDATE(), HOST_NAME(), " & tipo & ")"
            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand(consulta, conexion)
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 600
            conexion.Open()
            comando.ExecuteNonQuery()
            conexion.Close()
            comando.Dispose()
            conexion.Dispose()

        Catch ex As Exception

            MessageBox.Show("Error: " & ex.Message)

        End Try
    End Sub

    Private Function consultarTipoMercancia(ByVal referencia As String) As String

        Dim dset As New Data.DataSet
        Dim dad As OleDbDataAdapter
        Dim mercancia As String
        Dim consulta As String
        Dim ruta As String

        consulta = "SELECT Mcia_21 FROM stctrl21.dbf WHERE Refcia21 = '" & referencia & "'"
        ruta = "Z:\reco\TRAFICO\data"
        dad = New OleDbDataAdapter(consulta, "Provider=vfpoledb.1;Data Source=" + ruta + ";Mode=3;")
        mercancia = ""

        Try

            dad.Fill(dset)
            dad.Dispose()
            mercancia = dset.Tables(0).Rows(0)(0).ToString()

        Catch ex As Exception

            MessageBox.Show("Error al buscar la información: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        Return mercancia

    End Function
End Class