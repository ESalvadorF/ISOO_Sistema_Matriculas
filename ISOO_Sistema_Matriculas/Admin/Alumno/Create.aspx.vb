Imports CapaEntidad
Imports CapaNegocio

Public Class Create
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim oAlumno As New AlumnoCN
        Dim ok As Boolean
        If Session("vmodoedicion") = False Then
            'Crear nuevo Cliente
            ok = oAlumno.Insertar(New Alumno(txtdni.Text, txtpaterno.Text, txtmaterno.Text, txtpri.Text, txtsec.Text, txtsex.Text, txtfecha.Text,
                                            txtpais.Text, txtdep.Text, txtpro.Text, txtdom.Text, txtcodigo.Text))
            MsgBox("Registro Guardado")
            Response.Redirect("/Admin/Alumno/Index.aspx")
        ElseIf Session("vmodoedicion") = True Then

        End If
    End Sub
End Class