Public Class PlotPositions

    Dim Iteration As Integer 0

    Dim WellList As List(Of Well)

    Private Sub PlotPositions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ChrPosInWell.Series("Positions").Points.Clear()
        WellList = PlotWells._ActuelWell
        TimerShowPosition.Enabled = True


    End Sub

    Private Sub TimerShowPosition_Tick(sender As Object, e As EventArgs) Handles TimerShowPosition.Tick

        Dim PointTemp As Point

        If Iteration < WellList.Last._PointsArray.Count Then

            PointTemp = Puit._PointsArray(Iteration)
            Me.Chart1.Series("Series1").Points.AddXY(PointTemp.X, PointTemp.Y)
            Iteration += 1

        End If


    End Sub
End Class