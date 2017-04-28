Public Class SelectorColumnas

    Private seg As SeguimientoEmbarques

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(ByRef seg As SeguimientoEmbarques)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.seg = seg

    End Sub

    Private Sub SelectorColumnas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.cargarGrid()

    End Sub

    Private Sub cargarGrid()

        Dim indice As Integer

        For Each columna As DataGridViewColumn In Me.seg.gridInfo.Columns

            indice = Me.gridColumnas.Rows.Add()
            Me.gridColumnas.Rows(indice).Cells("colColumna").Value = columna.HeaderText
            Me.gridColumnas.Rows(indice).Cells("colSeleccionada").Value = IIf(columna.Visible, True, False)

        Next
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        Me.seleccionDeColumnas()
        Me.Close()

    End Sub

    Private Sub seleccionDeColumnas()

        For Each seleccion As DataGridViewRow In Me.gridColumnas.Rows
            If seleccion.Cells("colSeleccionada").Value = False Then
                For Each columna As DataGridViewColumn In Me.seg.gridInfo.Columns
                    If seleccion.Cells("colColumna").Value.ToString().Equals(columna.HeaderText) Then

                        columna.Visible = False
                        Exit For

                    End If
                Next
            Else
                For Each columna As DataGridViewColumn In Me.seg.gridInfo.Columns
                    If seleccion.Cells("colColumna").Value.ToString().Equals(columna.HeaderText) Then

                        columna.Visible = True
                        Exit For

                    End If
                Next
            End If
        Next
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Close()

    End Sub
End Class