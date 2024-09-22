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
    public partial class UpdateMakeupPage : System.Web.UI.Page
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

                    Response<List<User>> adminResponse = UserController.adminvalidation(currentUser);

                    if (!adminResponse.Success)
                    {
                        Response.Redirect("~/Views/HomePage.aspx");
                        //customer cannot access
                    }
                    else if (Request.QueryString["id"] == null)
                    {
                        Response.Redirect("~/Views/ManageMakeupPage.aspx");
                    }
                    else
                    {

                        Response<List<MakeupType>> type = MakeupTypeController.getallmakeuptype();
                        typedropdown.DataSource = type.Payload;
                        typedropdown.DataTextField = "MakeupTypeName";
                        typedropdown.DataValueField = "MakeupTypeID";
                        typedropdown.DataBind();

                        Response<List<MakeupBrand>> brand = MakeupBrandController.getallmakeupbrandasc();
                        branddropdown.DataSource = brand.Payload;
                        branddropdown.DataTextField = "MakeupBrandName";
                        branddropdown.DataValueField = "MakeupBrandID";
                        branddropdown.DataBind();

                        int id = Convert.ToInt32(Request.QueryString["id"]);
                        Response<Makeup> response = MakeupController.getmakeupbyID(id);
                        Makeup makeup = response.Payload;
                        makeupnametxt.Text = makeup.MakeupName;
                        pricetxt.Text = makeup.MakeupPrice.ToString();
                        weighttxt.Text = makeup.MakeupWeight.ToString();
                        typedropdown.SelectedValue = makeup.MakeupTypeID.ToString();
                        branddropdown.SelectedValue = makeup.MakeupBrandID.ToString();


                    }

                }
            }
        }

        protected void Updatemakeupbtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            String name = makeupnametxt.Text;
            string price = pricetxt.Text;
            string weight = weighttxt.Text;
            int type = Convert.ToInt32(typedropdown.SelectedValue);
            int brand = Convert.ToInt32(branddropdown.SelectedValue);
            Response<Makeup> makeups = MakeupController.Updatemakeup(id, name, price, weight, type, brand);
            if (makeups.Success)
            {
                Response.Redirect("~/Views/ManageMakeupPage.aspx");
            }
            else
            {
                errormess.Text = makeups.Message;
            }
        }
    }
}