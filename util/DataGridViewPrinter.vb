Imports System
Imports System.Text
Imports System.Collections
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Data
Imports System.Windows.Forms

Class DataGridViewPrinter
    Private TheDataGridView As DataGridView

    Private ThePrintDocument As PrintDocument

    Private IsCenterOnPage As Boolean

    Private IsWithTitle As Boolean

    Private TheTitleText As String

    Private TheTitleFont As Font

    Private TheTitleColor As Color

    Private IsWithPaging As Boolean

    Shared CurrentRow As Integer

    Shared PageNumber As Integer

    Private PageWidth As Integer
    Private PageHeight As Integer
    Private LeftMargin As Integer
    Private TopMargin As Integer
    Private RightMargin As Integer
    Private BottomMargin As Integer

    Private CurrentY As Single

    Private RowHeaderHeight As Single
    Private RowsHeight As List(Of Single)
    Private ColumnsWidth As List(Of Single)
    Private TheDataGridViewWidth As Single



    Private mColumnPoints As List(Of Integer())
    Private mColumnPointsWidth As List(Of Single)
    Private mColumnPoint As Integer


    Public Sub New(ByVal aDataGridView As DataGridView, ByVal aPrintDocument As PrintDocument, ByVal CenterOnPage As Boolean, ByVal WithTitle As Boolean, ByVal aTitleText As String, ByVal aTitleFont As Font, _
     ByVal aTitleColor As Color, ByVal WithPaging As Boolean)
        TheDataGridView = aDataGridView
        ThePrintDocument = aPrintDocument
        IsCenterOnPage = CenterOnPage
        IsWithTitle = WithTitle
        TheTitleText = aTitleText
        TheTitleFont = aTitleFont
        TheTitleColor = aTitleColor
        IsWithPaging = WithPaging

        PageNumber = 0

        RowsHeight = New List(Of Single)()
        ColumnsWidth = New List(Of Single)()

        mColumnPoints = New List(Of Integer())()
        mColumnPointsWidth = New List(Of Single)()


        If Not ThePrintDocument.DefaultPageSettings.Landscape Then
            PageWidth = ThePrintDocument.DefaultPageSettings.PaperSize.Width
            PageHeight = ThePrintDocument.DefaultPageSettings.PaperSize.Height
        Else
            PageHeight = ThePrintDocument.DefaultPageSettings.PaperSize.Width
            PageWidth = ThePrintDocument.DefaultPageSettings.PaperSize.Height
        End If


        LeftMargin = ThePrintDocument.DefaultPageSettings.Margins.Left
        TopMargin = ThePrintDocument.DefaultPageSettings.Margins.Top
        RightMargin = ThePrintDocument.DefaultPageSettings.Margins.Right
        BottomMargin = ThePrintDocument.DefaultPageSettings.Margins.Bottom


        CurrentRow = 0
    End Sub


    Private Sub Calculate(ByVal g As Graphics)
        If PageNumber = 0 Then

            Dim tmpSize As New SizeF()
            Dim tmpFont As Font
            Dim tmpWidth As Single

            TheDataGridViewWidth = 0
            For i As Integer = 0 To TheDataGridView.Columns.Count - 1
                tmpFont = TheDataGridView.ColumnHeadersDefaultCellStyle.Font
                If tmpFont Is Nothing Then

                    tmpFont = TheDataGridView.DefaultCellStyle.Font
                End If

                tmpSize = g.MeasureString(TheDataGridView.Columns(i).HeaderText, tmpFont)
                tmpWidth = tmpSize.Width
                RowHeaderHeight = tmpSize.Height

                For j As Integer = 0 To TheDataGridView.Rows.Count - 1
                    tmpFont = TheDataGridView.Rows(j).DefaultCellStyle.Font
                    If tmpFont Is Nothing Then

                        tmpFont = TheDataGridView.DefaultCellStyle.Font
                    End If

                    tmpSize = g.MeasureString("Anything", tmpFont)
                    RowsHeight.Add(tmpSize.Height)

                    tmpSize = g.MeasureString(TheDataGridView.Rows(j).Cells(i).EditedFormattedValue.ToString(), tmpFont)
                    If tmpSize.Width > tmpWidth Then
                        tmpWidth = tmpSize.Width
                    End If
                Next
                If TheDataGridView.Columns(i).Visible Then
                    TheDataGridViewWidth += tmpWidth
                End If
                ColumnsWidth.Add(tmpWidth)
            Next




            Dim k As Integer

            Dim mStartPoint As Integer = 0
            For k = 0 To TheDataGridView.Columns.Count - 1
                If TheDataGridView.Columns(k).Visible Then
                    mStartPoint = k
                    Exit For
                End If
            Next

            Dim mEndPoint As Integer = TheDataGridView.Columns.Count
            For k = TheDataGridView.Columns.Count - 1 To 0 Step -1
                If TheDataGridView.Columns(k).Visible Then
                    mEndPoint = k + 1
                    Exit For
                End If
            Next

            Dim mTempWidth As Single = TheDataGridViewWidth
            Dim mTempPrintArea As Single = CSng(PageWidth) - CSng(LeftMargin) - CSng(RightMargin)


            If TheDataGridViewWidth > mTempPrintArea Then
                mTempWidth = 0.0F
                For k = 0 To TheDataGridView.Columns.Count - 1
                    If TheDataGridView.Columns(k).Visible Then
                        mTempWidth += ColumnsWidth(k)

                        If mTempWidth > mTempPrintArea Then
                            mTempWidth -= ColumnsWidth(k)
                            mColumnPoints.Add(New Integer() {mStartPoint, mEndPoint})
                            mColumnPointsWidth.Add(mTempWidth)
                            mStartPoint = k
                            mTempWidth = ColumnsWidth(k)
                        End If
                    End If

                    mEndPoint = k + 1
                Next
            End If

            mColumnPoints.Add(New Integer() {mStartPoint, mEndPoint})
            mColumnPointsWidth.Add(mTempWidth)
            mColumnPoint = 0
        End If
    End Sub


    Private Sub DrawHeader(ByVal g As Graphics)
        CurrentY = CSng(TopMargin)


        If IsWithPaging Then
            PageNumber += 1
            Dim PageString As String = "Pagina " & PageNumber.ToString()

            Dim PageStringFormat As New StringFormat()
            PageStringFormat.Trimming = StringTrimming.Word
            PageStringFormat.FormatFlags = StringFormatFlags.NoWrap Or StringFormatFlags.LineLimit Or StringFormatFlags.NoClip
            PageStringFormat.Alignment = StringAlignment.Far

            Dim PageStringFont As New Font("Tahoma", 8, FontStyle.Regular, GraphicsUnit.Point)

            Dim PageStringRectangle As New RectangleF(CSng(LeftMargin), CurrentY, CSng(PageWidth) - CSng(RightMargin) - CSng(LeftMargin), g.MeasureString(PageString, PageStringFont).Height)

            g.DrawString(PageString, PageStringFont, New SolidBrush(Color.Black), PageStringRectangle, PageStringFormat)

            CurrentY += g.MeasureString(PageString, PageStringFont).Height
        End If


        If IsWithTitle Then
            Dim TitleFormat As New StringFormat()
            TitleFormat.Trimming = StringTrimming.Word
            TitleFormat.FormatFlags = StringFormatFlags.NoWrap Or StringFormatFlags.LineLimit Or StringFormatFlags.NoClip
            If IsCenterOnPage Then
                TitleFormat.Alignment = StringAlignment.Center
            Else
                TitleFormat.Alignment = StringAlignment.Near
            End If

            Dim TitleRectangle As New RectangleF(CSng(LeftMargin), CurrentY, CSng(PageWidth) - CSng(RightMargin) - CSng(LeftMargin), g.MeasureString(TheTitleText, TheTitleFont).Height)

            g.DrawString(TheTitleText, TheTitleFont, New SolidBrush(TheTitleColor), TitleRectangle, TitleFormat)

            CurrentY += g.MeasureString(TheTitleText, TheTitleFont).Height
        End If


        Dim CurrentX As Single = CSng(LeftMargin)
        If IsCenterOnPage Then
            CurrentX += ((CSng(PageWidth) - CSng(RightMargin) - CSng(LeftMargin)) - mColumnPointsWidth(mColumnPoint)) / 2.0F
        End If


        Dim HeaderForeColor As Color = TheDataGridView.ColumnHeadersDefaultCellStyle.ForeColor
        If HeaderForeColor.IsEmpty Then

            HeaderForeColor = TheDataGridView.DefaultCellStyle.ForeColor
        End If
        Dim HeaderForeBrush As New SolidBrush(HeaderForeColor)


        Dim HeaderBackColor As Color = TheDataGridView.ColumnHeadersDefaultCellStyle.BackColor
        If HeaderBackColor.IsEmpty Then

            HeaderBackColor = TheDataGridView.DefaultCellStyle.BackColor
        End If
        Dim HeaderBackBrush As New SolidBrush(HeaderBackColor)


        Dim TheLinePen As New Pen(TheDataGridView.GridColor, 1)


        Dim HeaderFont As Font = TheDataGridView.ColumnHeadersDefaultCellStyle.Font
        If HeaderFont Is Nothing Then

            HeaderFont = TheDataGridView.DefaultCellStyle.Font
        End If


        Dim HeaderBounds As New RectangleF(CurrentX, CurrentY, mColumnPointsWidth(mColumnPoint), RowHeaderHeight)
        g.FillRectangle(HeaderBackBrush, HeaderBounds)


        Dim CellFormat As New StringFormat()
        CellFormat.Trimming = StringTrimming.Word
        CellFormat.FormatFlags = StringFormatFlags.NoWrap Or StringFormatFlags.LineLimit Or StringFormatFlags.NoClip


        Dim CellBounds As RectangleF
        Dim ColumnWidth As Single
        For i As Integer = CInt(mColumnPoints(mColumnPoint).GetValue(0)) To CInt(mColumnPoints(mColumnPoint).GetValue(1)) - 1
            If Not TheDataGridView.Columns(i).Visible Then
                Continue For
            End If

            ColumnWidth = ColumnsWidth(i)


            If TheDataGridView.ColumnHeadersDefaultCellStyle.Alignment.ToString().Contains("Right") Then
                CellFormat.Alignment = StringAlignment.Far
            ElseIf TheDataGridView.ColumnHeadersDefaultCellStyle.Alignment.ToString().Contains("Center") Then
                CellFormat.Alignment = StringAlignment.Center
            Else
                CellFormat.Alignment = StringAlignment.Near
            End If

            CellBounds = New RectangleF(CurrentX, CurrentY, ColumnWidth, RowHeaderHeight)


            g.DrawString(TheDataGridView.Columns(i).HeaderText, HeaderFont, HeaderForeBrush, CellBounds, CellFormat)


            If TheDataGridView.RowHeadersBorderStyle <> DataGridViewHeaderBorderStyle.None Then

                g.DrawRectangle(TheLinePen, CurrentX, CurrentY, ColumnWidth, RowHeaderHeight)
            End If

            CurrentX += ColumnWidth
        Next

        CurrentY += RowHeaderHeight
    End Sub




    Private Function DrawRows(ByVal g As Graphics) As Boolean

        Dim TheLinePen As New Pen(TheDataGridView.GridColor, 1)


        Dim RowFont As Font
        Dim RowForeColor As Color
        Dim RowBackColor As Color
        Dim RowForeBrush As SolidBrush
        Dim RowBackBrush As SolidBrush
        Dim RowAlternatingBackBrush As SolidBrush


        Dim CellFormat As New StringFormat()
        CellFormat.Trimming = StringTrimming.Word
        CellFormat.FormatFlags = StringFormatFlags.NoWrap Or StringFormatFlags.LineLimit


        Dim RowBounds As RectangleF
        Dim CurrentX As Single
        Dim ColumnWidth As Single
        While CurrentRow < TheDataGridView.Rows.Count - 1
            If TheDataGridView.Rows(CurrentRow).Visible Then


                RowFont = TheDataGridView.Rows(CurrentRow).DefaultCellStyle.Font
                If RowFont Is Nothing Then

                    RowFont = TheDataGridView.DefaultCellStyle.Font
                End If


                RowForeColor = TheDataGridView.Rows(CurrentRow).DefaultCellStyle.ForeColor
                If RowForeColor.IsEmpty Then

                    RowForeColor = TheDataGridView.DefaultCellStyle.ForeColor
                End If
                RowForeBrush = New SolidBrush(RowForeColor)


                RowBackColor = TheDataGridView.Rows(CurrentRow).DefaultCellStyle.BackColor
                If RowBackColor.IsEmpty Then

                    RowBackBrush = New SolidBrush(TheDataGridView.DefaultCellStyle.BackColor)
                    RowAlternatingBackBrush = New SolidBrush(TheDataGridView.AlternatingRowsDefaultCellStyle.BackColor)
                Else

                    RowBackBrush = New SolidBrush(RowBackColor)
                    RowAlternatingBackBrush = New SolidBrush(RowBackColor)
                End If


                CurrentX = CSng(LeftMargin)
                If IsCenterOnPage Then
                    CurrentX += ((CSng(PageWidth) - CSng(RightMargin) - CSng(LeftMargin)) - mColumnPointsWidth(mColumnPoint)) / 2.0F
                End If


                RowBounds = New RectangleF(CurrentX, CurrentY, mColumnPointsWidth(mColumnPoint), RowsHeight(CurrentRow))


                If CurrentRow Mod 2 = 0 Then
                    g.FillRectangle(RowBackBrush, RowBounds)
                Else
                    g.FillRectangle(RowAlternatingBackBrush, RowBounds)
                End If


                For CurrentCell As Integer = CInt(mColumnPoints(mColumnPoint).GetValue(0)) To CInt(mColumnPoints(mColumnPoint).GetValue(1)) - 1
                    If Not TheDataGridView.Columns(CurrentCell).Visible Then
                        Continue For
                    End If


                    If TheDataGridView.Columns(CurrentCell).DefaultCellStyle.Alignment.ToString().Contains("Right") Then
                        CellFormat.Alignment = StringAlignment.Far
                    ElseIf TheDataGridView.Columns(CurrentCell).DefaultCellStyle.Alignment.ToString().Contains("Center") Then
                        CellFormat.Alignment = StringAlignment.Center
                    Else
                        CellFormat.Alignment = StringAlignment.Near
                    End If

                    ColumnWidth = ColumnsWidth(CurrentCell)
                    Dim CellBounds As New RectangleF(CurrentX, CurrentY, ColumnWidth, RowsHeight(CurrentRow))


                    g.DrawString(TheDataGridView.Rows(CurrentRow).Cells(CurrentCell).EditedFormattedValue.ToString(), RowFont, RowForeBrush, CellBounds, CellFormat)


                    If TheDataGridView.CellBorderStyle <> DataGridViewCellBorderStyle.None Then

                        g.DrawRectangle(TheLinePen, CurrentX, CurrentY, ColumnWidth, RowsHeight(CurrentRow))
                    End If

                    CurrentX += ColumnWidth
                Next
                CurrentY += RowsHeight(CurrentRow)



                If CInt(CurrentY) > (PageHeight - TopMargin - BottomMargin) Then
                    CurrentRow += 1
                    Return True
                End If
            End If
            CurrentRow += 1
        End While

        CurrentRow = 0
        mColumnPoint += 1

        If mColumnPoint = mColumnPoints.Count Then

            mColumnPoint = 0
            Return False
        Else
            Return True
        End If
    End Function


    Public Function DrawDataGridView(ByVal g As Graphics) As Boolean
        Try
            Calculate(g)
            DrawHeader(g)
            Dim bContinue As Boolean = DrawRows(g)
            Return bContinue
        Catch ex As Exception
            MessageBox.Show("Operation failed: " & ex.Message.ToString(), Application.ProductName & " - Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            Return False
        End Try
    End Function
End Class
