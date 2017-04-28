Imports System.Data.SqlClient
Imports System.Collections.Generic

Public Class TipoMovimientoDAO
    Public Shared Function getTiposMovimiento() As List(Of TipoMovimiento)
        Dim tiposMovimiento As List(Of TipoMovimiento) = New List(Of TipoMovimiento)
        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        conn.Open()
        Dim sql As String = "SELECT ID_MOVIMIENTO, NOMBRE_MOVIMIENTO FROM TRAFICO_LOCAL_MOVIMIENTO"
        Dim command As SqlCommand = New SqlCommand(sql, conn)
        Dim reader As SqlDataReader = command.ExecuteReader()
        While reader.Read()
            Dim tipoMovimiento As TipoMovimiento = New TipoMovimiento()
            tipoMovimiento.id_movimiento = reader.GetInt32(0)
            tipoMovimiento.nombre_movimiento = reader.GetString(1)
            tiposMovimiento.Add(tipoMovimiento)
        End While
        Return tiposMovimiento
    End Function
End Class
