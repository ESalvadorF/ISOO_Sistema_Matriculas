Imports CapaEntidad
Imports CapaDatos
Public Class MatriculaCN
    Public Sub New()
    End Sub
    Private Shared ReadOnly _instancia As New MatriculaCN
    Public Shared ReadOnly Property Instancia() As MatriculaCN
        Get
            Return _instancia
        End Get
    End Property
    Public Function ListarTodos() As DataTable
        Return MatriculaDA.Instancia.ListarTodos
    End Function
    Public Function Insertar(ByVal matricula As Matricula) As Boolean
        Return MatriculaDA.Instancia.Agregar(matricula)
    End Function
End Class
