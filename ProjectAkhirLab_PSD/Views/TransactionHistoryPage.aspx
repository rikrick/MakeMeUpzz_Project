<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Navbar.Master" AutoEventWireup="true" CodeBehind="TransactionHistoryPage.aspx.cs" Inherits="ProjectAkhirLab_PSD.Views.TransactionHistoryPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1>Transaction History</h1>
    </div>
    <div>
        <asp:GridView ID="transactiongv" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="TransactionID" HeaderText="ID" SortExpression="TransactionID" />
                <asp:BoundField DataField="User.Username" HeaderText="User" SortExpression="User.Username" />
                <asp:BoundField DataField="TransactionDate" HeaderText="Date" SortExpression="TransactionDate" />
                <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" />


                <asp:TemplateField HeaderText="Details">
                    <ItemTemplate>
                        <asp:Button ID="DetailButton" runat="server" Text="View Details" CommandArgument='<%# Eval("TransactionID") %>' OnClick="DetailButton_Click" />
                    </ItemTemplate>
                </asp:TemplateField>


            </Columns>
        </asp:GridView>
    </div>
    <div>
        <asp:Label ID="error" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
