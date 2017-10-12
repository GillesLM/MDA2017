Public Class PointGenerator
    Private OnePoint As Point()
    Private RArrey As ArrayList()

    'Accès au prio
    Public Property Point As Point()
        Get
            Return OnePoint
        End Get
        Set(value As Point())
            OnePoint = value
        End Set
    End Property

    Public Property ResultArray1 As ArrayList()
        Get
            Return RArrey
        End Get
        Set(value As ArrayList())
            RArrey = value
        End Set
    End Property



End Class
