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
    public class UserHandler
    {
        //register
        public static Response<User> Register(String username, String email,
            DateTime userDob, String Gender, String password)
        {
            User users = UserRepository.getUserbyUsername(username);
            if (users != null)
            {
                return new Response<User>()
                {
                    Success = false,
                    Message = "Username already taken!",
                    Payload = null
                };
            }
            else
            {
                User user = UserFactory.Create(UserRepository.getNewID(), username, email,
                    userDob, Gender, password);
                UserRepository.Createuser(user);

                return new Response<User>()
                {
                    Success = true,
                    Message = "Register Success!",
                    Payload = user
                };
            }
        }
        

        //login
        public static Response<User> Loginhandler(String username, String password)
        {

            User user = UserRepository.getUserbyUsername(username);
            if (user == null)
            {
                return new Response<User>()
                {
                    Success = false,
                    Message = "User does not exist!",
                    Payload = null
                };
            }
            else if (user.UserPassword != password)
            {
                return new Response<User>()
                {
                    Success = false,
                    Message = "Password is not correct!",
                    Payload = null
                };
            }
            else
            {
                return new Response<User>()
                {
                    Success = true,
                    Message = "Login Success!",
                    Payload = user
                };
            }
        }

        //for gridview in homepage
        public static Response<List<User>> Adminvalidation(User user)
        {
            if (user.UserRole == "Admin")
            {
                return new Response<List<User>>()
                {
                    Success = true,
                    Message = "Role: Admin",
                    Payload = UserRepository.getallusers()
                };
            }
            else
            {
                return new Response<List<User>>()
                {
                    Success = false,
                    Message = "Role: Customer",
                    Payload = null
                };
            }
        }

        //getuserbyid
        public static Response<User> getUserByID(int id)
        {
            User user = UserRepository.getById(id);
            if (user == null)
            {
                return new Response<User>()
                {
                    Success = false,
                    Message = "User not found!",
                    Payload = null
                };
            }
            else
            {
                return new Response<User>()
                {
                    Success = true,
                    Message = "User found!",
                    Payload = user
                };
            }
        }

        //for update user profile
        public static Response<User> Updateprofile(int id, string name, string email, string gender,
            DateTime DOB)
        {
            User users = UserRepository.getById(id);
            User currname = UserRepository.getUserbyUsername(name);
            int ids = 0;
            if (currname != null)
            {
                ids = currname.UserID;
            }

            if (users == null)
            {
                return new Response<User>()
                {
                    Success = false,
                    Message = "User id doesn't exist!",
                    Payload = null
                };
            }
            else if (ids != id && ids != 0)
            {
                return new Response<User>()
                {
                    Success = false,
                    Message = "Username already exist!",
                    Payload = null
                };
            }
            else
            {
                UserRepository.Updateprofile(users, name, email, gender, DOB);

                return new Response<User>()
                {
                    Success = true,
                    Message = "Update Success!",
                    Payload = users
                };
            }
        }

        //for update user password
        public static Response<User> Updatepass(int id, String old, String newpass)
        {
            User users = UserRepository.getById(id);
            if (users == null)
            {
                return new Response<User>()
                {
                    Success = false,
                    Message = "User id doesn't exist!",
                    Payload = null
                };
            }
            else if (!users.UserPassword.Equals(old))
            {
                return new Response<User>()
                {
                    Success = false,
                    Message = "Wrong Password!",
                    Payload = null
                };
            }
            else
            {
                UserRepository.Updatepass(users, newpass);

                return new Response<User>()
                {
                    Success = true,
                    Message = "Update Success!",
                    Payload = users
                };
            }

        }
    }
}