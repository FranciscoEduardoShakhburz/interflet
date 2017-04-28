Imports System.Data.SqlClient
Imports System.Collections.Generic
Imports System.Data.Odbc
Imports System.Data.OleDb
Imports System.IO


'private void actionFoxPro(string action)
'     {
'         string path = @"h:\sica\util\scontrol\";

'         if (Directory.Exists(path))
'         {
'             using (OdbcConnection con = new OdbcConnection("Driver={Microsoft Visual FoxPro Driver};SourceType=DBF;SourceDB=" + path))
'             {
'                 con.Open();
'                 using (OdbcCommand command = new OdbcCommand(action, con))
'                 {
'                     command.ExecuteNonQuery();                        
'                 }
'             }
'         }
'         else
'         {
'             MessageBox.Show("¡LA UBICACIÓN: " + path + " NO EXISTE!");
'         }
'     }

Public Class SolicitudDAO
    'Public Shared Function getSolicitudesByDate(ByVal fechaInicio As String, ByVal fechaFin As String) As List(Of Solicitud)
    '    Dim solicitudes As List(Of Solicitud) = New List(Of Solicitud)
    '    'Dim path As String = "h:\sica\lisrep\patieros\"
    '    Dim path As String = "c:\"
    '    Dim sql As String = "SELECT * FROM algo"
    '    If Directory.Exists(path) Then
    '        Dim conn As OdbcConnection = New OdbcConnection("Driver={Microsoft Visual FoxPro Driver};SourceType=DBF;SourceDB=" + path + ";Exclusive=No;Collate=Machine;NULL=NO;DELETED=NO;BACKGROUNDFETCH=NO;")
    '        Dim command As OdbcCommand = New OdbcCommand(sql, conn)
    '        conn.Open()
    '        Dim algo As Integer = command.ExecuteNonQuery()
    '        'While reader.Read()
    '        '    Dim solicitud As Solicitud = New Solicitud()
    '        '    'bla bla
    '        '    solicitudes.Add(solicitud)
    '        'End While
    '    End If
    '    Return solicitudes
    'End Function
End Class
