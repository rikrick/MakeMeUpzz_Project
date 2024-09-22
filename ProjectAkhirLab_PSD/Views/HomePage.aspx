<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Navbar.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="ProjectAkhirLab_PSD.Views.HomePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div>
            <h1>Home Page</h1>
            <asp:Label ID="Welcomelabel" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="usercountlabel" runat="server" Text=""></asp:Label>
            <asp:GridView ID="usergridview" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="UserID" HeaderText="UserID" SortExpression="UserID"/>
                    <asp:BoundField DataField="Username" HeaderText="Username" SortExpression="Username" />
                    <asp:BoundField DataField="UserEmail" HeaderText="Email" SortExpression="UserEmail" />
                    <asp:BoundField DataField="UserDOB" HeaderText="DOB" SortExpression="UserDOB" />
                    <asp:BoundField DataField="UserGender" HeaderText="Gender" SortExpression="UserGender" />
                    <asp:BoundField DataField="UserRole" HeaderText="Role" SortExpression="UserRole" />
                    <asp:BoundField DataField="UserPassword" HeaderText="Password" SortExpression="UserPassword" />
                </Columns>
            </asp:GridView>
        </div>

</asp:Content>
