<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="MostrarEstacion.aspx.cs" Inherits="Prueba3.MostrarEstacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h3>Mostrar estaciones de servicio</h3>
    
    <div class="mt-5">
         <asp:GridView ID="estacionesGrid" runat="server" AutoGenerateColumns="false" EmptyDataText="Aun no se han ingresado Estaciones de Servicio." CssClass="table table-hover" OnRowCommand="estacionesGrid_RowCommand">
            <Columns>
                <asp:BoundField HeaderText="Id Estacion" DataField="IdEstacionServicio"/>
                <asp:BoundField HeaderText="Capacidad Maxima" DataField="CapacidadMaxima" />
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
