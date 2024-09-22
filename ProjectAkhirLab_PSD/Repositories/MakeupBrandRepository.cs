using ProjectAkhirLab_PSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectAkhirLab_PSD.Repositories
{
    public class MakeupBrandRepository
    {
        static MakeMeUpzzDatabaseEntities db = DatabaseSingleton.GetInstance();

        //for gv makeupbrand
        public static List<MakeupBrand> getallmakeupbrand()
        {
            return db.MakeupBrands.OrderByDescending(MakeupBrand => MakeupBrand.MakeupBrandRating).ToList();
        }
        //for drop down makeupbrand
        public static List<MakeupBrand> getallmakeupbrandasc()
        {
            return db.MakeupBrands.ToList();
        }

        //for id
        public static int getNewID()
        {
            MakeupBrand brand = db.MakeupBrands.ToList().LastOrDefault();
            if (brand == null)
            {
                return 1;
            }
            else
            {
                return brand.MakeupBrandID + 1;
            }
        }

        //for create makeup type
        public static void Createbrand(MakeupBrand brand)
        {
            db.MakeupBrands.Add(brand);
            db.SaveChanges();
        }

        //for deleting
        public static void deletebrand(MakeupBrand brand)
        {
            db.MakeupBrands.Remove(brand);
            db.SaveChanges();
        }

        //find type by id
        public static MakeupBrand findid(int id)
        {
            MakeupBrand brand = db.MakeupBrands.Find(id);
            return brand;
        }

        //for update
        public static void UpdateBrand(MakeupBrand brand, String name, int rating)
        {
            brand.MakeupBrandName = name;
            brand.MakeupBrandRating = rating;
            db.SaveChanges();
        }
    }
}