using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodeFirst.Models.Repository;

namespace CodeFirst.Models.DataManager
{
    public class CartManager : ICartDataRepository<Cart>
    {
        readonly CartContext _cartContext;

        public CartManager(CartContext context)
        {
            _cartContext = context;
        }

        public void Add(Cart entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Cart cart)
        {
            throw new NotImplementedException();
        }

        public Cart Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cart> GetAll()
        {
            return _cartContext.Carts.ToList();
        }

        public void Update(Cart cart, Cart entity)
        {
            
            cart.Description = entity.Description;
            cart.CreatedDate = entity.CreatedDate;

            _cartContext.SaveChanges();
        }
    }
}
