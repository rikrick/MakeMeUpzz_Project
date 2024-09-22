using ProjectAkhirLab_PSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectAkhirLab_PSD.Layouts
{
    public partial class Navbar : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User currentUser = Session["user_session"] as User;
            String Userrole = currentUser.UserRole;

            if (Userrole.Equals("Admin"))
            {
                AdminNavbar.Visible = true;
            }
            else
            {
                CustomerNavbar.Visible = true;

            }
        }

        protected void OrderMakeupbutton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/OrderMakeupXPage.aspx");
        }

        protected void Historybutton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/TransactionHistoryPage.aspx");
        }

        protected void Profilebutton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/ProfilePage.aspx");
        }

        protected void Logoutbutton_Click(object sender, EventArgs e)
        {
            Session["user_session"] = null;
            Session.Abandon();

            Response.Cookies["user_cookie"].Expires = DateTime.Now.AddDays(-1);
            Response.Redirect("~/Views/LoginPage.aspx");
        }

        protected void Homebutton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/HomePage.aspx");
        }

        protected void Managebtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/ManageMakeupPage.aspx");
        }

        protected void Orderbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/HandleTransactionPage.aspx");
        }

        protected void profilebtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/ProfilePage.aspx");
        }

        protected void reportbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/ReportPage.aspx");
        }

        protected void Historyadmin_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/TransactionHistoryPage.aspx");
        }

        protected void Logoutbtn_Click(object sender, EventArgs e)
        {
            Session["user_session"] = null;
            Session.Abandon();

            Response.Cookies["user_cookie"].Expires = DateTime.Now.AddDays(-1);
            Response.Redirect("~/Views/LoginPage.aspx");
        }
    }
}