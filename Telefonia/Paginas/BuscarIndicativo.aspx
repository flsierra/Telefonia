<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Paginas/Site.Master" CodeBehind="BuscarIndicativo.aspx.vb" Inherits="Telefonia.BuscarIndicativo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <center>
        <h1>Buscar Indicativo </h1>
        <p>Acá podra buscar el indicativo correspondiente a una ciudad</p>
        <table class="w-100">
            <tr>
                <td style="width: 399px">&nbsp;</td>
                <td colspan="3">&nbsp;</td>
            </tr>
            <tr>
               <center> <td style="width: 399px">Ingrese el indicativo que quiere consultar</td></center>
                <td colspan="3">
                    <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 399px">&nbsp;</td>
                <td>
                    <asp:Button ID="btnSearch" runat="server" Text="Buscar" />
                </td>
                <td>
                    <asp:Button ID="btnClear" runat="server" Text="Limpiar" Visible="False" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td colspan="4">&nbsp;</td>
            </tr>
            <tr>
                <td colspan="4">
                    <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Visible="False">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        <EditRowStyle BackColor="#999999" />
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#E9E7E2" />
                        <SortedAscendingHeaderStyle BackColor="#506C8C" />
                        <SortedDescendingCellStyle BackColor="#FFFDF8" />
                        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                    </asp:GridView>
                </td>
            </tr>
        </table>
    </center>

</asp:Content>
