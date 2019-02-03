using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirst.Models.Repository
{

    public interface ICartItemDataRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(int id);
        void Add(TEntity entity);
        void Update(CartItem cartItem, TEntity entity);
        void Delete(CartItem cartItem);
    }
}
