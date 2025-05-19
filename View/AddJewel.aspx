<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddJewel.aspx.cs" Inherits="FinalProject_PSD_EmpatSekawan.View.AddJewel" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add New Jewel</title>
    <%--<style>
        .error-message {
            color: red;
            margin-top: 5px;
        }
        .form-group {
            margin-bottom: 15px;
        }
        .form-control {
            width: 100%;
            padding: 8px;
            margin-top: 5px;
        }
        .btn-submit {
            padding: 10px 20px;
            background-color: #4CAF50;
            color: white;
            border: none;
            cursor: pointer;
        }
        .btn-submit:hover {
            background-color: #45a049;
        }
    </style>--%>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Add New Jewel</h2>
            
            <div class="form-group">
                <asp:Label ID="lblJewelName" runat="server" Text="Jewel Name:"></asp:Label>
                <asp:TextBox ID="txtJewelName" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <div class="form-group">
                <asp:Label ID="lblCategory" runat="server" Text="Category:"></asp:Label>
                <asp:DropDownList ID="ddlCategory" runat="server" CssClass="form-control">
                </asp:DropDownList>
            </div>

            <div class="form-group">
                <asp:Label ID="lblBrand" runat="server" Text="Brand:"></asp:Label>
                <asp:DropDownList ID="ddlBrand" runat="server" CssClass="form-control">
                </asp:DropDownList>
            </div>

            <div class="form-group">
                <asp:Label ID="lblPrice" runat="server" Text="Price:"></asp:Label>
                <asp:TextBox ID="txtPrice" runat="server" CssClass="form-control" TextMode="Number" Step="0.01"></asp:TextBox>
            </div>

            <div class="form-group">
                <asp:Label ID="lblReleaseYear" runat="server" Text="Release Year:"></asp:Label>
                <asp:TextBox ID="txtReleaseYear" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
            </div>

            <div class="form-group">
                <asp:Button ID="btnAddJewel" runat="server" Text="Add Jewel" CssClass="btn-submit" OnClick="btnAddJewel_Click" />
            </div>

            <asp:Label ID="lblMessage" runat="server" CssClass="error-message"></asp:Label>
        </div>
    </form>
</body>
</html>
