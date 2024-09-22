using ProjectAkhirLab_PSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectAkhirLab_PSD.Repositories
{
    public class TransactionHeaderRepository
    {
        static MakeMeUpzzDatabaseEntities db = DatabaseSingleton.GetInstance();
        //for gv 
        public static List<TransactionHeader> getalltransaction()
        {
            return db.TransactionHeaders.ToList();
        }
        //for gettransactionbyid
        public static List<TransactionHeader> getalltransactionbyuserid(int id)
        {
            return (from tran in db.TransactionHeaders where tran.UserID == id select tran).ToList();
        }
        //for create
        public static void Createheader(TransactionHeader header)
        {
            db.TransactionHeaders.Add(header);
            db.SaveChanges();
        }
        //for newid
        public static int getNewID()
        {
            TransactionHeader header = db.TransactionHeaders.ToList().LastOrDefault();
            if (header == null)
            {
                return 1;
            }
            else
            {
                return header.TransactionID + 1;
            }
        }
        //for update
        public static void Updateheader(TransactionHeader header)
        {
            header.Status = "Handled";
            db.SaveChanges();
        }
        //for findid
        public static TransactionHeader findid(int id)
        {
            TransactionHeader header = db.TransactionHeaders.Find(id);
            return header;
        }
    }
}