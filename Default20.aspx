<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default20.aspx.cs" Inherits="Default20" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Tarea Programacion III</title>
</head>
<body>
    <form id="form1" runat="server"><h1>
            <span style="border: thin groove #0000FF; font-size: 14.0pt; mso-bidi-font-size: 11.0pt; line-height: 100%; font-family: &quot;Courier New&quot;; mso-fareast-font-family: &quot;Courier New&quot;; color: black; mso-ansi-language: ES; mso-fareast-language: ES; mso-bidi-language: AR-SA; background-image: none; cursor: auto;">
            Hacer Un Programa Que Imprima El Cubo y </span></h1>
        <h1>
            <span style="border: thin groove #0000FF; font-size: 14.0pt; mso-bidi-font-size: 11.0pt; line-height: 100%; font-family: &quot;Courier New&quot;; mso-fareast-font-family: &quot;Courier New&quot;; color: black; mso-ansi-language: ES; mso-fareast-language: ES; mso-bidi-language: AR-SA; background-image: none; cursor: auto;">
            La Raíz Cuadrada De Un Numero Ingresado Por La Pantalla.</span></h1>
        <div>
    
            <asp:Label ID="Label1" runat="server" Text="Ingrese Un Numero:  "></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
    
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" 
            Text="Mostrar" />
    
            <br />
    
        <br />
            <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" Height="241px" 
                OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="267px">
                <asp:ListItem></asp:ListItem>
                <asp:ListItem></asp:ListItem>
                <asp:ListItem></asp:ListItem>
                <asp:ListItem></asp:ListItem>
                <asp:ListItem></asp:ListItem>
            </asp:ListBox>
            <br />
        <br />
    
    </div>
    </form>
</body>
</html>
