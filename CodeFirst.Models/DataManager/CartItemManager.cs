using System.Collections.Generic;
using System.Linq;
using CodeFirst.Models.Repository;

namespace CodeFirst.Models.DataManager
{
    public class CartItemManager : ICartItemDataRepository<CartItem>
    {
        readonly CartItemContext _cartItemContext;

        public CartItemManager(CartItemContext context)
        {
            _cartItemContext = context;
        }

        public void Add(CartItem entity)
        {
            _cartItemContext.CartItems.Add(entity);
            _cartItemContext.SaveChanges();
        }

        public void Delete(CartItem cartItem)
        {
            _cartItemContext.CartItems.Remove(cartItem);
            _cartItemContext.SaveChanges();
        }

        public CartItem Get(int id)
        {
            return _cartItemContext.CartItems
                  .FirstOrDefault(e => e.Id == id);
        }

        public IEnumerable<CartItem> GetAll()
        {
            return _cartItemContext.CartItems.ToList();
        }

        public void Update(CartItem cartItem, CartItem entity)
        {
            cartItem.Name = entity.Name;
            cartItem.Description = entity.Description;
            cartItem.Calories = entity.Calories;
            cartItem.Fats = entity.Fats;
            cartItem.Proteins = entity.Proteins;
            cartItem.Sacharides = entity.Sacharides;
            cartItem.PurchaseDate = entity.PurchaseDate;
            cartItem.ExpirationDate = entity.ExpirationDate;
           
            _cartItemContext.SaveChanges();
        }
    }
}
