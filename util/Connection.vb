Imports System.Xml
Imports System.IO
Imports System.Data.SqlClient

Public Class Connection

    Private Shared instance As Connection = Nothing

    Private Sub New()

    End Sub

    Public Shared Function getInstance() As Connection

        If instance Is Nothing Then

            instance = New Connection()

        End If

        Return instance

    End Function

    Public Function getConnection() As SqlConnection

        Return New SqlConnection(Me.getConnectionString())

    End Function

    Public Function getConnectionTestDB() As SqlConnection

        Return New SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=TestDB;Data Source=175.50.5.46; Application Name = TestDB")

    End Function

    Public Function getConnectionString() As String

        Dim cnxStr As String
        Dim db As String

        db = "ProduccionInterfletdb"
        'db = "pruebasinter5"


        If db.Equals("ProduccionInterfletdb") Then

            cnxStr = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ProduccionInterfletdb;Data Source=175.50.5.46; Application Name = Sistema Interflet"
        ElseIf db.Equals("pruebasinter5") Then

            cnxStr = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=PruebasInter5;Data Source=175.50.5.46; Application Name = Sistema Interflet"

        End If


        'Return "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ProduccionInterfletdb;Data Source=175.50.5.46; Application Name = Sistema Interflet"

        'PRUEBA
        'Return "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=PruebasInter5;Data Source=175.50.5.46; Application Name = Sistema Interflet"


        'VERACRUZ
        'Return "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ProduccionInterfletdb;Data Source=175.50.5.46; User Id=sa; Password=sa; Application Name = Sistema Interflet"

        Return cnxStr

    End Function

    Public Function getConnectionQFS() As SqlConnection

        Return New SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=QFS;Data Source=175.50.5.46; Application Name = Sistema Interflet - QFS")
        'VERACRUZ
        'Return New SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=QFS;Data Source=175.50.5.46;  User Id=sa; Password=sa; Application Name = Sistema Interflet - QFS")

    End Function

    Public Function getConnectionQSP() As SqlConnection

        Return New SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=QSP;Data Source=175.50.5.46; Application Name = Sistema Interflet - QSP")

    End Function

    Public Function getConnectionDCTIME() As SqlConnection

        Return New SqlConnection("Data Source=dah-291;Initial Catalog=dctime;Persist Security Info=False;User ID=sa;Password=sa")

    End Function
End Class
