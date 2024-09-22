using ProjectAkhirLab_PSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectAkhirLab_PSD.Factories
{
    public class CartFactory
    {
        public static Cart Create(int id, int userid, int makeupid, int quantity)
        {
            Cart cart = new Cart();
            cart.CartID = id;
            cart.UserID = userid;
            cart.MakeupID = makeupid;
            cart.Quantity = quantity;
            return cart;
        }

    }
}