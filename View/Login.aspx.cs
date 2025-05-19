using System;
using System.Web.UI;
using FinalProject_PSD_EmpatSekawan.Handler;
using FinalProject_PSD_EmpatSekawan.Model;

namespace FinalProject_PSD_EmpatSekawan.View
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            UserHandler userHandler = new UserHandler();


            MsUser user = userHandler.LoginUser(email, password);
            if (user != null)
            {
                Session["User"] = user;
                Response.Redirect("~/Home.aspx");
            }
            else
            {
                lblError.Text = "Invalid email or password";
            }
        }
    }
}