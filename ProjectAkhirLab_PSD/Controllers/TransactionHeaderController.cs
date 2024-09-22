using ProjectAkhirLab_PSD.Handlers;
using ProjectAkhirLab_PSD.Models;
using ProjectAkhirLab_PSD.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectAkhirLab_PSD.Controllers
{
    public class TransactionHeaderController
    {

        //for gv
        public static Response<List<TransactionHeader>> getalltransaction()
        {
            Response<List<TransactionHeader>> response = TransactionHeaderHandler.getalltransaction();
            return response;
        }

        //for get transaction by id
        public static Response<List<TransactionHeader>> getalltransactionbyuserid(int id)
        {
            Response<List<TransactionHeader>> response = TransactionHeaderHandler.getalltransactionbyuserid(id);
            return response;
        }

        //for insert
        public static Response<TransactionHeader> insertheader(int userid, DateTime date)
        {
            Response<TransactionHeader> response = TransactionHeaderHandler.Insertheader(userid, date);
            return response;
        }
        //for update
        public static Response<TransactionHeader> Updateheader(int id)
        {

            Response<TransactionHeader> response = TransactionHeaderHandler.Updateheader(id);
            return response;

        }
    }
}