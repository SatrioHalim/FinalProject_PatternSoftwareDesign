using FinalProject_PSD_EmpatSekawan.Controller;
using FinalProject_PSD_EmpatSekawan.Handler;
using FinalProject_PSD_EmpatSekawan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject_PSD_EmpatSekawan.View
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            string gender = ddlGender.SelectedValue;
            DateTime dob = DateTime.Parse(txtDOB.Text);

            if (!System.Text.RegularExpressions.Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                lblError.Text = "Please enter a valid email address";
                return;
            }

            if (username.Length < 3 || username.Length > 25)
            {
                lblError.Text = "Username must be between 3 to 25 characters";
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(password, @"^[a-zA-Z0-9]{8,20}$"))
            {
                lblError.Text = "Password must be alphanumeric and between 8-20 characters";
                return;
            }

            if (password != confirmPassword)
            {
                lblError.Text = "Password and Confirm Password do not match";
                return;
            }

            UserController userController = new UserController();
            bool isRegistered = userController.RegisterUser(username, email, password, gender, dob);
            if (isRegistered)
            {
                Response.Redirect("~/View/Login.aspx");
            }
            else
            {
                lblError.Text = "Registration failed";
            }


        }
    }
}