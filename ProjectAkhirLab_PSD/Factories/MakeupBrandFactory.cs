using ProjectAkhirLab_PSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectAkhirLab_PSD.Factories
{
    public class MakeupBrandFactory
    {
        public static MakeupBrand Create(int id, String name, int rating)
        {
            MakeupBrand brand = new MakeupBrand();
            brand.MakeupBrandID = id;
            brand.MakeupBrandName = name;
            brand.MakeupBrandRating = rating;
            return brand;
        }
    }
}