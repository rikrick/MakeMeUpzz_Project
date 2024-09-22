using ProjectAkhirLab_PSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectAkhirLab_PSD.Factories
{
    public class TransactionDetailFactory
    {
        public static TransactionDetail Create(int tranid, int makeupid, int quantity)
        {
            TransactionDetail detail = new TransactionDetail();
            detail.TransactionID = tranid;
            detail.MakeupID = makeupid;
            detail.Quantity = quantity;
            return detail;
        }
    }
}