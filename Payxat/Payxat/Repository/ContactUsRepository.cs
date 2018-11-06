using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Payxat.Repository.DataObject;

namespace NewAeonTech.Repository
{
    public class ContactUsRepository
    {

        public static void AddContactUs(ref ContactU contactUs)
        {
            using (PayxatEntities1 db = new PayxatEntities1())
            {
                db.ContactUs.Add(contactUs);
                db.SaveChanges();

            }

        }


        public static void UpdateContactUs(ContactU contactUs)
        {
            using (PayxatEntities1 db = new PayxatEntities1())
            {
                ContactU pref = db.ContactUs.First(c => c.c_ID == contactUs.c_ID);
                pref = contactUs;
                db.SaveChanges();
            }

        }

        public static int RemoveContactUs(int contactUsId)
        {
            using (PayxatEntities1 db = new PayxatEntities1())
            {
                db.ContactUs.RemoveRange(db.ContactUs.Where(c => c.c_ID == contactUsId));


                return db.SaveChanges();
            }
        }

        public static List<ContactU> GetContactUs(int contactUsId = 0)
        {
            using (PayxatEntities1 db = new PayxatEntities1())
            {
                return db.ContactUs.Where(c => c.c_ID== contactUsId || contactUsId == 0).ToList();
            }
        }



    }
}