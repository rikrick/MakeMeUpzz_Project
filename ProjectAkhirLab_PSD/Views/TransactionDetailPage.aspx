<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Navbar.Master" AutoEventWireup="true" CodeBehind="TransactionDetailPage.aspx.cs" Inherits="ProjectAkhirLab_PSD.Views.TransactionDetailPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1>Transaction Detail</h1>
    </div>
    <div>
        <asp:Label ID="error" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <asp:GridView ID="detailgv" runat="server" AutoGenerateColumns="False">
            <columns>
                <asp:BoundField DataField="Makeup.MakeupName" HeaderText="Makeup" SortExpression="Makeup.MakeupName" />
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
            </columns>
        </asp:GridView>
    </div>
</asp:Content>
