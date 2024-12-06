<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Semestral.Login" %>

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
            <asp:Label ID="Label3" runat="server" Text="Transporte en Línea!!"></asp:Label>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Consulta tu saldo, agenda tus viajes, viaja feliz..."></asp:Label>
            <br />
            <asp:Image ID="Image1" runat="server" Height="116px" Width="141px" />
            <asp:Image ID="Image2" runat="server" Height="116px" Width="141px" />
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Bienvenido!!!"></asp:Label>
            <br />
            <asp:Label ID="Label6" runat="server" Text="Inicia sesión con tus datos a continuación..."></asp:Label>
            <br />
            <hr />
            <br />
            <asp:Label ID="Label7" runat="server" Text="Username:"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox1" runat="server" Width="222px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label8" runat="server" Text="Password:"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox2" runat="server" Width="222px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btn_login" runat="server" Text="Inicia sesión" Width="126px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btn_forgot" runat="server" Text="Olvidé mi contraseña" Width="126px" />
            <br />
            <br />
            <asp:Label ID="login_label" runat="server" ForeColor="Red"></asp:Label>
            <br />
            <br />
            <hr />
            <br />
            <asp:Label ID="Label10" runat="server" Text="No tienes una cuenta???"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btn_register" runat="server" Text="Registrate aquí" Width="126px" />
            <br />
            <br />
            <asp:Image ID="Image3" runat="server" Height="116px" Width="141px" />
            <br />
            <br />
            <br />
            <asp:Label ID="Label9" runat="server" Font-Italic="True" Font-Size="Smaller" Text="MOVING PTY @  2024 @ ALL RIGHTS RESERVED"></asp:Label>
        </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
