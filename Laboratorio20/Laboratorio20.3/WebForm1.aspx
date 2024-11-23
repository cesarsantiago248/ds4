<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Laboratorio20._3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Productos</title>
</head>
<body>
    <form id="form1" runat="server" >
        <div>
            <h2>Productos</h2>
            <asp:ImageButton ID="btnNuevo" runat="server" Width="20px" Height="20px" ImageUrl="~/iconos/nuevo.png" OnClick="btnNuevo_Click" />
            <asp:ImageButton ID="btnGuardar" runat="server" Width="20px" Height="20px" ImageUrl="~/iconos/guardar.png" OnClick="btnGuardar_Click" />
            <asp:ImageButton ID="btnCancelar" runat="server" Width="20px" Height="20px" ImageUrl="~/iconos/cancelar.png" OnClick="btnCancelar_Click" />
            <asp:ImageButton ID="btnEliminar" runat="server" Width="20px" Height="20px" ImageUrl="~/iconos/eliminar.png" OnClick="btnEliminar_Click" />

            <asp:Label ID="lblBuscar" runat="server" Text="Buscar por id:" Style="margin-left: 10px"></asp:Label>
            <asp:TextBox ID="txbBuscar" runat="server" Width="40px" ></asp:TextBox>
            <asp:ImageButton ID="btnBuscar" runat="server" Width="20px" Height="20px" ImageUrl="~/iconos/buscar.png" OnClick="btnBuscar_Click" />

            <br /><br />
            <asp:Label ID="lblId" Text="Id" runat="server" Style="margin-right: 80px" ></asp:Label>
            <asp:Label ID="lblNombre" Text="Nombre" runat="server"></asp:Label>
            <br />
            <asp:TextBox ID="txbId" runat="server" Width="40px" Style="margin-right: 40px" ></asp:TextBox>
            <asp:TextBox ID="txbNombre" runat="server" Width="200px"></asp:TextBox>
            <br /><br />
            <asp:Label ID="lblPrecio" Text="Precio" runat="server" Style="margin-right: 50px" ></asp:Label>
            <asp:Label ID="lblStock" Text="Stock" runat="server"></asp:Label>
            <br />
            <asp:TextBox ID="txbPrecio" runat="server" Style="margin-right: 30px" Width="50px" ></asp:TextBox>
            <asp:TextBox ID="txbStock" runat="server" Width="40px" ></asp:TextBox>
            <br /><br />
            <asp:Label ID="lblMensaje" runat="server" ForeColor="Red" ></asp:Label>
        </div>
    </form>
</body>
</html>
