using ProjectAkhirLab_PSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectAkhirLab_PSD.Factories
{
    public class TransactionHeaderFactory
    {
        public static TransactionHeader Create(int id, int userid, DateTime date)
        {
            TransactionHeader header = new TransactionHeader();
            header.TransactionID = id;
            header.UserID = userid;
            header.TransactionDate = date;
            header.Status = "Unhandled";
            return header;
        }
    }
}