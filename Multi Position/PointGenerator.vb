Public Class RandomPointArea

    Private Largeur As Double       'largeur de la zone contenant les points 
    Private Longueur As Double      'longeur de la zone contenant les points
    Private DistanceMin As Double   'distance minimum séparant les points
    Private PointCount As Double    'Nombre de poitn dans la zone


    Private RndPoint As Point()     'Point aléatoire   
    Private RArrey As ArrayList()   'tableau de point contenant les points

    ''' <summary>
    ''' accès au Tableau de résultat
    ''' </summary>
    ''' <returns>Retourne un tableau du type arraylist</returns>
    Public Property ResultArray As ArrayList()
        Get
            Return RArrey
        End Get
        Set(value As ArrayList())
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
    ''' Fonction qui génére un point et le stock dans RndPoint
    ''' </summary>
    Private Sub GenOnePoint()
        RndPoint.SetValue = 

    End Sub


End Class
