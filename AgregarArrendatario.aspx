<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarArrendatario.aspx.cs" Inherits="RentFacil.AgregarArrendatario" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="Styles/estilos.css" rel="stylesheet" />
    <title>Agregar Arrendatario</title>
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
        <h2>Formulario Arrendatario</h2>
        <fieldset>
            <legend>INFORMACION BASICA</legend>
            <div class="form_input">
                <asp:Label AssociatedControlID="txtID" ID="label4" runat="server" Text="Identificacion"></asp:Label>
                <asp:TextBox ID="txtID" type="text" placeholder="1025...." runat="server"></asp:TextBox>
            </div>
            <div class="form_input">
                <asp:Label AssociatedControlID="txtNombre" ID="label1" runat="server" Text="Nombre"></asp:Label>
                <asp:TextBox ID="txtNombre" type="text" placeholder="Juan" runat="server"></asp:TextBox>
            </div>
            <div class="form_input">
                <asp:Label AssociatedControlID="txtDireccion" ID="label2" runat="server" Text="Direccion"></asp:Label>
                <asp:TextBox ID="txtDireccion" type="text" placeholder="Carrera ** #**-**" runat="server"></asp:TextBox>
            </div>
            <div class="form_input">
                <asp:Label AssociatedControlID="txtCorreo" ID="label5" runat="server" Text="Correo"></asp:Label>
                <asp:TextBox ID="txtCorreo" type="email" placeholder="example@gmail.com" runat="server"></asp:TextBox>
            </div>
            <div class="form_input">
                <asp:Label AssociatedControlID="ddlContratos" ID="label3" runat="server" Text="Contrato"></asp:Label>
                <asp:DropDownList ID="ddlContratos" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList>
            </div>
            <div class="form_input">
                <asp:Button ID="BtnGuardar" runat="server" Text="Guardar" OnClick="BtnGuardar_Click" />
            </div>
        </fieldset>
        </div>
        <div>
        <asp:GridView ID="GridViewArrendatarios" runat="server" AutoGenerateColumns="false">
           <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Identificación" SortExpression="Id" />
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                    <asp:BoundField DataField="Direccion" HeaderText="Celular" SortExpression="Direccion" />
                    <asp:BoundField DataField="Correo" HeaderText="Correo" SortExpression="Correo" />
                    <asp:BoundField DataField="Contrato" HeaderText="Contrato" SortExpression="Contrato" />
            </Columns>
        </asp:GridView>
        </div>

    </form>
        <h1>Listado de Propiedades</h1>
    <div>
        <% foreach (var propiedad in propiedadDatos) { %>
            <div style="border: 1px solid #ccc; padding: 10px; margin-bottom: 10px;">
                <h3>Propiedad ID: <%= propiedad.IdPropiedad %></h3>
                <p>Área: <%= propiedad.Area %> m²</p>
                <p>Habitaciones: <%= propiedad.NroHabitaciones %></p>
                <p>Disponible: <%= propiedad.Disponible ? "Sí" : "No" %></p>
                <p>Precio Alquiler: <%= propiedad.PrecioAlquiler %> USD</p>
            </div>
        <% } %>
    </div>
</body>
</html>