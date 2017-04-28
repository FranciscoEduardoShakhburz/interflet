Imports System.Data
Imports System.Data.SqlClient

Public Class CatRutas

    Private infoRutas As DataTable

    Private Sub CatRutas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.consultarRutas()

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Close()

    End Sub

    Private Sub consultarRutas()

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet

        Try

            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand("up_consulta_rutas", conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandTimeout = 600
            conexion.Open()
            dS = New DataSet()
            sDA = New SqlDataAdapter(comando)
            sDA.Fill(dS)

            If dS.Tables.Count > 0 Then
                If dS.Tables(0).Rows.Count > 0 Then

                    Me.infoRutas = dS.Tables(0)
                    dS.Tables(0).Rows("ID").Delete()
                    dS.Tables(0).Rows("Fecha de alta").Delete()
                    dS.Tables(0).Rows("Lugar que ingresó").Delete()
                    dS.Tables(0).AcceptChanges()
                    Me.dGVRutas.DataSource = dS.Tables(0)

                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click

        Me.consultarRutas()

    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

        Dim ingresar As IngresarRuta = New IngresarRuta()
        ingresar.ShowDialog(Me)

    End Sub
End Class