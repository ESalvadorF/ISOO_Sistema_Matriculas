<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Create.aspx.vb" Inherits="ISOO_Sistema_Matriculas.Create1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
       <br>
<div class="row">
    <div class="col-md-6">    
        <h3>Registro Matricula</h3>
    </div>
    <div class="col-md-1 offset-5 text-right">             
                <asp:Button ID="Button1"  class="btn btn-success text-right" runat="server" Text="Guardar" />
                     
    </div><br><br>
</div>
<h4>Alumno</h4>
<div class="row">
    <div class="col-md-6">
        <label for="">Grado</label>       
        <asp:TextBox ID="txtgrado" runat="server" Width="269px"></asp:TextBox><br>
        <label for="">Seccion</label>       
        <asp:TextBox ID="txtSeccion" runat="server"></asp:TextBox><br>
        <label for="">Alumno</label>       
        <asp:TextBox ID="txtAlumno" runat="server"></asp:TextBox><br>        
    </div>
    <div class="col-md-6">   
        <label for="">Periodo</label>       
       <asp:TextBox ID="txtPeriodo" runat="server" Width="253px"></asp:TextBox><br>    
        <label for="">Nivel</label>       
        <asp:TextBox ID="txtNivel" runat="server"></asp:TextBox><br>
        <label for="">Fecha</label>       
        <asp:TextBox ID="txtFecha" runat="server" Width="275px"></asp:TextBox><br>
                   
        </div>
    </div>
</asp:Content>
