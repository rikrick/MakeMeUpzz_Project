using ProjectAkhirLab_PSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectAkhirLab_PSD.Factories
{
    public class MakeupTypeFactory
    {
        public static MakeupType Create(int id, String name)
        {
            MakeupType type = new MakeupType();
            type.MakeupTypeID = id;
            type.MakeupTypeName = name;
            return type;
        }
    }
}