using FinalProject_PSD_EmpatSekawan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject_PSD_EmpatSekawan.Repository
{
    public class DatabaseSingleton
    {

        private static Database1Entities1 db;
        public DatabaseSingleton()
        {
        }

        public static Database1Entities1 GetInstance()
        {
            if(db == null)
            {
                db = new Database1Entities1();
            }
            return db;
        }
    }
}