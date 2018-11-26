Public Class Matricula
    Private _Codigo As String
    Private _Grado As String
    Private _Seccion As String
    Private _Periodo As String
    Private _Nivel As String
    Private _fecha As Date
    Private _IdMatricula As Integer
    Public Property IdMatricula() As Integer
        Get
            Return _IdMatricula
        End Get
        Set(ByVal value As Integer)
            _IdMatricula = value
        End Set
    End Property
    Public Property Codigo() As String
        Get
            Return _Codigo
        End Get
        Set(ByVal value As String)
            _Codigo = value
        End Set
    End Property
    Public Property Grado() As String
        Get
            Return _Grado
        End Get
        Set(ByVal value As String)
            _Grado = value
        End Set
    End Property
    Public Property Seccion() As String
        Get
            Return _Seccion
        End Get
        Set(ByVal value As String)
            _Seccion = value
        End Set
    End Property
    Public Property Periodo() As String
        Get
            Return _Periodo
        End Get
        Set(ByVal value As String)
            _Periodo = value
        End Set
    End Property
    Public Property Nivel() As String
        Get
            Return _Nivel
        End Get
        Set(ByVal value As String)
            _Nivel = value
        End Set
    End Property

    Public Property fecha() As Date
        Get
            Return _fecha
        End Get
        Set(ByVal value As Date)
            _fecha = value
        End Set
    End Property
    Public Sub New(ByVal cIdMatricula As Integer, ByVal cCodigo As String, ByVal cGrado As String, ByVal cSeccion As String, ByVal cPeriodo As String,
                   ByVal cNivel As String, ByVal cfecha As Date)
        _IdMatricula = cIdMatricula
        _Codigo = cCodigo
        _Grado = cGrado
        _Seccion = cSeccion
        _Periodo = cPeriodo
        _Nivel = cNivel
        _fecha = cfecha

    End Sub
End Class
