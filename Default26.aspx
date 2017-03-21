<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default26.aspx.cs" Inherits="Default26" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Tarea Programacion III</title>
</head>
<body>
    <form id="form1" runat="server">
        <span style="border: thin groove #0000FF; font-size: 14.0pt; mso-bidi-font-size: 11.0pt; line-height: 100%; font-family: &quot;Courier New&quot;; mso-fareast-font-family: &quot;Courier New&quot;; color: black; mso-ansi-language: ES; mso-fareast-language: ES; mso-bidi-language: AR-SA; background-image: none; cursor: auto;">
            Calcular la Suma de los n Primeros Números Enteros Desde el Numero 8 
        <br />
        <br />
        S=8+9+10+11+...+N
</span>
        <div>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Ingrese el Numero Enesimo:"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox1" runat="server" Width="70px"></asp:TextBox>
            <br />
            <br />
        <asp:Button ID="Button1" runat="server" Text="Calcular" OnClick="Button1_Click" />
    
            <br />
            <br />
            <asp:ListBox ID="ListBox1" runat="server" Height="141px" Width="636px">
            </asp:ListBox>
            <br />
            <br />
    
    </div>
    </form>
</body>
</html>
