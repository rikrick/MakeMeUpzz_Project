<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Navbar.Master" AutoEventWireup="true" CodeBehind="HandleTransactionPage.aspx.cs" Inherits="ProjectAkhirLab_PSD.Views.HandleTransactionPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Handle Transaction
    </h1>
    <div>
        <asp:GridView ID="handlegv" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="TransactionID" HeaderText="ID" SortExpression="TransactionID" />
                <asp:BoundField DataField="User.Username" HeaderText="User" SortExpression="User.Username" />
                <asp:BoundField DataField="TransactionDate" HeaderText="Date" SortExpression="TransactionDate" />
                <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" />

                <asp:TemplateField HeaderText="Handle">
                    <ItemTemplate>
                        <asp:Button ID="handlebtn" runat="server" Text="Handle" OnClick="handlebtn_Click" CommandArgument='<%# Eval("TransactionID") %>' />
                    </ItemTemplate>
                </asp:TemplateField>

            </Columns>

        </asp:GridView>
    </div>
</asp:Content>
