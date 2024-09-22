<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Navbar.Master" AutoEventWireup="true" CodeBehind="InsertMakeupBrandPage.aspx.cs" Inherits="ProjectAkhirLab_PSD.Views.InsertMakeupBrandPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1>Insert Makeup Brand
        </h1>
    </div>
    <div>
        <asp:Label ID="brandnamelbl" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="brandnametxt" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="ratinglbl" runat="server" Text="Rating"></asp:Label>
        <asp:TextBox ID="ratingtxt" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Button ID="Insertbrand" runat="server" Text="Insert" OnClick="Insertbrand_Click" />
    </div>
    <asp:Label ID="errormess" runat="server" Text=""></asp:Label>
</asp:Content>
