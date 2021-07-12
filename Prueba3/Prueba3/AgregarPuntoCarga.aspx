﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AgregarPuntoCarga.aspx.cs" Inherits="Prueba3.AgregarPuntoCarga" %>

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
                    <label for="capacidadNum">Capacidad Maxima</label>
                    <asp:TextBox ID="capacidadNum" CssClass="form-control" type="Number" runat="server" placeHolder="Ingrese Capacidad maxima" required></asp:TextBox>

                </div>
                <br />

                <asp:Button ID="registrarPtoBtn" runat="server" Text="Registrar" CssClass="btn btn-primary" onClick="registrarPtoBtn" />
                <br />
                <div>
                    <asp:Label ID="confirmacion" runat="server" CssClass="text-success"></asp:Label>
                </div>

            </div>
        </div>
    </div>

</asp:Content>
