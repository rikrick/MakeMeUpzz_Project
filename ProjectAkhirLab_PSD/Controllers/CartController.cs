using ProjectAkhirLab_PSD.Handlers;
using ProjectAkhirLab_PSD.Models;
using ProjectAkhirLab_PSD.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectAkhirLab_PSD.Controllers
{
    public class CartController
    {
        //for insert
        public static Response<Cart> insertcart(int userid, int makeupid, String Quantity)
        {
            String errormess = "";
            int quan = 0;

            if (Quantity == "")
            {
                errormess = "All field must be filled";
            }
            else
            {
                quan = Convert.ToInt32(Quantity);
            }

            if (quan < 0)
            {
                errormess = "Quantity must be bigger than 0!";
            }


            if (errormess != "")
            {
                return new Response<Cart>()
                {
                    Success = false,
                    Message = errormess,
                    Payload = null
                };
            }
            else
            {
                Response<Cart> response = CartHandler.InsertCart(userid, makeupid, quan);
                return response;
            }
        }

        //for get all cart
        public static Response<List<Cart>> getallcart(int id)
        {
            Response<List<Cart>> response = CartHandler.getallcart(id);
            return response;
        }
        //for delete
        public static Response<Cart> deleteallcart(int id)
        {
            Response<Cart> response = CartHandler.Deleteallcart(id);
            return response;
        }
    }
}