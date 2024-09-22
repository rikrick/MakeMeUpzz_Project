using ProjectAkhirLab_PSD.Controllers;
using ProjectAkhirLab_PSD.Models;
using ProjectAkhirLab_PSD.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectAkhirLab_PSD.Views
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                if (Session["user_session"] != null || Request.Cookies["user_cookie"] != null)
                {

                    Response.Redirect("~/Views/HomePage.aspx");
                }
            }
        }

        protected void SubmitRegister_Click(object sender, EventArgs e)
        {
            String username = Usernametxtr.Text;
            String password = Passwordtxtr.Text;
            String confirmPassword = Confirmpasstxt.Text;
            String email = Emailtxt.Text;
            DateTime dates = Calendar1.SelectedDate;
            Boolean female = RBfemale.Checked;
            Boolean male = RBmale.Checked;
            Response<User> response = UserController.register(username, email, dates,
                female, male, password, confirmPassword);

            if (response.Success)
            {
                Response.Redirect("~/Views/LoginPage.aspx");
            }
            else
            {
                registerError.Text = response.Message;
            }
        }

        protected void LoginPageButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/LoginPage.aspx");
        }
    }
}