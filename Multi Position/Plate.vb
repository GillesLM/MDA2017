Imports Multi_Position
''' <summary>
''' la Classe plate génère une plaque de X puits.
''' </summary>
Public Class Plate

    Private WellsArray As New List(Of Well)
    Private PHeigth As Double = 2
    Private PWeigth As Double = 2
    Private PClearence As Double = 1
    Private PWellQtt As Double = 4
    Private PWellFilled As Double = 0

    ''' <summary>
    ''' Longueur de la plaque en nombre de puits
    ''' </summary>
    ''' <returns>PHeigth</returns>
    Public Property _PHeigth As Double
        Get
            Return PHeigth
        End Get
        Set(value As Double)
            PHeigth = value
        End Set
    End Property

    ''' <summary>
    ''' Largeur de la plaque en nombre de puits
    ''' </summary>
    ''' <returns>Pweigth</returns>
    Public Property _PWeigth As Double
        Get
            Return PWeigth
        End Get
        Set(value As Double)
            PWeigth = value
        End Set
    End Property

    ''' <summary>
    ''' Ecart entre les centre de chaque puits
    ''' </summary>
    ''' <returns>Pclearance</returns>
    Public Property _PClearence As Double
        Get
            Return PClearence
        End Get
        Set(value As Double)
            PClearence = value
        End Set
    End Property

    ''' <summary>
    ''' Nombre totale de puit contenu par la plaque
    ''' </summary>
    ''' <returns>PWellQtt</returns>
    Public ReadOnly Property _PWellQtt As Double
        Get
            Return PHeigth * PWeigth
        End Get
    End Property

    ''' <summary>
    ''' Nombre de puit remplis
    ''' </summary>
    ''' <returns>PwellFill</returns>
    Public ReadOnly Property _PWellFilled As Double
        Get
            PWellFilled = _WellsArray.Count
            Return PWellFilled
        End Get

    End Property

    ''' <summary>
    ''' Collection de puits remplis dans la plaque
    ''' </summary>
    ''' <returns>List de puit</returns>
    Public Property _WellsArray As List(Of Well)
        Get
            Return WellsArray
        End Get
        Set(value As List(Of Well))
            WellsArray = value
        End Set
    End Property


    ''' <summary>
    ''' Contruction d'une plaque avec les valeur par defaut. Largeur de 10, Longueur de 10, espacement de 10
    ''' </summary>
    Public Sub New()
        _WellsArray.Add(New Well())
        PHeigth = 10
        PWeigth = 10
        PWellQtt = 100
        PClearence = 1

    End Sub

    ''' <summary>
    ''' Contruction d'une plaque de puits. Largeur et longeur en nombre de puits
    ''' </summary>
    ''' <param name="Puit">Variable contenant les caractérisques du premier puit : coin gauche côté µscope</param>
    ''' <param name="Largeur">Largeur de la plaque en nombre de puits</param>
    ''' <param name="Longueur">Longeur de la plaque en nombre de puits</param>
    ''' <param name="Entrax">Entrax entre les puits en mm</param>
    Public Sub New(ByVal Puit As Well, ByVal Largeur As Double, ByVal Longueur As Double, ByVal Entrax As Double)

        _WellsArray.Add(Puit)
        PHeigth = Largeur
        PWeigth = Longueur
        PWellQtt = Largeur * Longueur
        PClearence = Entrax

    End Sub

    Public Sub GenerateWells(ByVal WellNbr As Integer)

        'Variable utilisateur
        Dim Columms As Integer 'nombre de colonnes
        Dim line As Integer 'numéro de la ligne du dernier puit

        'calcul de la position du dernier point et du nombre de colonne

        Columms = WellNbr \ 8
        line = WellNbr - (Columms * 8)

        'Varaible de comptage
        Dim Xcounter As Integer = 0 'la position de départ sur l'axe X sera toujours la première colone : 0
        Dim Ycounter As Integer = 0 'la position de départ sur l'axe Y sera toujours la deuxième ligne : 1, car la première ligne est donnée par l'utilisateur
        Dim LastPos As Integer = 0 'Varaible de vérification du nombre de puits parcourus.

        While Xcounter <= Columms


            'déplacement vers une ligne
            While Ycounter <= 7 And LastPos < WellNbr

                WellsArray.Add(GenWell(Xcounter, Ycounter))

                'passage à la ligne suivante
                Ycounter += 1
                LastPos += 1

            End While

            'remise a 0 du conteur de ligne et passage à la colonne suivante
            Ycounter = 0
            Xcounter += 1
        End While


    End Sub

    ''' <summary>
    ''' Génération d'un puit au coordonnée X Y
    ''' </summary>
    ''' <param name="X">coordonnée X du puit</param>
    ''' <param name="Y">coordonnée Y du puit</param>
    ''' <returns>rend un puit</returns>
    Private Function GenWell(ByVal X As Double, ByVal Y As Double) As Well

        Dim Well As New Well(6000, 6000, 250, 10, X, Y)
        Well._ID = "ID" & WellsArray.Count
        Well.GenPoints()
        Return Well

    End Function

End Class






