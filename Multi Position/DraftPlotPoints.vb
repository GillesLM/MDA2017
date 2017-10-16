
Public Class DraftPlotPoints
    Dim Xtemp As Double
    Dim Ytemp As Double
    Dim Puit As New Well()
    Dim temp As New ArrayList()
    Dim Wait As Boolean = True
    Dim Interation As Integer = 0

    Private Sub DraftPlotPoints_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Puit._AreaWidth = NumCoteA.Value
        Puit._AreaHeight = NumCoteB.Value
        Puit._CountAsk = NumPosToFind.Value
        Puit._Clearance = NumDistMin.Value

        Puit.



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

    Private Sub BtnGenPLot_Click(sender As Object, e As EventArgs) Handles BtnGenPLot.Click

        Puit.GenPoints()
        Puit.
        Timer1.Enabled = True

    End Sub



    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click

        Me.Chart1.Series("Series1").Points.Clear()
        Puit._PointsArray.Clear()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim PointTemp As Point

        If Interation < Puit._PointsArray.Count Then

            PointTemp = Puit._PointsArray(Interation)
            Me.Chart1.Series("Series1").Points.AddXY(PointTemp.X, PointTemp.Y)
            Interation += 1

        End If

    End Sub
End Class
