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
    public partial class LoginPage : System.Web.UI.Page
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

        protected void SubmitLogin_Click(object sender, EventArgs e)
        {
            String username = Usernametxt.Text;
            String password = Passwordtxt.Text;
            Boolean Rememberme = rememberMeLogin.Checked;
            Response<User> response = UserController.login(username, password, Rememberme);

            if (response.Success)
            {
                if (UserController.Cookies(response.Payload, Rememberme) != null)
                {
                    HttpCookie cookie = UserController.Cookies(response.Payload, Rememberme);
                    Response.Cookies.Add(cookie);

                }
                Session["user_session"] = response.Payload;

                Response.Redirect("~/Views/HomePage.aspx");
            }
            else
            {
                errorLabel.Text = response.Message;
            }
        }

        protected void RegisterPageButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/RegisterPage.aspx");
        }
    }
}