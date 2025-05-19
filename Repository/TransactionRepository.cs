using FinalProject_PSD_EmpatSekawan.Model;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace FinalProject_PSD_EmpatSekawan.Repository
{
    public class TransactionRepository
    {
        private Database1Entities1 db = DatabaseSingleton.GetInstance();
        public TransactionRepository() { }

        public List<TransactionHeader> All()
        {
            return db.TransactionHeaders.ToList();
        }

        public TransactionHeader GetTransactionById(int id)
        {
            foreach (TransactionHeader transaction in All())
            {
                if (transaction.TransactionID == id) return transaction;
            }
            return null;
        }

        public void AddTransaction(TransactionHeader transaction)
        {
            db.TransactionHeaders.Add(transaction);
            db.SaveChanges();
        }

        public void UpdateTransaction(TransactionHeader transaction)
        {
            db.Entry(transaction).State = EntityState.Modified;
        }

        public void DeleteTransaction(TransactionHeader transaction)
        {
            db.TransactionHeaders.Remove(transaction);
            db.SaveChanges();
        }
    }
}
