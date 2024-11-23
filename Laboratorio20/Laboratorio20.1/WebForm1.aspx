<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Laboratorio20._1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>&nbsp;<asp:Label ID="Label1" runat="server" Text="Multiplica tu Numero!"></asp:Label>
            </h3>
            <hr />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Se presentarán las tablas de mult. del número que introduzca a continuación..."></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblMultiplicar" Text="Introduzca un número:" EnableViewState="False"  runat="server" ></asp:Label> 
            <br />
            <asp:TextBox ID="txbNumero" runat="server" BackColor="LightGray" Width="238px"></asp:TextBox>
            <br />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnMultiplicar" runat="server" Text="Multiplicar" OnClick="btnMultiplicar_Click" ForeColor="#003366" Font-Bold="true" BorderStyle="Outset" BackColor="#00FF99"/>
            <br />
            <br />
            <br />
            <asp:Label ID="lblResultado" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
