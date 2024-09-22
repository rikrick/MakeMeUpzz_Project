using ProjectAkhirLab_PSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectAkhirLab_PSD.Repositories
{
    public class TransactionDetailRepository
    {
        static MakeMeUpzzDatabaseEntities db = DatabaseSingleton.GetInstance();
        //for get detail by id
        public static List<TransactionDetail> getalldetailbytranid(int id)
        {
            return (from tran in db.TransactionDetails where tran.TransactionID == id select tran).ToList();
        }

        //for create
        public static void Createdetails(TransactionDetail detail)
        {
            db.TransactionDetails.Add(detail);
            db.SaveChanges();
        }
    }
}