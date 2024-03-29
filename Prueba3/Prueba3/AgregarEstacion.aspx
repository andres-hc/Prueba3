﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AgregarEstacion.aspx.cs" Inherits="Prueba3.AgregarEstacion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>
        <div class="card">
            <div class="card-body">
                <h3>Registrar Estacion Servicio</h3>
                <br />
                <div class="form-group">
                    <label for="idEstacionNum">Identificador Estacion Servicio</label>
                    <asp:TextBox ID="idEstacionNum" CssClass="form-control" type="Number" runat="server" placeHolder="Ingrese identificador unico" required></asp:TextBox>

                </div>
                <br />
                <div class="form-group">
                    <label for="capacidadNum">Capacidad Maxima</label>
                    <asp:TextBox ID="capacidadNum" CssClass="form-control" type="Number" runat="server" placeHolder="Ingrese Capacidad maxima" required></asp:TextBox>

                </div>
                <br />

                <asp:Button ID="registrarEstBtn" runat="server" Text="Registrar" CssClass="btn btn-primary" OnClick="registrarEstBtn_Click" /><br />
                <div>
                    <asp:Label ID="confirmacion" runat="server" CssClass="text-success"></asp:Label>
                </div>

            </div>
        </div>
    </div>

</asp:Content>
