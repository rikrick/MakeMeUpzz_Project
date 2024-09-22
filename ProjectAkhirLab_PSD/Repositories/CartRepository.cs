using ProjectAkhirLab_PSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectAkhirLab_PSD.Repositories
{
    public class CartRepository
    {
        static MakeMeUpzzDatabaseEntities db = DatabaseSingleton.GetInstance();

        //for new id
        public static int getNewID()
        {
            Cart cart = db.Carts.ToList().LastOrDefault();
            if (cart == null)
            {
                return 1;
            }
            else
            {
                return cart.CartID + 1;
            }
        }
        //for create
        public static void Createcart(Cart cart)
        {
            db.Carts.Add(cart);
            db.SaveChanges();
        }

        //for get all cart
        public static List<Cart> getallcart(int id)
        {
            return (from cart in db.Carts where cart.UserID == id select cart).ToList();
        }

        //for delete
        public static void deleteallcart(List<Cart> carts)
        {
            db.Carts.RemoveRange(carts);
            db.SaveChanges();
        }
    }
}