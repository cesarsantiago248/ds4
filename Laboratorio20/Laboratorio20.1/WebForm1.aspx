<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Laboratorio20._1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Tabla de Multiplicar</h3>
            <asp:Label ID="lblMultiplicar" Text="Introduce un número:" EnableViewState="false"  runat="server" ></asp:Label> 
            <asp:TextBox ID="txbNumero" runat="server" BackColor="LightGray" Width="50px"></asp:TextBox>
            <br />
            <asp:Button ID="btnMultiplicar" runat="server" Text="Multiplicar" OnClick="btnMultiplicar_Click" ForeColor="#003366" Font-Bold="true" BorderStyle="Outset" BackColor="LightSteelBlue"/>
            <br />
            <asp:Label ID="lblResultado" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
