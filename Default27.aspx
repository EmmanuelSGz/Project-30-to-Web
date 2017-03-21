<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default27.aspx.cs" Inherits="Default27" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Tarea Programacion III</title>
</head>
<body>
    <form id="form1" runat="server">
        <span style="border: thin groove #0000FF; font-size: 14.0pt; line-height: 100%; color: black;background-image: none; cursor: auto;">
            Calcular los Egresos de la Compañía y Mostrar Cuanto Queda en Caja
        </span>
    <div>
    
        <br />
        <asp:Label ID="Label1" runat="server" Text="Ingrese Egreso: "></asp:Label>
        <br />
        <asp:TextBox ID="TextBox1" runat="server" Width="96px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" 
            Text="Calcular" />
        <br />
        <br />
        <asp:ListBox ID="ListBox1" runat="server" Height="176px" Width="218px" 
            AutoPostBack="True">
        </asp:ListBox>
        <br />
    
    </div>
    </form>
</body>
</html>
