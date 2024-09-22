<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Navbar.Master" AutoEventWireup="true" CodeBehind="OrderMakeupXPage.aspx.cs" Inherits="ProjectAkhirLab_PSD.Views.OrderMakeupXPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Order Makeup X
    </h1>
    <div>
        <asp:GridView ID="ordergv" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="MakeupName" HeaderText="Name" SortExpression="MakeupName" />
                <asp:BoundField DataField="MakeupPrice" HeaderText="Price" SortExpression="MakeupPrice" />
                <asp:BoundField DataField="MakeupWeight" HeaderText="Weight" SortExpression="MakeupWeight" />
                <asp:BoundField DataField="MakeupType.MakeupTypeName" HeaderText="Type" SortExpression="MakeupType.MakeupTypeName" />
                <asp:BoundField DataField="MakeupBrand.MakeupBrandName" HeaderText="Brand" SortExpression="MakeupBrand.MakeupBrandName" />
                <asp:TemplateField HeaderText="Quantity">
                    <ItemTemplate>
                        <asp:TextBox ID="Quantitytxt" runat="server"></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Order">
                    <ItemTemplate>
                        <asp:Button ID="Orderbutton" runat="server" Text="Order" CommandArgument='<%# Eval("MakeupID") %>' OnClick="Orderbutton_Click" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:Label ID="Testmess" runat="server" Text=""></asp:Label>
    </div>
    <br />


    <!--Gridview Cart -->
    <div>
        <h2>Cart
        </h2>
    </div>
    <div>
        <asp:GridView ID="cartgv" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="CartID" HeaderText="ID" SortExpression="CartID" />
                <asp:BoundField DataField="User.Username" HeaderText="User" SortExpression="User.Username" />
                <asp:BoundField DataField="Makeup.MakeupName" HeaderText="Makeup" SortExpression="Makeup.MakeupName" />
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
            </Columns>
        </asp:GridView>
    </div>
    <div>
        <asp:Button ID="clearbtn" runat="server" Text="Clear Cart" OnClick="clearbtn_Click" />
        <asp:Button ID="checkbtn" runat="server" Text="Checkout" OnClick="checkbtn_Click" />
    </div>
    <asp:Label ID="cartmess" runat="server" Text=""></asp:Label>
</asp:Content>
