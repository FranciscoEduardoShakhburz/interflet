Imports System.Data
Imports System.Data.SqlClient

Public Class IngresoBooking

    Private sql As String

    Private Sub IngresoBooking_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Cursor.Current = Cursors.Arrow

    End Sub

    Public Sub setSQL(ByVal sql As String)

        Me.sql = sql

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Dispose()

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        Dim conexion As SqlConnection
        Dim comando As SqlCommand
        Dim sDA As SqlDataAdapter
        Dim dS As DataSet


    End Sub
End Class