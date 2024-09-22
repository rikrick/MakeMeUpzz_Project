﻿using ProjectAkhirLab_PSD.Controllers;
using ProjectAkhirLab_PSD.Models;
using ProjectAkhirLab_PSD.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.Util;

namespace ProjectAkhirLab_PSD.Views
{
    public partial class TransactionHistoryPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (!Page.IsPostBack)
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

                        if (adminResponse.Success)
                        {
                            Response<List<TransactionHeader>> response = TransactionHeaderController.getalltransaction();
                            transactiongv.DataSource = response.Payload;
                            transactiongv.DataBind();
                        }
                        else
                        {
                            int id = Convert.ToInt32(Request.Cookies["user_cookie"].Value);
                            Response<List<TransactionHeader>> response = TransactionHeaderController.getalltransactionbyuserid(id);
                            transactiongv.DataSource = response.Payload;
                            transactiongv.DataBind();
                        }
                    }
                }
            }

        }

        protected void DetailButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string id = Convert.ToString(btn.CommandArgument);
            Response.Redirect("~/Views/TransactionDetailPage.aspx?id=" + id);
        }
    }
}