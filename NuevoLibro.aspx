<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NuevoLibro.aspx.cs" Inherits="Flyweight_Pattern.NuevoLibro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Nuevo Libro</title>
    <link rel="stylesheet" type="text/css" href="./Styles/stylesheet.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="secundario">
            <asp:Label ID="lblTitulo" runat="server" Text="Titulo: " CssClass="label"></asp:Label>
            <asp:TextBox ID="tbTitulo" runat="server"></asp:TextBox>
            <br />

            <asp:Label ID="lblAutor" runat="server" Text="Autor: " CssClass="label"></asp:Label>
            <asp:TextBox ID="tbAutor" runat="server"></asp:TextBox>            
            <br />

            <asp:Label ID="lblCategoria" runat="server" Text="Categoria: " CssClass="label"></asp:Label>
            <asp:TextBox ID="tbCategoria" runat="server"></asp:TextBox>          
            <br />

            <asp:Label ID="lblExtras" runat="server" Text="Extras: " CssClass="label"></asp:Label>
            <asp:TextBox ID="tbExtras" runat="server"></asp:TextBox>
            <br />

            <asp:Label ID="lblPrecio" runat="server" Text="precio: " CssClass="label"></asp:Label>
            <asp:TextBox ID="tbPrecio" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnAgregar" runat="server" OnClick="btnAgregar_Click" Text="Agregar"/>
        </div>
    </form>
</body>
</html>
