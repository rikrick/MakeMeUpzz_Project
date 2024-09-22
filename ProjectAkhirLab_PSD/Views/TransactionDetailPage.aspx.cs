﻿using ProjectAkhirLab_PSD.Controllers;
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
    public partial class TransactionDetailPage : System.Web.UI.Page
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

                    int ids = Convert.ToInt32(Request.QueryString["id"]);
                    /*error.Text = ids.ToString();*/

                    Response<List<TransactionDetail>> responses = TransactionDetailController.getalldetail(ids);
                    detailgv.DataSource = responses.Payload;
                    detailgv.DataBind();

                }
            }
        }
    }
}