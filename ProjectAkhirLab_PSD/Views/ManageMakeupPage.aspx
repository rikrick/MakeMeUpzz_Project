<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/Navbar.Master" AutoEventWireup="true" CodeBehind="ManageMakeupPage.aspx.cs" Inherits="ProjectAkhirLab_PSD.Views.ManageMakeupPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Manage Makeup</h1>

    <h3>Makeup</h3>
    <div>
        <asp:GridView ID="makeupgridview" runat="server" AutoGenerateColumns="False" OnRowDeleting="makeupgridview_RowDeleting" OnRowEditing="makeupgridview_RowEditing">
            <Columns>
                <asp:BoundField DataField="MakeupID" HeaderText="ID" SortExpression="MakeupID" />
                <asp:BoundField DataField="MakeupName" HeaderText="Name" SortExpression="MakeupName" />
                <asp:BoundField DataField="MakeupPrice" HeaderText="Price(Rp)" SortExpression="MakeupPrice" />
                <asp:BoundField DataField="MakeupWeight" HeaderText="Weight(grams)" SortExpression="MakeupWeight" />
                <asp:BoundField DataField="MakeupType.MakeupTypeName" HeaderText="Type" SortExpression="MakeupType.MakeupTypeName" />
                <asp:BoundField DataField="MakeupBrand.MakeupBrandName" HeaderText="Brand" SortExpression="MakeupBrand.MakeupBrandName" />
                <asp:CommandField ButtonType="Button" HeaderText="Update &amp; Delete" ShowCancelButton="False" ShowDeleteButton="True" ShowEditButton="True" ShowHeader="True" />
            </Columns>
        </asp:GridView>
    </div>
    <div>
        <asp:Button ID="InsertMakeup" runat="server" Text="Insert Makeup" OnClick="InsertMakeup_Click" />
    </div>
    <div>
        <asp:Label ID="errors" runat="server" Text=""></asp:Label>
    </div>


    <br />
    <h3>Makeup Type</h3>
    <div>
        <asp:GridView ID="makeuptypegv" runat="server" AutoGenerateColumns="False" OnRowDeleting="makeuptypegv_RowDeleting" OnRowEditing="makeuptypegv_RowEditing">
            <Columns>
                <asp:BoundField DataField="MakeupTypeID" HeaderText="ID" SortExpression="MakeupTypeID" />
                <asp:BoundField DataField="MakeupTypeName" HeaderText="Name" SortExpression="MakeupTypeName" />
                <asp:CommandField ButtonType="Button" HeaderText="Update &amp; Delete" ShowCancelButton="False" ShowDeleteButton="True" ShowEditButton="True" ShowHeader="True" />
            </Columns>
        </asp:GridView>
    </div>
    <div>
        <asp:Button ID="Insertypebtn" runat="server" Text="Insert Makeup Type" OnClick="Insertypebtn_Click" />
    </div>
    <div>
        <asp:Label ID="errortype" runat="server" Text=""></asp:Label>
    </div>



    <br />
    <h3>Makeup Brand</h3>
    <div>
        <asp:GridView ID="makeupbrandgv" runat="server" AutoGenerateColumns="False" OnRowDeleting="makeupbrandgv_RowDeleting" OnRowEditing="makeupbrandgv_RowEditing">
            <Columns>
                <asp:BoundField DataField="MakeupBrandID" HeaderText="ID" SortExpression="MakeupBrandID" />
                <asp:BoundField DataField="MakeupBrandName" HeaderText="Name" SortExpression="MakeupBrandName" />
                <asp:BoundField DataField="MakeupBrandRating" HeaderText="Rating" SortExpression="MakeupBrandRating" />
                <asp:CommandField ButtonType="Button" HeaderText="Update &amp; Delete" ShowCancelButton="False" ShowDeleteButton="True" ShowEditButton="True" ShowHeader="True" />
            </Columns>
        </asp:GridView>
    </div>
    <div>
        <asp:Button ID="Insertbrand" runat="server" Text="Insert Makeup Brand" OnClick="Insertbrand_Click" />
    </div>
    <div>
        <asp:Label ID="errorbrand" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
