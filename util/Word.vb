Imports Microsoft.Office.Interop.Word
Imports System.IO
Imports System.Reflection

Public Class Word

    Public Sub valeDeCaja(ByVal gasto As GastosRuta)
        Dim rutaPlantilla As String = "H:\Sica\LisRep\Reportes Interflet\plantillas\plantilla_vale_de_caja.doc"

        Dim fechaActual As DateTime = DateTime.Now
        Dim rutaLocal As String = "C:\Vales de Caja\" & fechaActual.Year.ToString() & "\" & fechaActual.Month.ToString() & "\" & fechaActual.Day.ToString() & "\"
        Dim plantilla As Object = rutaLocal & gasto.ToString()

        If File.Exists(rutaPlantilla) Then
            If Directory.Exists(rutaLocal) Then
                File.Copy(rutaPlantilla, plantilla, True)
                Me.imprimeValeDeCaja(plantilla, gasto)
            Else
                Directory.CreateDirectory(rutaLocal)
                File.Copy(rutaPlantilla, plantilla)
                Me.imprimeValeDeCaja(plantilla, gasto)
            End If
        End If

    End Sub

    Private Sub imprimeValeDeCaja(ByVal ruta As Object, ByVal gasto As GastosRuta)

        Dim numero As Numero = New Numero()
        Dim app As Application = New Application()
        Dim doc As Document = app.Documents.Open(ruta)

        doc.Activate()

        app.Selection.Find.Execute(FindText:="<ID>", ReplaceWith:=DirectCast(gasto.id, Object), Replace:=Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll)

        app.Selection.Find.Execute(FindText:="<NUMERO_VIAJE>", ReplaceWith:=DirectCast(gasto.viaje, Object), Replace:=Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll)


        app.Selection.Find.Execute(FindText:="<CANTIDAD_VIAJE>", ReplaceWith:=DirectCast(gasto.transferencia, Object), Replace:=Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll)


        app.Selection.Find.Execute(FindText:="<CANTIDAD_VIAJE2>", ReplaceWith:=DirectCast(gasto.cantidad_viaje, Object), Replace:=Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll)


        app.Selection.Find.Execute(FindText:="<DINERO_VIAJE>", ReplaceWith:=DirectCast(numero.ConvertirCadena(Convert.ToDouble(gasto.transferencia)).ToUpper, Object), Replace:=Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll)

        app.Selection.Find.Execute(FindText:="<DINERO_VIAJE2>", ReplaceWith:=DirectCast(numero.ConvertirCadena(Convert.ToDouble(gasto.cantidad_viaje)).ToUpper, Object), Replace:=Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll)


        app.Selection.Find.Execute(FindText:="<DESTINO>", ReplaceWith:=DirectCast(gasto.ruta, Object), Replace:=Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll)


        app.Selection.Find.Execute(FindText:="<CLIENTE_VIAJE>", ReplaceWith:=DirectCast(gasto.cliente, Object), Replace:=Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll)


        app.Selection.Find.Execute(FindText:="<UNIDAD_VIAJE>", ReplaceWith:=DirectCast(gasto.unidad, Object), Replace:=Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll)


        app.Selection.Find.Execute(FindText:="<OPERADOR_VIAJE>", ReplaceWith:=DirectCast(gasto.operador, Object), Replace:=Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll)

        app.Selection.Find.Execute(FindText:="<NOTAS_VIAJE>", ReplaceWith:=DirectCast("", Object), Replace:=Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll)

        app.Selection.Find.Execute(FindText:="<FECHA_VIAJE>", ReplaceWith:=DirectCast(DateTime.Now.ToString(), Object), Replace:=Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll)
        doc.Save()
        app.PrintOut()
        doc.Close()
        doc = Nothing
        app.Quit()
        app = Nothing

    End Sub
End Class