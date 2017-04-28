Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Security.Cryptography

Module ObtenerDatosCorreo

    Public Function nombreUsuario(ByVal idPersonal As Integer) As String
        Dim dominio As String = "@hinojosa.com.mx"

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim consulta As String

        Dim usuario As String
        Dim pwd As String
        Try
            consulta = "SELECT usuario, pwd FROM usuarios_correos WHERE IdPersonal = " & idPersonal & " "
            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand(consulta, conexion)
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 600
            conexion.Open()
            'usuario = comando.ExecuteScalar().ToString()
            'usuario = usuario & dominio
            '
            dS = New DataSet()
            sDA = New SqlDataAdapter(comando)
            sDA.Fill(dS)
            '
            If dS.Tables.Count > 0 Then
                If dS.Tables(0).Rows.Count > 0 Then
                    usuario = dS.Tables(0).Rows(0)("usuario").ToString()
                End If
            End If
            '
            conexion.Close()
            comando.Dispose()
            conexion.Dispose()
        Catch ex As Exception
            MessageBox.Show("Error al consultar desconexiones: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return usuario

    End Function

    Public Function contrasena(ByVal idPersonal As Integer) As String
        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet
        Dim consulta As String

        Dim usuario As String
        Dim pwd As String
        Try
            consulta = "SELECT pwd FROM usuarios_correos WHERE IdPersonal = " & idPersonal & " "
            conexion = Connection.getInstance().getConnection()
            comando = New SqlCommand(consulta, conexion)
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 600
            conexion.Open()
            'usuario = comando.ExecuteScalar().ToString()
            '
            dS = New DataSet()
            sDA = New SqlDataAdapter(comando)
            sDA.Fill(dS)
            '
            If dS.Tables.Count > 0 Then
                If dS.Tables(0).Rows.Count > 0 Then
                    usuario = dS.Tables(0).Rows(0)("pwd").ToString()
                End If
            End If
            '
            conexion.Close()
            comando.Dispose()
            conexion.Dispose()
        Catch ex As Exception
            MessageBox.Show("Error al consultar desconexiones: " & ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return usuario

    End Function


End Module
