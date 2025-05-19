using FinalProject_PSD_EmpatSekawan.Factory;
using FinalProject_PSD_EmpatSekawan.Model.MsUser;
using System.Data.Entity;

namespace FinalProject_PSD_EmpatSekawan.Repository
{
    public class UserRepository
    {

        private Database1Entities1 db = DatabaseSingleton.GetInstance();

        public UserRepository() { }

        public User GetUserByEmail(string email)
        {
            return db.MsUsers.FirstOrDefault(u => u.UserEmail == email);
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
