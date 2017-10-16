
Public Class DraftPlotPoints
    Dim Xtemp As Double
    Dim Ytemp As Double
    Dim Puit As New Well()
    Dim temp As New ArrayList()
    Dim Wait As Boolean = True
    Dim Interation As Integer = 0

    Private Sub DraftPlotPoints_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Puit.AreaWidth = NumCoteA.Value
        Puit.AreaHeight = NumCoteB.Value
        Puit.PCount = NumPosToFind.Value
        Puit.Clearance = NumDistMin.Value


    End Sub



    Private Sub NumCoteA_ValueChanged(sender As Object, e As EventArgs) Handles NumCoteA.ValueChanged

        Puit.AreaWidth = NumCoteA.Value

    End Sub

    Private Sub NumCoteB_ValueChanged(sender As Object, e As EventArgs) Handles NumCoteB.ValueChanged

        Puit.AreaHeight = NumCoteB.Value

    End Sub

    Private Sub NumPosToFind_ValueChanged(sender As Object, e As EventArgs) Handles NumPosToFind.ValueChanged

        Puit.PCount = NumPosToFind.Value

    End Sub

    Private Sub NumDistMin_ValueChanged(sender As Object, e As EventArgs) Handles NumDistMin.ValueChanged

        Puit.Clearance = NumDistMin.Value

    End Sub

    Private Sub BtnGenPLot_Click(sender As Object, e As EventArgs) Handles BtnGenPLot.Click

        Puit.GenPoints()
        Puit.SortPoint()
        Timer1.Enabled = True

    End Sub



    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click

        Me.Chart1.Series("Series1").Points.Clear()
        Puit.PointsArray.Clear()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim PointTemp As Point

        If Interation < Puit.PointsArray.Count Then

            PointTemp = Puit.PointsArray(Interation)
            Me.Chart1.Series("Series1").Points.AddXY(PointTemp.X, PointTemp.Y)
            Interation += 1

        End If

    End Sub
End Class
