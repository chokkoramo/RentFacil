<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarArrendador.aspx.cs" Inherits="RentFacil.AgregarArrendador" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="Styles/style.css" rel="stylesheet" />
    <title>Agregar Arrendador</title>
</head>
<body>
    <div class="navbar">
        <a href="Inicio.aspx">Inicio</a>
        <a href="AgregarArrendatario.aspx">Agregar Arrendatario</a>
        <a href="AgregarArrendador.aspx">Agregar Arrendador</a>
        <a href="#">Pagos</a>
    </div>
    <form id="form1" runat="server">
        <div>
        <h2>Formulario Arrendador</h2>
        <fieldset>
            <legend>INFORMACION BASICA</legend>
            <div class="form_input">
                <asp:Label AssociatedControlID="txtNombreArrendador" ID="label1" runat="server" Text="Nombre"></asp:Label>
                <asp:TextBox ID="txtNombreArrendador" type="text" placeholder="Juan" runat="server"></asp:TextBox>
            </div>
            <div class="form_input">
                <asp:Label AssociatedControlID="txtDireccionArrendador" ID="label2" runat="server" Text="Direccion"></asp:Label>
                <asp:TextBox ID="txtDireccionArrendador" type="text" placeholder="Carrera ** #**-**" runat="server"></asp:TextBox>
            </div>
            <div class="form_input">
                <asp:Label AssociatedControlID="txtCorreoArrendador" ID="label5" runat="server" Text="Correo"></asp:Label>
                <asp:TextBox ID="txtCorreoArrendador" type="email" placeholder="example@gmail.com" runat="server"></asp:TextBox>
            </div>
            <div class="form_input">
                <asp:Label AssociatedControlID="ddlPropiedades" ID="label3" runat="server" Text="Propiedades"></asp:Label>
                <asp:DropDownList ID="ddlPropiedades" runat="server" OnSelectedIndexChanged="ddlPropiedades_SelectedIndexChanged"></asp:DropDownList>
            </div>
            <div class="form_input">
                <asp:Button ID="BtnGuardar" runat="server" Text="Guardar" OnClick="BtnGuardar_Click" />
            </div>
        </fieldset>
        </div>
        <div>
        <asp:GridView ID="GridViewArrendador" runat="server" OnSelectedIndexChanged="GridViewArrendador_SelectedIndexChanged">
        </asp:GridView>
        </div>
    </form>
</body>
</html>
