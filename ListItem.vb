Public Class ListItem
    Private _Name As String
    Private _ForeColor As Color
    Private _BackColor As Color

    Public Sub New(ByVal name As String, ByVal listcolor As Color, ByVal Listbackcolor As Color)
        _Name = name
        _ForeColor = listcolor
        _BackColor = Listbackcolor
    End Sub

    Public Sub New(ByVal name As String)
        _Name = name
        _ForeColor = Color.Black
        _BackColor = Color.White
    End Sub
    Public Sub New()
        _Name = ""
        _ForeColor = Color.Black
        _BackColor = Color.White
    End Sub
    Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal Value As String)
            _Name = Value
        End Set
    End Property

    Public Property ForeColor() As Color
        Get
            Return _ForeColor
        End Get
        Set(ByVal Value As Color)
            _ForeColor = Value
        End Set
    End Property

    Public Property BackColor() As Color
        Get
            Return _BackColor
        End Get
        Set(ByVal Value As Color)
            _BackColor = Value
        End Set
    End Property
End Class
