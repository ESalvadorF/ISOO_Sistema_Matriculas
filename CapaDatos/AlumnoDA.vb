Imports CapaEntidad
Imports System.Data.SqlClient
Public Class AlumnoDA
    Public Sub New()
    End Sub
    Private Shared ReadOnly _instancia As New AlumnoDA
    Public Shared ReadOnly Property Instancia() As AlumnoDA
        Get
            Return _instancia
        End Get
    End Property
    Public Function ListarTodos() As DataTable
        Dim Coleccion As New List(Of Alumno)
        Dim DTable As New DataTable
        Try
            Dim cnn As New SqlConnection(Conexion.Instancia.cadenaconexion)
            cnn.Open()
            Dim sqlcmd As New SqlCommand("ListarAlumno", cnn)
            sqlcmd.CommandType = CommandType.StoredProcedure
            Dim PaTable As SqlDataReader = sqlcmd.ExecuteReader

            With DTable
                .Columns.Add("Codigo", System.Type.GetType("System.String"))
                .Columns.Add("Apellidos", System.Type.GetType("System.String"))
                .Columns.Add("Nombres", System.Type.GetType("System.String"))
                .Columns.Add("FechaNacimiento", System.Type.GetType("System.DateTime"))
                .Columns.Add("Departamento", System.Type.GetType("System.String"))
            End With
            While PaTable.Read
                Dim newrow As DataRow = DTable.NewRow

                newrow("Codigo") = PaTable.Item(0)
                newrow("Apellidos") = PaTable.Item(1)
                newrow("Nombres") = PaTable.Item(2)
                newrow("FechaNacimiento") = PaTable.Item(3)
                newrow("Departamento") = PaTable.Item(4)
                DTable.Rows.Add(newrow)
                'Nuevo.Add(New Alumno(PaTable.Item(0), PaTable.Item(1), PaTable.Item(2), PaTable.Item(3), PaTable.Item(4)))
            End While
            cnn.Close()
            cnn.Dispose()
            sqlcmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return DTable
    End Function
    Public Function Agregar(ByVal Alumno As Alumno) As Boolean
        Try
            Dim cnn As New SqlConnection(Conexion.Instancia.cadenaconexion)
            cnn.Open()
            Dim Sqlcmd As New SqlCommand("GuardarAlumno", cnn)
            Sqlcmd.CommandType = CommandType.StoredProcedure
            Sqlcmd.Parameters.Add("@codigo", SqlDbType.VarChar, 50).Value = Alumno.Codigo
            Sqlcmd.Parameters.Add("@sexo", SqlDbType.Char, 1).Value = Alumno.sexo
            Sqlcmd.Parameters.Add("@fecha", SqlDbType.Date).Value = Alumno.fechaNacimiento
            Sqlcmd.Parameters.Add("@dni", SqlDbType.Char, 8).Value = Alumno.Dni
            Sqlcmd.Parameters.Add("@paterno", SqlDbType.VarChar, 50).Value = Alumno.ApePaterno
            Sqlcmd.Parameters.Add("@materno", SqlDbType.VarChar, 50).Value = Alumno.ApeMaterno
            Sqlcmd.Parameters.Add("@domicilio", SqlDbType.VarChar, 50).Value = Alumno.Domicilio
            Sqlcmd.Parameters.Add("@pri", SqlDbType.VarChar, 50).Value = Alumno.PriNombre
            Sqlcmd.Parameters.Add("@sec", SqlDbType.VarChar, 50).Value = Alumno.OtroNombre
            Sqlcmd.Parameters.Add("@dep", SqlDbType.VarChar, 50).Value = Alumno.Departamento
            Sqlcmd.Parameters.Add("@pro", SqlDbType.VarChar, 50).Value = Alumno.Provincia
            Sqlcmd.Parameters.Add("@pais", SqlDbType.VarChar, 50).Value = Alumno.Pais
            Sqlcmd.ExecuteNonQuery()
            cnn.Close()
            cnn.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return True
    End Function
End Class
