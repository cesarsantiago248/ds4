<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Avión_Agregar_Saldo.aspx.cs" Inherits="Semestral.Funciones_Avion.Avión_Agregar_Saldo" %>

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
            <asp:Label ID="Label7" runat="server" Text="Servicios de Avión - Agrega Saldo a tu Cuenta"></asp:Label>
            <br />
            <asp:Label ID="Label8" runat="server" Text="Sin plata te ves feo..."></asp:Label>
            <br />
            <hr />
            <br />
            <asp:Label ID="Label9" runat="server" Text="Agrega Saldo"></asp:Label>
            <br />
            <asp:Label ID="Label10" runat="server" Text="Cuanto saldo deseas agregar a tu cuenta?"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="txtbox_agregar_saldo" runat="server" Width="164px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lbl_agregar_saldo" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lbl_saldos_antes_desp" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btn_return" runat="server" Text="Regresa al portal" Width="196px" />
            <br />
            <br />
            <hr />
            <br />
            <br />
            <asp:Image ID="Image3" runat="server" Height="116px" Width="141px" />
            <asp:Image ID="Image4" runat="server" Height="116px" Width="141px" />
            <asp:Image ID="Image5" runat="server" Height="116px" Width="141px" />
            <br />
            <br />
            <asp:Label ID="Label13" runat="server" Font-Italic="True" Font-Size="Smaller" Text="MOVING PTY @  2024 @ ALL RIGHTS RESERVED"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
