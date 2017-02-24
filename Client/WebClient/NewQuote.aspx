<%@ Page Title="" Language="C#" MasterPageFile="~/WebClient.Master" AutoEventWireup="true" CodeBehind="NewQuote.aspx.cs" Inherits="WebClient.NewQuote" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Customer
        <asp:DropDownList ID="CustomerDropDownList" runat="server">
        </asp:DropDownList>
    </p>
    <table>
        <tr>
            <td>Part</td>
            <td>Quantity</td>
        </tr>
        <tr>
            <td>
                <asp:DropDownList ID="PartDropDownList1" runat="server"></asp:DropDownList></td>
            <td>
                <asp:TextBox ID="QuantityTextBox1" runat="server" MaxLength="3" Columns="3"></asp:TextBox></td>
        </tr>
    </table>
    <table>
        <tr>
            <td>Labour details
            </td>
            <td>Labour price
            </td>
        </tr>
        <tr>
            <td>
                <textarea id="LabourTextArea" cols="50" rows="4" runat="server"></textarea>
            </td>
            <td style="vertical-align:top">
                <asp:TextBox ID="LabourPriceTextBox" runat="server" MaxLength="4" Columns="4"></asp:TextBox>
            </td>
        </tr>
    </table>
    <p>
    <asp:Button ID="SaveQuoteButton" runat="server" Text="Save Quote" OnClick="SaveQuoteButton_Click" />

        <br />
        <asp:Label ID="StatusLabel" runat="server"></asp:Label>

    </p>

</asp:Content>
