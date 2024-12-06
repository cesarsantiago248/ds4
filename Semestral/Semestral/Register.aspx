<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Semestral.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="MOVING PTY"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Movemos Panamá..."></asp:Label>
            <hr />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Transporte en Línea!!"></asp:Label>
            <br />
            <asp:Label ID="Label6" runat="server" Text="Consulta tu saldo, agenda tus viajes, viaja feliz..."></asp:Label>
            <br />
            <asp:Image ID="Image1" runat="server" Height="116px" Width="141px" />
            <asp:Image ID="Image2" runat="server" Height="116px" Width="141px" />
            <br />
            <br />
            <asp:Label ID="Label7" runat="server" Text="Crea tu cuenta de Transporte"></asp:Label>
            <br />
            <asp:Label ID="Label8" runat="server" Text="Al crear tu cuenta de transporte, tendrás acceso a tu tarjeta de transporte en Línea!! con la que podrás viajar"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label9" runat="server" Text="Inicia los datos de tu cuenta a continuación..."></asp:Label>
            <br />
            <hr />
            <br />
            <asp:Label ID="Label10" runat="server" Text="Nuevo Username:"></asp:Label>
            <br />
            <asp:TextBox ID="txtbox_username" runat="server" Width="222px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label11" runat="server" Text="Nuevo Password:"></asp:Label>
            <br />
            <asp:TextBox ID="txtbox_password" runat="server" Width="222px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label13" runat="server" Text="Su Nombre y Apellido:"></asp:Label>
            <br />
            <asp:TextBox ID="txtbox_nombre" runat="server" Width="222px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btn_crear_cuenta" runat="server" Text="Crear cuenta" Width="126px" />
            <br />
            <br />
            <asp:Label ID="lbl_crear_cuenta" runat="server"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="btn_return_login" runat="server" Text="Regresa a Inicio de Sesión" Width="230px" />
            <br />
            <br />
            <asp:Label ID="Label12" runat="server" Font-Italic="True" Font-Size="Smaller" Text="MOVING PTY @  2024 @ ALL RIGHTS RESERVED"></asp:Label>
        </div>
    </form>
</body>
</html>
