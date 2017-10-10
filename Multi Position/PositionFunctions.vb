''' <summary>
''' Ce module a pour but la génération de N point de coordonnées X, Y aléatoire dans une aire donnée.
''' </summary>
Module PositionFunctions

    Dim Tab As ArrayList 'Tableau recueillant toutes les position valide.
    Dim x As Double 'x est la position d'un point sur l'axe des abcisse
    Dim y As Double 'y est la position d'un point sur l'axe des ordonnées
    Dim CoteA As Integer 'CoteA est la hauteur de l'air dans laquel sont générés les points
    Dim CoteB As Integer 'Cote B est la largeur de l'air dans laquel sont générés les poitns
    Dim DistanceMax As Double 'Dsitance minimum entre chaque point


    'fonction qui configure le X d'un point
    Private Sub SetX(ByVal Xinput)
        x = Xinput
    End Sub

    'fonction qui recupère la valeur x d'un point
    Public Function GetX() As Double
        Return x
    End Function

    'fonction qui configure le y d'un point
    Private Sub SetY(ByVal Yinput)
        y = Yinput
    End Sub

    'fonction qui recupère la valeur x d'un point
    Public Function GetY() As Double
        Return y
    End Function

    'fonction qui configure la largeur de la zone recevant les points
    Public Sub SetCoteA(ByVal Ainput)
        CoteA = Ainput
    End Sub

    'fonction qui recupère la largeur de la zone recevant les points
    Public Function GetCoteA() As Double
        Return CoteA
    End Function

    'fonction qui configure la longueur de la zone recevant les points
    Public Sub SetCoteB(ByVal Binput)
        CoteB = Binput
    End Sub

    'fonction qui recupère la Longueur de la zone recevant les points
    Public Function GetCoteB() As Double
        Return CoteB
    End Function

    'fonction qui configure le X d'un point
    Private Sub SetDisMax(ByVal Dinput)
        DistanceMax = Dinput
    End Sub

    'fonction qui recupère la valeur x d'un point
    Public Function GetDistMax() As Double
        Return DistanceMax
    End Function

    ''' <summary>
    ''' Function de génération de position aléatoire pour un point
    ''' </summary>
    Public Sub PosGen()

        SetX(Rnd() * CoteA)
        SetY(Rnd() * CoteB)
    End Sub

    ''' <summary>
    ''' Function qui calcul le carré de l'hypothénuse à partir des valleur de X et Y
    ''' </summary>
    Private Function Pythagore() As Double

        Dim AdjacentA As Double
        Dim AdjacentB As Double
        Dim Hypothenuse As Double

        AdjacentA = GetX()
        AdjacentB = GetY()

        Hypothenuse = Math.Sqrt(AdjacentA ^ 2 + AdjacentB ^ 2)
        Return Hypothenuse

    End Function

    ''' <summary>
    ''' Function qui coomprez le carré de l'hypoténuse avec la distant minimum voulut entre chaque points
    ''' </summary>
    ''' <returns>retourne true si le carré de l'hyp. et supérieur à la distance minimum sinon retourne faux</returns>
    Private Function Compare() As Boolean

        Dim Dist As Double
        Dist = Pythagore()
        If Dist >= GetDistMax() Then
            Return True
        Else
            Return False
        End If

    End Function


End Module
