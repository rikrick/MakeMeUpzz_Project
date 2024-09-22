using ProjectAkhirLab_PSD.Controllers;
using ProjectAkhirLab_PSD.Models;
using ProjectAkhirLab_PSD.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace ProjectAkhirLab_PSD.Views
{
    public partial class ProfilePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                User currentUser = null;

                if (Session["user_session"] == null && Request.Cookies["user_cookie"] == null)
                {

                    Response.Redirect("~/Views/LoginPage.aspx");
                }
                else
                {
                    if (Session["user_session"] == null)
                    {
                        int id = Convert.ToInt32(Request.Cookies["user_cookie"].Value);
                        Response<User> response = UserController.getUserByID(id);
                        currentUser = response.Payload;
                        Session["user_session"] = currentUser;
                    }
                    else
                    {
                        /* currentUser = Session["user_session"] as User;*/
                        currentUser = (User)Session["user_session"];

                    }
                }



                unametxt.Text = currentUser.Username;
                uemailtxt.Text = currentUser.UserEmail;
                calenderlbl.Text = currentUser.UserDOB.ToString();
                Calendarupdate.SelectedDate = currentUser.UserDOB;
                if (currentUser.UserGender.Equals("Female"))
                {
                    urbfemale.Checked = true;
                }
                else
                {
                    urbmale.Checked = true;
                }


            }
        }

        protected void UpdateProfilebtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.Cookies["user_cookie"].Value);
            String name = unametxt.Text;
            String email = uemailtxt.Text;
            DateTime Calendar = Calendarupdate.SelectedDate;
            Boolean female = urbfemale.Checked;
            Boolean male = urbmale.Checked;
            Response<User> response = UserController.Updateprofiles(id, name, email, female, male,
                Calendar);
            warlbl.Text = response.Message;
        }

        protected void UpdatePass_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.Cookies["user_cookie"].Value);
            String oldpass = oldpasstxt.Text;
            string newpass = newpasstxt.Text;
            Response<User> response = UserController.Updatepass(id, oldpass, newpass);
            warpasslbl.Text = response.Message;
        }
    }
}