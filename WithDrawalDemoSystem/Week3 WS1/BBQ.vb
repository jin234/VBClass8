Public Class BBQ
    Private _ppl As Integer
    Private _basePrice As Integer
    Private _DisPrice As Double

    Public Sub New()
        _ppl = 0
        _basePrice = 0
        _DisPrice = 0
    End Sub

    Public Sub New(ppl As Integer, basePrice As Integer, DisPrice As Double)
        _ppl = ppl
        _basePrice = basePrice
        _DisPrice = DisPrice
    End Sub

    '--------------------------------------------------'
    Public Property ppl As Integer
        Get
            Return _ppl
        End Get
        Set(value As Integer)
            _ppl = value
        End Set
    End Property

    Public Property basePrice As Integer
        Get
            Return _basePrice
        End Get
        Set(value As Integer)
            _basePrice = value
        End Set
    End Property

    Public Property disPrice As Double
        Get
            Return _DisPrice
        End Get
        Set(value As Double)
            _DisPrice = value
        End Set
    End Property
    '--------------------------------------------------'
    Public Function checkppl() As Boolean
        Return _ppl <= 0
    End Function
    '--------------------------------------------------------------------'
    Public Function calculate() As Double
        Return _ppl * _basePrice
    End Function

    Public Function calculateD5() As Double
        Return _basePrice - ((_basePrice * 5) / 100)
    End Function


    Public Function calculateD10() As Double
        Return _basePrice - ((_basePrice * 10) / 100)
    End Function
End Class
