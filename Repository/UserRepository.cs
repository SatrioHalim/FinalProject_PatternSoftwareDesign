using FinalProject_PSD_EmpatSekawan.Model;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace FinalProject_PSD_EmpatSekawan.Repository
{
    public class UserRepository
    {

        private Database1Entities1 db = DatabaseSingleton.GetInstance();

        public UserRepository() { }

        public List<MsUser> all()
        {
            return db.MsUsers.ToList();
        }

        public MsUser GetUserByEmail(string email)
        {
            foreach(MsUser user in all())
            {
                if(user.UserEmail == email) return user;
            }
            return null;
        }

        public bool RegisterUser(MsUser user)
        {


            if (GetUserByEmail(user.UserEmail) == null)
            {
                db.MsUsers.Add(user);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public void UpdateUser(MsUser user)
        {
            db.Entry(user).State = EntityState.Modified;
            db.SaveChanges();
        }


    }
}
