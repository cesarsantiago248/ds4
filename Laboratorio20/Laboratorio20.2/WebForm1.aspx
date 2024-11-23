<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Laboratorio20._2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Matriz N x N</title>
    <style>
        table {
            border-collapse: collapse;
            margin-top: 20px;
        }
        td {
            border: 1px solid black;
            width: 30px;
            height: 30px;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Generar Matriz N x N</h2>
            <label for="txtDimension">Ingrese la dimensión N:</label>
            <asp:TextBox ID="txtDimension" Width="40"  runat="server" BackColor="LightGray" BorderStyle="None" ></asp:TextBox>
            <asp:Button ID="btnGenerar" runat="server" Text="Generar" OnClick="btnGenerar_Click"  BackColor="#0066ff" BorderStyle="Groove" Font-Bold="true" ForeColor="White" />
            <br /><br />
            <asp:Label ID="lblError" runat="server" Text="" ForeColor="Red" Font-Bold="true" ></asp:Label>
            <br />
            <asp:PlaceHolder ID="matriz" runat="server" ></asp:PlaceHolder>
        </div>
    </form>
</body>
</html>
