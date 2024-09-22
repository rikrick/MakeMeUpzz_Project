<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="ProjectAkhirLab_PSD.Views.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Login Page</h1>
        <div>
            <asp:Label ID="Usernamelbl" runat="server" Text="Username"></asp:Label>
            <asp:TextBox ID="Usernametxt" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Passwordlbl" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="Passwordtxt" runat="server" TextMode="Password"></asp:TextBox>
        </div>
        <div>
            <asp:CheckBox ID="rememberMeLogin" runat="server" Text="Remember Me" />
        </div>
        <div>
            <asp:Button ID="SubmitLogin" runat="server" Text="Login" OnClick="SubmitLogin_Click" />
        </div>
        <div>
            <asp:LinkButton ID="RegisterPageButton" runat="server" Text="Don't have an account? Register here!" OnClick="RegisterPageButton_Click" />
        </div>
        <div>
            <asp:Label ID="errorLabel" runat="server" Text="" />
        </div>
    </form>
</body>
</html>
