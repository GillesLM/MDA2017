Module Algèbre

    ''' <summary>
    ''' Calcul de la distance entre 2 points de coordonnée XY.
    ''' </summary>
    ''' <param name="PointA">Premier point</param>
    ''' <param name="PointB">Deuxième point</param>
    ''' <returns></returns>
    Public Function Pythagore(ByVal PointA As Point, ByVal PointB As Point) As Double

        Dim Hypotenuse As Double
        Dim AdjacentA As Double
        Dim AdjacentB As Double

        AdjacentA = PointA.X - PointB.X
        AdjacentB = PointA.Y - PointB.Y

        Hypotenuse = Math.Sqrt(AdjacentA ^ 2 + AdjacentB ^ 2)

        Return Hypotenuse
    End Function

    ''' <summary>
    ''' Génération d'un point aléatoire
    ''' </summary>
    ''' <param name="AbscissScale">2chelle des abscisse</param>
    ''' <param name="OrdonateScale"></param>
    ''' <returns>A point</returns>
    Public Function GenOnePoint(ByVal AbscissScale As Double, ByVal OrdonateScale As Double) As Point
        Dim Point As Point

        Point.X = (Rnd() * AbscissScale)
        Point.Y = (Rnd() * OrdonateScale)

        Return Point
    End Function

    ''' <summary>
    ''' Fonction qui trie les points selon les X croissants.
    ''' </summary>
    Public Sub SortPoint(ByRef List As List(Of Point))

        Dim sortedPoints As New List(Of Point)
        sortedPoints = (From pnt In List Order By pnt.X, pnt.Y Select pnt).ToList
        List = sortedPoints

    End Sub

End Module
