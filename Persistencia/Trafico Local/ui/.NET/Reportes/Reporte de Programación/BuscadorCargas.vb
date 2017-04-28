Imports System.Data.OleDb
Imports System.Data
Imports System.Data.SqlClient

Public Class BuscadorCargas

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        Cursor.Current = Cursors.WaitCursor
        Dim dS1, dS2, dS3, dS4, dS5 As DataSet
        Dim carga As DataGridViewRow
        Dim consulta1, consulta2, consulta3, consulta4, consulta5 As String
        Dim ruta1, ruta2, ruta3, ruta4, ruta5 As String

        Me.gridCargas.Rows.Clear()

        If Me.rdBtnReferencia.Checked Then

            consulta1 = "SELECT referencia, contenedor FROM datosrefp.dbf WHERE referencia = '" & Me.txtBusqueda.Text & "'"
            ruta1 = "H:\Sica\LisRep\Patieros\"
            dS1 = Me.buscarInfo(ruta1, consulta1)
            Dim nombreCliente As String = ""

            If dS1.Tables(0).Rows.Count > 0 Then
                For Each info As DataRow In dS1.Tables(0).Rows

                    Me.gridCargas.Rows.Add()
                    carga = Me.gridCargas.Rows(Me.gridCargas.Rows.Count - 1)
                    carga.Cells("Referencia").Value = info.Item(0).ToString()
                    carga.Cells("Contenedor").Value = info.Item(1).ToString().TrimEnd().TrimStart().Substring(0, 4) & "-" & info.Item(1).ToString().TrimStart().TrimEnd().Substring(4, 6) & "-" & info.Item(1).ToString().TrimStart().TrimEnd().Substring(10)
                    ruta2 = "z:\RECO\SORF\EMP003\DATA\"
                    consulta2 = "SELECT tamcon01, tipocon01, pesobr01 FROM srasigtras.dbf WHERE refciaaa = '" & info.Item(0).ToString().TrimEnd().TrimStart() & "' AND numcon01 = '" & (info.Item(1).ToString().TrimEnd().TrimStart().Substring(0, 10) & "-" & info.Item(1).ToString().TrimEnd().TrimStart().Substring(10)) & "'"
                    dS2 = Me.buscarInfo(ruta2, consulta2)

                    If dS2.Tables(0).Rows.Count > 0 Then

                        carga.Cells("Tipo").Value = dS2.Tables(0).Rows(0)(0).ToString() & " " & dS2.Tables(0).Rows(0)(1).ToString()
                        carga.Cells("Peso").Value = dS2.Tables(0).Rows(0)(2).ToString()

                    End If

                    consulta3 = "SELECT terorigen, tipprog, fecdemora, fecalmacen FROM datosref.dbf WHERE referencia = '" & info.Item(0).ToString().TrimStart().TrimEnd() & "'"
                    dS3 = Me.buscarInfo(ruta1, consulta3)

                    If dS3.Tables(0).Rows.Count > 0 Then

                        carga.Cells("TermOrigen").Value = dS3.Tables(0).Rows(0)(0).ToString().TrimEnd().TrimStart()
                        carga.Cells("fechaDemora").Value = Convert.ToDateTime(dS3.Tables(0).Rows(0)(2).ToString().TrimEnd().TrimStart()).ToString("dd/MM/yyyy")
                        carga.Cells("fechaAlmacenaje").Value = Convert.ToDateTime(dS3.Tables(0).Rows(0)(3).ToString().TrimEnd().TrimStart()).ToString("dd/MM/yyyy")

                    Else

                        carga.Cells("TermOrigen").Value = ""
                        carga.Cells("fechaDemora").Value = ""
                        carga.Cells("fechaAlmacenaje").Value = ""
                        
                    End If

                    If String.IsNullOrEmpty(nombreCliente) Then

                        ruta4 = "Z:\RECO\TRAFICO\data\"
                        consulta4 = "SELECT Cvecli21 FROM stctrl21.dbf where refcia21 = '" & info.Item(0).ToString().TrimStart().TrimEnd() & "'"
                        dS4 = Me.buscarInfo(ruta4, consulta4)

                        If dS4.Tables(0).Rows.Count > 0 Then

                            ruta5 = "Z:\RECO\SAAI\DBFS\"
                            consulta5 = "SELECT nomcli18  FROM ssclie18.dbf  where cvecli18 = " & dS4.Tables(0).Rows(0)(0).ToString()
                            dS5 = Me.buscarInfo(ruta5, consulta5)

                            If dS5.Tables(0).Rows.Count > 0 Then

                                nombreCliente = dS5.Tables(0).Rows(0)(0).ToString()
                                carga.Cells("Cliente").Value = nombreCliente

                            End If
                        End If
                    Else

                        carga.Cells("Cliente").Value = nombreCliente

                    End If
                Next
            End If
        ElseIf Me.rdBtnContenedor.Checked Then

            consulta1 = "SELECT TOP(1) referencia, contenedor FROM datosrefp.dbf WHERE contenedor = '" & Me.txtBusqueda.Text.TrimEnd().TrimStart().Replace(" ", "").Replace("-", "") & "' ORDER BY referencia DESC"
            ruta1 = "H:\Sica\LisRep\Patieros\"
            dS1 = Me.buscarInfo(ruta1, consulta1)

            If dS1.Tables(0).Rows.Count > 0 Then
                For Each info As DataRow In dS1.Tables(0).Rows

                    Me.gridCargas.Rows.Add()
                    carga = Me.gridCargas.Rows(Me.gridCargas.Rows.Count - 1)
                    carga.Cells("Referencia").Value = info.Item(0).ToString()
                    carga.Cells("Contenedor").Value = info.Item(1).ToString().TrimEnd().TrimStart().Substring(0, 4) & "-" & info.Item(1).ToString().TrimStart().TrimEnd().Substring(4, 6) & "-" & info.Item(1).ToString().TrimStart().TrimEnd().Substring(10)
                    ruta2 = "z:\RECO\SORF\EMP003\DATA\"
                    consulta2 = "SELECT tamcon01, tipocon01, pesobr01 FROM srasigtras.dbf WHERE refciaaa = '" & info.Item(0).ToString().TrimEnd().TrimStart() & "' AND numcon01 = '" & (info.Item(1).ToString().TrimEnd().TrimStart().Substring(0, 10) & "-" & info.Item(1).ToString().TrimEnd().TrimStart().Substring(10)) & "'"
                    dS2 = Me.buscarInfo(ruta2, consulta2)

                    If dS2.Tables(0).Rows.Count > 0 Then

                        carga.Cells("Tipo").Value = dS2.Tables(0).Rows(0)(0).ToString() & " " & dS2.Tables(0).Rows(0)(1).ToString()
                        carga.Cells("Peso").Value = dS2.Tables(0).Rows(0)(2).ToString()

                    End If

                    consulta3 = "SELECT terorigen, tipprog, fecdemora, fecalmacen FROM datosref.dbf WHERE referencia = '" & info.Item(0).ToString().TrimStart().TrimEnd() & "'"
                    dS3 = Me.buscarInfo(ruta1, consulta3)

                    If dS3.Tables(0).Rows.Count > 0 Then

                        carga.Cells("TermOrigen").Value = dS3.Tables(0).Rows(0)(0).ToString().TrimEnd().TrimStart()
                        carga.Cells("fechaDemora").Value = Convert.ToDateTime(dS3.Tables(0).Rows(0)(2).ToString().TrimEnd().TrimStart()).ToString("dd/MM/yyyy")
                        carga.Cells("fechaAlmacenaje").Value = Convert.ToDateTime(dS3.Tables(0).Rows(0)(3).ToString().TrimEnd().TrimStart()).ToString("dd/MM/yyyy")

                    Else

                        carga.Cells("TermOrigen").Value = ""
                        carga.Cells("fechaDemora").Value = ""
                        carga.Cells("fechaAlmacenaje").Value = ""

                    End If

                    ruta4 = "Z:\RECO\TRAFICO\data\"
                    consulta4 = "SELECT Cvecli21 FROM stctrl21.dbf where refcia21 = '" & info.Item(0).ToString().TrimStart().TrimEnd() & "'"
                    dS4 = Me.buscarInfo(ruta4, consulta4)

                    If dS4.Tables(0).Rows.Count > 0 Then

                        ruta5 = "Z:\RECO\SAAI\DBFS\"
                        consulta5 = "SELECT nomcli18  FROM ssclie18.dbf  where cvecli18 = " & dS4.Tables(0).Rows(0)(0).ToString()
                        dS5 = Me.buscarInfo(ruta5, consulta5)


                        If dS5.Tables(0).Rows.Count > 0 Then

                            carga.Cells("Cliente").Value = dS5.Tables(0).Rows(0)(0).ToString()

                        End If
                    End If
                Next
            End If
        End If

        Cursor.Current = Cursors.Arrow

    End Sub

    
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        Try

            For Each carga As DataGridViewRow In Me.gridCargas.Rows

                Me.actualizarInfoDBF(carga.Cells(0).Value.ToString(), carga.Cells(1).Value.ToString())
                Me.insertarCarga(carga.Cells(0).Value.ToString(), carga.Cells(1).Value.ToString(), carga.Cells(2).Value.ToString(), carga.Cells(3).Value.ToString(), carga.Cells(4).Value.ToString(), carga.Cells(5).Value.ToString(), carga.Cells(6).Value.ToString())

            Next
        Catch ex As Exception

            MessageBox.Show("Hubo un problema al guardar la información: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Exit Sub
        End Try
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Close()

    End Sub

    Private Function buscarInfo(ByVal ruta As String, ByVal consulta As String) As DataSet

        Dim dset As New Data.DataSet

        Dim dad As New OleDbDataAdapter(consulta, "Provider=vfpoledb.1;Data Source=" + ruta + ";Mode=3;")
        
        Try

            dad.Fill(dset)
            dad.Dispose()

        Catch ex As Exception

            MessageBox.Show("Error al buscar la información: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        Return dset

    End Function

    Private Sub actualizarInfoDBF(ByVal ref As String, ByVal cont As String)

        If Me.gridCargas.Rows.Count > 0 Then

            Dim comando As OleDbCommand
            Dim conexion As OleDbConnection
            Dim consulta As String
            Dim ruta As String

            Try

                ruta = "H:\Sica\LisRep\Patieros\"
                conexion = New OleDbConnection("Provider=vfpoledb.1;Data Source=" + ruta + ";Mode=3;")
                consulta = "UPDATE datosrefp.dbf SET estado = 2 WHERE referencia = '" & ref & "' AND contenedor = '" & cont.Replace("-", "") & "'"
                conexion.Open()
                comando = New OleDbCommand(consulta, conexion)
                comando.CommandType = CommandType.Text
                comando.CommandTimeout = 1000
                comando.ExecuteNonQuery()

            Catch ex As Exception

                MessageBox.Show("Error: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try
        End If
    End Sub

    Private Sub insertarCarga(ByVal ref As String, ByVal cont As String, ByVal tipo As String, ByVal peso As String, ByVal terOrigen As String, ByVal fecDemora As String, ByVal fecAlmacenaje As String)

        Dim cn As SqlConnection = Connection.getInstance.getConnection
        Dim command As SqlCommand

        If String.IsNullOrEmpty(cont) Or String.IsNullOrEmpty(ref) Then

            MessageBox.Show("El contenedor y la referencia son requeridos")
            Return

        Else

            cn.Open()
            command = New SqlCommand("up_inserte_RProgramacion", cn)
            command.CommandType = CommandType.StoredProcedure

            With command.Parameters

                .AddWithValue("@TIPO_OPER", "IMPO")
                .AddWithValue("@TERMINAL", terOrigen)
                .AddWithValue("@REFERENCIA", ref.TrimStart().TrimEnd())
                .AddWithValue("@TIPO", tipo)
                .AddWithValue("@PESO", peso)
                .AddWithValue("@DEMORA", fecDemora)
                .AddWithValue("@ALMACENAJE", fecAlmacenaje)
                .AddWithValue("@CONTENEDOR", cont.TrimStart().TrimEnd())
                .AddWithValue("@tipo_insert", 1)

                If Me.cmbTipo.SelectedIndex = 0 Then

                    .AddWithValue("@TIPO_PRO", 2)

                ElseIf Me.cmbTipo.SelectedIndex = 1 Then

                    .AddWithValue("@TIPO_PRO", 3)

                End If
            End With

            Try

                command.ExecuteNonQuery()
                MessageBox.Show("Los datos se han guardado correctamente", "Guardado correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
                
            Catch ex As Exception

                MessageBox.Show("Error: " & ex.Message)

            End Try
        End If
    End Sub

    Private Sub BuscadorCargas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.cmbTipo.SelectedIndex = 0

    End Sub
End Class