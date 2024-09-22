using ProjectAkhirLab_PSD.Handlers;
using ProjectAkhirLab_PSD.Models;
using ProjectAkhirLab_PSD.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectAkhirLab_PSD.Controllers
{
    public class MakeupBrandController
    {
        //for gridview
        public static Response<List<MakeupBrand>> getallmakeupbrand()
        {
            Response<List<MakeupBrand>> response = MakeupBrandHandler.getallmakeupbrand();
            return response;
        }

        //for dropdownlist
        public static Response<List<MakeupBrand>> getallmakeupbrandasc()
        {
            Response<List<MakeupBrand>> response = MakeupBrandHandler.getallmakeupbrandasc();
            return response;
        }

        //for insert makeup brand
        public static Response<MakeupBrand> insertbrand(String name, string rating)
        {
            String errormess = "";
            int ratings = 0;

            if (rating == "")
            {
                errormess = "All field must be filled";
            }
            else
            {
                ratings = Convert.ToInt32(rating);
            }

            if (name == "")
            {
                errormess = "All field must be filled";
            }
            else if (name.Length > 99 || name.Length < 1)
            {
                errormess = "Name Must be between 1 and 99 alphabet";
            }
            else if (ratings < 0 || ratings > 100)
            {
                errormess = "Must be between 0 - 100";
            }

            if (errormess != "")
            {
                return new Response<MakeupBrand>()
                {
                    Success = false,
                    Message = errormess,
                    Payload = null
                };
            }
            else
            {
                Response<MakeupBrand> response = MakeupBrandHandler.Insertbrand(name, ratings);
                return response;
            }

        }
        // for insert makeup type

        //for delete makeup type
        public static Response<MakeupBrand> deletebrand(int id)
        {
            Response<MakeupBrand> response = MakeupBrandHandler.Deletebrand(id);
            return response;
        }
        //for delete makeup type

        //for find makeup type by id
        public static Response<MakeupBrand> getbrandbyID(int id)
        {
            Response<MakeupBrand> response = MakeupBrandHandler.findbrandbyID(id);
            return response;

        }
        //for find makeup type by id

        // for update makeup type
        public static Response<MakeupBrand> Updatebrand(int id, String name, string rating)
        {
            String errormess = "";
            int ratings = 0;

            if (rating == "")
            {
                errormess = "All field must be filled";
            }
            else
            {
                ratings = Convert.ToInt32(rating);
            }

            if (name == "")
            {
                errormess = "All field must be filled";
            }
            else if (name.Length > 99 || name.Length < 1)
            {
                errormess = "Name Must be between 1 and 99 alphabet";
            }
            else if (ratings < 0 || ratings > 100)
            {
                errormess = "Must be between 0 - 100";
            }

            if (errormess != "")
            {
                return new Response<MakeupBrand>()
                {
                    Success = false,
                    Message = errormess,
                    Payload = null
                };
            }
            else
            {
                Response<MakeupBrand> response = MakeupBrandHandler.UpdateBrand(id, name, ratings);
                return response;
            }

        }
        // for update makeup type
    }
}