<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="FinalProject_PSD_EmpatSekawan.View.Home" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Jewelry Store</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" />
    <style>
        .navbar {
            background-color: #f8f9fa;
            box-shadow: 0 2px 4px rgba(0,0,0,.1);
        }
        .navbar-brand {
            font-weight: bold;
            color: #333 !important;
        }
        .nav-link {
            color: #555 !important;
            transition: color 0.3s ease;
        }
        .navbar-nav {
            display: flex;
            flex-direction: row !important;
            align-items: center;
        }
        .nav-item {
            display: inline-block;
            margin: 0 2px;
        }
        .nav-link:hover {
            color: #007bff !important;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <nav class="navbar navbar-expand-lg navbar-light">
            <div class="container">
                <a class="navbar-brand" href="Home.aspx">Jewelry Store</a>
                <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav" 
                        aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>
                <div class="collapse navbar-collapse" id="navbarNav">
                    <ul class="navbar-nav ms-auto">

                        <asp:Panel ID="pnlNonAuthenticated" runat="server" Visible="false">
                            <li class="nav-item">
                                <a class="nav-link" href="Home.aspx">Home</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href="Login.aspx">Login</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href="Register.aspx">Register</a>
                            </li>
                        </asp:Panel>

                        <asp:Panel ID="pnlAdmin" runat="server" Visible="false">
                             <li class="nav-item">
                                <a class="nav-link" href="Home.aspx">Home</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href="AddJewel.aspx">Add Jewel</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href="Reports.aspx">Reports</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href="HandleOrders.aspx">Handle Orders</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href="Profile.aspx">Profile</a>
                            </li>
                            <li class="nav-item">
                                <asp:LinkButton ID="lnkLogout" runat="server" CssClass="nav-link" OnClick="lnkLogout_Click">Logout</asp:LinkButton>
                            </li>
                        </asp:Panel>

                        <asp:Panel ID="pnlCustomer" runat="server" Visible="false">
                            <li class="nav-item">
                                <a class="nav-link" href="Home.aspx">Home</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href="Cart.aspx">Cart</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href="MyOrders.aspx">My Orders</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href="Profile.aspx">Profile</a>
                            </li>
                            <li class="nav-item">
                                <asp:LinkButton ID="lnkCustomerLogout" runat="server" CssClass="nav-link" OnClick="lnkLogout_Click">Logout</asp:LinkButton>
                            </li>
                        </asp:Panel>
                    </ul>
                </div>
            </div>
        </nav>

        <!-- Main content area -->
        <div class="container mt-4">
            <asp:Label ID="LbUsername" runat="server" Text=""></asp:Label>
        </div>
    </form>

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js"></script>
</body>
</html>
