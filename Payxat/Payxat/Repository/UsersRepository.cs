using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Payxat.Repository.DataObject;

namespace Payxat.Repository
{
    public class UsersRepository {

        public static void AddUser(ref User user)
        {
            using (PayxatEntities1 db = new PayxatEntities1())
            {
                db.Users.Add(user);
                db.SaveChanges();

            }
        }

        public static User Login(string userName, string password)
        {
            using (PayxatEntities1 db = new PayxatEntities1())
            {
                User result = db.Users.Where(u => u.U_Name == userName && u.U_Password == password).FirstOrDefault();
                return result;
            }
        }

        public static void UpdateUser(User user)
        {
            using (PayxatEntities1 db = new PayxatEntities1())
            {
                User pref = db.Users.First(c => c.U_ID == user.U_ID);
                pref = user;
                db.SaveChanges();
            }

        }

        public static int RemoveUser(int userId)
        {
            using (PayxatEntities1 db = new PayxatEntities1())
            {
                db.Users.RemoveRange(db.Users.Where(u => u.U_ID == userId));
                return db.SaveChanges();
            }
        }

        public static List<User> GetContactUs(int userId = 0)
        {
            using (PayxatEntities1 db = new PayxatEntities1())
            {
                return db.Users.Where(u => u.U_ID == userId || userId == 0).ToList();
            }
        }


    }
}