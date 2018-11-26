Imports CapaEntidad
Imports CapaDatos
Public Class AlumnoCN
    Public Sub New()
    End Sub
    Private Shared ReadOnly _instancia As New AlumnoCN
    Public Shared ReadOnly Property Instancia() As AlumnoCN
        Get
            Return _instancia
        End Get
    End Property
    Public Function ListarTodos() As DataTable
        Return AlumnoDA.Instancia.ListarTodos
    End Function
    Public Function Insertar(ByVal alumno As Alumno) As Boolean
        Return AlumnoDA.Instancia.Agregar(alumno)
    End Function

End Class
