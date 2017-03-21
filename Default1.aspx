<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default1.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Tarea Programacion III</title>
</head>
<body>
    <form id="form1" runat="server"><h1>
        <span style="border: thin groove #0000FF; font-size: 14.0pt; mso-bidi-font-size: 11.0pt; line-height: 100%; font-family: &quot;Courier New&quot;; mso-fareast-font-family: &quot;Courier New&quot;; color: black; mso-ansi-language: ES; mso-fareast-language: ES; mso-bidi-language: AR-SA; background-image: none; cursor: auto;">
        Calcular El Salario Del Trabajador Dadas Las Horas Trabajadas Y La Tarifa.</span></h1>
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Ingrese Horas Trabajadas:"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Ingrese Tarifa:"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Calcular" 
            OnClick="Button1_Click" />
        <br />
        <asp:Label ID="Label3" runat="server" Text="El Salario Es:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
    
    </div>
        <br />
    </form>
</body>
</html>
