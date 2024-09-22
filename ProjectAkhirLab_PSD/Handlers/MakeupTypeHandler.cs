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
    public class MakeupTypeHandler
    {
        //for get all type
        public static Response<List<MakeupType>> getallmakeuptype()
        {
            return new Response<List<MakeupType>>()
            {
                Success = true,
                Message = "",
                Payload = MakeupTypeRepository.getallmakeuptype()
            };
        }

        //insert makeup type
        public static Response<MakeupType> Inserttype(String name)
        {
            MakeupType type = MakeupTypeFactory.Create(MakeupTypeRepository.getNewID(), name);
            MakeupTypeRepository.Createtype(type);
            return new Response<MakeupType>()
            {
                Success = true,
                Message = "Insert Success!",
                Payload = type
            };

        }

        //for deleting makeup
        public static Response<MakeupType> Deletetype(int id)
        {
            MakeupType type = MakeupTypeRepository.findid(id);
            if (type == null)
            {
                return new Response<MakeupType>()
                {
                    Success = false,
                    Message = "makeup type doesn't exist",
                    Payload = null
                };
            }
            else
            {
                MakeupTypeRepository.deletetype(type);

                return new Response<MakeupType>()
                {
                    Success = true,
                    Message = "Success!",
                    Payload = null
                };
            }
        }

        //for get makeuptype by id
        public static Response<MakeupType> findtypebyID(int id)
        {
            MakeupType type = MakeupTypeRepository.findid(id);
            if (type == null)
            {
                return new Response<MakeupType>()
                {
                    Success = false,
                    Message = "Makeup type not found!",
                    Payload = null
                };
            }
            else
            {
                return new Response<MakeupType>()
                {
                    Success = true,
                    Message = "Makeup type found!",
                    Payload = type
                };
            }
        }

        //for update
        public static Response<MakeupType> UpdateType(int id, String name)
        {
            MakeupType type = MakeupTypeRepository.findid(id);
            if (type == null)
            {
                return new Response<MakeupType>()
                {
                    Success = false,
                    Message = "Makeup type id doesn't exist!",
                    Payload = null
                };
            }
            else
            {
                MakeupTypeRepository.UpdateType(type, name);

                return new Response<MakeupType>()
                {
                    Success = true,
                    Message = "Update Success",
                    Payload = type
                };
            }
        }
    }
}