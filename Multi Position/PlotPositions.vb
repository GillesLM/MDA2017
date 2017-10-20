Public Class PlotPositions

    Dim Iteration As Integer = 0

    Dim ActuelWell As Well



    Private Sub PlotPositions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ChrPosInWell.Series("Positions").Points.Clear()
        ActuelWell = PlotWells._ActuelWell


        For i As Integer = 0 To ActuelWell._PointsList.Count - 1
            Me.ChrPosInWell.Series("Positions").Points.AddXY(ActuelWell._PointsList(i).X, ActuelWell._PointsList(i).Y)
            LblWell_ID.Text = ActuelWell._ID
        Next

    End Sub



    Private Sub PlotPositions_Closed(sender As Object, e As EventArgs) Handles Me.Closed

    End Sub
End Class