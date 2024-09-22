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
    public class TransactionHeaderHandler
    {
        //for gv 
        public static Response<List<TransactionHeader>> getalltransaction()
        {
            return new Response<List<TransactionHeader>>()
            {
                Success = true,
                Message = "Success",
                Payload = TransactionHeaderRepository.getalltransaction()
            };
        }
        //for get transaction by id
        public static Response<List<TransactionHeader>> getalltransactionbyuserid(int id)
        {
            return new Response<List<TransactionHeader>>()
            {
                Success = true,
                Message = "Success",
                Payload = TransactionHeaderRepository.getalltransactionbyuserid(id)
            };
        }
        //for insert
        public static Response<TransactionHeader> Insertheader(int userid, DateTime date)
        {
            TransactionHeader header = TransactionHeaderFactory.Create(TransactionHeaderRepository.getNewID(), userid, date);
            TransactionHeaderRepository.Createheader(header);
            return new Response<TransactionHeader>()
            {
                Success = true,
                Message = "Insert Success!",
                Payload = header
            };

        }
        //for update
        public static Response<TransactionHeader> Updateheader(int id)
        {
            TransactionHeader header = TransactionHeaderRepository.findid(id);
            if (header == null)
            {
                return new Response<TransactionHeader>()
                {
                    Success = false,
                    Message = "transaction header doesn't exist!",
                    Payload = null
                };
            }
            else
            {
                TransactionHeaderRepository.Updateheader(header);

                return new Response<TransactionHeader>()
                {
                    Success = true,
                    Message = "Update Success",
                    Payload = header
                };
            }
        }
    }
}