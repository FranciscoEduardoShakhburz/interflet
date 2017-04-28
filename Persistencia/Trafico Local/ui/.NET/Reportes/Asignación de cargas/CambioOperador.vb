Imports System.Data
Imports System.Data.SqlClient

Public Class CambioOperador

    Private carga As DataGridViewRow

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByRef carga As DataGridViewRow)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.carga = carga

    End Sub

    Private Sub CambioOperador_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.cargarInformacion()

    End Sub

    Private Sub dGVAltamira_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dGVAltamira.CellDoubleClick

        Me.carga.Cells("colOperadorAs").Value = Me.dGVAltamira.SelectedRows(0).Cells("colOperador").Value.ToString()
        Me.Close()

    End Sub

    Private Sub dGVManzanillo_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dGVManzanillo.CellDoubleClick

        Me.carga.Cells("colOperadorAs").Value = Me.dGVManzanillo.SelectedRows(0).Cells("colOperadorMzo").Value.ToString()
        Me.Close()

    End Sub

    Private Sub dGVVeracruz_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dGVVeracruz.CellDoubleClick

        Me.carga.Cells("colOperadorAs").Value = Me.dGVVeracruz.SelectedRows(0).Cells("colOperadorVer").Value.ToString()
        Me.Close()

    End Sub

    Private Sub cargarInformacion()

        Dim tracto As DataGridViewRow
        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim consulta As String
        Dim dS As DataSet

        Try

            consulta = "SELECT * FROM SistemaInterflet_CatUnidades sicu ORDER BY sicu.areaId ASC"
            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand(consulta, conexion)
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 600
            conexion.Open()
            dS = New DataSet()
            sDA = New SqlDataAdapter(comando)
            sDA.Fill(dS)
            conexion.Close()
            comando.Dispose()
            conexion.Dispose()

            If dS.Tables.Count > 0 Then
                If dS.Tables(0).Rows.Count > 0 Then
                    For Each unidad As DataRow In dS.Tables(0).Rows
                        If unidad("areaId").ToString().Equals("1") Then

                            tracto = Me.dGVAltamira.Rows(Me.dGVAltamira.Rows.Add())
                            tracto.Cells("colId").Value = Convert.ToInt32(unidad("id").ToString())
                            tracto.Cells("colEconomico").Value = unidad("economico").ToString()
                            tracto.Cells("colPlacas").Value = unidad("placas").ToString()
                            tracto.Cells("colOperador").Value = unidad("operador").ToString()
                            tracto.Cells("colCel").Value = unidad("celularAsignado").ToString()

                            If Not String.IsNullOrEmpty(unidad("fechaVencExamenMedico").ToString()) Then

                                tracto.Cells("colFechaVencExamenMedico").Value = Convert.ToDateTime(unidad("fechaVencExamenMedico").ToString()).ToString("dd/MM/yyyy")

                            Else

                                tracto.Cells("colFechaVencExamenMedico").Value = ""

                            End If

                            If Not String.IsNullOrEmpty(unidad("fechaVencLicencia").ToString()) Then

                                tracto.Cells("colFechaVencLic").Value = Convert.ToDateTime(unidad("fechaVencLicencia").ToString()).ToString("dd/MM/yyyy")

                            Else

                                tracto.Cells("colFechaVencLic").Value = ""

                            End If
                        ElseIf unidad("areaId").ToString().Equals("2") Then

                            tracto = Me.dGVManzanillo.Rows(Me.dGVManzanillo.Rows.Add())
                            tracto.Cells("colIdMzo").Value = Convert.ToInt32(unidad("id").ToString())
                            tracto.Cells("colEconomicoMzo").Value = unidad("economico").ToString()
                            tracto.Cells("colPlacasMzo").Value = unidad("placas").ToString()
                            tracto.Cells("colOperadorMzo").Value = unidad("operador").ToString()
                            tracto.Cells("colCelMzo").Value = unidad("celularAsignado").ToString()

                            If Not String.IsNullOrEmpty(unidad("fechaVencExamenMedico").ToString()) Then

                                tracto.Cells("colFechaVencExamenMedicoMzo").Value = Convert.ToDateTime(unidad("fechaVencExamenMedico").ToString()).ToString("dd/MM/yyyy")

                            Else

                                tracto.Cells("colFechaVencExamenMedicoMzo").Value = ""

                            End If

                            If Not String.IsNullOrEmpty(unidad("fechaVencLicencia").ToString()) Then

                                tracto.Cells("colFechaVencLicMzo").Value = Convert.ToDateTime(unidad("fechaVencLicencia").ToString()).ToString("dd/MM/yyyy")

                            Else

                                tracto.Cells("colFechaVencLicMzo").Value = ""

                            End If
                        ElseIf unidad("areaId").ToString().Equals("3") Then

                            tracto = Me.dGVVeracruz.Rows(Me.dGVVeracruz.Rows.Add())
                            tracto.Cells("colIdVer").Value = Convert.ToInt32(unidad("id").ToString())
                            tracto.Cells("colEconomicoVer").Value = unidad("economico").ToString()
                            tracto.Cells("colPlacasVer").Value = unidad("placas").ToString()
                            tracto.Cells("colOperadorVer").Value = unidad("operador").ToString()
                            tracto.Cells("colCelVer").Value = unidad("celularAsignado").ToString()

                            If Not String.IsNullOrEmpty(unidad("fechaVencExamenMedico").ToString()) Then

                                tracto.Cells("colFechaVencExamenMedicoVer").Value = Convert.ToDateTime(unidad("fechaVencExamenMedico").ToString()).ToString("dd/MM/yyyy")

                            Else

                                tracto.Cells("colFechaVencExamenMedicoVer").Value = ""

                            End If

                            If Not String.IsNullOrEmpty(unidad("fechaVencLicencia").ToString()) Then

                                tracto.Cells("colFechaVencLicVer").Value = Convert.ToDateTime(unidad("fechaVencLicencia").ToString()).ToString("dd/MM/yyyy")

                            Else

                                tracto.Cells("colFechaVencLicVer").Value = ""

                            End If
                        End If
                    Next
                End If
            End If
        Catch ex As Exception

            MessageBox.Show("Error al cargar la información del catálogo: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
End Class