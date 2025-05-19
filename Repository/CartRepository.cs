using FinalProject_PSD_EmpatSekawan.Model;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace FinalProject_PSD_EmpatSekawan.Repository
{
    public class CartRepository
    {
        private Database1Entities1 db = DatabaseSingleton.GetInstance();
        public CartRepository() { }

        public List<Cart> All()
        {
            return db.Carts.ToList();
        }

        public void AddCart(Cart cart)
        {
            db.Carts.Add(cart);
            db.SaveChanges();
        }

        public void UpdateCart(Cart cart)
        {
            db.Entry(cart).State = EntityState.Modified;
        }

        public void DeleteCart(Cart cart)
        {
            db.Carts.Remove(cart);
            db.SaveChanges();
        }
    }
}
