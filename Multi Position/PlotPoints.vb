
Public Class PLotPoints
    Dim Xtemp As Double
    Dim Ytemp As Double







    Private Sub NumCoteA_ValueChanged(sender As Object, e As EventArgs) Handles NumCoteA.ValueChanged
        SetCoteA(NumCoteA.Value)


    End Sub

    Private Sub NumCoteB_ValueChanged(sender As Object, e As EventArgs) Handles NumCoteB.ValueChanged
        SetCoteB(NumCoteB.Value)
    End Sub

    Private Sub NumPosToFind_ValueChanged(sender As Object, e As EventArgs) Handles NumPosToFind.ValueChanged
        SetNbrOfPosToFind(NumPosToFind.Value)
    End Sub

    Private Sub NumDistMin_ValueChanged(sender As Object, e As EventArgs) Handles NumDistMin.ValueChanged
        SetDisMin(NumDistMin.Value)
    End Sub

    Private Sub BtnGenPLot_Click(sender As Object, e As EventArgs) Handles BtnGenPLot.Click
        Me.Chart1.Series("Series1").Points.Clear()
        Main_FindPoints()
        NumResults.Value = GetResultTableSize() - 1
        For i As Integer = 0 To GetResultTableSize() - 1
            Xtemp = IndexResultTable(i).X
            Ytemp = IndexResultTable(i).Y
            Me.Chart1.Series("Series1").Points.AddXY(Xtemp, Ytemp)
        Next
        ResetResulteTable()

    End Sub

End Class
