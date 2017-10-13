
Public Class DraftPlotPoints
    Dim Xtemp As Double
    Dim Ytemp As Double
    Dim Puit As New RandomPointArea()
    Dim temp As ArrayList



    Private Sub NumCoteA_ValueChanged(sender As Object, e As EventArgs) Handles NumCoteA.ValueChanged

        Puit.AreaWidth = NumCoteA.Value

    End Sub

    Private Sub NumCoteB_ValueChanged(sender As Object, e As EventArgs) Handles NumCoteB.ValueChanged

        Puit.AreaHeight = NumCoteB.Value

    End Sub

    Private Sub NumPosToFind_ValueChanged(sender As Object, e As EventArgs) Handles NumPosToFind.ValueChanged

        Puit.CountOfPoint = NumPosToFind.Value

    End Sub

    Private Sub NumDistMin_ValueChanged(sender As Object, e As EventArgs) Handles NumDistMin.ValueChanged

        Puit.PointClearance = NumDistMin.Value

    End Sub

    Private Sub BtnGenPLot_Click(sender As Object, e As EventArgs) Handles BtnGenPLot.Click

        Puit.GenPoints()
        Dim PointTemp As Point

        For i As Integer = 0 To Puit.PointPositionArray.Count() - 1
            PointTemp = Puit.PointPositionArray(i)



            Me.Chart1.Series("Series1").Points.AddXY(PointTemp.X, PointTemp.Y)
        Next

        Puit.PointPositionArray.Clear()

    End Sub

    Private Sub DraftPlotPoints_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Puit.PointClearance = 10000
    End Sub
End Class
