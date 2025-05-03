<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListarSucursal.aspx.cs" Inherits="TP5_Grupo_6.ListadoSucursales" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style18 {
            height: 29px;
        }
        .auto-style20 {
            height: 50px;
        }
        .auto-style23 {
            height: 50px;
            width: 442px;
        }
        .auto-style24 {
            width: 442px;
        }
        .auto-style25 {
            width: 442px;
            height: 23px;
        }
        .auto-style26 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style18" colspan="2">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:HyperLink ID="hlAgregarSucursal" runat="server" NavigateUrl="~/AgregarSucursal.aspx">Agregar Sucursal</asp:HyperLink>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:HyperLink ID="hlListadoSucursales" runat="server" NavigateUrl="~/ListarSucursal.aspx">Listado de Sucursales</asp:HyperLink>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:HyperLink ID="hlEliminarSucursal" runat="server" NavigateUrl="~/EliminarSucursal.aspx" >Eliminar Sucursal</asp:HyperLink>
                    </td>
                    </tr>
                <tr>
                    <td class="auto-style23">
                        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Listado de sucursales"></asp:Label>
                    </td>
                    <td class="auto-style20"></td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:HyperLink ID="HyperLink1" runat="server">Búsqueda ingrese Id sucursal:</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="txtBusqueda" runat="server" Width="245px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnFiltrar" runat="server" Text="Filtrar" OnClick="btnFiltrar_Click" />
&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnMostrarTodos" runat="server" Text="Mostrar todos" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style25"></td>
                    <td class="auto-style26"></td>
                </tr>
                <tr>
                    <td class="auto-style24">
                        <asp:GridView ID="gvSucursal" runat="server">
                        </asp:GridView>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style24">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style24">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
