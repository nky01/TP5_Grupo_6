<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tp05EjercicioA.aspx.cs" Inherits="TP5_Grupo_6.tp05EjercicioA" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 283px;
        }
        .auto-style3 {
            width: 283px;
            height: 26px;
        }
        .auto-style4 {
            height: 26px;
        }
        .auto-style5 {
            width: 226px;
        }
        .auto-style6 {
            height: 26px;
            width: 226px;
        }
        .auto-style7 {
            width: 283px;
            height: 87px;
        }
        .auto-style8 {
            width: 226px;
            height: 87px;
        }
        .auto-style9 {
            height: 87px;
        }
        .auto-style10 {
            width: 283px;
            height: 56px;
        }
        .auto-style11 {
            width: 226px;
            height: 56px;
        }
        .auto-style12 {
            height: 56px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style7">
                        <br />
                        <br />
                        <asp:Label ID="labelGrupo" runat="server" Font-Bold="True" Font-Size="25pt" Text="GRUPO NO. 6"></asp:Label>
                        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                    <td class="auto-style8">
                        <asp:HyperLink ID="hyperlinkAgregar" runat="server" NavigateUrl="~/tp05EjercicioA.aspx">Agregar Sucursal</asp:HyperLink>
                    </td>
                    <td class="auto-style9"></td>
                    <td class="auto-style9"></td>
                    <td class="auto-style9"></td>
                    <td class="auto-style9"></td>
                    <td class="auto-style9"></td>
                </tr>
                <tr>
                    <td class="auto-style10">
                        <asp:Label ID="labelAgregar" runat="server" Font-Bold="True" Font-Size="20pt" Text="Agregar Sucursal"></asp:Label>
                    </td>
                    <td class="auto-style11"></td>
                    <td class="auto-style12"></td>
                    <td class="auto-style12"></td>
                    <td class="auto-style12"></td>
                    <td class="auto-style12"></td>
                    <td class="auto-style12"></td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="labelSucursal" runat="server" Text="Nombre Sucursal:"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="textboxNombre" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="labelDescripcion" runat="server" Text="Descripcion:"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="textboxDescripcion" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="labelProvincia" runat="server" Text="Provincia:"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:DropDownList ID="ddlProvincia" runat="server">
                        </asp:DropDownList>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="labelDireccion" runat="server" Text="Direccion:"></asp:Label>
                    </td>
                    <td class="auto-style6">
                        <asp:TextBox ID="textboxDireccion" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style4"></td>
                    <td class="auto-style4"></td>
                    <td class="auto-style4"></td>
                    <td class="auto-style4"></td>
                    <td class="auto-style4"></td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:Button ID="buttonAceptar" runat="server" OnClick="buttonAceptar_Click" Text="Aceptar" />
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
