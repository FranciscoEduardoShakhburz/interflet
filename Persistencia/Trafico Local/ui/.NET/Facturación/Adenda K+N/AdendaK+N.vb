Imports System.IO
Imports System.Xml
Imports System.Data
Imports System.Data.SqlClient

Public Class AdendaK_N

    Private Sub AdendaK_N_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.rBFechas.Checked = True

    End Sub

    Private Sub bSeleccionarRuta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSeleccionarRuta.Click

        Me.fBDRutaDestino.ShowDialog(Me)
        Me.tBRuta.Text = Me.fBDRutaDestino.SelectedPath
        Me.bModificar.Enabled = True

    End Sub

    Private Sub bModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bModificar.Click

        Cursor.Current = Cursors.WaitCursor
        Me.insertarAdenda(Me.xmlFacturas())
        Cursor.Current = Cursors.Arrow

    End Sub

    Private Sub bSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSalir.Click

        Me.Close()

    End Sub

    Private Sub rBFechas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rBFechas.CheckedChanged, rBFactura.CheckedChanged

        If Me.rBFechas.Checked Then

            Me.dTPDesde.Enabled = True
            Me.dTPHasta.Enabled = True
            Me.tBFactura.Text = ""
            Me.tBFactura.Enabled = False

        ElseIf Me.rBFactura.Checked Then

            Me.tBFactura.Enabled = True
            Me.dTPDesde.Enabled = False
            Me.dTPHasta.Enabled = False

        End If
    End Sub

    Private Function xmlFacturas() As DataSet

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim consulta As String
        Dim dS As DataSet
        dS = New DataSet

        Try

            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand("UP_XmlKuehneAndNagelInfo", conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandTimeout = 600

            With comando.Parameters

                .AddWithValue("@fechaDesde", Me.dTPDesde.Value)
                .AddWithValue("@fechaHasta", Me.dTPHasta.Value)
                .AddWithValue("@factura", Me.tBFactura.Text)
                .AddWithValue("@tipoCons", IIf(Me.rBFechas.Checked = True, 1, 2))

            End With

            sDA = New SqlDataAdapter(comando)
            sDA.Fill(dS)
            conexion.Close()
            comando.Dispose()
            conexion.Dispose()

        Catch ex As Exception

            MessageBox.Show("Error al consultar los archivos: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        Return dS

    End Function

    Private Sub insertarAdenda(ByVal dS As DataSet)

        Dim nameSpaces As XmlNamespaceManager
        Dim nameSpaces1 As XmlNamespaceManager
        Dim nodoPrincipal As XmlNode
        Dim atributo As XmlAttribute
        Dim factura As XmlDocument
        Dim adenda As XmlElement
        Dim nodo1 As XmlElement
        Dim nodo2 As XmlElement
        Dim nodo3 As XmlElement
        Dim nodo4 As XmlElement
        Dim nodo5 As XmlElement
        Dim nodo6 As XmlElement
        Dim nodo7 As XmlElement
        Dim destino As String
        Dim ruta As String

        Try

            ruta = "\\\\Dah-191n\\Archivos\\"

            If dS.Tables(0).Rows.Count > 0 Then
                For Each fact As DataRow In dS.Tables(0).Rows
                    If Not fact("observaciones").ToString().Contains("*") Then

                        MessageBox.Show("El número FILE no se encuentra registrado en el pedido de la factura " & fact("factura") & "", "¡Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Continue For

                    End If

                    destino = Me.tBRuta.Text & "\\" & fact("factura").ToString() & ".xml"
                    ruta += fact("factura").ToString() & ".xml"

                    If File.Exists(destino) Then

                        File.Delete(destino)

                    End If

                    File.Copy(ruta, destino)
                    ruta = "\\\\Dah-191n\\Archivos\\"
                    factura = New XmlDocument()
                    factura.Load(destino)
                    nameSpaces = New XmlNamespaceManager(factura.NameTable)
                    nameSpaces.AddNamespace("cfdi", "http://www.sat.gob.mx/cfd/3")
                    nodoPrincipal = factura.SelectSingleNode("/cfdi:Comprobante", nameSpaces)
                    adenda = factura.CreateElement(nodoPrincipal.GetPrefixOfNamespace(nodoPrincipal.NamespaceURI), "Addenda", nodoPrincipal.NamespaceURI)
                    nodo1 = factura.CreateNode(XmlNodeType.Element, "kn", "KNRECEPCION", "http://www.w3.org/2001/XMLSchema")
                    nodo1.SetAttribute("xsi:schemaLocation", "C:\Users\david.dominguez\Desktop\XSD_17_11_2016.xsd")
                    nodo2 = factura.CreateNode(XmlNodeType.Element, "kn", "Tipo", "http://www.w3.org/2001/XMLSchema")
                    nodo1.AppendChild(nodo2)
                    nodo3 = factura.CreateNode(XmlNodeType.Element, "kn", "FacturasKN", "http://www.w3.org/2001/XMLSchema")
                    nodo2.AppendChild(nodo3)
                    nodo4 = factura.CreateNode(XmlNodeType.Element, "kn", "Purchase_Order", "http://www.w3.org/2001/XMLSchema")
                    nodo4.InnerText = " "
                    nodo5 = factura.CreateNode(XmlNodeType.Element, "kn", "FileNumber_GL", "http://www.w3.org/2001/XMLSchema")

                    If fact("observaciones").ToString().Contains("*") Then

                        nodo5.InnerText = "73" & fact("observaciones").ToString().Split("*")(1).Split(" ")(0)

                    Else

                        nodo5.InnerText = " "

                    End If

                    nodo6 = factura.CreateNode(XmlNodeType.Element, "kn", "Branch_Centre", "http://www.w3.org/2001/XMLSchema")
                    nodo6.InnerText = "10II"
                    nodo7 = factura.CreateNode(XmlNodeType.Element, "kn", "TransportRef", "http://www.w3.org/2001/XMLSchema")
                    nodo7.InnerText = " "
                    nodo3.AppendChild(nodo4)
                    nodo3.AppendChild(nodo5)
                    nodo3.AppendChild(nodo6)
                    nodo3.AppendChild(nodo7)
                    adenda.AppendChild(nodo1)
                    nodoPrincipal.AppendChild(adenda)
                    factura.Save(destino)
                    Me.modificarArchivo(destino)
                    MessageBox.Show("¡Archivos modificados correctamente!", "¡Correcto!", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Next

            Else

                MessageBox.Show("No se encontraron archivos con los parámetro de búsquerda actuales.", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If
        Catch ex As Exception

            MessageBox.Show("Error al generar la adenda: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub modificarArchivo(ByVal path As String)

        Dim lines = File.ReadAllLines(path)

        For i As Integer = 0 To lines.Length - 1
            If lines(i).contains(" schemaLocation") Then

                lines(i) = lines(i).replace(" schemaLocation", " xsi:schemaLocation")
                Exit For

            End If
        Next

        File.WriteAllLines(path, lines)

    End Sub
End Class