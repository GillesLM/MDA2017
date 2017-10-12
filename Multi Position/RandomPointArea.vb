''' <summary>
''' Class de zone de point. Elle a pour but la création d'aire contenant plusieurs point dont la position est déterminé de manière aléatoire.
''' </summary>
Public Class RandomPointArea

    Private Largeur As Double       'largeur de la zone contenant les points 
    Private Longueur As Double      'longeur de la zone contenant les points
    Private DistanceMin As Double   'distance minimum séparant les points
    Private PointCount As Double    'Nombre de point dans la zone

    Private IterationMax As UInteger = 10000
    Private RndPoint As New Point()     'Point aléatoire   
    Private RArrey As New ArrayList()   'tableau de point contenant les points


    ''' <summary>
    ''' Tableau des point peuplant la zone
    ''' </summary>
    ''' <returns>Retourne un tableau du type arraylist</returns>
    Public Property PointPositionArray As ArrayList
        Get
            Return RArrey
        End Get
        Set(value As ArrayList)
            RArrey = value
        End Set
    End Property

    ''' <summary>
    ''' largeur de la zone
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
    ''' longueur de la zone
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
    ''' Distance minimum entre chaque point
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
    ''' nombre de point a trouver
    ''' </summary>
    ''' <returns>retourne une valeur du type double</returns>
    Public Property CountOfPoint As Double
        Get
            Return PointCount
        End Get
        Set(value As Double)
            PointCount = value
        End Set
    End Property

    ''' <summary>
    ''' Maximum d'iteration pour trouver les points aléatoire
    ''' </summary>
    ''' <returns>le nombre maximum d'itération pour trouver les points aléatoire</returns>
    Public Property MaxIteration As UInteger
        Get
            Return IterationMax
        End Get
        Set(value As UInteger)
            IterationMax = value
        End Set
    End Property

    ''' <summary>
    ''' Génération d'un point aléatoire
    ''' </summary>
    Private Function GenOnePoint() As Point
        Dim Point As Point

        Point.X = (Rnd() * Largeur)
        Point.Y = (Rnd() * Longueur)

        Return Point
    End Function


    ''' <summary>
    ''' Calcul de la distance entre 2 points.
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
    ''' Contruction de la zone avec les paramètre par défaut : largeur 10, Longueur 10, Distance mini 1, nombre de point 1
    ''' </summary>
    Public Sub New()
        Largeur = 10
        Longueur = 10
        DistanceMin = 1
        PointCount = 1

    End Sub

    ''' <summary>
    ''' Construction de la zone avec les attributs données
    ''' </summary>
    ''' <param name="CoteA">largeur de la zone</param>
    ''' <param name="CoteB">Longueu de la zone</param>
    ''' <param name="Distance">Distance minimal entre les points</param>
    ''' <param name="Count">Nombre de point contenu dans la zone</param>
    Public Sub New(ByVal CoteA As Double, ByVal CoteB As Double, ByVal Distance As Double, ByVal Count As Double)

        Largeur = CoteA
        Longueur = CoteB
        DistanceMin = Distance
        PointCount = Count

    End Sub

    ''' <summary>
    ''' Génération des points dans la zone
    ''' </summary>
    Public Sub GenPoints()

        Dim Iteration As Integer = 0    'compteur d'itérations
        Dim Count As Integer = 0        'compteur de points trouvés
        Dim Flag As Boolean = False     'Indique si un point a été trouvé
        Dim Distance As Integer = 0     ' distance calculé entre 2 point

        'Génération du premier point que l'on ajout au tableau de point aléatoire
        RndPoint = GenOnePoint()
        RArrey.Add(RndPoint)

        'Recherche d'un nombre de point aléatoire. S'arrête si il a a assés de point trouvé ou si la boucle a fait assés d'itération
        While Count < PointCount Or Iteration < IterationMax
            RndPoint = GenOnePoint()                            'génération d'un point
            Flag = False                                        'indicateur de point trouvé mis à false

            For j As Integer = 0 To RArrey.Count - 1            'Parcours du tableau de poitn valide

                Distance = Pythagore(RArrey(i), RndPoint)       'Calcul de la distance entre le point généré et le point indexé du tableau de point valide
                If Distance < DistanceMin Then                  'Si la distance n'est pas assés grand. L'indicateur est mis à true
                    Flag = True
                End If

            Next

            If Flag = False Then                                'si l'indicateur est toujours à false, alors le point est ajouté au tableau de point valide
                RArrey.Add(RndPoint)
                Count += 1                                      'Le nombre de point aléatoire trouvé est incrémenté
            End If

            Iteration += 1                                      'le compteur d'itération est incrémenté
        End While


    End Sub

End Class
