<%@ Page Title="" Language="C#" MasterPageFile="~/WebClient.Master" AutoEventWireup="true" CodeBehind="EditQuote.aspx.cs" Inherits="WebClient.EditQuote" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="main">
    <h1>Quote #<asp:Label ID="QuoteNumberLabel" runat="server"></asp:Label></h1>
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
        <tr>
            <td>Status</td><td><asp:DropDownList runat="server" ID="StatusDropDownList"></asp:DropDownList></td>
        </tr>
    </table>
    <p>
       Parts ETA: <asp:Label ID="ETALabel" runat="server" Text=""></asp:Label><br />
        </p>
        <p>
    <asp:Button ID="SaveButton" runat="server" Text="Save Changes" OnClick="SaveButton_Click" />
    &nbsp;<asp:LinkButton ID="ApproveLinkButton" runat="server" Visible="false" OnClick="ApproveLinkButton_Click">Approve</asp:LinkButton>&nbsp;<asp:LinkButton ID="CheckStockLinkButton" runat="server" Visible="false" OnClick="CheckStockLinkButton_Click">Check stock</asp:LinkButton>
                &nbsp;<asp:LinkButton ID="GetETALinkButton" runat="server" Visible="false" OnClick="GetETALinkButton_Click">Get parts ETA</asp:LinkButton>
            &nbsp;<asp:LinkButton ID="BookLinkButton" runat="server" Visible="false" OnClick="BookLinkButton_Click">Book service</asp:LinkButton>&nbsp;<asp:LinkButton ID="RejectLinkButton" runat="server" Visible="false" OnClick="RejectLinkButton_Click">Reject</asp:LinkButton>
        </p>
    <p>
        <asp:Literal EnableViewState="false" ID="StatusLiteral" runat="server"></asp:Literal>
    </p>
        </div>
</asp:Content>
