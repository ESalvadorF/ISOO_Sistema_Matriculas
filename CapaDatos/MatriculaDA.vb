Imports CapaEntidad
Imports System.Data.SqlClient
Public Class MatriculaDA
    Public Sub New()
    End Sub
    Private Shared ReadOnly _instancia As New MatriculaDA
    Public Shared ReadOnly Property Instancia() As MatriculaDA
        Get
            Return _instancia
        End Get
    End Property
    Public Function ListarTodos() As DataTable
        Dim Coleccion As New List(Of Matricula)
        Dim DTable As New DataTable
        Try
            Dim cnn As New SqlConnection(Conexion.Instancia.cadenaconexion)
            cnn.Open()
            Dim sqlcmd As New SqlCommand("ListarMatricula", cnn)
            sqlcmd.CommandType = CommandType.StoredProcedure
            Dim PaTable As SqlDataReader = sqlcmd.ExecuteReader

            With DTable
                .Columns.Add("idmatricula", System.Type.GetType("System.String"))
                .Columns.Add("grado", System.Type.GetType("System.String"))
                .Columns.Add("seccion", System.Type.GetType("System.String"))
                .Columns.Add("nivel", System.Type.GetType("System.String"))
                .Columns.Add("fecha", System.Type.GetType("System.DateTime"))
                .Columns.Add("periodo", System.Type.GetType("System.String"))
                .Columns.Add("alumno", System.Type.GetType("System.String"))
            End With
            While PaTable.Read
                Dim newrow As DataRow = DTable.NewRow

                newrow("idmatricula") = PaTable.Item(0)
                newrow("grado") = PaTable.Item(1)
                newrow("seccion") = PaTable.Item(2)
                newrow("nivel") = PaTable.Item(3)
                newrow("fecha") = PaTable.Item(4)
                newrow("periodo") = PaTable.Item(5)
                newrow("alumno") = PaTable.Item(6)
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
    Public Function Agregar(ByVal matricula As Matricula) As Boolean
        Try
            Dim cnn As New SqlConnection(Conexion.Instancia.cadenaconexion)
            cnn.Open()
            Dim Sqlcmd As New SqlCommand("GuardarMatricula", cnn)
            Sqlcmd.CommandType = CommandType.StoredProcedure
            Sqlcmd.Parameters.Add("@grado", SqlDbType.VarChar, 50).Value = matricula.Grado
            Sqlcmd.Parameters.Add("@seccion", SqlDbType.Date).Value = matricula.Seccion
            Sqlcmd.Parameters.Add("@periodo", SqlDbType.VarChar, 50).Value = matricula.Periodo
            Sqlcmd.Parameters.Add("@nivel", SqlDbType.VarChar, 50).Value = matricula.Nivel
            Sqlcmd.Parameters.Add("@codigo", SqlDbType.Char, 10).Value = matricula.Codigo
            cnn.Close()
            cnn.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return True
    End Function
End Class
