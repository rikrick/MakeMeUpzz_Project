using ProjectAkhirLab_PSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectAkhirLab_PSD.Repositories
{
    public class DatabaseSingleton
    {
        private static MakeMeUpzzDatabaseEntities db = null;

        public static MakeMeUpzzDatabaseEntities GetInstance()
        {
            if (db == null)
            {
                db = new MakeMeUpzzDatabaseEntities();
            }
            return db;
        }
    }
}