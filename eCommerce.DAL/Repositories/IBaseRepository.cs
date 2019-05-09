using eCommerce.DAL.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.DAL.Repositories
{
    public interface IBaseRepository<TEntity>
        where TEntity : class
    {
        TEntity GetById(object Id);
        IQueryable<TEntity> GetAll();
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        void DeleteById(object Id);
    }
}
