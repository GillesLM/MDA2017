Imports Multi_Position
''' <summary>
''' la Classe plate génère une plaque de X puits.
''' </summary>
Public Class Plate

    Private WellsList As New List(Of Well)
    Private PHeigth As Double = 2
    Private PWeigth As Double = 2
    Private PClearence As Double = 1


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
    ''' Collection de puits remplis dans la plaque
    ''' </summary>
    ''' <returns>List de puit</returns>
    Public Property _WellsList As List(Of Well)
        Get
            Return WellsList
        End Get
        Set(value As List(Of Well))
            WellsList = value
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
    ''' <param name="Largeur">Largeur de la plaque en nombre de puits</param>
    ''' <param name="Longueur">Longeur de la plaque en nombre de puits</param>
    ''' <param name="Entrax">Entrax entre les puits en mm</param>
    Public Sub New(ByVal Largeur As Double, ByVal Longueur As Double, ByVal Entrax As Double)

        PHeigth = Largeur
        PWeigth = Longueur
        PClearence = Entrax

    End Sub





    ''' <summary>
    ''' Génération d'un puit au coordonnée X Y
    ''' </summary>
    ''' <param name="X">coordonnée X du puit</param>
    ''' <param name="Y">coordonnée Y du puit</param>
    ''' <returns>rend un puit</returns>
    Private Function Generate1Well(ByVal X As Double, ByVal Y As Double, ByVal CountOfPoint As Integer) As Well

        Dim Well As New Well(6360, 6360, 250, CountOfPoint, X, Y)
        Well._ID = "ID" & WellsList.Count
        Well.GenPoints()
        Return Well

    End Function

    ''' <summary>
    ''' Remplis un nombre de puits demander avec un nombre de point demandé
    ''' </summary>
    ''' <param name="CountOfWell">Nombre de puits demandés</param>
    ''' <param name="CountOfPoints">Nombre de points dmandés</param>
    Public Sub FillWells(ByVal CountOfWell As Integer, ByVal CountOfPoints As Integer)

        Dim X As Integer = 0
        Dim Y As Integer = 0

        For i As Integer = 1 To CountOfWell

            If i Mod 8 <> 0 Then

                WellsList.Add(Generate1Well(X, Y, CountOfPoints))
                Y += 1

            Else

                WellsList.Add(Generate1Well(X, Y, CountOfPoints))

                Y = 0
                X += 1

            End If

        Next



    End Sub

    ''' <summary>
    ''' Vide toutes les puits de la plaque
    ''' </summary>
    Public Sub ClearPlate()
        WellsList.Clear()
    End Sub

End Class






