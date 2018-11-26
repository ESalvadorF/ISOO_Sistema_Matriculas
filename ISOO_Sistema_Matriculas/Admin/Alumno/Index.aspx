<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Index.aspx.vb" Inherits="ISOO_Sistema_Matriculas.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <br>  
    <div class="row">
  <div class="col-md-6">    
      <h3>Alumnos</h3>
  </div>
  <div class="col-md-1 offset-4 text-right">       
      <asp:Button ID="Button2"  class="btn btn-success text-right"  runat ="server" Height="34px" Text="Matricular" />
      <asp:Button   class="btn btn-success text-right" ID="Button1" runat="server" Text="Registrar" Width="85px" />               
  </div><br><br>
        <asp:GridView ID="GrdAlumno" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="1000px" Height="100px">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField HeaderText="Codigo" DataField="Codigo" />
                <asp:BoundField HeaderText="Apellidos" DataField="Apellidos" />
                <asp:BoundField HeaderText="Nombres" DataField="Nombres" />
                <asp:BoundField HeaderText="Fecha Nacimiento" DataField="FechaNacimiento" />
                <asp:BoundField HeaderText="Departamento" DataField="Departamento" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        <br>
</div>
</asp:Content>
