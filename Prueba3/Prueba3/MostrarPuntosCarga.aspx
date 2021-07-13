<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="MostrarPuntosCarga.aspx.cs" Inherits="Prueba3.MostrarPuntosCarga" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <h3>Mostrar puntos carga</h3>
    <br />
    <div>
        <label>Filtrar por tipo</label><br />
        <asp:DropDownList ID="tipoDd" AutoPostBack="true" runat="server" OnSelectedIndexChanged="tipoDd_SelectedIndexChanged" Enabled="true">
            <asp:ListItem Value="" Selected="True" Text="Todos"></asp:ListItem>
            <asp:ListItem Value="1" Text="Gasolina"></asp:ListItem>
            <asp:ListItem Value="2" Text="Electrico"></asp:ListItem>
        </asp:DropDownList>
    </div>
               
    <div class="mt-5">
        <asp:GridView ID="puntosGrid" runat="server" AutoGenerateColumns="false" EmptyDataText="Aun no se han ingresado puntos de carga" 
            CssClass="table table-hover" 
            OnRowEditing="puntosGrid_RowEditing" 
            OnRowUpdating="puntosGrid_RowUpdating"
            OnRowDataBound="puntosGrid_RowDataBound"
            DataKeyNames="Id">
            <Columns>
                <asp:TemplateField HeaderText="Id">
                    <ItemTemplate>
                        <asp:Label ID="id1" runat="server" Text='<% # Bind("id") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:Label ID="id2" type="number" runat="server" Text='<% # Bind("id") %>'></asp:Label>
                    </EditItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Tipo">
                    <ItemTemplate>
                        <asp:Label ID="tipo1" runat="server" Text='<% # Bind("tipoTxt") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="tipo2" runat="server" Text='<% # Bind("tipoTxt") %>'></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Capacidad Maxima">
                    <ItemTemplate>
                        <asp:Label ID="cap1" runat="server" Text='<% # Bind("capacidadMaxima") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="cap2" runat="server" type="number" Text='<% # Bind("capacidadMaxima") %>'></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Fecha Vencimiento">
                    <ItemTemplate>
                        <asp:Label ID="fv1" runat="server" Text='<% # Bind("fechaVencimiento") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="fv2" runat="server" Text='<% # Bind("fechaVencimiento") %>'></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:CommandField ButtonType="Button" ShowEditButton="true" />

            </Columns>
        </asp:GridView>
    </div>

</asp:Content>
