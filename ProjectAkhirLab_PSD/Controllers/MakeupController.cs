using ProjectAkhirLab_PSD.Handlers;
using ProjectAkhirLab_PSD.Models;
using ProjectAkhirLab_PSD.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectAkhirLab_PSD.Controllers
{
    public class MakeupController
    {
        // for gridview for make up
        public static Response<List<Makeup>> getallmakeup()
        {
            Response<List<Makeup>> response = MakeupHandler.getallmakeup();
            return response;
        }
        // for gridview for makeup

        // for insert makeup
        public static Response<Makeup> insertmakeup(String name, string price, string weight, int type, int brand)
        {
            String errormess = "";
            int prices = 0;
            int weights = 0;
            if (price == "" || weight == "")
            {
                errormess = "All field must be filled";
            }
            else
            {
                prices = Convert.ToInt32(price);
                weights = Convert.ToInt32(weight);
            }

            if (name == "")
            {
                errormess = "All field must be filled";
            }
            else if (name.Length > 99 || name.Length < 1)
            {
                errormess = "Name Must be between 1 and 99 alphabet";
            }
            else if (prices < 1)
            {
                errormess = "Greater than or equals than 1";
            }
            else if (weights > 1500)
            {
                errormess = "Cannot be greater than 1500 grams";
            }

            if (errormess != "")
            {
                return new Response<Makeup>()
                {
                    Success = false,
                    Message = errormess,
                    Payload = null
                };
            }
            else
            {
                Response<Makeup> response = MakeupHandler.InsertMakeup(name, prices, weights, type, brand);
                return response;
            }



        }
        // for insert makeup

        //for delete makeup
        public static Response<Makeup> deletemakeup(int id)
        {
            Response<Makeup> response = MakeupHandler.Deletemakeup(id);
            return response;
        }
        //for delete makeup

        //for find makeup by id
        public static Response<Makeup> getmakeupbyID(int id)
        {
            Response<Makeup> response = MakeupHandler.FindID(id);
            return response;

        }
        //for find makeup by id


        // for update makeup
        public static Response<Makeup> Updatemakeup(int id, String name, string price, string weight, int type, int brand)
        {
            String errormess = "";
            int prices = 0;
            int weights = 0;
            if (price == "" || weight == "")
            {
                errormess = "All field must be filled";
            }
            else
            {
                prices = Convert.ToInt32(price);
                weights = Convert.ToInt32(weight);
            }

            if (name == "")
            {
                errormess = "All field must be filled";
            }
            else if (name.Length > 99 || name.Length < 1)
            {
                errormess = "Name Must be between 1 and 99 alphabet";
            }
            else if (prices < 1)
            {
                errormess = "Greater than or equals than 1";
            }
            else if (weights > 1500)
            {
                errormess = "Cannot be greater than 1500 grams";
            }

            if (errormess != "")
            {
                return new Response<Makeup>()
                {
                    Success = false,
                    Message = errormess,
                    Payload = null
                };
            }
            else
            {
                Response<Makeup> response = MakeupHandler.UpdateMakeup(id, name, prices, weights, type, brand);
                return response;
            }

        }
        // for update makeup
    }
}