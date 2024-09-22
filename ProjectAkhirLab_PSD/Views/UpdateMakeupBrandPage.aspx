<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Navbar.Master" AutoEventWireup="true" CodeBehind="UpdateMakeupBrandPage.aspx.cs" Inherits="ProjectAkhirLab_PSD.Views.UpdateMakeupBrandPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1>Update Makeup Brand
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
        <asp:Button ID="Updatebrand" runat="server" Text="Update" OnClick="Updatebrand_Click"/>
    </div>
    <asp:Label ID="errormess" runat="server" Text=""></asp:Label>
</asp:Content>
