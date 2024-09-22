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
    public partial class OrderMakeupXPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
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
                        Response.Redirect("~/Views/HomePage.aspx");
                        //Admin cannot access
                    }
                    else
                    {
                        ordergrid();
                        cartgrid();
                    }

                }

            }
        }

        private void ordergrid()
        {
            Response<List<Makeup>> makeups = MakeupController.getallmakeup();
            ordergv.DataSource = makeups.Payload;
            ordergv.DataBind();
        }

        private void cartgrid()
        {
            int id = Convert.ToInt32(Request.Cookies["user_cookie"].Value);
            Response<List<Cart>> carts = CartController.getallcart(id);
            cartgv.DataSource = carts.Payload;
            cartgv.DataBind();
        }
        protected void Orderbutton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int makeupid = Convert.ToInt32(btn.CommandArgument);
            int userid = Convert.ToInt32(Request.Cookies["user_cookie"].Value);
            GridViewRow row = (GridViewRow)btn.NamingContainer;
            TextBox quantity = (TextBox)row.FindControl("Quantitytxt");
            Response<Cart> cart = CartController.insertcart(userid, makeupid, quantity.Text);

            Testmess.Text = cart.Message;

            ordergrid();
            cartgrid();
        }

        protected void clearbtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.Cookies["user_cookie"].Value);
            Response<Cart> response = CartController.deleteallcart(id);
            cartmess.Text = response.Message;

            cartgrid();
        }

        protected void checkbtn_Click(object sender, EventArgs e)
        {
            int userid = Convert.ToInt32(Request.Cookies["user_cookie"].Value);
            DateTime date = DateTime.Now;
            Response<TransactionHeader> header = TransactionHeaderController.insertheader(userid, date);
            Response<List<Cart>> response = CartController.getallcart(userid);
            List<Cart> carts = response.Payload;
            foreach (Cart cart in carts)
            {
                Response<TransactionDetail> details = TransactionDetailController.insertdetail(header.Payload.TransactionID,
                    cart.MakeupID, cart.Quantity);

            }
            Response<Cart> responses = CartController.deleteallcart(userid);

            cartgrid();
        }
    }
}