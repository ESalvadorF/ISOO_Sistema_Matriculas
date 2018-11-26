Public Class Alumno
    Private _Dni As String
    Private _ApePaterno As String
    Private _ApeMaterno As String
    Private _PriNombre As String
    Private _OtroNombre As String
    Private _sexo As String
    Private _fechaNacimiento As Date
    Private _Pais As String
    Private _Departamento As String
    Private _Provincia As String
    Private _Domicilio As String
    Private _Codigo As String
    Public Property Dni() As String
        Get
            Return _ApePaterno
        End Get
        Set(ByVal value As String)
            _ApePaterno = value
        End Set
    End Property
    Public Property ApePaterno() As String
        Get
            Return _ApePaterno
        End Get
        Set(ByVal value As String)
            _ApePaterno = value
        End Set
    End Property
    Public Property ApeMaterno() As String
        Get
            Return _ApeMaterno
        End Get
        Set(ByVal value As String)
            _ApeMaterno = value
        End Set
    End Property
    Public Property PriNombre() As String
        Get
            Return _PriNombre
        End Get
        Set(ByVal value As String)
            _PriNombre = value
        End Set
    End Property
    Public Property OtroNombre() As String
        Get
            Return _OtroNombre
        End Get
        Set(ByVal value As String)
            _OtroNombre = value
        End Set
    End Property
    Public Property sexo() As String
        Get
            Return _sexo
        End Get
        Set(ByVal value As String)
            _sexo = value
        End Set
    End Property

    Public Property fechaNacimiento() As Date
        Get
            Return _fechaNacimiento
        End Get
        Set(ByVal value As Date)
            _fechaNacimiento = value
        End Set
    End Property
    Public Property Pais() As String
        Get
            Return _Pais
        End Get
        Set(ByVal value As String)
            _Pais = value
        End Set
    End Property
    Public Property Departamento() As String
        Get
            Return _Departamento
        End Get
        Set(ByVal value As String)
            _Departamento = value
        End Set
    End Property
    Public Property Provincia() As String
        Get
            Return _Departamento
        End Get
        Set(ByVal value As String)
            _Provincia = value
        End Set
    End Property
    Public Property Domicilio() As String
        Get
            Return _Domicilio
        End Get
        Set(ByVal value As String)
            _Domicilio = value
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
    Public Sub New(ByVal cDni As String, ByVal cApePaterno As String, ByVal cApeMaterno As String, ByVal cPriNombre As String, ByVal cOtroNombre As String,
                   ByVal csexo As String, ByVal cfechaNacimiento As Date, ByVal cPais As String, ByVal cDepartamento As String, ByVal cProvincia As String,
                   ByVal cDomicilio As String, ByVal cCodigo As String)
        _Dni = cDni
        _ApePaterno = cApePaterno
        _ApeMaterno = cApeMaterno
        _PriNombre = cPriNombre
        _OtroNombre = cOtroNombre
        _sexo = csexo
        _fechaNacimiento = cfechaNacimiento
        _Pais = cPais
        _Departamento = cDepartamento
        _Provincia = cProvincia
        _Domicilio = cDomicilio
        _Codigo = cCodigo

    End Sub
End Class
