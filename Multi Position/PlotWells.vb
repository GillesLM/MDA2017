
Public Class PlotWells

    Dim Xtemp As Double
    Dim Ytemp As Double
    Dim Puit As New Well()
    Dim Plaque As New Plate(Puit, 8, 12, 1)
    Dim WellNbr As Integer
    Dim temp As New ArrayList()
    Dim Iteration As Integer = 0



    ''' <summary>
    ''' Plaque généré par dans la formulaire PLotWells
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property _ActuelWell As Well
        Get
            Return Plaque._WellsArray(Iteration)
        End Get



    End Property

    Private Sub DraftPlotPoints_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Puit._AreaWidth = NumCoteA.Value
        Puit._AreaHeight = NumCoteB.Value
        Puit._CountAsk = NumPosToFind.Value
        Puit._Clearance = NumDistMin.Value
        PlotPositions.Owner = Me
        PlotPositions.Close()




    End Sub





    Private Sub NumPosToFind_ValueChanged(sender As Object, e As EventArgs) Handles NumPosToFind.ValueChanged

        Puit._CountAsk = NumPosToFind.Value

    End Sub

    Private Sub NumDistMin_ValueChanged(sender As Object, e As EventArgs) Handles NumDistMin.ValueChanged

        Puit._Clearance = NumDistMin.Value

    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click

        Me.Chart1.Series("Series1").Points.Clear()
        Puit._PointsArray.Clear()
        Plaque._WellsArray.Clear()
        Iteration = 0


    End Sub


    Private Sub NumWells_ValueChanged(sender As Object, e As EventArgs) Handles NumWells.ValueChanged
        WellNbr = NumWells.Value
    End Sub

    Private Sub BtnGenWells_Click(sender As Object, e As EventArgs) Handles BtnGenWells.Click

        Plaque.
        Plaque.GenerateWells(WellNbr)
        TimerShowPositins.Enabled = True



    End Sub

    Private Sub TimerShowPositins_Tick(sender As Object, e As EventArgs) Handles TimerShowPositins.Tick


        Dim Form As New PlotPositions()


        If Iteration < Plaque._PWell2Fill Then
            Me.Chart1.Series("Series1").Points.AddXY(Plaque._WellsArray(Iteration)._Coordonates.X, Plaque._WellsArray(Iteration)._Coordonates.Y)
            Form.Show()
        Else
            TimerShowPositins.Enabled = False
            Iteration = 0
        End If

        Iteration += 1

    End Sub
End Class
