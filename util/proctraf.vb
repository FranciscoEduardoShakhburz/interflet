Option Strict Off
Option Explicit On
Module proctraf
	Public Const F_Fecha As String = "mm/dd/aaaa"
	Public Const IDFac As String = "F"
	Public Const IdPais As String = "W"
	Public Const IdUnidad As String = "V"
	Public Const IdEje As String = "U"
	Public Const IdClase As String = "N"
	Public Const IdMoneda As String = "P"
	Public Const IdTran As String = "t"
	Public Const Idadua As String = "H"
	Public Const IdGpo As String = "M"
	Public Const IdEdo As String = "K"
	Public Const IdOfi As String = "Q"
	Public Const IdCia As String = "A"
	Public Const IdCd As String = "L"
	Public Const IdEjecutivo As String = "C"
    Public TipoVista As String
    Public Midescrip As String
    Public MiParte As New VB6.FixedLengthString(15)
    Public MiFraccion As String
    Public campos As ADODB.Fields
    Public Registro As ADODB.Recordset
    Public Miconex As ADODB.Connection
    Public Miconexprueba As ADODB.Connection
    Public MiUnidad As String
    Public MiViaje As Short
    Public IdenHf As String
    Public VarTmp As String
    Public PathBmp As String
    Public Pathrep As String
    Public Username As String
    Public UserPath As String
    Public FechaPas As Date
    Public ChequePas As Short
    Public EsBis As Boolean
    Public Dressactual As String
    Public PmodHoja As New VB6.FixedLengthString(1)
    Public Remoto As New VB6.FixedLengthString(1)
    Public Entro As Boolean
    Public cadDer As New VB6.FixedLengthString(250)
    Public nOperador As String
    Public sFechaIni As String
    Public sFechaFin As String
    Public cons_bitacora As Object
    Public cons_incidente As Short
    Public cons_fecha As String

    Public Forma, FormaAbc As Object
    Public FormaPrin As Object
    Public Accion As String
    Public tiporep As Short


    Function FEnter(ByRef KeyAscii As Short) As Object
        If KeyAscii = 13 Then
            System.Windows.Forms.SendKeys.Send("{Tab}")
        End If
    End Function

    Function ConFecha(ByRef MiFecha As Date) As String

        ConFecha = VB6.Format(MiFecha, "yyyymmdd")
    End Function
	
	Public Sub ImpoMaehf(ByRef Archivo As String)
		Dim nada As Object
		Dim HF_FECPEDIM As Object
		Dim MousePointer As Object
		Dim MiHf As Object
		Dim fecha As Object
		Dim strbuffer As String
		Dim FileHandle As Short
		Dim cad2 As String
		Dim ComanGraba As New ADODB.Command
		Dim RegComan As New ADODB.Recordset
		Dim CadHf As String
		Dim nuevo As Object
		Dim NuevPar As Boolean

        Dim HF_NumGpo, HF_CteFac, Hf_Numehf, hf_Cteped, HF_cvepro, HF_NUMPRO As Object
        Dim hf_Nompro As String
        Dim HF_CANBUL As Object
        Dim HF_PESOLB As String
        Dim HF_CVELIN, HF_CLASE, HF_LOCMER, HF_NOMLIN As Object
        Dim HF_NTALON As String
        Dim HF_OBSER1, HF_DESME1, HF_ATENCI As Object
        Dim HF_CERRAD As String
        Dim HF_FCRUC, HF_FHOJA, HF_FECEXP, HF_FECENT, HF_AVISO, HF_FECREG, HF_FECTXT As Object
        Dim HF_FECARRMCIA As String
        Dim HF_NUMPED, HF_HORA, HF_NUMREF, HF_NUMADUA As Object
        Dim HF_T_PROM As String
        Dim HF_FLETEUS, HF_CAUSA1, HF_IMPEXP, HF_FOB As Object
        Dim HF_CHEQUE As String
        Dim HF_NUMREC, HF_BANCO, HF_REVISO, HF_NOMREC As Object
        Dim HF_VEHICULO As String
        Dim HF_VEICULO, HF_CVEORI, HF_NUMUSR, HF_NOMUSR, HF_CVEDEST, HF_PLAZUE As Object
        Dim HF_TPROM As String
        Dim HF_NUMERO, HF_NUMREL, HF_EQUIM, HF_SELLOS, HF_TLS, HF_MARCAS, HF_NUMREV As Object
        Dim HF_NOMF As String
        Dim HF_NCAJA, HF_FEMUSR, HF_TIMREG, HF_COMENT, HF_HORATXT As Object
        Dim HF_CVELOC As String
        Dim Hf_Regimen, HF_NUMFAC, Hf_Equiv, Hf_Dta As Object
        Dim Hf_Multiplica As String
        Dim HF_TLC As String





		Dim Aux_fecFac, Aux_orden, aux_hf, Aux_TipoDoc, Aux_fact, Aux_Valc As Object
		Dim Aux_valS As String
		Dim Aux_valFac, Aux_TipMon, Aux_ValF, Aux_OtrGto, Aux_NumOrig As Object
		Dim Aux_NumCopia As String

        Dim H_Descrip, H_NumHf, H_Importe As Object
        Dim H_Fecha As String

		Dim Ate_pro, Dom_pro, Cve_pro, Nom_Pro, Tel_pro, Mail_pro As Object
		Dim Ciu_pro As String

        Dim F_NSeries, F_Descrip, F_CantR, F_Orden, F_CantF, F_CantD, F_Fraccion, F_Refacion As Object
        Dim F_NModelo As String
        Dim F_Valor, F_Peso, F_Tipo, F_Materia, F_Medida, F_CveTip, F_Adv, F_Unidad, F_Permiso As Object
        Dim F_Numeros As String
        Dim F_Numero2, F_Cve3, F_Cve1, F_PrecUni, F_Tlc, F_Cveorig, F_Cve2, F_Numero1, F_Numero3 As Object
        Dim F_Firma1 As String
        Dim F_Firma2, F_Firma3 As Object
        Dim F_Pendiente As String

		Dim Hf_FecRep, Hf_CveCli, Hf_Inv, hf_Fecsal As Object
		Dim Hf_Timesal As String
		Dim hf_Bultos, Hf_Numtran, hf_FeCruc, hf_TimCruc, Hf_ResRel, hf_Caja, hf_Obser As Object
		Dim hf_control As String
		Dim hf_Destino, hf_NomMex, hf_linmex, hf_ImpTos, hf_Talon, hf_Unidades As Object
		Dim hf_TipoTransp As String

        Dim Hf_tipo As Object
        Dim hf_Numreco As String


        ComanGraba = New ADODB.Command
        ComanGraba.let_ActiveConnection(Miconex)
        ComanGraba.CommandType = ADODB.CommandTypeEnum.adCmdText

		CadHf = "Insert into Maehf (hf_Numehf,HF_CtePed,HF_CteFac,HF_NumGpo,HF_cvepro,hf_nompro,HF_FECENT,HF_CANBUL,"
		CadHf = CadHf & "HF_CLASE,HF_LOCMER,HF_CVELIN,HF_NOMLIN,HF_NTALON,HF_PESOLB,HF_DESME1,"
		CadHf = CadHf & "HF_OBSER1, HF_ATENCI, HF_CERRAD, HF_FECARRMCIA, HF_HORA, HF_NUMREF, HF_NUMPED, HF_NUMADUA,"
		CadHf = CadHf & "HF_TPROM,HF_CAUSA1,HF_IMPEXP,HF_FLETEUS,HF_FOB,HF_CHEQUE,HF_BANCO,HF_FECEXP,"
		CadHf = CadHf & "HF_AVISO,HF_REVISO,HF_NUMREC,HF_NOMREC,HF_NUMUSR,HF_NOMUSR,HF_CVEORI,HF_CVEDEST,HF_VEHICULO,"
		CadHf = CadHf & "HF_PLAZUE,HF_SELLOS,HF_FHOJA,HF_EQUIM,HF_TLS,HF_NUMREL,HF_MARCAS,HF_NUMERO,"
		CadHf = CadHf & "HF_NUMREV,HF_NOMF,HF_FECREG,HF_TIMREG,HF_FEMUSR,HF_COMENT,HF_FCRUc,HF_NCAJA,HF_FECTXT,HF_HORATXT,HF_NUMFAC,HF_CVELOC,"
		CadHf = CadHf & "Hf_Equiv,Hf_Regimen,Hf_Dta,Hf_Multiplica,HF_Tlc)"
		CadHf = CadHf & " Values ("

        nuevo = True
        NuevPar = True

		MiHf = ""
		


		FileHandle = FreeFile

        FileOpen(FileHandle, Archivo, OpenMode.Input)


        MousePointer = System.Windows.Forms.Cursors.WaitCursor

		
        Do While Not EOF(FileHandle)


            strbuffer = LineInput(FileHandle)
            strbuffer = Replace(strbuffer, "'", " ")
            strbuffer = Replace(strbuffer, Chr(34), " ")
            If VarTmp = "Arribo" Then 'Se seleciono Entrada de Mercancias

                Select Case Mid(strbuffer, 1, 1)
                    Case "A"

                        Hf_Numehf = Mid(strbuffer, 2, 8)

                        hf_Cteped = Mid(strbuffer, 10, 4)

                        HF_CteFac = Mid(strbuffer, 14, 4)

                        HF_NumGpo = Mid(strbuffer, 18, 4)

                        HF_NUMPRO = Mid(strbuffer, 22, 4)
                        hf_Nompro = Mid(strbuffer, 26, 40)

                        HF_FECENT = Space(10)
                        If Trim(Mid(strbuffer, 66, 10)) <> "" Then

                            HF_FECENT = ConFecha(CDate(Mid(strbuffer, 66, 10)))
                        End If

                        HF_CANBUL = Val(Mid(strbuffer, 76, 5))

                        HF_CLASE = Mid(strbuffer, 81, 4)

                        HF_LOCMER = Mid(strbuffer, 85, 20)

                        HF_CVELIN = Mid(strbuffer, 105, 4)

                        HF_NOMLIN = Mid(strbuffer, 109, 40)
                        HF_NTALON = Mid(strbuffer, 149, 20)
                        HF_PESOLB = CStr(Val(Mid(strbuffer, 169, 15)))

                        HF_DESME1 = Mid(strbuffer, 184)

                        nuevo = True
                        NuevPar = True


                        MiHf = Hf_Numehf
                    Case "B"

                        HF_OBSER1 = Mid(strbuffer, 10, 80)

                        HF_ATENCI = Mid(strbuffer, 90, 30)
                        HF_CERRAD = Mid(strbuffer, 120, 1)
                        HF_FECARRMCIA = Space(10)
                        If Trim(Mid(strbuffer, 121, 10)) <> "" Then
                            HF_FECARRMCIA = ConFecha(CDate(Mid(strbuffer, 121, 10)))
                        End If

                        HF_HORA = Mid(strbuffer, 131, 5)

                        HF_NUMREF = Mid(strbuffer, 136, 10)

                        HF_NUMPED = Mid(strbuffer, 146, 7)

                        HF_NUMADUA = Mid(strbuffer, 153, 4)
                        HF_T_PROM = Mid(strbuffer, 157, 15)

                        HF_CAUSA1 = Mid(strbuffer, 172)
                    Case "C"

                        HF_IMPEXP = Mid(strbuffer, 10, 1)

                        HF_FLETEUS = Val(Mid(strbuffer, 11, 15))

                        HF_FOB = Mid(strbuffer, 26, 1)
                        HF_CHEQUE = CStr(Val(Mid(strbuffer, 27, 9)))

                        HF_BANCO = Mid(strbuffer, 36, 20)

                        HF_FECEXP = Space(10)
                        If Trim(Mid(strbuffer, 56, 10)) <> "" Then

                            HF_FECEXP = ConFecha(CDate(Mid(strbuffer, 56, 10)))
                        End If

                        HF_AVISO = Space(10)
                        If Trim(Mid(strbuffer, 66, 10)) <> "" Then

                            HF_AVISO = ConFecha(CDate(Mid(strbuffer, 66, 10)))
                        End If

                        HF_REVISO = Mid(strbuffer, 76, 20)

                        HF_NUMREC = Mid(strbuffer, 96, 7)

                        HF_NOMREC = Mid(strbuffer, 103, 20)

                        HF_NUMUSR = Mid(strbuffer, 123, 7)

                        HF_NOMUSR = Mid(strbuffer, 130, 20)

                        HF_CVEORI = Mid(strbuffer, 150, 4)

                        HF_CVEDEST = Mid(strbuffer, 154, 4)

                        HF_VEICULO = Mid(strbuffer, 158, 20)

                        HF_NUMFAC = Val(Mid(strbuffer, 178, 2))
                        HF_CVELOC = Mid(strbuffer, 180, 2)

                    Case "D"

                        HF_PLAZUE = Mid(strbuffer, 10, 1)

                        HF_SELLOS = Mid(strbuffer, 11, 25)

                        HF_FHOJA = Space(10)
                        If Trim(Mid(strbuffer, 36, 10)) <> "" Then

                            HF_FHOJA = ConFecha(CDate(Mid(strbuffer, 36, 10)))
                        End If

                        HF_EQUIM = Val(Mid(strbuffer, 46, 11))

                        HF_TLS = Mid(strbuffer, 57, 1)

                        HF_NUMREL = Mid(strbuffer, 58, 7)

                        HF_MARCAS = Mid(strbuffer, 65, 11)

                        HF_NUMERO = Mid(strbuffer, 76, 7)

                        HF_NUMREV = Mid(strbuffer, 83, 7)
                        HF_NOMF = Mid(strbuffer, 90, 12)

                        HF_FECREG = Space(10)
                        If Trim(Mid(strbuffer, 102, 10)) <> "" Then

                            HF_FECREG = ConFecha(CDate(Mid(strbuffer, 102, 10)))
                        End If

                        HF_TIMREG = Mid(strbuffer, 112, 5)

                        HF_FEMUSR = Mid(strbuffer, 117, 2)

                        HF_COMENT = Mid(strbuffer, 119, 40)

                        HF_FCRUC = Space(10)
                        If Trim(Mid(strbuffer, 159, 10)) <> "" Then

                            HF_FCRUC = ConFecha(CDate(Mid(strbuffer, 159, 10)))
                        End If

                        HF_NCAJA = Mid(strbuffer, 169, 15)

                        HF_FECTXT = Space(10)
                        If Trim(Mid(strbuffer, 184, 10)) <> "" Then

                            HF_FECTXT = ConFecha(CDate(Mid(strbuffer, 184, 10)))
                        End If

                        HF_HORATXT = Mid(strbuffer, 194, 5)

                        Hf_Equiv = Val(Mid(strbuffer, 199, 8))

                        Hf_Regimen = Mid(strbuffer, 207, 2)

                        Hf_Dta = Val(Mid(strbuffer, 209, 9))
                        Hf_Multiplica = Mid(strbuffer, 218, 1)
                        HF_TLC = Mid(strbuffer, 219, 1)



                        ComanGraba.CommandText = "select hf_Numehf from maehf where hf_Numehf='" & Hf_Numehf & Chr(39)
                        RegComan = ComanGraba.Execute
                        If RegComan.EOF Then








                            cad2 = "'" & Hf_Numehf & "','" & hf_Cteped & "','" & HF_CteFac & "','" & HF_NumGpo & "','" & HF_NUMPRO & "','" & hf_Nompro & "','" & HF_FECENT & "','" & HF_CANBUL





                            cad2 = cad2 & "','" & HF_CLASE & "','" & HF_LOCMER & "','" & HF_CVELIN & "','" & HF_NOMLIN & "','" & HF_NTALON & "','" & HF_PESOLB & "','" & HF_DESME1






                            cad2 = cad2 & "','" & HF_OBSER1 & "','" & HF_ATENCI & "','" & HF_CERRAD & "','" & HF_FECARRMCIA & "','" & HF_HORA & "','" & HF_NUMREF & "','" & HF_NUMPED & "','" & HF_NUMADUA






                            cad2 = cad2 & "','" & HF_TPROM & "','" & HF_CAUSA1 & "','" & HF_IMPEXP & "','" & HF_FLETEUS & "','" & HF_FOB & "','" & HF_CHEQUE & "','" & HF_BANCO & "','" & HF_FECEXP








                            cad2 = cad2 & "','" & HF_AVISO & "','" & HF_REVISO & "','" & HF_NUMREC & "','" & HF_NOMREC & "','" & HF_NUMUSR & "','" & HF_NOMUSR & "','" & HF_CVEORI & "','" & HF_CVEDEST & "','" & HF_VEHICULO








                            cad2 = cad2 & "','" & HF_PLAZUE & "','" & HF_SELLOS & "','" & HF_FHOJA & "','" & HF_EQUIM & "','" & HF_TLS & "','" & HF_NUMREL & "','" & HF_MARCAS & "','" & HF_NUMERO










                            cad2 = cad2 & "','" & HF_NUMREV & "','" & HF_NOMF & "','" & HF_FECREG & "','" & HF_TIMREG & "','" & HF_FEMUSR & "','" & HF_COMENT & "','" & HF_FCRUC & "','" & HF_NCAJA & "','" & HF_FECTXT & "','" & HF_HORATXT & "','" & HF_NUMFAC & "','" & HF_CVELOC



                            cad2 = cad2 & "','" & Hf_Equiv & "','" & Hf_Regimen & "','" & Hf_Dta & "','" & Hf_Multiplica & "','" & HF_TLC & "')"
                            ComanGraba.CommandText = CadHf & cad2
                        Else







                            cad2 = "update maehf set HF_CtePed ='" & hf_Cteped & "',HF_CteFac='" & HF_CteFac & "',HF_NumGpo='" & HF_NumGpo & "',HF_cvepro='" & HF_NUMPRO & "',Hf_Nompro='" & hf_Nompro & "',HF_FECENT='" & HF_FECENT & "',HF_CANBUL='" & HF_CANBUL & Chr(39)





                            cad2 = cad2 & ",HF_CLASE='" & HF_CLASE & "',HF_LOCMER='" & HF_LOCMER & "',HF_CVELIN='" & HF_CVELIN & "',HF_NOMLIN='" & HF_NOMLIN & "',HF_NTALON='" & HF_NTALON & "',HF_PESOLB='" & HF_PESOLB & "',HF_DESME1='" & HF_DESME1 & Chr(39)






                            cad2 = cad2 & ",HF_OBSER1='" & HF_OBSER1 & "',HF_ATENCI='" & HF_ATENCI & "',HF_CERRAD='" & HF_CERRAD & "',HF_FECARRMCIA='" & HF_FECARRMCIA & "',HF_HORA='" & HF_HORA & "',HF_NUMREF='" & HF_NUMREF & "',HF_NUMPED='" & HF_NUMPED & "',HF_NUMADUA='" & HF_NUMADUA & Chr(39)






                            cad2 = cad2 & ",HF_TPROM='" & HF_TPROM & "',HF_CAUSA1='" & HF_CAUSA1 & "',HF_IMPEXP='" & HF_IMPEXP & "',HF_FLETEUS='" & HF_FLETEUS & "',HF_FOB='" & HF_FOB & "',HF_CHEQUE='" & HF_CHEQUE & "',HF_BANCO='" & HF_BANCO & "',HF_FECEXP='" & HF_FECEXP & Chr(39)








                            cad2 = cad2 & ",HF_AVISO='" & HF_AVISO & "',HF_REVISO='" & HF_REVISO & "',HF_NUMREC='" & HF_NUMREC & "',HF_NOMREC='" & HF_NOMREC & "',HF_NUMUSR='" & HF_NUMUSR & "',HF_NOMUSR='" & HF_NOMUSR & "',HF_CVEORI='" & HF_CVEORI & "',HF_CVEDEST='" & HF_CVEDEST & "',HF_VEHICULO ='" & HF_VEHICULO & Chr(39)








                            cad2 = cad2 & ",HF_PLAZUE='" & HF_PLAZUE & "',HF_SELLOS='" & HF_SELLOS & "',HF_FHOJA='" & HF_FHOJA & "',HF_EQUIM='" & HF_EQUIM & "',HF_TLS='" & HF_TLS & "',HF_NUMREL='" & HF_NUMREL & "',HF_MARCAS='" & HF_MARCAS & "',HF_NUMERO='" & HF_NUMERO & Chr(39)










                            cad2 = cad2 & ",HF_NUMREV='" & HF_NUMREV & "',HF_NOMF='" & HF_NOMF & "',HF_FECREG='" & HF_FECREG & "',HF_TIMREG='" & HF_TIMREG & "',HF_FEMUSR='" & HF_FEMUSR & "',HF_COMENT='" & HF_COMENT & "',HF_FCRUC='" & HF_FCRUC & "',HF_NCAJA='" & HF_NCAJA & "',HF_FECTXT='" & HF_FECTXT & "',HF_HORATXT='" & HF_HORATXT & "',HF_NUMFAC='" & HF_NUMFAC & "',HF_CVELOC='" & HF_CVELOC & Chr(39)



                            cad2 = cad2 & ",Hf_Equiv='" & Hf_Equiv & "',Hf_Regimen='" & Hf_Regimen & "',Hf_Dta='" & Hf_Dta & "',Hf_Multiplica='" & Hf_Multiplica & "',Hf_Tlc ='" & HF_TLC & Chr(39)

                            cad2 = cad2 & " where hf_Numehf ='" & Hf_Numehf & Chr(39)
                            ComanGraba.CommandText = cad2
                        End If
                        ComanGraba.Execute()
                    Case "P"
                        If NuevPar Then


                            ComanGraba.CommandText = "Delete from Fileprod where f_NumHf='" & Hf_Numehf & Chr(39)
                            RegComan = ComanGraba.Execute
                            NuevPar = False
                        End If

                        F_Orden = Mid(strbuffer, 10, 20)

                        F_CantF = Val(Mid(strbuffer, 30, 9))

                        F_CantR = Val(Mid(strbuffer, 39, 9))

                        F_CantD = Val(Mid(strbuffer, 48, 9))

                        F_Descrip = Mid(strbuffer, 57, 135)

                        F_Fraccion = Mid(strbuffer, 192, 8)

                        F_NSeries = Mid(strbuffer, 200, 10)

                        F_Refacion = Mid(strbuffer, 210, 40)
                        F_NModelo = Mid(strbuffer, 250, 10)

                        F_Medida = Mid(strbuffer, 260, 20)

                        F_Materia = Mid(strbuffer, 280, 10)

                        F_CveTip = Mid(strbuffer, 290, 4)

                        F_Tipo = Mid(strbuffer, 294, 4)

                        F_Adv = Val(Mid(strbuffer, 298, 9))

                        F_Peso = Val(Mid(strbuffer, 307, 9))

                        F_Unidad = Mid(strbuffer, 316, 4)

                        F_Valor = Val(Mid(strbuffer, 320, 9))

                        F_Permiso = Mid(strbuffer, 329, 10)
                        F_Numeros = Mid(strbuffer, 339, 10)

                        F_Tlc = Mid(strbuffer, 349, 1)

                        F_PrecUni = Val(Mid(strbuffer, 350, 9))

                        F_Cveorig = Mid(strbuffer, 359, 4)

                        F_Cve1 = Mid(strbuffer, 363, 3)

                        F_Cve2 = Mid(strbuffer, 366, 3)

                        F_Cve3 = Mid(strbuffer, 369, 3)

                        F_Numero1 = Mid(strbuffer, 372, 7)

                        F_Numero2 = Mid(strbuffer, 379, 7)

                        F_Numero3 = Mid(strbuffer, 386, 7)
                        F_Firma1 = Mid(strbuffer, 393, 8)

                        F_Firma2 = Mid(strbuffer, 401, 8)

                        F_Firma3 = Mid(strbuffer, 409, 8)
                        F_Pendiente = CStr(Val(Mid(strbuffer, 417, 9)))


                        cad2 = "insert into Fileprod (F_NumHf,F_Orden, F_CantF, F_CantR, F_CantD, F_Descrip, F_Fraccion, F_NSeries, F_Refacion, F_NModelo," & "F_Medida , F_Materia, F_CveTip, F_Tipo, F_Adv, F_Peso, F_Unidad, F_Valor, F_Permiso, F_Numeros," & "F_Tlc , F_PrecUni, F_Cveorig, F_Cve1, F_Cve2, F_Cve3, F_Numero1, F_Numero2, F_Numero3, F_Firma1," & "F_Firma2 , F_Firma3, F_Pendiente) Values "





























                        cad2 = cad2 & "('" & Hf_Numehf & " ','" & F_Orden & "','" & F_CantF & "','" & F_CantR & "','" & F_CantD & "','" & F_Descrip & "','" & F_Fraccion & "','" & F_NSeries & "','" & F_Refacion & "','" & F_NModelo & "','" & F_Medida & "','" & F_Materia & "','" & F_CveTip & "','" & F_Tipo & "','" & F_Adv & "','" & F_Peso & "','" & F_Unidad & "','" & F_Valor & "','" & F_Permiso & "','" & F_Numeros & "','" & F_Tlc & "','" & F_PrecUni & "','" & F_Cveorig & "','" & F_Cve1 & "','" & F_Cve2 & "','" & F_Cve3 & "','" & F_Numero1 & "','" & F_Numero2 & "','" & F_Numero3 & "','" & F_Firma1 & "','" & F_Firma2 & "','" & F_Firma3 & "','" & F_Pendiente & "')"
                        ComanGraba.CommandText = cad2
                        ComanGraba.Execute()
                    Case "F"

                        aux_hf = Mid(strbuffer, 2, 8)

                        Aux_TipoDoc = Mid(strbuffer, 10, 4)

                        Aux_orden = Mid(strbuffer, 14, 10)

                        Aux_fact = Mid(strbuffer, 24, 30)

                        Aux_fecFac = Space(10)
                        If Trim(Mid(strbuffer, 54, 10)) <> "" Then

                            Aux_fecFac = ConFecha(CDate(Mid(strbuffer, 54, 10)))
                        End If

                        Aux_Valc = Val(Mid(strbuffer, 64, 9))
                        Aux_valS = CStr(Val(Mid(strbuffer, 73, 9)))

                        Aux_ValF = Val(Mid(strbuffer, 82, 9))

                        Aux_TipMon = Mid(strbuffer, 91, 4)

                        Aux_OtrGto = Val(Mid(strbuffer, 95, 9))

                        Aux_valFac = Val(Mid(strbuffer, 104, 9))

                        Aux_NumOrig = Val(Mid(strbuffer, 113, 9))
                        Aux_NumCopia = CStr(Val(Mid(strbuffer, 122, 9)))


                        If nuevo Then


                            ComanGraba.CommandText = "Delete from AuxOrd where aux_hf='" & Hf_Numehf & Chr(39)
                            RegComan = ComanGraba.Execute

                            ComanGraba.CommandText = "Delete from Filegas where H_Numhf='" & Hf_Numehf & Chr(39)
                            RegComan = ComanGraba.Execute

                            nuevo = False
                        End If

                        cad2 = "Insert into AuxOrd (Aux_Hf,Aux_TipoDoc,Aux_orden,Aux_Fact,Aux_fecfac,Aux_valc,Aux_ValS,Aux_ValF,Aux_TipMon,Aux_otrGto,Aux_valFac,Aux_NumOrig,Aux_NumCopia) values "






                        cad2 = cad2 & "('" & aux_hf & "','" & Aux_TipoDoc & "','" & Aux_orden & "','" & Aux_fact & "','" & Aux_fecFac & "','" & Aux_Valc





                        cad2 = cad2 & "','" & Aux_valS & "','" & Aux_ValF & "','" & Aux_TipMon & "','" & Aux_OtrGto & "','" & Aux_valFac & "','" & Aux_NumOrig & "','" & Aux_NumCopia & "')"
                        ComanGraba.CommandText = cad2
                        ComanGraba.Execute()
                    Case "O"

                        H_NumHf = Mid(strbuffer, 2, 8)

                        H_Descrip = Mid(strbuffer, 10, 40)

                        H_Importe = Val(Mid(strbuffer, 50, 9))
                        H_Fecha = Space(10)
                        If Trim(Mid(strbuffer, 59, 10)) <> "" Then
                            H_Fecha = ConFecha(CDate(Mid(strbuffer, 59, 10)))
                        End If

                        If nuevo Then


                            ComanGraba.CommandText = "Delete from Filegas where H_Numhf='" & Hf_Numehf & Chr(39)
                            RegComan = ComanGraba.Execute

                            nuevo = False
                        End If





                        cad2 = "Insert into Filegas (H_NumHf,H_descrip,H_Importe,H_fecha) values ('" & H_NumHf & "','" & H_Descrip & "','" & H_Importe & "','" & H_Fecha & "')"
                        ComanGraba.CommandText = cad2
                        ComanGraba.Execute()
                    Case "W"

                        Cve_pro = Mid(strbuffer, 2, 4)

                        Nom_Pro = Mid(strbuffer, 6, 35)

                        Nom_Pro = Replace(Nom_Pro, "'", " ")

                        Dom_pro = Mid(strbuffer, 41, 35)

                        Dom_pro = Replace(Dom_pro, "'", " ")

                        Tel_pro = Mid(strbuffer, 76, 10)

                        Ate_pro = Mid(strbuffer, 86, 20)

                        Mail_pro = Mid(strbuffer, 106, 30)
                        Ciu_pro = Mid(strbuffer, 136, 4)

                        ComanGraba.CommandText = "Select * from Proveedor where cve_pro = '" & Cve_pro & Chr(39)
                        RegComan = ComanGraba.Execute
                        If RegComan.EOF Then







                            cad2 = "Insert Into Proveedor (Cve_pro,Nom_pro,Dom_pro,Tel_pro,Ate_pro,Mail_pro,Ciu_pro) values ('" & Cve_pro & "','" & Nom_Pro & "','" & Dom_pro & "','" & Tel_pro & "','" & Ate_pro & "','" & Mail_pro & "','" & Ciu_pro & "')"
                            ComanGraba.CommandText = cad2
                            ComanGraba.Execute()
                        End If
                End Select
            Else
                Select Case Mid(strbuffer, 1, 1)
                    Case "A"

                        Hf_Numehf = Mid(strbuffer, 2, 8)

                        HF_NUMREF = Mid(strbuffer, 10, 10)

                        HF_NUMPED = Mid(strbuffer, 20, 7)

                        Hf_CveCli = Mid(strbuffer, 27, 4)

                        HF_cvepro = Mid(strbuffer, 31, 4)

                        Hf_Inv = Mid(strbuffer, 35, 30)

                        Hf_FecRep = Space(10)
                        If Trim(Mid(strbuffer, 65, 10)) <> "" Then

                            Hf_FecRep = ConFecha(CDate(Mid(strbuffer, 65, 10)))
                        End If

                        hf_Fecsal = Space(10)
                        If Trim(Mid(strbuffer, 75, 10)) <> "" Then

                            hf_Fecsal = ConFecha(CDate(Mid(strbuffer, 75, 10)))
                        End If
                        Hf_Timesal = Mid(strbuffer, 85, 5)

                        hf_TimCruc = Mid(strbuffer, 90, 5)


                        hf_FeCruc = Space(10)
                        If Trim(Mid(strbuffer, 95, 10)) <> "" Then

                            hf_FeCruc = ConFecha(CDate(Mid(strbuffer, 95, 10)))
                        End If

                        Hf_ResRel = Mid(strbuffer, 105, 10)

                        Hf_Numtran = Mid(strbuffer, 115, 4)

                        hf_Caja = Mid(strbuffer, 119, 30)

                        hf_Bultos = Mid(strbuffer, 149, 45)

                        hf_Obser = Mid(strbuffer, 194, 70)
                        hf_control = Mid(strbuffer, 264, 20)

                        HF_NUMUSR = Mid(strbuffer, 284, 7)

                        hf_linmex = Mid(strbuffer, 291, 4)
                    Case "B"

                        hf_ImpTos = Val(Mid(strbuffer, 2, 9))

                        HF_FECREG = Space(10)
                        If Trim(Mid(strbuffer, 11, 10)) <> "" Then

                            HF_FECREG = ConFecha(CDate(Mid(strbuffer, 11, 10)))
                        End If

                        HF_TIMREG = Mid(strbuffer, 21, 5)

                        HF_NOMLIN = Mid(strbuffer, 26, 40)

                        hf_NomMex = Mid(strbuffer, 66, 40)

                        hf_Talon = Mid(strbuffer, 106, 15)

                        hf_Destino = Mid(strbuffer, 121, 25)

                        hf_Unidades = Val(Mid(strbuffer, 146, 5))
                        hf_TipoTransp = Mid(strbuffer, 151, 4)

                        HF_FEMUSR = Mid(strbuffer, 155, 2)
                        If Trim(Mid(strbuffer, 157, 10)) <> "" Then

                            HF_FECPEDIM = ConFecha(CDate(Mid(strbuffer, 157, 10)))
                        End If


                        ComanGraba.CommandText = "Delete from Maeout where Hf_NumeHf='" & Hf_Numehf & Chr(39)
                        RegComan = ComanGraba.Execute

                        cad2 = "Insert into Maeout (Hf_Numehf,HF_NUMREF,HF_NUMPED,Hf_CveCli,HF_cvepro,Hf_Inv,Hf_FecRep,hf_Fecsal,Hf_Timesal," & "hf_TimCruc , hf_FeCruc, Hf_ResSel, Hf_Numtran, hf_Caja, hf_Bultos, hf_Obser, hf_control, HF_NUMUSR," & "hf_linmex , hf_ImpTos, HF_FECREG, HF_TIMREG, HF_NOMLIN, hf_NomMex, hf_Talon, hf_Destino, hf_Unidades," & "hf_TipoTransp , HF_FEMUSR,HF_FECPEDIM) Values "



























                        cad2 = cad2 & "('" & Hf_Numehf & " ','" & HF_NUMREF & " ','" & HF_NUMPED & " ','" & Hf_CveCli & " ','" & HF_cvepro & " ','" & Hf_Inv & " ','" & Hf_FecRep & " ','" & hf_Fecsal & " ','" & Hf_Timesal & "','" & hf_TimCruc & " ','" & hf_FeCruc & " ','" & Hf_ResRel & " ','" & Hf_Numtran & " ','" & hf_Caja & " ','" & hf_Bultos & " ','" & hf_Obser & " ','" & hf_control & " ','" & HF_NUMUSR & "','" & hf_linmex & " ','" & hf_ImpTos & " ','" & HF_FECREG & " ','" & HF_TIMREG & " ','" & HF_NOMLIN & " ','" & hf_NomMex & " ','" & hf_Talon & " ','" & hf_Destino & " ','" & hf_Unidades & "','" & hf_TipoTransp & "','" & HF_FEMUSR & "','" & HF_FECPEDIM & "')"
                        ComanGraba.CommandText = cad2
                        ComanGraba.Execute()


                        ComanGraba.CommandText = "Delete from maereco where hf_Numehf='" & Hf_Numehf & Chr(39)
                        RegComan = ComanGraba.Execute
                    Case "W"

                        Hf_Numehf = Mid(strbuffer, 2, 8)

                        Hf_tipo = Mid(strbuffer, 10, 10)

                        HF_HORA = Mid(strbuffer, 20, 5)
                        hf_Numreco = Mid(strbuffer, 25, 5)



                        cad2 = "Insert into MaeReco (hf_numehf,hf_tipo,hf_hora,Hf_Numreco) Values ('" & Hf_Numehf & "','" & Hf_tipo & "','" & HF_HORA & "','" & hf_Numreco & "')"
                        ComanGraba.CommandText = cad2
                        RegComan = ComanGraba.Execute
                End Select
            End If
        Loop


		MousePointer = System.Windows.Forms.Cursors.Default

        FileClose(FileHandle)

		nada = MsgBox("Proceso Efectuado satisfactoriamente ", MsgBoxStyle.OKOnly)
		Exit Sub


	End Sub
	





	Public Sub Conecta()
        Miconex = New ADODB.Connection






        With Miconex




            .ConnectionString = "Provider=SQLOLEDB.1;Password=sa;Persist Security Info=True;User ID=sa;Initial Catalog=ProduccionInterfletdb;Data Source=ARCHIVOS"
            .Open()
        End With
    End Sub

    Public Sub Conecta_prueba()
        Miconexprueba = New ADODB.Connection

        With Miconexprueba
            .Provider = "SQLOLEDB"


            .ConnectionString = "Server=ARCHIVOS;Database=ProduccionInterfletDB;Trusted_Connection=Yes;Initial Catalog=ProduccionInterfletDB"
            .Open()
        End With
    End Sub






	Function lee_archivo_ini(ByRef FILE_INI As String) As Object
		Dim var_server As String
		Dim var_user_id As String
		Dim var_password As String
		Dim var_initial_catalog As String
		
		Dim ban_fin As Boolean
		Dim car As Object
		Dim cadena As String
		
		FileOpen(1, FILE_INI, OpenMode.Input)
		cadena = ""
		Remoto.Value = "0"
		
		While Not EOF(1)
			ban_fin = False

            car = InputString(1, 1)

			If (car = vbCr) Then
				ban_fin = True
			End If

            If (car = vbLf) Then
                ban_fin = True
            End If
            If Not ban_fin Then

                cadena = cadena + car
            End If

            If car = ";" Or car = "]" Then
                If Len(cadena) > 6 Then
                    If UCase(Mid(cadena, 1, 6)) = "SERVER" Then
                        var_server = Mid(cadena, 8, Len(cadena) - 8)
                    End If
                End If

                If Len(cadena) > 7 Then
                    If UCase(Mid(cadena, 1, 7)) = "USER_ID" Then
                        var_user_id = Mid(cadena, 9, Len(cadena) - 9)
                    End If
                End If

                If Len(cadena) > 8 Then
                    If UCase(Mid(cadena, 1, 8)) = "PASSWORD" Then
                        var_password = Mid(cadena, 10, Len(cadena) - 10)
                    End If
                End If

                If Len(cadena) > 15 Then
                    If UCase(Mid(cadena, 1, 15)) = "INITIAL_CATALOG" Then
                        var_initial_catalog = Mid(cadena, 17, Len(cadena) - 17)
                    End If
                End If




                If UCase(Mid(cadena, 1, 8)) = "RUTABMPS" Then
                    PathBmp = Mid(cadena, 10, Len(cadena) - 10)
                End If
                If UCase(Mid(cadena, 1, 7)) = "RUTARPT" Then
                    Pathrep = Mid(cadena, 9, Len(cadena) - 9)
                End If
                If UCase(Mid(cadena, 1, 6)) = "REMOTO" Then
                    Remoto.Value = Mid(cadena, 8, Len(cadena) - 8)
                End If

                cadena = ""
            End If
		End While
		

        lee_archivo_ini = "Data Source=" & var_server & ";" & "User ID=" & var_user_id & ";" & "Password=" & var_password & ";" & "Initial Catalog=" & var_initial_catalog


        FileClose(1)
    End Function

    Function FNum(ByRef NUMERO As Double) As Object

        FNum = Space(15 - Len(VB6.Format(NUMERO, "###,##0.00"))) & VB6.Format(NUMERO, "###,##0.00")
    End Function
	
	Function FNum2(ByRef NUMERO As Double) As Object

        FNum2 = Space(3 - Len(VB6.Format(NUMERO, "###"))) & VB6.Format(NUMERO, "###")
    End Function







	Function SACAINI(ByRef FILE_INI As String) As Object
		Dim var_server As String
		Dim var_user_id As String
		Dim var_password As String
		Dim var_initial_catalog As String
		Dim cadena As String
		
		FileOpen(1, FILE_INI, OpenMode.Input)
		
		cadena = ""
		Remoto.Value = "0"
		
		While Not EOF(1)
			cadena = LineInput(1)
			
			If UCase(Mid(cadena, 1, 6)) = "SERVER" Then
				var_server = Mid(cadena, 8, Len(cadena) - 8)
			Else
				If UCase(Mid(cadena, 1, 7)) = "USER_ID" Then
					var_user_id = Mid(cadena, 9, Len(cadena) - 9)
				Else
					If UCase(Mid(cadena, 1, 8)) = "PASSWORD" Then
						var_password = Mid(cadena, 10, Len(cadena) - 10)
					Else
						If UCase(Mid(cadena, 1, 15)) = "INITIAL_CATALOG" Then
							var_initial_catalog = Mid(cadena, 17, Len(cadena) - 17)
						Else



                            If UCase(Mid(cadena, 1, 8)) = "RUTABMPS" Then
                                PathBmp = Mid(cadena, 10, Len(cadena) - 10)
                            Else
                                If UCase(Mid(cadena, 1, 7)) = "RUTARPT" Then
                                    Pathrep = Mid(cadena, 9, Len(cadena) - 9)
                                Else
                                    If UCase(Mid(cadena, 1, 6)) = "REMOTO" Then
                                        Remoto.Value = Mid(cadena, 8, Len(cadena) - 8)
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End While


        SACAINI = "Data Source=" & var_server & ";" & "User ID=" & var_user_id & ";" & "Password=" & Trim(var_password) & ";" & "Initial Catalog=" & var_initial_catalog
        FileClose(1)
		
	End Function
End Module