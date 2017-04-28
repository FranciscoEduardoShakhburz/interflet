Imports System.Data
Imports System.Data.SqlClient

Public Class RepCpFecPase

    Private dS As DataSet

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.dS = New DataSet()

    End Sub

    Private Sub RepCpFecPase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.cBSucursal.SelectedIndex = 0

    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click

        Cursor.Current = Cursors.WaitCursor
        Me.exportar()
        Cursor.Current = Cursors.Arrow
        
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Me.Close()

    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        Cursor.Current = Cursors.WaitCursor
        Me.dGVCP.Rows.Clear()
        Me.dS = Me.consultarInformacion()
        Me.mostrarInfoGrid(Me.dS)
        Cursor.Current = Cursors.Arrow

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        Cursor.Current = Cursors.WaitCursor
        Me.guardarInfo()
        Cursor.Current = Cursors.Arrow

    End Sub

    Private Function consultarInformacion() As DataSet

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet

        dS = New DataSet()

        Try

            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand("UP_ConsultaCPSinFechaPase", conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandTimeout = 600

            With comando.Parameters

                .AddWithValue("@desde", Me.dTPDesde.Value)
                .AddWithValue("@hasta", Me.dTPHasta.Value)

                If Me.cBSucursal.SelectedItem.ToString().Contains("ALTAM") Then

                    .AddWithValue("@sucursal", 1)

                ElseIf Me.cBSucursal.SelectedItem.ToString().Contains("MANZA") Then

                    .AddWithValue("@sucursal", 2)

                ElseIf Me.cBSucursal.SelectedItem.ToString().Contains("VERA") Then

                    .AddWithValue("@sucursal", 3)

                Else

                    .AddWithValue("@sucursal", 0)

                End If
            End With

            conexion.Open()
            sDA = New SqlDataAdapter(comando)
            sDA.Fill(dS)
            conexion.Close()
            conexion.Dispose()
            comando.Dispose()
        Catch ex As Exception

            MessageBox.Show("Error al consultar la información: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        Return dS

    End Function

    Private Sub mostrarInfoGrid(ByVal dS As DataSet)

        Dim dato As DataGridViewRow

        If dS.Tables.Count > 0 Then
            If dS.Tables(0).Rows.Count > 0 Then
                For Each unidad As DataRow In dS.Tables(0).Rows

                    dato = Me.dGVCP.Rows(Me.dGVCP.Rows.Add())
                    dato.Cells("colFPase").Value = unidad("Fecha de pase").ToString()
                    dato.Cells("colCP").Value = unidad("Carta porte").ToString()
                    dato.Cells("colImpreso").Value = Me.estaImpresa(unidad("Carta porte").ToString())

                Next
            End If
        End If
    End Sub

    Private Sub guardarInfo()

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim consulta As String

        For Each carta As DataGridViewRow In Me.dGVCP.Rows
            If carta.Cells("colImpreso").Value = True Then

                consulta = "INSERT INTO Trafico_CPConFPase_Impresas VALUES ('" & carta.Cells("colCP").Value.ToString() & "', '" & carta.Cells("colFPase").Value.ToString() & "')"

            Else

                consulta = "DELETE FROM Trafico_CPConFPase_Impresas WHERE cartaPorte = '" & carta.Cells("colCP").Value.ToString() & "'"

            End If

            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand(consulta, conexion)
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 600
            conexion.Open()
            comando.ExecuteNonQuery()
            conexion.Close()
            conexion.Dispose()
            comando.Dispose()

        Next
    End Sub

    Private Function estaImpresa(ByVal cp As String) As Boolean

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim consulta As String
        Dim impresa As Boolean

        Try

            consulta = "SELECT COUNT(*) FROM Trafico_CPConFPase_Impresas WHERE cartaPorte = '" & cp & "'"
            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand(consulta, conexion)
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 600
            conexion.Open()
            impresa = IIf(Convert.ToInt32(comando.ExecuteScalar().ToString()) > 0, True, False)
            conexion.Close()
            conexion.Dispose()
            comando.Dispose()

        Catch ex As Exception

            MessageBox.Show("Error al consultar la información: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        Return impresa

    End Function

    Private Sub exportar()

        Dim ds As DataSet
        Dim fila As DataRow

        If Me.dS.Tables.Count > 0 Then
            If Me.dS.Tables(0).Rows.Count > 0 Then

                ds = New DataSet()
                ds.Tables.Add()

                For Each columna As DataColumn In Me.dS.Tables(0).Columns

                    ds.Tables(0).Columns.Add(columna.ColumnName)

                Next

                For Each cp As DataRow In Me.dS.Tables(0).Rows
                    If Not Me.estaImpresa(cp("Carta porte").ToString()) Then

                        ds.Tables(0).Rows.Add()
                        fila = ds.Tables(0).Rows(ds.Tables(0).Rows.Count - 1)
                        fila("Fecha de pase") = cp("Fecha de pase").ToString()
                        fila("Carta porte") = cp("Carta porte").ToString()
                        fila("Fecha CP") = cp("Fecha CP").ToString()
                        fila("Cliente") = cp("Cliente").ToString()
                        fila("Nombre de cliente") = cp("Nombre de cliente").ToString()
                        fila("Observaciones") = cp("Observaciones").ToString()

                    End If
                Next

                Excel.datasetToExcel(ds)

            End If
        End If
    End Sub
End Class