<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SitioVeterinario.aspx.cs" Inherits="VeterinariaApp.SitioVeterinario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center">
        
        <asp:Button ID="btn_verMascota" runat="server" OnClick="btn_verMascota_Click" Text="Ver Mascota" />
        <asp:Button ID="btn_registrarMascota" runat="server" Text="Registrar Mascota" />
        
    </div>
    </form>
</body>
</html>
