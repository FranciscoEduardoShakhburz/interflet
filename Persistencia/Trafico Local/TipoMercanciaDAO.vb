Imports System.Data.SqlClient
Imports System.Collections.Generic

Public Class TipoMercanciaDAO
    Public Shared Function getTiposMercancia() As List(Of TipoMercancia)
        Dim tiposMercancia As List(Of TipoMercancia) = New List(Of TipoMercancia)
        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        conn.Open()
        Dim sql As String = "SELECT ID_MERCANCIA, ID_TIPO_MERCANCIA FROM TRAFICO_LOCAL_MERCANCIA"
        Dim command As SqlCommand = New SqlCommand(sql, conn)
        Dim reader As SqlDataReader = command.ExecuteReader()
        While reader.Read()
            Dim tipoMercancia As TipoMercancia = New TipoMercancia()
            tipoMercancia.id_mercancia = reader.GetInt32(0)
            tipoMercancia.id_tipo_mercancia = reader.GetString(1)
            tiposMercancia.Add(tipoMercancia)
        End While
        Return tiposMercancia
    End Function
End Class
