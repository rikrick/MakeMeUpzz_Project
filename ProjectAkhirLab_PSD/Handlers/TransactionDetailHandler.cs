using ProjectAkhirLab_PSD.Factories;
using ProjectAkhirLab_PSD.Models;
using ProjectAkhirLab_PSD.Modules;
using ProjectAkhirLab_PSD.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectAkhirLab_PSD.Handlers
{
    public class TransactionDetailHandler
    {
        //for get detail by id
        public static Response<List<TransactionDetail>> getalldetailbyuserid(int id)
        {
            return new Response<List<TransactionDetail>>()
            {
                Success = true,
                Message = "Success",
                Payload = TransactionDetailRepository.getalldetailbytranid(id)
            };
        }
        //for insert
        public static Response<TransactionDetail> Insertdetail(int tranid, int makeupid, int quantity)
        {
            TransactionDetail detail = TransactionDetailFactory.Create(tranid, makeupid, quantity);
            TransactionDetailRepository.Createdetails(detail);
            return new Response<TransactionDetail>()
            {
                Success = true,
                Message = "Insert Success!",
                Payload = detail
            };

        }
    }
}