
Public Class PLotPoints
    Dim Xtemp As Double
    Dim Ytemp As Double


    Private Sub GenPlots_Click(sender As Object, e As EventArgs) Handles BTNGenPlots.Click

        PoolOfPosGenenerator()
        For i As Integer = 0 To GetTabPosSize() - 1
            Me.Chart1.Series("Series1").Points.AddXY(GetTabPos(0, i), GetTabPos(1, i))
        Next

    End Sub

    Private Sub NumCoteA_ValueChanged(sender As Object, e As EventArgs) Handles NumCoteA.ValueChanged
        SetCoteA(NumCoteA.Value)
    End Sub

    Private Sub NumCoteB_ValueChanged(sender As Object, e As EventArgs) Handles NumCoteB.ValueChanged
        SetCoteB(NumCoteB.Value)
    End Sub

    Private Sub NumPosToFind_ValueChanged(sender As Object, e As EventArgs) Handles NumPosToFind.ValueChanged

        ResetFinalPos()
        SetNbrOfPosToFind(NumPosToFind.Value)

    End Sub

    Private Sub BtnGenPLot_Click(sender As Object, e As EventArgs) Handles BtnGenPLot.Click
        FindPoints()


        For i As Integer = 0 To GetFinalPosNbr() - 1
            Xtemp = GetFinalPos(i).X
            Ytemp = GetFinalPos(i).Y
            Me.Chart1.Series("Series1").Points.AddXY(Xtemp, Ytemp)
        Next

    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        Me.Chart1.Series("Series1").Points.Clear()

    End Sub

    Private Sub NumDistMin_ValueChanged(sender As Object, e As EventArgs) Handles NumDistMin.ValueChanged
        SetDisMin(NumDistMin.Value)
    End Sub
End Class
