<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Flyweight_Pattern.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Venta online</title>
    <link rel="stylesheet" type="text/css" href="~/Styles/stylesheet.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="principal">
            <asp:LinkButton ID="NuevoLibro" runat="server" Text="Nuevo" OnClick="NuevoLibro_Click" />
            <div class="secundario">
                <asp:Table ID="TableBooks" runat="server">

                </asp:Table>

                <!--
                <asp:Label ID="lblTitulo" runat="server" Text="Titulo: " CssClass="label"></asp:Label>
                <br />

                <asp:Label ID="lblAutor" runat="server" Text="Autor: " CssClass="label"></asp:Label>
                <br />

                <asp:Label ID="lblCategoria" runat="server" Text="Categoria: " CssClass="label"></asp:Label>
                <br />

                <asp:Label ID="lblExtras" runat="server" Text="Extras: " CssClass="label"></asp:Label>

                <asp:Label ID="lblPrecio" runat="server" Text="precio: " CssClass="priceElement"></asp:Label>
                -->
            </div>
        </div>
    </form>
</body>
</html>