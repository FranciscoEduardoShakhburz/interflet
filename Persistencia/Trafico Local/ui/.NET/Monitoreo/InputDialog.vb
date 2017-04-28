Imports System.Data.SqlClient

Public Class InputDialog

    Private noViaje As Integer
    Private unidad As String
    Private operador As String
    Private horaAlerta As DateTime
    Private observacion As String
    Private nuevaHora As DateTime

#Region "Constructor y Accesos"
    Public Sub New()
        InitializeComponent()
        Me.noViaje = 0
        Me.unidad = ""
        Me.operador = ""
        Me.horaAlerta = DateTime.Now
        Me.observacion = ""
        Me.nuevaHora = DateTime.Now
    End Sub

    Public Property Viaje() As Integer
        Get
            Return Me.noViaje
        End Get
        Set(ByVal value As Integer)
            Me.noViaje = value
        End Set
    End Property

    Public Property IdUnidad() As String
        Get
            Return Me.unidad
        End Get
        Set(ByVal value As String)
            Me.unidad = value
        End Set
    End Property

    Public Property NombreOperador() As String
        Get
            Return Me.operador
        End Get
        Set(ByVal value As String)
            Me.operador = value
        End Set
    End Property

    Public Property Alerta() As DateTime
        Get
            Return Me.horaAlerta
        End Get
        Set(ByVal value As DateTime)
            Me.horaAlerta = value
        End Set
    End Property

    Public Property Posponer() As DateTime
        Get
            Return Me.nuevaHora
        End Get
        Set(ByVal value As DateTime)
            Me.nuevaHora = value
        End Set
    End Property

#End Region

    Private Sub InputDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtNoViaje.Text = Me.noViaje.ToString()
        Me.txtUnidad.Text = Me.unidad
        Me.txtOperador.Text = Me.operador
        Me.txtHoraAlerta.Text = Me.horaAlerta.ToString()
        Me.cmbAcepto.SelectedIndex = 0
        Me.radioActivar.Checked = True

    End Sub


    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Cursor = Cursors.WaitCursor
        Dim conn As SqlConnection = Connection.getInstance().getConnection()
        Try
            If Not String.IsNullOrEmpty(txtObservaciones.Text.Trim) Then
                Me.observacion = Me.txtObservaciones.Text.Trim.ToUpper()
                Dim command As SqlCommand = New SqlCommand("UP_Guarda_Descansos", conn)
                command.CommandType = CommandType.StoredProcedure
                conn.Open()

                Dim param As SqlParameter
                param = command.Parameters.AddWithValue("@noViaje", Me.noViaje)
                param = command.Parameters.AddWithValue("@unidad", Me.unidad)
                param = command.Parameters.AddWithValue("@nombre_operador", Me.operador)
                param = command.Parameters.AddWithValue("@hora_alerta", Me.horaAlerta)
                param = command.Parameters.AddWithValue("@observaciones", Me.observacion)

                command.ExecuteNonQuery()
                MessageBox.Show("¡El descanso ha sido guardado!")
            Else
                MessageBox.Show("El campo de observación no debe permanecer vacío")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
            conn.Close()
            Cursor = Cursors.Arrow
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        limpiarTextBox()
        Me.Close()
    End Sub

    Private Sub limpiarTextBox()
        For Each control As Control In Me.gpViaje.Controls
            If TypeOf control Is TextBox Then
                control.Text = ""
            End If
        Next
    End Sub

    Private Sub radioActivar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioActivar.CheckedChanged
        If Me.radioActivar.Checked = True Then
            Me.grupoActivar.Visible = True
            Me.grupoPosponer.Visible = False
        Else
            Me.grupoActivar.Visible = False
            Me.grupoPosponer.Visible = True
        End If
    End Sub

    Private Sub btnPosponer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPosponer.Click
        Dim horas As String = Me.txtPosponer.Text.Trim
        Dim horaActual As DateTime = DateTime.Now
        If Not String.IsNullOrEmpty(horas) Then
            horaActual = horaActual.AddHours(Convert.ToDouble(horas))
        End If
        Me.Posponer = horaActual
    End Sub
End Class