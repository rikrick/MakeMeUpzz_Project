using ProjectAkhirLab_PSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectAkhirLab_PSD.Repositories
{
    public class MakeupRepository
    {
        static MakeMeUpzzDatabaseEntities db = DatabaseSingleton.GetInstance();

        //for gv makeup
        public static List<Makeup> getallmakeup()
        {
            return db.Makeups.ToList();
        }

        public static int getNewID()
        {
            Makeup makeup = db.Makeups.ToList().LastOrDefault();
            if (makeup == null)
            {
                return 1;
            }
            else
            {
                return makeup.MakeupID + 1;
            }
        }

        //for create make up
        public static void Createmakeup(Makeup makeup)
        {
            db.Makeups.Add(makeup);
            db.SaveChanges();
        }

        //for deleting

        public static void deleteemakeup(Makeup makeup)
        {
            db.Makeups.Remove(makeup);
            db.SaveChanges();
        }

        //for find id
        public static Makeup findid(int id)
        {
            Makeup makeup = db.Makeups.Find(id);
            return makeup;
        }

        //for update
        public static void UpdateMakeup(Makeup makeup, String name, int price, int weight, int type,
            int brand)
        {
            makeup.MakeupName = name;
            makeup.MakeupPrice = price;
            makeup.MakeupWeight = weight;
            makeup.MakeupTypeID = type;
            makeup.MakeupBrandID = brand;
            db.SaveChanges();
        }
    }
}