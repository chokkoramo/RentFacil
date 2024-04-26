<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InformePagos.aspx.cs" Inherits="RentFacil.InformePagos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="Styles/style.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <div class="navbar">
        <a href="Inicio.aspx">Inicio</a>
        <a href="AgregarArrendatario.aspx">Agregar Arrendatario</a>
        <a href="AgregarArrendador.aspx">Agregar Arrendador</a>
        <a href="InformePagos.aspx">Pagos</a>
    </div>
    <form id="form1" runat="server">
        <div>
            <h2>Informe de Pagos</h2>
            <div class="form_input">
                <asp:Label ID="Label1" runat="server" Text="Seleccione el rango de fechas"></asp:Label>
                <asp:TextBox ID="txtFechaInicio" runat="server" placeholder="**/**/****"></asp:TextBox>
                <asp:TextBox ID="txtFechaFin" runat="server"></asp:TextBox>
                <asp:Button ID="btnGenerarInforme" runat="server" Text="Informe"  OnClick="btnGenerarInforme_Click"/>
            </div>
        </div>
    </form>
</body>
</html>
