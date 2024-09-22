using ProjectAkhirLab_PSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectAkhirLab_PSD.Repositories
{
    public class MakeupTypeRepository
    {
        static MakeMeUpzzDatabaseEntities db = DatabaseSingleton.GetInstance();

        //for gv makeuptype
        public static List<MakeupType> getallmakeuptype()
        {
            return db.MakeupTypes.ToList();
        }
        //for newid
        public static int getNewID()
        {
            MakeupType type = db.MakeupTypes.ToList().LastOrDefault();
            if (type == null)
            {
                return 1;
            }
            else
            {
                return type.MakeupTypeID + 1;
            }
        }

        //for create makeup type
        public static void Createtype(MakeupType type)
        {
            db.MakeupTypes.Add(type);
            db.SaveChanges();
        }

        //for deleting
        public static void deletetype(MakeupType type)
        {
            db.MakeupTypes.Remove(type);
            db.SaveChanges();
        }

        //find type by id
        public static MakeupType findid(int id)
        {
            MakeupType type = db.MakeupTypes.Find(id);
            return type;
        }

        //for update
        public static void UpdateType(MakeupType type, String name)
        {
            type.MakeupTypeName = name;
            db.SaveChanges();
        }
    }
}