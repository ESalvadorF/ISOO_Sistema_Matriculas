Imports CapaEntidad
Imports CapaNegocio
Public Class Create1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim oMatricula As New MatriculaCN
        Dim oAlumno As New AlumnoCN()
        Dim ok As Boolean
        If Session("vmodoedicion") = False Then
            'Crear nuevo Cliente
            ok = oMatricula.Insertar(New Matricula(1, txtAlumno.Text, txtgrado.Text, txtSeccion.Text,
                                                txtNivel.Text, txtPeriodo.Text, txtFecha.Text))
            MsgBox("Registro Guardado")
            Response.Redirect("/Admin/Alumno/Index.aspx")
        ElseIf Session("vmodoedicion") = True Then

        End If
    End Sub
End Class