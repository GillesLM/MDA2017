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
    Public Function GenOnePoint(ByVal AbsyceScale As Double, ByVal OrdonneScale As Double) As Point
        Dim Point As Point

        Point.X = (Rnd() * AbsyceScale)
        Point.Y = (Rnd() * OrdonneScale)

        Return Point
    End Function

End Module
