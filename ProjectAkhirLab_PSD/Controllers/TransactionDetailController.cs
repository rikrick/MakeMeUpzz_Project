using ProjectAkhirLab_PSD.Handlers;
using ProjectAkhirLab_PSD.Models;
using ProjectAkhirLab_PSD.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectAkhirLab_PSD.Controllers
{
    public class TransactionDetailController
    {
        //for get detail by id
        public static Response<List<TransactionDetail>> getalldetail(int id)
        {
            Response<List<TransactionDetail>> response = TransactionDetailHandler.getalldetailbyuserid(id);
            return response;
        }

        //for insert
        public static Response<TransactionDetail> insertdetail(int tranid, int makeupid, int quantity)
        {
            Response<TransactionDetail> response = TransactionDetailHandler.Insertdetail(tranid, makeupid, quantity);
            return response;
        }
    }
}