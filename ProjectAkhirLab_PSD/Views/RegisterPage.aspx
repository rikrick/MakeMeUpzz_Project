<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="ProjectAkhirLab_PSD.Views.RegisterPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Register Page</h1>
        <div>
            <asp:Label ID="Usernamelblr" runat="server" Text="Username"></asp:Label>
            <asp:TextBox ID="Usernametxtr" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Emaillbl" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="Emailtxt" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:RadioButton ID="RBmale" runat="server" Text="Male" GroupName="Gender" />
            <asp:RadioButton ID="RBfemale" runat="server" Text="Female" GroupName="Gender" />
        </div>
        <div>
            <asp:Label ID="Passwordlblr" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="Passwordtxtr" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Confirmpasslbl" runat="server" Text="Comfirm Password"></asp:Label>
            <asp:TextBox ID="Confirmpasstxt" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        </div>
        <div>
            <asp:Button ID="SubmitRegister" runat="server" Text="Submit" OnClick="SubmitRegister_Click" />
        </div>
        <div>
            <asp:LinkButton ID="LoginPageButton" runat="server" Text="Already have an account? Login here!" OnClick="LoginPageButton_Click" />
        </div>
        <div>
            <asp:Label ID="registerError" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
