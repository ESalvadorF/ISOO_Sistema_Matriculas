Imports CapaNegocio
Public Class index1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            mostrar()
        End If
    End Sub
    Sub mostrar()
        Dim oAlumno As New MatriculaCN
        GrdMatricula.DataSource = oAlumno.ListarTodos
        GrdMatricula.DataBind()
    End Sub

    Protected Sub GrdMatricula_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GrdMatricula.SelectedIndexChanged

    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Response.Redirect("/Admin/Matricula/Create.aspx")
    End Sub
End Class