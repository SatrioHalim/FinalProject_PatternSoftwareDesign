using FinalProject_PSD_EmpatSekawan.Handler;
using FinalProject_PSD_EmpatSekawan.Model;
using System.Collections.Generic;

namespace FinalProject_PSD_EmpatSekawan.Controller
{
    public class CartController
    {
        private CartHandler cartHandler = new CartHandler();

        public List<Cart> GetAllCarts()
        {
            return cartHandler.GetAllCarts();
        }

        //public Cart GetCartById(int id)
        //{
        //    return cartHandler.GetCartById(id);
        //}

        public void AddCart(Cart cart)
        {
            cartHandler.AddCart(cart);
        }

        public void UpdateCart(Cart cart)
        {
            cartHandler.UpdateCart(cart);
        }
    }
}
