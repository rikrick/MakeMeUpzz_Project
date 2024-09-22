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
    public class CartHandler
    {
        //for insert
        public static Response<Cart> InsertCart(int userid, int makeupid, int quantity)
        {
            Cart cart = CartFactory.Create(CartRepository.getNewID(), userid, makeupid, quantity);
            CartRepository.Createcart(cart);
            return new Response<Cart>()
            {
                Success = true,
                Message = "Insert Success!",
                Payload = cart
            };

        }

        //for get cart
        public static Response<List<Cart>> getallcart(int id)
        {
            return new Response<List<Cart>>()
            {
                Success = true,
                Message = "Success!",
                Payload = CartRepository.getallcart(id)
            };
        }

        //for delete
        public static Response<Cart> Deleteallcart(int id)
        {
            List<Cart> carts = CartRepository.getallcart(id);
            if (carts == null)
            {
                return new Response<Cart>()
                {
                    Success = false,
                    Message = "Carts is empty",
                    Payload = null
                };
            }
            else
            {
                CartRepository.deleteallcart(carts);

                return new Response<Cart>()
                {
                    Success = true,
                    Message = "Success!",
                    Payload = null
                };
            }
        }
    }
}