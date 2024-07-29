<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Paginas/Site.Master" CodeBehind="Municipio.aspx.vb" Inherits="Telefonia.Municipio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table class="w-100">
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td colspan="2">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">Codigo</td>
            <td colspan="3">
                <asp:TextBox ID="txtCodMun" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td colspan="2">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">Municipio</td>
            <td colspan="3">
                <asp:TextBox ID="txtNameMun" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">&nbsp;</td>
            <td colspan="3">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">Cod_Dept</td>
            <td colspan="3">
                <asp:TextBox ID="txtCodDept" runat="server" Enabled="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">&nbsp;</td>
            <td colspan="3">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="btnFirst" runat="server" Text="Primero" />
            </td>
            <td>
                <asp:Button ID="btnPrev" runat="server" Text="Anterior" />
            </td>
            <td>
                <asp:Button ID="btnNext" runat="server" Text="Siguiente" />
            </td>
            <td>
                <asp:Button ID="btnLast" runat="server" Text="Ultimo" />
            </td>
        </tr>
        <tr>
            <td colspan="2">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="btnNew" runat="server" Text="Nuevo" />
            </td>
            <td>
                <asp:Button ID="btnInsert" runat="server" Text="Insertar" />
            </td>
            <td>
                <asp:Button ID="btnUpdate" runat="server" Text="Actualizar" />
            </td>
            <td>
                <asp:Button ID="btnDelet" runat="server" Text="Eliminar" />
            </td>
        </tr>
    </table>
</asp:Content>
