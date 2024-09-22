using ProjectAkhirLab_PSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectAkhirLab_PSD.Factories
{
    public class UserFactory
    {
        public static User Create(int Userid, String name, String Email,
           DateTime userDob, String Gender, String password)
        {
            User user = new User();
            user.UserID = Userid;
            user.Username = name;
            user.UserEmail = Email;
            user.UserDOB = userDob;
            user.UserGender = Gender;
            user.UserRole = "Customer";
            user.UserPassword = password;

            return user;
        }
    }
}