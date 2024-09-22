using ProjectAkhirLab_PSD.Handlers;
using ProjectAkhirLab_PSD.Models;
using ProjectAkhirLab_PSD.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace ProjectAkhirLab_PSD.Controllers
{
    public class UserController
    {
       //register
        public static Response<User> register(String username, String email,
            DateTime userDob, Boolean female, Boolean male, String password,
            string confirm)
        {
            String errormess = "";
            string date = userDob.ToString();
            Regex emailval = new Regex(@"^\S+\.com$");
            Regex passval = new Regex("^[a-zA-Z0-9]*$");
            String Gender = "";

            if (female == true)
            {
                Gender = "Female";
            }
            else if (male == true)
            {
                Gender = "Male";
            }

            if (username == "" || email == "" || Gender == "" || password == "" ||
                confirm == "" || date == "")
            {
                errormess = "All field must be filled";
            }
            else if (username.Length > 15 || username.Length < 5)
            {
                errormess = "Username must be between 5 and 15 alphabet";
            }
            else if (!passval.IsMatch(password))
            {
                errormess = "Password must be alphanumberic";
            }
            else if (!emailval.IsMatch(email))
            {
                errormess = "Email must ends with '.com'";
            }
            else if (password != confirm)
            {
                errormess = "Password must be the same with confirm password";
            }


            if (errormess != "")
            {
                return new Response<User>()
                {
                    Success = false,
                    Message = errormess,
                    Payload = null
                };
            }
            else
            {
                Response<User> response = UserHandler.Register(username, email, userDob,
                Gender, password);
                return response;
            }



        }
        //register

        //login
        public static Response<User> login(string username, string password, Boolean remember)
        {
            if (username == "" || password == "")
            {
                return new Response<User>()
                {
                    Success = false,
                    Message = "Please fill in all fields!",
                    Payload = null
                };
            }
            else
            {
                Response<User> response = UserHandler.Loginhandler(username, password);
                return response;

            }
        }
        // login

        // for gridview in homepage and for admin validation in navbar
        public static Response<List<User>> adminvalidation(User user)
        {
            Response<List<User>> response = UserHandler.Adminvalidation(user);
            return response;
        }
        // for gridview in homepage

        // get user by id
        public static Response<User> getUserByID(int id)
        {
            Response<User> response = UserHandler.getUserByID(id);
            return response;

        }
        //get user by id

        //for update user profile
        public static Response<User> Updateprofiles(int id, String name, String email, Boolean female,
            Boolean male, DateTime DOB)
        {
            String errormess = "";
            string date = DOB.ToString();
            Regex emailval = new Regex(@"^\S+\.com$");
            String Gender = "";

            if (female == true)
            {
                Gender = "Female";
            }
            else if (male == true)
            {
                Gender = "Male";
            }

            if (name == "" || email == "" || Gender == "" || date == "")
            {
                errormess = "All field must be filled";
            }
            else if (name.Length > 15 || name.Length < 5)
            {
                errormess = "Must be between 5 and 15 alphabet";
            }
            else if (!emailval.IsMatch(email))
            {
                errormess = "Email must ends with '.com'";
            }


            if (errormess != "")
            {
                return new Response<User>()
                {
                    Success = false,
                    Message = errormess,
                    Payload = null
                };
            }
            else
            {
                Response<User> response = UserHandler.Updateprofile(id, name, email, Gender,
                    DOB);
                return response;
            }
        }
        //for update user profile

        //for update user passwword
        public static Response<User> Updatepass(int id, string old, String newpass)
        {
            String errormess = "";
            Regex passval = new Regex("^[a-zA-Z0-9]*$");

            if (old == "" || newpass == "")
            {
                errormess = "All field must be filled";
            }
            else if (!passval.IsMatch(newpass))
            {
                errormess = "Password must be alphanumberic";
            }


            if (errormess != "")
            {
                return new Response<User>()
                {
                    Success = false,
                    Message = errormess,
                    Payload = null
                };
            }
            else
            {
                Response<User> response = UserHandler.Updatepass(id, old, newpass);
                return response;
            }
        }
        //for update user passwword

        public static HttpCookie Cookies(User user, Boolean remember)
        {
            if (remember == true)
            {
                HttpCookie cookie = new HttpCookie("user_cookie");
                cookie.Value = user.UserID.ToString();
                cookie.Expires = DateTime.Now.AddHours(12);
                return cookie;
            }
            else
            {
                return null;

            }
        }
    }
}