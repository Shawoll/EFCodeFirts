using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirst.Models.Repository
{
    public interface ICartDataRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(int id);
        void Add(TEntity entity);
        void Update(Cart cart, TEntity entity);
        void Delete(Cart cart);
    }
}
