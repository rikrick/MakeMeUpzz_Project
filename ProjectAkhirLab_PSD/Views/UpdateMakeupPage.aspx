<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Navbar.Master" AutoEventWireup="true" CodeBehind="UpdateMakeupPage.aspx.cs" Inherits="ProjectAkhirLab_PSD.Views.UpdateMakeupPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1>Update Makeup</h1>
    </div>
    <div>
        <asp:Label ID="makeupnamelbl" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="makeupnametxt" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="pricelbl" runat="server" Text="Price"></asp:Label>
        <asp:TextBox ID="pricetxt" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="weightlbl" runat="server" Text="Weight"></asp:Label>
        <asp:TextBox ID="weighttxt" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Typelbl" runat="server" Text="Type"></asp:Label>
        <asp:DropDownList ID="typedropdown" runat="server"></asp:DropDownList>
    </div>
    <div>
        <asp:Label ID="brandlbl" runat="server" Text="Brand"></asp:Label>
        <asp:DropDownList ID="branddropdown" runat="server"></asp:DropDownList>
    </div>
    <div>
        <asp:Button ID="Updatemakeupbtn" runat="server" Text="Update" OnClick="Updatemakeupbtn_Click" />
    </div>
    <div>
        <asp:Label ID="errormess" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
