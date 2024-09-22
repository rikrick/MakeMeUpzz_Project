using ProjectAkhirLab_PSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectAkhirLab_PSD.Factories
{
    public class MakeupFactory
    {
        public static Makeup Create(int Id, String Name, int Price, int Weight,
           int Typeid, int Brandid)
        {
            Makeup makeup = new Makeup();
            makeup.MakeupID = Id;
            makeup.MakeupName = Name;
            makeup.MakeupPrice = Price;
            makeup.MakeupWeight = Weight;
            makeup.MakeupTypeID = Typeid;
            makeup.MakeupBrandID = Brandid;

            return makeup;
        }
    }
}