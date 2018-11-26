<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="index.aspx.vb" Inherits="ISOO_Sistema_Matriculas.index1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
           <br>  
    <div class="row">
  <div class="col-md-6">    
      <h3>Matriculas</h3>
  </div>
  <div class="col-md-1 offset-4 text-right">       
      <asp:Button   class="btn btn-success text-right" ID="Button2" runat="server" Text="Registrar" />               
  </div><br><br>
        <asp:GridView ID="GrdMatricula" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="1000px" Height="100px">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField HeaderText="Matricula" DataField="idmatricula" />
                <asp:BoundField HeaderText="Grado" DataField="grado" />
                <asp:BoundField HeaderText="Seccion" DataField="seccion" />
                <asp:BoundField HeaderText="Nivel" DataField="nivel" />
                <asp:BoundField HeaderText="Fecha " DataField="Fecha" />
                <asp:BoundField DataField="periodo" HeaderText="Periodo" />
                <asp:BoundField DataField="Alumno" HeaderText="Alumno" />
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
