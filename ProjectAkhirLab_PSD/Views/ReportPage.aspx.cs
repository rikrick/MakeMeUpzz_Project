using ProjectAkhirLab_PSD.Controllers;
using ProjectAkhirLab_PSD.Datasets;
using ProjectAkhirLab_PSD.Handlers;
using ProjectAkhirLab_PSD.Models;
using ProjectAkhirLab_PSD.Modules;
using ProjectAkhirLab_PSD.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectAkhirLab_PSD.Views
{
    public partial class ReportPage : System.Web.UI.Page
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
                        Response<User> responses = UserController.getUserByID(id);
                        currentUser = responses.Payload;
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
                    }
                    else
                    {
                        Response<List<TransactionHeader>> response = new Response<List<TransactionHeader>>();
                        CrystalReport1 report = new CrystalReport1();
                        CrystalReportViewer1.ReportSource = report;
                        DataSet data = getData(TransactionHeaderHandler.getalltransaction());
                        report.SetDataSource(data);
                    }

                }
            }
        }



        private DataSet getData(Response<List<TransactionHeader>> respon)
        {
            DataSet data = new DataSet();
            var headerTable = data.TransactionHeaders;
            var detailTable = data.TransactionDetails;
            int subTotal = 0;
            List<TransactionHeader> transactionHeaders = respon.Payload;

            foreach (TransactionHeader th in transactionHeaders)
            {
                subTotal = 0;
                var hRow = headerTable.NewRow();
                hRow["TransactionID"] = th.TransactionID;
                hRow["UserID"] = th.UserID;
                hRow["TransactionDate"] = th.TransactionDate;
                hRow["Status"] = th.Status;

                foreach (TransactionDetail td in th.TransactionDetails)
                {
                    var dRow = detailTable.NewRow();
                    dRow["TransactionID"] = td.TransactionID;
                    dRow["MakeupID"] = td.MakeupID;
                    dRow["Quantity"] = td.Quantity;
                    Response<Makeup> response = MakeupController.getmakeupbyID(td.MakeupID);
                    int price = response.Payload.MakeupPrice;
                    int totalPrice = td.Quantity * price;
                    dRow["TotalPrice"] = totalPrice;
                    subTotal += totalPrice;
                    detailTable.Rows.Add(dRow);
                }
                hRow["SubTotal"] = subTotal;
                headerTable.Rows.Add(hRow);
            }
            return data;
        }
    }
}
