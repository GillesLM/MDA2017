''' <summary>
''' Class de zone de point. Elle a pour but la création d'aire contenant plusieurs point dont la position est déterminé de manière aléatoire.
''' </summary>
Public Class RandomPointArea

    Private Largeur As Double       'largeur de la zone contenant les points 
    Private Longueur As Double      'longeur de la zone contenant les points
    Private DistanceMin As Double   'distance minimum séparant les points
    Private PointCount As Double    'Nombre de point dans la zone


    Private RndPoint As New Point()     'Point aléatoire   
    Private RArrey As New ArrayList()   'tableau de point contenant les points


    ''' <summary>
    ''' accès au Tableau de résultat
    ''' </summary>
    ''' <returns>Retourne un tableau du type arraylist</returns>
    Public Property ResultArray As ArrayList
        Get
            Return RArrey
        End Get
        Set(value As ArrayList)
            RArrey = value
        End Set
    End Property

    ''' <summary>
    ''' accès à la largeur de la zone
    ''' </summary>
    ''' <returns>Retourne une valeur du type double</returns>
    Public Property AreaWidth As Double
        Get
            Return Largeur
        End Get
        Set(value As Double)
            Largeur = value
        End Set
    End Property


    ''' <summary>
    ''' accès à la longueur de la zone
    ''' </summary>
    ''' <returns>Retourne une valeur du type double</returns>
    Public Property AreaHeight As Double
        Get
            Return Longueur
        End Get
        Set(value As Double)
            Longueur = value
        End Set
    End Property


    ''' <summary>
    ''' accès à l'entrax minimum entre chaque point
    ''' </summary>
    ''' <returns>Retourne une valeur de type double</returns>
    Public Property PointClearance As Double
        Get
            Return DistanceMin
        End Get
        Set(value As Double)
            DistanceMin = value
        End Set
    End Property

    ''' <summary>
    ''' accès au nombre de point a trouver
    ''' </summary>
    ''' <returns>retourne une valeur du type double</returns>
    Public Property PointPool As Double
        Get
            Return PointCount
        End Get
        Set(value As Double)
            PointCount = value
        End Set
    End Property

    ''' <summary>
    ''' Fonction qui génére un point dans la zone et le stock dans RndPoint
    ''' </summary>
    Private Sub GenOnePoint()
        RndPoint.X = (Rnd() * Largeur)
        RndPoint.Y = (Rnd() * Longueur)
    End Sub


    ''' <summary>
    ''' Fonction qui calcul la distance entre 2 points.
    ''' </summary>
    ''' <param name="PointA"> Premier point</param>
    ''' <param name="PointB">Deuxième point</param>
    ''' <returns></returns>
    Private Function Pythagore(ByVal PointA As Point, ByVal PointB As Point) As Double

        Dim Hypotenuse As Double
        Dim AdjacentA As Double
        Dim AdjacentB As Double

        AdjacentA = PointA.X - PointB.X
        AdjacentB = PointA.Y - PointB.Y

        Hypotenuse = Math.Sqrt(AdjacentA ^ 2 + AdjacentB ^ 2)

        Return Hypotenuse
    End Function

    ''' <summary>
    ''' Fonction de contruction de la zone avec répartition des point
    ''' </summary>
    Public Sub New()

    End Sub

    Public Sub New(ByVal CoteA As Double, ByVal CoteB As Double, ByVal Distance As Double, ByVal Count As Double)

        Largeur = CoteA
        Longueur = CoteB
        DistanceMin = Distance
        PointCount = Count

    End Sub

End Class
