Imports System.Data.SqlClient
Imports System.Collections.Generic

Public Class TipoProgramacionDAO
    Public Shared Function getTiposProgramacion() As List(Of TipoProgramacion)
        Dim tiposProgramacion As List(Of TipoProgramacion) = New List(Of TipoProgramacion)
        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        conn.Open()
        Dim sql As String = "SELECT ID_PROGRAMACION, ID_NOMBRE_PROGRAMACION, ID_ABREVIATURA_PROGRAMACION FROM TRAFICO_LOCAL_PROGRAMACION"
        Dim command As SqlCommand = New SqlCommand(sql, conn)
        Dim reader As SqlDataReader = command.ExecuteReader()
        While reader.Read()
            Dim tipoProgramacion As TipoProgramacion = New TipoProgramacion()
            tipoProgramacion.id_programacion = reader.GetInt32(0)
            tipoProgramacion.id_nombre_programacion = reader.GetString(1)
            tipoProgramacion.id_abreviatura_programacion = reader.GetString(2)
            tiposProgramacion.Add(tipoProgramacion)
        End While
        Return tiposProgramacion
    End Function
End Class
