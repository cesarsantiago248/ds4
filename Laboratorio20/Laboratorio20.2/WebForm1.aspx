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
            <h2>
                <asp:Label ID="Label1" runat="server" Text="Genera una Matriz N X N"></asp:Label>
            </h2>
            <hr />
            <label for="txtDimension">
            <br />
            <asp:Label ID="Label2" runat="server" Text="El número que ingrese a continuación será precentado como una matriz N x N..."></asp:Label>
            <br />
            <br />
            Ingrese el valor de N...</label>
            <br />
            <asp:TextBox ID="txtDimension" Width="263px"  runat="server" BackColor="LightGray" BorderStyle="None" OnTextChanged="txtDimension_TextChanged" ></asp:TextBox>
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnGenerar" runat="server" Text="Generar" OnClick="btnGenerar_Click"  BackColor="#00FF99" BorderStyle="Groove" Font-Bold="true" ForeColor="#000066" Width="77px" />
            <br />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" Text="" ForeColor="Red" Font-Bold="true" ></asp:Label>
            <br />
            <asp:PlaceHolder ID="matriz" runat="server" ></asp:PlaceHolder>
        </div>
    </form>
</body>
</html>
