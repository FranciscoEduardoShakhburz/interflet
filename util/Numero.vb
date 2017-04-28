Public Class Numero
    Dim sUnidades() As String = {"", "un", "dos", "tres", "cuatro", "cinco", _
    "seis", "siete", "ocho", "nueve", "diez", _
    "once", "doce", "trece", "catorce", _
    "quince", "dieciseis", _
    "diecisiete", "dieciocho", "diecinueve", "veinte", _
    "veintiún", "veintidos", "veintitres", "veinticuatro", _
    "veinticinco", "veintiseis", "veintisiete", _
    "veintiocho", "veintinueve"}

    Dim sDecenas() As String = {"", "diez", "veinte", "treinta", "cuarenta", "cincuenta", "sesenta", "setenta", "ochenta", "noventa"}

    Dim sCentenas() As String = {"", "ciento", "doscientos", "trescientos", "cuatrocientos", "quinientos", "seiscientos", "setecientos", "ochocientos", "novecientos"}
    Dim sResultado As String = ""


    Public Function ConvertirCadena(ByVal sNumero As String) As String
        Dim dNumero As Double
        Dim dNumAux As Double = 0
        Dim x As Char
        Dim sAux As String

        sResultado = " "
        Try
            dNumero = Convert.ToDouble(sNumero)

        Catch
            Return ""
        End Try

        If (dNumero > 999999999999) Then
            Return ""
        End If
        If (dNumero > 999999999) Then
            dNumAux = dNumero Mod 1000000000000
            sResultado += Numeros(dNumAux, 1000000000) + " mil "
        End If

        If (dNumero > 999999) Then
            dNumAux = dNumero Mod 1000000000
            sResultado += Numeros(dNumAux, 1000000) + " millones "
        End If

        If (dNumero > 999) Then
            dNumAux = dNumero Mod 1000000
            sResultado += Numeros(dNumAux, 1000) + " mil "
        End If

        dNumAux = dNumero Mod 1000
        sResultado += Numeros(dNumAux, 1)

        ''Enseguida verificamos si contiene punto, 
        ''si es así, los convertimos a texto.
        sAux = dNumero.ToString()

        If (sAux.IndexOf(".") >= 0) Then
            sResultado += ObtenerDecimales(sAux)
        End If
        ''Las siguientes líneas convierten 
        ''el primer caracter a mayúscula.
        sAux = sResultado
        x = Char.ToUpper(sResultado(1))
        sResultado = x.ToString()

        For i As Integer = 2 To sAux.Length - 1 Step 1
            sResultado += sAux(i).ToString()
        Next

        Return sResultado
    End Function


    Public Function ConvertirNumero(ByVal dNumero As Double) As String
        Dim dNumAux As Double = 0
        Dim x As Char
        Dim sAux As String

        sResultado = " "

        If (dNumero > 999999999999) Then
            Return ""
        End If
        If (dNumero > 999999999) Then
            dNumAux = dNumero Mod 1000000000000
            sResultado += Numeros(dNumAux, 1000000000) + " mil "
        End If

        If (dNumero > 999999) Then
            dNumAux = dNumero Mod 1000000000
            sResultado += Numeros(dNumAux, 1000000) + " millones "
        End If

        If (dNumero > 999) Then
            dNumAux = dNumero Mod 1000000
            sResultado += Numeros(dNumAux, 1000) + " mil "
        End If

        dNumAux = dNumero Mod 1000
        sResultado += Numeros(dNumAux, 1)


        ''Enseguida verificamos si contiene punto, 
        ''si es así, los convertimos a texto.
        sAux = dNumero.ToString()
        Dim varDecimales As String = ""
        If (sAux.IndexOf(".") >= 0) Then
            varDecimales = ObtenerDecimales(sAux)

        Else
            varDecimales = ""
        End If
        sResultado += varDecimales
        ''Las siguientes líneas convierten 
        ''el primer caracter a mayúscula.
        sAux = sResultado
        x = Char.ToUpper(sResultado(1))
        sResultado = x.ToString()
        For i As Integer = 2 To sAux.Length - 1 Step 1
            sResultado += sAux(i).ToString()
        Next

        Return sResultado
    End Function


    Private Function Numeros(ByVal dNumAux As Double, _
                             ByVal dFactor As Double) As String
        Dim dCociente As Double = dNumAux / dFactor
        Dim dNumero As Double = 0
        Dim iNumero As Integer = 0
        Dim sNumero As String = ""
        Dim sTexto As String = ""

        If (dCociente >= 100) Then
            dNumero = dCociente / 100
            sNumero = dNumero.ToString()
            iNumero = Integer.Parse(sNumero(0).ToString())
            sTexto += Me.sCentenas(iNumero) + " "
        End If

        dCociente = dCociente Mod 100
        If (dCociente >= 30) Then
            dNumero = dCociente / 10
            sNumero = dNumero.ToString()
            iNumero = Integer.Parse(sNumero(0).ToString())
            If (iNumero > 0) Then
                sTexto += Me.sDecenas(iNumero) + " "
            End If

            dNumero = dCociente Mod 10
            sNumero = dNumero.ToString()
            iNumero = Integer.Parse(sNumero(0).ToString())
            If (iNumero > 0) Then
                sTexto += "y " + Me.sUnidades(iNumero) + " "
            End If

        Else
            dNumero = dCociente
            sNumero = dNumero.ToString()
            If (sNumero.Length > 1) Then
                If (sNumero(1) <> ".") Then
                    iNumero = Integer.Parse(sNumero(0).ToString() + sNumero(1).ToString())
                Else
                    iNumero = Integer.Parse(sNumero(0).ToString())
                End If
            Else
                iNumero = Integer.Parse(sNumero(0).ToString())
                sTexto += Me.sUnidades(iNumero) + " "
            End If
        End If

        Return sTexto
    End Function


    Private Function ObtenerDecimales(ByVal sNumero As String) As String
        Dim sNumPuntos() As String
        Dim sTexto As String = ""
        Dim dNumero As Double = 0
        sNumPuntos = sNumero.Split(".")
        dNumero = Convert.ToDouble(sNumPuntos(1))
        sTexto = "punto " + Numeros(dNumero, 1)
        Return sTexto
    End Function
End Class
