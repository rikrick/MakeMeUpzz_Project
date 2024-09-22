using ProjectAkhirLab_PSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectAkhirLab_PSD.Repositories
{
    public class UserRepository
    {
        static MakeMeUpzzDatabaseEntities db = DatabaseSingleton.GetInstance();
        //get user by username
        public static User getUserbyUsername(String username)
        {
            return (from u in db.Users where u.Username == username select u).FirstOrDefault();
        }

        //create user for register
        public static void Createuser(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }

        // generate new id
        public static int getNewID()
        {
            User user = db.Users.ToList().LastOrDefault();
            if (user == null)
            {
                return 1;
            }
            else
            {
                return user.UserID + 1;
            }
        }

        //get user by id
        public static User getById(int id)
        {
            return (from u in db.Users where u.UserID == id select u).FirstOrDefault();
        }

        // for gridview in homepage
        public static List<User> getallusers()
        {
            return db.Users.ToList();
        }
        // for update user profile
        public static void Updateprofile(User user, String name, String email, String gender,
            DateTime DOB)
        {
            user.Username = name;
            user.UserEmail = email;
            user.UserGender = gender;
            user.UserDOB = DOB;
            db.SaveChanges();
        }

        //for update user password
        public static void Updatepass(User user, String pass)
        {
            user.UserPassword = pass;
            db.SaveChanges();
        }
    }
}