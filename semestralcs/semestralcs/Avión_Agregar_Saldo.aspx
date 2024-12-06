<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Avión_Agregar_Saldo.aspx.cs" Inherits="semestralcs.Avión_Agregar_Saldo" %>

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
            <asp:Image ID="Image6" runat="server" Height="116px" Width="141px" ImageUrl="~/images/symbol.jpg" />
            <asp:Image ID="Image7" runat="server" Height="116px" Width="141px" ImageUrl="~/images/plane.png" />
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
           <asp:Button ID="btn_add" runat="server" OnClick="btn_add_Click" Text="Agregar Saldo" Width="189px" />
           <br />
           <br />
           <asp:Label ID="lbl_agregar_saldo" runat="server"></asp:Label>
           <br />
           <br />
           <asp:Label ID="lbl_error" runat="server"></asp:Label>
           <br />
           <br />
           <asp:Label ID="lbl_saldos_1" runat="server"></asp:Label>
           <br />
           <asp:Label ID="lbl_saldos_2" runat="server"></asp:Label>
           <br />
           <br />
           <asp:Button ID="btn_return" runat="server" Text="Regresa al portal" Width="196px" OnClick="btn_return_Click" />
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
