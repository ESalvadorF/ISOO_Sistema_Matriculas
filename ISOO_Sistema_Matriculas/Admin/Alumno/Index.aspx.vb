Imports CapaNegocio
Public Class Index
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            mostrar()
        End If
    End Sub
    Sub mostrar()
        Dim oAlumno As New AlumnoCN
        GrdAlumno.DataSource = oAlumno.ListarTodos
        GrdAlumno.DataBind()
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Response.Redirect("/Admin/Alumno/Create.aspx")
    End Sub

    Protected Sub GrdAlumno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GrdAlumno.SelectedIndexChanged

    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Response.Redirect("/Admin/Matricula/index.aspx")
    End Sub
End Class