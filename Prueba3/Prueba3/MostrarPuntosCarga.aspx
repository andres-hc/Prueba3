<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="MostrarPuntosCarga.aspx.cs" Inherits="Prueba3.MostrarPuntosCarga" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="mt-5">
         <asp:GridView ID="ptosCargaGrid" runat="server" AutoGenerateColumns="false" EmptyDataText="Aun no se han ingresado Estaciones de Servicio." CssClass="table table-hover" OnRowCommand="ptosCargaGrid_RowCommand">
            <Columns>
                <asp:BoundField HeaderText="ID" DataField="Id"/>
                <asp:BoundField HeaderText="Tipo" DataField="Tipo" />
                <asp:BoundField HeaderText="Capacidad Maxima" DataField="CapacidadMaxima" />
                <asp:BoundField HeaderText="Fecha Vencimiento" DataField="FechaVencimiento" />
                <asp:TemplateField HeaderText="Eliminar">
                    <ItemTemplate>
                           <asp:Button runat="server" Text="ELIMINAR"
                               CssClass="btn btn-danger" CommandName="eliminar" 
                               CommandArgument='<%# Eval("IdEstacionServicio") %>'></asp:Button>

                    </ItemTemplate>
                </asp:TemplateField>            
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
