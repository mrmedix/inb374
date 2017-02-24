<%@ Page Title="" Language="C#" MasterPageFile="~/WebClient.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebClient.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <p>
        New quotes awaiting customer approval: <asp:Label ID="NewQuotesCountLabel" runat="server"></asp:Label>
        <br />
        Quotes awaiting part stock level check: <asp:Label ID="CheckStockCountLabel" runat="server"></asp:Label>
        <br />
        Quotes awaiting approval of parts ETA: <asp:Label ID="ETACountLabel" runat="server"></asp:Label>
    </p>

</asp:Content>
