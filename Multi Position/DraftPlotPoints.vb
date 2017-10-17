
Public Class DraftPlotPoints

    Dim Xtemp As Double
    Dim Ytemp As Double
    Dim Puit As New Well()
    Dim Plaque As New Plate(Puit, 8, 12, 1)
    Dim WellNbr As Integer
    Dim temp As New ArrayList()
    Dim Wait As Boolean = True
    Dim Iteration As Integer = 0



    Private Sub DraftPlotPoints_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Puit._AreaWidth = NumCoteA.Value
        Puit._AreaHeight = NumCoteB.Value
        Puit._CountAsk = NumPosToFind.Value
        Puit._Clearance = NumDistMin.Value




    End Sub



    Private Sub NumCoteA_ValueChanged(sender As Object, e As EventArgs) Handles NumCoteA.ValueChanged

        Puit._AreaWidth = NumCoteA.Value

    End Sub

    Private Sub NumCoteB_ValueChanged(sender As Object, e As EventArgs) Handles NumCoteB.ValueChanged

        Puit._AreaHeight = NumCoteB.Value

    End Sub

    Private Sub NumPosToFind_ValueChanged(sender As Object, e As EventArgs) Handles NumPosToFind.ValueChanged

        Puit._CountAsk = NumPosToFind.Value

    End Sub

    Private Sub NumDistMin_ValueChanged(sender As Object, e As EventArgs) Handles NumDistMin.ValueChanged

        Puit._Clearance = NumDistMin.Value

    End Sub

    Private Sub BtnGenPlot_Click(sender As Object, e As EventArgs) Handles BtnGenPlot.Click

        Puit.GenPoints()

        TimerPoints.Enabled = True

    End Sub



    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click

        Me.Chart1.Series("Series1").Points.Clear()
        Puit._PointsArray.Clear()
        Plaque._WellsArray.Clear()
        Iteration = 0
        TimerWells.Enabled = False
        TimerPoints.Enabled = False


    End Sub

    Private Sub TimerPoints_Tick(sender As Object, e As EventArgs) Handles TimerPoints.Tick

        Dim PointTemp As Point

        If Iteration < Puit._PointsArray.Count Then

            PointTemp = Puit._PointsArray(Iteration)
            Me.Chart1.Series("Series1").Points.AddXY(PointTemp.X, PointTemp.Y)
            Iteration += 1

        End If



    End Sub

    Private Sub NumWells_ValueChanged(sender As Object, e As EventArgs) Handles NumWells.ValueChanged
        WellNbr = NumWells.Value
    End Sub

    Private Sub BtnGenWells_Click(sender As Object, e As EventArgs) Handles BtnGenWells.Click

        Plaque.GenWells(Puit, WellNbr)
        TimerWells.Enabled = True

    End Sub

    Private Sub TimerWells_Tick(sender As Object, e As EventArgs) Handles TimerWells.Tick


        Dim well As New Well

        If Iteration < Plaque._PWellFilled Then

            Me.Chart1.Series("Series1").Points.AddXY(well._Coordonates.X, well._Coordonates.Y)
            Iteration += 1

        End If

        Lbliteration.Text = Iteration

    End Sub
End Class
