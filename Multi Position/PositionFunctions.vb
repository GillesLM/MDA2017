''' <summary>
''' Ce module a pour but la génération de N point de coordonnées X, Y aléatoire dans une aire donnée.
''' </summary>
Module PositionFunctions
    Dim NbrOfPosToFind As Integer
    Dim TabPos(2, 10000) As Double 'Tableau recueillant toutes les positions générées.
    Dim CoteA As Integer 'CoteA est la hauteur de l'air dans laquel sont générés les points
    Dim CoteB As Integer 'Cote B est la largeur de l'air dans laquel sont générés les poitns
    Dim DistanceMax As Double 'Dsitance minimum entre chaque point
    Dim Point As New Point

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


    'fonction permettant la récupération d'un valeur du tableau
    Public Function GetTabPos(ByVal i As Integer, ByVal j As Integer) As Double
        Return TabPos(i, j)
    End Function

    'fonction qui return la point génér dans le pool
    Public Function GetTabPosSize()
        Return TabPos.GetLength(1)
    End Function

    'fonction qui configure le nombre de point à trouver
    Public Sub SetNbrOfPosToFind(ByVal Posinput)
        NbrOfPosToFind = Posinput
    End Sub

    'fonction qui recupère la valeur du nombre de point à trouver
    Public Function GetNbrOfPosToFind() As Double
        Return NbrOfPosToFind
    End Function

    ''' <summary>
    ''' Function de génération des position aléatoire pour un point et les stocke dans TabPos
    ''' </summary>
    Public Sub PoolOfPosGenenerator()
        For i As Integer = 0 To TabPos.GetLength(1) - 1

            TabPos(0, i) = (Rnd() * CoteA)
            TabPos(1, i) = (Rnd() * CoteB)

        Next
    End Sub

    ''' <summary>
    ''' Function qui génère un position X Y aléatoire
    ''' </summary>
    Public Sub XYGenenerator()
        Point.X = (Rnd() * CoteA)
        Point.Y = (Rnd() * CoteB)
    End Sub

    ''' <summary>
    ''' Function qui calcul le carré de l'hypothénuse à partir des valleur de X et Y
    ''' </summary>
    Private Function Pythagore(ByVal XValidPos As Double, ByVal YValidPos As Double) As Double

        Dim AdjacentA As Double
        Dim AdjacentB As Double
        Dim Hypothenuse As Double

        AdjacentA = Point.X - XValidPos
        AdjacentB = Point.Y - YValidPos


        Hypothenuse = Math.Sqrt(AdjacentA ^ 2 + AdjacentB ^ 2)
        Return Hypothenuse

    End Function

    ''' <summary>
    ''' Function qui coomprez le carré de l'hypoténuse avec la distant minimum voulut entre chaque points
    ''' </summary>

    Private Sub Compare()



    End Sub



End Module
