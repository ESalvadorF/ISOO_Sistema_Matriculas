<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Create.aspx.vb" Inherits="ISOO_Sistema_Matriculas.Create" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br>
<div class="row">
    <div class="col-md-6">    
        <h3>Registro Alumno</h3>
    </div>
    <div class="col-md-1 offset-5 text-right">             
                <asp:Button ID="Button1"  class="btn btn-success text-right" runat="server" Text="Guardar" />
                     
    </div><br><br>
</div>
<h4>Alumno</h4>
<div class="row">
    <div class="col-md-6">
        <label for="">DNI</label>       
        <asp:TextBox ID="txtdni" runat="server" Width="269px"></asp:TextBox><br>
        <label for="">Apellido Paterno</label>       
        <asp:TextBox ID="txtpaterno" runat="server"></asp:TextBox><br>
        <label for="">Apellido Materno</label>       
        <asp:TextBox ID="txtmaterno" runat="server"></asp:TextBox><br>
        <label for="">Primer Nombre</label>       
        <asp:TextBox ID="txtpri" runat="server" Width="195px"></asp:TextBox><br>
        <label for="">Segundo Nombre</label>       
        <asp:TextBox ID="txtsec" runat="server"></asp:TextBox><br>
        <label for="">Sexo</label>       
        <asp:TextBox ID="txtsex" runat="server" Width="267px"></asp:TextBox><br>
    </div>
    <div class="col-md-6">   
        <label for="">Codigo</label>       
       <asp:TextBox ID="txtcodigo" runat="server" Width="253px"></asp:TextBox><br>    
        <label for="">Fecha Nacimiento</label>       
        <asp:TextBox ID="txtfecha" runat="server"></asp:TextBox><br>
        <label for="">Pais</label>       
        <asp:TextBox ID="txtpais" runat="server" Width="275px"></asp:TextBox><br> 
        <label for="">Departamento</label>       
        <asp:TextBox ID="txtdep" runat="server" Width="201px"></asp:TextBox><br>
        <label for="">Provincia</label>       
        <asp:TextBox ID="txtpro" runat="server" Width="235px"></asp:TextBox><br>
        <label for="">Domicilio</label>       
        <asp:TextBox ID="txtdom" runat="server" Width="230px"></asp:TextBox><br>             
        </div>
    </div>
</asp:Content>
