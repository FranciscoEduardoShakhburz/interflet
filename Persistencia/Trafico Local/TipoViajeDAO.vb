Imports System.Data.SqlClient
Imports System.Collections.Generic

Public Class TipoViajeDAO

    Public Shared Function getListTiposViaje() As List(Of TipoViaje)

        Dim tiposViaje As List(Of TipoViaje) = New List(Of TipoViaje)
        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        conn.Open()
        Dim sql As String = "select id_tipoviaje, tipoviaje from trafico_tipo_viaje order by id_tipoviaje"
        Dim command As SqlCommand = New SqlCommand(sql, conn)
        command.CommandType = CommandType.Text
        Dim reader As SqlDataReader = command.ExecuteReader()

        While reader.Read()

            Dim tipoViaje As TipoViaje = New TipoViaje()
            tipoViaje.IdTipo = reader.GetInt32(0)
            tipoViaje.Tipo = reader.GetString(1)
            tiposViaje.Add(tipoViaje)

        End While

        conn.Close()
        Return tiposViaje

    End Function

    Public Shared Function getTableTiposViaje() As DataTable
        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        conn.Open()
        Dim sql As String = "select id_tipoviaje, tipoviaje from trafico_tipo_viaje order by id_tipoviaje"
        Dim adapter As New SqlDataAdapter(sql, conn)
        Dim table As New DataTable
        adapter.Fill(table)
        conn.Close()
        Return table
    End Function

    Public Shared Sub insertTipoViaje(ByVal tipoViaje As String)
        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        conn.Open()
        Dim sql As String = "insert into trafico_tipo_viaje (tipoviaje) values ('" + tipoViaje + "')"
        Dim command As SqlCommand = New SqlCommand(sql, conn)
        command.CommandType = CommandType.Text
        command.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Shared Sub updateTipoviaje(ByVal tipoViaje As String, ByVal idTipoViaje As Integer)
        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        conn.Open()
        Dim sql As String = "update trafico_tipo_viaje set tipoviaje = '" + tipoViaje + "' where id_tipoviaje = " + idTipoViaje.ToString()
        Dim command As SqlCommand = New SqlCommand(sql, conn)
        command.CommandType = CommandType.Text
        command.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Shared Sub deleteTipoViaje(ByVal idTipoViaje As Integer)
        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        conn.Open()
        Dim sql As String = "delete from trafico_tipo_viaje where id_tipoviaje = " + idTipoViaje.ToString()
        Dim command As SqlCommand = New SqlCommand(sql, conn)
        command.CommandType = CommandType.Text
        command.ExecuteNonQuery()
        conn.Close()
    End Sub

End Class
