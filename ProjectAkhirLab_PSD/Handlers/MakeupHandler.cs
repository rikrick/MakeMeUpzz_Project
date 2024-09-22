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
    public class MakeupHandler
    {
        //for gridview
        public static Response<List<Makeup>> getallmakeup()
        {
            return new Response<List<Makeup>>()
            {
                Success = true,
                Message = "",
                Payload = MakeupRepository.getallmakeup()
            };
        }

        //insert makeup
        public static Response<Makeup> InsertMakeup(String name, int price, int weight, int type, int brand)
        {
            Makeup makeup = MakeupFactory.Create(MakeupRepository.getNewID(), name, price, weight, type, brand);
            MakeupRepository.Createmakeup(makeup);

            return new Response<Makeup>()
            {
                Success = true,
                Message = "Insert Success!",
                Payload = makeup
            };

        }

        //for deleting makeup
        public static Response<Makeup> Deletemakeup(int id)
        {
            Makeup makeup = MakeupRepository.findid(id);
            if (makeup == null)
            {
                return new Response<Makeup>()
                {
                    Success = false,
                    Message = "makeup doesn't exist",
                    Payload = null
                };
            }
            else
            {
                MakeupRepository.deleteemakeup(makeup);

                return new Response<Makeup>()
                {
                    Success = true,
                    Message = "Success!",
                    Payload = null
                };
            }
        }

        //for get makeup by id
        public static Response<Makeup> FindID(int id)
        {
            Makeup makeup = MakeupRepository.findid(id);
            if (makeup == null)
            {
                return new Response<Makeup>()
                {
                    Success = false,
                    Message = "Makeup not found!",
                    Payload = null
                };
            }
            else
            {
                return new Response<Makeup>()
                {
                    Success = true,
                    Message = "Makeup found!",
                    Payload = makeup
                };
            }
        }

        //for update
        public static Response<Makeup> UpdateMakeup(int id, String name, int price, int weight, int type,
            int brand)
        {
            Makeup makeup = MakeupRepository.findid(id);
            if (makeup == null)
            {
                return new Response<Makeup>()
                {
                    Success = false,
                    Message = "Makeup id doesn't exist!",
                    Payload = null
                };
            }
            else
            {
                MakeupRepository.UpdateMakeup(makeup, name, price, weight, type, brand);

                return new Response<Makeup>()
                {
                    Success = true,
                    Message = "Update Success",
                    Payload = makeup
                };
            }
        }
    }
}