Imports System.Data.SqlClient
Imports System.Collections.Generic

Public Class TipoContenedorDAO

    Public Shared Function getTiposContenedor() As List(Of TipoContenedor)
        Dim tiposContenedor As List(Of TipoContenedor) = New List(Of TipoContenedor)
        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        conn.Open()
        Dim sql As String = "SELECT ID_TIPO_CONTENEDOR, TIPO_CONTENEDOR FROM TRAFICO_LOCAL_TIPO_CONTENEDOR"
        Dim command As SqlCommand = New SqlCommand(sql, conn)
        Dim reader As SqlDataReader = command.ExecuteReader()
        While reader.Read()
            Dim tipoContenedor As TipoContenedor = New TipoContenedor()
            tipoContenedor.id_tipo_contenedor = reader.GetInt32(0)
            tipoContenedor.tipo_contenedor = reader.GetString(1)
            tiposContenedor.Add(tipoContenedor)
        End While
        Return tiposContenedor
    End Function
End Class
