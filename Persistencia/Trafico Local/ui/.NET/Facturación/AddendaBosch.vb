Imports System.Data.SqlClient
Imports System.Xml
Imports System.IO

Public Class AddendaBosch

    Private Sub btnSelArchivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelArchivo.Click

        Me.buscarDestino.ShowDialog(Me)
        Me.txtRuta.Text = Me.buscarDestino.SelectedPath
        Me.btnModificar.Enabled = True

    End Sub

    Private Sub AddendaBosch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.btnModificar.Enabled = False

    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

        Cursor.Current = Cursors.WaitCursor
        Dim dA As SqlDataAdapter
        Dim dS As DataSet
        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim nameSpaces As XmlNamespaceManager
        Dim factura As XmlDocument
        Dim addenda, nodo1, nodo2, nodo3, nodo4 As XmlElement
        Dim nodoPrincipal As XmlNode
        Dim atributo As XmlAttribute
        Dim sql, ruta, destino As String

        Try

            conexion = Connection.getInstance().getConnection()
            conexion.Open()
            sql = "SELECT num_guia FROM trafico_guia WHERE id_Cliente = 698 AND (fecha_guia >= '" & Me.dteDesde.Value.ToString("dd-MM-yyyy") & "' AND fecha_guia <= '" & Me.dteHasta.Value.AddDays(1).ToString("dd-MM-yyyy") & "') AND tipo_doc = 1"
            comando = New SqlCommand(sql, conexion)
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 1000
            dA = New SqlDataAdapter(comando)
            dS = New DataSet()
            dA.Fill(dS)
            ruta = "\\\\Dah-191n\\Archivos\\"

            If dS.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To dS.Tables(0).Rows.Count - 1

                    destino = Me.txtRuta.Text & "\\" & dS.Tables(0).Rows(i)(0).ToString() & ".xml"
                    ruta += dS.Tables(0).Rows(i)(0).ToString() & ".xml"

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
                    addenda = factura.CreateElement(nodoPrincipal.GetPrefixOfNamespace(nodoPrincipal.NamespaceURI), "Addenda", nodoPrincipal.NamespaceURI)
                    nodo1 = factura.CreateElement("customized")
                    nodo1.SetAttribute("xmlns", "http://repository.edicomnet.com/schemas/mx/cfd/addenda")
                    atributo = factura.CreateAttribute("xsi", "schemaLocation", " ")
                    atributo.Value = "http://repository.edicomnet.com/schemas"
                    nodo1.Attributes.Append(atributo)
                    nodo1.RemoveAttributeAt(2)
                    'nodo1.SetAttribute("xsi:schemaLocation", "http://repository.edicomnet.com/schemas")
                    nodo2 = factura.CreateElement("EDICOM_GENERICA")
                    nodo1.AppendChild(nodo2)
                    nodo4 = factura.CreateElement("elementos")
                    nodo2.AppendChild(nodo4)
                    nodo2 = factura.CreateElement("elemento")
                    nodo4.AppendChild(nodo2)
                    nodo3 = nodo2
                    nodo2 = factura.CreateElement("etiqueta")
                    nodo2.InnerText = "OC"
                    nodo3.AppendChild(nodo2)
                    nodo2 = factura.CreateElement("descripcion")
                    nodo2.InnerText = "Orden de compra"
                    nodo3.AppendChild(nodo2)
                    nodo2 = factura.CreateElement("valor")
                    nodo2.InnerText = "CONTRATO"
                    nodo3.AppendChild(nodo2)
                    nodo3 = factura.CreateElement("elemento")
                    nodo4.AppendChild(nodo3)
                    nodo2 = factura.CreateElement("etiqueta")
                    nodo2.InnerText = "CP"
                    nodo3.AppendChild(nodo2)
                    nodo2 = factura.CreateElement("descripcion")
                    nodo2.InnerText = "Codigo de planta"
                    nodo3.AppendChild(nodo2)
                    nodo2 = factura.CreateElement("valor")
                    nodo2.InnerText = "AguP"
                    nodo3.AppendChild(nodo2)
                    addenda.AppendChild(nodo1)
                    nodoPrincipal.AppendChild(addenda)
                    factura.Save(destino)
                    Me.modificarArchivo(destino)

                Next
            End If

            MessageBox.Show("Listo", "¡Listo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Catch ex As Exception

            MessageBox.Show("Error: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Dispose()

    End Sub

    Private Sub modificarArchivo(ByVal path As String)

        Dim lines = File.ReadAllLines(path)

        For i As Integer = 0 To lines.Length - 1
            If lines(i).contains("xmlns:xsi="" """) Then

                lines(i) = lines(i).replace(" xmlns:xsi="" """, "")
                Exit For

            End If
        Next

        File.WriteAllLines(path, lines)

    End Sub
End Class