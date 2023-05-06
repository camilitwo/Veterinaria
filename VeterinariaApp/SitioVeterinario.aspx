<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SitioVeterinario.aspx.cs" Inherits="VeterinariaApp.SitioVeterinario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 613px;
        }
        .auto-style2 {
            width: 593px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center">
        
        <asp:Button ID="btn_verMascota" runat="server" OnClick="btn_verMascota_Click" Text="Ver Mascota" />
        <asp:Button ID="btn_registrarMascota" runat="server" Text="Registrar Mascota" OnClick="btn_registrarMascota_Click" />
        
        <br />
        <br />
        <br />
        <asp:Menu ID="Menu1" runat="server" style="text-align: left" Width="405px" OnMenuItemClick="Menu1_MenuItemClick" StaticSubMenuIndent="">
            <Items>
                <asp:MenuItem Text="Ver lista de propietarios" Value="Ver lista de propietarios" ></asp:MenuItem>

                <asp:MenuItem Text="Ver lista de mascotas" Value="Ver lista de mascotas" Selected="True"></asp:MenuItem>
            </Items>
        </asp:Menu>
        
        <br />
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">
                    <asp:GridView ID="gv_sitio" runat="server">
                    </asp:GridView>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        
    </div>
    </form>
</body>
</html>
