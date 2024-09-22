<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Navbar.Master" AutoEventWireup="true" CodeBehind="InsertMakeupTypePage.aspx.cs" Inherits="ProjectAkhirLab_PSD.Views.InsertMakeupTypePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1>Insert Makeup Type
        </h1>
    </div>
    <div>
        <asp:Label ID="typenamelbl" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="typenametxt" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Button ID="Inserttype" runat="server" Text="Insert" OnClick="Inserttype_Click" />
    </div>
    <asp:Label ID="errmess" runat="server" Text=""></asp:Label>
</asp:Content>
