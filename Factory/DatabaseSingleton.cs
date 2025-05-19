using FinalProject_PSD_EmpatSekawan.Model;
using System.Data.Entity;

namespace FinalProject_PSD_EmpatSekawan.Factory
{
    public class DatabaseSingleton
    {
        private static Database1Entities1 db;
        private DatabaseSingleton() { }

        public static Database1Entities1 GetInstance()
        {
            if (db == null)
            {
                db = new Database1Entities1();
            }
            return db;
        }
    }
}
