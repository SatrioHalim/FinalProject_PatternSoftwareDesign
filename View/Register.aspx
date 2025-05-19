<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="FinalProject_PSD_EmpatSekawan.View.Register" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="register-container">
            <h1 class="register-title">Register</h1>
            <div class="form-group">
                <label for="txtEmail">Email</label>
                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" TextMode="Email" placeholder="Enter your email" required></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtUsername">Username</label>
                <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control" placeholder="Enter your username" required></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtPassword">Password</label>
                <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" TextMode="Password" placeholder="Enter your password" required></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtConfirmPassword">Confirm Password</label>
                <asp:TextBox ID="txtConfirmPassword" runat="server" CssClass="form-control" TextMode="Password" placeholder="Confirm your password" required></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="ddlGender">Gender</label>
                <asp:DropDownList ID="ddlGender" runat="server" CssClass="form-control">
                    <asp:ListItem Text="Select Gender" Value="" />
                    <asp:ListItem Text="Male" Value="Male" />
                    <asp:ListItem Text="Female" Value="Female" />
                </asp:DropDownList>
            </div>
            <div class="form-group">
                <label for="txtDOB">Date of Birth</label>
                <asp:TextBox ID="txtDOB" runat="server" CssClass="form-control" TextMode="Date" required></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Button ID="btnRegister" runat="server" Text="Register" CssClass="btn-register" OnClick="btnRegister_Click" />
            </div>
            <asp:Label ID="lblError" runat="server" CssClass="error-message" Visible="true" Text=""></asp:Label>
            <div class="login-link">
                <a href="../View/Login.aspx">Login here</a>
            </div>
        </div>
    </form>
</body>
</html>
