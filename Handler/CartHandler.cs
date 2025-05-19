using FinalProject_PSD_EmpatSekawan.Model;
using FinalProject_PSD_EmpatSekawan.Repository;
using System.Collections.Generic;

namespace FinalProject_PSD_EmpatSekawan.Handler
{
    public class CartHandler
    {
        private CartRepository cartRepository = new CartRepository();

        public List<Cart> GetAllCarts()
        {
            return cartRepository.All();
        }

        //public Cart GetCartById(int id)
        //{
        //    return cartRepository.GetCartById(id);
        //}

        public void AddCart(Cart cart)
        {
            cartRepository.AddCart(cart);
        }

        public void UpdateCart(Cart cart)
        {
            cartRepository.UpdateCart(cart);
        }

        public void DeleteCart(Cart cart)
        {
            cartRepository.DeleteCart(cart);
        }
    }
}
