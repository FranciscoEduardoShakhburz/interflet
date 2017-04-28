Public Class Estadisticas

    Private grid As DataGridView

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByVal grid As DataGridView)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.grid = grid

    End Sub

    Private Sub Estadisticas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.calcular()

    End Sub

    Private Sub calcular()

        Dim totalEmbEntregados As Integer
        Dim entregasEnTiempo As Integer
        Dim entregasFueraDeTiempo As Integer
        Dim porLlegadasATiempo As Integer
        Dim embarquesEnRegreso As Integer
        Dim unidadesEnPatio As Integer
        Dim embarquesCargaDañada As Integer
        Dim entregasPerfectas As Integer

        totalEmbEntregados = 0
        entregasEnTiempo = 0
        entregasFueraDeTiempo = 0
        embarquesEnRegreso = 0
        unidadesEnPatio = 0
        embarquesCargaDañada = 0
        entregasPerfectas = 0

        If Me.grid.Rows.Count > 0 Then
            For Each carga As DataGridViewRow In Me.grid.Rows
                If Not String.IsNullOrEmpty(carga.Cells("colLlegoATiempo").Value.ToString()) Then

                    totalEmbEntregados += 1

                End If
            Next

            For Each carga As DataGridViewRow In Me.grid.Rows
                If carga.Cells("colLlegoATiempo").Value.ToString().Equals("SI") Then

                    entregasEnTiempo += 1

                End If
            Next

            entregasFueraDeTiempo = totalEmbEntregados - entregasEnTiempo

            porLlegadasATiempo = (entregasEnTiempo / IIf(totalEmbEntregados = 0, 1, totalEmbEntregados)) * 100

            If porLlegadasATiempo = 100 Then

                Me.etqLlegadasATiempo.Text = "" & porLlegadasATiempo

            ElseIf porLlegadasATiempo > 9 Then

                Me.etqLlegadasATiempo.Text = " " & porLlegadasATiempo

            Else

                Me.etqLlegadasATiempo.Text = "  " & porLlegadasATiempo

            End If

            For Each carga As DataGridViewRow In Me.grid.Rows
                If carga.Cells("colStatus").Value.ToString().Equals("REGRESO") Then

                    embarquesEnRegreso += 1

                End If
            Next

            If embarquesEnRegreso = 100 Then

                Me.etqEmbarquesRegreso.Text = "" & embarquesEnRegreso

            ElseIf embarquesEnRegreso > 9 Then

                Me.etqEmbarquesRegreso.Text = " " & embarquesEnRegreso

            Else

                Me.etqEmbarquesRegreso.Text = "  " & embarquesEnRegreso

            End If

            Me.etqEmbarquesRegreso.Text = embarquesEnRegreso & ""

            For Each carga As DataGridViewRow In Me.grid.Rows
                If carga.Cells("colStatus").Value.ToString().Equals("PATIO") Then

                    unidadesEnPatio += 1

                End If
            Next

            If unidadesEnPatio >= 100 Then

                Me.etqUnidadesPatio.Text = "" & unidadesEnPatio

            ElseIf unidadesEnPatio > 9 Then

                Me.etqUnidadesPatio.Text = " " & unidadesEnPatio

            Else

                Me.etqUnidadesPatio.Text = "  " & unidadesEnPatio

            End If
        End If

        For Each carga As DataGridViewRow In Me.grid.Rows
            If carga.Cells("colCargaConDaño").Value.ToString().Equals("SI") Then

                embarquesCargaDañada += 0

            End If
        Next

        If embarquesCargaDañada >= 100 Then

            Me.etqUnidadesPatio.Text = "" & embarquesCargaDañada

        ElseIf embarquesCargaDañada > 9 Then

            Me.etqCargaDañada.Text = " " & embarquesCargaDañada

        Else

            Me.etqCargaDañada.Text = "  " & embarquesCargaDañada

        End If

        For Each carga As DataGridViewRow In Me.grid.Rows
            If (carga.Cells("colStatus").Value.ToString().Equals("REGRESO") Or carga.Cells("colStatus").Value.ToString().Equals("CLIENTE")) And carga.Cells("colCargaConDaño").Value.ToString().Equals("NO") And carga.Cells("colLlegoATiempo").Value.ToString().Equals("SI") Then

                entregasPerfectas += 1

            End If
        Next

        If entregasPerfectas >= 100 Then

            Me.etqEntregasPerfectas.Text = "" & entregasPerfectas

        ElseIf embarquesCargaDañada > 9 Then

            Me.etqEntregasPerfectas.Text = " " & entregasPerfectas

        Else

            Me.etqEntregasPerfectas.Text = "  " & entregasPerfectas

        End If

        'For Each carga As DataGridViewRow In Me.grid.Rows
        '    If (carga.Cells("colStatus").Value.ToString().Equals("REGRESO") Or carga.Cells("colStatus").Value.ToString().Equals("CLIENTE")) Then

        '        unidadesEnPatio += 1

        '    End If
        'Next
    End Sub
End Class