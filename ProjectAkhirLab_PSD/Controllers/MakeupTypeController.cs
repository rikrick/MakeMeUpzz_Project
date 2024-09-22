using ProjectAkhirLab_PSD.Handlers;
using ProjectAkhirLab_PSD.Models;
using ProjectAkhirLab_PSD.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectAkhirLab_PSD.Controllers
{
    public class MakeupTypeController
    {
        //for get type
        public static Response<List<MakeupType>> getallmakeuptype()
        {
            Response<List<MakeupType>> response = MakeupTypeHandler.getallmakeuptype();
            return response;
        }

        //for insert makeup type
        public static Response<MakeupType> inserttype(String name)
        {
            String errormess = "";

            if (name == "")
            {
                errormess = "All field must be filled";
            }
            else if (name.Length > 99 || name.Length < 1)
            {
                errormess = "Name Must be between 1 and 99 alphabet";
            }

            if (errormess != "")
            {
                return new Response<MakeupType>()
                {
                    Success = false,
                    Message = errormess,
                    Payload = null
                };
            }
            else
            {
                Response<MakeupType> response = MakeupTypeHandler.Inserttype(name);
                return response;
            }

        }
        // for insert makeup type

        //for delete makeup type
        public static Response<MakeupType> deletetype(int id)
        {
            Response<MakeupType> response = MakeupTypeHandler.Deletetype(id);
            return response;
        }
        //for delete makeup type

        //for find makeup type by id
        public static Response<MakeupType> gettypebyID(int id)
        {
            Response<MakeupType> response = MakeupTypeHandler.findtypebyID(id);
            return response;

        }
        //for find makeup type by id

        // for update makeup type
        public static Response<MakeupType> Updatetype(int id, String name)
        {
            String errormess = "";
            if (name == "")
            {
                errormess = "All field must be filled";
            }
            else if (name.Length > 99 || name.Length < 1)
            {
                errormess = "Name Must be between 1 and 99 alphabet";
            }

            if (errormess != "")
            {
                return new Response<MakeupType>()
                {
                    Success = false,
                    Message = errormess,
                    Payload = null
                };
            }
            else
            {
                Response<MakeupType> response = MakeupTypeHandler.UpdateType(id, name);
                return response;
            }

        }
        // for update makeup type
    }
}