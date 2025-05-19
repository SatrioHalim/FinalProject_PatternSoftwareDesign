using FinalProject_PSD_EmpatSekawan.Model;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace FinalProject_PSD_EmpatSekawan.Repository
{
    public class JewelRepository
    {
        private Database1Entities1 db = DatabaseSingleton.GetInstance();

        public JewelRepository() { }

        public List<MsJewel> All()
        {
            return db.MsJewels.ToList();
        }

        public MsJewel GetJewelById(int id)
        {
            foreach (MsJewel jewel in All())
            {
                if (jewel.JewelID == id) return jewel;
            }
            return null;
        }

        public void AddJewel(MsJewel jewel)
        {
            db.MsJewels.Add(jewel);
            db.SaveChanges();
        }

        public void UpdateJewel(MsJewel jewel)
        {
            db.Entry(jewel).State = EntityState.Modified;
        }

        public void DeleteJewel(MsJewel jewel)
        {
            db.MsJewels.Remove(jewel);
            db.SaveChanges();
        }
    }
}