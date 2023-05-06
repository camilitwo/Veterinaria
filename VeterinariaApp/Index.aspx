<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="VeterinariaApp.Index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1 class="auto-style1">
            <asp:AccessDataSource ID="AccessDataSource1" runat="server"></asp:AccessDataSource>
            Sistema de Ingreso veterinaria Mascotas </h1>
        <h2 class="auto-style1">Validación de datos</h2>
        <p class="auto-style1">
            Usuario:<asp:TextBox ID="Txt_usuario" runat="server"></asp:TextBox>
        </p>
        <p class="auto-style1">
            Password:
            <asp:TextBox ID="Txt_password" runat="server"></asp:TextBox>
        </p>
        <p class="auto-style1">
            <asp:Button ID="Btn_ingreso" runat="server" Text="Ingreso" OnClick="Btn_ingreso_Click" />
        </p>
        <p class="auto-style1">
            <asp:Label ID="Lbl_mensaje" runat="server"></asp:Label>
        </p>
    
    </div>
    </form>
</body>
</html>
