<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bus_Agendar.aspx.cs" Inherits="Semestral.Funciones_Bus.Bus_Agendar" %>

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
            <asp:Label ID="Label7" runat="server" Text="Servicios de Bus - Agenda un viaje"></asp:Label>
            <br />
            <asp:Label ID="Label8" runat="server" Text="Viene lo bueno..."></asp:Label>
            <br />
            <hr />
            <br />
            <asp:Label ID="Label9" runat="server" Text="Vuelos actuales"></asp:Label>
            <br />
            <asp:Label ID="Label10" runat="server" Text="Mira a continuación los viajes que tenemos disponibles para la venta..."></asp:Label>
            <br />
            <asp:GridView ID="gridview_viajes" runat="server">
            </asp:GridView>
            <br />
            <hr />
            <br />
            <asp:Label ID="Label14" runat="server" Text="Agenda tu viaje"></asp:Label>
            <br />
            <asp:Label ID="Label15" runat="server" Text="Escoje el viaje que quieres agendar..."></asp:Label>
            <br />
            <br />
            <asp:DropDownList ID="listbox_viajes" runat="server" Height="17px" Width="173px">
            </asp:DropDownList>
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Agenda el viaje" Width="193px" />
            <br />
            <br />
            <asp:Label ID="lbl_agenda" runat="server"></asp:Label>
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
</body>
</html>
