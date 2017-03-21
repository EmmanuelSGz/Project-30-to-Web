<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default28.aspx.cs" Inherits="Default28" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Tarea Programacion III</title>
</head>
<body>
    <form id="form1" runat="server">
        <span style="border: thin groove #0000FF; font-size: 14.0pt; line-height: 100%; color: black;background-image: none; cursor: auto;">
            Diseñar Un Formulario Que Permita Ingresar Dos Notas Malas y Determine Su Promedio, Debe Mostrar Un Comentario Si Está Aprobado o Desaprobado.</span>
    <div>
    
        <br />
        <asp:Label ID="Label1" runat="server" Text="Ingrese Primera Nota:"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Ingrese Segunda Nota:"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" 
            Text="Mostrar" />
        <br />
        <br />
        <br />
        <asp:ListBox ID="ListBox1" runat="server" Height="148px" Width="182px">
        </asp:ListBox>
        <br />
    
    </div>
    </form>
</body>
</html>
