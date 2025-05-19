using FinalProject_PSD_EmpatSekawan.Model;
using System;
using System.Web.UI;

namespace FinalProject_PSD_EmpatSekawan.View
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                UpdateNavigationVisibility();
            }
        }

        private void UpdateNavigationVisibility()
        {
            MsUser user = (MsUser)Session["User"];
            if (user == null)
            {
                pnlNonAuthenticated.Visible = true;
                pnlAdmin.Visible = false;
                pnlCustomer.Visible = false;
            }
            else
            {
                // string userRole = Session["UserRole"]?.ToString();
                string userRole = user.UserRole;
                LbUsername.Text = user.UserName;

                pnlNonAuthenticated.Visible = false;

                if (userRole == "Admin")
                {
                    pnlAdmin.Visible = true;
                    pnlCustomer.Visible = false;
                }
                else if (userRole == "Customer")
                {
                    pnlAdmin.Visible = false;
                    pnlCustomer.Visible = true;
                }
            }
        }

        protected void lnkLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();

            Response.Redirect("Home.aspx");
        }
    }
}