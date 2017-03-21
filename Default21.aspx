<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default21.aspx.cs" Inherits="Default21" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Tarea Programacion III</title>
</head>
<body>
    <form id="form1" runat="server">
        <span style="border: thin groove #0000FF; font-size: 14.0pt; mso-bidi-font-size: 11.0pt; line-height: 100%; font-family: &quot;Courier New&quot;; mso-fareast-font-family: &quot;Courier New&quot;; color: black; mso-ansi-language: ES; mso-fareast-language: ES; mso-bidi-language: AR-SA; background-image: none; cursor: auto;">&nbsp;Calcular La Suma, Diferencia, Producto y División.  </span>
    <div>
    
        <br />
        <asp:Label ID="Label1" runat="server" Text="Ingresar Valores a Calcular:"></asp:Label>
    
        <br />
        <asp:TextBox ID="TextBox1" runat="server" Width="76px"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox ID="TextBox2" runat="server" Width="75px"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" 
            Text="Calcular" />
    
        <br />
        <br />
        <br />
        <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" Height="132px" 
            Width="166px"></asp:ListBox>
    
    </div>
    </form>
</body>
</html>
