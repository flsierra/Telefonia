<%@ Page Title="About" Language="VB" MasterPageFile="Site.Master" AutoEventWireup="true" CodeBehind="Departamento.aspx.vb" Inherits="Telefonia.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        
            &nbsp;
            <table class="w-100">
                <tr>
                    <td colspan="2">Nombre</td>
                    <td colspan="2">
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">&nbsp;</td>
                    <td colspan="2">
                        &nbsp;</td>
                </tr>
                <tr>                
                    <td colspan="2">Codigo</td>
                    <td colspan="2">
                        <asp:TextBox ID="txtCod" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>                
                    <td colspan="2">&nbsp;</td>
                    <td colspan="2">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lbCod" runat="server" Text="Codigo Nuevo" Visible="False"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtNewCod" runat="server" Visible="False"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="2">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
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
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnNew" runat="server" Text="Nuevo" />
                    </td>
                    <td>
                        <asp:Button ID="btnInsert" runat="server" Text="Insertar" />
                    </td>
                    <td>
                        <asp:Button ID="btnUpdate" runat="server" Text="Actualizar" Visible="False" />
                        <asp:Button ID="btnAction" runat="server" Text="Actualizar Registro" />
                    </td>
                    <td>
                        <asp:Button ID="btnDelet" runat="server" Text="Eliminar" />
                    </td>
                    <br />
                </tr>
            </table>
    </h2>
    </main>
</asp:Content>
