''' <summary>
''' Ce module a pour but la génération de N point de coordonnées X, Y aléatoire dans une aire donnée.
''' </summary>
Module DraftPositionFunctions


    Dim NbrOfPosToFind As Integer
    Dim NbrOfPull As Integer = 100
    Dim CoteA As Integer 'CoteA est la hauteur de l'air dans laquel sont générés les points
    Dim CoteB As Integer 'Cote B est la largeur de l'air dans laquel sont générés les poitns
    Dim DistanceMin As Double 'Dsitance minimum entre chaque point
    Dim RndPoint As New Point 'Point XY aléatoire
    Dim ResulteTables As New ArrayList() 'collection de point XY correspondant aux positions finals

    Public Sub ResetResulteTable()
        ResulteTables.Clear()
    End Sub

    'Fonction permettant de recupé un point de la tableau des résultat
    Public Function IndexResultTable(ByVal i) As Point
        Return ResulteTables(i)
    End Function

    'Fonction qui retourne le nombre de point trouvés
    Public Function GetResultTableSize() As Integer
        Return ResulteTables.Count
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
    Public Sub SetDisMin(ByVal Dinput)
        DistanceMin = Dinput
    End Sub

    'fonction qui recupère la valeur x d'un point
    Public Function GetDistMin() As Double
        Return DistanceMin
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
    ''' Function qui génère un position X Y aléatoire
    ''' </summary>
    Public Sub XYGenerator()
        RndPoint.X = (Rnd() * CoteA)
        RndPoint.Y = (Rnd() * CoteB)
    End Sub

    ''' <summary>
    ''' Function qui calcul le carré de l'hypothénuse à partir des valleur de X et Y
    ''' </summary>
    Private Function Pythagore(ByVal CurrentPos As Point, ByVal TestingPos As Point) As Double

        Dim AdjacentA As Double
        Dim AdjacentB As Double
        Dim Hypothenuse As Double

        AdjacentA = CurrentPos.X - TestingPos.X
        AdjacentB = CurrentPos.Y - TestingPos.Y


        Hypothenuse = Math.Sqrt(AdjacentA ^ 2 + AdjacentB ^ 2)
        Return Hypothenuse

    End Function

    ''' <summary>
    ''' Function qui coomprez le carré de l'hypoténuse avec la distant minimum voulut entre chaque points
    ''' </summary>

    Private Sub CompareAll()

        Dim Distance As Double 'Distance entre 2 point

        For j As Integer = 0 To ResulteTables.Count
            Distance = Pythagore(ResulteTables(j), RndPoint)
            If Distance >= DistanceMin Then
                ResulteTables.Add(RndPoint)
            End If
        Next

    End Sub

    Public Sub Main_FindPoints()
        Dim i As Integer = 0
        XYGenerator()
        ResulteTables.Add(RndPoint)

        While (ResulteTables.Count < NbrOfPosToFind)
            XYGenerator()
            CompareAll()
            i += 1
        End While

    End Sub



End Module
