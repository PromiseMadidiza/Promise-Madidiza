Public Class Customer

    Private Property _Name As String
    Private Property _Surname As String
    Private Property _ID As Integer
    Private Property _Address As String
    Private Property _Contact As Integer

    Public Property Name() As String
            Get
            Return _Name
        End Get
            Set(ByVal value As String)
            _Name = value
        End Set
        End Property

    Public Property Surname() As String
        Get
            Return _Surname
        End Get
        Set(value As String)
            _Surname = value
        End Set
    End Property

    Public Property ID() As Integer
        Get
            Return _ID
        End Get
        Set(ByVal value As Integer)
            _ID = value
        End Set
    End Property

    Public Property Address() As Integer
        Get
            Return _Address
        End Get
        Set(ByVal value As Integer)
            _Address = value
        End Set
    End Property

    Public Property Contact() As Integer
        Get
            Return _Contact
        End Get
        Set(ByVal value As Integer)
            _Contact = value
        End Set
    End Property


End Class

