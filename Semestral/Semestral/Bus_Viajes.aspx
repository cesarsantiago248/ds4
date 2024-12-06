<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bus_Viajes.aspx.cs" Inherits="Semestral.Funciones_Bus.Bus_Viajes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
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
            <asp:Label ID="Label7" runat="server" Text="Servicios de Bus - Observa tus viajes agendados"></asp:Label>
            <br />
            <asp:Label ID="Label8" runat="server" Text="Apuesto que estás ansioso por viajar..."></asp:Label>
            <br />
            <hr />
            <br />
            <asp:Label ID="Label9" runat="server" Text="Vuelos agendados"></asp:Label>
            <br />
            <asp:Label ID="Label10" runat="server" Text="Mira a continuación los viajes que tienes agendados..."></asp:Label>
            <br />
            <asp:GridView ID="gridview_viajes_agendados" runat="server">
            </asp:GridView>
            <br />
            <br />
            <asp:Button ID="btn_return" runat="server" Text="Regresa al portal" Width="196px" />
            <br />
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
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
