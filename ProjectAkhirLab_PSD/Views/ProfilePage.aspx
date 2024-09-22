<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Navbar.Master" AutoEventWireup="true" CodeBehind="ProfilePage.aspx.cs" Inherits="ProjectAkhirLab_PSD.Views.ProfilePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1>Profile</h1>
    </div>
    <h3>Update Profile</h3>
    <hr />
    <div>
        <asp:Label ID="unamelbl" runat="server" Text="Username"></asp:Label>
        <asp:TextBox ID="unametxt" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="uemaillbl" runat="server" Text="Email"></asp:Label>
        <asp:TextBox ID="uemailtxt" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:RadioButton ID="urbmale" runat="server" Text="Male" GroupName="Gender" />
        <asp:RadioButton ID="urbfemale" runat="server" Text="Female" GroupName="Gender" />
    </div>
    <div>
        <asp:Label ID="Label1" runat="server" Text="Date Of Birth: "></asp:Label>
        <asp:Label ID="calenderlbl" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <asp:Calendar ID="Calendarupdate" runat="server"></asp:Calendar>
    </div>
    <div>
        <asp:Button ID="UpdateProfilebtn" runat="server" Text="Update Profile" OnClick="UpdateProfilebtn_Click" />
    </div>
    <asp:Label ID="warlbl" runat="server" Text=""></asp:Label>

    <br />
    <br />

    <h3>Update Password</h3>
    <hr />
    <div>
        <asp:Label ID="oldpasslb" runat="server" Text="Old Password"></asp:Label>
        <asp:TextBox ID="oldpasstxt" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="newpasslbl" runat="server" Text="New Password"></asp:Label>
        <asp:TextBox ID="newpasstxt" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Button ID="UpdatePass" runat="server" Text="Update Password" OnClick="UpdatePass_Click" />
    </div>
    <asp:Label ID="warpasslbl" runat="server" Text=""></asp:Label>

    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>
