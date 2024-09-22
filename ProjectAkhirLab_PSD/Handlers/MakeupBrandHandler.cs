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
    public class MakeupBrandHandler
    {
        //for gridview
        public static Response<List<MakeupBrand>> getallmakeupbrand()
        {
            return new Response<List<MakeupBrand>>()
            {
                Success = true,
                Message = "Success",
                Payload = MakeupBrandRepository.getallmakeupbrand()
            };
        }
        //for dropdownlist
        public static Response<List<MakeupBrand>> getallmakeupbrandasc()
        {
            return new Response<List<MakeupBrand>>()
            {
                Success = true,
                Message = "Success",
                Payload = MakeupBrandRepository.getallmakeupbrandasc()
            };
        }
        //insert makeup brand
        public static Response<MakeupBrand> Insertbrand(String name, int rating)
        {
            MakeupBrand brand = MakeupBrandFactory.Create(MakeupBrandRepository.getNewID(), name, rating);
            MakeupBrandRepository.Createbrand(brand);
            return new Response<MakeupBrand>()
            {
                Success = true,
                Message = "Insert Success!",
                Payload = brand
            };

        }

        //for deleting makeup
        public static Response<MakeupBrand> Deletebrand(int id)
        {
            MakeupBrand brand = MakeupBrandRepository.findid(id);
            if (brand == null)
            {
                return new Response<MakeupBrand>()
                {
                    Success = false,
                    Message = "makeup brand doesn't exist",
                    Payload = null
                };
            }
            else
            {
                MakeupBrandRepository.deletebrand(brand);

                return new Response<MakeupBrand>()
                {
                    Success = true,
                    Message = "Success!",
                    Payload = null
                };
            }
        }

        //find makeup brand by id
        public static Response<MakeupBrand> findbrandbyID(int id)
        {
            MakeupBrand brand = MakeupBrandRepository.findid(id);
            if (brand == null)
            {
                return new Response<MakeupBrand>()
                {
                    Success = false,
                    Message = "Makeup brand not found!",
                    Payload = null
                };
            }
            else
            {
                return new Response<MakeupBrand>()
                {
                    Success = true,
                    Message = "Makeup brand found!",
                    Payload = brand
                };
            }
        }

        //for update
        public static Response<MakeupBrand> UpdateBrand(int id, String name, int rating)
        {
            MakeupBrand brand = MakeupBrandRepository.findid(id);
            if (brand == null)
            {
                return new Response<MakeupBrand>()
                {
                    Success = false,
                    Message = "Makeup brand id doesn't exist!",
                    Payload = null
                };
            }
            else
            {
                MakeupBrandRepository.UpdateBrand(brand, name, rating);

                return new Response<MakeupBrand>()
                {
                    Success = true,
                    Message = "Update Success",
                    Payload = brand
                };
            }
        }
    }
}