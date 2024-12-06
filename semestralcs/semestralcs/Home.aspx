<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="semestralcs.Home" %>

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
            <asp:Image ID="Image1" runat="server" Height="116px" Width="141px" ImageUrl="~/images/symbol.jpg" />
            <asp:Image ID="Image2" runat="server" Height="116px" Width="141px" ImageUrl="~/images/plane.png" />
            <br />
            <br />
            Bienvenido Usuario
            <asp:Label ID="lbl_user" runat="server" ForeColor="#00CC00"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label7" runat="server" Text="Portal de Transporte"></asp:Label>
            <br />
            <asp:Label ID="Label8" runat="server" Text="Selecciona el portal de transporte al que deseas ingresar.."></asp:Label>
            <br />
            <hr />
            <br />
            <asp:Label ID="Label13" runat="server" Text="Servicios que brindamos..."></asp:Label>
            <br />
            <br />
            <asp:Button ID="btn_tren" runat="server" Text="Viajes en Tren" Width="227px" OnClick="btn_tren_Click" />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btn_bus" runat="server" Text="Viajes en Autobús" Width="227px" OnClick="btn_bus_Click" />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btn_avion" runat="server" Text="Viajes en Avión" Width="227px" OnClick="btn_avion_Click" />
            <br />
            <br />
            <hr />
            <br />
            <br />
            <asp:Image ID="Image3" runat="server" Height="116px" Width="141px" ImageUrl="~/images/train.png" />
            <asp:Image ID="Image4" runat="server" Height="116px" Width="141px" ImageUrl="~/images/bus.png" />
            <asp:Image ID="Image5" runat="server" Height="116px" Width="141px" ImageUrl="~/images/plane.png" />
            <br />
            <br />
            <asp:Label ID="Label12" runat="server" Font-Italic="True" Font-Size="Smaller" Text="MOVING PTY @  2024 @ ALL RIGHTS RESERVED"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
