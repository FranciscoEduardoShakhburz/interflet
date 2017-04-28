Public Class frmMapaUbica

    Private Sub frmMapaUbica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        Kill(My.Application.Info.DirectoryPath & "\mapaviajes.htm")
        Call Cabecera()
        Call Marca()
        Call Cerrar()
        Mundo.Navigate(New System.Uri(My.Application.Info.DirectoryPath & "\mapaviajes.htm"))
    End Sub

    Private Sub Cabecera()
        FileOpen(1, My.Application.Info.DirectoryPath & "\mapaviajes.htm", OpenMode.Append)
        PrintLine(1, "<!DOCTYPE html PUBLIC " & """" & "-//W3C//DTD XHTML 1.0 Transitional//EN" & """ " & """" & "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" & """" & ">")
        PrintLine(1, "<html xmlns=" & """" & "http://www.w3.org/1999/xhtml" & """" & ">")
        PrintLine(1, "<head>")
        PrintLine(1, "<title>Mapa de Ubicacion de Viajes</title>")
        PrintLine(1, "<meta name=" & """" & "viewport" & """" & " content=" & """" & "initial-scale=1.0, user-scalable=no" & """" & "/>")
        PrintLine(1, "<style type=" & """" & "text/css" & """" & ">")
        PrintLine(1, "html { height: 100% }")
        PrintLine(1, "body { height: 100%; margin: 0px; padding: 0px }")
        PrintLine(1, "#map { height: 100% }")
        PrintLine(1, "</style>")
        PrintLine(1, "<script type=" & """" & "text/javascript" & """" & " src=" & """" & "https://maps.google.com/maps/api/js?sensor=false" & """" & ">")
        PrintLine(1, "</script>")
        PrintLine(1, "<script type=" & """" & "text/javascript" & """" & ">")
        FileClose()
    End Sub

    Private Sub Marca()
        FileOpen(1, My.Application.Info.DirectoryPath & "\mapaviajes.htm", OpenMode.Append)

        PrintLine(1, "function load() {")
        PrintLine(1, "var myOptions = { ")
        PrintLine(1, "center: new google.maps.LatLng(" & frmUbicaViajes.latitud & "," & frmUbicaViajes.longitud & "),")
        PrintLine(1, "zoom: 8,")

        PrintLine(1, "mapTypeId: google.maps.MapTypeId.TERRAIN")
        PrintLine(1, "};")

        PrintLine(1, "var map = new google.maps.Map(document.getElementById(" & """" & "map" & """" & "),")
        PrintLine(1, "myOptions);")

        For i As Integer = 0 To frmUbicaViajes.dtMapa.Rows.Count - 1
            PrintLine(1, "Viaje" & i.ToString() & " = new google.maps.Marker({")
            PrintLine(1, "position: new google.maps.LatLng(" & frmUbicaViajes.dtMapa.Rows(i).Item("latitude").ToString() & "," & frmUbicaViajes.dtMapa.Rows(i).Item("longitud").ToString() & "),")
            If frmUbicaViajes.Detalle = True Then
                PrintLine(1, "icon:   'images/flecha.png',")
            Else
                PrintLine(1, "icon:   'images/tracto.png',")
            End If
            PrintLine(1, "map: map,")
            PrintLine(1, "title: '" & frmUbicaViajes.dtMapa.Rows(i).Item("unidad").ToString() & "'")
            PrintLine(1, "	});")

            PrintLine(1, "attachMessage(" & "Viaje" & i.ToString() & " , '" & frmUbicaViajes.dtMapa.Rows(i).Item("unidad").ToString() & "','" & frmUbicaViajes.dtMapa.Rows(i).Item("Cliente").ToString() & "' );")
        Next

        FileClose()
    End Sub

    Private Sub Cerrar()
        FileOpen(1, My.Application.Info.DirectoryPath & "\mapaviajes.htm", OpenMode.Append)

        PrintLine(1, "function attachMessage(marker, unidad, cliente) {")
        PrintLine(1, "var infowindow = new google.maps.InfoWindow(")
        PrintLine(1, "{ content: " & "unidad + " & """" & "  " & """" & "+ cliente" & ",")

        PrintLine(1, "maxWidth: 200")
        PrintLine(1, "});")
        PrintLine(1, "google.maps.event.addListener(marker, 'click', function() {")
        PrintLine(1, "infowindow.open(map,marker);")
        PrintLine(1, " });")
        PrintLine(1, "}")

        PrintLine(1, "}")
        PrintLine(1, "</script>")
        PrintLine(1, "</head>")

        PrintLine(1, "<body onload=" & """" & "load()" & """" & " >")
        PrintLine(1, "<div id=" & """" & "map" & """" & " style=" & """" & "text-align: center; width: 1250px; height: 940px" & """" & "></div>")
        PrintLine(1, "</body>")
        PrintLine(1, "</html>")
        FileClose()
    End Sub
End Class