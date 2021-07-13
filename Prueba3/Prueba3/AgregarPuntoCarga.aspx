<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AgregarPuntoCarga.aspx.cs" Inherits="Prueba3.AgregarPuntoCarga" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>
        <div class="card">
            <div class="card-body">
                <h3>Registrar Punto Carga</h3>
                <br />
                <div class="form-group">
                    <label for="idPtoCarga">Identificador Punto Carga</label>
                    <asp:TextBox ID="idPtoCarga" CssClass="form-control" type="Number" runat="server" placeHolder="Ingrese identificador unico" required></asp:TextBox>

                </div>
                <br />
                <div class="form-group">
                    <label for="capacidadMax">Capacidad Maxima</label>
                    <asp:TextBox ID="capacidadMax" CssClass="form-control" type="Number" runat="server" placeHolder="Ingrese Capacidad maxima" required></asp:TextBox>

                </div>
                <br />
                <div class="form-group">
                    <label for="tipoDd">Tipo</label>
                    <asp:DropDownList ID="tipoDd" CssClass="form-control" runat="server"></asp:DropDownList>
                </div>
                <br />
                <div class="form-group">
                    <label for="fechaTxt">Fecha Vencimiento</label>
                    <asp:TextBox ID="fechaTxt" CssClass="form-control" type="text" runat="server" placeHolder="Ingrese fecha de vencimiento (Formato dd-mm-aaaa)" required></asp:TextBox>
                    <%--<asp:CustomValidator ID="fechaCV" runat="server" ValidateEmptyText="true" CssClass="text-danger" ControlToValidate="fechaTxt" OnServerValidate="fechaCV_ServerValidate" ErrorMessage="CustomValidator"></asp:CustomValidator>--%>
                </div>
                <br />

                <asp:Button ID="registrarPtoBtn" runat="server" Text="Registrar" CssClass="btn btn-primary" OnClick="registrarPtoBtn_Click" />
                <br />
                <div>
                    <asp:Label ID="confirmacion" runat="server" CssClass="text-success"></asp:Label>
                </div>

            </div>
        </div>
    </div>

</asp:Content>
