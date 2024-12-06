<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Avión_Agendar.aspx.cs" Inherits="semestralcs.Avión_Agendar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
            <style>
        /* Basic reset and layout */
        body {
            font-family: 'Arial', sans-serif;
            margin: 0;
            padding: 0;
            background-color: #f4f4f4;
        }

        /* Centering content */
        form {
            max-width: 1200px;
            margin: 0 auto;
            padding: 20px;
        }

        /* Header styles */
        #Label1 {
            font-size: 36px;
            font-weight: bold;
            color: #007BFF;
            text-align: center;
        }

        #Label2 {
            font-size: 20px;
            font-style: italic;
            color: #888;
            text-align: center;
        }

        /* Section separator styles */
        hr {
            border: 1px solid #007BFF;
            width: 90%;
            margin: 30px auto;
        }

        /* Images styling */
        asp:Image {
            display: inline-block;
            margin: 5px;
            border-radius: 8px;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
        }

        /* Styling for Labels */
        label {
            font-size: 18px;
            margin-bottom: 10px;
            display: block;
            color: #333;
        }

        /* GridView styling */
        .gridview_viajes {
            width: 100%;
            border-collapse: collapse;
            margin-top: 20px;
            border: 1px solid #ddd;
        }

        .gridview_viajes th, .gridview_viajes td {
            padding: 10px;
            text-align: left;
            border-bottom: 1px solid #ddd;
        }

        .gridview_viajes tr:hover {
            background-color: #f1f1f1;
        }

        .gridview_viajes th {
            background-color: #007BFF;
            color: white;
        }

        /* Button styling */
        #btn_return {
            background-color: #007BFF;
            color: white;
            padding: 10px 20px;
            font-size: 16px;
            border: none;
            border-radius: 5px;
            cursor: pointer;
        }

        #btn_return:hover {
            background-color: #0056b3;
        }

        /* Footer style */
        #Label13 {
            text-align: center;
            font-size: 12px;
            color: #555;
            font-style: italic;
            margin-top: 30px;
        }

        /* Error label */
        #lbl_error {
            color: red;
            font-weight: bold;
            text-align: center;
        }

        /* Flex container for images */
        .image-container {
            display: flex;
            justify-content: space-around;
            margin-top: 20px;
        }
    </style>
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
            <asp:Image ID="Image6" runat="server" Height="116px" Width="141px" ImageUrl="~/images/symbol.jpg" />
            <asp:Image ID="Image7" runat="server" Height="116px" Width="141px" ImageUrl="~/images/plane.png" />
        <br />
        <br />
        <asp:Label ID="Label7" runat="server" Text="Servicios de Avión - Agenda un viaje"></asp:Label>
        <br />
        <asp:Label ID="Label8" runat="server" Text="Viene lo bueno..."></asp:Label>
        <br />
        <hr />
        <br />
        <asp:Label ID="Label9" runat="server" Text="Vuelos actuales"></asp:Label>
        <br />
        <asp:Label ID="Label10" runat="server" Text="Mira a continuación los vuelos que tenemos disponibles para la venta..."></asp:Label>
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
        <asp:Button ID="btn_agendar" runat="server" Text="Agenda el viaje" Width="193px" OnClick="btn_agendar_Click" />
        <br />
        <br />
        <asp:Label ID="lbl_agenda" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btn_return" runat="server" Text="Regresa al portal" Width="196px" OnClick="btn_return_Click" />
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
