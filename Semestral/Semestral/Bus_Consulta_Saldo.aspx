<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bus_Consulta_Saldo.aspx.cs" Inherits="Semestral.Funciones_Avion.Bus_Consulta_Saldo" %>

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
            <asp:Label ID="Label7" runat="server" Text="Servicios de Bus - Consulta de Saldo y Tarifas"></asp:Label>
            <br />
            <asp:Label ID="Label8" runat="server" Text="Compara los precios que tenemos, contra tu bolsillo..."></asp:Label>
            <br />
            <hr />
            <br />
            <asp:Label ID="lbl_nombre_cliente" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label9" runat="server" Text="Actualmente tu cuenta de servicio de Bus cuenta con el siguiente saldo:"></asp:Label>
            <br />
            <asp:Label ID="lbl_saldo_cliente" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label10" runat="server" Text="Deseas agregar saldo a tu cuenta?"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btn_agregar_saldo" runat="server" Text="Agregar saldo" Width="205px" />
            <br />
            <hr />
            <br />
            <asp:Label ID="Label11" runat="server" Text="Nuestras tarifas"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label12" runat="server" Text="A continuación el tarifario a la fecha de hoy..."></asp:Label>
            <br />
            <asp:GridView ID="gridview_tarifario" runat="server">
            </asp:GridView>
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
