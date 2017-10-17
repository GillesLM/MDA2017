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
            PWellFilled = WellsArray.Count
            Return PWellFilled
        End Get

    End Property



    ''' <summary>
    ''' Contruction d'une plaque avec les valeur par defaut. Largeur de 10, Longueur de 10, espacement de 10
    ''' </summary>
    Public Sub New()
        WellsArray.Add(New Well())
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

        WellsArray.Add(Puit)
        PHeigth = Largeur
        PWeigth = Longueur
        PWellQtt = Largeur * Longueur
        PClearence = Entrax

    End Sub

    ''' <summary>
    ''' Récupère un puit à l'index indiqué
    ''' </summary>
    ''' <param name="index">index du puits dans la liste des puits</param>
    ''' <returns>Type Well</returns>
    Public Function IndexPlate(ByVal index As Integer) As Well

        Return WellsArray(index)

    End Function

    ''' <summary>
    ''' Récupère les coordonnées d'un puits en fonction de sont ID
    ''' </summary>
    ''' <param name="ID">ID du puit</param>
    ''' <returns>type point</returns>
    Public Function IndexPlate(ByVal ID As String) As Point

        Dim temp As Well
        temp = WellsArray.Find(Function(x) x._ID.Contains(ID))
        Return temp._Coordonates


    End Function

    ''' <summary>
    ''' Supprime tous les puit remplis de la plaque
    ''' </summary>
    Public Sub ClearPLate()

        WellsArray.Clear()

    End Sub
    ''' <summary>
    ''' Supprime un puit dans la collection de la plaque en renseignant son ID
    ''' </summary>
    ''' <param name="ID">ID du puit</param>
    ''' <returns>True : le puit a été retiré</returns>
    Public Function DeleteWell(ByVal ID As String) As Boolean

        Dim temp As New Well()

        temp = WellsArray.Find(Function(x) x._ID.Contains(ID))
        Return WellsArray.Remove(temp)

    End Function

    ''' <summary>
    ''' Supprime un puit de la colllection de la plaque en renseignant le puit
    ''' </summary>
    ''' <param name="Well">le puit a retirer</param>
    ''' <returns>True si le puit a été retiré</returns>
    Public Function DeleteWell(ByVal Well As Well) As Boolean

        Return WellsArray.Remove(Well)

    End Function

    ''' <summary>
    '''  Supprime un puit de la collection de la plaque en renseignant ses coordonnée dans la plaque
    ''' </summary>
    ''' <param name="X">Coordonnée X du puit a supprimer</param>
    ''' <param name="Y">Coordonnée Y du puit a supprimer</param>
    ''' <returns></returns>
    Public Function DeleteWell(ByVal X As Integer, ByVal Y As Integer) As Boolean

        Dim coord As Point
        coord.X = X
        coord.Y = Y

        Dim temp As New Well()

        temp = WellsArray.Find(Function(f) f._Coordonates.Equals(coord))
        Return WellsArray.Remove(temp)

    End Function

    ''' <summary>
    ''' Ajout un puit à la plaque
    ''' </summary>
    ''' <param name="Twell">Le puit à ajouter</param>
    Public Sub AddWell(ByVal Twell As Well)

        WellsArray.Add(Twell)

    End Sub

    ''' <summary>
    ''' Génération de "WellNbr" puits dans une plaque.
    ''' </summary>
    ''' <param name="BaseWell">Puit sur lequel se base la generation</param>
    ''' <param name="WellNbr">Nombre de puit a générer</param>
    Public Sub GenWells(ByVal BaseWell As Well, ByVal WellNbr As Integer)



        Dim Coord As New Point(0, 0)
        Dim Columms As Integer 'nombre de colonnes
        Dim line As Integer 'numéro de la ligne du dernier puit

        Columms = WellNbr \ 8
        line = WellNbr - (Columms * 8)

        'Varaible de comptage
        Dim Xcounter As Integer = 0 'la position de départ sur l'axe X sera toujours la première colone : 0
        Dim Ycounter As Integer = 0 'la position de départ sur l'axe Y sera toujours la deuxième ligne : 1, car la première ligne est donnée par l'utilisateur
        Dim LastPos As Integer = 0 'Varaible de vérification du nombre de puits parcourus.

        'déplacement vers une colonne
        While Xcounter <= Columms


            'déplacement vers une ligne
            While Ycounter <= 7 And LastPos < WellNbr

                Coord.X = Xcounter
                Coord.Y = Ycounter

                BaseWell._Coordonates = Coord
                BaseWell._ID = ("ID" & LastPos)
                WellsArray.Add(BaseWell)


                Ycounter += 1
                LastPos += 1


            End While

            'remise a 0 du conteur de ligne et passage à la colonne suivante
            Ycounter = 0
            Xcounter += 1
        End While

    End Sub

End Class






