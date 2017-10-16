Imports Multi_Position
''' <summary>
''' la Classe plate génère une plaque de X puits.
''' </summary>
Public Class Plate

    Private WellsArray As List(Of Well)
    Private PHeigth As Double
    Private PWeigth As Double
    Private PClearence As Double
    Private PWellQtt As Double
    Private PWellFill As Double

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
    Public Property _PWellQtt As Double
        Get
            Return PWellQtt
        End Get
        Set(value As Double)
            PWellQtt = value
        End Set
    End Property

    ''' <summary>
    ''' Nombre de puit remplis
    ''' </summary>
    ''' <returns>PwellFill</returns>
    Public Property _PWellFill As Double
        Get
            Return PWellFill
        End Get
        Set(value As Double)
            PWellFill = value
        End Set
    End Property



    ''' <summary>
    ''' Contruction d'une plaque avec les valeur par defaut. Largeur de 10, Longueur de 10, espacement de 10
    ''' </summary>
    Public Sub New()

        PHeigth = 10
        PWeigth = 10
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
    ''' <param name="well">Le puit à ajouter</param>
    Public Sub AddWell(ByVal well As Well)

        WellsArray.Add(well)

    End Sub


End Class
