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
    public partial class ManageMakeupPage : System.Web.UI.Page
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
                    else
                    {
                        if (!IsPostBack)
                        {
                            makeupgv();
                            typegv();
                            brandgv();

                        }
                    }

                }
            }
        }

        private void makeupgv()
        {
            Response<List<Makeup>> makeups = MakeupController.getallmakeup();
            makeupgridview.DataSource = makeups.Payload;
            makeupgridview.DataBind();
        }
        private void typegv()
        {
            Response<List<MakeupType>> types = MakeupTypeController.getallmakeuptype();
            makeuptypegv.DataSource = types.Payload;
            makeuptypegv.DataBind();
        }
        private void brandgv()
        {
            Response<List<MakeupBrand>> brands = MakeupBrandController.getallmakeupbrand();
            makeupbrandgv.DataSource = brands.Payload;
            makeupbrandgv.DataBind();
        }

        protected void makeupgridview_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = makeupgridview.Rows[e.RowIndex];
            String id = row.Cells[0].Text;

            Response<Makeup> deleted = MakeupController.deletemakeup(Convert.ToInt32(id));

            makeupgv();
            //errors.Text = deleted.Message;
        }

        protected void makeupgridview_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = makeupgridview.Rows[e.NewEditIndex];
            string id = row.Cells[0].Text;
            Response.Redirect("~/Views/UpdateMakeupPage.aspx?id=" + id);
        }

        protected void InsertMakeup_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/InsertMakeupPage.aspx");
        }

        protected void makeuptypegv_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = makeupgridview.Rows[e.RowIndex];
            String id = row.Cells[0].Text;

            Response<Makeup> deleted = MakeupController.deletemakeup(Convert.ToInt32(id));

            makeupgv();
            //errors.Text = deleted.Message;
        }

        protected void makeuptypegv_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = makeuptypegv.Rows[e.NewEditIndex];
            string id = row.Cells[0].Text;
            Response.Redirect("~/Views/UpdateMakeupTypePage.aspx?id=" + id);
        }

        protected void Insertypebtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/InsertMakeupTypePage.aspx");
        }

        protected void makeupbrandgv_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = makeupbrandgv.Rows[e.RowIndex];
            String id = row.Cells[0].Text;

            Response<MakeupBrand> deleted = MakeupBrandController.deletebrand(Convert.ToInt32(id));

            brandgv();
            //errorbrand.Text = deleted.Message;
        }

        protected void makeupbrandgv_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = makeupbrandgv.Rows[e.NewEditIndex];
            string id = row.Cells[0].Text;
            Response.Redirect("~/Views/UpdateMakeupBrandPage.aspx?id=" + id);
        }

        protected void Insertbrand_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/InsertMakeupBrandPage.aspx");
        }
    }
}