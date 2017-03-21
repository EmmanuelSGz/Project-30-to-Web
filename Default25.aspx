<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default25.aspx.cs" Inherits="Default25" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Tarea Programacion III</title>
</head>
<body>
    <form id="form1" runat="server">
        <span style="border: thin groove #0000FF; font-size: 14.0pt; line-height: 100%; font-family: &quot;Courier: New&quot; mso-fareast-font-family: &quot;Courier New&quot;; color: black; mso-ansi-language: ES; mso-fareast-language: ES; mso-bidi-language: AR-SA; background-image: none; cursor: auto;">
            Calcular Todos los Pagos Hechos de un Restaurant que Lea 130 consumos y Que si el 
        <br />
        <br />
        Consumo Ingresado Excede los $130 el Descuento será del 15%</span>
    <div>
    
        <br />
        <asp:Label ID="Label1" runat="server" Text="Ingrese Consumo:"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox1" runat="server" Width="104px"></asp:TextBox>
        <br />
    
        <br />
        <asp:Button ID="Button1" runat="server" Text="Calcular" 
            OnClick="Button1_Click" />
    
        <br />
        <br />
        <asp:ListBox ID="ListBox1" runat="server" Height="170px" Width="193px">
        </asp:ListBox>
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
