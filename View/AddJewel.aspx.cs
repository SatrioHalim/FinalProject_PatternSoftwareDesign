using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using FinalProject_PSD_EmpatSekawan.Controller;
using FinalProject_PSD_EmpatSekawan.Model;
using System.Collections.Generic;

namespace FinalProject_PSD_EmpatSekawan.View
{
    public partial class AddJewel : System.Web.UI.Page
    {
        private JewelController jewelController = new JewelController();
        private BrandController brandController = new BrandController();
        private CategoryController categoryController = new CategoryController();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsUserAdmin())
            {
                Response.Redirect("~/View/Login.aspx");
                return;
            }

            if (!IsPostBack)
            {
                LoadCategories();
                LoadBrands();
            }
        }

        private bool IsUserAdmin()
        {
            MsUser user = (MsUser)Session["User"];
            if (user == null)
                return false;
            return user.UserRole == "Admin";
        }

        private void LoadCategories()
        {
            List<MsCategory> categories = categoryController.GetAllCategories();
            ddlCategory.DataSource = categories;
            ddlCategory.DataTextField = "CategoryName";
            ddlCategory.DataValueField = "CategoryID";
            ddlCategory.DataBind();
            ddlCategory.Items.Insert(0, new ListItem("-- Select Category --", ""));
        }

        private void LoadBrands()
        {
            List<MsBrand> brands = brandController.GetAllBrands();
            ddlBrand.DataSource = brands;
            ddlBrand.DataTextField = "BrandName";
            ddlBrand.DataValueField = "BrandID";
            ddlBrand.DataBind();
            ddlBrand.Items.Insert(0, new ListItem("-- Select Brand --", ""));
        }

        protected void btnAddJewel_Click(object sender, EventArgs e)
        {

            string jewelName = txtJewelName.Text;
            string categoryID = ddlCategory.SelectedValue;
            string brandID = ddlBrand.SelectedValue;
            string price = txtPrice.Text;
            string releaseYear = txtReleaseYear.Text;

            if (string.IsNullOrEmpty(jewelName) || string.IsNullOrEmpty(categoryID) || string.IsNullOrEmpty(brandID) || string.IsNullOrEmpty(price) || string.IsNullOrEmpty(releaseYear))
            {
                lblMessage.Text = "Please fill in all fields.";
                return;
            }

            if (!decimal.TryParse(price, out decimal parsedPrice) || parsedPrice <= 0)
            {
                lblMessage.Text = "Price must be a positive number.";
                return;
            }

            if (!int.TryParse(releaseYear, out int parsedReleaseYear) || parsedReleaseYear <= 0)
            {
                lblMessage.Text = "Release year must be a positive number.";
                return;
            }

            jewelController.AddJewel(new MsJewel()
            {
                JewelName = jewelName,
                CategoryID = int.Parse(categoryID),
                BrandID = int.Parse(brandID),
                JewelPrice = (int)parsedPrice,
                JewelReleaseYear = parsedReleaseYear
            });

            lblMessage.Text = "Jewel added successfully!";
            ClearForm();
        }

        private void ClearForm()
        {
            txtJewelName.Text = string.Empty;
            ddlCategory.SelectedIndex = 0;
            ddlBrand.SelectedIndex = 0;
            txtPrice.Text = string.Empty;
            txtReleaseYear.Text = string.Empty;
        }
    }
}